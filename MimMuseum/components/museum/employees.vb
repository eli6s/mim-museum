''' <summary>
''' shared employees form. set building_filter before load to choose which
''' employees to display. "museum" → manager+assistant, "boutique" → cashier.
''' the host user control passes the right string in.
''' </summary>
Public Class museum_employees
    Private ReadOnly db_obj As New db_controller()
    Private current_mode As FormMode = FormMode.Add
    Private editing_id As Integer = 0

    'building tag — museum employees are anyone non-cashier, boutique are cashiers
    Public Property building_filter As String = "museum"

    'maps display text to the position id so we can save back to the db
    Private position_map As New Dictionary(Of String, Integer)

    'allowed gender values, kept as a constant to match the schema check constraint
    Private ReadOnly gender_values As String() = {"female", "male"}


    'we filter by position depending on the building
    'museum side → manager + assistant
    'boutique side → cashier
    Private ReadOnly Property select_sql As String
        Get
            Dim position_filter As String = If(building_filter = "boutique",
                                              "p.position_title = 'cashier'",
                                              "p.position_title IN ('manager', 'assistant')")

            Return $"SELECT
                        e.employee_id,
                        e.first_name,
                        e.last_name,
                        e.gender,
                        e.date_of_birth,
                        e.hire_date,
                        e.email,
                        e.phone_num,
                        e.home_addr,
                        e.monthly_salary,
                        p.position_title,
                        e.is_active
                     FROM employees e
                     INNER JOIN positions p ON e.position_id = p.position_id
                     WHERE {position_filter}
                     AND e.employee_id <> {session_manager.employee_id}
                    "
        End Get
    End Property


    Private Sub museum_employees_load(sender As Object, e As EventArgs) Handles MyBase.Load
        style_tabs(tbc)
        setup_grid()
        load_lookups()
        set_mode(FormMode.Add)
        run_search()
    End Sub


    Private Sub setup_grid()
        employees_grid.AutoGenerateColumns = False
        employees_grid.Columns.Clear()

        Dim cols As New Dictionary(Of String, Object()) From {
            {"row_number", {"#", 40}},
            {"employee_id", {"ID", 70}},
            {"first_name", {"First Name", 130}},
            {"last_name", {"Last Name", 130}},
            {"gender", {"Gender", 80}},
            {"position_title", {"Position", 110}},
            {"date_of_birth", {"DOB", 110}},
            {"hire_date", {"Hire Date", 110}},
            {"email", {"Email", 200}},
            {"phone_num", {"Phone", 130}},
            {"home_addr", {"Home Address", 200}},
            {"monthly_salary", {"Salary", 110}},
            {"is_active", {"Active", 80}}
        }

        For Each col In cols
            add_column(employees_grid, col.Key, col.Value(0), col.Value(1))
        Next

        employees_grid.Columns("row_number").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
    End Sub


    'load the position dropdown — different positions depending on the building
    'managers cannot hire other managers, only assistants
    'boutique side can only hire cashiers
    Private Sub load_lookups()
        Dim position_sql As String

        If building_filter = "boutique" Then
            position_sql = "SELECT position_id, position_title FROM positions WHERE position_title = 'cashier'"
        Else
            'museum side: only show assistant (managers cannot hire other managers)
            position_sql = "SELECT position_id, position_title FROM positions WHERE position_title = 'assistant'"
        End If

        load_combo(position_input, position_map, position_sql, "position_id", "position_title")
    End Sub


    'when position changes, auto-populate the salary based on the constant and disable the input
    Private Sub position_input_selected_index_changed(sender As Object, e As EventArgs) Handles position_input.SelectedIndexChanged
        If position_input.SelectedItem Is Nothing Then Return

        Dim position_title = position_input.SelectedItem.ToString()

        Select Case position_title.ToLower()
            Case "manager"
                salary_input.Text = config.MANAGER_SALARY.ToString("F2")
            Case "assistant"
                salary_input.Text = config.ASSISTANT_SALARY.ToString("F2")
            Case "cashier"
                salary_input.Text = config.CASHIER_SALARY.ToString("F2")
        End Select

        salary_input.Enabled = False
    End Sub


    Private Sub set_mode(new_mode As FormMode)
        current_mode = new_mode

        Select Case current_mode
            Case FormMode.Add
                confirm_btn.Text = "Add"
                mode_lbl.Content = "Mode: ADD"
                mode_lbl.ForeColor = Color.FromArgb(98, 252, 170)

                'in add mode, all fields except salary are editable
                first_name_input.Enabled = True
                last_name_input.Enabled = True
                input_female.Enabled = True
                input_male.Enabled = True
                dob_input.Enabled = True
                hire_date_input.Enabled = True
                position_input.Enabled = True
                salary_input.Enabled = False 'always disabled, auto-filled by position

            Case FormMode.Edit
                confirm_btn.Text = "Update"
                mode_lbl.Content = "Mode: EDIT"
                mode_lbl.ForeColor = Color.FromArgb(255, 170, 0)

                'in edit mode, only contact info is editable
                first_name_input.Enabled = False
                last_name_input.Enabled = False
                input_female.Enabled = False
                input_male.Enabled = False
                dob_input.Enabled = False
                hire_date_input.Enabled = False
                position_input.Enabled = False
                salary_input.Enabled = False
        End Select
    End Sub


    Private Sub run_search()
        Dim term = search_input.Text.Trim()
        Dim sql As String
        Dim params As New Dictionary(Of String, Object)

        If String.IsNullOrEmpty(term) Then
            sql = select_sql & " ORDER BY e.last_name, e.first_name"
        Else
            sql = select_sql &
                "
                AND (
                    e.first_name   LIKE @term OR
                    e.last_name    LIKE @term OR
                    e.email        LIKE @term OR
                    e.phone_num    LIKE @term OR
                    e.home_addr    LIKE @term OR
                    p.position_title LIKE @term OR
                    CAST(e.employee_id AS NVARCHAR(20)) LIKE @term OR
                    CAST(e.monthly_salary AS NVARCHAR(20)) LIKE @term OR
                    FORMAT(e.hire_date, 'MMM d, yyyy') LIKE @term OR
                    FORMAT(e.date_of_birth, 'MMM d, yyyy') LIKE @term
                )
                ORDER BY e.last_name, e.first_name
                "
            params("term") = "%" & term & "%"
        End If

        Try
            employees_grid.DataSource = db_obj.fetch_datatable(sql, params)
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

        Try
            db_obj.execute(
                "
                INSERT INTO employees
                    (first_name, last_name, gender, date_of_birth, hire_date,
                     email, phone_num, home_addr, monthly_salary, position_id, is_active)
                VALUES
                    (@first_name, @last_name, @gender, @date_of_birth, @hire_date,
                     @email, @phone_num, @home_addr, @monthly_salary, @position_id, 1)
                ", build_params())

            Dim full_name = $"{first_name_input.Text.Trim()} {last_name_input.Text.Trim()}"
            clear_inputs()
            go_to_browse()
            run_search()
            Vip.Notification.Alert.ShowSucess($"Added employee {full_name}.")
        Catch ex As Exception
            Vip.Notification.Alert.ShowError($"Insert error: {ex.Message}")
        End Try
    End Sub


    Private Sub do_update()
        Dim err = validate_inputs()
        If err IsNot Nothing Then
            Vip.Notification.Alert.ShowWarning(err)
            Return
        End If

        Try
            Dim p = build_params()
            p("employee_id") = editing_id

            db_obj.execute(
                "
                UPDATE employees
                SET first_name      = @first_name,
                    last_name       = @last_name,
                    gender          = @gender,
                    date_of_birth   = @date_of_birth,
                    hire_date       = @hire_date,
                    email           = @email,
                    phone_num       = @phone_num,
                    home_addr       = @home_addr,
                    monthly_salary  = @monthly_salary,
                    position_id     = @position_id
                WHERE employee_id   = @employee_id
                ", p)

            Dim updated_id = editing_id
            clear_inputs()
            go_to_browse()
            run_search()
            Vip.Notification.Alert.ShowSucess($"Updated employee #{updated_id}.")
        Catch ex As Exception
            Vip.Notification.Alert.ShowError($"Update error: {ex.Message}")
        End Try
    End Sub


    Private Sub search_input_content_changed(sender As Object, e As EventArgs) Handles search_input.ContentChanged
        run_search()
    End Sub


    Private Sub tab_control_selected_index_changed(sender As Object, e As EventArgs) Handles tbc.SelectedIndexChanged
        If tbc.SelectedIndex = 0 AndAlso current_mode = FormMode.Edit Then
            clear_inputs()
            set_mode(FormMode.Add)
        End If

        If tbc.SelectedIndex = 1 Then
            load_lookups()
        End If
    End Sub


    Private Sub employees_grid_data_binding_complete(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles employees_grid.DataBindingComplete
        populate_row_numbers(employees_grid)
    End Sub


    Private Sub employees_grid_sorted(sender As Object, e As EventArgs) Handles employees_grid.Sorted
        populate_row_numbers(employees_grid)
    End Sub


    Private Async Sub employees_grid_key_down(sender As Object, e As KeyEventArgs) Handles employees_grid.KeyDown
        If e.KeyCode <> Keys.Delete Then Return
        If employees_grid.SelectedRows.Count = 0 Then Return

        Dim selected_id = CInt(employees_grid.SelectedRows(0).Cells("employee_id").Value)
        Dim full_name = $"{employees_grid.SelectedRows(0).Cells("first_name").Value} {employees_grid.SelectedRows(0).Cells("last_name").Value}"

        Dim confirm = Await delete_confirmation.ShowDialog(
                                main,
                                $"Delete employee '{full_name}'? This cannot be undone.",
                                "Confirm Delete",
                                MessageBoxButtons.YesNo)

        If confirm <> DialogResult.Yes Then Return

        Try
            db_obj.execute(
                "DELETE FROM employees WHERE employee_id = @employee_id",
                New Dictionary(Of String, Object) From {{"employee_id", selected_id}})
            run_search()
            Vip.Notification.Alert.ShowSucess($"Deleted employee {full_name}.")
        Catch ex As Exception
            Vip.Notification.Alert.ShowError($"Delete error: {ex.Message}")
        End Try
    End Sub


    Private Sub employees_grid_cell_double_click(sender As Object, e As DataGridViewCellEventArgs) Handles employees_grid.CellDoubleClick
        If e.RowIndex < 0 Then Return

        Dim row = employees_grid.Rows(e.RowIndex)
        editing_id = CInt(row.Cells("employee_id").Value)

        go_to_manage()

        first_name_input.Text = row.Cells("first_name").Value?.ToString()
        last_name_input.Text = row.Cells("last_name").Value?.ToString()
        email_input.Text = row.Cells("email").Value?.ToString()
        phone_input.Text = row.Cells("phone_num").Value?.ToString()
        home_addr_input.Text = row.Cells("home_addr").Value?.ToString()
        salary_input.Text = row.Cells("monthly_salary").Value?.ToString()
        dob_input.Content = Convert.ToDateTime(row.Cells("date_of_birth").Value)
        hire_date_input.Content = Convert.ToDateTime(row.Cells("hire_date").Value)

        'set gender radio buttons
        Dim gender_val = row.Cells("gender").Value?.ToString()
        If gender_val = "female" Then
            input_female.Checked = True
        Else
            input_male.Checked = True
        End If

        select_combo(position_input, row.Cells("position_title").Value?.ToString())

        set_mode(FormMode.Edit)
    End Sub


    'format dates and salary nicely in the grid
    Private Sub employees_grid_cell_formatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles employees_grid.CellFormatting
        If e.RowIndex < 0 Then Return
        Dim col = employees_grid.Columns(e.ColumnIndex).Name

        If col = "date_of_birth" OrElse col = "hire_date" Then
            If e.Value IsNot Nothing AndAlso TypeOf e.Value Is DateTime Then
                e.Value = CDate(e.Value).ToString("MMM d, yyyy")
                e.FormattingApplied = True
            End If
        End If

        If col = "monthly_salary" AndAlso e.Value IsNot Nothing Then
            e.Value = CDec(e.Value).ToString("C2")
            e.FormattingApplied = True
        End If

        If col = "is_active" AndAlso e.Value IsNot Nothing AndAlso TypeOf e.Value Is Boolean Then
            Dim active = CBool(e.Value)
            e.Value = If(active, "Yes", "No")
            e.CellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            e.FormattingApplied = True
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
                do_update()
        End Select
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


    Private Function build_params() As Dictionary(Of String, Object)
        Return New Dictionary(Of String, Object) From {
            {"first_name", first_name_input.Text.Trim()},
            {"last_name", last_name_input.Text.Trim()},
            {"gender", If(input_female.Checked, "female", "male")},
            {"date_of_birth", dob_input.Content.Date},
            {"hire_date", hire_date_input.Content.Date},
            {"email", email_input.Text.Trim()},
            {"phone_num", phone_input.Text.Trim()},
            {"home_addr", home_addr_input.Text.Trim()},
            {"monthly_salary", CDec(salary_input.Text.Trim())},
            {"position_id", get_combo_id(position_input, position_map)}
        }
    End Function


    Private Sub clear_inputs()
        first_name_input.Text = ""
        last_name_input.Text = ""
        email_input.Text = ""
        phone_input.Text = ""
        home_addr_input.Text = ""
        salary_input.Text = ""
        dob_input.Content = DateTime.Today.AddYears(-25)
        hire_date_input.Content = DateTime.Today
        input_female.Checked = False
        input_male.Checked = False
        position_input.SelectedIndex = -1
        salary_input.Enabled = False 're-disable for next use
        editing_id = 0
    End Sub


    Private Function validate_inputs() As String
        If String.IsNullOrWhiteSpace(first_name_input.Text) Then Return "First name required."
        If String.IsNullOrWhiteSpace(last_name_input.Text) Then Return "Last name required."
        If Not input_female.Checked AndAlso Not input_male.Checked Then Return "Select a gender."
        If dob_input.Content.Date > DateTime.Today.AddYears(-18) Then Return "Employee must be at least 18 years old."
        If hire_date_input.Content.Date > DateTime.Today Then Return "Hire date cannot be in the future."
        If String.IsNullOrWhiteSpace(email_input.Text) Then Return "Email required."
        If Not valid_email(email_input.Text) Then Return "Invalid email format."
        If String.IsNullOrWhiteSpace(phone_input.Text) Then Return "Phone required."
        If Not valid_phone_num(phone_input.Text) Then Return "Invalid phone number format."
        If String.IsNullOrWhiteSpace(home_addr_input.Text) Then Return "Home address required."
        If get_combo_id(position_input, position_map) = 0 Then Return "Select a position."
        'salary is auto-filled by position, no need to validate
        Return Nothing
    End Function

End Class