<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class museum_employees
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(museum_employees))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.delete_confirmation = New CuoreUI.Components.cuiMessageDialog()
        Me.CuiLabel10 = New CuoreUI.Controls.cuiLabel()
        Me.dob_input = New CuoreUI.Controls.cuiCalendarDatePicker()
        Me.cancel_btn = New CuoreUI.Controls.cuiButton()
        Me.confirm_btn = New CuoreUI.Controls.cuiButton()
        Me.CuiLabel5 = New CuoreUI.Controls.cuiLabel()
        Me.CuiLabel12 = New CuoreUI.Controls.cuiLabel()
        Me.email_input = New CuoreUI.Controls.cuiTextBox()
        Me.mode_lbl = New CuoreUI.Controls.cuiLabel()
        Me.first_name_input = New CuoreUI.Controls.cuiTextBox()
        Me.CuiLabel15 = New CuoreUI.Controls.cuiLabel()
        Me.pg_browse = New System.Windows.Forms.TabPage()
        Me.MaterialDivider1 = New ReaLTaiizor.Controls.MaterialDivider()
        Me.search_input = New CuoreUI.Controls.cuiTextBox()
        Me.employees_grid = New MetroFramework.Controls.MetroGrid()
        Me.pg_manage = New System.Windows.Forms.TabPage()
        Me.salary_input = New CuoreUI.Controls.cuiTextBox()
        Me.CuiLabel6 = New CuoreUI.Controls.cuiLabel()
        Me.home_addr_input = New CuoreUI.Controls.cuiTextBox()
        Me.CuiLabel2 = New CuoreUI.Controls.cuiLabel()
        Me.CuiLabel1 = New CuoreUI.Controls.cuiLabel()
        Me.hire_date_input = New CuoreUI.Controls.cuiCalendarDatePicker()
        Me.input_female = New ReaLTaiizor.Controls.ParrotRadioButton()
        Me.input_male = New ReaLTaiizor.Controls.ParrotRadioButton()
        Me.CuiLabel11 = New CuoreUI.Controls.cuiLabel()
        Me.CuiLabel9 = New CuoreUI.Controls.cuiLabel()
        Me.last_name_input = New CuoreUI.Controls.cuiTextBox()
        Me.phone_input = New CuoreUI.Controls.cuiTextBox()
        Me.position_input = New CuoreUI.Controls.cuiComboBox()
        Me.CuiLabel4 = New CuoreUI.Controls.cuiLabel()
        Me.CuiLabel3 = New CuoreUI.Controls.cuiLabel()
        Me.tbc = New System.Windows.Forms.TabControl()
        Me.pg_browse.SuspendLayout()
        CType(Me.employees_grid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pg_manage.SuspendLayout()
        Me.tbc.SuspendLayout()
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
        'CuiLabel10
        '
        Me.CuiLabel10.BackColor = System.Drawing.Color.Transparent
        Me.CuiLabel10.Content = "Date\ of\ Birth"
        Me.CuiLabel10.Font = New System.Drawing.Font("Helvetica", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CuiLabel10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.CuiLabel10.HorizontalAlignment = System.Drawing.StringAlignment.Center
        Me.CuiLabel10.Location = New System.Drawing.Point(1157, 367)
        Me.CuiLabel10.Name = "CuiLabel10"
        Me.CuiLabel10.Size = New System.Drawing.Size(169, 23)
        Me.CuiLabel10.TabIndex = 129
        Me.CuiLabel10.VerticalAlignment = System.Drawing.StringAlignment.Near
        '
        'dob_input
        '
        Me.dob_input.Content = New Date(2026, 3, 8, 0, 0, 0, 0)
        Me.dob_input.EnableThemeChangeButton = True
        Me.dob_input.Font = New System.Drawing.Font("Helvetica", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dob_input.ForeColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.dob_input.HoverBackground = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.dob_input.HoverOutline = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.dob_input.Icon = CType(resources.GetObject("dob_input.Icon"), System.Drawing.Image)
        Me.dob_input.IconTint = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.dob_input.Location = New System.Drawing.Point(1175, 399)
        Me.dob_input.Margin = New System.Windows.Forms.Padding(6)
        Me.dob_input.Name = "dob_input"
        Me.dob_input.NormalBackground = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.dob_input.NormalOutline = System.Drawing.Color.Transparent
        Me.dob_input.OutlineThickness = 1.5!
        Me.dob_input.PickerPosition = CuoreUI.Controls.cuiCalendarDatePicker.Position.Bottom
        Me.dob_input.PressedBackground = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.dob_input.PressedOutline = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.dob_input.Rounding = 12
        Me.dob_input.ShowIcon = True
        Me.dob_input.Size = New System.Drawing.Size(391, 49)
        Me.dob_input.TabIndex = 128
        Me.dob_input.Theme = CuoreUI.Controls.Forms.DatePicker.Themes.Light
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
        Me.cancel_btn.Location = New System.Drawing.Point(1146, 973)
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
        Me.confirm_btn.Location = New System.Drawing.Point(969, 973)
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
        Me.CuiLabel5.Content = "Manage\ Employees"
        Me.CuiLabel5.Font = New System.Drawing.Font("Helvetica", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CuiLabel5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.CuiLabel5.HorizontalAlignment = System.Drawing.StringAlignment.Center
        Me.CuiLabel5.Location = New System.Drawing.Point(951, 45)
        Me.CuiLabel5.Name = "CuiLabel5"
        Me.CuiLabel5.Size = New System.Drawing.Size(321, 65)
        Me.CuiLabel5.TabIndex = 85
        Me.CuiLabel5.VerticalAlignment = System.Drawing.StringAlignment.Near
        '
        'CuiLabel12
        '
        Me.CuiLabel12.BackColor = System.Drawing.Color.Transparent
        Me.CuiLabel12.Content = "Email"
        Me.CuiLabel12.Font = New System.Drawing.Font("Helvetica", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CuiLabel12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.CuiLabel12.HorizontalAlignment = System.Drawing.StringAlignment.Center
        Me.CuiLabel12.Location = New System.Drawing.Point(1127, 468)
        Me.CuiLabel12.Name = "CuiLabel12"
        Me.CuiLabel12.Size = New System.Drawing.Size(166, 22)
        Me.CuiLabel12.TabIndex = 126
        Me.CuiLabel12.VerticalAlignment = System.Drawing.StringAlignment.Near
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
        Me.email_input.Location = New System.Drawing.Point(1175, 497)
        Me.email_input.Margin = New System.Windows.Forms.Padding(4)
        Me.email_input.Multiline = False
        Me.email_input.Name = "email_input"
        Me.email_input.NormalImageTint = System.Drawing.Color.Silver
        Me.email_input.OutlineColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.email_input.Padding = New System.Windows.Forms.Padding(23, 13, 23, 0)
        Me.email_input.PasswordChar = False
        Me.email_input.PlaceholderColor = System.Drawing.Color.DimGray
        Me.email_input.PlaceholderText = "Email"
        Me.email_input.Rounding = New System.Windows.Forms.Padding(12)
        Me.email_input.Size = New System.Drawing.Size(391, 49)
        Me.email_input.TabIndex = 125
        Me.email_input.TextOffset = New System.Drawing.Size(0, 0)
        Me.email_input.UnderlinedStyle = True
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
        Me.first_name_input.Location = New System.Drawing.Point(733, 285)
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
        Me.first_name_input.Size = New System.Drawing.Size(392, 49)
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
        Me.CuiLabel15.Location = New System.Drawing.Point(1175, 255)
        Me.CuiLabel15.Name = "CuiLabel15"
        Me.CuiLabel15.Size = New System.Drawing.Size(128, 30)
        Me.CuiLabel15.TabIndex = 87
        Me.CuiLabel15.VerticalAlignment = System.Drawing.StringAlignment.Near
        '
        'pg_browse
        '
        Me.pg_browse.BackColor = System.Drawing.Color.FromArgb(CType(CType(166, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.pg_browse.Controls.Add(Me.MaterialDivider1)
        Me.pg_browse.Controls.Add(Me.search_input)
        Me.pg_browse.Controls.Add(Me.employees_grid)
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
        'employees_grid
        '
        Me.employees_grid.AllowUserToAddRows = False
        Me.employees_grid.AllowUserToDeleteRows = False
        Me.employees_grid.AllowUserToResizeColumns = False
        Me.employees_grid.AllowUserToResizeRows = False
        Me.employees_grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.employees_grid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.employees_grid.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.employees_grid.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.employees_grid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenHorizontal
        Me.employees_grid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(84, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Helvetica", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle1.Padding = New System.Windows.Forms.Padding(10, 0, 10, 0)
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(84, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.employees_grid.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.employees_grid.ColumnHeadersHeight = 70
        Me.employees_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Helvetica", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.employees_grid.DefaultCellStyle = DataGridViewCellStyle2
        Me.employees_grid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2
        Me.employees_grid.EnableHeadersVisualStyles = False
        Me.employees_grid.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.employees_grid.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.employees_grid.Location = New System.Drawing.Point(88, 185)
        Me.employees_grid.Name = "employees_grid"
        Me.employees_grid.ReadOnly = True
        Me.employees_grid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(217, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Helvetica", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(250, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.employees_grid.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.employees_grid.RowHeadersVisible = False
        Me.employees_grid.RowHeadersWidth = 50
        Me.employees_grid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(217, Byte), Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Helvetica", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle4.Padding = New System.Windows.Forms.Padding(0, 15, 0, 20)
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(250, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White
        Me.employees_grid.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.employees_grid.RowTemplate.Height = 42
        Me.employees_grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.employees_grid.Size = New System.Drawing.Size(2147, 970)
        Me.employees_grid.TabIndex = 9
        '
        'pg_manage
        '
        Me.pg_manage.BackColor = System.Drawing.Color.FromArgb(CType(CType(166, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.pg_manage.Controls.Add(Me.salary_input)
        Me.pg_manage.Controls.Add(Me.CuiLabel6)
        Me.pg_manage.Controls.Add(Me.home_addr_input)
        Me.pg_manage.Controls.Add(Me.CuiLabel2)
        Me.pg_manage.Controls.Add(Me.CuiLabel1)
        Me.pg_manage.Controls.Add(Me.hire_date_input)
        Me.pg_manage.Controls.Add(Me.input_female)
        Me.pg_manage.Controls.Add(Me.input_male)
        Me.pg_manage.Controls.Add(Me.CuiLabel11)
        Me.pg_manage.Controls.Add(Me.CuiLabel10)
        Me.pg_manage.Controls.Add(Me.dob_input)
        Me.pg_manage.Controls.Add(Me.cancel_btn)
        Me.pg_manage.Controls.Add(Me.confirm_btn)
        Me.pg_manage.Controls.Add(Me.CuiLabel5)
        Me.pg_manage.Controls.Add(Me.CuiLabel12)
        Me.pg_manage.Controls.Add(Me.email_input)
        Me.pg_manage.Controls.Add(Me.mode_lbl)
        Me.pg_manage.Controls.Add(Me.first_name_input)
        Me.pg_manage.Controls.Add(Me.CuiLabel15)
        Me.pg_manage.Controls.Add(Me.CuiLabel9)
        Me.pg_manage.Controls.Add(Me.last_name_input)
        Me.pg_manage.Controls.Add(Me.phone_input)
        Me.pg_manage.Controls.Add(Me.position_input)
        Me.pg_manage.Controls.Add(Me.CuiLabel4)
        Me.pg_manage.Controls.Add(Me.CuiLabel3)
        Me.pg_manage.Location = New System.Drawing.Point(4, 26)
        Me.pg_manage.Name = "pg_manage"
        Me.pg_manage.Padding = New System.Windows.Forms.Padding(3)
        Me.pg_manage.Size = New System.Drawing.Size(2329, 1268)
        Me.pg_manage.TabIndex = 1
        Me.pg_manage.Text = "Manage"
        '
        'salary_input
        '
        Me.salary_input.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.salary_input.Content = ""
        Me.salary_input.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.salary_input.FocusBackgroundColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.salary_input.FocusImageTint = System.Drawing.Color.White
        Me.salary_input.FocusOutlineColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.salary_input.Font = New System.Drawing.Font("Helvetica", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.salary_input.ForeColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.salary_input.Image = Nothing
        Me.salary_input.ImageExpand = New System.Drawing.Point(0, 0)
        Me.salary_input.ImageOffset = New System.Drawing.Point(0, 0)
        Me.salary_input.Location = New System.Drawing.Point(732, 730)
        Me.salary_input.Margin = New System.Windows.Forms.Padding(4)
        Me.salary_input.Multiline = False
        Me.salary_input.Name = "salary_input"
        Me.salary_input.NormalImageTint = System.Drawing.Color.Silver
        Me.salary_input.OutlineColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.salary_input.Padding = New System.Windows.Forms.Padding(23, 13, 23, 0)
        Me.salary_input.PasswordChar = False
        Me.salary_input.PlaceholderColor = System.Drawing.Color.DimGray
        Me.salary_input.PlaceholderText = "Salary"
        Me.salary_input.Rounding = New System.Windows.Forms.Padding(12)
        Me.salary_input.Size = New System.Drawing.Size(391, 49)
        Me.salary_input.TabIndex = 137
        Me.salary_input.TextOffset = New System.Drawing.Size(0, 0)
        Me.salary_input.UnderlinedStyle = True
        '
        'CuiLabel6
        '
        Me.CuiLabel6.BackColor = System.Drawing.Color.Transparent
        Me.CuiLabel6.Content = "Salary"
        Me.CuiLabel6.Font = New System.Drawing.Font("Helvetica", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CuiLabel6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.CuiLabel6.HorizontalAlignment = System.Drawing.StringAlignment.Center
        Me.CuiLabel6.Location = New System.Drawing.Point(693, 702)
        Me.CuiLabel6.Name = "CuiLabel6"
        Me.CuiLabel6.Size = New System.Drawing.Size(166, 32)
        Me.CuiLabel6.TabIndex = 138
        Me.CuiLabel6.VerticalAlignment = System.Drawing.StringAlignment.Near
        '
        'home_addr_input
        '
        Me.home_addr_input.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.home_addr_input.Content = ""
        Me.home_addr_input.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.home_addr_input.FocusBackgroundColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.home_addr_input.FocusImageTint = System.Drawing.Color.White
        Me.home_addr_input.FocusOutlineColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.home_addr_input.Font = New System.Drawing.Font("Helvetica", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.home_addr_input.ForeColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.home_addr_input.Image = Nothing
        Me.home_addr_input.ImageExpand = New System.Drawing.Point(0, 0)
        Me.home_addr_input.ImageOffset = New System.Drawing.Point(0, 0)
        Me.home_addr_input.Location = New System.Drawing.Point(1175, 614)
        Me.home_addr_input.Margin = New System.Windows.Forms.Padding(4)
        Me.home_addr_input.Multiline = False
        Me.home_addr_input.Name = "home_addr_input"
        Me.home_addr_input.NormalImageTint = System.Drawing.Color.Silver
        Me.home_addr_input.OutlineColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.home_addr_input.Padding = New System.Windows.Forms.Padding(23, 13, 23, 0)
        Me.home_addr_input.PasswordChar = False
        Me.home_addr_input.PlaceholderColor = System.Drawing.Color.DimGray
        Me.home_addr_input.PlaceholderText = "Home Address"
        Me.home_addr_input.Rounding = New System.Windows.Forms.Padding(12)
        Me.home_addr_input.Size = New System.Drawing.Size(391, 49)
        Me.home_addr_input.TabIndex = 135
        Me.home_addr_input.TextOffset = New System.Drawing.Size(0, 0)
        Me.home_addr_input.UnderlinedStyle = True
        '
        'CuiLabel2
        '
        Me.CuiLabel2.BackColor = System.Drawing.Color.Transparent
        Me.CuiLabel2.Content = "Home\ Address"
        Me.CuiLabel2.Font = New System.Drawing.Font("Helvetica", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CuiLabel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.CuiLabel2.HorizontalAlignment = System.Drawing.StringAlignment.Center
        Me.CuiLabel2.Location = New System.Drawing.Point(1175, 584)
        Me.CuiLabel2.Name = "CuiLabel2"
        Me.CuiLabel2.Size = New System.Drawing.Size(166, 32)
        Me.CuiLabel2.TabIndex = 136
        Me.CuiLabel2.VerticalAlignment = System.Drawing.StringAlignment.Near
        '
        'CuiLabel1
        '
        Me.CuiLabel1.BackColor = System.Drawing.Color.Transparent
        Me.CuiLabel1.Content = "Hire\ Date"
        Me.CuiLabel1.Font = New System.Drawing.Font("Helvetica", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CuiLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.CuiLabel1.HorizontalAlignment = System.Drawing.StringAlignment.Center
        Me.CuiLabel1.Location = New System.Drawing.Point(702, 467)
        Me.CuiLabel1.Name = "CuiLabel1"
        Me.CuiLabel1.Size = New System.Drawing.Size(169, 23)
        Me.CuiLabel1.TabIndex = 134
        Me.CuiLabel1.VerticalAlignment = System.Drawing.StringAlignment.Near
        '
        'hire_date_input
        '
        Me.hire_date_input.Content = New Date(2026, 3, 8, 0, 0, 0, 0)
        Me.hire_date_input.EnableThemeChangeButton = True
        Me.hire_date_input.Font = New System.Drawing.Font("Helvetica", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hire_date_input.ForeColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.hire_date_input.HoverBackground = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.hire_date_input.HoverOutline = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.hire_date_input.Icon = CType(resources.GetObject("hire_date_input.Icon"), System.Drawing.Image)
        Me.hire_date_input.IconTint = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.hire_date_input.Location = New System.Drawing.Point(734, 499)
        Me.hire_date_input.Margin = New System.Windows.Forms.Padding(6)
        Me.hire_date_input.Name = "hire_date_input"
        Me.hire_date_input.NormalBackground = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.hire_date_input.NormalOutline = System.Drawing.Color.Transparent
        Me.hire_date_input.OutlineThickness = 1.5!
        Me.hire_date_input.PickerPosition = CuoreUI.Controls.cuiCalendarDatePicker.Position.Bottom
        Me.hire_date_input.PressedBackground = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.hire_date_input.PressedOutline = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.hire_date_input.Rounding = 12
        Me.hire_date_input.ShowIcon = True
        Me.hire_date_input.Size = New System.Drawing.Size(391, 49)
        Me.hire_date_input.TabIndex = 133
        Me.hire_date_input.Theme = CuoreUI.Controls.Forms.DatePicker.Themes.Light
        '
        'input_female
        '
        Me.input_female.Checked = False
        Me.input_female.Cursor = System.Windows.Forms.Cursors.Hand
        Me.input_female.ForeColor = System.Drawing.Color.White
        Me.input_female.Location = New System.Drawing.Point(884, 413)
        Me.input_female.Name = "input_female"
        Me.input_female.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality
        Me.input_female.RadioColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(162, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.input_female.RadioHoverColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(98, Byte), Integer))
        Me.input_female.RadioStyle = ReaLTaiizor.Controls.ParrotRadioButton.Style.Material
        Me.input_female.Size = New System.Drawing.Size(147, 26)
        Me.input_female.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias
        Me.input_female.TabIndex = 132
        Me.input_female.Text = "Female"
        Me.input_female.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit
        '
        'input_male
        '
        Me.input_male.Checked = False
        Me.input_male.Cursor = System.Windows.Forms.Cursors.Hand
        Me.input_male.ForeColor = System.Drawing.Color.White
        Me.input_male.Location = New System.Drawing.Point(734, 413)
        Me.input_male.Name = "input_male"
        Me.input_male.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality
        Me.input_male.RadioColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(162, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.input_male.RadioHoverColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(98, Byte), Integer))
        Me.input_male.RadioStyle = ReaLTaiizor.Controls.ParrotRadioButton.Style.Material
        Me.input_male.Size = New System.Drawing.Size(125, 26)
        Me.input_male.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias
        Me.input_male.TabIndex = 131
        Me.input_male.Text = "Male"
        Me.input_male.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit
        '
        'CuiLabel11
        '
        Me.CuiLabel11.BackColor = System.Drawing.Color.Transparent
        Me.CuiLabel11.Content = "Gender"
        Me.CuiLabel11.Font = New System.Drawing.Font("Helvetica", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CuiLabel11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.CuiLabel11.HorizontalAlignment = System.Drawing.StringAlignment.Center
        Me.CuiLabel11.Location = New System.Drawing.Point(693, 360)
        Me.CuiLabel11.Name = "CuiLabel11"
        Me.CuiLabel11.Size = New System.Drawing.Size(166, 30)
        Me.CuiLabel11.TabIndex = 130
        Me.CuiLabel11.VerticalAlignment = System.Drawing.StringAlignment.Near
        '
        'CuiLabel9
        '
        Me.CuiLabel9.BackColor = System.Drawing.Color.Transparent
        Me.CuiLabel9.Content = "First\ Name"
        Me.CuiLabel9.Font = New System.Drawing.Font("Helvetica", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CuiLabel9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.CuiLabel9.HorizontalAlignment = System.Drawing.StringAlignment.Center
        Me.CuiLabel9.Location = New System.Drawing.Point(731, 255)
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
        Me.last_name_input.Location = New System.Drawing.Point(1175, 285)
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
        Me.last_name_input.Size = New System.Drawing.Size(391, 49)
        Me.last_name_input.TabIndex = 83
        Me.last_name_input.TextOffset = New System.Drawing.Size(0, 0)
        Me.last_name_input.UnderlinedStyle = True
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
        Me.phone_input.Location = New System.Drawing.Point(734, 614)
        Me.phone_input.Margin = New System.Windows.Forms.Padding(4)
        Me.phone_input.Multiline = False
        Me.phone_input.Name = "phone_input"
        Me.phone_input.NormalImageTint = System.Drawing.Color.Silver
        Me.phone_input.OutlineColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.phone_input.Padding = New System.Windows.Forms.Padding(23, 13, 23, 0)
        Me.phone_input.PasswordChar = False
        Me.phone_input.PlaceholderColor = System.Drawing.Color.DimGray
        Me.phone_input.PlaceholderText = "Phone Number"
        Me.phone_input.Rounding = New System.Windows.Forms.Padding(12)
        Me.phone_input.Size = New System.Drawing.Size(391, 49)
        Me.phone_input.TabIndex = 92
        Me.phone_input.TextOffset = New System.Drawing.Size(0, 0)
        Me.phone_input.UnderlinedStyle = True
        '
        'position_input
        '
        Me.position_input.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.position_input.DropDownBackgroundColor = System.Drawing.Color.White
        Me.position_input.DropDownForeColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(27, Byte), Integer))
        Me.position_input.ExpandArrowColor = System.Drawing.Color.Gray
        Me.position_input.Font = New System.Drawing.Font("Helvetica", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.position_input.ForeColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.position_input.Items = New String(-1) {}
        Me.position_input.Location = New System.Drawing.Point(1175, 730)
        Me.position_input.Margin = New System.Windows.Forms.Padding(6)
        Me.position_input.MaxDropDownHeight = 240
        Me.position_input.Name = "position_input"
        Me.position_input.NoSelectionText = "Select"
        Me.position_input.OutlineColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.position_input.OutlineThickness = 1.0!
        Me.position_input.Rounding = 12
        Me.position_input.SelectedIndex = -1
        Me.position_input.SelectedItem = ""
        Me.position_input.Size = New System.Drawing.Size(391, 49)
        Me.position_input.SortAlphabetically = True
        Me.position_input.TabIndex = 118
        '
        'CuiLabel4
        '
        Me.CuiLabel4.BackColor = System.Drawing.Color.Transparent
        Me.CuiLabel4.Content = "Position"
        Me.CuiLabel4.Font = New System.Drawing.Font("Helvetica", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CuiLabel4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.CuiLabel4.HorizontalAlignment = System.Drawing.StringAlignment.Center
        Me.CuiLabel4.Location = New System.Drawing.Point(1157, 702)
        Me.CuiLabel4.Name = "CuiLabel4"
        Me.CuiLabel4.Size = New System.Drawing.Size(104, 30)
        Me.CuiLabel4.TabIndex = 117
        Me.CuiLabel4.VerticalAlignment = System.Drawing.StringAlignment.Near
        '
        'CuiLabel3
        '
        Me.CuiLabel3.BackColor = System.Drawing.Color.Transparent
        Me.CuiLabel3.Content = "Phone\ Number"
        Me.CuiLabel3.Font = New System.Drawing.Font("Helvetica", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CuiLabel3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.CuiLabel3.HorizontalAlignment = System.Drawing.StringAlignment.Center
        Me.CuiLabel3.Location = New System.Drawing.Point(731, 584)
        Me.CuiLabel3.Name = "CuiLabel3"
        Me.CuiLabel3.Size = New System.Drawing.Size(166, 32)
        Me.CuiLabel3.TabIndex = 105
        Me.CuiLabel3.VerticalAlignment = System.Drawing.StringAlignment.Near
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
        'museum_employees
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(166, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Controls.Add(Me.tbc)
        Me.Name = "museum_employees"
        Me.Size = New System.Drawing.Size(2318, 1291)
        Me.pg_browse.ResumeLayout(False)
        CType(Me.employees_grid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pg_manage.ResumeLayout(False)
        Me.tbc.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents delete_confirmation As CuoreUI.Components.cuiMessageDialog
    Friend WithEvents CuiLabel10 As CuoreUI.Controls.cuiLabel
    Friend WithEvents dob_input As CuoreUI.Controls.cuiCalendarDatePicker
    Friend WithEvents cancel_btn As CuoreUI.Controls.cuiButton
    Friend WithEvents confirm_btn As CuoreUI.Controls.cuiButton
    Friend WithEvents CuiLabel5 As CuoreUI.Controls.cuiLabel
    Friend WithEvents CuiLabel12 As CuoreUI.Controls.cuiLabel
    Friend WithEvents email_input As CuoreUI.Controls.cuiTextBox
    Friend WithEvents mode_lbl As CuoreUI.Controls.cuiLabel
    Friend WithEvents first_name_input As CuoreUI.Controls.cuiTextBox
    Friend WithEvents CuiLabel15 As CuoreUI.Controls.cuiLabel
    Friend WithEvents pg_browse As TabPage
    Friend WithEvents MaterialDivider1 As ReaLTaiizor.Controls.MaterialDivider
    Friend WithEvents search_input As CuoreUI.Controls.cuiTextBox
    Friend WithEvents employees_grid As MetroFramework.Controls.MetroGrid
    Friend WithEvents pg_manage As TabPage
    Friend WithEvents CuiLabel9 As CuoreUI.Controls.cuiLabel
    Friend WithEvents last_name_input As CuoreUI.Controls.cuiTextBox
    Friend WithEvents phone_input As CuoreUI.Controls.cuiTextBox
    Friend WithEvents position_input As CuoreUI.Controls.cuiComboBox
    Friend WithEvents CuiLabel4 As CuoreUI.Controls.cuiLabel
    Friend WithEvents CuiLabel3 As CuoreUI.Controls.cuiLabel
    Friend WithEvents tbc As TabControl
    Friend WithEvents input_female As ReaLTaiizor.Controls.ParrotRadioButton
    Friend WithEvents input_male As ReaLTaiizor.Controls.ParrotRadioButton
    Friend WithEvents CuiLabel11 As CuoreUI.Controls.cuiLabel
    Friend WithEvents CuiLabel1 As CuoreUI.Controls.cuiLabel
    Friend WithEvents hire_date_input As CuoreUI.Controls.cuiCalendarDatePicker
    Friend WithEvents salary_input As CuoreUI.Controls.cuiTextBox
    Friend WithEvents CuiLabel6 As CuoreUI.Controls.cuiLabel
    Friend WithEvents home_addr_input As CuoreUI.Controls.cuiTextBox
    Friend WithEvents CuiLabel2 As CuoreUI.Controls.cuiLabel
End Class
