<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class events
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(events))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.delete_confirmation = New CuoreUI.Components.cuiMessageDialog()
        Me.CuiLabel10 = New CuoreUI.Controls.cuiLabel()
        Me.event_date_input = New CuoreUI.Controls.cuiCalendarDatePicker()
        Me.cancel_btn = New CuoreUI.Controls.cuiButton()
        Me.confirm_btn = New CuoreUI.Controls.cuiButton()
        Me.CuiLabel5 = New CuoreUI.Controls.cuiLabel()
        Me.CuiLabel12 = New CuoreUI.Controls.cuiLabel()
        Me.capacity_input = New CuoreUI.Controls.cuiTextBox()
        Me.mode_lbl = New CuoreUI.Controls.cuiLabel()
        Me.CuiLabel15 = New CuoreUI.Controls.cuiLabel()
        Me.tbc = New System.Windows.Forms.TabControl()
        Me.pg_browse = New System.Windows.Forms.TabPage()
        Me.MaterialDivider1 = New ReaLTaiizor.Controls.MaterialDivider()
        Me.search_input = New CuoreUI.Controls.cuiTextBox()
        Me.events_grid = New MetroFramework.Controls.MetroGrid()
        Me.pg_manage = New System.Windows.Forms.TabPage()
        Me.attendees_checklist = New System.Windows.Forms.CheckedListBox()
        Me.employees_checklist = New System.Windows.Forms.CheckedListBox()
        Me.CuiLabel11 = New CuoreUI.Controls.cuiLabel()
        Me.CuiLabel9 = New CuoreUI.Controls.cuiLabel()
        Me.end_time_input = New System.Windows.Forms.DateTimePicker()
        Me.start_time_input = New System.Windows.Forms.DateTimePicker()
        Me.event_name_input = New CuoreUI.Controls.cuiTextBox()
        Me.status_input = New CuoreUI.Controls.cuiComboBox()
        Me.CuiLabel4 = New CuoreUI.Controls.cuiLabel()
        Me.tbc.SuspendLayout()
        Me.pg_browse.SuspendLayout()
        CType(Me.events_grid, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'CuiLabel10
        '
        Me.CuiLabel10.BackColor = System.Drawing.Color.Transparent
        Me.CuiLabel10.Content = "Date"
        Me.CuiLabel10.Font = New System.Drawing.Font("Helvetica", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CuiLabel10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.CuiLabel10.HorizontalAlignment = System.Drawing.StringAlignment.Center
        Me.CuiLabel10.Location = New System.Drawing.Point(839, 418)
        Me.CuiLabel10.Name = "CuiLabel10"
        Me.CuiLabel10.Size = New System.Drawing.Size(136, 23)
        Me.CuiLabel10.TabIndex = 129
        Me.CuiLabel10.VerticalAlignment = System.Drawing.StringAlignment.Near
        '
        'event_date_input
        '
        Me.event_date_input.Content = New Date(2026, 3, 8, 0, 0, 0, 0)
        Me.event_date_input.EnableThemeChangeButton = True
        Me.event_date_input.Font = New System.Drawing.Font("Helvetica", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.event_date_input.ForeColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.event_date_input.HoverBackground = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.event_date_input.HoverOutline = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.event_date_input.Icon = CType(resources.GetObject("event_date_input.Icon"), System.Drawing.Image)
        Me.event_date_input.IconTint = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.event_date_input.Location = New System.Drawing.Point(858, 450)
        Me.event_date_input.Margin = New System.Windows.Forms.Padding(6)
        Me.event_date_input.Name = "event_date_input"
        Me.event_date_input.NormalBackground = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.event_date_input.NormalOutline = System.Drawing.Color.Transparent
        Me.event_date_input.OutlineThickness = 1.5!
        Me.event_date_input.PickerPosition = CuoreUI.Controls.cuiCalendarDatePicker.Position.Bottom
        Me.event_date_input.PressedBackground = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.event_date_input.PressedOutline = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.event_date_input.Rounding = 12
        Me.event_date_input.ShowIcon = True
        Me.event_date_input.Size = New System.Drawing.Size(267, 49)
        Me.event_date_input.TabIndex = 128
        Me.event_date_input.Theme = CuoreUI.Controls.Forms.DatePicker.Themes.Light
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
        Me.CuiLabel5.Content = "Manage\ Events"
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
        Me.CuiLabel12.Content = "Capacity"
        Me.CuiLabel12.Font = New System.Drawing.Font("Helvetica", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CuiLabel12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.CuiLabel12.HorizontalAlignment = System.Drawing.StringAlignment.Center
        Me.CuiLabel12.Location = New System.Drawing.Point(828, 315)
        Me.CuiLabel12.Name = "CuiLabel12"
        Me.CuiLabel12.Size = New System.Drawing.Size(166, 32)
        Me.CuiLabel12.TabIndex = 126
        Me.CuiLabel12.VerticalAlignment = System.Drawing.StringAlignment.Near
        '
        'capacity_input
        '
        Me.capacity_input.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.capacity_input.Content = ""
        Me.capacity_input.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.capacity_input.FocusBackgroundColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.capacity_input.FocusImageTint = System.Drawing.Color.White
        Me.capacity_input.FocusOutlineColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.capacity_input.Font = New System.Drawing.Font("Helvetica", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.capacity_input.ForeColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.capacity_input.Image = Nothing
        Me.capacity_input.ImageExpand = New System.Drawing.Point(0, 0)
        Me.capacity_input.ImageOffset = New System.Drawing.Point(0, 0)
        Me.capacity_input.Location = New System.Drawing.Point(858, 347)
        Me.capacity_input.Margin = New System.Windows.Forms.Padding(4)
        Me.capacity_input.Multiline = False
        Me.capacity_input.Name = "capacity_input"
        Me.capacity_input.NormalImageTint = System.Drawing.Color.Silver
        Me.capacity_input.OutlineColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.capacity_input.Padding = New System.Windows.Forms.Padding(23, 13, 23, 0)
        Me.capacity_input.PasswordChar = False
        Me.capacity_input.PlaceholderColor = System.Drawing.Color.DimGray
        Me.capacity_input.PlaceholderText = "Capacity"
        Me.capacity_input.Rounding = New System.Windows.Forms.Padding(12)
        Me.capacity_input.Size = New System.Drawing.Size(144, 49)
        Me.capacity_input.TabIndex = 125
        Me.capacity_input.TextOffset = New System.Drawing.Size(0, 0)
        Me.capacity_input.UnderlinedStyle = True
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
        'CuiLabel15
        '
        Me.CuiLabel15.BackColor = System.Drawing.Color.Transparent
        Me.CuiLabel15.Content = "Name"
        Me.CuiLabel15.Font = New System.Drawing.Font("Helvetica", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CuiLabel15.ForeColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.CuiLabel15.HorizontalAlignment = System.Drawing.StringAlignment.Center
        Me.CuiLabel15.Location = New System.Drawing.Point(839, 183)
        Me.CuiLabel15.Name = "CuiLabel15"
        Me.CuiLabel15.Size = New System.Drawing.Size(128, 30)
        Me.CuiLabel15.TabIndex = 87
        Me.CuiLabel15.VerticalAlignment = System.Drawing.StringAlignment.Near
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
        'pg_browse
        '
        Me.pg_browse.BackColor = System.Drawing.Color.FromArgb(CType(CType(166, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.pg_browse.Controls.Add(Me.MaterialDivider1)
        Me.pg_browse.Controls.Add(Me.search_input)
        Me.pg_browse.Controls.Add(Me.events_grid)
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
        'events_grid
        '
        Me.events_grid.AllowUserToAddRows = False
        Me.events_grid.AllowUserToDeleteRows = False
        Me.events_grid.AllowUserToResizeColumns = False
        Me.events_grid.AllowUserToResizeRows = False
        Me.events_grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.events_grid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.events_grid.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.events_grid.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.events_grid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenHorizontal
        Me.events_grid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(84, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Helvetica", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle1.Padding = New System.Windows.Forms.Padding(10, 0, 10, 0)
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(84, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.events_grid.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.events_grid.ColumnHeadersHeight = 70
        Me.events_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Helvetica", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.events_grid.DefaultCellStyle = DataGridViewCellStyle2
        Me.events_grid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2
        Me.events_grid.EnableHeadersVisualStyles = False
        Me.events_grid.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.events_grid.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.events_grid.Location = New System.Drawing.Point(88, 185)
        Me.events_grid.Name = "events_grid"
        Me.events_grid.ReadOnly = True
        Me.events_grid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(217, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Helvetica", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(250, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.events_grid.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.events_grid.RowHeadersVisible = False
        Me.events_grid.RowHeadersWidth = 50
        Me.events_grid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(217, Byte), Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Helvetica", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle4.Padding = New System.Windows.Forms.Padding(0, 15, 0, 20)
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(250, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White
        Me.events_grid.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.events_grid.RowTemplate.Height = 42
        Me.events_grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.events_grid.Size = New System.Drawing.Size(2147, 970)
        Me.events_grid.TabIndex = 9
        '
        'pg_manage
        '
        Me.pg_manage.BackColor = System.Drawing.Color.FromArgb(CType(CType(166, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.pg_manage.Controls.Add(Me.attendees_checklist)
        Me.pg_manage.Controls.Add(Me.employees_checklist)
        Me.pg_manage.Controls.Add(Me.CuiLabel11)
        Me.pg_manage.Controls.Add(Me.CuiLabel9)
        Me.pg_manage.Controls.Add(Me.end_time_input)
        Me.pg_manage.Controls.Add(Me.start_time_input)
        Me.pg_manage.Controls.Add(Me.CuiLabel10)
        Me.pg_manage.Controls.Add(Me.event_date_input)
        Me.pg_manage.Controls.Add(Me.cancel_btn)
        Me.pg_manage.Controls.Add(Me.confirm_btn)
        Me.pg_manage.Controls.Add(Me.CuiLabel5)
        Me.pg_manage.Controls.Add(Me.CuiLabel12)
        Me.pg_manage.Controls.Add(Me.capacity_input)
        Me.pg_manage.Controls.Add(Me.mode_lbl)
        Me.pg_manage.Controls.Add(Me.CuiLabel15)
        Me.pg_manage.Controls.Add(Me.event_name_input)
        Me.pg_manage.Controls.Add(Me.status_input)
        Me.pg_manage.Controls.Add(Me.CuiLabel4)
        Me.pg_manage.Location = New System.Drawing.Point(4, 26)
        Me.pg_manage.Name = "pg_manage"
        Me.pg_manage.Padding = New System.Windows.Forms.Padding(3)
        Me.pg_manage.Size = New System.Drawing.Size(2329, 1268)
        Me.pg_manage.TabIndex = 1
        Me.pg_manage.Text = "Manage"
        '
        'attendees_checklist
        '
        Me.attendees_checklist.FormattingEnabled = True
        Me.attendees_checklist.Location = New System.Drawing.Point(1137, 659)
        Me.attendees_checklist.Name = "attendees_checklist"
        Me.attendees_checklist.Size = New System.Drawing.Size(257, 184)
        Me.attendees_checklist.TabIndex = 135
        '
        'employees_checklist
        '
        Me.employees_checklist.FormattingEnabled = True
        Me.employees_checklist.Location = New System.Drawing.Point(858, 657)
        Me.employees_checklist.Name = "employees_checklist"
        Me.employees_checklist.Size = New System.Drawing.Size(240, 184)
        Me.employees_checklist.TabIndex = 134
        '
        'CuiLabel11
        '
        Me.CuiLabel11.BackColor = System.Drawing.Color.Transparent
        Me.CuiLabel11.Content = "End\ Time"
        Me.CuiLabel11.Font = New System.Drawing.Font("Helvetica", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CuiLabel11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.CuiLabel11.HorizontalAlignment = System.Drawing.StringAlignment.Center
        Me.CuiLabel11.Location = New System.Drawing.Point(1137, 526)
        Me.CuiLabel11.Name = "CuiLabel11"
        Me.CuiLabel11.Size = New System.Drawing.Size(136, 23)
        Me.CuiLabel11.TabIndex = 133
        Me.CuiLabel11.VerticalAlignment = System.Drawing.StringAlignment.Near
        '
        'CuiLabel9
        '
        Me.CuiLabel9.BackColor = System.Drawing.Color.Transparent
        Me.CuiLabel9.Content = "Start\ Time"
        Me.CuiLabel9.Font = New System.Drawing.Font("Helvetica", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CuiLabel9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.CuiLabel9.HorizontalAlignment = System.Drawing.StringAlignment.Center
        Me.CuiLabel9.Location = New System.Drawing.Point(858, 526)
        Me.CuiLabel9.Name = "CuiLabel9"
        Me.CuiLabel9.Size = New System.Drawing.Size(136, 23)
        Me.CuiLabel9.TabIndex = 132
        Me.CuiLabel9.VerticalAlignment = System.Drawing.StringAlignment.Near
        '
        'end_time_input
        '
        Me.end_time_input.Font = New System.Drawing.Font("Helvetica", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.end_time_input.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.end_time_input.Location = New System.Drawing.Point(1147, 562)
        Me.end_time_input.Name = "end_time_input"
        Me.end_time_input.ShowUpDown = True
        Me.end_time_input.Size = New System.Drawing.Size(240, 30)
        Me.end_time_input.TabIndex = 131
        '
        'start_time_input
        '
        Me.start_time_input.Font = New System.Drawing.Font("Helvetica", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.start_time_input.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.start_time_input.Location = New System.Drawing.Point(858, 562)
        Me.start_time_input.Name = "start_time_input"
        Me.start_time_input.ShowUpDown = True
        Me.start_time_input.Size = New System.Drawing.Size(240, 30)
        Me.start_time_input.TabIndex = 130
        '
        'event_name_input
        '
        Me.event_name_input.BackColor = System.Drawing.Color.Transparent
        Me.event_name_input.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.event_name_input.Content = ""
        Me.event_name_input.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.event_name_input.FocusBackgroundColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.event_name_input.FocusImageTint = System.Drawing.Color.White
        Me.event_name_input.FocusOutlineColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.event_name_input.Font = New System.Drawing.Font("Helvetica", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.event_name_input.ForeColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.event_name_input.Image = Nothing
        Me.event_name_input.ImageExpand = New System.Drawing.Point(0, 0)
        Me.event_name_input.ImageOffset = New System.Drawing.Point(0, 0)
        Me.event_name_input.Location = New System.Drawing.Point(858, 213)
        Me.event_name_input.Margin = New System.Windows.Forms.Padding(4)
        Me.event_name_input.Multiline = False
        Me.event_name_input.Name = "event_name_input"
        Me.event_name_input.NormalImageTint = System.Drawing.Color.Silver
        Me.event_name_input.OutlineColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.event_name_input.Padding = New System.Windows.Forms.Padding(23, 13, 23, 0)
        Me.event_name_input.PasswordChar = False
        Me.event_name_input.PlaceholderColor = System.Drawing.Color.DimGray
        Me.event_name_input.PlaceholderText = "Event Name"
        Me.event_name_input.Rounding = New System.Windows.Forms.Padding(12)
        Me.event_name_input.Size = New System.Drawing.Size(536, 49)
        Me.event_name_input.TabIndex = 83
        Me.event_name_input.TextOffset = New System.Drawing.Size(0, 0)
        Me.event_name_input.UnderlinedStyle = True
        '
        'status_input
        '
        Me.status_input.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.status_input.DropDownBackgroundColor = System.Drawing.Color.White
        Me.status_input.DropDownForeColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(27, Byte), Integer))
        Me.status_input.ExpandArrowColor = System.Drawing.Color.Gray
        Me.status_input.Font = New System.Drawing.Font("Helvetica", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.status_input.ForeColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.status_input.Items = New String(-1) {}
        Me.status_input.Location = New System.Drawing.Point(1036, 347)
        Me.status_input.Margin = New System.Windows.Forms.Padding(6)
        Me.status_input.MaxDropDownHeight = 240
        Me.status_input.Name = "status_input"
        Me.status_input.NoSelectionText = "Select"
        Me.status_input.OutlineColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.status_input.OutlineThickness = 1.0!
        Me.status_input.Rounding = 12
        Me.status_input.SelectedIndex = -1
        Me.status_input.SelectedItem = ""
        Me.status_input.Size = New System.Drawing.Size(358, 49)
        Me.status_input.SortAlphabetically = True
        Me.status_input.TabIndex = 118
        '
        'CuiLabel4
        '
        Me.CuiLabel4.BackColor = System.Drawing.Color.Transparent
        Me.CuiLabel4.Content = "Status"
        Me.CuiLabel4.Font = New System.Drawing.Font("Helvetica", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CuiLabel4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.CuiLabel4.HorizontalAlignment = System.Drawing.StringAlignment.Center
        Me.CuiLabel4.Location = New System.Drawing.Point(985, 317)
        Me.CuiLabel4.Name = "CuiLabel4"
        Me.CuiLabel4.Size = New System.Drawing.Size(166, 30)
        Me.CuiLabel4.TabIndex = 117
        Me.CuiLabel4.VerticalAlignment = System.Drawing.StringAlignment.Near
        '
        'events
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(166, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Controls.Add(Me.tbc)
        Me.Name = "events"
        Me.Size = New System.Drawing.Size(2318, 1291)
        Me.tbc.ResumeLayout(False)
        Me.pg_browse.ResumeLayout(False)
        CType(Me.events_grid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pg_manage.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents delete_confirmation As CuoreUI.Components.cuiMessageDialog
    Friend WithEvents CuiLabel10 As CuoreUI.Controls.cuiLabel
    Friend WithEvents event_date_input As CuoreUI.Controls.cuiCalendarDatePicker
    Friend WithEvents cancel_btn As CuoreUI.Controls.cuiButton
    Friend WithEvents confirm_btn As CuoreUI.Controls.cuiButton
    Friend WithEvents CuiLabel5 As CuoreUI.Controls.cuiLabel
    Friend WithEvents CuiLabel12 As CuoreUI.Controls.cuiLabel
    Friend WithEvents capacity_input As CuoreUI.Controls.cuiTextBox
    Friend WithEvents mode_lbl As CuoreUI.Controls.cuiLabel
    Friend WithEvents CuiLabel15 As CuoreUI.Controls.cuiLabel
    Friend WithEvents tbc As TabControl
    Friend WithEvents pg_browse As TabPage
    Friend WithEvents MaterialDivider1 As ReaLTaiizor.Controls.MaterialDivider
    Friend WithEvents search_input As CuoreUI.Controls.cuiTextBox
    Friend WithEvents events_grid As MetroFramework.Controls.MetroGrid
    Friend WithEvents pg_manage As TabPage
    Friend WithEvents event_name_input As CuoreUI.Controls.cuiTextBox
    Friend WithEvents status_input As CuoreUI.Controls.cuiComboBox
    Friend WithEvents CuiLabel4 As CuoreUI.Controls.cuiLabel
    Friend WithEvents CuiLabel11 As CuoreUI.Controls.cuiLabel
    Friend WithEvents CuiLabel9 As CuoreUI.Controls.cuiLabel
    Friend WithEvents end_time_input As DateTimePicker
    Friend WithEvents start_time_input As DateTimePicker
    Friend WithEvents attendees_checklist As CheckedListBox
    Friend WithEvents employees_checklist As CheckedListBox
End Class
