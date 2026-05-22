<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class customers
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.radio_female = New ReaLTaiizor.Controls.ParrotRadioButton()
        Me.tbc = New System.Windows.Forms.TabControl()
        Me.pg_browse = New System.Windows.Forms.TabPage()
        Me.MaterialDivider1 = New ReaLTaiizor.Controls.MaterialDivider()
        Me.search_input = New CuoreUI.Controls.cuiTextBox()
        Me.customers_grid = New MetroFramework.Controls.MetroGrid()
        Me.pg_manage = New System.Windows.Forms.TabPage()
        Me.radio_male = New ReaLTaiizor.Controls.ParrotRadioButton()
        Me.cancel_btn = New CuoreUI.Controls.cuiButton()
        Me.confirm_btn = New CuoreUI.Controls.cuiButton()
        Me.CuiLabel5 = New CuoreUI.Controls.cuiLabel()
        Me.CuiLabel12 = New CuoreUI.Controls.cuiLabel()
        Me.phone_input = New CuoreUI.Controls.cuiTextBox()
        Me.mode_lbl = New CuoreUI.Controls.cuiLabel()
        Me.first_name_input = New CuoreUI.Controls.cuiTextBox()
        Me.CuiLabel15 = New CuoreUI.Controls.cuiLabel()
        Me.CuiLabel9 = New CuoreUI.Controls.cuiLabel()
        Me.last_name_input = New CuoreUI.Controls.cuiTextBox()
        Me.email_input = New CuoreUI.Controls.cuiTextBox()
        Me.CuiLabel4 = New CuoreUI.Controls.cuiLabel()
        Me.CuiLabel3 = New CuoreUI.Controls.cuiLabel()
        Me.delete_confirmation = New CuoreUI.Components.cuiMessageDialog()
        Me.tbc.SuspendLayout()
        Me.pg_browse.SuspendLayout()
        CType(Me.customers_grid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pg_manage.SuspendLayout()
        Me.SuspendLayout()
        '
        'radio_female
        '
        Me.radio_female.Checked = False
        Me.radio_female.Cursor = System.Windows.Forms.Cursors.Hand
        Me.radio_female.ForeColor = System.Drawing.Color.White
        Me.radio_female.Location = New System.Drawing.Point(907, 455)
        Me.radio_female.Name = "radio_female"
        Me.radio_female.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality
        Me.radio_female.RadioColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(162, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.radio_female.RadioHoverColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(98, Byte), Integer))
        Me.radio_female.RadioStyle = ReaLTaiizor.Controls.ParrotRadioButton.Style.Material
        Me.radio_female.Size = New System.Drawing.Size(147, 26)
        Me.radio_female.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias
        Me.radio_female.TabIndex = 129
        Me.radio_female.Text = "Female"
        Me.radio_female.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit
        '
        'tbc
        '
        Me.tbc.Controls.Add(Me.pg_browse)
        Me.tbc.Controls.Add(Me.pg_manage)
        Me.tbc.Font = New System.Drawing.Font("Helvetica", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbc.Location = New System.Drawing.Point(-9, -4)
        Me.tbc.Name = "tbc"
        Me.tbc.SelectedIndex = 0
        Me.tbc.Size = New System.Drawing.Size(2337, 1298)
        Me.tbc.TabIndex = 2
        '
        'pg_browse
        '
        Me.pg_browse.BackColor = System.Drawing.Color.FromArgb(CType(CType(166, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.pg_browse.Controls.Add(Me.MaterialDivider1)
        Me.pg_browse.Controls.Add(Me.search_input)
        Me.pg_browse.Controls.Add(Me.customers_grid)
        Me.pg_browse.Location = New System.Drawing.Point(4, 26)
        Me.pg_browse.Name = "pg_browse"
        Me.pg_browse.Padding = New System.Windows.Forms.Padding(3)
        Me.pg_browse.Size = New System.Drawing.Size(2329, 1268)
        Me.pg_browse.TabIndex = 0
        Me.pg_browse.Text = "Browse"
        '
        'MaterialDivider1
        '
        Me.MaterialDivider1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(161, Byte), Integer))
        Me.MaterialDivider1.Depth = 0
        Me.MaterialDivider1.Location = New System.Drawing.Point(6, 144)
        Me.MaterialDivider1.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER
        Me.MaterialDivider1.Name = "MaterialDivider1"
        Me.MaterialDivider1.Size = New System.Drawing.Size(2314, 1)
        Me.MaterialDivider1.TabIndex = 123
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
        Me.search_input.Location = New System.Drawing.Point(503, 45)
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
        Me.search_input.Size = New System.Drawing.Size(1304, 61)
        Me.search_input.TabIndex = 122
        Me.search_input.TextOffset = New System.Drawing.Size(0, 0)
        Me.search_input.UnderlinedStyle = True
        '
        'customers_grid
        '
        Me.customers_grid.AllowUserToAddRows = False
        Me.customers_grid.AllowUserToDeleteRows = False
        Me.customers_grid.AllowUserToResizeColumns = False
        Me.customers_grid.AllowUserToResizeRows = False
        Me.customers_grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.customers_grid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.customers_grid.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.customers_grid.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.customers_grid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenHorizontal
        Me.customers_grid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(84, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Helvetica", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle1.Padding = New System.Windows.Forms.Padding(10, 0, 10, 0)
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(84, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.customers_grid.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.customers_grid.ColumnHeadersHeight = 70
        Me.customers_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Helvetica", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.customers_grid.DefaultCellStyle = DataGridViewCellStyle2
        Me.customers_grid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2
        Me.customers_grid.EnableHeadersVisualStyles = False
        Me.customers_grid.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.customers_grid.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.customers_grid.Location = New System.Drawing.Point(88, 185)
        Me.customers_grid.Name = "customers_grid"
        Me.customers_grid.ReadOnly = True
        Me.customers_grid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(217, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Helvetica", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(250, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.customers_grid.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.customers_grid.RowHeadersVisible = False
        Me.customers_grid.RowHeadersWidth = 50
        Me.customers_grid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(217, Byte), Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Helvetica", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle4.Padding = New System.Windows.Forms.Padding(0, 15, 0, 20)
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(250, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White
        Me.customers_grid.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.customers_grid.RowTemplate.Height = 42
        Me.customers_grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.customers_grid.Size = New System.Drawing.Size(2147, 970)
        Me.customers_grid.TabIndex = 9
        '
        'pg_manage
        '
        Me.pg_manage.BackColor = System.Drawing.Color.FromArgb(CType(CType(166, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.pg_manage.Controls.Add(Me.radio_female)
        Me.pg_manage.Controls.Add(Me.radio_male)
        Me.pg_manage.Controls.Add(Me.cancel_btn)
        Me.pg_manage.Controls.Add(Me.confirm_btn)
        Me.pg_manage.Controls.Add(Me.CuiLabel5)
        Me.pg_manage.Controls.Add(Me.CuiLabel12)
        Me.pg_manage.Controls.Add(Me.phone_input)
        Me.pg_manage.Controls.Add(Me.mode_lbl)
        Me.pg_manage.Controls.Add(Me.first_name_input)
        Me.pg_manage.Controls.Add(Me.CuiLabel15)
        Me.pg_manage.Controls.Add(Me.CuiLabel9)
        Me.pg_manage.Controls.Add(Me.last_name_input)
        Me.pg_manage.Controls.Add(Me.email_input)
        Me.pg_manage.Controls.Add(Me.CuiLabel4)
        Me.pg_manage.Controls.Add(Me.CuiLabel3)
        Me.pg_manage.Location = New System.Drawing.Point(4, 26)
        Me.pg_manage.Name = "pg_manage"
        Me.pg_manage.Padding = New System.Windows.Forms.Padding(3)
        Me.pg_manage.Size = New System.Drawing.Size(2329, 1268)
        Me.pg_manage.TabIndex = 1
        Me.pg_manage.Text = "Manage"
        '
        'radio_male
        '
        Me.radio_male.Checked = False
        Me.radio_male.Cursor = System.Windows.Forms.Cursors.Hand
        Me.radio_male.ForeColor = System.Drawing.Color.White
        Me.radio_male.Location = New System.Drawing.Point(757, 455)
        Me.radio_male.Name = "radio_male"
        Me.radio_male.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality
        Me.radio_male.RadioColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(162, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.radio_male.RadioHoverColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(98, Byte), Integer))
        Me.radio_male.RadioStyle = ReaLTaiizor.Controls.ParrotRadioButton.Style.Material
        Me.radio_male.Size = New System.Drawing.Size(125, 26)
        Me.radio_male.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias
        Me.radio_male.TabIndex = 128
        Me.radio_male.Text = "Male"
        Me.radio_male.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit
        '
        'cancel_btn
        '
        Me.cancel_btn.CheckButton = False
        Me.cancel_btn.Checked = False
        Me.cancel_btn.CheckedBackground = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cancel_btn.CheckedForeColor = System.Drawing.Color.White
        Me.cancel_btn.CheckedImageTint = System.Drawing.Color.White
        Me.cancel_btn.CheckedOutline = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cancel_btn.Content = "Cancel"
        Me.cancel_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cancel_btn.DialogResult = System.Windows.Forms.DialogResult.None
        Me.cancel_btn.Font = New System.Drawing.Font("Helvetica", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cancel_btn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.cancel_btn.HoverBackground = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(161, Byte), Integer))
        Me.cancel_btn.HoverForeColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.cancel_btn.HoverImageTint = System.Drawing.Color.White
        Me.cancel_btn.HoverOutline = System.Drawing.Color.Transparent
        Me.cancel_btn.Image = Nothing
        Me.cancel_btn.ImageExpand = New System.Drawing.Point(3, 3)
        Me.cancel_btn.ImeMode = System.Windows.Forms.ImeMode.Close
        Me.cancel_btn.Location = New System.Drawing.Point(1147, 728)
        Me.cancel_btn.Name = "cancel_btn"
        Me.cancel_btn.NormalBackground = System.Drawing.Color.Transparent
        Me.cancel_btn.NormalForeColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.cancel_btn.NormalImageTint = System.Drawing.Color.White
        Me.cancel_btn.NormalOutline = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.cancel_btn.OutlineThickness = 3.0!
        Me.cancel_btn.Padding = New System.Windows.Forms.Padding(12)
        Me.cancel_btn.PressedBackground = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.cancel_btn.PressedForeColor = System.Drawing.Color.White
        Me.cancel_btn.PressedImageTint = System.Drawing.Color.White
        Me.cancel_btn.PressedOutline = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.cancel_btn.Rounding = New System.Windows.Forms.Padding(12)
        Me.cancel_btn.Size = New System.Drawing.Size(126, 49)
        Me.cancel_btn.TabIndex = 108
        Me.cancel_btn.TextAlignment = System.Drawing.StringAlignment.Center
        Me.cancel_btn.TextPadding = 12
        Me.cancel_btn.TextSpacing = 2
        '
        'confirm_btn
        '
        Me.confirm_btn.CheckButton = False
        Me.confirm_btn.Checked = False
        Me.confirm_btn.CheckedBackground = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.confirm_btn.CheckedForeColor = System.Drawing.Color.White
        Me.confirm_btn.CheckedImageTint = System.Drawing.Color.White
        Me.confirm_btn.CheckedOutline = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.confirm_btn.Content = "Confirm"
        Me.confirm_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.confirm_btn.DialogResult = System.Windows.Forms.DialogResult.None
        Me.confirm_btn.Font = New System.Drawing.Font("Helvetica", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.confirm_btn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.confirm_btn.HoverBackground = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(161, Byte), Integer))
        Me.confirm_btn.HoverForeColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.confirm_btn.HoverImageTint = System.Drawing.Color.White
        Me.confirm_btn.HoverOutline = System.Drawing.Color.Transparent
        Me.confirm_btn.Image = Nothing
        Me.confirm_btn.ImageExpand = New System.Drawing.Point(3, 3)
        Me.confirm_btn.ImeMode = System.Windows.Forms.ImeMode.Close
        Me.confirm_btn.Location = New System.Drawing.Point(970, 728)
        Me.confirm_btn.Name = "confirm_btn"
        Me.confirm_btn.NormalBackground = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.confirm_btn.NormalForeColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.confirm_btn.NormalImageTint = System.Drawing.Color.White
        Me.confirm_btn.NormalOutline = System.Drawing.Color.Transparent
        Me.confirm_btn.OutlineThickness = 1.0!
        Me.confirm_btn.Padding = New System.Windows.Forms.Padding(12)
        Me.confirm_btn.PressedBackground = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.confirm_btn.PressedForeColor = System.Drawing.Color.White
        Me.confirm_btn.PressedImageTint = System.Drawing.Color.White
        Me.confirm_btn.PressedOutline = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.confirm_btn.Rounding = New System.Windows.Forms.Padding(12)
        Me.confirm_btn.Size = New System.Drawing.Size(156, 49)
        Me.confirm_btn.TabIndex = 10
        Me.confirm_btn.TextAlignment = System.Drawing.StringAlignment.Center
        Me.confirm_btn.TextPadding = 12
        Me.confirm_btn.TextSpacing = 2
        '
        'CuiLabel5
        '
        Me.CuiLabel5.BackColor = System.Drawing.Color.Transparent
        Me.CuiLabel5.Content = "Manage\ Customers"
        Me.CuiLabel5.Font = New System.Drawing.Font("Helvetica", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CuiLabel5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.CuiLabel5.HorizontalAlignment = System.Drawing.StringAlignment.Center
        Me.CuiLabel5.Location = New System.Drawing.Point(945, 46)
        Me.CuiLabel5.Name = "CuiLabel5"
        Me.CuiLabel5.Size = New System.Drawing.Size(316, 65)
        Me.CuiLabel5.TabIndex = 85
        Me.CuiLabel5.VerticalAlignment = System.Drawing.StringAlignment.Near
        '
        'CuiLabel12
        '
        Me.CuiLabel12.BackColor = System.Drawing.Color.Transparent
        Me.CuiLabel12.Content = "Phone"
        Me.CuiLabel12.Font = New System.Drawing.Font("Helvetica", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CuiLabel12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.CuiLabel12.HorizontalAlignment = System.Drawing.StringAlignment.Center
        Me.CuiLabel12.Location = New System.Drawing.Point(1109, 402)
        Me.CuiLabel12.Name = "CuiLabel12"
        Me.CuiLabel12.Size = New System.Drawing.Size(166, 32)
        Me.CuiLabel12.TabIndex = 126
        Me.CuiLabel12.VerticalAlignment = System.Drawing.StringAlignment.Near
        '
        'phone_input
        '
        Me.phone_input.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.phone_input.Content = ""
        Me.phone_input.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.phone_input.FocusBackgroundColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.phone_input.FocusImageTint = System.Drawing.Color.White
        Me.phone_input.FocusOutlineColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.phone_input.Font = New System.Drawing.Font("Helvetica", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.phone_input.ForeColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.phone_input.Image = Nothing
        Me.phone_input.ImageExpand = New System.Drawing.Point(0, 0)
        Me.phone_input.ImageOffset = New System.Drawing.Point(0, 0)
        Me.phone_input.Location = New System.Drawing.Point(1159, 432)
        Me.phone_input.Margin = New System.Windows.Forms.Padding(4)
        Me.phone_input.Multiline = False
        Me.phone_input.Name = "phone_input"
        Me.phone_input.NormalImageTint = System.Drawing.Color.Silver
        Me.phone_input.OutlineColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.phone_input.Padding = New System.Windows.Forms.Padding(23, 13, 23, 0)
        Me.phone_input.PasswordChar = False
        Me.phone_input.PlaceholderColor = System.Drawing.Color.DimGray
        Me.phone_input.PlaceholderText = "ex: +961 70 000 000"
        Me.phone_input.Rounding = New System.Windows.Forms.Padding(12)
        Me.phone_input.Size = New System.Drawing.Size(365, 49)
        Me.phone_input.TabIndex = 125
        Me.phone_input.TextOffset = New System.Drawing.Size(0, 0)
        Me.phone_input.UnderlinedStyle = True
        '
        'mode_lbl
        '
        Me.mode_lbl.BackColor = System.Drawing.Color.Transparent
        Me.mode_lbl.Content = "Mode:\ ADD"
        Me.mode_lbl.Font = New System.Drawing.Font("Helvetica", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mode_lbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(98, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.mode_lbl.HorizontalAlignment = System.Drawing.StringAlignment.Center
        Me.mode_lbl.Location = New System.Drawing.Point(998, 130)
        Me.mode_lbl.Name = "mode_lbl"
        Me.mode_lbl.Size = New System.Drawing.Size(227, 44)
        Me.mode_lbl.TabIndex = 124
        Me.mode_lbl.VerticalAlignment = System.Drawing.StringAlignment.Near
        '
        'first_name_input
        '
        Me.first_name_input.BackColor = System.Drawing.Color.Transparent
        Me.first_name_input.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.first_name_input.Content = ""
        Me.first_name_input.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.first_name_input.FocusBackgroundColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.first_name_input.FocusImageTint = System.Drawing.Color.White
        Me.first_name_input.FocusOutlineColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.first_name_input.Font = New System.Drawing.Font("Helvetica", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.first_name_input.ForeColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.first_name_input.Image = Nothing
        Me.first_name_input.ImageExpand = New System.Drawing.Point(0, 0)
        Me.first_name_input.ImageOffset = New System.Drawing.Point(0, 0)
        Me.first_name_input.Location = New System.Drawing.Point(757, 325)
        Me.first_name_input.Margin = New System.Windows.Forms.Padding(4)
        Me.first_name_input.Multiline = False
        Me.first_name_input.Name = "first_name_input"
        Me.first_name_input.NormalImageTint = System.Drawing.Color.Silver
        Me.first_name_input.OutlineColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.first_name_input.Padding = New System.Windows.Forms.Padding(23, 13, 23, 0)
        Me.first_name_input.PasswordChar = False
        Me.first_name_input.PlaceholderColor = System.Drawing.Color.DimGray
        Me.first_name_input.PlaceholderText = "First Name"
        Me.first_name_input.Rounding = New System.Windows.Forms.Padding(12)
        Me.first_name_input.Size = New System.Drawing.Size(369, 49)
        Me.first_name_input.TabIndex = 121
        Me.first_name_input.TextOffset = New System.Drawing.Size(0, 0)
        Me.first_name_input.UnderlinedStyle = True
        '
        'CuiLabel15
        '
        Me.CuiLabel15.BackColor = System.Drawing.Color.Transparent
        Me.CuiLabel15.Content = "Last\ Name"
        Me.CuiLabel15.Font = New System.Drawing.Font("Helvetica", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CuiLabel15.ForeColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.CuiLabel15.HorizontalAlignment = System.Drawing.StringAlignment.Center
        Me.CuiLabel15.Location = New System.Drawing.Point(1147, 295)
        Me.CuiLabel15.Name = "CuiLabel15"
        Me.CuiLabel15.Size = New System.Drawing.Size(128, 30)
        Me.CuiLabel15.TabIndex = 87
        Me.CuiLabel15.VerticalAlignment = System.Drawing.StringAlignment.Near
        '
        'CuiLabel9
        '
        Me.CuiLabel9.BackColor = System.Drawing.Color.Transparent
        Me.CuiLabel9.Content = "First\ Name"
        Me.CuiLabel9.Font = New System.Drawing.Font("Helvetica", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CuiLabel9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.CuiLabel9.HorizontalAlignment = System.Drawing.StringAlignment.Center
        Me.CuiLabel9.Location = New System.Drawing.Point(754, 295)
        Me.CuiLabel9.Name = "CuiLabel9"
        Me.CuiLabel9.Size = New System.Drawing.Size(128, 30)
        Me.CuiLabel9.TabIndex = 122
        Me.CuiLabel9.VerticalAlignment = System.Drawing.StringAlignment.Near
        '
        'last_name_input
        '
        Me.last_name_input.BackColor = System.Drawing.Color.Transparent
        Me.last_name_input.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.last_name_input.Content = ""
        Me.last_name_input.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.last_name_input.FocusBackgroundColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.last_name_input.FocusImageTint = System.Drawing.Color.White
        Me.last_name_input.FocusOutlineColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.last_name_input.Font = New System.Drawing.Font("Helvetica", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.last_name_input.ForeColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.last_name_input.Image = Nothing
        Me.last_name_input.ImageExpand = New System.Drawing.Point(0, 0)
        Me.last_name_input.ImageOffset = New System.Drawing.Point(0, 0)
        Me.last_name_input.Location = New System.Drawing.Point(1155, 325)
        Me.last_name_input.Margin = New System.Windows.Forms.Padding(4)
        Me.last_name_input.Multiline = False
        Me.last_name_input.Name = "last_name_input"
        Me.last_name_input.NormalImageTint = System.Drawing.Color.Silver
        Me.last_name_input.OutlineColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.last_name_input.Padding = New System.Windows.Forms.Padding(23, 13, 23, 0)
        Me.last_name_input.PasswordChar = False
        Me.last_name_input.PlaceholderColor = System.Drawing.Color.DimGray
        Me.last_name_input.PlaceholderText = "Last Name"
        Me.last_name_input.Rounding = New System.Windows.Forms.Padding(12)
        Me.last_name_input.Size = New System.Drawing.Size(369, 49)
        Me.last_name_input.TabIndex = 83
        Me.last_name_input.TextOffset = New System.Drawing.Size(0, 0)
        Me.last_name_input.UnderlinedStyle = True
        '
        'email_input
        '
        Me.email_input.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.email_input.Content = ""
        Me.email_input.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.email_input.FocusBackgroundColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.email_input.FocusImageTint = System.Drawing.Color.White
        Me.email_input.FocusOutlineColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.email_input.Font = New System.Drawing.Font("Helvetica", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.email_input.ForeColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.email_input.Image = Nothing
        Me.email_input.ImageExpand = New System.Drawing.Point(0, 0)
        Me.email_input.ImageOffset = New System.Drawing.Point(0, 0)
        Me.email_input.Location = New System.Drawing.Point(757, 548)
        Me.email_input.Margin = New System.Windows.Forms.Padding(4)
        Me.email_input.Multiline = False
        Me.email_input.Name = "email_input"
        Me.email_input.NormalImageTint = System.Drawing.Color.Silver
        Me.email_input.OutlineColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.email_input.Padding = New System.Windows.Forms.Padding(23, 13, 23, 0)
        Me.email_input.PasswordChar = False
        Me.email_input.PlaceholderColor = System.Drawing.Color.DimGray
        Me.email_input.PlaceholderText = "ex: example@gmail.com"
        Me.email_input.Rounding = New System.Windows.Forms.Padding(12)
        Me.email_input.Size = New System.Drawing.Size(767, 49)
        Me.email_input.TabIndex = 92
        Me.email_input.TextOffset = New System.Drawing.Size(0, 0)
        Me.email_input.UnderlinedStyle = True
        '
        'CuiLabel4
        '
        Me.CuiLabel4.BackColor = System.Drawing.Color.Transparent
        Me.CuiLabel4.Content = "Gender"
        Me.CuiLabel4.Font = New System.Drawing.Font("Helvetica", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CuiLabel4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.CuiLabel4.HorizontalAlignment = System.Drawing.StringAlignment.Center
        Me.CuiLabel4.Location = New System.Drawing.Point(716, 402)
        Me.CuiLabel4.Name = "CuiLabel4"
        Me.CuiLabel4.Size = New System.Drawing.Size(166, 30)
        Me.CuiLabel4.TabIndex = 117
        Me.CuiLabel4.VerticalAlignment = System.Drawing.StringAlignment.Near
        '
        'CuiLabel3
        '
        Me.CuiLabel3.BackColor = System.Drawing.Color.Transparent
        Me.CuiLabel3.Content = "Email\ \(Optional\)"
        Me.CuiLabel3.Font = New System.Drawing.Font("Helvetica", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CuiLabel3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.CuiLabel3.HorizontalAlignment = System.Drawing.StringAlignment.Center
        Me.CuiLabel3.Location = New System.Drawing.Point(757, 509)
        Me.CuiLabel3.Name = "CuiLabel3"
        Me.CuiLabel3.Size = New System.Drawing.Size(166, 32)
        Me.CuiLabel3.TabIndex = 105
        Me.CuiLabel3.VerticalAlignment = System.Drawing.StringAlignment.Near
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
        'customers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(166, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Controls.Add(Me.tbc)
        Me.Name = "customers"
        Me.Size = New System.Drawing.Size(2318, 1291)
        Me.tbc.ResumeLayout(False)
        Me.pg_browse.ResumeLayout(False)
        CType(Me.customers_grid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pg_manage.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents radio_female As ReaLTaiizor.Controls.ParrotRadioButton
    Friend WithEvents tbc As TabControl
    Friend WithEvents pg_browse As TabPage
    Friend WithEvents MaterialDivider1 As ReaLTaiizor.Controls.MaterialDivider
    Friend WithEvents search_input As CuoreUI.Controls.cuiTextBox
    Friend WithEvents customers_grid As MetroFramework.Controls.MetroGrid
    Friend WithEvents pg_manage As TabPage
    Friend WithEvents radio_male As ReaLTaiizor.Controls.ParrotRadioButton
    Friend WithEvents cancel_btn As CuoreUI.Controls.cuiButton
    Friend WithEvents confirm_btn As CuoreUI.Controls.cuiButton
    Friend WithEvents CuiLabel5 As CuoreUI.Controls.cuiLabel
    Friend WithEvents CuiLabel12 As CuoreUI.Controls.cuiLabel
    Friend WithEvents phone_input As CuoreUI.Controls.cuiTextBox
    Friend WithEvents mode_lbl As CuoreUI.Controls.cuiLabel
    Friend WithEvents first_name_input As CuoreUI.Controls.cuiTextBox
    Friend WithEvents CuiLabel15 As CuoreUI.Controls.cuiLabel
    Friend WithEvents CuiLabel9 As CuoreUI.Controls.cuiLabel
    Friend WithEvents last_name_input As CuoreUI.Controls.cuiTextBox
    Friend WithEvents email_input As CuoreUI.Controls.cuiTextBox
    Friend WithEvents CuiLabel4 As CuoreUI.Controls.cuiLabel
    Friend WithEvents CuiLabel3 As CuoreUI.Controls.cuiLabel
    Friend WithEvents delete_confirmation As CuoreUI.Components.cuiMessageDialog
End Class
