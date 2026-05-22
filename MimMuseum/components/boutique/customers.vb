Public Class customers
    Private ReadOnly db_obj As New db_controller()
    Private current_mode As FormMode = FormMode.Add
    Private editing_id As Integer = 0

    Private Const select_sql As String =
        "SELECT
             customer_id,
             first_name,
             last_name,
             gender,
             email,
             phone_num,
             registered_at
         FROM customers
        "

    Private Sub customers_load(sender As Object, e As EventArgs) Handles MyBase.Load
        style_tabs(tbc)
        setup_grid()
        set_mode(FormMode.Add)
        run_search()
    End Sub


    Private Sub setup_grid()
        customers_grid.AutoGenerateColumns = False
        customers_grid.Columns.Clear()

        Dim cols As New Dictionary(Of String, Object()) From {
            {"row_number", {"#", 40}},
            {"customer_id", {"ID", 70}},
            {"first_name", {"First Name", 140}},
            {"last_name", {"Last Name", 140}},
            {"gender", {"Gender", 80}},
            {"email", {"Email", 200}},
            {"phone_num", {"Phone", 130}},
            {"registered_at", {"Registered At", 140}}
        }

        For Each col In cols
            add_column(customers_grid, col.Key, col.Value(0), col.Value(1))
        Next

        customers_grid.Columns("row_number").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
    End Sub


    Private Sub set_mode(new_mode As FormMode)
        current_mode = new_mode

        Select Case current_mode
            Case FormMode.Add
                confirm_btn.Text = "Add"
                mode_lbl.Content = "Mode: ADD"
                mode_lbl.ForeColor = Color.FromArgb(98, 252, 170)
            Case FormMode.Edit
                confirm_btn.Text = "Update"
                mode_lbl.Content = "Mode: EDIT"
                mode_lbl.ForeColor = Color.FromArgb(255, 170, 0)
        End Select
    End Sub


    Private Sub run_search()
        Dim term = search_input.Text.Trim()
        Dim sql As String
        Dim params As New Dictionary(Of String, Object)

        If String.IsNullOrEmpty(term) Then
            sql = select_sql & " ORDER BY last_name, first_name"
        Else
            sql = select_sql &
                "
                WHERE
                    first_name   LIKE @term OR
                    last_name    LIKE @term OR
                    email        LIKE @term OR
                    phone_num    LIKE @term OR
                    CAST(customer_id AS NVARCHAR(20)) LIKE @term OR
                    CAST(registered_at AS NVARCHAR(30)) LIKE @term OR
                    FORMAT(registered_at, 'MMM d, yyyy') LIKE @term
                ORDER BY last_name, first_name
                "
            params("term") = "%" & term & "%"
        End If

        Try
            customers_grid.DataSource = db_obj.fetch_datatable(sql, params)
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
                INSERT INTO customers (first_name, last_name, gender, email, phone_num)
                VALUES (@first_name, @last_name, @gender, @email, @phone_num)
                ", build_params())

            Dim name = $"{first_name_input.Text.Trim()} {last_name_input.Text.Trim()}"
            clear_inputs()
            go_to_browse()
            run_search()
            Vip.Notification.Alert.ShowSucess($"Added customer {name}.")
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
            p("customer_id") = editing_id

            db_obj.execute(
                "
                UPDATE customers
                SET first_name = @first_name,
                    last_name  = @last_name,
                    gender     = @gender,
                    email      = @email,
                    phone_num  = @phone_num
                WHERE customer_id = @customer_id
                ", p)

            Dim updated_id = editing_id
            clear_inputs()
            go_to_browse()
            run_search()
            Vip.Notification.Alert.ShowSucess($"Updated customer #{updated_id}.")

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
    End Sub


    Private Sub customers_grid_data_binding_complete(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles customers_grid.DataBindingComplete
        populate_row_numbers(customers_grid)
    End Sub


    Private Sub customers_grid_sorted(sender As Object, e As EventArgs) Handles customers_grid.Sorted
        populate_row_numbers(customers_grid)
    End Sub


    Private Async Sub customers_grid_key_down(sender As Object, e As KeyEventArgs) Handles customers_grid.KeyDown
        If e.KeyCode <> Keys.Delete Then Return
        If customers_grid.SelectedRows.Count = 0 Then Return

        Dim selected_id = CInt(customers_grid.SelectedRows(0).Cells("customer_id").Value)
        Dim name = $"{customers_grid.SelectedRows(0).Cells("first_name").Value} {customers_grid.SelectedRows(0).Cells("last_name").Value}"

        Dim confirm = Await delete_confirmation.ShowDialog(
                                main,
                                $"Delete customer '{name}'? This cannot be undone.",
                                "Confirm Delete",
                                MessageBoxButtons.YesNo)

        If confirm <> DialogResult.Yes Then Return

        Try
            db_obj.execute(
                "DELETE FROM customers WHERE customer_id = @customer_id",
                New Dictionary(Of String, Object) From {{"customer_id", selected_id}})
            run_search()
            Vip.Notification.Alert.ShowSucess($"Deleted customer {name}.")
        Catch ex As Exception
            Vip.Notification.Alert.ShowError($"Delete error: {ex.Message}")
        End Try
    End Sub


    Private Sub customers_grid_cell_double_click(sender As Object, e As DataGridViewCellEventArgs) Handles customers_grid.CellDoubleClick
        If e.RowIndex < 0 Then Return

        Dim row = customers_grid.Rows(e.RowIndex)
        editing_id = CInt(row.Cells("customer_id").Value)

        go_to_manage()

        first_name_input.Text = row.Cells("first_name").Value?.ToString()
        last_name_input.Text = row.Cells("last_name").Value?.ToString()
        phone_input.Text = row.Cells("phone_num").Value?.ToString()

        Dim email_val = row.Cells("email").Value
        email_input.Text = If(IsDBNull(email_val), "", email_val?.ToString())

        Dim g = row.Cells("gender").Value?.ToString()
        radio_female.Checked = (g = "female")
        radio_male.Checked = (g = "male")

        set_mode(FormMode.Edit)
    End Sub


    Private Sub customers_grid_cell_formatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles customers_grid.CellFormatting
        If e.RowIndex < 0 Then Return
        If customers_grid.Columns(e.ColumnIndex).Name = "registered_at" Then
            If e.Value IsNot Nothing AndAlso TypeOf e.Value Is DateTime Then
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
            Case FormMode.Add : do_insert()
            Case FormMode.Edit : do_update()
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
        Dim email_val As Object = If(String.IsNullOrWhiteSpace(email_input.Text), CObj(DBNull.Value), CObj(email_input.Text.Trim()))
        Return New Dictionary(Of String, Object) From {
            {"first_name", first_name_input.Text.Trim()},
            {"last_name", last_name_input.Text.Trim()},
            {"gender", If(radio_female.Checked, "female", "male")},
            {"email", email_val},
            {"phone_num", phone_input.Text.Trim()}
        }
    End Function


    Private Sub clear_inputs()
        first_name_input.Text = ""
        last_name_input.Text = ""
        email_input.Text = ""
        phone_input.Text = ""
        radio_female.Checked = False
        radio_male.Checked = False
        editing_id = 0
    End Sub


    Private Function validate_inputs() As String
        If String.IsNullOrWhiteSpace(first_name_input.Text) Then Return "First name required."
        If String.IsNullOrWhiteSpace(last_name_input.Text) Then Return "Last name required."
        If Not radio_female.Checked AndAlso Not radio_male.Checked Then Return "Select a gender."
        If String.IsNullOrWhiteSpace(phone_input.Text) Then Return "Phone number required."
        If Not valid_phone_num(phone_input.Text) Then Return "Invalid phone number format."
        If Not String.IsNullOrWhiteSpace(email_input.Text) AndAlso Not valid_email(email_input.Text) Then Return "Invalid email format."
        Return Nothing
    End Function

End Class
