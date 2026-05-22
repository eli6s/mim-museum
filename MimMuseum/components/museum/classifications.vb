Public Class classifications

    Private ReadOnly db_obj As New db_controller()
    Private current_mode As FormMode = FormMode.Add
    Private editing_id As Integer = 0

    Private Const select_sql As String = "SELECT class_id, class_name FROM classifications"


    Private Sub classifications_load(sender As Object, e As EventArgs) Handles MyBase.Load
        style_tabs(tbc)
        setup_grid()
        set_mode(FormMode.Add)
        run_search()
    End Sub


    Private Sub setup_grid()
        classifications_grid.AutoGenerateColumns = False
        classifications_grid.Columns.Clear()

        Dim cols As New Dictionary(Of String, Object()) From {
            {"row_number", {"#", 40}},
            {"class_name", {"Classification", 300}}
        }

        For Each col In cols
            add_column(classifications_grid, col.Key, col.Value(0), col.Value(1))
        Next

        ' class_id is in the SELECT for CRUD operations but not shown in the grid
        add_column(classifications_grid, "class_id", "ID", 0, False)
        classifications_grid.Columns("row_number").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
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
            sql = select_sql & " ORDER BY class_name"
        Else
            sql = select_sql & " WHERE class_name LIKE @term ORDER BY class_name"
            params("term") = "%" & term & "%"
        End If

        Try
            classifications_grid.DataSource = db_obj.fetch_datatable(sql, params)
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
                INSERT INTO classifications (class_name)
                VALUES (@class_name)
                ",
                New Dictionary(Of String, Object) From {{"class_name", name_input.Text.Trim()}}
            )

            Dim inserted = name_input.Text.Trim()
            clear_inputs()
            go_to_browse()
            run_search()
            Vip.Notification.Alert.ShowSucess($"Added classification '{inserted}'")

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
                UPDATE classifications
                SET class_name = @class_name
                WHERE class_id = @class_id
                ",
                New Dictionary(Of String, Object) From {
                    {"class_name", name_input.Text.Trim()},
                    {"class_id", editing_id}
                }
            )

            clear_inputs()
            set_mode(FormMode.Add)
            go_to_browse()
            run_search()
            Vip.Notification.Alert.ShowSucess("Classification updated")

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
    Private Sub classifications_grid_data_binding_complete(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles classifications_grid.DataBindingComplete
        populate_row_numbers(classifications_grid)
    End Sub


    Private Sub classifications_grid_sorted(sender As Object, e As EventArgs) Handles classifications_grid.Sorted
        populate_row_numbers(classifications_grid)
    End Sub


    Private Async Sub classifications_grid_key_down(sender As Object, e As KeyEventArgs) Handles classifications_grid.KeyDown
        If e.KeyCode <> Keys.Delete Then Return
        If classifications_grid.SelectedRows.Count = 0 Then Return

        Dim selected_id = Convert.ToInt32(classifications_grid.SelectedRows(0).Cells("class_id").Value)
        Dim selected_name = classifications_grid.SelectedRows(0).Cells("class_name").Value?.ToString()

        Dim confirm = Await delete_confirmation.ShowDialog(
            main,
            $"Delete classification '{selected_name}'? This cannot be undone.",
            "Confirm Delete",
            MessageBoxButtons.YesNo
        )
        If confirm <> DialogResult.Yes Then Return

        Try
            db_obj.execute(
                "
                DELETE FROM classifications
                WHERE class_id = @class_id
                ",
                New Dictionary(Of String, Object) From {{"class_id", selected_id}}
            )
            run_search()
            Vip.Notification.Alert.ShowSucess($"Deleted classification '{selected_name}'")
        Catch ex As Exception
            Vip.Notification.Alert.ShowError($"Delete error: {ex.Message}")
        End Try
    End Sub


    Private Sub classifications_grid_cell_double_click(sender As Object, e As DataGridViewCellEventArgs) Handles classifications_grid.CellDoubleClick
        If e.RowIndex < 0 Then Return

        Dim row = classifications_grid.Rows(e.RowIndex)

        go_to_manage()
        editing_id = Convert.ToInt32(row.Cells("class_id").Value)
        name_input.Text = row.Cells("class_name").Value?.ToString()

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
        If String.IsNullOrWhiteSpace(name_input.Text) Then Return "Classification name is required."
        Return Nothing
    End Function

End Class