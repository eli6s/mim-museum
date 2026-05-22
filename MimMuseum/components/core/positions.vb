Public Class positions
    Private ReadOnly db_obj As New db_controller()
    Private Const select_sql As String = "SELECT position_title FROM positions"


    Private Sub positions_load(sender As Object, e As EventArgs) Handles MyBase.Load
        setup_grid()
        run_search()
    End Sub


    Private Sub setup_grid()
        positions_grid.AutoGenerateColumns = False
        positions_grid.Columns.Clear()

        Dim cols As New Dictionary(Of String, Object()) From {
            {"row_number", {"#", 40}},
            {"position_title", {"Position", 250}}
        }

        For Each col In cols
            add_column(positions_grid, col.Key, col.Value(0), col.Value(1))
        Next

        positions_grid.Columns("row_number").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
    End Sub


    Private Sub run_search()
        Dim term = search_input.Text.Trim()
        Dim sql As String
        Dim params As New Dictionary(Of String, Object)

        If String.IsNullOrEmpty(term) Then
            sql = select_sql & " ORDER BY position_title"
        Else
            sql = select_sql &
                " WHERE
                    position_title LIKE @term OR
                    CAST(position_id AS NVARCHAR(10)) LIKE @term
                 ORDER BY position_title"
            params("term") = "%" & term & "%"
        End If

        Try
            positions_grid.DataSource = db_obj.fetch_datatable(sql, params)
        Catch ex As Exception
            Vip.Notification.Alert.ShowError($"Search error: {ex.Message}")
        End Try
    End Sub


    Private Sub search_input_content_changed(sender As Object, e As EventArgs) Handles search_input.ContentChanged
        run_search()
    End Sub


    'DataBindingComplete ensures row numbers are assigned after the grid finishes binding,
    'since DataSource assignment is asynchronous and rows aren't available immediately.
    Private Sub positions_grid_data_binding_complete(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles positions_grid.DataBindingComplete
        populate_row_numbers(positions_grid)
    End Sub


    Private Sub positions_grid_sorted(sender As Object, e As EventArgs) Handles positions_grid.Sorted
        populate_row_numbers(positions_grid)
    End Sub

End Class