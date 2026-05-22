' shows all transactions with a side panel for line items.
' managers can delete transactions, cashiers cannot.
' includes a "view receipt" button that opens receipt_viewer.

Public Class transactions
    Private ReadOnly db_obj As New db_controller()

    Private Const select_sql As String =
        "SELECT
             t.trans_uuid,
             t.subtotal,
             t.vat,
             t.total,
             t.payment_method,
             t.amount_paid,
             t.change_due,
             t.created_at,
             e.first_name + ' ' + e.last_name AS cashier_name,
             ISNULL(c.first_name + ' ' + c.last_name, 'Walk-in') AS customer_name
         FROM transactions t
         INNER JOIN employees e ON t.employee_id = e.employee_id
         LEFT JOIN customers c ON t.customer_id = c.customer_id
        "

    Private Sub transactions_load(sender As Object, e As EventArgs) Handles MyBase.Load
        setup_grid()
        setup_items_list()
        run_search()
    End Sub


    Private Sub setup_grid()
        transactions_grid.AutoGenerateColumns = False
        transactions_grid.Columns.Clear()

        Dim cols As New Dictionary(Of String, Object()) From {
            {"row_number", {"#", 40}},
            {"trans_uuid", {"Transaction ID", 240}},
            {"customer_name", {"Customer", 150}},
            {"cashier_name", {"Cashier", 150}},
            {"subtotal", {"Subtotal", 100}},
            {"vat", {"VAT", 80}},
            {"total", {"Total", 100}},
            {"payment_method", {"Method", 90}},
            {"created_at", {"Date", 170}}
        }

        For Each col In cols
            add_column(transactions_grid, col.Key, col.Value(0), col.Value(1))
        Next

        'amount_paid and change_due stay in the data source but hidden
        add_column(transactions_grid, "amount_paid", "amount_paid", 0, False)
        add_column(transactions_grid, "change_due", "change_due", 0, False)

        transactions_grid.Columns("row_number").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
    End Sub


    Private Sub setup_items_list()
        items_list.Columns.Clear()
        items_list.Columns.Add("Item", 200)
        items_list.Columns.Add("Qty", 60)
        items_list.Columns.Add("Price", 90)
        items_list.Columns.Add("Total", 90)
        items_list.View = View.Details
        items_list.FullRowSelect = True
        items_list.GridLines = True
    End Sub


    Private Sub run_search()
        Dim term = search_input.Text.Trim()
        Dim sql As String
        Dim params As New Dictionary(Of String, Object)

        If String.IsNullOrEmpty(term) Then
            sql = select_sql & " ORDER BY t.created_at DESC"
        Else
            sql = select_sql &
                "
                WHERE
                    CAST(t.trans_uuid AS NVARCHAR(50)) LIKE @term OR
                    ISNULL(c.first_name + ' ' + c.last_name, 'Walk-in') LIKE @term OR
                    e.first_name + ' ' + e.last_name LIKE @term OR
                    t.payment_method LIKE @term OR
                    CAST(t.total AS NVARCHAR(20)) LIKE @term OR
                    FORMAT(t.created_at, 'MMM d, yyyy hh:mm tt') LIKE @term
                ORDER BY t.created_at DESC
                "
            params("term") = "%" & term & "%"
        End If

        Try
            transactions_grid.DataSource = db_obj.fetch_datatable(sql, params)
        Catch ex As Exception
            Vip.Notification.Alert.ShowError($"Search error: {ex.Message}")
        End Try
    End Sub


    Private Sub load_line_items(trans_uuid As Guid)
        items_list.Items.Clear()

        Dim sql = "
            SELECT
                ti.quantity,
                ti.item_price,
                bi.item_name
            FROM transaction_items ti
            INNER JOIN boutique_items bi ON ti.item_id = bi.item_id
            WHERE ti.trans_uuid = @trans_uuid
        "

        Try
            For Each row In db_obj.fetch(sql, New Dictionary(Of String, Object) From {{"trans_uuid", trans_uuid}})
                Dim qty = CInt(row("quantity"))
                Dim price = CDec(row("item_price"))
                Dim total = qty * price

                Dim lvi As New ListViewItem(row("item_name").ToString())
                lvi.SubItems.Add(qty.ToString())
                lvi.SubItems.Add(price.ToString("C2"))
                lvi.SubItems.Add(total.ToString("C2"))
                items_list.Items.Add(lvi)
            Next
        Catch ex As Exception
            Vip.Notification.Alert.ShowError($"Load line items error: {ex.Message}")
        End Try
    End Sub


    Private Sub search_input_content_changed(sender As Object, e As EventArgs) Handles search_input.ContentChanged
        run_search()
    End Sub


    Private Sub transactions_grid_selection_changed(sender As Object, e As EventArgs) Handles transactions_grid.SelectionChanged
        If transactions_grid.SelectedRows.Count = 0 Then
            items_list.Items.Clear()
            Return
        End If

        Dim uuid_val = transactions_grid.SelectedRows(0).Cells("trans_uuid").Value
        If uuid_val Is Nothing OrElse IsDBNull(uuid_val) Then Return

        Dim trans_uuid = Guid.Parse(uuid_val.ToString())
        load_line_items(trans_uuid)
    End Sub


    Private Sub transactions_grid_data_binding_complete(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles transactions_grid.DataBindingComplete
        populate_row_numbers(transactions_grid)
    End Sub


    Private Sub transactions_grid_sorted(sender As Object, e As EventArgs) Handles transactions_grid.Sorted
        populate_row_numbers(transactions_grid)
    End Sub


    ' delete via Delete key (manager only)
    Private Async Sub transactions_grid_key_down(sender As Object, e As KeyEventArgs) Handles transactions_grid.KeyDown
        If e.KeyCode <> Keys.Delete Then Return
        If session_manager.position <> UserPosition.Manager Then
            Vip.Notification.Alert.ShowWarning("Only managers can delete transactions.")
            Return
        End If
        If transactions_grid.SelectedRows.Count = 0 Then Return

        Dim uuid_val = transactions_grid.SelectedRows(0).Cells("trans_uuid").Value
        Dim trans_uuid = Guid.Parse(uuid_val.ToString())

        Dim confirm = Await delete_confirmation.ShowDialog(
                                main,
                                $"Delete transaction {trans_uuid}? This cannot be undone.",
                                "Confirm Delete",
                                MessageBoxButtons.YesNo)

        If confirm <> DialogResult.Yes Then Return

        Try
            ' delete line items first (FK constraint)
            db_obj.execute(
                "DELETE FROM transaction_items WHERE trans_uuid = @trans_uuid",
                New Dictionary(Of String, Object) From {{"trans_uuid", trans_uuid}})

            db_obj.execute(
                "DELETE FROM transactions WHERE trans_uuid = @trans_uuid",
                New Dictionary(Of String, Object) From {{"trans_uuid", trans_uuid}})

            run_search()
            items_list.Items.Clear()
            Vip.Notification.Alert.ShowSucess("Transaction deleted.")
        Catch ex As Exception
            Vip.Notification.Alert.ShowError($"Delete error: {ex.Message}")
        End Try
    End Sub


    Private Sub view_receipt_btn_click(sender As Object, e As EventArgs) Handles view_receipt_btn.Click
        If transactions_grid.SelectedRows.Count = 0 Then
            Vip.Notification.Alert.ShowWarning("Select a transaction first.")
            Return
        End If

        Dim uuid_val = transactions_grid.SelectedRows(0).Cells("trans_uuid").Value
        Dim trans_uuid = Guid.Parse(uuid_val.ToString())

        'open the receipt viewer form
        Dim viewer As New receipt_viewer(trans_uuid)
        viewer.ShowDialog()
    End Sub


    Private Sub transactions_grid_cell_formatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles transactions_grid.CellFormatting
        If e.RowIndex < 0 Then Return
        Dim col = transactions_grid.Columns(e.ColumnIndex).Name

        If col = "created_at" AndAlso e.Value IsNot Nothing AndAlso TypeOf e.Value Is DateTime Then
            e.Value = CDate(e.Value).ToString("MMM d, yyyy hh:mm tt")
            e.FormattingApplied = True
        End If

        If (col = "subtotal" OrElse col = "vat" OrElse col = "total") AndAlso e.Value IsNot Nothing Then
            e.Value = CDec(e.Value).ToString("C2")
            e.FormattingApplied = True
        End If

        If col = "payment_method" AndAlso e.Value IsNot Nothing Then
            ' capitalise for display: "cash" → "Cash"
            Dim method = e.Value.ToString()
            If method.Length > 0 Then
                e.Value = method.Substring(0, 1).ToUpper() & method.Substring(1).ToLower()
                e.FormattingApplied = True
            End If
        End If
    End Sub

End Class