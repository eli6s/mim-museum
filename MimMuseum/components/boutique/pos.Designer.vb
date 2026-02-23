<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class pos
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.main_layout = New System.Windows.Forms.TableLayoutPanel()
        Me.left_panel = New System.Windows.Forms.Panel()
        Me.products_flow = New System.Windows.Forms.FlowLayoutPanel()
        Me.search_panel = New System.Windows.Forms.Panel()
        Me.clear_search_btn = New System.Windows.Forms.Button()
        Me.search_btn = New System.Windows.Forms.Button()
        Me.search_box = New System.Windows.Forms.TextBox()
        Me.right_panel = New System.Windows.Forms.Panel()
        Me.cart_listview = New System.Windows.Forms.ListView()
        Me.col_product = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.col_qty = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.col_price = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.cart_context_menu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.remove_item_menu = New System.Windows.Forms.ToolStripMenuItem()
        Me.bottom_panel = New System.Windows.Forms.Panel()
        Me.complete_sale_btn = New System.Windows.Forms.Button()
        Me.clear_cart_btn = New System.Windows.Forms.Button()
        Me.lbl_change_amount = New System.Windows.Forms.Label()
        Me.lbl_change = New System.Windows.Forms.Label()
        Me.lbl_total_amount = New System.Windows.Forms.Label()
        Me.lbl_total = New System.Windows.Forms.Label()
        Me.lbl_vat_amount = New System.Windows.Forms.Label()
        Me.lbl_vat = New System.Windows.Forms.Label()
        Me.lbl_subtotal_amount = New System.Windows.Forms.Label()
        Me.lbl_subtotal = New System.Windows.Forms.Label()
        Me.txt_amount_paid = New System.Windows.Forms.TextBox()
        Me.lbl_amount_paid = New System.Windows.Forms.Label()
        Me.radio_card = New System.Windows.Forms.RadioButton()
        Me.radio_cash = New System.Windows.Forms.RadioButton()
        Me.lbl_payment_method = New System.Windows.Forms.Label()
        Me.cmb_customer = New System.Windows.Forms.ComboBox()
        Me.lbl_customer = New System.Windows.Forms.Label()
        Me.lbl_order_details = New System.Windows.Forms.Label()
        Me.main_layout.SuspendLayout()
        Me.left_panel.SuspendLayout()
        Me.search_panel.SuspendLayout()
        Me.right_panel.SuspendLayout()
        Me.cart_context_menu.SuspendLayout()
        Me.bottom_panel.SuspendLayout()
        Me.SuspendLayout()
        '
        'main_layout
        '
        Me.main_layout.ColumnCount = 2
        Me.main_layout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65.0!))
        Me.main_layout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.0!))
        Me.main_layout.Controls.Add(Me.left_panel, 0, 0)
        Me.main_layout.Controls.Add(Me.right_panel, 1, 0)
        Me.main_layout.Dock = System.Windows.Forms.DockStyle.Fill
        Me.main_layout.Location = New System.Drawing.Point(0, 0)
        Me.main_layout.Name = "main_layout"
        Me.main_layout.Padding = New System.Windows.Forms.Padding(20)
        Me.main_layout.RowCount = 1
        Me.main_layout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.main_layout.Size = New System.Drawing.Size(1444, 839)
        Me.main_layout.TabIndex = 0
        '
        'left_panel
        '
        Me.left_panel.AutoScroll = True
        Me.left_panel.Controls.Add(Me.products_flow)
        Me.left_panel.Controls.Add(Me.search_panel)
        Me.left_panel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.left_panel.Location = New System.Drawing.Point(23, 23)
        Me.left_panel.Name = "left_panel"
        Me.left_panel.Padding = New System.Windows.Forms.Padding(10)
        Me.left_panel.Size = New System.Drawing.Size(906, 793)
        Me.left_panel.TabIndex = 0
        '
        'products_flow
        '
        Me.products_flow.AutoScroll = True
        Me.products_flow.Dock = System.Windows.Forms.DockStyle.Fill
        Me.products_flow.Location = New System.Drawing.Point(10, 70)
        Me.products_flow.Name = "products_flow"
        Me.products_flow.Padding = New System.Windows.Forms.Padding(10)
        Me.products_flow.Size = New System.Drawing.Size(886, 713)
        Me.products_flow.TabIndex = 1
        '
        'search_panel
        '
        Me.search_panel.Controls.Add(Me.clear_search_btn)
        Me.search_panel.Controls.Add(Me.search_btn)
        Me.search_panel.Controls.Add(Me.search_box)
        Me.search_panel.Dock = System.Windows.Forms.DockStyle.Top
        Me.search_panel.Location = New System.Drawing.Point(10, 10)
        Me.search_panel.Name = "search_panel"
        Me.search_panel.Padding = New System.Windows.Forms.Padding(0, 0, 0, 10)
        Me.search_panel.Size = New System.Drawing.Size(886, 60)
        Me.search_panel.TabIndex = 0
        '
        'clear_search_btn
        '
        Me.clear_search_btn.BackColor = System.Drawing.Color.FromArgb(CType(CType(108, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.clear_search_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.clear_search_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.clear_search_btn.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.clear_search_btn.ForeColor = System.Drawing.Color.White
        Me.clear_search_btn.Location = New System.Drawing.Point(650, 10)
        Me.clear_search_btn.Name = "clear_search_btn"
        Me.clear_search_btn.Size = New System.Drawing.Size(100, 40)
        Me.clear_search_btn.TabIndex = 2
        Me.clear_search_btn.Text = "Clear"
        Me.clear_search_btn.UseVisualStyleBackColor = False
        '
        'search_btn
        '
        Me.search_btn.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.search_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.search_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.search_btn.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.search_btn.ForeColor = System.Drawing.Color.White
        Me.search_btn.Location = New System.Drawing.Point(520, 10)
        Me.search_btn.Name = "search_btn"
        Me.search_btn.Size = New System.Drawing.Size(120, 40)
        Me.search_btn.TabIndex = 1
        Me.search_btn.Text = "Search"
        Me.search_btn.UseVisualStyleBackColor = False
        '
        'search_box
        '
        Me.search_box.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.search_box.Location = New System.Drawing.Point(10, 10)
        Me.search_box.Name = "search_box"
        Me.search_box.Size = New System.Drawing.Size(500, 29)
        Me.search_box.TabIndex = 0
        '
        'right_panel
        '
        Me.right_panel.BackColor = System.Drawing.Color.FromArgb(CType(CType(166, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.right_panel.Controls.Add(Me.cart_listview)
        Me.right_panel.Controls.Add(Me.bottom_panel)
        Me.right_panel.Controls.Add(Me.lbl_order_details)
        Me.right_panel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.right_panel.Location = New System.Drawing.Point(935, 23)
        Me.right_panel.Name = "right_panel"
        Me.right_panel.Padding = New System.Windows.Forms.Padding(15)
        Me.right_panel.Size = New System.Drawing.Size(486, 793)
        Me.right_panel.TabIndex = 1
        '
        'cart_listview
        '
        Me.cart_listview.BackColor = System.Drawing.Color.FromArgb(CType(CType(166, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cart_listview.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.col_product, Me.col_qty, Me.col_price})
        Me.cart_listview.ContextMenuStrip = Me.cart_context_menu
        Me.cart_listview.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cart_listview.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cart_listview.FullRowSelect = True
        Me.cart_listview.GridLines = True
        Me.cart_listview.HideSelection = False
        Me.cart_listview.Location = New System.Drawing.Point(15, 55)
        Me.cart_listview.Name = "cart_listview"
        Me.cart_listview.Size = New System.Drawing.Size(456, 323)
        Me.cart_listview.TabIndex = 2
        Me.cart_listview.UseCompatibleStateImageBehavior = False
        Me.cart_listview.View = System.Windows.Forms.View.Details
        '
        'col_product
        '
        Me.col_product.Text = "Product"
        Me.col_product.Width = 220
        '
        'col_qty
        '
        Me.col_qty.Text = "Qty"
        '
        'col_price
        '
        Me.col_price.Text = "Price"
        Me.col_price.Width = 100
        '
        'cart_context_menu
        '
        Me.cart_context_menu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.remove_item_menu})
        Me.cart_context_menu.Name = "cart_context_menu"
        Me.cart_context_menu.Size = New System.Drawing.Size(145, 26)
        '
        'remove_item_menu
        '
        Me.remove_item_menu.Name = "remove_item_menu"
        Me.remove_item_menu.Size = New System.Drawing.Size(144, 22)
        Me.remove_item_menu.Text = "Remove Item"
        '
        'bottom_panel
        '
        Me.bottom_panel.Controls.Add(Me.complete_sale_btn)
        Me.bottom_panel.Controls.Add(Me.clear_cart_btn)
        Me.bottom_panel.Controls.Add(Me.lbl_change_amount)
        Me.bottom_panel.Controls.Add(Me.lbl_change)
        Me.bottom_panel.Controls.Add(Me.lbl_total_amount)
        Me.bottom_panel.Controls.Add(Me.lbl_total)
        Me.bottom_panel.Controls.Add(Me.lbl_vat_amount)
        Me.bottom_panel.Controls.Add(Me.lbl_vat)
        Me.bottom_panel.Controls.Add(Me.lbl_subtotal_amount)
        Me.bottom_panel.Controls.Add(Me.lbl_subtotal)
        Me.bottom_panel.Controls.Add(Me.txt_amount_paid)
        Me.bottom_panel.Controls.Add(Me.lbl_amount_paid)
        Me.bottom_panel.Controls.Add(Me.radio_card)
        Me.bottom_panel.Controls.Add(Me.radio_cash)
        Me.bottom_panel.Controls.Add(Me.lbl_payment_method)
        Me.bottom_panel.Controls.Add(Me.cmb_customer)
        Me.bottom_panel.Controls.Add(Me.lbl_customer)
        Me.bottom_panel.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.bottom_panel.Location = New System.Drawing.Point(15, 378)
        Me.bottom_panel.Name = "bottom_panel"
        Me.bottom_panel.Padding = New System.Windows.Forms.Padding(10)
        Me.bottom_panel.Size = New System.Drawing.Size(456, 400)
        Me.bottom_panel.TabIndex = 1
        '
        'complete_sale_btn
        '
        Me.complete_sale_btn.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.complete_sale_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.complete_sale_btn.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.complete_sale_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.complete_sale_btn.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold)
        Me.complete_sale_btn.ForeColor = System.Drawing.Color.White
        Me.complete_sale_btn.Location = New System.Drawing.Point(10, 340)
        Me.complete_sale_btn.Name = "complete_sale_btn"
        Me.complete_sale_btn.Size = New System.Drawing.Size(436, 50)
        Me.complete_sale_btn.TabIndex = 16
        Me.complete_sale_btn.Text = "Complete Sale"
        Me.complete_sale_btn.UseVisualStyleBackColor = False
        '
        'clear_cart_btn
        '
        Me.clear_cart_btn.BackColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.clear_cart_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.clear_cart_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.clear_cart_btn.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.clear_cart_btn.ForeColor = System.Drawing.Color.White
        Me.clear_cart_btn.Location = New System.Drawing.Point(10, 285)
        Me.clear_cart_btn.Name = "clear_cart_btn"
        Me.clear_cart_btn.Size = New System.Drawing.Size(150, 45)
        Me.clear_cart_btn.TabIndex = 15
        Me.clear_cart_btn.Text = "Clear Cart"
        Me.clear_cart_btn.UseVisualStyleBackColor = False
        '
        'lbl_change_amount
        '
        Me.lbl_change_amount.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.lbl_change_amount.ForeColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.lbl_change_amount.Location = New System.Drawing.Point(180, 245)
        Me.lbl_change_amount.Name = "lbl_change_amount"
        Me.lbl_change_amount.Size = New System.Drawing.Size(150, 30)
        Me.lbl_change_amount.TabIndex = 14
        Me.lbl_change_amount.Text = "$0.00"
        Me.lbl_change_amount.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl_change
        '
        Me.lbl_change.AutoSize = True
        Me.lbl_change.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.lbl_change.Location = New System.Drawing.Point(10, 250)
        Me.lbl_change.Name = "lbl_change"
        Me.lbl_change.Size = New System.Drawing.Size(62, 20)
        Me.lbl_change.TabIndex = 13
        Me.lbl_change.Text = "Change:"
        '
        'lbl_total_amount
        '
        Me.lbl_total_amount.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lbl_total_amount.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lbl_total_amount.Location = New System.Drawing.Point(180, 205)
        Me.lbl_total_amount.Name = "lbl_total_amount"
        Me.lbl_total_amount.Size = New System.Drawing.Size(150, 35)
        Me.lbl_total_amount.TabIndex = 12
        Me.lbl_total_amount.Text = "$0.00"
        Me.lbl_total_amount.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl_total
        '
        Me.lbl_total.AutoSize = True
        Me.lbl_total.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lbl_total.Location = New System.Drawing.Point(10, 210)
        Me.lbl_total.Name = "lbl_total"
        Me.lbl_total.Size = New System.Drawing.Size(60, 25)
        Me.lbl_total.TabIndex = 11
        Me.lbl_total.Text = "Total:"
        '
        'lbl_vat_amount
        '
        Me.lbl_vat_amount.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.lbl_vat_amount.Location = New System.Drawing.Point(180, 175)
        Me.lbl_vat_amount.Name = "lbl_vat_amount"
        Me.lbl_vat_amount.Size = New System.Drawing.Size(150, 30)
        Me.lbl_vat_amount.TabIndex = 10
        Me.lbl_vat_amount.Text = "$0.00"
        Me.lbl_vat_amount.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl_vat
        '
        Me.lbl_vat.AutoSize = True
        Me.lbl_vat.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.lbl_vat.Location = New System.Drawing.Point(10, 180)
        Me.lbl_vat.Name = "lbl_vat"
        Me.lbl_vat.Size = New System.Drawing.Size(79, 20)
        Me.lbl_vat.TabIndex = 9
        Me.lbl_vat.Text = "VAT (11%):"
        '
        'lbl_subtotal_amount
        '
        Me.lbl_subtotal_amount.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.lbl_subtotal_amount.Location = New System.Drawing.Point(180, 145)
        Me.lbl_subtotal_amount.Name = "lbl_subtotal_amount"
        Me.lbl_subtotal_amount.Size = New System.Drawing.Size(150, 30)
        Me.lbl_subtotal_amount.TabIndex = 8
        Me.lbl_subtotal_amount.Text = "$0.00"
        Me.lbl_subtotal_amount.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl_subtotal
        '
        Me.lbl_subtotal.AutoSize = True
        Me.lbl_subtotal.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.lbl_subtotal.Location = New System.Drawing.Point(10, 150)
        Me.lbl_subtotal.Name = "lbl_subtotal"
        Me.lbl_subtotal.Size = New System.Drawing.Size(68, 20)
        Me.lbl_subtotal.TabIndex = 7
        Me.lbl_subtotal.Text = "Subtotal:"
        '
        'txt_amount_paid
        '
        Me.txt_amount_paid.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txt_amount_paid.Location = New System.Drawing.Point(135, 103)
        Me.txt_amount_paid.Name = "txt_amount_paid"
        Me.txt_amount_paid.Size = New System.Drawing.Size(125, 25)
        Me.txt_amount_paid.TabIndex = 6
        Me.txt_amount_paid.Text = "0.00"
        '
        'lbl_amount_paid
        '
        Me.lbl_amount_paid.AutoSize = True
        Me.lbl_amount_paid.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.lbl_amount_paid.Location = New System.Drawing.Point(10, 106)
        Me.lbl_amount_paid.Name = "lbl_amount_paid"
        Me.lbl_amount_paid.Size = New System.Drawing.Size(92, 19)
        Me.lbl_amount_paid.TabIndex = 5
        Me.lbl_amount_paid.Text = "Amount Paid:"
        '
        'radio_card
        '
        Me.radio_card.AutoSize = True
        Me.radio_card.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.radio_card.Location = New System.Drawing.Point(120, 70)
        Me.radio_card.Name = "radio_card"
        Me.radio_card.Size = New System.Drawing.Size(56, 23)
        Me.radio_card.TabIndex = 4
        Me.radio_card.Text = "Card"
        Me.radio_card.UseVisualStyleBackColor = True
        '
        'radio_cash
        '
        Me.radio_cash.AutoSize = True
        Me.radio_cash.Checked = True
        Me.radio_cash.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.radio_cash.Location = New System.Drawing.Point(10, 70)
        Me.radio_cash.Name = "radio_cash"
        Me.radio_cash.Size = New System.Drawing.Size(57, 23)
        Me.radio_cash.TabIndex = 3
        Me.radio_cash.TabStop = True
        Me.radio_cash.Text = "Cash"
        Me.radio_cash.UseVisualStyleBackColor = True
        '
        'lbl_payment_method
        '
        Me.lbl_payment_method.AutoSize = True
        Me.lbl_payment_method.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lbl_payment_method.Location = New System.Drawing.Point(10, 45)
        Me.lbl_payment_method.Name = "lbl_payment_method"
        Me.lbl_payment_method.Size = New System.Drawing.Size(128, 19)
        Me.lbl_payment_method.TabIndex = 2
        Me.lbl_payment_method.Text = "Payment Method:"
        '
        'cmb_customer
        '
        Me.cmb_customer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_customer.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cmb_customer.FormattingEnabled = True
        Me.cmb_customer.Location = New System.Drawing.Point(10, 35)
        Me.cmb_customer.Name = "cmb_customer"
        Me.cmb_customer.Size = New System.Drawing.Size(250, 25)
        Me.cmb_customer.TabIndex = 1
        '
        'lbl_customer
        '
        Me.lbl_customer.AutoSize = True
        Me.lbl_customer.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.lbl_customer.Location = New System.Drawing.Point(10, 10)
        Me.lbl_customer.Name = "lbl_customer"
        Me.lbl_customer.Size = New System.Drawing.Size(137, 19)
        Me.lbl_customer.TabIndex = 0
        Me.lbl_customer.Text = "Customer (Optional):"
        '
        'lbl_order_details
        '
        Me.lbl_order_details.BackColor = System.Drawing.Color.FromArgb(CType(CType(166, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lbl_order_details.Dock = System.Windows.Forms.DockStyle.Top
        Me.lbl_order_details.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Bold)
        Me.lbl_order_details.Location = New System.Drawing.Point(15, 15)
        Me.lbl_order_details.Name = "lbl_order_details"
        Me.lbl_order_details.Size = New System.Drawing.Size(456, 40)
        Me.lbl_order_details.TabIndex = 0
        Me.lbl_order_details.Text = "Order Details"
        Me.lbl_order_details.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'pos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(166, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Controls.Add(Me.main_layout)
        Me.Name = "pos"
        Me.Size = New System.Drawing.Size(1444, 839)
        Me.main_layout.ResumeLayout(False)
        Me.left_panel.ResumeLayout(False)
        Me.search_panel.ResumeLayout(False)
        Me.search_panel.PerformLayout()
        Me.right_panel.ResumeLayout(False)
        Me.cart_context_menu.ResumeLayout(False)
        Me.bottom_panel.ResumeLayout(False)
        Me.bottom_panel.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents main_layout As TableLayoutPanel
    Friend WithEvents left_panel As Panel
    Friend WithEvents products_flow As FlowLayoutPanel
    Friend WithEvents search_panel As Panel
    Friend WithEvents clear_search_btn As Button
    Friend WithEvents search_btn As Button
    Friend WithEvents search_box As TextBox
    Friend WithEvents right_panel As Panel
    Friend WithEvents cart_listview As ListView
    Friend WithEvents col_product As ColumnHeader
    Friend WithEvents col_qty As ColumnHeader
    Friend WithEvents col_price As ColumnHeader
    Friend WithEvents cart_context_menu As ContextMenuStrip
    Friend WithEvents remove_item_menu As ToolStripMenuItem
    Friend WithEvents bottom_panel As Panel
    Friend WithEvents complete_sale_btn As Button
    Friend WithEvents clear_cart_btn As Button
    Friend WithEvents lbl_change_amount As Label
    Friend WithEvents lbl_change As Label
    Friend WithEvents lbl_total_amount As Label
    Friend WithEvents lbl_total As Label
    Friend WithEvents lbl_vat_amount As Label
    Friend WithEvents lbl_vat As Label
    Friend WithEvents lbl_subtotal_amount As Label
    Friend WithEvents lbl_subtotal As Label
    Friend WithEvents txt_amount_paid As TextBox
    Friend WithEvents lbl_amount_paid As Label
    Friend WithEvents radio_card As RadioButton
    Friend WithEvents radio_cash As RadioButton
    Friend WithEvents lbl_payment_method As Label
    Friend WithEvents cmb_customer As ComboBox
    Friend WithEvents lbl_customer As Label
    Friend WithEvents lbl_order_details As Label
End Class