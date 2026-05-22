Public Class countries
    Private ReadOnly db_obj As New db_controller()
    Private Const select_sql As String = "SELECT country_name FROM countries"


    Private Sub countries_load(sender As Object, e As EventArgs) Handles MyBase.Load
        setup_grid()
        run_search()
    End Sub


    Private Sub setup_grid()
        countries_grid.AutoGenerateColumns = False
        countries_grid.Columns.Clear()

        Dim cols As New Dictionary(Of String, Object()) From {
            {"row_number", {"#", 40}},
            {"country_name", {"Country", 250}}
        }

        For Each col In cols
            add_column(countries_grid, col.Key, col.Value(0), col.Value(1))
        Next

        countries_grid.Columns("row_number").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
    End Sub


    Private Sub run_search()
        Dim term = search_input.Text.Trim()
        Dim sql As String
        Dim params As New Dictionary(Of String, Object)

        If String.IsNullOrEmpty(term) Then
            sql = select_sql & " ORDER BY country_name"
        Else
            sql = select_sql &
                " WHERE
                    country_name LIKE @term OR
                    CAST(country_id AS NVARCHAR(10)) LIKE @term
                 ORDER BY country_name"
            params("term") = "%" & term & "%"
        End If

        Try
            countries_grid.DataSource = db_obj.fetch_datatable(sql, params)
        Catch ex As Exception
            Vip.Notification.Alert.ShowError($"Search error: {ex.Message}")
        End Try
    End Sub


    Private Sub search_input_content_changed(sender As Object, e As EventArgs) Handles search_input.ContentChanged
        run_search()
    End Sub


    'DataBindingComplete ensures row numbers are assigned after the grid finishes binding,
    'since DataSource assignment is asynchronous and rows aren't available immediately.
    Private Sub countries_grid_data_binding_complete(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles countries_grid.DataBindingComplete
        populate_row_numbers(countries_grid)
    End Sub


    Private Sub countries_grid_sorted(sender As Object, e As EventArgs) Handles countries_grid.Sorted
        populate_row_numbers(countries_grid)
    End Sub

End Class