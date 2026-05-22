<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class users
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
        Me.delete_confirmation = New CuoreUI.Components.cuiMessageDialog()
        Me.pg_browse = New System.Windows.Forms.TabPage()
        Me.MaterialDivider1 = New ReaLTaiizor.Controls.MaterialDivider()
        Me.search_input = New CuoreUI.Controls.cuiTextBox()
        Me.users_grid = New MetroFramework.Controls.MetroGrid()
        Me.tbc = New System.Windows.Forms.TabControl()
        Me.pg_manage = New System.Windows.Forms.TabPage()
        Me.reset_pass_btn = New CuoreUI.Controls.cuiButton()
        Me.cancel_btn = New CuoreUI.Controls.cuiButton()
        Me.confirm_btn = New CuoreUI.Controls.cuiButton()
        Me.CuiLabel5 = New CuoreUI.Controls.cuiLabel()
        Me.mode_lbl = New CuoreUI.Controls.cuiLabel()
        Me.username_input = New CuoreUI.Controls.cuiTextBox()
        Me.CuiLabel9 = New CuoreUI.Controls.cuiLabel()
        Me.employee_input = New CuoreUI.Controls.cuiComboBox()
        Me.employee_lbl = New CuoreUI.Controls.cuiLabel()
        Me.pg_browse.SuspendLayout()
        CType(Me.users_grid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tbc.SuspendLayout()
        Me.pg_manage.SuspendLayout()
        Me.SuspendLayout()
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
        'pg_browse
        '
        Me.pg_browse.BackColor = System.Drawing.Color.FromArgb(CType(CType(166, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.pg_browse.Controls.Add(Me.MaterialDivider1)
        Me.pg_browse.Controls.Add(Me.search_input)
        Me.pg_browse.Controls.Add(Me.users_grid)
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
        'users_grid
        '
        Me.users_grid.AllowUserToAddRows = False
        Me.users_grid.AllowUserToDeleteRows = False
        Me.users_grid.AllowUserToResizeColumns = False
        Me.users_grid.AllowUserToResizeRows = False
        Me.users_grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.users_grid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.users_grid.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.users_grid.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.users_grid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenHorizontal
        Me.users_grid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(84, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Helvetica", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle1.Padding = New System.Windows.Forms.Padding(10, 0, 10, 0)
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(84, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.users_grid.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.users_grid.ColumnHeadersHeight = 70
        Me.users_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Helvetica", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.users_grid.DefaultCellStyle = DataGridViewCellStyle2
        Me.users_grid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2
        Me.users_grid.EnableHeadersVisualStyles = False
        Me.users_grid.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.users_grid.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.users_grid.Location = New System.Drawing.Point(88, 185)
        Me.users_grid.Name = "users_grid"
        Me.users_grid.ReadOnly = True
        Me.users_grid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(217, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Helvetica", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(250, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.users_grid.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.users_grid.RowHeadersVisible = False
        Me.users_grid.RowHeadersWidth = 50
        Me.users_grid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(217, Byte), Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Helvetica", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle4.Padding = New System.Windows.Forms.Padding(0, 15, 0, 20)
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(250, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White
        Me.users_grid.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.users_grid.RowTemplate.Height = 42
        Me.users_grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.users_grid.Size = New System.Drawing.Size(2147, 970)
        Me.users_grid.TabIndex = 9
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
        Me.tbc.TabIndex = 1
        '
        'pg_manage
        '
        Me.pg_manage.BackColor = System.Drawing.Color.FromArgb(CType(CType(166, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.pg_manage.Controls.Add(Me.reset_pass_btn)
        Me.pg_manage.Controls.Add(Me.cancel_btn)
        Me.pg_manage.Controls.Add(Me.confirm_btn)
        Me.pg_manage.Controls.Add(Me.CuiLabel5)
        Me.pg_manage.Controls.Add(Me.mode_lbl)
        Me.pg_manage.Controls.Add(Me.username_input)
        Me.pg_manage.Controls.Add(Me.CuiLabel9)
        Me.pg_manage.Controls.Add(Me.employee_input)
        Me.pg_manage.Controls.Add(Me.employee_lbl)
        Me.pg_manage.Location = New System.Drawing.Point(4, 26)
        Me.pg_manage.Name = "pg_manage"
        Me.pg_manage.Padding = New System.Windows.Forms.Padding(3)
        Me.pg_manage.Size = New System.Drawing.Size(2329, 1268)
        Me.pg_manage.TabIndex = 1
        Me.pg_manage.Text = "Manage"
        '
        'reset_pass_btn
        '
        Me.reset_pass_btn.CheckButton = False
        Me.reset_pass_btn.Checked = False
        Me.reset_pass_btn.CheckedBackground = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.reset_pass_btn.CheckedForeColor = System.Drawing.Color.White
        Me.reset_pass_btn.CheckedImageTint = System.Drawing.Color.White
        Me.reset_pass_btn.CheckedOutline = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.reset_pass_btn.Content = "Reset Password"
        Me.reset_pass_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.reset_pass_btn.DialogResult = System.Windows.Forms.DialogResult.None
        Me.reset_pass_btn.Font = New System.Drawing.Font("Helvetica", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.reset_pass_btn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.reset_pass_btn.HoverBackground = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(161, Byte), Integer))
        Me.reset_pass_btn.HoverForeColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.reset_pass_btn.HoverImageTint = System.Drawing.Color.White
        Me.reset_pass_btn.HoverOutline = System.Drawing.Color.Transparent
        Me.reset_pass_btn.Image = Nothing
        Me.reset_pass_btn.ImageExpand = New System.Drawing.Point(3, 3)
        Me.reset_pass_btn.ImeMode = System.Windows.Forms.ImeMode.Close
        Me.reset_pass_btn.Location = New System.Drawing.Point(961, 518)
        Me.reset_pass_btn.Name = "reset_pass_btn"
        Me.reset_pass_btn.NormalBackground = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.reset_pass_btn.NormalForeColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.reset_pass_btn.NormalImageTint = System.Drawing.Color.White
        Me.reset_pass_btn.NormalOutline = System.Drawing.Color.Transparent
        Me.reset_pass_btn.OutlineThickness = 1.0!
        Me.reset_pass_btn.Padding = New System.Windows.Forms.Padding(12)
        Me.reset_pass_btn.PressedBackground = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.reset_pass_btn.PressedForeColor = System.Drawing.Color.White
        Me.reset_pass_btn.PressedImageTint = System.Drawing.Color.White
        Me.reset_pass_btn.PressedOutline = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.reset_pass_btn.Rounding = New System.Windows.Forms.Padding(12)
        Me.reset_pass_btn.Size = New System.Drawing.Size(166, 49)
        Me.reset_pass_btn.TabIndex = 125
        Me.reset_pass_btn.TextAlignment = System.Drawing.StringAlignment.Center
        Me.reset_pass_btn.TextPadding = 12
        Me.reset_pass_btn.TextSpacing = 2
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
        Me.cancel_btn.Location = New System.Drawing.Point(1148, 518)
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
        Me.confirm_btn.Location = New System.Drawing.Point(971, 518)
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
        Me.CuiLabel5.Content = "Manage\ Users"
        Me.CuiLabel5.Font = New System.Drawing.Font("Helvetica", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CuiLabel5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.CuiLabel5.HorizontalAlignment = System.Drawing.StringAlignment.Center
        Me.CuiLabel5.Location = New System.Drawing.Point(958, 46)
        Me.CuiLabel5.Name = "CuiLabel5"
        Me.CuiLabel5.Size = New System.Drawing.Size(303, 65)
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
        Me.mode_lbl.Location = New System.Drawing.Point(994, 130)
        Me.mode_lbl.Name = "mode_lbl"
        Me.mode_lbl.Size = New System.Drawing.Size(227, 44)
        Me.mode_lbl.TabIndex = 124
        Me.mode_lbl.VerticalAlignment = System.Drawing.StringAlignment.Near
        '
        'username_input
        '
        Me.username_input.BackColor = System.Drawing.Color.Transparent
        Me.username_input.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.username_input.Content = ""
        Me.username_input.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.username_input.Enabled = False
        Me.username_input.FocusBackgroundColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.username_input.FocusImageTint = System.Drawing.Color.White
        Me.username_input.FocusOutlineColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.username_input.Font = New System.Drawing.Font("Helvetica", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.username_input.ForeColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.username_input.Image = Nothing
        Me.username_input.ImageExpand = New System.Drawing.Point(0, 0)
        Me.username_input.ImageOffset = New System.Drawing.Point(0, 0)
        Me.username_input.Location = New System.Drawing.Point(942, 282)
        Me.username_input.Margin = New System.Windows.Forms.Padding(4)
        Me.username_input.Multiline = False
        Me.username_input.Name = "username_input"
        Me.username_input.NormalImageTint = System.Drawing.Color.Silver
        Me.username_input.OutlineColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.username_input.Padding = New System.Windows.Forms.Padding(23, 13, 23, 0)
        Me.username_input.PasswordChar = False
        Me.username_input.PlaceholderColor = System.Drawing.Color.DimGray
        Me.username_input.PlaceholderText = "Username"
        Me.username_input.Rounding = New System.Windows.Forms.Padding(12)
        Me.username_input.Size = New System.Drawing.Size(371, 49)
        Me.username_input.TabIndex = 121
        Me.username_input.TextOffset = New System.Drawing.Size(0, 0)
        Me.username_input.UnderlinedStyle = True
        '
        'CuiLabel9
        '
        Me.CuiLabel9.BackColor = System.Drawing.Color.Transparent
        Me.CuiLabel9.Content = "Username"
        Me.CuiLabel9.Font = New System.Drawing.Font("Helvetica", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CuiLabel9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.CuiLabel9.HorizontalAlignment = System.Drawing.StringAlignment.Center
        Me.CuiLabel9.Location = New System.Drawing.Point(939, 252)
        Me.CuiLabel9.Name = "CuiLabel9"
        Me.CuiLabel9.Size = New System.Drawing.Size(128, 30)
        Me.CuiLabel9.TabIndex = 122
        Me.CuiLabel9.VerticalAlignment = System.Drawing.StringAlignment.Near
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
        Me.employee_input.Location = New System.Drawing.Point(938, 397)
        Me.employee_input.Margin = New System.Windows.Forms.Padding(6)
        Me.employee_input.MaxDropDownHeight = 240
        Me.employee_input.Name = "employee_input"
        Me.employee_input.NoSelectionText = "Select"
        Me.employee_input.OutlineColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.employee_input.OutlineThickness = 1.0!
        Me.employee_input.Rounding = 12
        Me.employee_input.SelectedIndex = -1
        Me.employee_input.SelectedItem = ""
        Me.employee_input.Size = New System.Drawing.Size(375, 49)
        Me.employee_input.SortAlphabetically = True
        Me.employee_input.TabIndex = 118
        '
        'employee_lbl
        '
        Me.employee_lbl.BackColor = System.Drawing.Color.Transparent
        Me.employee_lbl.Content = "Employee"
        Me.employee_lbl.Font = New System.Drawing.Font("Helvetica", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.employee_lbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.employee_lbl.HorizontalAlignment = System.Drawing.StringAlignment.Center
        Me.employee_lbl.Location = New System.Drawing.Point(915, 367)
        Me.employee_lbl.Name = "employee_lbl"
        Me.employee_lbl.Size = New System.Drawing.Size(166, 30)
        Me.employee_lbl.TabIndex = 117
        Me.employee_lbl.VerticalAlignment = System.Drawing.StringAlignment.Near
        '
        'users
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(166, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Controls.Add(Me.tbc)
        Me.Name = "users"
        Me.Size = New System.Drawing.Size(2318, 1291)
        Me.pg_browse.ResumeLayout(False)
        CType(Me.users_grid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tbc.ResumeLayout(False)
        Me.pg_manage.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents delete_confirmation As CuoreUI.Components.cuiMessageDialog
    Friend WithEvents pg_browse As TabPage
    Friend WithEvents MaterialDivider1 As ReaLTaiizor.Controls.MaterialDivider
    Friend WithEvents search_input As CuoreUI.Controls.cuiTextBox
    Friend WithEvents users_grid As MetroFramework.Controls.MetroGrid
    Friend WithEvents tbc As TabControl
    Friend WithEvents pg_manage As TabPage
    Friend WithEvents reset_pass_btn As CuoreUI.Controls.cuiButton
    Friend WithEvents cancel_btn As CuoreUI.Controls.cuiButton
    Friend WithEvents confirm_btn As CuoreUI.Controls.cuiButton
    Friend WithEvents CuiLabel5 As CuoreUI.Controls.cuiLabel
    Friend WithEvents mode_lbl As CuoreUI.Controls.cuiLabel
    Friend WithEvents username_input As CuoreUI.Controls.cuiTextBox
    Friend WithEvents CuiLabel9 As CuoreUI.Controls.cuiLabel
    Friend WithEvents employee_input As CuoreUI.Controls.cuiComboBox
    Friend WithEvents employee_lbl As CuoreUI.Controls.cuiLabel
End Class
