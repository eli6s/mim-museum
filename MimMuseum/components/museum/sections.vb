Public Class sections

    Private ReadOnly db_obj As New db_controller()
    Private current_mode As FormMode = FormMode.Add
    Private editing_id As Integer = 0

    Private Const select_sql As String = "SELECT section_id, section_name FROM sections"


    Private Sub sections_load(sender As Object, e As EventArgs) Handles MyBase.Load
        style_tabs(tbc)
        setup_grid()
        set_mode(FormMode.Add)
        run_search()
    End Sub


    Private Sub setup_grid()
        sections_grid.AutoGenerateColumns = False
        sections_grid.Columns.Clear()

        Dim cols As New Dictionary(Of String, Object()) From {
            {"row_number", {"#", 40}},
            {"section_name", {"Section", 300}}
        }

        For Each col In cols
            add_column(sections_grid, col.Key, col.Value(0), col.Value(1))
        Next

        ' section_id is in the SELECT for CRUD operations but not shown in the grid
        add_column(sections_grid, "section_id", "ID", 0, False)
        sections_grid.Columns("row_number").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
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
            sql = select_sql & " ORDER BY section_name"
        Else
            sql = select_sql & " WHERE section_name LIKE @term ORDER BY section_name"
            params("term") = "%" & term & "%"
        End If

        Try
            sections_grid.DataSource = db_obj.fetch_datatable(sql, params)
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
                INSERT INTO sections (section_name)
                VALUES (@section_name)
                ",
                New Dictionary(Of String, Object) From {{"section_name", name_input.Text.Trim()}}
            )

            Dim inserted = name_input.Text.Trim()
            clear_inputs()
            go_to_browse()
            run_search()
            Vip.Notification.Alert.ShowSucess($"Added section '{inserted}'")

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
            db_obj.execute(
                "
                UPDATE sections
                SET section_name = @section_name
                WHERE section_id = @section_id
                ",
                New Dictionary(Of String, Object) From {
                    {"section_name", name_input.Text.Trim()},
                    {"section_id", editing_id}
                }
            )

            clear_inputs()
            set_mode(FormMode.Add)
            go_to_browse()
            run_search()
            Vip.Notification.Alert.ShowSucess("Section updated")

        Catch ex As Exception
            Vip.Notification.Alert.ShowError($"Update error: {ex.Message}")
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
    End Sub


    'DataBindingComplete ensures row numbers are assigned after the grid finishes binding,
    'since DataSource assignment is asynchronous and rows aren't available immediately.
    Private Sub sections_grid_data_binding_complete(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles sections_grid.DataBindingComplete
        populate_row_numbers(sections_grid)
    End Sub


    Private Sub sections_grid_sorted(sender As Object, e As EventArgs) Handles sections_grid.Sorted
        populate_row_numbers(sections_grid)
    End Sub


    Private Async Sub sections_grid_key_down(sender As Object, e As KeyEventArgs) Handles sections_grid.KeyDown
        If e.KeyCode <> Keys.Delete Then Return
        If sections_grid.SelectedRows.Count = 0 Then Return

        Dim selected_id = Convert.ToInt32(sections_grid.SelectedRows(0).Cells("section_id").Value)
        Dim selected_name = sections_grid.SelectedRows(0).Cells("section_name").Value?.ToString()

        Dim confirm = Await delete_confirmation.ShowDialog(
            main,
            $"Delete section '{selected_name}'? This cannot be undone.",
            "Confirm Delete",
            MessageBoxButtons.YesNo
        )
        If confirm <> DialogResult.Yes Then Return

        Try
            db_obj.execute(
                "
                DELETE FROM sections
                WHERE section_id = @section_id
                ",
                New Dictionary(Of String, Object) From {{"section_id", selected_id}}
            )
            run_search()
            Vip.Notification.Alert.ShowSucess($"Deleted section '{selected_name}'")
        Catch ex As Exception
            Vip.Notification.Alert.ShowError($"Delete error: {ex.Message}")
        End Try
    End Sub


    Private Sub sections_grid_cell_double_click(sender As Object, e As DataGridViewCellEventArgs) Handles sections_grid.CellDoubleClick
        If e.RowIndex < 0 Then Return

        Dim row = sections_grid.Rows(e.RowIndex)

        go_to_manage()
        editing_id = Convert.ToInt32(row.Cells("section_id").Value)
        name_input.Text = row.Cells("section_name").Value?.ToString()

        set_mode(FormMode.Edit)
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


    Private Sub clear_inputs()
        name_input.Text = ""
        editing_id = 0
    End Sub


    Private Function validate_inputs() As String
        If String.IsNullOrWhiteSpace(name_input.Text) Then Return "Section name is required."
        Return Nothing
    End Function

End Class