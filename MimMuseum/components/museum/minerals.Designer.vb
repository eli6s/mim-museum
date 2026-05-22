<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class minerals
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(minerals))
        Me.tbc = New System.Windows.Forms.TabControl()
        Me.pg_browse = New System.Windows.Forms.TabPage()
        Me.MaterialDivider1 = New ReaLTaiizor.Controls.MaterialDivider()
        Me.search_input = New CuoreUI.Controls.cuiTextBox()
        Me.minerals_grid = New MetroFramework.Controls.MetroGrid()
        Me.pg_manage = New System.Windows.Forms.TabPage()
        Me.CuiLabel10 = New CuoreUI.Controls.cuiLabel()
        Me.date_added_input = New CuoreUI.Controls.cuiCalendarDatePicker()
        Me.desc_input = New CuoreUI.Controls.cuiTextBox()
        Me.cancel_btn = New CuoreUI.Controls.cuiButton()
        Me.confirm_btn = New CuoreUI.Controls.cuiButton()
        Me.CuiLabel5 = New CuoreUI.Controls.cuiLabel()
        Me.CuiLabel12 = New CuoreUI.Controls.cuiLabel()
        Me.formula_input = New CuoreUI.Controls.cuiTextBox()
        Me.mode_lbl = New CuoreUI.Controls.cuiLabel()
        Me.tag_input = New CuoreUI.Controls.cuiTextBox()
        Me.CuiLabel15 = New CuoreUI.Controls.cuiLabel()
        Me.CuiLabel9 = New CuoreUI.Controls.cuiLabel()
        Me.name_input = New CuoreUI.Controls.cuiTextBox()
        Me.fluorescent_input = New CuoreUI.Controls.cuiSwitch()
        Me.dimensions_input = New CuoreUI.Controls.cuiTextBox()
        Me.section_input = New CuoreUI.Controls.cuiComboBox()
        Me.CuiLabel6 = New CuoreUI.Controls.cuiLabel()
        Me.CuiLabel8 = New CuoreUI.Controls.cuiLabel()
        Me.CuiLabel2 = New CuoreUI.Controls.cuiLabel()
        Me.class_input = New CuoreUI.Controls.cuiComboBox()
        Me.CuiLabel1 = New CuoreUI.Controls.cuiLabel()
        Me.CuiLabel4 = New CuoreUI.Controls.cuiLabel()
        Me.CuiLabel3 = New CuoreUI.Controls.cuiLabel()
        Me.country_input = New CuoreUI.Controls.cuiComboBox()
        Me.CuiLabel7 = New CuoreUI.Controls.cuiLabel()
        Me.hardness_input = New ReaLTaiizor.Controls.HopeNumeric()
        Me.radioactive_input = New CuoreUI.Controls.cuiSwitch()
        Me.delete_confirmation = New CuoreUI.Components.cuiMessageDialog()
        Me.Mim_museum_dataset = New MimMuseum.mim_museum_dataset()
        Me.tbc.SuspendLayout()
        Me.pg_browse.SuspendLayout()
        CType(Me.minerals_grid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pg_manage.SuspendLayout()
        CType(Me.Mim_museum_dataset, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tbc
        '
        Me.tbc.Controls.Add(Me.pg_browse)
        Me.tbc.Controls.Add(Me.pg_manage)
        Me.tbc.Font = New System.Drawing.Font("Helvetica", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbc.Location = New System.Drawing.Point(-7, 0)
        Me.tbc.Name = "tbc"
        Me.tbc.SelectedIndex = 0
        Me.tbc.Size = New System.Drawing.Size(2337, 1298)
        Me.tbc.TabIndex = 0
        '
        'pg_browse
        '
        Me.pg_browse.BackColor = System.Drawing.Color.FromArgb(CType(CType(166, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.pg_browse.Controls.Add(Me.MaterialDivider1)
        Me.pg_browse.Controls.Add(Me.search_input)
        Me.pg_browse.Controls.Add(Me.minerals_grid)
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
        'minerals_grid
        '
        Me.minerals_grid.AllowUserToAddRows = False
        Me.minerals_grid.AllowUserToDeleteRows = False
        Me.minerals_grid.AllowUserToResizeColumns = False
        Me.minerals_grid.AllowUserToResizeRows = False
        Me.minerals_grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.minerals_grid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.minerals_grid.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.minerals_grid.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.minerals_grid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenHorizontal
        Me.minerals_grid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(84, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Helvetica", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle1.Padding = New System.Windows.Forms.Padding(10, 0, 10, 0)
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(84, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.minerals_grid.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.minerals_grid.ColumnHeadersHeight = 70
        Me.minerals_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Helvetica", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.minerals_grid.DefaultCellStyle = DataGridViewCellStyle2
        Me.minerals_grid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2
        Me.minerals_grid.EnableHeadersVisualStyles = False
        Me.minerals_grid.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.minerals_grid.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.minerals_grid.Location = New System.Drawing.Point(88, 185)
        Me.minerals_grid.Name = "minerals_grid"
        Me.minerals_grid.ReadOnly = True
        Me.minerals_grid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(217, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Helvetica", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(250, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.minerals_grid.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.minerals_grid.RowHeadersVisible = False
        Me.minerals_grid.RowHeadersWidth = 50
        Me.minerals_grid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(217, Byte), Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Helvetica", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle4.Padding = New System.Windows.Forms.Padding(0, 15, 0, 20)
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(250, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White
        Me.minerals_grid.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.minerals_grid.RowTemplate.Height = 42
        Me.minerals_grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.minerals_grid.Size = New System.Drawing.Size(2147, 970)
        Me.minerals_grid.TabIndex = 9
        '
        'pg_manage
        '
        Me.pg_manage.BackColor = System.Drawing.Color.FromArgb(CType(CType(166, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.pg_manage.Controls.Add(Me.CuiLabel10)
        Me.pg_manage.Controls.Add(Me.date_added_input)
        Me.pg_manage.Controls.Add(Me.desc_input)
        Me.pg_manage.Controls.Add(Me.cancel_btn)
        Me.pg_manage.Controls.Add(Me.confirm_btn)
        Me.pg_manage.Controls.Add(Me.CuiLabel5)
        Me.pg_manage.Controls.Add(Me.CuiLabel12)
        Me.pg_manage.Controls.Add(Me.formula_input)
        Me.pg_manage.Controls.Add(Me.mode_lbl)
        Me.pg_manage.Controls.Add(Me.tag_input)
        Me.pg_manage.Controls.Add(Me.CuiLabel15)
        Me.pg_manage.Controls.Add(Me.CuiLabel9)
        Me.pg_manage.Controls.Add(Me.name_input)
        Me.pg_manage.Controls.Add(Me.fluorescent_input)
        Me.pg_manage.Controls.Add(Me.dimensions_input)
        Me.pg_manage.Controls.Add(Me.section_input)
        Me.pg_manage.Controls.Add(Me.CuiLabel6)
        Me.pg_manage.Controls.Add(Me.CuiLabel8)
        Me.pg_manage.Controls.Add(Me.CuiLabel2)
        Me.pg_manage.Controls.Add(Me.class_input)
        Me.pg_manage.Controls.Add(Me.CuiLabel1)
        Me.pg_manage.Controls.Add(Me.CuiLabel4)
        Me.pg_manage.Controls.Add(Me.CuiLabel3)
        Me.pg_manage.Controls.Add(Me.country_input)
        Me.pg_manage.Controls.Add(Me.CuiLabel7)
        Me.pg_manage.Controls.Add(Me.hardness_input)
        Me.pg_manage.Controls.Add(Me.radioactive_input)
        Me.pg_manage.Location = New System.Drawing.Point(4, 26)
        Me.pg_manage.Name = "pg_manage"
        Me.pg_manage.Padding = New System.Windows.Forms.Padding(3)
        Me.pg_manage.Size = New System.Drawing.Size(2329, 1268)
        Me.pg_manage.TabIndex = 1
        Me.pg_manage.Text = "Manage"
        '
        'CuiLabel10
        '
        Me.CuiLabel10.BackColor = System.Drawing.Color.Transparent
        Me.CuiLabel10.Content = "Date\ Added"
        Me.CuiLabel10.Font = New System.Drawing.Font("Helvetica", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CuiLabel10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.CuiLabel10.HorizontalAlignment = System.Drawing.StringAlignment.Center
        Me.CuiLabel10.Location = New System.Drawing.Point(944, 468)
        Me.CuiLabel10.Name = "CuiLabel10"
        Me.CuiLabel10.Size = New System.Drawing.Size(169, 23)
        Me.CuiLabel10.TabIndex = 129
        Me.CuiLabel10.VerticalAlignment = System.Drawing.StringAlignment.Near
        '
        'date_added_input
        '
        Me.date_added_input.Content = New Date(2026, 3, 8, 0, 0, 0, 0)
        Me.date_added_input.EnableThemeChangeButton = True
        Me.date_added_input.Font = New System.Drawing.Font("Helvetica", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.date_added_input.ForeColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.date_added_input.HoverBackground = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.date_added_input.HoverOutline = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.date_added_input.Icon = CType(resources.GetObject("date_added_input.Icon"), System.Drawing.Image)
        Me.date_added_input.IconTint = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.date_added_input.Location = New System.Drawing.Point(944, 500)
        Me.date_added_input.Margin = New System.Windows.Forms.Padding(6)
        Me.date_added_input.Name = "date_added_input"
        Me.date_added_input.NormalBackground = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.date_added_input.NormalOutline = System.Drawing.Color.Transparent
        Me.date_added_input.OutlineThickness = 1.5!
        Me.date_added_input.PickerPosition = CuoreUI.Controls.cuiCalendarDatePicker.Position.Bottom
        Me.date_added_input.PressedBackground = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.date_added_input.PressedOutline = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.date_added_input.Rounding = 12
        Me.date_added_input.ShowIcon = True
        Me.date_added_input.Size = New System.Drawing.Size(267, 49)
        Me.date_added_input.TabIndex = 128
        Me.date_added_input.Theme = CuoreUI.Controls.Forms.DatePicker.Themes.Light
        '
        'desc_input
        '
        Me.desc_input.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.desc_input.Content = ""
        Me.desc_input.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.desc_input.FocusBackgroundColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.desc_input.FocusImageTint = System.Drawing.Color.White
        Me.desc_input.FocusOutlineColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.desc_input.Font = New System.Drawing.Font("Helvetica", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.desc_input.ForeColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.desc_input.Image = Nothing
        Me.desc_input.ImageExpand = New System.Drawing.Point(0, 0)
        Me.desc_input.ImageOffset = New System.Drawing.Point(0, 0)
        Me.desc_input.Location = New System.Drawing.Point(546, 604)
        Me.desc_input.Margin = New System.Windows.Forms.Padding(4)
        Me.desc_input.Multiline = False
        Me.desc_input.Name = "desc_input"
        Me.desc_input.NormalImageTint = System.Drawing.Color.Silver
        Me.desc_input.OutlineColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.desc_input.Padding = New System.Windows.Forms.Padding(23, 97, 23, 0)
        Me.desc_input.PasswordChar = False
        Me.desc_input.PlaceholderColor = System.Drawing.Color.DimGray
        Me.desc_input.PlaceholderText = "Brief description of the mineral specimen..."
        Me.desc_input.Rounding = New System.Windows.Forms.Padding(12)
        Me.desc_input.Size = New System.Drawing.Size(1184, 217)
        Me.desc_input.TabIndex = 127
        Me.desc_input.TextOffset = New System.Drawing.Size(0, 0)
        Me.desc_input.UnderlinedStyle = True
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
        Me.cancel_btn.Location = New System.Drawing.Point(1147, 922)
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
        Me.confirm_btn.Location = New System.Drawing.Point(970, 922)
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
        Me.CuiLabel5.Content = "Manage\ Minerals"
        Me.CuiLabel5.Font = New System.Drawing.Font("Helvetica", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CuiLabel5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.CuiLabel5.HorizontalAlignment = System.Drawing.StringAlignment.Center
        Me.CuiLabel5.Location = New System.Drawing.Point(958, 46)
        Me.CuiLabel5.Name = "CuiLabel5"
        Me.CuiLabel5.Size = New System.Drawing.Size(303, 65)
        Me.CuiLabel5.TabIndex = 85
        Me.CuiLabel5.VerticalAlignment = System.Drawing.StringAlignment.Near
        '
        'CuiLabel12
        '
        Me.CuiLabel12.BackColor = System.Drawing.Color.Transparent
        Me.CuiLabel12.Content = "Formula"
        Me.CuiLabel12.Font = New System.Drawing.Font("Helvetica", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CuiLabel12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.CuiLabel12.HorizontalAlignment = System.Drawing.StringAlignment.Center
        Me.CuiLabel12.Location = New System.Drawing.Point(1394, 254)
        Me.CuiLabel12.Name = "CuiLabel12"
        Me.CuiLabel12.Size = New System.Drawing.Size(166, 32)
        Me.CuiLabel12.TabIndex = 126
        Me.CuiLabel12.VerticalAlignment = System.Drawing.StringAlignment.Near
        '
        'formula_input
        '
        Me.formula_input.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.formula_input.Content = ""
        Me.formula_input.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.formula_input.FocusBackgroundColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.formula_input.FocusImageTint = System.Drawing.Color.White
        Me.formula_input.FocusOutlineColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.formula_input.Font = New System.Drawing.Font("Helvetica", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.formula_input.ForeColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.formula_input.Image = Nothing
        Me.formula_input.ImageExpand = New System.Drawing.Point(0, 0)
        Me.formula_input.ImageOffset = New System.Drawing.Point(0, 0)
        Me.formula_input.Location = New System.Drawing.Point(1424, 284)
        Me.formula_input.Margin = New System.Windows.Forms.Padding(4)
        Me.formula_input.Multiline = False
        Me.formula_input.Name = "formula_input"
        Me.formula_input.NormalImageTint = System.Drawing.Color.Silver
        Me.formula_input.OutlineColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.formula_input.Padding = New System.Windows.Forms.Padding(23, 13, 23, 0)
        Me.formula_input.PasswordChar = False
        Me.formula_input.PlaceholderColor = System.Drawing.Color.DimGray
        Me.formula_input.PlaceholderText = "Chemical Formula"
        Me.formula_input.Rounding = New System.Windows.Forms.Padding(12)
        Me.formula_input.Size = New System.Drawing.Size(306, 49)
        Me.formula_input.TabIndex = 125
        Me.formula_input.TextOffset = New System.Drawing.Size(0, 0)
        Me.formula_input.UnderlinedStyle = True
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
        'tag_input
        '
        Me.tag_input.BackColor = System.Drawing.Color.Transparent
        Me.tag_input.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.tag_input.Content = ""
        Me.tag_input.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tag_input.FocusBackgroundColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.tag_input.FocusImageTint = System.Drawing.Color.White
        Me.tag_input.FocusOutlineColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.tag_input.Font = New System.Drawing.Font("Helvetica", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tag_input.ForeColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.tag_input.Image = Nothing
        Me.tag_input.ImageExpand = New System.Drawing.Point(0, 0)
        Me.tag_input.ImageOffset = New System.Drawing.Point(0, 0)
        Me.tag_input.Location = New System.Drawing.Point(546, 284)
        Me.tag_input.Margin = New System.Windows.Forms.Padding(4)
        Me.tag_input.Multiline = False
        Me.tag_input.Name = "tag_input"
        Me.tag_input.NormalImageTint = System.Drawing.Color.Silver
        Me.tag_input.OutlineColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.tag_input.Padding = New System.Windows.Forms.Padding(23, 13, 23, 0)
        Me.tag_input.PasswordChar = False
        Me.tag_input.PlaceholderColor = System.Drawing.Color.DimGray
        Me.tag_input.PlaceholderText = "Mineral Tag"
        Me.tag_input.Rounding = New System.Windows.Forms.Padding(12)
        Me.tag_input.Size = New System.Drawing.Size(253, 49)
        Me.tag_input.TabIndex = 121
        Me.tag_input.TextOffset = New System.Drawing.Size(0, 0)
        Me.tag_input.UnderlinedStyle = True
        '
        'CuiLabel15
        '
        Me.CuiLabel15.BackColor = System.Drawing.Color.Transparent
        Me.CuiLabel15.Content = "Name"
        Me.CuiLabel15.Font = New System.Drawing.Font("Helvetica", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CuiLabel15.ForeColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.CuiLabel15.HorizontalAlignment = System.Drawing.StringAlignment.Center
        Me.CuiLabel15.Location = New System.Drawing.Point(823, 254)
        Me.CuiLabel15.Name = "CuiLabel15"
        Me.CuiLabel15.Size = New System.Drawing.Size(128, 30)
        Me.CuiLabel15.TabIndex = 87
        Me.CuiLabel15.VerticalAlignment = System.Drawing.StringAlignment.Near
        '
        'CuiLabel9
        '
        Me.CuiLabel9.BackColor = System.Drawing.Color.Transparent
        Me.CuiLabel9.Content = "Tag"
        Me.CuiLabel9.Font = New System.Drawing.Font("Helvetica", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CuiLabel9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.CuiLabel9.HorizontalAlignment = System.Drawing.StringAlignment.Center
        Me.CuiLabel9.Location = New System.Drawing.Point(522, 254)
        Me.CuiLabel9.Name = "CuiLabel9"
        Me.CuiLabel9.Size = New System.Drawing.Size(128, 30)
        Me.CuiLabel9.TabIndex = 122
        Me.CuiLabel9.VerticalAlignment = System.Drawing.StringAlignment.Near
        '
        'name_input
        '
        Me.name_input.BackColor = System.Drawing.Color.Transparent
        Me.name_input.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.name_input.Content = ""
        Me.name_input.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.name_input.FocusBackgroundColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.name_input.FocusImageTint = System.Drawing.Color.White
        Me.name_input.FocusOutlineColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.name_input.Font = New System.Drawing.Font("Helvetica", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.name_input.ForeColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.name_input.Image = Nothing
        Me.name_input.ImageExpand = New System.Drawing.Point(0, 0)
        Me.name_input.ImageOffset = New System.Drawing.Point(0, 0)
        Me.name_input.Location = New System.Drawing.Point(842, 284)
        Me.name_input.Margin = New System.Windows.Forms.Padding(4)
        Me.name_input.Multiline = False
        Me.name_input.Name = "name_input"
        Me.name_input.NormalImageTint = System.Drawing.Color.Silver
        Me.name_input.OutlineColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.name_input.Padding = New System.Windows.Forms.Padding(23, 13, 23, 0)
        Me.name_input.PasswordChar = False
        Me.name_input.PlaceholderColor = System.Drawing.Color.DimGray
        Me.name_input.PlaceholderText = "Mineral Name"
        Me.name_input.Rounding = New System.Windows.Forms.Padding(12)
        Me.name_input.Size = New System.Drawing.Size(536, 49)
        Me.name_input.TabIndex = 83
        Me.name_input.TextOffset = New System.Drawing.Size(0, 0)
        Me.name_input.UnderlinedStyle = True
        '
        'fluorescent_input
        '
        Me.fluorescent_input.Checked = False
        Me.fluorescent_input.CheckedBackground = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.fluorescent_input.CheckedForeground = System.Drawing.Color.White
        Me.fluorescent_input.CheckedOutlineColor = System.Drawing.Color.Empty
        Me.fluorescent_input.CheckedSymbolColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.fluorescent_input.Cursor = System.Windows.Forms.Cursors.Hand
        Me.fluorescent_input.Location = New System.Drawing.Point(1491, 513)
        Me.fluorescent_input.MinimumSize = New System.Drawing.Size(12, 8)
        Me.fluorescent_input.Name = "fluorescent_input"
        Me.fluorescent_input.OutlineThickness = 1.0!
        Me.fluorescent_input.ShowSymbols = False
        Me.fluorescent_input.Size = New System.Drawing.Size(48, 26)
        Me.fluorescent_input.TabIndex = 111
        Me.fluorescent_input.ThumbSizeModifier = New System.Drawing.Size(0, 0)
        Me.fluorescent_input.UncheckedBackground = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.fluorescent_input.UncheckedForeground = System.Drawing.Color.White
        Me.fluorescent_input.UncheckedOutlineColor = System.Drawing.Color.Empty
        Me.fluorescent_input.UncheckedSymbolColor = System.Drawing.Color.Gray
        '
        'dimensions_input
        '
        Me.dimensions_input.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.dimensions_input.Content = ""
        Me.dimensions_input.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.dimensions_input.FocusBackgroundColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.dimensions_input.FocusImageTint = System.Drawing.Color.White
        Me.dimensions_input.FocusOutlineColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.dimensions_input.Font = New System.Drawing.Font("Helvetica", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dimensions_input.ForeColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.dimensions_input.Image = Nothing
        Me.dimensions_input.ImageExpand = New System.Drawing.Point(0, 0)
        Me.dimensions_input.ImageOffset = New System.Drawing.Point(0, 0)
        Me.dimensions_input.Location = New System.Drawing.Point(543, 498)
        Me.dimensions_input.Margin = New System.Windows.Forms.Padding(4)
        Me.dimensions_input.Multiline = False
        Me.dimensions_input.Name = "dimensions_input"
        Me.dimensions_input.NormalImageTint = System.Drawing.Color.Silver
        Me.dimensions_input.OutlineColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.dimensions_input.Padding = New System.Windows.Forms.Padding(23, 13, 23, 0)
        Me.dimensions_input.PasswordChar = False
        Me.dimensions_input.PlaceholderColor = System.Drawing.Color.DimGray
        Me.dimensions_input.PlaceholderText = "ex: 1 x 1 x 1 cm"
        Me.dimensions_input.Rounding = New System.Windows.Forms.Padding(12)
        Me.dimensions_input.Size = New System.Drawing.Size(358, 49)
        Me.dimensions_input.TabIndex = 92
        Me.dimensions_input.TextOffset = New System.Drawing.Size(0, 0)
        Me.dimensions_input.UnderlinedStyle = True
        '
        'section_input
        '
        Me.section_input.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.section_input.DropDownBackgroundColor = System.Drawing.Color.White
        Me.section_input.DropDownForeColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(27, Byte), Integer))
        Me.section_input.ExpandArrowColor = System.Drawing.Color.Gray
        Me.section_input.Font = New System.Drawing.Font("Helvetica", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.section_input.ForeColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.section_input.Items = New String(-1) {}
        Me.section_input.Location = New System.Drawing.Point(1370, 391)
        Me.section_input.Margin = New System.Windows.Forms.Padding(6)
        Me.section_input.MaxDropDownHeight = 240
        Me.section_input.Name = "section_input"
        Me.section_input.NoSelectionText = "Select"
        Me.section_input.OutlineColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.section_input.OutlineThickness = 1.0!
        Me.section_input.Rounding = 12
        Me.section_input.SelectedIndex = -1
        Me.section_input.SelectedItem = ""
        Me.section_input.Size = New System.Drawing.Size(363, 49)
        Me.section_input.SortAlphabetically = True
        Me.section_input.TabIndex = 120
        '
        'CuiLabel6
        '
        Me.CuiLabel6.BackColor = System.Drawing.Color.Transparent
        Me.CuiLabel6.Content = "Country"
        Me.CuiLabel6.Font = New System.Drawing.Font("Helvetica", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CuiLabel6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.CuiLabel6.HorizontalAlignment = System.Drawing.StringAlignment.Center
        Me.CuiLabel6.Location = New System.Drawing.Point(928, 361)
        Me.CuiLabel6.Name = "CuiLabel6"
        Me.CuiLabel6.Size = New System.Drawing.Size(166, 30)
        Me.CuiLabel6.TabIndex = 95
        Me.CuiLabel6.VerticalAlignment = System.Drawing.StringAlignment.Near
        '
        'CuiLabel8
        '
        Me.CuiLabel8.BackColor = System.Drawing.Color.Transparent
        Me.CuiLabel8.Content = "Section"
        Me.CuiLabel8.Font = New System.Drawing.Font("Helvetica", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CuiLabel8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.CuiLabel8.HorizontalAlignment = System.Drawing.StringAlignment.Center
        Me.CuiLabel8.Location = New System.Drawing.Point(1329, 361)
        Me.CuiLabel8.Name = "CuiLabel8"
        Me.CuiLabel8.Size = New System.Drawing.Size(166, 30)
        Me.CuiLabel8.TabIndex = 119
        Me.CuiLabel8.VerticalAlignment = System.Drawing.StringAlignment.Near
        '
        'CuiLabel2
        '
        Me.CuiLabel2.BackColor = System.Drawing.Color.Transparent
        Me.CuiLabel2.Content = "Radioactive"
        Me.CuiLabel2.Font = New System.Drawing.Font("Helvetica", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CuiLabel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.CuiLabel2.HorizontalAlignment = System.Drawing.StringAlignment.Center
        Me.CuiLabel2.Location = New System.Drawing.Point(1578, 468)
        Me.CuiLabel2.Name = "CuiLabel2"
        Me.CuiLabel2.Size = New System.Drawing.Size(180, 24)
        Me.CuiLabel2.TabIndex = 98
        Me.CuiLabel2.VerticalAlignment = System.Drawing.StringAlignment.Near
        '
        'class_input
        '
        Me.class_input.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.class_input.DropDownBackgroundColor = System.Drawing.Color.White
        Me.class_input.DropDownForeColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(27, Byte), Integer))
        Me.class_input.ExpandArrowColor = System.Drawing.Color.Gray
        Me.class_input.Font = New System.Drawing.Font("Helvetica", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.class_input.ForeColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.class_input.Items = New String(-1) {}
        Me.class_input.Location = New System.Drawing.Point(544, 391)
        Me.class_input.Margin = New System.Windows.Forms.Padding(6)
        Me.class_input.MaxDropDownHeight = 240
        Me.class_input.Name = "class_input"
        Me.class_input.NoSelectionText = "Select"
        Me.class_input.OutlineColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.class_input.OutlineThickness = 1.0!
        Me.class_input.Rounding = 12
        Me.class_input.SelectedIndex = -1
        Me.class_input.SelectedItem = ""
        Me.class_input.Size = New System.Drawing.Size(375, 49)
        Me.class_input.SortAlphabetically = True
        Me.class_input.TabIndex = 118
        '
        'CuiLabel1
        '
        Me.CuiLabel1.BackColor = System.Drawing.Color.Transparent
        Me.CuiLabel1.Content = "Fluorescent"
        Me.CuiLabel1.Font = New System.Drawing.Font("Helvetica", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CuiLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.CuiLabel1.HorizontalAlignment = System.Drawing.StringAlignment.Center
        Me.CuiLabel1.Location = New System.Drawing.Point(1433, 468)
        Me.CuiLabel1.Name = "CuiLabel1"
        Me.CuiLabel1.Size = New System.Drawing.Size(166, 24)
        Me.CuiLabel1.TabIndex = 104
        Me.CuiLabel1.VerticalAlignment = System.Drawing.StringAlignment.Near
        '
        'CuiLabel4
        '
        Me.CuiLabel4.BackColor = System.Drawing.Color.Transparent
        Me.CuiLabel4.Content = "Class"
        Me.CuiLabel4.Font = New System.Drawing.Font("Helvetica", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CuiLabel4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.CuiLabel4.HorizontalAlignment = System.Drawing.StringAlignment.Center
        Me.CuiLabel4.Location = New System.Drawing.Point(493, 361)
        Me.CuiLabel4.Name = "CuiLabel4"
        Me.CuiLabel4.Size = New System.Drawing.Size(166, 30)
        Me.CuiLabel4.TabIndex = 117
        Me.CuiLabel4.VerticalAlignment = System.Drawing.StringAlignment.Near
        '
        'CuiLabel3
        '
        Me.CuiLabel3.BackColor = System.Drawing.Color.Transparent
        Me.CuiLabel3.Content = "Dimensions"
        Me.CuiLabel3.Font = New System.Drawing.Font("Helvetica", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CuiLabel3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.CuiLabel3.HorizontalAlignment = System.Drawing.StringAlignment.Center
        Me.CuiLabel3.Location = New System.Drawing.Point(531, 468)
        Me.CuiLabel3.Name = "CuiLabel3"
        Me.CuiLabel3.Size = New System.Drawing.Size(166, 32)
        Me.CuiLabel3.TabIndex = 105
        Me.CuiLabel3.VerticalAlignment = System.Drawing.StringAlignment.Near
        '
        'country_input
        '
        Me.country_input.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.country_input.DropDownBackgroundColor = System.Drawing.Color.White
        Me.country_input.DropDownForeColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(27, Byte), Integer))
        Me.country_input.ExpandArrowColor = System.Drawing.Color.Gray
        Me.country_input.Font = New System.Drawing.Font("Helvetica", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.country_input.ForeColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.country_input.Items = New String(-1) {}
        Me.country_input.Location = New System.Drawing.Point(958, 391)
        Me.country_input.Margin = New System.Windows.Forms.Padding(6)
        Me.country_input.MaxDropDownHeight = 240
        Me.country_input.Name = "country_input"
        Me.country_input.NoSelectionText = "Select"
        Me.country_input.OutlineColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.country_input.OutlineThickness = 1.0!
        Me.country_input.Rounding = 12
        Me.country_input.SelectedIndex = -1
        Me.country_input.SelectedItem = ""
        Me.country_input.Size = New System.Drawing.Size(373, 49)
        Me.country_input.SortAlphabetically = True
        Me.country_input.TabIndex = 116
        '
        'CuiLabel7
        '
        Me.CuiLabel7.BackColor = System.Drawing.Color.Transparent
        Me.CuiLabel7.Content = "Hardness\ \(1-10\)"
        Me.CuiLabel7.Font = New System.Drawing.Font("Helvetica", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CuiLabel7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.CuiLabel7.HorizontalAlignment = System.Drawing.StringAlignment.Center
        Me.CuiLabel7.Location = New System.Drawing.Point(1241, 468)
        Me.CuiLabel7.Name = "CuiLabel7"
        Me.CuiLabel7.Size = New System.Drawing.Size(186, 24)
        Me.CuiLabel7.TabIndex = 107
        Me.CuiLabel7.VerticalAlignment = System.Drawing.StringAlignment.Near
        '
        'hardness_input
        '
        Me.hardness_input.BackColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.hardness_input.BaseColor = System.Drawing.Color.FromArgb(CType(CType(166, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.hardness_input.BorderColorA = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.hardness_input.BorderColorB = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.hardness_input.BorderHoverColorA = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.hardness_input.ButtonTextColorA = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.hardness_input.ButtonTextColorB = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.hardness_input.Cursor = System.Windows.Forms.Cursors.Hand
        Me.hardness_input.EnterKey = True
        Me.hardness_input.Font = New System.Drawing.Font("Helvetica", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hardness_input.ForeColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.hardness_input.HoverButtonTextColorA = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.hardness_input.HoverButtonTextColorB = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.hardness_input.Location = New System.Drawing.Point(1251, 507)
        Me.hardness_input.MaxNum = 10.0!
        Me.hardness_input.MinNum = 1.0!
        Me.hardness_input.Name = "hardness_input"
        Me.hardness_input.Precision = 0
        Me.hardness_input.Size = New System.Drawing.Size(157, 32)
        Me.hardness_input.Step = 1.0!
        Me.hardness_input.Style = ReaLTaiizor.Controls.HopeNumeric.NumericStyle.LeftRight
        Me.hardness_input.TabIndex = 115
        Me.hardness_input.Text = "HopeNumeric1"
        Me.hardness_input.ValueNumber = 1.0!
        '
        'radioactive_input
        '
        Me.radioactive_input.Checked = False
        Me.radioactive_input.CheckedBackground = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.radioactive_input.CheckedForeground = System.Drawing.Color.White
        Me.radioactive_input.CheckedOutlineColor = System.Drawing.Color.Empty
        Me.radioactive_input.CheckedSymbolColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.radioactive_input.Cursor = System.Windows.Forms.Cursors.Hand
        Me.radioactive_input.Location = New System.Drawing.Point(1639, 513)
        Me.radioactive_input.MinimumSize = New System.Drawing.Size(12, 8)
        Me.radioactive_input.Name = "radioactive_input"
        Me.radioactive_input.OutlineThickness = 1.0!
        Me.radioactive_input.ShowSymbols = False
        Me.radioactive_input.Size = New System.Drawing.Size(48, 26)
        Me.radioactive_input.TabIndex = 109
        Me.radioactive_input.ThumbSizeModifier = New System.Drawing.Size(0, 0)
        Me.radioactive_input.UncheckedBackground = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.radioactive_input.UncheckedForeground = System.Drawing.Color.White
        Me.radioactive_input.UncheckedOutlineColor = System.Drawing.Color.Empty
        Me.radioactive_input.UncheckedSymbolColor = System.Drawing.Color.Gray
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
        'Mim_museum_dataset
        '
        Me.Mim_museum_dataset.DataSetName = "mim_museum_dataset"
        Me.Mim_museum_dataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'minerals
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(166, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Controls.Add(Me.tbc)
        Me.Name = "minerals"
        Me.Size = New System.Drawing.Size(2318, 1291)
        Me.tbc.ResumeLayout(False)
        Me.pg_browse.ResumeLayout(False)
        CType(Me.minerals_grid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pg_manage.ResumeLayout(False)
        CType(Me.Mim_museum_dataset, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tbc As TabControl
    Friend WithEvents pg_browse As TabPage
    Friend WithEvents pg_manage As TabPage
    Friend WithEvents minerals_grid As MetroFramework.Controls.MetroGrid
    Friend WithEvents search_input As CuoreUI.Controls.cuiTextBox
    Friend WithEvents MaterialDivider1 As ReaLTaiizor.Controls.MaterialDivider
    Friend WithEvents cancel_btn As CuoreUI.Controls.cuiButton
    Friend WithEvents confirm_btn As CuoreUI.Controls.cuiButton
    Friend WithEvents CuiLabel5 As CuoreUI.Controls.cuiLabel
    Friend WithEvents CuiLabel12 As CuoreUI.Controls.cuiLabel
    Friend WithEvents formula_input As CuoreUI.Controls.cuiTextBox
    Friend WithEvents mode_lbl As CuoreUI.Controls.cuiLabel
    Friend WithEvents tag_input As CuoreUI.Controls.cuiTextBox
    Friend WithEvents CuiLabel15 As CuoreUI.Controls.cuiLabel
    Friend WithEvents CuiLabel9 As CuoreUI.Controls.cuiLabel
    Friend WithEvents name_input As CuoreUI.Controls.cuiTextBox
    Friend WithEvents fluorescent_input As CuoreUI.Controls.cuiSwitch
    Friend WithEvents dimensions_input As CuoreUI.Controls.cuiTextBox
    Friend WithEvents section_input As CuoreUI.Controls.cuiComboBox
    Friend WithEvents CuiLabel6 As CuoreUI.Controls.cuiLabel
    Friend WithEvents CuiLabel8 As CuoreUI.Controls.cuiLabel
    Friend WithEvents CuiLabel2 As CuoreUI.Controls.cuiLabel
    Friend WithEvents class_input As CuoreUI.Controls.cuiComboBox
    Friend WithEvents CuiLabel1 As CuoreUI.Controls.cuiLabel
    Friend WithEvents CuiLabel4 As CuoreUI.Controls.cuiLabel
    Friend WithEvents CuiLabel3 As CuoreUI.Controls.cuiLabel
    Friend WithEvents country_input As CuoreUI.Controls.cuiComboBox
    Friend WithEvents CuiLabel7 As CuoreUI.Controls.cuiLabel
    Friend WithEvents hardness_input As ReaLTaiizor.Controls.HopeNumeric
    Friend WithEvents radioactive_input As CuoreUI.Controls.cuiSwitch
    Friend WithEvents desc_input As CuoreUI.Controls.cuiTextBox
    Friend WithEvents delete_confirmation As CuoreUI.Components.cuiMessageDialog
    Friend WithEvents CuiLabel10 As CuoreUI.Controls.cuiLabel
    Friend WithEvents date_added_input As CuoreUI.Controls.cuiCalendarDatePicker
    Friend WithEvents Mim_museum_dataset As mim_museum_dataset
End Class
