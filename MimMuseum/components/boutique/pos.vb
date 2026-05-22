Imports System.Data.SqlClient

Public Class pos
    Private Const VAT_RATE As Decimal = 0.11D
    Private ReadOnly db As New db_controller()
    Private _cart As New List(Of cart_item)

    Private Sub pos_load(sender As Object, e As EventArgs) Handles Me.Load
        load_customers()
        load_products()
    End Sub


    Private Sub load_customers()
        cmb_customer.Items = New String() {}
        cmb_customer.AddItem("— Walk-in Customer —")

        Dim rows = db.fetch(
            "SELECT customer_id, first_name + ' ' + last_name + ' (' + phone_num + ')' AS display
             FROM customers
             ORDER BY first_name, last_name"
        )

        For Each row In rows
            cmb_customer.AddItem(row("display").ToString())
        Next

        cmb_customer.SelectedIndex = 0
    End Sub


    Private Sub load_products(Optional search_term As String = "")
        products_flow.Controls.Clear()

        Dim sql As String =
            "SELECT item_id, item_name, unit_price, quantity, image_filename
             FROM boutique_items
             WHERE is_active = 1"

        Dim params As Dictionary(Of String, Object) = Nothing

        If Not String.IsNullOrWhiteSpace(search_term) Then
            sql &= " AND item_name LIKE @search"
            params = New Dictionary(Of String, Object) From {{"search", "%" & search_term.Trim() & "%"}}
        End If

        sql &= " ORDER BY item_name"

        Try
            Dim dt = db.fetch_datatable(sql, params)

            For Each row As DataRow In dt.Rows
                Dim card As New product_card()
                card.Width = 150
                card.Height = 180
                card.Margin = New Padding(6)
                card.set_product(
                    CInt(row("item_id")),
                    row("item_name").ToString(),
                    CDec(row("unit_price")),
                    CInt(row("quantity")),
                    If(IsDBNull(row("image_filename")), Nothing, row("image_filename").ToString())
                )
                AddHandler card.product_clicked, AddressOf card_product_clicked
                products_flow.Controls.Add(card)
            Next
        Catch ex As Exception
            Vip.Notification.Alert.ShowError($"Failed to load products: {ex.Message}")
        End Try
    End Sub


    Private Sub search_box_ContentChanged(sender As Object, e As EventArgs) Handles search_box.ContentChanged
        load_products(search_box.Text)
    End Sub


    Private Sub card_product_clicked(card As product_card)
        Dim raw_stock As Object = db.fetch_val(
            "SELECT quantity FROM boutique_items WHERE item_id = @item_id AND is_active = 1",
            New Dictionary(Of String, Object) From {{"item_id", card.item_id}}
        )

        If raw_stock Is Nothing OrElse IsDBNull(raw_stock) Then
            Vip.Notification.Alert.ShowWarning($"'{card.item_name}' is no longer available.")
            load_products(search_box.Text)
            Return
        End If

        Dim current_stock As Integer = CInt(raw_stock)
        Dim existing As cart_item = _cart.FirstOrDefault(Function(c) c.item_id = card.item_id)
        Dim already_in_cart As Integer = If(existing IsNot Nothing, existing.quantity, 0)

        If already_in_cart >= current_stock Then
            Vip.Notification.Alert.ShowWarning($"Only {current_stock} unit(s) of '{card.item_name}' in stock.")
            Return
        End If

        If existing IsNot Nothing Then
            existing.quantity += 1
        Else
            _cart.Add(New cart_item(card.item_id, card.item_name, 1, card.unit_price))
        End If

        refresh_cart_view()
        update_totals()
    End Sub


    Private Sub refresh_cart_view()
        cart_listview.BeginUpdate()
        cart_listview.Items.Clear()

        For Each item As cart_item In _cart
            Dim lvi As New ListViewItem(item.item_name)
            lvi.SubItems.Add(item.quantity.ToString())
            lvi.SubItems.Add(item.unit_price.ToString("C2"))
            lvi.SubItems.Add(item.line_total.ToString("C2"))
            lvi.Tag = item
            cart_listview.Items.Add(lvi)
        Next

        cart_listview.EndUpdate()
    End Sub


    Private Sub remove_item_menu_click(sender As Object, e As EventArgs) Handles remove_item_menu.Click
        If cart_listview.SelectedItems.Count = 0 Then Return
        Dim item = DirectCast(cart_listview.SelectedItems(0).Tag, cart_item)
        _cart.Remove(item)
        refresh_cart_view()
        update_totals()
    End Sub


    Private Async Sub clear_cart_btn_click(sender As Object, e As EventArgs) Handles clear_cart_btn.Click
        If _cart.Count = 0 Then Return

        Dim confirm = Await delete_confirmation.ShowDialog(
                                main,
                                "Clear all items from the cart?",
                                "Clear Cart",
                                MessageBoxButtons.YesNo)

        If confirm = DialogResult.Yes Then reset_cart()
    End Sub


    Private Sub update_totals()
        Dim subtotal As Decimal = _cart.Sum(Function(c) c.line_total)
        Dim vat As Decimal = Math.Round(subtotal * VAT_RATE, 2)
        Dim total As Decimal = subtotal + vat

        lbl_subtotal_amount.Text = subtotal.ToString("C2")
        lbl_vat_amount.Text = vat.ToString("C2")
        lbl_total_amount.Text = total.ToString("C2")

        update_change(total)
    End Sub


    Private Sub update_change(total As Decimal)
        If radio_cash.Checked Then
            txt_amount_paid.Enabled = True
            Dim paid As Decimal
            If Decimal.TryParse(txt_amount_paid.Text, paid) Then
                Dim change As Decimal = Math.Round(paid - total, 2)
                lbl_change_amount.Text = If(change >= 0D, change.ToString("C2"), "(Insufficient)")
                lbl_change_amount.ForeColor = If(change >= 0D,
                    Color.FromArgb(40, 167, 69),
                    Color.FromArgb(220, 53, 69))
            Else
                lbl_change_amount.Text = "—"
                lbl_change_amount.ForeColor = SystemColors.ControlText
            End If
        Else
            txt_amount_paid.Enabled = False
            txt_amount_paid.Text = ""
            lbl_change_amount.Text = "N/A"
            lbl_change_amount.ForeColor = SystemColors.ControlText
        End If
    End Sub


    Private Sub txt_amount_paid_content_changed(sender As Object, e As EventArgs) Handles txt_amount_paid.ContentChanged
        Dim subtotal As Decimal = _cart.Sum(Function(c) c.line_total)
        Dim total As Decimal = subtotal + Math.Round(subtotal * VAT_RATE, 2)
        update_change(total)
    End Sub


    Private Sub payment_mode_changed(sender As Object, e As EventArgs) _
        Handles radio_cash.CheckedChanged, radio_card.CheckedChanged

        Dim subtotal As Decimal = _cart.Sum(Function(c) c.line_total)
        Dim total As Decimal = subtotal + Math.Round(subtotal * VAT_RATE, 2)
        update_change(total)
    End Sub


    Private Sub complete_sale_btn_click(sender As Object, e As EventArgs) Handles complete_sale_btn.Click
        If _cart.Count = 0 Then
            Vip.Notification.Alert.ShowWarning("The cart is empty.")
            Return
        End If

        Dim subtotal As Decimal = _cart.Sum(Function(c) c.line_total)
        Dim vat As Decimal = Math.Round(subtotal * VAT_RATE, 2)
        Dim total As Decimal = subtotal + vat

        Dim is_cash As Boolean = radio_cash.Checked
        Dim payment_method_str As String = If(is_cash,
            PaymentMethod.Cash.ToString().ToLower(),
            PaymentMethod.Card.ToString().ToLower())

        Dim amount_paid As Decimal? = Nothing
        Dim change_due As Decimal? = Nothing

        If is_cash Then
            Dim paid As Decimal
            If Not Decimal.TryParse(txt_amount_paid.Text, paid) OrElse paid < total Then
                Vip.Notification.Alert.ShowWarning($"Amount paid must be at least {total:C2}.")
                Return
            End If
            amount_paid = paid
            change_due = Math.Round(paid - total, 2)
        End If

        Dim customer_id As Integer? = Nothing
        If cmb_customer.SelectedIndex > 0 Then
            Dim selected_display = cmb_customer.SelectedItem.ToString()
            Dim customer_rows = db.fetch(
                "SELECT customer_id
                 FROM customers
                 WHERE first_name + ' ' + last_name + ' (' + phone_num + ')' = @display",
                New Dictionary(Of String, Object) From {{"display", selected_display}}
            )
            If customer_rows.Count > 0 Then
                customer_id = Convert.ToInt32(customer_rows(0)("customer_id"))
            End If
        End If

        Dim trans_uuid As Guid = Guid.NewGuid()
        Dim employee_id As Integer = session_manager.employee_id

        Try
            db.execute(
                "INSERT INTO transactions
                    (trans_uuid, customer_id, subtotal, vat, total,
                     payment_method, amount_paid, change_due, employee_id)
                 VALUES
                    (@trans_uuid, @customer_id, @subtotal, @vat, @total,
                     @payment_method, @amount_paid, @change_due, @employee_id)",
                New Dictionary(Of String, Object) From {
                    {"trans_uuid", trans_uuid},
                    {"customer_id", If(customer_id.HasValue, CObj(customer_id.Value), CObj(DBNull.Value))},
                    {"subtotal", subtotal},
                    {"vat", vat},
                    {"total", total},
                    {"payment_method", payment_method_str},
                    {"amount_paid", If(amount_paid.HasValue, CObj(amount_paid.Value), CObj(DBNull.Value))},
                    {"change_due", If(change_due.HasValue, CObj(change_due.Value), CObj(DBNull.Value))},
                    {"employee_id", employee_id}
                })

            For Each item As cart_item In _cart
                db.execute(
                    "INSERT INTO transaction_items (trans_uuid, item_id, quantity, item_price)
                     VALUES (@trans_uuid, @item_id, @quantity, @item_price)",
                    New Dictionary(Of String, Object) From {
                        {"trans_uuid", trans_uuid},
                        {"item_id", item.item_id},
                        {"quantity", item.quantity},
                        {"item_price", item.unit_price}
                    })

                db.execute(
                    "UPDATE boutique_items
                     SET quantity = quantity - @quantity
                     WHERE item_id = @item_id",
                    New Dictionary(Of String, Object) From {
                        {"quantity", item.quantity},
                        {"item_id", item.item_id}
                    })
            Next

            Try
                Dim viewer As New receipt_viewer(trans_uuid)
                viewer.ShowDialog()
            Catch ex As Exception
                ' don't fail the whole sale just because the receipt didn't open
                Vip.Notification.Alert.ShowWarning($"Receipt could not be displayed: {ex.Message}")
            End Try

            reset_cart()
            load_products()

        Catch ex As Exception
            Vip.Notification.Alert.ShowError($"Sale could not be saved: {ex.Message}")
        End Try
    End Sub


    Private Sub reset_cart()
        _cart.Clear()
        refresh_cart_view()
        update_totals()
        txt_amount_paid.Text = ""
        cmb_customer.SelectedIndex = 0
        radio_cash.Checked = True
    End Sub

End Class
