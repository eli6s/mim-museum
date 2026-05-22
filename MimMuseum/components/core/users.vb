
' TODO: really make sense of this form

Public Class users
    Private ReadOnly db_obj As New db_controller()
    Private current_mode As FormMode = FormMode.Add
    Private editing_username As String = ""

    ' lookup map: display text → employee_id
    Private employee_map As New Dictionary(Of String, Integer)

    Private Const select_sql As String =
        "SELECT
             u.username,
             e.employee_id,
             e.first_name,
             e.last_name,
             u.created_at,
             u.last_login
         FROM users u
         INNER JOIN employees e ON u.employee_id = e.employee_id
         INNER JOIN positions p ON e.position_id = p.position_id
         WHERE u.username <> @current_user AND p.position_title <> 'manager'
        "


    Private Sub users_load(sender As Object, e As EventArgs) Handles MyBase.Load
        style_tabs(tbc)
        setup_grid()
        set_mode(FormMode.Add)
        run_search()
    End Sub


    Private Sub setup_grid()
        users_grid.AutoGenerateColumns = False
        users_grid.Columns.Clear()

        Dim cols As New Dictionary(Of String, Object()) From {
            {"row_number", {"#", 40}},
            {"username", {"Username", 180}},
            {"employee_id", {"Emp. ID", 80}},
            {"first_name", {"First Name", 150}},
            {"last_name", {"Last Name", 150}},
            {"created_at", {"Created At", 150}},
            {"last_login", {"Last Login", 150}}
        }

        For Each col In cols
            add_column(users_grid, col.Key, col.Value(0), col.Value(1))
        Next

        users_grid.Columns("row_number").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
    End Sub


    'active employees who don't already have a user account
    Private Sub load_lookups()
        load_combo(
            employee_input,
            employee_map,
            "
            SELECT e.employee_id, e.first_name + ' ' + e.last_name AS full_name
            FROM employees e
            WHERE e.is_active = 1
            AND NOT EXISTS (
                SELECT 1 FROM users u WHERE u.employee_id = e.employee_id
                )
            ORDER BY full_name",
            "employee_id",
            "full_name"
            )
    End Sub


    Private Sub set_mode(new_mode As FormMode)
        current_mode = new_mode

        Select Case current_mode
            Case FormMode.Add
                confirm_btn.Text = "Add"
                mode_lbl.Content = "Mode: ADD"
                mode_lbl.ForeColor = Color.FromArgb(98, 252, 170)
                ' show employee combo, hide reset button
                employee_lbl.Visible = True
                employee_input.Visible = True
                confirm_btn.Visible = True
                reset_pass_btn.Visible = False

            Case FormMode.Edit
                confirm_btn.Text = "Update"
                mode_lbl.Content = "Mode: EDIT"
                mode_lbl.ForeColor = Color.FromArgb(255, 170, 0)
                ' hide employee combo, show reset button
                employee_lbl.Visible = False
                employee_input.Visible = False
                confirm_btn.Visible = False
                reset_pass_btn.Visible = True
        End Select
    End Sub


    Private Sub run_search()
        Dim term = search_input.Text.Trim()

        Dim sql As String
        Dim params As New Dictionary(Of String, Object)
        params("current_user") = session_manager.user_name

        If String.IsNullOrEmpty(term) Then
            sql = select_sql & " ORDER BY u.username"
        Else
            sql = select_sql &
                "
                AND (
                    u.username    LIKE @term OR
                    e.first_name  LIKE @term OR
                    e.last_name   LIKE @term OR
                    CAST(e.employee_id AS NVARCHAR(20)) LIKE @term OR
                    CAST(u.created_at  AS NVARCHAR(30)) LIKE @term OR
                    FORMAT(u.created_at, 'MMM d, yyyy') LIKE @term OR
                    (u.last_login IS NOT NULL AND FORMAT(u.last_login, 'MMM d, yyyy') LIKE @term)
                )
                ORDER BY u.username
                "
            params("term") = "%" & term & "%"
        End If

        Try
            users_grid.DataSource = db_obj.fetch_datatable(sql, params)
        Catch ex As Exception
            Vip.Notification.Alert.ShowError($"Search error: {ex.Message}")
        End Try
    End Sub


    Private Sub do_insert()
        Dim err = validate_inputs()
        If err IsNot Nothing Then
            Vip.Notification.Alert.ShowWarning(err)
            Return
        End If

        Dim plain_pass = generate_plain_password()
        Dim pass_hash = generate_password_hash(plain_pass)
        Dim username = username_input.Text.Trim()
        Dim emp_id = get_combo_id(employee_input, employee_map)

        ' Resolve the employee email so we can send credentials
        Dim emp_email As String = ""

        Try
            Dim email_result = db_obj.fetch(
                        "
                        SELECT email
                        FROM employees
                        WHERE employee_id = @employee_id
                        ", New Dictionary(Of String, Object) From {{"employee_id", emp_id}}
                        )

            If email_result.Count > 0 Then
                emp_email = email_result(0)("email").ToString()
            End If
        Catch ex As Exception
            Vip.Notification.Alert.ShowWarning($"Could not retrieve employee email: {ex.Message}")
        End Try

        Try
            db_obj.execute(
                "
                INSERT INTO users (username, password_hash, employee_id)
                VALUES (@username, @password_hash, @employee_id)
                ",
                New Dictionary(Of String, Object) From {
                    {"username", username},
                    {"password_hash", pass_hash},
                    {"employee_id", emp_id}
                }
            )

            If Not String.IsNullOrEmpty(emp_email) Then
                send_email(
                    emp_email,
                    "Your MIM Museum System Account",
                    $"Hello," & Environment.NewLine & Environment.NewLine &
                    $"Your account has been created." & Environment.NewLine &
                    $"Username: {username}" & Environment.NewLine &
                    $"Password: {plain_pass}" & Environment.NewLine & Environment.NewLine &
                    "We recommend you change your password after your first login."
                )
            End If

            Vip.Notification.Alert.ShowSucess($"User '{username}' created successfully.")
            clear_inputs()
            go_to_browse()
            run_search()

        Catch ex As Exception
            Vip.Notification.Alert.ShowError($"Insert error: {ex.Message}")
        End Try
    End Sub


    Private Async Sub do_reset_password()
        Dim confirm = Await delete_confirmation.ShowDialog(
                                main,
                                $"Reset password for '{editing_username}'? A new password will be emailed to them.",
                                "Confirm password reset",
                                MessageBoxButtons.YesNo
                                )

        If confirm <> DialogResult.Yes Then Return

        ' Resolve employee email
        Dim emp_email As String = ""
        Try
            Dim email_result = db_obj.fetch(
                "SELECT e.email FROM employees e
                 INNER JOIN users u ON u.employee_id = e.employee_id
                 WHERE u.username = @username",
                New Dictionary(Of String, Object) From {{"username", editing_username}}
            )
            If email_result.Count > 0 Then
                emp_email = email_result(0)("email").ToString()
            End If
        Catch ex As Exception
            Vip.Notification.Alert.ShowWarning($"Could not retrieve employee email: {ex.Message}")
            Return
        End Try

        Dim plain_pass = generate_plain_password()
        Dim pass_hash = generate_password_hash(plain_pass)

        Try
            db_obj.execute(
                "
                UPDATE users
                SET password_hash = @password_hash
                WHERE username    = @username
                ",
                New Dictionary(Of String, Object) From {
                    {"password_hash", pass_hash},
                    {"username", editing_username}
                }
            )

            If Not String.IsNullOrEmpty(emp_email) Then
                send_email(
                    emp_email,
                    "Your Password Has Been Reset",
                    $"Hello," & Environment.NewLine & Environment.NewLine &
                    $"Your password has been reset by an administrator." & Environment.NewLine &
                    $"Username: {editing_username}" & Environment.NewLine &
                    $"New Password: {plain_pass}"
                    )
            End If

            Vip.Notification.Alert.ShowSucess($"Password reset for '{editing_username}'.")
            clear_inputs()
            go_to_browse()
            run_search()

        Catch ex As Exception
            Vip.Notification.Alert.ShowError($"Password reset error: {ex.Message}")
        End Try
    End Sub


    ' Auto-generate username when employee is selected (add mode only).
    ' Uses a DB fetch to safely handle edge-case names (middle names, hyphenated, etc.)
    Private Sub employee_input_selected_index_changed(sender As Object, e As EventArgs) Handles employee_input.SelectedIndexChanged
        If current_mode <> FormMode.Add Then Return

        Dim emp_id = get_combo_id(employee_input, employee_map)
        If emp_id = 0 Then
            username_input.Text = ""
            Return
        End If

        Try
            Dim rows = db_obj.fetch(
                "SELECT first_name, last_name FROM employees WHERE employee_id = @employee_id",
                New Dictionary(Of String, Object) From {{"employee_id", emp_id}}
            )

            If rows.Count > 0 Then
                Dim first = rows(0)("first_name").ToString()
                Dim last = rows(0)("last_name").ToString()
                username_input.Text = generate_username(first, last, emp_id)
            End If
        Catch ex As Exception
            username_input.Text = ""
        End Try
    End Sub


    Private Sub search_input_content_changed(sender As Object, e As EventArgs) Handles search_input.ContentChanged
        run_search()
    End Sub


    Private Sub tab_control_selected_index_changed(sender As Object, e As EventArgs) Handles tbc.SelectedIndexChanged
        If tbc.SelectedIndex = 1 AndAlso current_mode = FormMode.Edit Then
            clear_inputs()
            set_mode(FormMode.Add)
        End If

        ' Skip clear + load when a double-click is driving the navigation —
        ' editing_username being set is the signal that we're mid-population.
        If tbc.SelectedIndex = 1 AndAlso String.IsNullOrEmpty(editing_username) Then
            clear_inputs()
            load_lookups()
        End If
    End Sub


    ' DataBindingComplete ensures row numbers are assigned after the grid finishes binding,
    ' since DataSource assignment is asynchronous and rows aren't available immediately.
    Private Sub users_grid_data_binding_complete(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles users_grid.DataBindingComplete
        populate_row_numbers(users_grid)
    End Sub


    Private Sub users_grid_sorted(sender As Object, e As EventArgs) Handles users_grid.Sorted
        populate_row_numbers(users_grid)
    End Sub


    Private Async Sub users_grid_key_down(sender As Object, e As KeyEventArgs) Handles users_grid.KeyDown
        If e.KeyCode <> Keys.Delete Then Return
        If users_grid.SelectedRows.Count = 0 Then Return

        Dim selected_username = users_grid.SelectedRows(0).Cells("username").Value?.ToString()
        If String.IsNullOrEmpty(selected_username) Then Return

        Dim confirm = Await delete_confirmation.ShowDialog(
                                main,
                                $"Delete user '{selected_username}'? This cannot be undone.",
                                "Confirm Delete",
                                MessageBoxButtons.YesNo
                                )

        If confirm <> DialogResult.Yes Then Return

        Try
            db_obj.execute(
                "DELETE FROM users WHERE username = @username",
                New Dictionary(Of String, Object) From {{"username", selected_username}}
            )
            run_search()
            Vip.Notification.Alert.ShowSucess($"Deleted user '{selected_username}'.")
        Catch ex As Exception
            Vip.Notification.Alert.ShowError($"Delete error: {ex.Message}")
        End Try
    End Sub


    Private Sub users_grid_cell_double_click(sender As Object, e As DataGridViewCellEventArgs) Handles users_grid.CellDoubleClick
        If e.RowIndex < 0 Then Return

        Dim row = users_grid.Rows(e.RowIndex)

        ' Set editing_username BEFORE go_to_manage so tab_control_selected_index_changed
        ' sees it and skips clear_inputs + load_lookups
        editing_username = row.Cells("username").Value?.ToString()
        go_to_manage()

        username_input.Text = editing_username
        set_mode(FormMode.Edit)
    End Sub


    Private Sub users_grid_cell_formatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles users_grid.CellFormatting
        If e.RowIndex < 0 Then Return

        Dim col_name = users_grid.Columns(e.ColumnIndex).Name

        If col_name = "created_at" Then
            If e.Value IsNot Nothing AndAlso TypeOf e.Value Is DateTime Then
                e.Value = CDate(e.Value).ToString("MMM d, yyyy")
                e.FormattingApplied = True
            End If
        End If

        If col_name = "last_login" Then
            If e.Value Is Nothing OrElse IsDBNull(e.Value) Then
                e.Value = ""
                e.FormattingApplied = True
            ElseIf TypeOf e.Value Is DateTime Then
                e.Value = CDate(e.Value).ToString("MMM d, yyyy")
                e.FormattingApplied = True
            End If
        End If
    End Sub


    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, key_data As Keys) As Boolean
        If key_data = Keys.Escape AndAlso tbc.SelectedIndex = 1 Then
            cancel_btn_click(Nothing, EventArgs.Empty)
            Return True
        End If
        Return MyBase.ProcessCmdKey(msg, key_data)
    End Function


    Private Sub confirm_btn_click(sender As Object, e As EventArgs) Handles confirm_btn.Click
        Select Case current_mode
            Case FormMode.Add
                do_insert()
            Case FormMode.Edit
                ' Nothing to confirm in edit mode — password reset is handled by reset_pass_btn
        End Select
    End Sub


    Private Sub reset_pass_btn_click(sender As Object, e As EventArgs) Handles reset_pass_btn.Click
        do_reset_password()
    End Sub


    Private Sub cancel_btn_click(sender As Object, e As EventArgs) Handles cancel_btn.Click
        clear_inputs()
        set_mode(FormMode.Add)
        go_to_browse()
    End Sub


    Private Sub go_to_browse()
        tbc.SelectedIndex = 0
    End Sub


    Private Sub go_to_manage()
        tbc.SelectedIndex = 1
    End Sub


    Private Sub clear_inputs()
        username_input.Text = ""
        employee_input.SelectedIndex = -1
        editing_username = ""
    End Sub


    Private Function validate_inputs() As String
        If current_mode = FormMode.Add Then
            If get_combo_id(employee_input, employee_map) = 0 Then Return "Please select an employee."
            If String.IsNullOrWhiteSpace(username_input.Text) Then Return "Username could not be generated. Please select an employee."
            If Not valid_username(username_input.Text) Then Return "Generated username is invalid. Please check the employee's name."
        End If

        Return Nothing
    End Function

End Class