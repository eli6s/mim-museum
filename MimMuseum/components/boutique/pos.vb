'' =============================================================================
'' pos.vb  –  Point-of-Sale UserControl  (code-behind only)
''
'' Designer controls expected in pos.Designer.vb:
''   LEFT SIDE (65 %)
''     search_box       TextBox
''     search_btn       Button
''     clear_search_btn        Button
''     products_flow     FlowLayoutPanel
''
''   RIGHT SIDE (35 %)
''     lblOrderDetails Label          "Order Details"
''     cart_listview          ListView       Details view, FullRowSelect = True
''                       Columns: Item | Qty | Unit Price | Total
''     --- bottom panel ---
''     cmb_customer     ComboBox       DropDownList
''     rdoCash         RadioButton
''     rdoCard         RadioButton
''     txtAmountPaid   TextBox
''     lblSubtotal     Label
''     lblVAT          Label
''     lblTotal        Label
''     lblChange       Label
''     btnClearCart    Button
''     btnCompleteSale Button
'' =============================================================================
'Imports System.Data.SqlClient
'Imports System.Windows.Controls

'Public Class pos
'    Private Const VAT_RATE As Decimal = 0.11D       ' 11 %
'    Private ReadOnly db As New db_controller()
'    Private _cart As New List(Of cart_item)


'    Private Sub pos_Load(sender As Object, e As EventArgs) Handles Me.Load
'        SetupCartListView()
'        LoadCustomers()
'        LoadProducts()
'    End Sub


'    Private Sub SetupCartListView()
'        cart_listview.View = View.Details
'        cart_listview.FullRowSelect = True
'        cart_listview.GridLines = True

'        If cart_listview.Columns.Count = 0 Then
'            cart_listview.Columns.Add("Item", 160)
'            cart_listview.Columns.Add("Qty", 45, HorizontalAlignment.Center)
'            cart_listview.Columns.Add("Unit Price", 75, HorizontalAlignment.Right)
'            cart_listview.Columns.Add("Total", 75, HorizontalAlignment.Right)
'        End If
'    End Sub


'    Private Sub LoadCustomers()
'        cmb_customer.Items.Clear()
'        cmb_customer.Items.Add(New CustomerItem(Nothing, "— Walk-in customer —"))

'        ' customers schema: customer_id INT IDENTITY(701,1), first_name, last_name, phone_num
'        Dim sql As String =
'            "SELECT customer_id, " &
'            "       first_name + ' ' + last_name + ' (' + phone_num + ')' AS display " &
'            "FROM   customers " &
'            "ORDER BY first_name, last_name"

'        Dim dt As DataTable = db.fetch_datatable(sql)

'        For Each row As DataRow In dt.Rows
'            cmb_customer.Items.Add(
'                New CustomerItem(CInt(row("customer_id")), row("display").ToString()))
'        Next

'        cmb_customer.SelectedIndex = 0
'    End Sub


'    Private Sub LoadProducts(Optional searchTerm As String = "")
'        products_flow.Controls.Clear()

'        Dim sql As String =
'            "SELECT item_id, item_name, unit_price, quantity, image_filename " &
'            "FROM   boutique_items " &
'            "WHERE  is_active = 1"

'        Dim params As Dictionary(Of String, Object) = Nothing

'        If Not String.IsNullOrWhiteSpace(searchTerm) Then
'            sql &= " AND item_name LIKE @search"
'            ' build_params prepends "@" automatically — do NOT include it in the key
'            params = New Dictionary(Of String, Object) From {{"search", "%" & searchTerm.Trim() & "%"}}
'        End If

'        sql &= " ORDER BY item_name"

'        Dim dt As DataTable = db.fetch_datatable(sql, params)

'        For Each row As DataRow In dt.Rows
'            Dim card As New product_card()
'            card.Width = 150
'            card.Height = 180
'            card.Margin = New Padding(6)
'            card.SetProduct(
'                CInt(row("item_id")),
'                row("item_name").ToString(),
'                CDec(row("unit_price")),
'                CInt(row("quantity")),
'                If(IsDBNull(row("image_filename")), Nothing, row("image_filename").ToString()))

'            AddHandler card.ProductClicked, AddressOf Card_ProductClicked
'            products_flow.Controls.Add(card)
'        Next
'    End Sub


'    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles search_btn.Click
'        LoadProducts(search_box.Text)
'    End Sub


'    Private Sub txtSearch_KeyDown(sender As Object, e As KeyEventArgs) Handles search_box.KeyDown
'        If e.KeyCode = Keys.Enter Then LoadProducts(search_box.Text)
'    End Sub


'    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles clear_search_btn.Click
'        search_box.Clear()
'        LoadProducts()
'    End Sub


'    Private Sub Card_ProductClicked(card As product_card)
'        ' Re-query live stock so we're never working off a stale card value.
'        ' fetch_val returns Object; guard against DBNull/Nothing (item may have
'        ' been deactivated or deleted since the panel was loaded).
'        Dim rawStock As Object = db.fetch_val(
'            "SELECT quantity FROM boutique_items WHERE item_id = @item_id AND is_active = 1",
'            New Dictionary(Of String, Object) From {{"item_id", card.ItemId}})

'        If rawStock Is Nothing OrElse IsDBNull(rawStock) Then
'            MessageBox.Show(
'                $"""{card.ItemName}"" is no longer available.",
'                "Item Unavailable",
'                MessageBoxButtons.OK,
'                MessageBoxIcon.Warning)
'            LoadProducts(search_box.Text)   ' refresh the panel
'            Return
'        End If

'        Dim currentStock As Integer = CInt(rawStock)

'        Dim existing As cart_item =
'            _cart.FirstOrDefault(Function(c) c.item_id = card.ItemId)

'        Dim alreadyInCart As Integer = If(existing IsNot Nothing, existing.quantity, 0)

'        If alreadyInCart >= currentStock Then
'            MessageBox.Show(
'                $"Only {currentStock} unit(s) of ""{card.ItemName}"" in stock.",
'                "Insufficient Stock",
'                MessageBoxButtons.OK,
'                MessageBoxIcon.Warning)
'            Return
'        End If

'        If existing IsNot Nothing Then
'            existing.quantity += 1
'        Else
'            _cart.Add(New cart_item(card.ItemId, card.ItemName, 1, card.UnitPrice))
'        End If

'        RefreshCartView()
'        UpdateTotals()
'    End Sub


'    Private Sub RefreshCartView()
'        cart_listview.BeginUpdate()
'        cart_listview.Items.Clear()

'        For Each item As cart_item In _cart
'            Dim lvi As New ListViewItem(item.item_name)
'            lvi.SubItems.Add(item.quantity.ToString())
'            lvi.SubItems.Add(item.unit_price.ToString("C2"))
'            lvi.SubItems.Add(item.LineTotal.ToString("C2"))
'            lvi.Tag = item
'            cart_listview.Items.Add(lvi)
'        Next

'        cart_listview.EndUpdate()
'    End Sub


'    Private Sub UpdateTotals()
'        Dim subtotal As Decimal = _cart.Sum(Function(c) c.LineTotal)
'        Dim vat As Decimal = Math.Round(subtotal * VAT_RATE, 2)
'        Dim total As Decimal = subtotal + vat

'        lblSubtotal.Text = subtotal.ToString("C2")
'        lblVAT.Text = vat.ToString("C2")
'        lblTotal.Text = total.ToString("C2")

'        UpdateChange(total)
'    End Sub


'    Private Sub UpdateChange(total As Decimal)
'        If rdoCash.Checked Then
'            txtAmountPaid.Enabled = True
'            Dim paid As Decimal
'            If Decimal.TryParse(txtAmountPaid.Text, paid) Then
'                Dim change As Decimal = Math.Round(paid - total, 2)
'                lblChange.Text = If(change >= 0D, change.ToString("C2"), "(Insufficient)")
'                lblChange.ForeColor = If(change >= 0D, Color.DarkGreen, Color.Red)
'            Else
'                lblChange.Text = "—"
'                lblChange.ForeColor = SystemColors.ControlText
'            End If
'        Else
'            ' Card — amount_paid and change_due must be NULL (schema constraint)
'            txtAmountPaid.Enabled = False
'            txtAmountPaid.Clear()
'            lblChange.Text = "N/A"
'            lblChange.ForeColor = SystemColors.ControlText
'        End If
'    End Sub


'    ' Fires as cashier types the tendered amount
'    Private Sub txtAmountPaid_TextChanged(sender As Object, e As EventArgs) _
'        Handles txtAmountPaid.TextChanged

'        Dim subtotal As Decimal = _cart.Sum(Function(c) c.LineTotal)
'        Dim total As Decimal = subtotal + Math.Round(subtotal * VAT_RATE, 2)
'        UpdateChange(total)
'    End Sub


'    ' Fires when switching between cash and card
'    Private Sub PaymentMode_Changed(sender As Object, e As EventArgs) _
'        Handles rdoCash.CheckedChanged, rdoCard.CheckedChanged

'        Dim subtotal As Decimal = _cart.Sum(Function(c) c.LineTotal)
'        Dim total As Decimal = subtotal + Math.Round(subtotal * VAT_RATE, 2)
'        UpdateChange(total)
'    End Sub


'    Private Sub btnClearCart_Click(sender As Object, e As EventArgs) _
'        Handles btnClearCart.Click

'        If _cart.Count = 0 Then Return

'        If MessageBox.Show(
'                "Clear all items from the cart?",
'                "Clear Cart",
'                MessageBoxButtons.YesNo,
'                MessageBoxIcon.Question) = DialogResult.Yes Then
'            ResetCart()
'        End If
'    End Sub


'    Private Sub ResetCart()
'        _cart.Clear()
'        RefreshCartView()
'        UpdateTotals()
'        txtAmountPaid.Clear()
'        cmb_customer.SelectedIndex = 0
'        rdoCash.Checked = True
'    End Sub


'    Private Sub btnCompleteSale_Click(sender As Object, e As EventArgs) _
'        Handles btnCompleteSale.Click

'        ' Guard: cart must not be empty
'        If _cart.Count = 0 Then
'            MessageBox.Show("The cart is empty.", "Nothing to sell",
'                            MessageBoxButtons.OK, MessageBoxIcon.Information)
'            Return
'        End If

'        ' Compute financials
'        Dim subtotal As Decimal = _cart.Sum(Function(c) c.LineTotal)
'        Dim vat As Decimal = Math.Round(subtotal * VAT_RATE, 2)
'        Dim total As Decimal = subtotal + vat

'        ' Resolve payment method using the PaymentMethod enum for consistency
'        Dim isCash As Boolean = rdoCash.Checked
'        ' schema CHECK constraint requires lowercase "cash" / "card"
'        Dim paymentMethodStr As String = If(isCash,
'            PaymentMethod.Cash.ToString().ToLower(),
'            PaymentMethod.Card.ToString().ToLower())

'        ' Cash-specific validation
'        Dim amountPaid As Decimal? = Nothing
'        Dim changeDue As Decimal? = Nothing

'        If isCash Then
'            Dim paid As Decimal
'            If Not Decimal.TryParse(txtAmountPaid.Text, paid) OrElse paid < total Then
'                MessageBox.Show(
'                    $"Amount paid must be at least {total:C2}.",
'                    "Insufficient Payment",
'                    MessageBoxButtons.OK,
'                    MessageBoxIcon.Warning)
'                txtAmountPaid.Focus()
'                Return
'            End If
'            amountPaid = paid
'            ' schema chk_change_correct: change_due must equal amount_paid - total exactly
'            changeDue = Math.Round(paid - total, 2)
'        End If

'        Dim selectedCustomer As CustomerItem =
'            DirectCast(cmb_customer.SelectedItem, CustomerItem)

'        Dim transUuid As Guid = Guid.NewGuid()
'        Dim employeeId As Integer = SessionManager.CurrentUserId

'        ' ================================================================
'        ' DATABASE WRITE — all in one SqlTransaction for full atomicity.
'        ' db_controller.execute() opens a new connection per call, so we
'        ' bypass it here and manage the connection + transaction manually.
'        ' ================================================================
'        Try
'            Using conn As New SqlConnection(
'                    "Data Source=localhost;Initial Catalog=mim_museum;Integrated Security=True")
'                conn.Open()
'                Using tran As SqlTransaction = conn.BeginTransaction()
'                    Try
'                        ' ---- 1. Insert transaction header ----
'                        Dim insertTrans As String =
'                            "INSERT INTO transactions " &
'                            "    (trans_uuid, customer_id, subtotal, vat, total, " &
'                            "     payment_method, amount_paid, change_due, employee_id) " &
'                            "VALUES " &
'                            "    (@trans_uuid, @customer_id, @subtotal, @vat, @total, " &
'                            "     @payment_method, @amount_paid, @change_due, @employee_id)"

'                        Using cmd As New SqlCommand(insertTrans, conn, tran)
'                            cmd.Parameters.AddWithValue("@trans_uuid", transUuid)
'                            cmd.Parameters.AddWithValue(
'                                "@customer_id",
'                                If(selectedCustomer.customer_id.HasValue,
'                                   CObj(selectedCustomer.customer_id.Value),
'                                   CObj(DBNull.Value)))
'                            cmd.Parameters.AddWithValue("@subtotal", subtotal)
'                            cmd.Parameters.AddWithValue("@vat", vat)
'                            cmd.Parameters.AddWithValue("@total", total)
'                            cmd.Parameters.AddWithValue("@payment_method", paymentMethodStr)
'                            cmd.Parameters.AddWithValue(
'                                "@amount_paid",
'                                If(amountPaid.HasValue, CObj(amountPaid.Value), CObj(DBNull.Value)))
'                            cmd.Parameters.AddWithValue(
'                                "@change_due",
'                                If(changeDue.HasValue, CObj(changeDue.Value), CObj(DBNull.Value)))
'                            cmd.Parameters.AddWithValue("@employee_id", employeeId)
'                            cmd.ExecuteNonQuery()
'                        End Using

'                        ' ---- 2. Insert line items + decrement stock ----
'                        For Each item As CartItem In _cart

'                            ' Insert transaction_items row
'                            ' Schema column is item_price (price snapshot, not unit_price join)
'                            Dim insertLine As String =
'                                "INSERT INTO transaction_items " &
'                                "    (trans_uuid, item_id, quantity, item_price) " &
'                                "VALUES (@trans_uuid, @item_id, @quantity, @item_price)"

'                            Using cmd As New SqlCommand(insertLine, conn, tran)
'                                cmd.Parameters.AddWithValue("@trans_uuid", transUuid)
'                                cmd.Parameters.AddWithValue("@item_id", item.item_id)
'                                cmd.Parameters.AddWithValue("@quantity", item.quantity)
'                                cmd.Parameters.AddWithValue("@item_price", item.unit_price)
'                                cmd.ExecuteNonQuery()
'                            End Using

'                            ' Decrement boutique_items.quantity
'                            Dim deductSql As String =
'                                "UPDATE boutique_items " &
'                                "SET    quantity = quantity - @quantity " &
'                                "WHERE  item_id = @item_id"

'                            Using cmd As New SqlCommand(deductSql, conn, tran)
'                                cmd.Parameters.AddWithValue("@quantity", item.quantity)
'                                cmd.Parameters.AddWithValue("@item_id", item.item_id)
'                                cmd.ExecuteNonQuery()
'                            End Using
'                        Next

'                        tran.Commit()

'                    Catch exInner As Exception
'                        tran.Rollback()
'                        Throw   ' re-throw so the outer Catch shows the message
'                    End Try
'                End Using
'            End Using

'            ' ---- 3. Success feedback ----
'            Dim receipt As String =
'                $"Sale completed!{Environment.NewLine}" &
'                $"Subtotal : {subtotal:C2}{Environment.NewLine}" &
'                $"VAT (11%): {vat:C2}{Environment.NewLine}" &
'                $"Total    : {total:C2}"

'            If isCash Then
'                receipt &= $"{Environment.NewLine}Change   : {changeDue.Value:C2}"
'            End If

'            MessageBox.Show(receipt, "Sale Complete",
'                            MessageBoxButtons.OK, MessageBoxIcon.Information)

'            ' ---- 4. Reset POS ready for next customer ----
'            ResetCart()
'            LoadProducts()  ' refresh cards so updated stock counts are visible

'        Catch ex As Exception
'            MessageBox.Show(
'                $"The sale could not be saved:{Environment.NewLine}{ex.Message}",
'                "Database Error",
'                MessageBoxButtons.OK,
'                MessageBoxIcon.Error)
'        End Try

'    End Sub

'End Class