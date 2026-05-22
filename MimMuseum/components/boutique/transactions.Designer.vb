<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class transactions
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.MaterialDivider1 = New ReaLTaiizor.Controls.MaterialDivider()
        Me.search_input = New CuoreUI.Controls.cuiTextBox()
        Me.transactions_grid = New MetroFramework.Controls.MetroGrid()
        Me.items_list = New System.Windows.Forms.ListView()
        Me.view_receipt_btn = New CuoreUI.Controls.cuiButton()
        Me.delete_confirmation = New CuoreUI.Components.cuiMessageDialog()
        Me.item = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.qty = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.price = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        CType(Me.transactions_grid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MaterialDivider1
        '
        Me.MaterialDivider1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(161, Byte), Integer))
        Me.MaterialDivider1.Depth = 0
        Me.MaterialDivider1.Location = New System.Drawing.Point(2, 189)
        Me.MaterialDivider1.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER
        Me.MaterialDivider1.Name = "MaterialDivider1"
        Me.MaterialDivider1.Size = New System.Drawing.Size(2314, 1)
        Me.MaterialDivider1.TabIndex = 132
        Me.MaterialDivider1.Text = "MaterialDivider1"
        '
        'search_input
        '
        Me.search_input.BackColor = System.Drawing.Color.Transparent
        Me.search_input.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.search_input.Content = ""
        Me.search_input.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.search_input.FocusBackgroundColor = System.Drawing.Color.FromArgb(CType(CType(166, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.search_input.FocusImageTint = System.Drawing.Color.White
        Me.search_input.FocusOutlineColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.search_input.Font = New System.Drawing.Font("Helvetica", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.search_input.ForeColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.search_input.Image = Nothing
        Me.search_input.ImageExpand = New System.Drawing.Point(0, 0)
        Me.search_input.ImageOffset = New System.Drawing.Point(0, 0)
        Me.search_input.Location = New System.Drawing.Point(86, 90)
        Me.search_input.Margin = New System.Windows.Forms.Padding(4)
        Me.search_input.Multiline = False
        Me.search_input.Name = "search_input"
        Me.search_input.NormalImageTint = System.Drawing.Color.Silver
        Me.search_input.OutlineColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.search_input.Padding = New System.Windows.Forms.Padding(23, 19, 23, 0)
        Me.search_input.PasswordChar = False
        Me.search_input.PlaceholderColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.search_input.PlaceholderText = "Search"
        Me.search_input.Rounding = New System.Windows.Forms.Padding(12)
        Me.search_input.Size = New System.Drawing.Size(1585, 61)
        Me.search_input.TabIndex = 131
        Me.search_input.TextOffset = New System.Drawing.Size(0, 0)
        Me.search_input.UnderlinedStyle = True
        '
        'transactions_grid
        '
        Me.transactions_grid.AllowUserToAddRows = False
        Me.transactions_grid.AllowUserToDeleteRows = False
        Me.transactions_grid.AllowUserToResizeColumns = False
        Me.transactions_grid.AllowUserToResizeRows = False
        Me.transactions_grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.transactions_grid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.transactions_grid.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.transactions_grid.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.transactions_grid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenHorizontal
        Me.transactions_grid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(84, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Helvetica", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle5.Padding = New System.Windows.Forms.Padding(10, 0, 10, 0)
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(84, Byte), Integer))
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.transactions_grid.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.transactions_grid.ColumnHeadersHeight = 70
        Me.transactions_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Helvetica", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.transactions_grid.DefaultCellStyle = DataGridViewCellStyle6
        Me.transactions_grid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2
        Me.transactions_grid.EnableHeadersVisualStyles = False
        Me.transactions_grid.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.transactions_grid.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.transactions_grid.Location = New System.Drawing.Point(86, 226)
        Me.transactions_grid.Name = "transactions_grid"
        Me.transactions_grid.ReadOnly = True
        Me.transactions_grid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(217, Byte), Integer))
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Helvetica", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(250, Byte), Integer))
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.transactions_grid.RowHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.transactions_grid.RowHeadersVisible = False
        Me.transactions_grid.RowHeadersWidth = 50
        Me.transactions_grid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(217, Byte), Integer))
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Helvetica", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle8.Padding = New System.Windows.Forms.Padding(0, 15, 0, 20)
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(250, Byte), Integer))
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White
        Me.transactions_grid.RowsDefaultCellStyle = DataGridViewCellStyle8
        Me.transactions_grid.RowTemplate.Height = 42
        Me.transactions_grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.transactions_grid.Size = New System.Drawing.Size(1585, 970)
        Me.transactions_grid.TabIndex = 130
        '
        'items_list
        '
        Me.items_list.BackColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.items_list.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.item, Me.qty, Me.price})
        Me.items_list.Font = New System.Drawing.Font("Helvetica", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.items_list.HideSelection = False
        Me.items_list.Location = New System.Drawing.Point(1720, 226)
        Me.items_list.Name = "items_list"
        Me.items_list.Size = New System.Drawing.Size(524, 970)
        Me.items_list.TabIndex = 133
        Me.items_list.UseCompatibleStateImageBehavior = False
        Me.items_list.View = System.Windows.Forms.View.Details
        '
        'view_receipt_btn
        '
        Me.view_receipt_btn.CheckButton = False
        Me.view_receipt_btn.Checked = False
        Me.view_receipt_btn.CheckedBackground = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.view_receipt_btn.CheckedForeColor = System.Drawing.Color.White
        Me.view_receipt_btn.CheckedImageTint = System.Drawing.Color.White
        Me.view_receipt_btn.CheckedOutline = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.view_receipt_btn.Content = "View Receipt"
        Me.view_receipt_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.view_receipt_btn.DialogResult = System.Windows.Forms.DialogResult.None
        Me.view_receipt_btn.Font = New System.Drawing.Font("Helvetica", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.view_receipt_btn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.view_receipt_btn.HoverBackground = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(161, Byte), Integer))
        Me.view_receipt_btn.HoverForeColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.view_receipt_btn.HoverImageTint = System.Drawing.Color.White
        Me.view_receipt_btn.HoverOutline = System.Drawing.Color.Transparent
        Me.view_receipt_btn.Image = Nothing
        Me.view_receipt_btn.ImageExpand = New System.Drawing.Point(3, 3)
        Me.view_receipt_btn.ImeMode = System.Windows.Forms.ImeMode.Close
        Me.view_receipt_btn.Location = New System.Drawing.Point(2088, 90)
        Me.view_receipt_btn.Name = "view_receipt_btn"
        Me.view_receipt_btn.NormalBackground = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.view_receipt_btn.NormalForeColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.view_receipt_btn.NormalImageTint = System.Drawing.Color.White
        Me.view_receipt_btn.NormalOutline = System.Drawing.Color.Transparent
        Me.view_receipt_btn.OutlineThickness = 1.0!
        Me.view_receipt_btn.Padding = New System.Windows.Forms.Padding(12)
        Me.view_receipt_btn.PressedBackground = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.view_receipt_btn.PressedForeColor = System.Drawing.Color.White
        Me.view_receipt_btn.PressedImageTint = System.Drawing.Color.White
        Me.view_receipt_btn.PressedOutline = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.view_receipt_btn.Rounding = New System.Windows.Forms.Padding(12)
        Me.view_receipt_btn.Size = New System.Drawing.Size(156, 49)
        Me.view_receipt_btn.TabIndex = 134
        Me.view_receipt_btn.TextAlignment = System.Drawing.StringAlignment.Center
        Me.view_receipt_btn.TextPadding = 12
        Me.view_receipt_btn.TextSpacing = 2
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
        'item
        '
        Me.item.Text = "item"
        Me.item.Width = 300
        '
        'qty
        '
        Me.qty.Text = "qty"
        Me.qty.Width = 70
        '
        'price
        '
        Me.price.Text = "price"
        Me.price.Width = 150
        '
        'transactions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(166, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Controls.Add(Me.view_receipt_btn)
        Me.Controls.Add(Me.items_list)
        Me.Controls.Add(Me.MaterialDivider1)
        Me.Controls.Add(Me.search_input)
        Me.Controls.Add(Me.transactions_grid)
        Me.Name = "transactions"
        Me.Size = New System.Drawing.Size(2318, 1291)
        CType(Me.transactions_grid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MaterialDivider1 As ReaLTaiizor.Controls.MaterialDivider
    Friend WithEvents search_input As CuoreUI.Controls.cuiTextBox
    Friend WithEvents transactions_grid As MetroFramework.Controls.MetroGrid
    Friend WithEvents items_list As ListView
    Friend WithEvents view_receipt_btn As CuoreUI.Controls.cuiButton
    Friend WithEvents delete_confirmation As CuoreUI.Components.cuiMessageDialog
    Friend WithEvents item As ColumnHeader
    Friend WithEvents qty As ColumnHeader
    Friend WithEvents price As ColumnHeader
End Class
