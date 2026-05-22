<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class museum_maintenance
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(museum_maintenance))
        Me.tbc = New System.Windows.Forms.TabControl()
        Me.pg_browse = New System.Windows.Forms.TabPage()
        Me.MaterialDivider1 = New ReaLTaiizor.Controls.MaterialDivider()
        Me.search_input = New CuoreUI.Controls.cuiTextBox()
        Me.maintenance_grid = New MetroFramework.Controls.MetroGrid()
        Me.pg_manage = New System.Windows.Forms.TabPage()
        Me.MaterialDivider2 = New ReaLTaiizor.Controls.MaterialDivider()
        Me.equipment_list = New System.Windows.Forms.ListView()
        Me.Item = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Cost = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.remove_equipment_btn = New CuoreUI.Controls.cuiButton()
        Me.add_equipment_btn = New CuoreUI.Controls.cuiButton()
        Me.equipment_input = New CuoreUI.Controls.cuiComboBox()
        Me.CuiLabel13 = New CuoreUI.Controls.cuiLabel()
        Me.CuiLabel8 = New CuoreUI.Controls.cuiLabel()
        Me.end_date_input = New CuoreUI.Controls.cuiCalendarDatePicker()
        Me.employee_input = New CuoreUI.Controls.cuiComboBox()
        Me.CuiLabel7 = New CuoreUI.Controls.cuiLabel()
        Me.servicer_input = New CuoreUI.Controls.cuiTextBox()
        Me.CuiLabel6 = New CuoreUI.Controls.cuiLabel()
        Me.equipment_cost_input = New CuoreUI.Controls.cuiTextBox()
        Me.CuiLabel2 = New CuoreUI.Controls.cuiLabel()
        Me.CuiLabel10 = New CuoreUI.Controls.cuiLabel()
        Me.start_date_input = New CuoreUI.Controls.cuiCalendarDatePicker()
        Me.cancel_btn = New CuoreUI.Controls.cuiButton()
        Me.confirm_btn = New CuoreUI.Controls.cuiButton()
        Me.CuiLabel5 = New CuoreUI.Controls.cuiLabel()
        Me.mode_lbl = New CuoreUI.Controls.cuiLabel()
        Me.notes_input = New CuoreUI.Controls.cuiTextBox()
        Me.type_input = New CuoreUI.Controls.cuiComboBox()
        Me.CuiLabel4 = New CuoreUI.Controls.cuiLabel()
        Me.CuiLabel3 = New CuoreUI.Controls.cuiLabel()
        Me.delete_confirmation = New CuoreUI.Components.cuiMessageDialog()
        Me.tbc.SuspendLayout()
        Me.pg_browse.SuspendLayout()
        CType(Me.maintenance_grid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pg_manage.SuspendLayout()
        Me.SuspendLayout()
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
        Me.pg_browse.Controls.Add(Me.maintenance_grid)
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
        'maintenance_grid
        '
        Me.maintenance_grid.AllowUserToAddRows = False
        Me.maintenance_grid.AllowUserToDeleteRows = False
        Me.maintenance_grid.AllowUserToResizeColumns = False
        Me.maintenance_grid.AllowUserToResizeRows = False
        Me.maintenance_grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.maintenance_grid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.maintenance_grid.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.maintenance_grid.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.maintenance_grid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenHorizontal
        Me.maintenance_grid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(84, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Helvetica", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle1.Padding = New System.Windows.Forms.Padding(10, 0, 10, 0)
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(84, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.maintenance_grid.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.maintenance_grid.ColumnHeadersHeight = 70
        Me.maintenance_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Helvetica", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.maintenance_grid.DefaultCellStyle = DataGridViewCellStyle2
        Me.maintenance_grid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2
        Me.maintenance_grid.EnableHeadersVisualStyles = False
        Me.maintenance_grid.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.maintenance_grid.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.maintenance_grid.Location = New System.Drawing.Point(88, 185)
        Me.maintenance_grid.Name = "maintenance_grid"
        Me.maintenance_grid.ReadOnly = True
        Me.maintenance_grid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(217, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Helvetica", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(250, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.maintenance_grid.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.maintenance_grid.RowHeadersVisible = False
        Me.maintenance_grid.RowHeadersWidth = 50
        Me.maintenance_grid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(217, Byte), Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Helvetica", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle4.Padding = New System.Windows.Forms.Padding(0, 15, 0, 20)
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(250, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White
        Me.maintenance_grid.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.maintenance_grid.RowTemplate.Height = 42
        Me.maintenance_grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.maintenance_grid.Size = New System.Drawing.Size(2147, 970)
        Me.maintenance_grid.TabIndex = 9
        '
        'pg_manage
        '
        Me.pg_manage.BackColor = System.Drawing.Color.FromArgb(CType(CType(166, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.pg_manage.Controls.Add(Me.MaterialDivider2)
        Me.pg_manage.Controls.Add(Me.equipment_list)
        Me.pg_manage.Controls.Add(Me.remove_equipment_btn)
        Me.pg_manage.Controls.Add(Me.add_equipment_btn)
        Me.pg_manage.Controls.Add(Me.equipment_input)
        Me.pg_manage.Controls.Add(Me.CuiLabel13)
        Me.pg_manage.Controls.Add(Me.CuiLabel8)
        Me.pg_manage.Controls.Add(Me.end_date_input)
        Me.pg_manage.Controls.Add(Me.employee_input)
        Me.pg_manage.Controls.Add(Me.CuiLabel7)
        Me.pg_manage.Controls.Add(Me.servicer_input)
        Me.pg_manage.Controls.Add(Me.CuiLabel6)
        Me.pg_manage.Controls.Add(Me.equipment_cost_input)
        Me.pg_manage.Controls.Add(Me.CuiLabel2)
        Me.pg_manage.Controls.Add(Me.CuiLabel10)
        Me.pg_manage.Controls.Add(Me.start_date_input)
        Me.pg_manage.Controls.Add(Me.cancel_btn)
        Me.pg_manage.Controls.Add(Me.confirm_btn)
        Me.pg_manage.Controls.Add(Me.CuiLabel5)
        Me.pg_manage.Controls.Add(Me.mode_lbl)
        Me.pg_manage.Controls.Add(Me.notes_input)
        Me.pg_manage.Controls.Add(Me.type_input)
        Me.pg_manage.Controls.Add(Me.CuiLabel4)
        Me.pg_manage.Controls.Add(Me.CuiLabel3)
        Me.pg_manage.Location = New System.Drawing.Point(4, 26)
        Me.pg_manage.Name = "pg_manage"
        Me.pg_manage.Padding = New System.Windows.Forms.Padding(3)
        Me.pg_manage.Size = New System.Drawing.Size(2329, 1268)
        Me.pg_manage.TabIndex = 1
        Me.pg_manage.Text = "Manage"
        '
        'MaterialDivider2
        '
        Me.MaterialDivider2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(161, Byte), Integer))
        Me.MaterialDivider2.Depth = 0
        Me.MaterialDivider2.Location = New System.Drawing.Point(235, 695)
        Me.MaterialDivider2.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER
        Me.MaterialDivider2.Name = "MaterialDivider2"
        Me.MaterialDivider2.Size = New System.Drawing.Size(1752, 1)
        Me.MaterialDivider2.TabIndex = 149
        Me.MaterialDivider2.Text = "MaterialDivider2"
        '
        'equipment_list
        '
        Me.equipment_list.BackColor = System.Drawing.Color.FromArgb(CType(CType(166, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.equipment_list.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Item, Me.Cost})
        Me.equipment_list.HideSelection = False
        Me.equipment_list.Location = New System.Drawing.Point(729, 850)
        Me.equipment_list.Name = "equipment_list"
        Me.equipment_list.Size = New System.Drawing.Size(584, 250)
        Me.equipment_list.TabIndex = 148
        Me.equipment_list.UseCompatibleStateImageBehavior = False
        Me.equipment_list.View = System.Windows.Forms.View.Details
        '
        'Item
        '
        Me.Item.Text = "Item"
        Me.Item.Width = 380
        '
        'Cost
        '
        Me.Cost.Text = "Cost"
        Me.Cost.Width = 200
        '
        'remove_equipment_btn
        '
        Me.remove_equipment_btn.CheckButton = False
        Me.remove_equipment_btn.Checked = False
        Me.remove_equipment_btn.CheckedBackground = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.remove_equipment_btn.CheckedForeColor = System.Drawing.Color.White
        Me.remove_equipment_btn.CheckedImageTint = System.Drawing.Color.White
        Me.remove_equipment_btn.CheckedOutline = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.remove_equipment_btn.Content = "- Remove"
        Me.remove_equipment_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.remove_equipment_btn.DialogResult = System.Windows.Forms.DialogResult.None
        Me.remove_equipment_btn.Font = New System.Drawing.Font("Helvetica", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.remove_equipment_btn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.remove_equipment_btn.HoverBackground = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(161, Byte), Integer))
        Me.remove_equipment_btn.HoverForeColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.remove_equipment_btn.HoverImageTint = System.Drawing.Color.White
        Me.remove_equipment_btn.HoverOutline = System.Drawing.Color.Transparent
        Me.remove_equipment_btn.Image = Nothing
        Me.remove_equipment_btn.ImageExpand = New System.Drawing.Point(3, 3)
        Me.remove_equipment_btn.ImeMode = System.Windows.Forms.ImeMode.Close
        Me.remove_equipment_btn.Location = New System.Drawing.Point(1466, 856)
        Me.remove_equipment_btn.Name = "remove_equipment_btn"
        Me.remove_equipment_btn.NormalBackground = System.Drawing.Color.Transparent
        Me.remove_equipment_btn.NormalForeColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.remove_equipment_btn.NormalImageTint = System.Drawing.Color.White
        Me.remove_equipment_btn.NormalOutline = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.remove_equipment_btn.OutlineThickness = 3.0!
        Me.remove_equipment_btn.Padding = New System.Windows.Forms.Padding(12)
        Me.remove_equipment_btn.PressedBackground = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.remove_equipment_btn.PressedForeColor = System.Drawing.Color.White
        Me.remove_equipment_btn.PressedImageTint = System.Drawing.Color.White
        Me.remove_equipment_btn.PressedOutline = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.remove_equipment_btn.Rounding = New System.Windows.Forms.Padding(12)
        Me.remove_equipment_btn.Size = New System.Drawing.Size(109, 28)
        Me.remove_equipment_btn.TabIndex = 146
        Me.remove_equipment_btn.TextAlignment = System.Drawing.StringAlignment.Center
        Me.remove_equipment_btn.TextPadding = 12
        Me.remove_equipment_btn.TextSpacing = 2
        '
        'add_equipment_btn
        '
        Me.add_equipment_btn.CheckButton = False
        Me.add_equipment_btn.Checked = False
        Me.add_equipment_btn.CheckedBackground = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.add_equipment_btn.CheckedForeColor = System.Drawing.Color.White
        Me.add_equipment_btn.CheckedImageTint = System.Drawing.Color.White
        Me.add_equipment_btn.CheckedOutline = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.add_equipment_btn.Content = "+ Add"
        Me.add_equipment_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.add_equipment_btn.DialogResult = System.Windows.Forms.DialogResult.None
        Me.add_equipment_btn.Font = New System.Drawing.Font("Helvetica", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.add_equipment_btn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.add_equipment_btn.HoverBackground = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(161, Byte), Integer))
        Me.add_equipment_btn.HoverForeColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.add_equipment_btn.HoverImageTint = System.Drawing.Color.White
        Me.add_equipment_btn.HoverOutline = System.Drawing.Color.Transparent
        Me.add_equipment_btn.Image = Nothing
        Me.add_equipment_btn.ImageExpand = New System.Drawing.Point(3, 3)
        Me.add_equipment_btn.ImeMode = System.Windows.Forms.ImeMode.Close
        Me.add_equipment_btn.Location = New System.Drawing.Point(1339, 853)
        Me.add_equipment_btn.Name = "add_equipment_btn"
        Me.add_equipment_btn.NormalBackground = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.add_equipment_btn.NormalForeColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.add_equipment_btn.NormalImageTint = System.Drawing.Color.White
        Me.add_equipment_btn.NormalOutline = System.Drawing.Color.Transparent
        Me.add_equipment_btn.OutlineThickness = 1.0!
        Me.add_equipment_btn.Padding = New System.Windows.Forms.Padding(12)
        Me.add_equipment_btn.PressedBackground = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.add_equipment_btn.PressedForeColor = System.Drawing.Color.White
        Me.add_equipment_btn.PressedImageTint = System.Drawing.Color.White
        Me.add_equipment_btn.PressedOutline = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.add_equipment_btn.Rounding = New System.Windows.Forms.Padding(12)
        Me.add_equipment_btn.Size = New System.Drawing.Size(109, 31)
        Me.add_equipment_btn.TabIndex = 145
        Me.add_equipment_btn.TextAlignment = System.Drawing.StringAlignment.Center
        Me.add_equipment_btn.TextPadding = 12
        Me.add_equipment_btn.TextSpacing = 2
        '
        'equipment_input
        '
        Me.equipment_input.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.equipment_input.DropDownBackgroundColor = System.Drawing.Color.White
        Me.equipment_input.DropDownForeColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(27, Byte), Integer))
        Me.equipment_input.ExpandArrowColor = System.Drawing.Color.Gray
        Me.equipment_input.Font = New System.Drawing.Font("Helvetica", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.equipment_input.ForeColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.equipment_input.Items = New String(-1) {}
        Me.equipment_input.Location = New System.Drawing.Point(729, 759)
        Me.equipment_input.Margin = New System.Windows.Forms.Padding(6)
        Me.equipment_input.MaxDropDownHeight = 240
        Me.equipment_input.Name = "equipment_input"
        Me.equipment_input.NoSelectionText = "Select"
        Me.equipment_input.OutlineColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.equipment_input.OutlineThickness = 1.0!
        Me.equipment_input.Rounding = 12
        Me.equipment_input.SelectedIndex = -1
        Me.equipment_input.SelectedItem = ""
        Me.equipment_input.Size = New System.Drawing.Size(396, 49)
        Me.equipment_input.SortAlphabetically = True
        Me.equipment_input.TabIndex = 144
        '
        'CuiLabel13
        '
        Me.CuiLabel13.BackColor = System.Drawing.Color.Transparent
        Me.CuiLabel13.Content = "Equipment"
        Me.CuiLabel13.Font = New System.Drawing.Font("Helvetica", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CuiLabel13.ForeColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.CuiLabel13.HorizontalAlignment = System.Drawing.StringAlignment.Center
        Me.CuiLabel13.Location = New System.Drawing.Point(713, 729)
        Me.CuiLabel13.Name = "CuiLabel13"
        Me.CuiLabel13.Size = New System.Drawing.Size(151, 30)
        Me.CuiLabel13.TabIndex = 143
        Me.CuiLabel13.VerticalAlignment = System.Drawing.StringAlignment.Near
        '
        'CuiLabel8
        '
        Me.CuiLabel8.BackColor = System.Drawing.Color.Transparent
        Me.CuiLabel8.Content = "End\ Date"
        Me.CuiLabel8.Font = New System.Drawing.Font("Helvetica", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CuiLabel8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.CuiLabel8.HorizontalAlignment = System.Drawing.StringAlignment.Center
        Me.CuiLabel8.Location = New System.Drawing.Point(1144, 409)
        Me.CuiLabel8.Name = "CuiLabel8"
        Me.CuiLabel8.Size = New System.Drawing.Size(169, 23)
        Me.CuiLabel8.TabIndex = 142
        Me.CuiLabel8.VerticalAlignment = System.Drawing.StringAlignment.Near
        '
        'end_date_input
        '
        Me.end_date_input.Content = New Date(2026, 3, 8, 0, 0, 0, 0)
        Me.end_date_input.EnableThemeChangeButton = True
        Me.end_date_input.Font = New System.Drawing.Font("Helvetica", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.end_date_input.ForeColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.end_date_input.HoverBackground = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.end_date_input.HoverOutline = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.end_date_input.Icon = CType(resources.GetObject("end_date_input.Icon"), System.Drawing.Image)
        Me.end_date_input.IconTint = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.end_date_input.Location = New System.Drawing.Point(1162, 441)
        Me.end_date_input.Margin = New System.Windows.Forms.Padding(6)
        Me.end_date_input.Name = "end_date_input"
        Me.end_date_input.NormalBackground = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.end_date_input.NormalOutline = System.Drawing.Color.Transparent
        Me.end_date_input.OutlineThickness = 1.5!
        Me.end_date_input.PickerPosition = CuoreUI.Controls.cuiCalendarDatePicker.Position.Bottom
        Me.end_date_input.PressedBackground = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.end_date_input.PressedOutline = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.end_date_input.Rounding = 12
        Me.end_date_input.ShowIcon = True
        Me.end_date_input.Size = New System.Drawing.Size(413, 49)
        Me.end_date_input.TabIndex = 141
        Me.end_date_input.Theme = CuoreUI.Controls.Forms.DatePicker.Themes.Light
        '
        'employee_input
        '
        Me.employee_input.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.employee_input.DropDownBackgroundColor = System.Drawing.Color.White
        Me.employee_input.DropDownForeColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(27, Byte), Integer))
        Me.employee_input.ExpandArrowColor = System.Drawing.Color.Gray
        Me.employee_input.Font = New System.Drawing.Font("Helvetica", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.employee_input.ForeColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.employee_input.Items = New String(-1) {}
        Me.employee_input.Location = New System.Drawing.Point(729, 337)
        Me.employee_input.Margin = New System.Windows.Forms.Padding(6)
        Me.employee_input.MaxDropDownHeight = 240
        Me.employee_input.Name = "employee_input"
        Me.employee_input.NoSelectionText = "Select"
        Me.employee_input.OutlineColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.employee_input.OutlineThickness = 1.0!
        Me.employee_input.Rounding = 12
        Me.employee_input.SelectedIndex = -1
        Me.employee_input.SelectedItem = ""
        Me.employee_input.Size = New System.Drawing.Size(394, 49)
        Me.employee_input.SortAlphabetically = True
        Me.employee_input.TabIndex = 140
        '
        'CuiLabel7
        '
        Me.CuiLabel7.BackColor = System.Drawing.Color.Transparent
        Me.CuiLabel7.Content = "Employee"
        Me.CuiLabel7.Font = New System.Drawing.Font("Helvetica", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CuiLabel7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.CuiLabel7.HorizontalAlignment = System.Drawing.StringAlignment.Center
        Me.CuiLabel7.Location = New System.Drawing.Point(729, 309)
        Me.CuiLabel7.Name = "CuiLabel7"
        Me.CuiLabel7.Size = New System.Drawing.Size(104, 30)
        Me.CuiLabel7.TabIndex = 139
        Me.CuiLabel7.VerticalAlignment = System.Drawing.StringAlignment.Near
        '
        'servicer_input
        '
        Me.servicer_input.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.servicer_input.Content = ""
        Me.servicer_input.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.servicer_input.FocusBackgroundColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.servicer_input.FocusImageTint = System.Drawing.Color.White
        Me.servicer_input.FocusOutlineColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.servicer_input.Font = New System.Drawing.Font("Helvetica", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.servicer_input.ForeColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.servicer_input.Image = Nothing
        Me.servicer_input.ImageExpand = New System.Drawing.Point(0, 0)
        Me.servicer_input.ImageOffset = New System.Drawing.Point(0, 0)
        Me.servicer_input.Location = New System.Drawing.Point(1160, 230)
        Me.servicer_input.Margin = New System.Windows.Forms.Padding(4)
        Me.servicer_input.Multiline = False
        Me.servicer_input.Name = "servicer_input"
        Me.servicer_input.NormalImageTint = System.Drawing.Color.Silver
        Me.servicer_input.OutlineColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.servicer_input.Padding = New System.Windows.Forms.Padding(23, 13, 23, 0)
        Me.servicer_input.PasswordChar = False
        Me.servicer_input.PlaceholderColor = System.Drawing.Color.DimGray
        Me.servicer_input.PlaceholderText = "Servicer"
        Me.servicer_input.Rounding = New System.Windows.Forms.Padding(12)
        Me.servicer_input.Size = New System.Drawing.Size(415, 49)
        Me.servicer_input.TabIndex = 137
        Me.servicer_input.TextOffset = New System.Drawing.Size(0, 0)
        Me.servicer_input.UnderlinedStyle = True
        '
        'CuiLabel6
        '
        Me.CuiLabel6.BackColor = System.Drawing.Color.Transparent
        Me.CuiLabel6.Content = "Servicer"
        Me.CuiLabel6.Font = New System.Drawing.Font("Helvetica", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CuiLabel6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.CuiLabel6.HorizontalAlignment = System.Drawing.StringAlignment.Center
        Me.CuiLabel6.Location = New System.Drawing.Point(1144, 191)
        Me.CuiLabel6.Name = "CuiLabel6"
        Me.CuiLabel6.Size = New System.Drawing.Size(110, 32)
        Me.CuiLabel6.TabIndex = 138
        Me.CuiLabel6.VerticalAlignment = System.Drawing.StringAlignment.Near
        '
        'equipment_cost_input
        '
        Me.equipment_cost_input.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.equipment_cost_input.Content = ""
        Me.equipment_cost_input.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.equipment_cost_input.FocusBackgroundColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.equipment_cost_input.FocusImageTint = System.Drawing.Color.White
        Me.equipment_cost_input.FocusOutlineColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.equipment_cost_input.Font = New System.Drawing.Font("Helvetica", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.equipment_cost_input.ForeColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.equipment_cost_input.Image = Nothing
        Me.equipment_cost_input.ImageExpand = New System.Drawing.Point(0, 0)
        Me.equipment_cost_input.ImageOffset = New System.Drawing.Point(0, 0)
        Me.equipment_cost_input.Location = New System.Drawing.Point(1162, 759)
        Me.equipment_cost_input.Margin = New System.Windows.Forms.Padding(4)
        Me.equipment_cost_input.Multiline = False
        Me.equipment_cost_input.Name = "equipment_cost_input"
        Me.equipment_cost_input.NormalImageTint = System.Drawing.Color.Silver
        Me.equipment_cost_input.OutlineColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.equipment_cost_input.Padding = New System.Windows.Forms.Padding(23, 13, 23, 0)
        Me.equipment_cost_input.PasswordChar = False
        Me.equipment_cost_input.PlaceholderColor = System.Drawing.Color.DimGray
        Me.equipment_cost_input.PlaceholderText = "Home Address"
        Me.equipment_cost_input.Rounding = New System.Windows.Forms.Padding(12)
        Me.equipment_cost_input.Size = New System.Drawing.Size(413, 49)
        Me.equipment_cost_input.TabIndex = 135
        Me.equipment_cost_input.TextOffset = New System.Drawing.Size(0, 0)
        Me.equipment_cost_input.UnderlinedStyle = True
        '
        'CuiLabel2
        '
        Me.CuiLabel2.BackColor = System.Drawing.Color.Transparent
        Me.CuiLabel2.Content = "Equipment\ Cost"
        Me.CuiLabel2.Font = New System.Drawing.Font("Helvetica", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CuiLabel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.CuiLabel2.HorizontalAlignment = System.Drawing.StringAlignment.Center
        Me.CuiLabel2.Location = New System.Drawing.Point(1162, 729)
        Me.CuiLabel2.Name = "CuiLabel2"
        Me.CuiLabel2.Size = New System.Drawing.Size(166, 32)
        Me.CuiLabel2.TabIndex = 136
        Me.CuiLabel2.VerticalAlignment = System.Drawing.StringAlignment.Near
        '
        'CuiLabel10
        '
        Me.CuiLabel10.BackColor = System.Drawing.Color.Transparent
        Me.CuiLabel10.Content = "Start\ Date"
        Me.CuiLabel10.Font = New System.Drawing.Font("Helvetica", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CuiLabel10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.CuiLabel10.HorizontalAlignment = System.Drawing.StringAlignment.Center
        Me.CuiLabel10.Location = New System.Drawing.Point(713, 409)
        Me.CuiLabel10.Name = "CuiLabel10"
        Me.CuiLabel10.Size = New System.Drawing.Size(169, 23)
        Me.CuiLabel10.TabIndex = 129
        Me.CuiLabel10.VerticalAlignment = System.Drawing.StringAlignment.Near
        '
        'start_date_input
        '
        Me.start_date_input.Content = New Date(2026, 3, 8, 0, 0, 0, 0)
        Me.start_date_input.EnableThemeChangeButton = True
        Me.start_date_input.Font = New System.Drawing.Font("Helvetica", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.start_date_input.ForeColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.start_date_input.HoverBackground = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.start_date_input.HoverOutline = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.start_date_input.Icon = CType(resources.GetObject("start_date_input.Icon"), System.Drawing.Image)
        Me.start_date_input.IconTint = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.start_date_input.Location = New System.Drawing.Point(729, 441)
        Me.start_date_input.Margin = New System.Windows.Forms.Padding(6)
        Me.start_date_input.Name = "start_date_input"
        Me.start_date_input.NormalBackground = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.start_date_input.NormalOutline = System.Drawing.Color.Transparent
        Me.start_date_input.OutlineThickness = 1.5!
        Me.start_date_input.PickerPosition = CuoreUI.Controls.cuiCalendarDatePicker.Position.Bottom
        Me.start_date_input.PressedBackground = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.start_date_input.PressedOutline = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.start_date_input.Rounding = 12
        Me.start_date_input.ShowIcon = True
        Me.start_date_input.Size = New System.Drawing.Size(394, 49)
        Me.start_date_input.TabIndex = 128
        Me.start_date_input.Theme = CuoreUI.Controls.Forms.DatePicker.Themes.Light
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
        Me.cancel_btn.Location = New System.Drawing.Point(1146, 1168)
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
        Me.confirm_btn.Location = New System.Drawing.Point(969, 1168)
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
        Me.CuiLabel5.Content = "Manage\ Maintenance"
        Me.CuiLabel5.Font = New System.Drawing.Font("Helvetica", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CuiLabel5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.CuiLabel5.HorizontalAlignment = System.Drawing.StringAlignment.Center
        Me.CuiLabel5.Location = New System.Drawing.Point(937, 49)
        Me.CuiLabel5.Name = "CuiLabel5"
        Me.CuiLabel5.Size = New System.Drawing.Size(362, 65)
        Me.CuiLabel5.TabIndex = 85
        Me.CuiLabel5.VerticalAlignment = System.Drawing.StringAlignment.Near
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
        'notes_input
        '
        Me.notes_input.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.notes_input.Content = ""
        Me.notes_input.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.notes_input.FocusBackgroundColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.notes_input.FocusImageTint = System.Drawing.Color.White
        Me.notes_input.FocusOutlineColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.notes_input.Font = New System.Drawing.Font("Helvetica", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.notes_input.ForeColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.notes_input.Image = Nothing
        Me.notes_input.ImageExpand = New System.Drawing.Point(0, 0)
        Me.notes_input.ImageOffset = New System.Drawing.Point(0, 0)
        Me.notes_input.Location = New System.Drawing.Point(731, 551)
        Me.notes_input.Margin = New System.Windows.Forms.Padding(4)
        Me.notes_input.Multiline = False
        Me.notes_input.Name = "notes_input"
        Me.notes_input.NormalImageTint = System.Drawing.Color.Silver
        Me.notes_input.OutlineColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.notes_input.Padding = New System.Windows.Forms.Padding(23, 31, 23, 0)
        Me.notes_input.PasswordChar = False
        Me.notes_input.PlaceholderColor = System.Drawing.Color.DimGray
        Me.notes_input.PlaceholderText = "ex: equipment calibration, hvac system inspection, sensor battery replacement, et" &
    "c"
        Me.notes_input.Rounding = New System.Windows.Forms.Padding(12)
        Me.notes_input.Size = New System.Drawing.Size(844, 85)
        Me.notes_input.TabIndex = 92
        Me.notes_input.TextOffset = New System.Drawing.Size(0, 0)
        Me.notes_input.UnderlinedStyle = True
        '
        'type_input
        '
        Me.type_input.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.type_input.DropDownBackgroundColor = System.Drawing.Color.White
        Me.type_input.DropDownForeColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(27, Byte), Integer))
        Me.type_input.ExpandArrowColor = System.Drawing.Color.Gray
        Me.type_input.Font = New System.Drawing.Font("Helvetica", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.type_input.ForeColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.type_input.Items = New String(-1) {}
        Me.type_input.Location = New System.Drawing.Point(729, 230)
        Me.type_input.Margin = New System.Windows.Forms.Padding(6)
        Me.type_input.MaxDropDownHeight = 240
        Me.type_input.Name = "type_input"
        Me.type_input.NoSelectionText = "Select"
        Me.type_input.OutlineColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.type_input.OutlineThickness = 1.0!
        Me.type_input.Rounding = 12
        Me.type_input.SelectedIndex = -1
        Me.type_input.SelectedItem = ""
        Me.type_input.Size = New System.Drawing.Size(394, 49)
        Me.type_input.SortAlphabetically = True
        Me.type_input.TabIndex = 118
        '
        'CuiLabel4
        '
        Me.CuiLabel4.BackColor = System.Drawing.Color.Transparent
        Me.CuiLabel4.Content = "Type"
        Me.CuiLabel4.Font = New System.Drawing.Font("Helvetica", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CuiLabel4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.CuiLabel4.HorizontalAlignment = System.Drawing.StringAlignment.Center
        Me.CuiLabel4.Location = New System.Drawing.Point(713, 195)
        Me.CuiLabel4.Name = "CuiLabel4"
        Me.CuiLabel4.Size = New System.Drawing.Size(102, 28)
        Me.CuiLabel4.TabIndex = 117
        Me.CuiLabel4.VerticalAlignment = System.Drawing.StringAlignment.Near
        '
        'CuiLabel3
        '
        Me.CuiLabel3.BackColor = System.Drawing.Color.Transparent
        Me.CuiLabel3.Content = "Notes"
        Me.CuiLabel3.Font = New System.Drawing.Font("Helvetica", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CuiLabel3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.CuiLabel3.HorizontalAlignment = System.Drawing.StringAlignment.Center
        Me.CuiLabel3.Location = New System.Drawing.Point(681, 512)
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
        'museum_maintenance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(166, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Controls.Add(Me.tbc)
        Me.Name = "museum_maintenance"
        Me.Size = New System.Drawing.Size(2318, 1291)
        Me.tbc.ResumeLayout(False)
        Me.pg_browse.ResumeLayout(False)
        CType(Me.maintenance_grid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pg_manage.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tbc As TabControl
    Friend WithEvents pg_browse As TabPage
    Friend WithEvents MaterialDivider1 As ReaLTaiizor.Controls.MaterialDivider
    Friend WithEvents search_input As CuoreUI.Controls.cuiTextBox
    Friend WithEvents maintenance_grid As MetroFramework.Controls.MetroGrid
    Friend WithEvents pg_manage As TabPage
    Friend WithEvents servicer_input As CuoreUI.Controls.cuiTextBox
    Friend WithEvents CuiLabel6 As CuoreUI.Controls.cuiLabel
    Friend WithEvents equipment_cost_input As CuoreUI.Controls.cuiTextBox
    Friend WithEvents CuiLabel2 As CuoreUI.Controls.cuiLabel
    Friend WithEvents CuiLabel10 As CuoreUI.Controls.cuiLabel
    Friend WithEvents start_date_input As CuoreUI.Controls.cuiCalendarDatePicker
    Friend WithEvents cancel_btn As CuoreUI.Controls.cuiButton
    Friend WithEvents confirm_btn As CuoreUI.Controls.cuiButton
    Friend WithEvents CuiLabel5 As CuoreUI.Controls.cuiLabel
    Friend WithEvents mode_lbl As CuoreUI.Controls.cuiLabel
    Friend WithEvents notes_input As CuoreUI.Controls.cuiTextBox
    Friend WithEvents type_input As CuoreUI.Controls.cuiComboBox
    Friend WithEvents CuiLabel4 As CuoreUI.Controls.cuiLabel
    Friend WithEvents CuiLabel3 As CuoreUI.Controls.cuiLabel
    Friend WithEvents delete_confirmation As CuoreUI.Components.cuiMessageDialog
    Friend WithEvents employee_input As CuoreUI.Controls.cuiComboBox
    Friend WithEvents CuiLabel7 As CuoreUI.Controls.cuiLabel
    Friend WithEvents equipment_input As CuoreUI.Controls.cuiComboBox
    Friend WithEvents CuiLabel13 As CuoreUI.Controls.cuiLabel
    Friend WithEvents CuiLabel8 As CuoreUI.Controls.cuiLabel
    Friend WithEvents end_date_input As CuoreUI.Controls.cuiCalendarDatePicker
    Friend WithEvents add_equipment_btn As CuoreUI.Controls.cuiButton
    Friend WithEvents remove_equipment_btn As CuoreUI.Controls.cuiButton
    Friend WithEvents equipment_list As ListView
    Friend WithEvents Item As ColumnHeader
    Friend WithEvents Cost As ColumnHeader
    Friend WithEvents MaterialDivider2 As ReaLTaiizor.Controls.MaterialDivider
End Class
