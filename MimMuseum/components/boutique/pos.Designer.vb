<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class pos
    Inherits System.Windows.Forms.UserControl

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

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.main_layout = New System.Windows.Forms.TableLayoutPanel()
        Me.left_panel = New System.Windows.Forms.Panel()
        Me.products_flow = New System.Windows.Forms.FlowLayoutPanel()
        Me.search_panel = New System.Windows.Forms.Panel()
        Me.right_panel = New System.Windows.Forms.Panel()
        Me.cart_listview = New System.Windows.Forms.ListView()
        Me.col_product = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.col_qty = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.col_price = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.cart_context_menu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.remove_item_menu = New System.Windows.Forms.ToolStripMenuItem()
        Me.bottom_panel = New System.Windows.Forms.Panel()
        Me.complete_sale_btn = New CuoreUI.Controls.cuiButton()
        Me.lbl_change_amount = New System.Windows.Forms.Label()
        Me.lbl_change = New System.Windows.Forms.Label()
        Me.lbl_total_amount = New System.Windows.Forms.Label()
        Me.lbl_total = New System.Windows.Forms.Label()
        Me.lbl_vat_amount = New System.Windows.Forms.Label()
        Me.lbl_vat = New System.Windows.Forms.Label()
        Me.lbl_subtotal_amount = New System.Windows.Forms.Label()
        Me.lbl_subtotal = New System.Windows.Forms.Label()
        Me.txt_amount_paid = New CuoreUI.Controls.cuiTextBox()
        Me.lbl_amount_paid = New System.Windows.Forms.Label()
        Me.radio_card = New System.Windows.Forms.RadioButton()
        Me.radio_cash = New System.Windows.Forms.RadioButton()
        Me.lbl_payment_method = New System.Windows.Forms.Label()
        Me.lbl_customer = New System.Windows.Forms.Label()
        Me.lbl_order_details = New System.Windows.Forms.Label()
        Me.delete_confirmation = New CuoreUI.Components.cuiMessageDialog()
        Me.clear_cart_btn = New CuoreUI.Controls.cuiButton()
        Me.cmb_customer = New CuoreUI.Controls.cuiComboBox()
        Me.search_box = New CuoreUI.Controls.cuiTextBox()
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
        Me.main_layout.BackColor = System.Drawing.Color.FromArgb(CType(CType(166, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(255, Byte), Integer))
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
        Me.left_panel.BackColor = System.Drawing.Color.FromArgb(CType(CType(166, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(255, Byte), Integer))
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
        Me.products_flow.BackColor = System.Drawing.Color.FromArgb(CType(CType(166, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.products_flow.Dock = System.Windows.Forms.DockStyle.Fill
        Me.products_flow.Location = New System.Drawing.Point(10, 70)
        Me.products_flow.Name = "products_flow"
        Me.products_flow.Padding = New System.Windows.Forms.Padding(10)
        Me.products_flow.Size = New System.Drawing.Size(886, 713)
        Me.products_flow.TabIndex = 1
        '
        'search_panel
        '
        Me.search_panel.BackColor = System.Drawing.Color.FromArgb(CType(CType(166, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.search_panel.Controls.Add(Me.search_box)
        Me.search_panel.Dock = System.Windows.Forms.DockStyle.Top
        Me.search_panel.Location = New System.Drawing.Point(10, 10)
        Me.search_panel.Name = "search_panel"
        Me.search_panel.Padding = New System.Windows.Forms.Padding(0, 0, 0, 10)
        Me.search_panel.Size = New System.Drawing.Size(886, 60)
        Me.search_panel.TabIndex = 0
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
        Me.cart_listview.Font = New System.Drawing.Font("Helvetica", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cart_listview.FullRowSelect = True
        Me.cart_listview.GridLines = True
        Me.cart_listview.HideSelection = False
        Me.cart_listview.Location = New System.Drawing.Point(15, 55)
        Me.cart_listview.Name = "cart_listview"
        Me.cart_listview.Size = New System.Drawing.Size(456, 299)
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
        Me.bottom_panel.BackColor = System.Drawing.Color.FromArgb(CType(CType(166, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.bottom_panel.Controls.Add(Me.cmb_customer)
        Me.bottom_panel.Controls.Add(Me.clear_cart_btn)
        Me.bottom_panel.Controls.Add(Me.complete_sale_btn)
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
        Me.bottom_panel.Controls.Add(Me.lbl_customer)
        Me.bottom_panel.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.bottom_panel.Location = New System.Drawing.Point(15, 354)
        Me.bottom_panel.Name = "bottom_panel"
        Me.bottom_panel.Padding = New System.Windows.Forms.Padding(10)
        Me.bottom_panel.Size = New System.Drawing.Size(456, 424)
        Me.bottom_panel.TabIndex = 1
        '
        'complete_sale_btn
        '
        Me.complete_sale_btn.CheckButton = False
        Me.complete_sale_btn.Checked = False
        Me.complete_sale_btn.CheckedBackground = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.complete_sale_btn.CheckedForeColor = System.Drawing.Color.White
        Me.complete_sale_btn.CheckedImageTint = System.Drawing.Color.White
        Me.complete_sale_btn.CheckedOutline = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.complete_sale_btn.Content = "Complete Sale"
        Me.complete_sale_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.complete_sale_btn.DialogResult = System.Windows.Forms.DialogResult.None
        Me.complete_sale_btn.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.complete_sale_btn.Font = New System.Drawing.Font("Helvetica", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.complete_sale_btn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(166, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.complete_sale_btn.HoverBackground = System.Drawing.Color.White
        Me.complete_sale_btn.HoverForeColor = System.Drawing.Color.DimGray
        Me.complete_sale_btn.HoverImageTint = System.Drawing.Color.DimGray
        Me.complete_sale_btn.HoverOutline = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.complete_sale_btn.Image = Nothing
        Me.complete_sale_btn.ImageExpand = New System.Drawing.Point(0, 0)
        Me.complete_sale_btn.Location = New System.Drawing.Point(10, 364)
        Me.complete_sale_btn.Name = "complete_sale_btn"
        Me.complete_sale_btn.NormalBackground = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(161, Byte), Integer))
        Me.complete_sale_btn.NormalForeColor = System.Drawing.Color.FromArgb(CType(CType(166, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.complete_sale_btn.NormalImageTint = System.Drawing.Color.Black
        Me.complete_sale_btn.NormalOutline = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.complete_sale_btn.OutlineThickness = 1.0!
        Me.complete_sale_btn.Padding = New System.Windows.Forms.Padding(12)
        Me.complete_sale_btn.PressedBackground = System.Drawing.Color.WhiteSmoke
        Me.complete_sale_btn.PressedForeColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.complete_sale_btn.PressedImageTint = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.complete_sale_btn.PressedOutline = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.complete_sale_btn.Rounding = New System.Windows.Forms.Padding(12)
        Me.complete_sale_btn.Size = New System.Drawing.Size(436, 50)
        Me.complete_sale_btn.TabIndex = 16
        Me.complete_sale_btn.TextAlignment = System.Drawing.StringAlignment.Center
        Me.complete_sale_btn.TextPadding = 12
        Me.complete_sale_btn.TextSpacing = 2
        '
        'lbl_change_amount
        '
        Me.lbl_change_amount.Font = New System.Drawing.Font("Helvetica", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_change_amount.ForeColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.lbl_change_amount.Location = New System.Drawing.Point(110, 252)
        Me.lbl_change_amount.Name = "lbl_change_amount"
        Me.lbl_change_amount.Size = New System.Drawing.Size(150, 30)
        Me.lbl_change_amount.TabIndex = 14
        Me.lbl_change_amount.Text = "$0.00"
        Me.lbl_change_amount.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl_change
        '
        Me.lbl_change.AutoSize = True
        Me.lbl_change.Font = New System.Drawing.Font("Helvetica", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_change.Location = New System.Drawing.Point(10, 261)
        Me.lbl_change.Name = "lbl_change"
        Me.lbl_change.Size = New System.Drawing.Size(63, 17)
        Me.lbl_change.TabIndex = 13
        Me.lbl_change.Text = "Change:"
        '
        'lbl_total_amount
        '
        Me.lbl_total_amount.Font = New System.Drawing.Font("Helvetica", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_total_amount.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lbl_total_amount.Location = New System.Drawing.Point(119, 217)
        Me.lbl_total_amount.Name = "lbl_total_amount"
        Me.lbl_total_amount.Size = New System.Drawing.Size(150, 35)
        Me.lbl_total_amount.TabIndex = 12
        Me.lbl_total_amount.Text = "$0.00"
        Me.lbl_total_amount.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl_total
        '
        Me.lbl_total.AutoSize = True
        Me.lbl_total.Font = New System.Drawing.Font("Helvetica", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_total.Location = New System.Drawing.Point(10, 221)
        Me.lbl_total.Name = "lbl_total"
        Me.lbl_total.Size = New System.Drawing.Size(63, 22)
        Me.lbl_total.TabIndex = 11
        Me.lbl_total.Text = "Total:"
        '
        'lbl_vat_amount
        '
        Me.lbl_vat_amount.Font = New System.Drawing.Font("Helvetica", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_vat_amount.Location = New System.Drawing.Point(110, 184)
        Me.lbl_vat_amount.Name = "lbl_vat_amount"
        Me.lbl_vat_amount.Size = New System.Drawing.Size(150, 30)
        Me.lbl_vat_amount.TabIndex = 10
        Me.lbl_vat_amount.Text = "$0.00"
        Me.lbl_vat_amount.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl_vat
        '
        Me.lbl_vat.AutoSize = True
        Me.lbl_vat.Font = New System.Drawing.Font("Helvetica", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_vat.Location = New System.Drawing.Point(10, 191)
        Me.lbl_vat.Name = "lbl_vat"
        Me.lbl_vat.Size = New System.Drawing.Size(81, 17)
        Me.lbl_vat.TabIndex = 9
        Me.lbl_vat.Text = "VAT (11%):"
        '
        'lbl_subtotal_amount
        '
        Me.lbl_subtotal_amount.Font = New System.Drawing.Font("Helvetica", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_subtotal_amount.Location = New System.Drawing.Point(110, 154)
        Me.lbl_subtotal_amount.Name = "lbl_subtotal_amount"
        Me.lbl_subtotal_amount.Size = New System.Drawing.Size(150, 30)
        Me.lbl_subtotal_amount.TabIndex = 8
        Me.lbl_subtotal_amount.Text = "$0.00"
        Me.lbl_subtotal_amount.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl_subtotal
        '
        Me.lbl_subtotal.AutoSize = True
        Me.lbl_subtotal.Font = New System.Drawing.Font("Helvetica", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_subtotal.Location = New System.Drawing.Point(10, 161)
        Me.lbl_subtotal.Name = "lbl_subtotal"
        Me.lbl_subtotal.Size = New System.Drawing.Size(65, 17)
        Me.lbl_subtotal.TabIndex = 7
        Me.lbl_subtotal.Text = "Subtotal:"
        '
        'txt_amount_paid
        '
        Me.txt_amount_paid.BackColor = System.Drawing.Color.Transparent
        Me.txt_amount_paid.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.txt_amount_paid.Content = ""
        Me.txt_amount_paid.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_amount_paid.FocusBackgroundColor = System.Drawing.Color.White
        Me.txt_amount_paid.FocusImageTint = System.Drawing.Color.White
        Me.txt_amount_paid.FocusOutlineColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.txt_amount_paid.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_amount_paid.ForeColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.txt_amount_paid.Image = Nothing
        Me.txt_amount_paid.ImageExpand = New System.Drawing.Point(0, 0)
        Me.txt_amount_paid.ImageOffset = New System.Drawing.Point(0, 0)
        Me.txt_amount_paid.Location = New System.Drawing.Point(135, 105)
        Me.txt_amount_paid.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_amount_paid.Multiline = False
        Me.txt_amount_paid.Name = "txt_amount_paid"
        Me.txt_amount_paid.NormalImageTint = System.Drawing.Color.White
        Me.txt_amount_paid.OutlineColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.txt_amount_paid.Padding = New System.Windows.Forms.Padding(16, 9, 16, 0)
        Me.txt_amount_paid.PasswordChar = False
        Me.txt_amount_paid.PlaceholderColor = System.Drawing.Color.DimGray
        Me.txt_amount_paid.PlaceholderText = "Eg: 100"
        Me.txt_amount_paid.Rounding = New System.Windows.Forms.Padding(8)
        Me.txt_amount_paid.Size = New System.Drawing.Size(125, 35)
        Me.txt_amount_paid.TabIndex = 6
        Me.txt_amount_paid.TextOffset = New System.Drawing.Size(0, 0)
        Me.txt_amount_paid.UnderlinedStyle = True
        '
        'lbl_amount_paid
        '
        Me.lbl_amount_paid.AutoSize = True
        Me.lbl_amount_paid.Font = New System.Drawing.Font("Helvetica", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_amount_paid.Location = New System.Drawing.Point(13, 115)
        Me.lbl_amount_paid.Name = "lbl_amount_paid"
        Me.lbl_amount_paid.Size = New System.Drawing.Size(86, 15)
        Me.lbl_amount_paid.TabIndex = 5
        Me.lbl_amount_paid.Text = "Amount Paid:"
        '
        'radio_card
        '
        Me.radio_card.AutoSize = True
        Me.radio_card.Font = New System.Drawing.Font("Helvetica", 10.0!)
        Me.radio_card.Location = New System.Drawing.Point(387, 46)
        Me.radio_card.Name = "radio_card"
        Me.radio_card.Size = New System.Drawing.Size(56, 20)
        Me.radio_card.TabIndex = 4
        Me.radio_card.Text = "Card"
        Me.radio_card.UseVisualStyleBackColor = True
        '
        'radio_cash
        '
        Me.radio_cash.AutoSize = True
        Me.radio_cash.Checked = True
        Me.radio_cash.Font = New System.Drawing.Font("Helvetica", 10.0!)
        Me.radio_cash.Location = New System.Drawing.Point(310, 46)
        Me.radio_cash.Name = "radio_cash"
        Me.radio_cash.Size = New System.Drawing.Size(58, 20)
        Me.radio_cash.TabIndex = 3
        Me.radio_cash.TabStop = True
        Me.radio_cash.Text = "Cash"
        Me.radio_cash.UseVisualStyleBackColor = True
        '
        'lbl_payment_method
        '
        Me.lbl_payment_method.AutoSize = True
        Me.lbl_payment_method.Font = New System.Drawing.Font("Helvetica", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_payment_method.Location = New System.Drawing.Point(307, 10)
        Me.lbl_payment_method.Name = "lbl_payment_method"
        Me.lbl_payment_method.Size = New System.Drawing.Size(136, 17)
        Me.lbl_payment_method.TabIndex = 2
        Me.lbl_payment_method.Text = "Payment Method:"
        '
        'lbl_customer
        '
        Me.lbl_customer.AutoSize = True
        Me.lbl_customer.Font = New System.Drawing.Font("Helvetica", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_customer.Location = New System.Drawing.Point(10, 10)
        Me.lbl_customer.Name = "lbl_customer"
        Me.lbl_customer.Size = New System.Drawing.Size(145, 17)
        Me.lbl_customer.TabIndex = 0
        Me.lbl_customer.Text = "Customer (Optional):"
        '
        'lbl_order_details
        '
        Me.lbl_order_details.BackColor = System.Drawing.Color.FromArgb(CType(CType(166, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lbl_order_details.Dock = System.Windows.Forms.DockStyle.Top
        Me.lbl_order_details.Font = New System.Drawing.Font("Helvetica", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_order_details.Location = New System.Drawing.Point(15, 15)
        Me.lbl_order_details.Name = "lbl_order_details"
        Me.lbl_order_details.Size = New System.Drawing.Size(456, 40)
        Me.lbl_order_details.TabIndex = 0
        Me.lbl_order_details.Text = "Order Details"
        Me.lbl_order_details.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'delete_confirmation
        '
        Me.delete_confirmation.BackColor = System.Drawing.Color.White
        Me.delete_confirmation.ButtonSize = New System.Drawing.Size(80, 32)
        Me.delete_confirmation.CancelText = ""
        Me.delete_confirmation.DialogPadding = New System.Windows.Forms.Padding(30)
        Me.delete_confirmation.DialogSize = New System.Drawing.Size(430, 300)
        Me.delete_confirmation.DimColor = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.delete_confirmation.ForeColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.delete_confirmation.NoText = "No"
        Me.delete_confirmation.OKText = ""
        Me.delete_confirmation.Rounding = 12
        Me.delete_confirmation.YesText = "Yes"
        '
        'clear_cart_btn
        '
        Me.clear_cart_btn.CheckButton = False
        Me.clear_cart_btn.Checked = False
        Me.clear_cart_btn.CheckedBackground = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.clear_cart_btn.CheckedForeColor = System.Drawing.Color.White
        Me.clear_cart_btn.CheckedImageTint = System.Drawing.Color.White
        Me.clear_cart_btn.CheckedOutline = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.clear_cart_btn.Content = "Clear Cart"
        Me.clear_cart_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.clear_cart_btn.DialogResult = System.Windows.Forms.DialogResult.None
        Me.clear_cart_btn.Font = New System.Drawing.Font("Helvetica", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clear_cart_btn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.clear_cart_btn.HoverBackground = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(161, Byte), Integer))
        Me.clear_cart_btn.HoverForeColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.clear_cart_btn.HoverImageTint = System.Drawing.Color.White
        Me.clear_cart_btn.HoverOutline = System.Drawing.Color.Transparent
        Me.clear_cart_btn.Image = Nothing
        Me.clear_cart_btn.ImageExpand = New System.Drawing.Point(3, 3)
        Me.clear_cart_btn.ImeMode = System.Windows.Forms.ImeMode.Close
        Me.clear_cart_btn.Location = New System.Drawing.Point(13, 307)
        Me.clear_cart_btn.Name = "clear_cart_btn"
        Me.clear_cart_btn.NormalBackground = System.Drawing.Color.Transparent
        Me.clear_cart_btn.NormalForeColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.clear_cart_btn.NormalImageTint = System.Drawing.Color.White
        Me.clear_cart_btn.NormalOutline = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.clear_cart_btn.OutlineThickness = 3.0!
        Me.clear_cart_btn.Padding = New System.Windows.Forms.Padding(12)
        Me.clear_cart_btn.PressedBackground = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.clear_cart_btn.PressedForeColor = System.Drawing.Color.White
        Me.clear_cart_btn.PressedImageTint = System.Drawing.Color.White
        Me.clear_cart_btn.PressedOutline = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.clear_cart_btn.Rounding = New System.Windows.Forms.Padding(12)
        Me.clear_cart_btn.Size = New System.Drawing.Size(147, 42)
        Me.clear_cart_btn.TabIndex = 109
        Me.clear_cart_btn.TextAlignment = System.Drawing.StringAlignment.Center
        Me.clear_cart_btn.TextPadding = 12
        Me.clear_cart_btn.TextSpacing = 2
        '
        'cmb_customer
        '
        Me.cmb_customer.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.cmb_customer.DropDownBackgroundColor = System.Drawing.Color.White
        Me.cmb_customer.DropDownForeColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(27, Byte), Integer))
        Me.cmb_customer.ExpandArrowColor = System.Drawing.Color.Gray
        Me.cmb_customer.Font = New System.Drawing.Font("Helvetica", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_customer.ForeColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.cmb_customer.Items = New String(-1) {}
        Me.cmb_customer.Location = New System.Drawing.Point(10, 32)
        Me.cmb_customer.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.cmb_customer.MaxDropDownHeight = 240
        Me.cmb_customer.Name = "cmb_customer"
        Me.cmb_customer.NoSelectionText = "Select"
        Me.cmb_customer.OutlineColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.cmb_customer.OutlineThickness = 1.0!
        Me.cmb_customer.Rounding = 12
        Me.cmb_customer.SelectedIndex = -1
        Me.cmb_customer.SelectedItem = ""
        Me.cmb_customer.Size = New System.Drawing.Size(250, 40)
        Me.cmb_customer.SortAlphabetically = True
        Me.cmb_customer.TabIndex = 119
        '
        'search_box
        '
        Me.search_box.BackColor = System.Drawing.Color.Transparent
        Me.search_box.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.search_box.Content = ""
        Me.search_box.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.search_box.FocusBackgroundColor = System.Drawing.Color.FromArgb(CType(CType(166, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.search_box.FocusImageTint = System.Drawing.Color.White
        Me.search_box.FocusOutlineColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.search_box.Font = New System.Drawing.Font("Helvetica", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.search_box.ForeColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.search_box.Image = Nothing
        Me.search_box.ImageExpand = New System.Drawing.Point(0, 0)
        Me.search_box.ImageOffset = New System.Drawing.Point(0, 0)
        Me.search_box.Location = New System.Drawing.Point(17, 13)
        Me.search_box.Margin = New System.Windows.Forms.Padding(4)
        Me.search_box.Multiline = False
        Me.search_box.Name = "search_box"
        Me.search_box.NormalImageTint = System.Drawing.Color.Silver
        Me.search_box.OutlineColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.search_box.Padding = New System.Windows.Forms.Padding(23, 9, 23, 0)
        Me.search_box.PasswordChar = False
        Me.search_box.PlaceholderColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.search_box.PlaceholderText = "Search"
        Me.search_box.Rounding = New System.Windows.Forms.Padding(12)
        Me.search_box.Size = New System.Drawing.Size(500, 40)
        Me.search_box.TabIndex = 123
        Me.search_box.TextOffset = New System.Drawing.Size(0, 0)
        Me.search_box.UnderlinedStyle = True
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
    Friend WithEvents right_panel As Panel
    Friend WithEvents cart_listview As ListView
    Friend WithEvents col_product As ColumnHeader
    Friend WithEvents col_qty As ColumnHeader
    Friend WithEvents col_price As ColumnHeader
    Friend WithEvents cart_context_menu As ContextMenuStrip
    Friend WithEvents remove_item_menu As ToolStripMenuItem
    Friend WithEvents bottom_panel As Panel
    Friend WithEvents complete_sale_btn As CuoreUI.Controls.cuiButton
    Friend WithEvents lbl_change_amount As Label
    Friend WithEvents lbl_change As Label
    Friend WithEvents lbl_total_amount As Label
    Friend WithEvents lbl_total As Label
    Friend WithEvents lbl_vat_amount As Label
    Friend WithEvents lbl_vat As Label
    Friend WithEvents lbl_subtotal_amount As Label
    Friend WithEvents lbl_subtotal As Label
    Friend WithEvents txt_amount_paid As CuoreUI.Controls.cuiTextBox
    Friend WithEvents lbl_amount_paid As Label
    Friend WithEvents radio_card As RadioButton
    Friend WithEvents radio_cash As RadioButton
    Friend WithEvents lbl_payment_method As Label
    Friend WithEvents lbl_customer As Label
    Friend WithEvents lbl_order_details As Label
    Friend WithEvents delete_confirmation As CuoreUI.Components.cuiMessageDialog
    Friend WithEvents clear_cart_btn As CuoreUI.Controls.cuiButton
    Friend WithEvents cmb_customer As CuoreUI.Controls.cuiComboBox
    Friend WithEvents search_box As CuoreUI.Controls.cuiTextBox
End Class