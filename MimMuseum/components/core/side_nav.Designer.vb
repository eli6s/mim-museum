<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class side_nav
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(side_nav))
        Me.logo_panel = New CuoreUI.Controls.cuiPanelGradient()
        Me.MaterialDivider1 = New ReaLTaiizor.Controls.MaterialDivider()
        Me.login_museum_logo = New CuoreUI.Controls.cuiPictureBox()
        Me.btn_museum = New CuoreUI.Controls.cuiButton()
        Me.museum_submenu = New CuoreUI.Controls.cuiPanel()
        Me.btn_guests = New CuoreUI.Controls.cuiButton()
        Me.btn_events = New CuoreUI.Controls.cuiButton()
        Me.btn_donations = New CuoreUI.Controls.cuiButton()
        Me.btn_museum_employees = New CuoreUI.Controls.cuiButton()
        Me.btn_museum_maintenance = New CuoreUI.Controls.cuiButton()
        Me.btn_museum_equipment = New CuoreUI.Controls.cuiButton()
        Me.btn_countries = New CuoreUI.Controls.cuiButton()
        Me.btn_sections = New CuoreUI.Controls.cuiButton()
        Me.btn_classifications = New CuoreUI.Controls.cuiButton()
        Me.btn_minerals = New CuoreUI.Controls.cuiButton()
        Me.btn_museum_dashboard = New CuoreUI.Controls.cuiButton()
        Me.MaterialDivider2 = New ReaLTaiizor.Controls.MaterialDivider()
        Me.btn_boutique = New CuoreUI.Controls.cuiButton()
        Me.boutique_submenu = New CuoreUI.Controls.cuiPanel()
        Me.btn_boutique_maintenance = New CuoreUI.Controls.cuiButton()
        Me.btn_boutique_equipment = New CuoreUI.Controls.cuiButton()
        Me.btn_boutique_employees = New CuoreUI.Controls.cuiButton()
        Me.btn_customers = New CuoreUI.Controls.cuiButton()
        Me.btn_transactions = New CuoreUI.Controls.cuiButton()
        Me.btn_inventory = New CuoreUI.Controls.cuiButton()
        Me.btn_POS = New CuoreUI.Controls.cuiButton()
        Me.btn_boutique_dashboard = New CuoreUI.Controls.cuiButton()
        Me.MaterialDivider4 = New ReaLTaiizor.Controls.MaterialDivider()
        Me.core_panel = New CuoreUI.Controls.cuiPanelGradient()
        Me.actions_panel = New CuoreUI.Controls.cuiPanel()
        Me.btn_logout = New CuoreUI.Controls.cuiButton()
        Me.btn_settings = New CuoreUI.Controls.cuiButton()
        Me.btn_reports = New CuoreUI.Controls.cuiButton()
        Me.btn_users = New CuoreUI.Controls.cuiButton()
        Me.btn_positions = New CuoreUI.Controls.cuiButton()
        Me.btn_categories = New CuoreUI.Controls.cuiButton()
        Me.logout_confirmation = New CuoreUI.Components.cuiMessageDialog()
        Me.logo_panel.SuspendLayout()
        Me.museum_submenu.SuspendLayout()
        Me.boutique_submenu.SuspendLayout()
        Me.core_panel.SuspendLayout()
        Me.actions_panel.SuspendLayout()
        Me.SuspendLayout()
        '
        'logo_panel
        '
        Me.logo_panel.Controls.Add(Me.MaterialDivider1)
        Me.logo_panel.Controls.Add(Me.login_museum_logo)
        Me.logo_panel.Dock = System.Windows.Forms.DockStyle.Top
        Me.logo_panel.GradientAngle = 0!
        Me.logo_panel.Location = New System.Drawing.Point(0, 0)
        Me.logo_panel.Name = "logo_panel"
        Me.logo_panel.OutlineThickness = 1.0!
        Me.logo_panel.PanelColor1 = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.logo_panel.PanelColor2 = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.logo_panel.PanelOutlineColor1 = System.Drawing.Color.Transparent
        Me.logo_panel.PanelOutlineColor2 = System.Drawing.Color.Transparent
        Me.logo_panel.Rounding = New System.Windows.Forms.Padding(8)
        Me.logo_panel.Size = New System.Drawing.Size(241, 153)
        Me.logo_panel.TabIndex = 0
        '
        'MaterialDivider1
        '
        Me.MaterialDivider1.BackColor = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.MaterialDivider1.Depth = 0
        Me.MaterialDivider1.Location = New System.Drawing.Point(1, 147)
        Me.MaterialDivider1.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER
        Me.MaterialDivider1.Name = "MaterialDivider1"
        Me.MaterialDivider1.Size = New System.Drawing.Size(240, 2)
        Me.MaterialDivider1.TabIndex = 8
        Me.MaterialDivider1.Text = "MaterialDivider1"
        '
        'login_museum_logo
        '
        Me.login_museum_logo.BackColor = System.Drawing.Color.Transparent
        Me.login_museum_logo.BackgroundImage = CType(resources.GetObject("login_museum_logo.BackgroundImage"), System.Drawing.Image)
        Me.login_museum_logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.login_museum_logo.Content = Nothing
        Me.login_museum_logo.ImageTint = System.Drawing.Color.White
        Me.login_museum_logo.Location = New System.Drawing.Point(65, 22)
        Me.login_museum_logo.Name = "login_museum_logo"
        Me.login_museum_logo.OutlineThickness = 1.0!
        Me.login_museum_logo.PanelOutlineColor = System.Drawing.Color.Empty
        Me.login_museum_logo.Rotation = 0
        Me.login_museum_logo.Rounding = New System.Windows.Forms.Padding(8)
        Me.login_museum_logo.Size = New System.Drawing.Size(101, 94)
        Me.login_museum_logo.TabIndex = 6
        '
        'btn_museum
        '
        Me.btn_museum.CheckButton = False
        Me.btn_museum.Checked = False
        Me.btn_museum.CheckedBackground = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_museum.CheckedForeColor = System.Drawing.Color.White
        Me.btn_museum.CheckedImageTint = System.Drawing.Color.White
        Me.btn_museum.CheckedOutline = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_museum.Content = "Museum"
        Me.btn_museum.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_museum.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btn_museum.Dock = System.Windows.Forms.DockStyle.Top
        Me.btn_museum.Font = New System.Drawing.Font("Helvetica", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_museum.ForeColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.btn_museum.HoverBackground = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.btn_museum.HoverForeColor = System.Drawing.Color.White
        Me.btn_museum.HoverImageTint = System.Drawing.Color.White
        Me.btn_museum.HoverOutline = System.Drawing.Color.Transparent
        Me.btn_museum.Image = CType(resources.GetObject("btn_museum.Image"), System.Drawing.Image)
        Me.btn_museum.ImageExpand = New System.Drawing.Point(3, 3)
        Me.btn_museum.Location = New System.Drawing.Point(0, 153)
        Me.btn_museum.Name = "btn_museum"
        Me.btn_museum.NormalBackground = System.Drawing.Color.Transparent
        Me.btn_museum.NormalForeColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.btn_museum.NormalImageTint = System.Drawing.Color.White
        Me.btn_museum.NormalOutline = System.Drawing.Color.Transparent
        Me.btn_museum.OutlineThickness = 1.0!
        Me.btn_museum.Padding = New System.Windows.Forms.Padding(35)
        Me.btn_museum.PressedBackground = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.btn_museum.PressedForeColor = System.Drawing.Color.White
        Me.btn_museum.PressedImageTint = System.Drawing.Color.White
        Me.btn_museum.PressedOutline = System.Drawing.Color.Transparent
        Me.btn_museum.Rounding = New System.Windows.Forms.Padding(8)
        Me.btn_museum.Size = New System.Drawing.Size(241, 58)
        Me.btn_museum.TabIndex = 14
        Me.btn_museum.Tag = ""
        Me.btn_museum.TextAlignment = System.Drawing.StringAlignment.Near
        Me.btn_museum.TextPadding = 35
        Me.btn_museum.TextSpacing = 2
        '
        'museum_submenu
        '
        Me.museum_submenu.Controls.Add(Me.btn_guests)
        Me.museum_submenu.Controls.Add(Me.btn_events)
        Me.museum_submenu.Controls.Add(Me.btn_donations)
        Me.museum_submenu.Controls.Add(Me.btn_museum_employees)
        Me.museum_submenu.Controls.Add(Me.btn_museum_maintenance)
        Me.museum_submenu.Controls.Add(Me.btn_museum_equipment)
        Me.museum_submenu.Controls.Add(Me.btn_countries)
        Me.museum_submenu.Controls.Add(Me.btn_sections)
        Me.museum_submenu.Controls.Add(Me.btn_classifications)
        Me.museum_submenu.Controls.Add(Me.btn_minerals)
        Me.museum_submenu.Controls.Add(Me.btn_museum_dashboard)
        Me.museum_submenu.Controls.Add(Me.MaterialDivider2)
        Me.museum_submenu.Dock = System.Windows.Forms.DockStyle.Top
        Me.museum_submenu.Location = New System.Drawing.Point(0, 211)
        Me.museum_submenu.Name = "museum_submenu"
        Me.museum_submenu.OutlineThickness = 1.0!
        Me.museum_submenu.PanelColor = System.Drawing.Color.Transparent
        Me.museum_submenu.PanelOutlineColor = System.Drawing.Color.Transparent
        Me.museum_submenu.Rounding = New System.Windows.Forms.Padding(8)
        Me.museum_submenu.Size = New System.Drawing.Size(241, 442)
        Me.museum_submenu.TabIndex = 15
        Me.museum_submenu.Tag = "Museum"
        '
        'btn_guests
        '
        Me.btn_guests.CheckButton = False
        Me.btn_guests.Checked = False
        Me.btn_guests.CheckedBackground = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_guests.CheckedForeColor = System.Drawing.Color.White
        Me.btn_guests.CheckedImageTint = System.Drawing.Color.White
        Me.btn_guests.CheckedOutline = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_guests.Content = "Guests"
        Me.btn_guests.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_guests.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btn_guests.Dock = System.Windows.Forms.DockStyle.Top
        Me.btn_guests.Font = New System.Drawing.Font("Helvetica", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_guests.ForeColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.btn_guests.HoverBackground = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.btn_guests.HoverForeColor = System.Drawing.Color.White
        Me.btn_guests.HoverImageTint = System.Drawing.Color.White
        Me.btn_guests.HoverOutline = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btn_guests.Image = CType(resources.GetObject("btn_guests.Image"), System.Drawing.Image)
        Me.btn_guests.ImageExpand = New System.Drawing.Point(3, 3)
        Me.btn_guests.ImeMode = System.Windows.Forms.ImeMode.Close
        Me.btn_guests.Location = New System.Drawing.Point(0, 390)
        Me.btn_guests.Name = "btn_guests"
        Me.btn_guests.NormalBackground = System.Drawing.Color.Transparent
        Me.btn_guests.NormalForeColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.btn_guests.NormalImageTint = System.Drawing.Color.White
        Me.btn_guests.NormalOutline = System.Drawing.Color.Transparent
        Me.btn_guests.OutlineThickness = 1.0!
        Me.btn_guests.Padding = New System.Windows.Forms.Padding(50)
        Me.btn_guests.PressedBackground = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.btn_guests.PressedForeColor = System.Drawing.Color.White
        Me.btn_guests.PressedImageTint = System.Drawing.Color.White
        Me.btn_guests.PressedOutline = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btn_guests.Rounding = New System.Windows.Forms.Padding(8)
        Me.btn_guests.Size = New System.Drawing.Size(241, 39)
        Me.btn_guests.TabIndex = 2
        Me.btn_guests.Tag = ""
        Me.btn_guests.TextAlignment = System.Drawing.StringAlignment.Near
        Me.btn_guests.TextPadding = 50
        Me.btn_guests.TextSpacing = 2
        '
        'btn_events
        '
        Me.btn_events.CheckButton = False
        Me.btn_events.Checked = False
        Me.btn_events.CheckedBackground = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_events.CheckedForeColor = System.Drawing.Color.White
        Me.btn_events.CheckedImageTint = System.Drawing.Color.White
        Me.btn_events.CheckedOutline = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_events.Content = "Events"
        Me.btn_events.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_events.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btn_events.Dock = System.Windows.Forms.DockStyle.Top
        Me.btn_events.Font = New System.Drawing.Font("Helvetica", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_events.ForeColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.btn_events.HoverBackground = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.btn_events.HoverForeColor = System.Drawing.Color.White
        Me.btn_events.HoverImageTint = System.Drawing.Color.White
        Me.btn_events.HoverOutline = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btn_events.Image = CType(resources.GetObject("btn_events.Image"), System.Drawing.Image)
        Me.btn_events.ImageExpand = New System.Drawing.Point(3, 3)
        Me.btn_events.ImeMode = System.Windows.Forms.ImeMode.Close
        Me.btn_events.Location = New System.Drawing.Point(0, 351)
        Me.btn_events.Name = "btn_events"
        Me.btn_events.NormalBackground = System.Drawing.Color.Transparent
        Me.btn_events.NormalForeColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.btn_events.NormalImageTint = System.Drawing.Color.White
        Me.btn_events.NormalOutline = System.Drawing.Color.Transparent
        Me.btn_events.OutlineThickness = 1.0!
        Me.btn_events.Padding = New System.Windows.Forms.Padding(50)
        Me.btn_events.PressedBackground = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.btn_events.PressedForeColor = System.Drawing.Color.White
        Me.btn_events.PressedImageTint = System.Drawing.Color.White
        Me.btn_events.PressedOutline = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btn_events.Rounding = New System.Windows.Forms.Padding(8)
        Me.btn_events.Size = New System.Drawing.Size(241, 39)
        Me.btn_events.TabIndex = 13
        Me.btn_events.Tag = ""
        Me.btn_events.TextAlignment = System.Drawing.StringAlignment.Near
        Me.btn_events.TextPadding = 50
        Me.btn_events.TextSpacing = 2
        '
        'btn_donations
        '
        Me.btn_donations.CheckButton = False
        Me.btn_donations.Checked = False
        Me.btn_donations.CheckedBackground = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_donations.CheckedForeColor = System.Drawing.Color.White
        Me.btn_donations.CheckedImageTint = System.Drawing.Color.White
        Me.btn_donations.CheckedOutline = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_donations.Content = "Donations"
        Me.btn_donations.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_donations.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btn_donations.Dock = System.Windows.Forms.DockStyle.Top
        Me.btn_donations.Font = New System.Drawing.Font("Helvetica", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_donations.ForeColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.btn_donations.HoverBackground = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.btn_donations.HoverForeColor = System.Drawing.Color.White
        Me.btn_donations.HoverImageTint = System.Drawing.Color.White
        Me.btn_donations.HoverOutline = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btn_donations.Image = CType(resources.GetObject("btn_donations.Image"), System.Drawing.Image)
        Me.btn_donations.ImageExpand = New System.Drawing.Point(3, 3)
        Me.btn_donations.ImeMode = System.Windows.Forms.ImeMode.Close
        Me.btn_donations.Location = New System.Drawing.Point(0, 312)
        Me.btn_donations.Name = "btn_donations"
        Me.btn_donations.NormalBackground = System.Drawing.Color.Transparent
        Me.btn_donations.NormalForeColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.btn_donations.NormalImageTint = System.Drawing.Color.White
        Me.btn_donations.NormalOutline = System.Drawing.Color.Transparent
        Me.btn_donations.OutlineThickness = 1.0!
        Me.btn_donations.Padding = New System.Windows.Forms.Padding(50)
        Me.btn_donations.PressedBackground = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.btn_donations.PressedForeColor = System.Drawing.Color.White
        Me.btn_donations.PressedImageTint = System.Drawing.Color.White
        Me.btn_donations.PressedOutline = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btn_donations.Rounding = New System.Windows.Forms.Padding(8)
        Me.btn_donations.Size = New System.Drawing.Size(241, 39)
        Me.btn_donations.TabIndex = 1
        Me.btn_donations.Tag = ""
        Me.btn_donations.TextAlignment = System.Drawing.StringAlignment.Near
        Me.btn_donations.TextPadding = 50
        Me.btn_donations.TextSpacing = 2
        '
        'btn_museum_employees
        '
        Me.btn_museum_employees.CheckButton = False
        Me.btn_museum_employees.Checked = False
        Me.btn_museum_employees.CheckedBackground = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_museum_employees.CheckedForeColor = System.Drawing.Color.White
        Me.btn_museum_employees.CheckedImageTint = System.Drawing.Color.White
        Me.btn_museum_employees.CheckedOutline = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_museum_employees.Content = "Employees"
        Me.btn_museum_employees.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_museum_employees.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btn_museum_employees.Dock = System.Windows.Forms.DockStyle.Top
        Me.btn_museum_employees.Font = New System.Drawing.Font("Helvetica", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_museum_employees.ForeColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.btn_museum_employees.HoverBackground = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.btn_museum_employees.HoverForeColor = System.Drawing.Color.White
        Me.btn_museum_employees.HoverImageTint = System.Drawing.Color.White
        Me.btn_museum_employees.HoverOutline = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btn_museum_employees.Image = CType(resources.GetObject("btn_museum_employees.Image"), System.Drawing.Image)
        Me.btn_museum_employees.ImageExpand = New System.Drawing.Point(3, 3)
        Me.btn_museum_employees.ImeMode = System.Windows.Forms.ImeMode.Close
        Me.btn_museum_employees.Location = New System.Drawing.Point(0, 273)
        Me.btn_museum_employees.Name = "btn_museum_employees"
        Me.btn_museum_employees.NormalBackground = System.Drawing.Color.Transparent
        Me.btn_museum_employees.NormalForeColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.btn_museum_employees.NormalImageTint = System.Drawing.Color.White
        Me.btn_museum_employees.NormalOutline = System.Drawing.Color.Transparent
        Me.btn_museum_employees.OutlineThickness = 1.0!
        Me.btn_museum_employees.Padding = New System.Windows.Forms.Padding(50)
        Me.btn_museum_employees.PressedBackground = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.btn_museum_employees.PressedForeColor = System.Drawing.Color.White
        Me.btn_museum_employees.PressedImageTint = System.Drawing.Color.White
        Me.btn_museum_employees.PressedOutline = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btn_museum_employees.Rounding = New System.Windows.Forms.Padding(8)
        Me.btn_museum_employees.Size = New System.Drawing.Size(241, 39)
        Me.btn_museum_employees.TabIndex = 1
        Me.btn_museum_employees.Tag = ""
        Me.btn_museum_employees.TextAlignment = System.Drawing.StringAlignment.Near
        Me.btn_museum_employees.TextPadding = 50
        Me.btn_museum_employees.TextSpacing = 2
        '
        'btn_museum_maintenance
        '
        Me.btn_museum_maintenance.CheckButton = False
        Me.btn_museum_maintenance.Checked = False
        Me.btn_museum_maintenance.CheckedBackground = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_museum_maintenance.CheckedForeColor = System.Drawing.Color.White
        Me.btn_museum_maintenance.CheckedImageTint = System.Drawing.Color.White
        Me.btn_museum_maintenance.CheckedOutline = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_museum_maintenance.Content = "Maintenance"
        Me.btn_museum_maintenance.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_museum_maintenance.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btn_museum_maintenance.Dock = System.Windows.Forms.DockStyle.Top
        Me.btn_museum_maintenance.Font = New System.Drawing.Font("Helvetica", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_museum_maintenance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.btn_museum_maintenance.HoverBackground = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.btn_museum_maintenance.HoverForeColor = System.Drawing.Color.White
        Me.btn_museum_maintenance.HoverImageTint = System.Drawing.Color.White
        Me.btn_museum_maintenance.HoverOutline = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btn_museum_maintenance.Image = CType(resources.GetObject("btn_museum_maintenance.Image"), System.Drawing.Image)
        Me.btn_museum_maintenance.ImageExpand = New System.Drawing.Point(3, 3)
        Me.btn_museum_maintenance.ImeMode = System.Windows.Forms.ImeMode.Close
        Me.btn_museum_maintenance.Location = New System.Drawing.Point(0, 234)
        Me.btn_museum_maintenance.Name = "btn_museum_maintenance"
        Me.btn_museum_maintenance.NormalBackground = System.Drawing.Color.Transparent
        Me.btn_museum_maintenance.NormalForeColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.btn_museum_maintenance.NormalImageTint = System.Drawing.Color.White
        Me.btn_museum_maintenance.NormalOutline = System.Drawing.Color.Transparent
        Me.btn_museum_maintenance.OutlineThickness = 1.0!
        Me.btn_museum_maintenance.Padding = New System.Windows.Forms.Padding(50)
        Me.btn_museum_maintenance.PressedBackground = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.btn_museum_maintenance.PressedForeColor = System.Drawing.Color.White
        Me.btn_museum_maintenance.PressedImageTint = System.Drawing.Color.White
        Me.btn_museum_maintenance.PressedOutline = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btn_museum_maintenance.Rounding = New System.Windows.Forms.Padding(8)
        Me.btn_museum_maintenance.Size = New System.Drawing.Size(241, 39)
        Me.btn_museum_maintenance.TabIndex = 0
        Me.btn_museum_maintenance.Tag = ""
        Me.btn_museum_maintenance.TextAlignment = System.Drawing.StringAlignment.Near
        Me.btn_museum_maintenance.TextPadding = 50
        Me.btn_museum_maintenance.TextSpacing = 2
        '
        'btn_museum_equipment
        '
        Me.btn_museum_equipment.CheckButton = False
        Me.btn_museum_equipment.Checked = False
        Me.btn_museum_equipment.CheckedBackground = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_museum_equipment.CheckedForeColor = System.Drawing.Color.White
        Me.btn_museum_equipment.CheckedImageTint = System.Drawing.Color.White
        Me.btn_museum_equipment.CheckedOutline = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_museum_equipment.Content = "Equipment"
        Me.btn_museum_equipment.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_museum_equipment.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btn_museum_equipment.Dock = System.Windows.Forms.DockStyle.Top
        Me.btn_museum_equipment.Font = New System.Drawing.Font("Helvetica", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_museum_equipment.ForeColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.btn_museum_equipment.HoverBackground = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.btn_museum_equipment.HoverForeColor = System.Drawing.Color.White
        Me.btn_museum_equipment.HoverImageTint = System.Drawing.Color.White
        Me.btn_museum_equipment.HoverOutline = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btn_museum_equipment.Image = CType(resources.GetObject("btn_museum_equipment.Image"), System.Drawing.Image)
        Me.btn_museum_equipment.ImageExpand = New System.Drawing.Point(3, 3)
        Me.btn_museum_equipment.ImeMode = System.Windows.Forms.ImeMode.Close
        Me.btn_museum_equipment.Location = New System.Drawing.Point(0, 195)
        Me.btn_museum_equipment.Name = "btn_museum_equipment"
        Me.btn_museum_equipment.NormalBackground = System.Drawing.Color.Transparent
        Me.btn_museum_equipment.NormalForeColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.btn_museum_equipment.NormalImageTint = System.Drawing.Color.White
        Me.btn_museum_equipment.NormalOutline = System.Drawing.Color.Transparent
        Me.btn_museum_equipment.OutlineThickness = 1.0!
        Me.btn_museum_equipment.Padding = New System.Windows.Forms.Padding(50)
        Me.btn_museum_equipment.PressedBackground = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.btn_museum_equipment.PressedForeColor = System.Drawing.Color.White
        Me.btn_museum_equipment.PressedImageTint = System.Drawing.Color.White
        Me.btn_museum_equipment.PressedOutline = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btn_museum_equipment.Rounding = New System.Windows.Forms.Padding(8)
        Me.btn_museum_equipment.Size = New System.Drawing.Size(241, 39)
        Me.btn_museum_equipment.TabIndex = 9
        Me.btn_museum_equipment.Tag = ""
        Me.btn_museum_equipment.TextAlignment = System.Drawing.StringAlignment.Near
        Me.btn_museum_equipment.TextPadding = 50
        Me.btn_museum_equipment.TextSpacing = 2
        '
        'btn_countries
        '
        Me.btn_countries.CheckButton = False
        Me.btn_countries.Checked = False
        Me.btn_countries.CheckedBackground = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_countries.CheckedForeColor = System.Drawing.Color.White
        Me.btn_countries.CheckedImageTint = System.Drawing.Color.White
        Me.btn_countries.CheckedOutline = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_countries.Content = "Countries"
        Me.btn_countries.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_countries.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btn_countries.Dock = System.Windows.Forms.DockStyle.Top
        Me.btn_countries.Font = New System.Drawing.Font("Helvetica", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_countries.ForeColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.btn_countries.HoverBackground = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.btn_countries.HoverForeColor = System.Drawing.Color.White
        Me.btn_countries.HoverImageTint = System.Drawing.Color.White
        Me.btn_countries.HoverOutline = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btn_countries.Image = CType(resources.GetObject("btn_countries.Image"), System.Drawing.Image)
        Me.btn_countries.ImageExpand = New System.Drawing.Point(3, 3)
        Me.btn_countries.ImeMode = System.Windows.Forms.ImeMode.Close
        Me.btn_countries.Location = New System.Drawing.Point(0, 156)
        Me.btn_countries.Name = "btn_countries"
        Me.btn_countries.NormalBackground = System.Drawing.Color.Transparent
        Me.btn_countries.NormalForeColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.btn_countries.NormalImageTint = System.Drawing.Color.White
        Me.btn_countries.NormalOutline = System.Drawing.Color.Transparent
        Me.btn_countries.OutlineThickness = 1.0!
        Me.btn_countries.Padding = New System.Windows.Forms.Padding(50)
        Me.btn_countries.PressedBackground = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.btn_countries.PressedForeColor = System.Drawing.Color.White
        Me.btn_countries.PressedImageTint = System.Drawing.Color.White
        Me.btn_countries.PressedOutline = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btn_countries.Rounding = New System.Windows.Forms.Padding(8)
        Me.btn_countries.Size = New System.Drawing.Size(241, 39)
        Me.btn_countries.TabIndex = 5
        Me.btn_countries.Tag = ""
        Me.btn_countries.TextAlignment = System.Drawing.StringAlignment.Near
        Me.btn_countries.TextPadding = 50
        Me.btn_countries.TextSpacing = 2
        '
        'btn_sections
        '
        Me.btn_sections.CheckButton = False
        Me.btn_sections.Checked = False
        Me.btn_sections.CheckedBackground = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_sections.CheckedForeColor = System.Drawing.Color.White
        Me.btn_sections.CheckedImageTint = System.Drawing.Color.White
        Me.btn_sections.CheckedOutline = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_sections.Content = "Sections"
        Me.btn_sections.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_sections.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btn_sections.Dock = System.Windows.Forms.DockStyle.Top
        Me.btn_sections.Font = New System.Drawing.Font("Helvetica", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_sections.ForeColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.btn_sections.HoverBackground = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.btn_sections.HoverForeColor = System.Drawing.Color.White
        Me.btn_sections.HoverImageTint = System.Drawing.Color.White
        Me.btn_sections.HoverOutline = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btn_sections.Image = CType(resources.GetObject("btn_sections.Image"), System.Drawing.Image)
        Me.btn_sections.ImageExpand = New System.Drawing.Point(3, 3)
        Me.btn_sections.ImeMode = System.Windows.Forms.ImeMode.Close
        Me.btn_sections.Location = New System.Drawing.Point(0, 117)
        Me.btn_sections.Name = "btn_sections"
        Me.btn_sections.NormalBackground = System.Drawing.Color.Transparent
        Me.btn_sections.NormalForeColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.btn_sections.NormalImageTint = System.Drawing.Color.White
        Me.btn_sections.NormalOutline = System.Drawing.Color.Transparent
        Me.btn_sections.OutlineThickness = 1.0!
        Me.btn_sections.Padding = New System.Windows.Forms.Padding(50)
        Me.btn_sections.PressedBackground = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.btn_sections.PressedForeColor = System.Drawing.Color.White
        Me.btn_sections.PressedImageTint = System.Drawing.Color.White
        Me.btn_sections.PressedOutline = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btn_sections.Rounding = New System.Windows.Forms.Padding(8)
        Me.btn_sections.Size = New System.Drawing.Size(241, 39)
        Me.btn_sections.TabIndex = 6
        Me.btn_sections.Tag = ""
        Me.btn_sections.TextAlignment = System.Drawing.StringAlignment.Near
        Me.btn_sections.TextPadding = 50
        Me.btn_sections.TextSpacing = 2
        '
        'btn_classifications
        '
        Me.btn_classifications.CheckButton = False
        Me.btn_classifications.Checked = False
        Me.btn_classifications.CheckedBackground = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_classifications.CheckedForeColor = System.Drawing.Color.White
        Me.btn_classifications.CheckedImageTint = System.Drawing.Color.White
        Me.btn_classifications.CheckedOutline = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_classifications.Content = "Classifications"
        Me.btn_classifications.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_classifications.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btn_classifications.Dock = System.Windows.Forms.DockStyle.Top
        Me.btn_classifications.Font = New System.Drawing.Font("Helvetica", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_classifications.ForeColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.btn_classifications.HoverBackground = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.btn_classifications.HoverForeColor = System.Drawing.Color.White
        Me.btn_classifications.HoverImageTint = System.Drawing.Color.White
        Me.btn_classifications.HoverOutline = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btn_classifications.Image = CType(resources.GetObject("btn_classifications.Image"), System.Drawing.Image)
        Me.btn_classifications.ImageExpand = New System.Drawing.Point(3, 3)
        Me.btn_classifications.ImeMode = System.Windows.Forms.ImeMode.Close
        Me.btn_classifications.Location = New System.Drawing.Point(0, 78)
        Me.btn_classifications.Name = "btn_classifications"
        Me.btn_classifications.NormalBackground = System.Drawing.Color.Transparent
        Me.btn_classifications.NormalForeColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.btn_classifications.NormalImageTint = System.Drawing.Color.White
        Me.btn_classifications.NormalOutline = System.Drawing.Color.Transparent
        Me.btn_classifications.OutlineThickness = 1.0!
        Me.btn_classifications.Padding = New System.Windows.Forms.Padding(50)
        Me.btn_classifications.PressedBackground = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.btn_classifications.PressedForeColor = System.Drawing.Color.White
        Me.btn_classifications.PressedImageTint = System.Drawing.Color.White
        Me.btn_classifications.PressedOutline = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btn_classifications.Rounding = New System.Windows.Forms.Padding(8)
        Me.btn_classifications.Size = New System.Drawing.Size(241, 39)
        Me.btn_classifications.TabIndex = 7
        Me.btn_classifications.Tag = ""
        Me.btn_classifications.TextAlignment = System.Drawing.StringAlignment.Near
        Me.btn_classifications.TextPadding = 50
        Me.btn_classifications.TextSpacing = 2
        '
        'btn_minerals
        '
        Me.btn_minerals.CheckButton = False
        Me.btn_minerals.Checked = False
        Me.btn_minerals.CheckedBackground = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.btn_minerals.CheckedForeColor = System.Drawing.Color.White
        Me.btn_minerals.CheckedImageTint = System.Drawing.Color.White
        Me.btn_minerals.CheckedOutline = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btn_minerals.Content = "Minerals"
        Me.btn_minerals.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_minerals.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btn_minerals.Dock = System.Windows.Forms.DockStyle.Top
        Me.btn_minerals.Font = New System.Drawing.Font("Helvetica", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_minerals.ForeColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.btn_minerals.HoverBackground = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.btn_minerals.HoverForeColor = System.Drawing.Color.White
        Me.btn_minerals.HoverImageTint = System.Drawing.Color.White
        Me.btn_minerals.HoverOutline = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btn_minerals.Image = CType(resources.GetObject("btn_minerals.Image"), System.Drawing.Image)
        Me.btn_minerals.ImageExpand = New System.Drawing.Point(3, 3)
        Me.btn_minerals.ImeMode = System.Windows.Forms.ImeMode.Close
        Me.btn_minerals.Location = New System.Drawing.Point(0, 39)
        Me.btn_minerals.Name = "btn_minerals"
        Me.btn_minerals.NormalBackground = System.Drawing.Color.Transparent
        Me.btn_minerals.NormalForeColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.btn_minerals.NormalImageTint = System.Drawing.Color.White
        Me.btn_minerals.NormalOutline = System.Drawing.Color.Transparent
        Me.btn_minerals.OutlineThickness = 1.0!
        Me.btn_minerals.Padding = New System.Windows.Forms.Padding(50)
        Me.btn_minerals.PressedBackground = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.btn_minerals.PressedForeColor = System.Drawing.Color.White
        Me.btn_minerals.PressedImageTint = System.Drawing.Color.White
        Me.btn_minerals.PressedOutline = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btn_minerals.Rounding = New System.Windows.Forms.Padding(8)
        Me.btn_minerals.Size = New System.Drawing.Size(241, 39)
        Me.btn_minerals.TabIndex = 3
        Me.btn_minerals.Tag = ""
        Me.btn_minerals.TextAlignment = System.Drawing.StringAlignment.Near
        Me.btn_minerals.TextPadding = 50
        Me.btn_minerals.TextSpacing = 2
        '
        'btn_museum_dashboard
        '
        Me.btn_museum_dashboard.CheckButton = False
        Me.btn_museum_dashboard.Checked = False
        Me.btn_museum_dashboard.CheckedBackground = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_museum_dashboard.CheckedForeColor = System.Drawing.Color.White
        Me.btn_museum_dashboard.CheckedImageTint = System.Drawing.Color.White
        Me.btn_museum_dashboard.CheckedOutline = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_museum_dashboard.Content = "Dashboard"
        Me.btn_museum_dashboard.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_museum_dashboard.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btn_museum_dashboard.Dock = System.Windows.Forms.DockStyle.Top
        Me.btn_museum_dashboard.Font = New System.Drawing.Font("Helvetica", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_museum_dashboard.ForeColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.btn_museum_dashboard.HoverBackground = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.btn_museum_dashboard.HoverForeColor = System.Drawing.Color.White
        Me.btn_museum_dashboard.HoverImageTint = System.Drawing.Color.White
        Me.btn_museum_dashboard.HoverOutline = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btn_museum_dashboard.Image = CType(resources.GetObject("btn_museum_dashboard.Image"), System.Drawing.Image)
        Me.btn_museum_dashboard.ImageExpand = New System.Drawing.Point(3, 3)
        Me.btn_museum_dashboard.ImeMode = System.Windows.Forms.ImeMode.Close
        Me.btn_museum_dashboard.Location = New System.Drawing.Point(0, 0)
        Me.btn_museum_dashboard.Name = "btn_museum_dashboard"
        Me.btn_museum_dashboard.NormalBackground = System.Drawing.Color.Transparent
        Me.btn_museum_dashboard.NormalForeColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.btn_museum_dashboard.NormalImageTint = System.Drawing.Color.White
        Me.btn_museum_dashboard.NormalOutline = System.Drawing.Color.Transparent
        Me.btn_museum_dashboard.OutlineThickness = 1.0!
        Me.btn_museum_dashboard.Padding = New System.Windows.Forms.Padding(50)
        Me.btn_museum_dashboard.PressedBackground = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.btn_museum_dashboard.PressedForeColor = System.Drawing.Color.White
        Me.btn_museum_dashboard.PressedImageTint = System.Drawing.Color.White
        Me.btn_museum_dashboard.PressedOutline = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btn_museum_dashboard.Rounding = New System.Windows.Forms.Padding(8)
        Me.btn_museum_dashboard.Size = New System.Drawing.Size(241, 39)
        Me.btn_museum_dashboard.TabIndex = 4
        Me.btn_museum_dashboard.Tag = ""
        Me.btn_museum_dashboard.TextAlignment = System.Drawing.StringAlignment.Near
        Me.btn_museum_dashboard.TextPadding = 50
        Me.btn_museum_dashboard.TextSpacing = 2
        '
        'MaterialDivider2
        '
        Me.MaterialDivider2.BackColor = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.MaterialDivider2.Depth = 0
        Me.MaterialDivider2.Location = New System.Drawing.Point(4, 440)
        Me.MaterialDivider2.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER
        Me.MaterialDivider2.Name = "MaterialDivider2"
        Me.MaterialDivider2.Size = New System.Drawing.Size(240, 2)
        Me.MaterialDivider2.TabIndex = 12
        Me.MaterialDivider2.Text = "MaterialDivider2"
        '
        'btn_boutique
        '
        Me.btn_boutique.CheckButton = False
        Me.btn_boutique.Checked = False
        Me.btn_boutique.CheckedBackground = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_boutique.CheckedForeColor = System.Drawing.Color.White
        Me.btn_boutique.CheckedImageTint = System.Drawing.Color.White
        Me.btn_boutique.CheckedOutline = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_boutique.Content = "Boutique"
        Me.btn_boutique.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_boutique.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btn_boutique.Dock = System.Windows.Forms.DockStyle.Top
        Me.btn_boutique.Font = New System.Drawing.Font("Helvetica", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_boutique.ForeColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.btn_boutique.HoverBackground = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.btn_boutique.HoverForeColor = System.Drawing.Color.White
        Me.btn_boutique.HoverImageTint = System.Drawing.Color.White
        Me.btn_boutique.HoverOutline = System.Drawing.Color.Transparent
        Me.btn_boutique.Image = CType(resources.GetObject("btn_boutique.Image"), System.Drawing.Image)
        Me.btn_boutique.ImageExpand = New System.Drawing.Point(3, 3)
        Me.btn_boutique.Location = New System.Drawing.Point(0, 653)
        Me.btn_boutique.Name = "btn_boutique"
        Me.btn_boutique.NormalBackground = System.Drawing.Color.Transparent
        Me.btn_boutique.NormalForeColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.btn_boutique.NormalImageTint = System.Drawing.Color.White
        Me.btn_boutique.NormalOutline = System.Drawing.Color.Transparent
        Me.btn_boutique.OutlineThickness = 1.0!
        Me.btn_boutique.Padding = New System.Windows.Forms.Padding(35)
        Me.btn_boutique.PressedBackground = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.btn_boutique.PressedForeColor = System.Drawing.Color.White
        Me.btn_boutique.PressedImageTint = System.Drawing.Color.White
        Me.btn_boutique.PressedOutline = System.Drawing.Color.Transparent
        Me.btn_boutique.Rounding = New System.Windows.Forms.Padding(8)
        Me.btn_boutique.Size = New System.Drawing.Size(241, 58)
        Me.btn_boutique.TabIndex = 17
        Me.btn_boutique.Tag = ""
        Me.btn_boutique.TextAlignment = System.Drawing.StringAlignment.Near
        Me.btn_boutique.TextPadding = 35
        Me.btn_boutique.TextSpacing = 2
        '
        'boutique_submenu
        '
        Me.boutique_submenu.Controls.Add(Me.btn_boutique_maintenance)
        Me.boutique_submenu.Controls.Add(Me.btn_boutique_equipment)
        Me.boutique_submenu.Controls.Add(Me.btn_boutique_employees)
        Me.boutique_submenu.Controls.Add(Me.btn_customers)
        Me.boutique_submenu.Controls.Add(Me.btn_transactions)
        Me.boutique_submenu.Controls.Add(Me.btn_inventory)
        Me.boutique_submenu.Controls.Add(Me.btn_POS)
        Me.boutique_submenu.Controls.Add(Me.btn_boutique_dashboard)
        Me.boutique_submenu.Controls.Add(Me.MaterialDivider4)
        Me.boutique_submenu.Dock = System.Windows.Forms.DockStyle.Top
        Me.boutique_submenu.Location = New System.Drawing.Point(0, 711)
        Me.boutique_submenu.Name = "boutique_submenu"
        Me.boutique_submenu.OutlineThickness = 1.0!
        Me.boutique_submenu.PanelColor = System.Drawing.Color.Transparent
        Me.boutique_submenu.PanelOutlineColor = System.Drawing.Color.Transparent
        Me.boutique_submenu.Rounding = New System.Windows.Forms.Padding(8)
        Me.boutique_submenu.Size = New System.Drawing.Size(241, 325)
        Me.boutique_submenu.TabIndex = 18
        Me.boutique_submenu.Tag = "Boutique"
        '
        'btn_boutique_maintenance
        '
        Me.btn_boutique_maintenance.CheckButton = False
        Me.btn_boutique_maintenance.Checked = False
        Me.btn_boutique_maintenance.CheckedBackground = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_boutique_maintenance.CheckedForeColor = System.Drawing.Color.White
        Me.btn_boutique_maintenance.CheckedImageTint = System.Drawing.Color.White
        Me.btn_boutique_maintenance.CheckedOutline = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_boutique_maintenance.Content = "Maintenance"
        Me.btn_boutique_maintenance.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_boutique_maintenance.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btn_boutique_maintenance.Dock = System.Windows.Forms.DockStyle.Top
        Me.btn_boutique_maintenance.Font = New System.Drawing.Font("Helvetica", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_boutique_maintenance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.btn_boutique_maintenance.HoverBackground = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.btn_boutique_maintenance.HoverForeColor = System.Drawing.Color.White
        Me.btn_boutique_maintenance.HoverImageTint = System.Drawing.Color.White
        Me.btn_boutique_maintenance.HoverOutline = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btn_boutique_maintenance.Image = CType(resources.GetObject("btn_boutique_maintenance.Image"), System.Drawing.Image)
        Me.btn_boutique_maintenance.ImageExpand = New System.Drawing.Point(3, 3)
        Me.btn_boutique_maintenance.Location = New System.Drawing.Point(0, 273)
        Me.btn_boutique_maintenance.Name = "btn_boutique_maintenance"
        Me.btn_boutique_maintenance.NormalBackground = System.Drawing.Color.Transparent
        Me.btn_boutique_maintenance.NormalForeColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.btn_boutique_maintenance.NormalImageTint = System.Drawing.Color.White
        Me.btn_boutique_maintenance.NormalOutline = System.Drawing.Color.Transparent
        Me.btn_boutique_maintenance.OutlineThickness = 1.0!
        Me.btn_boutique_maintenance.Padding = New System.Windows.Forms.Padding(50)
        Me.btn_boutique_maintenance.PressedBackground = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.btn_boutique_maintenance.PressedForeColor = System.Drawing.Color.White
        Me.btn_boutique_maintenance.PressedImageTint = System.Drawing.Color.White
        Me.btn_boutique_maintenance.PressedOutline = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btn_boutique_maintenance.Rounding = New System.Windows.Forms.Padding(8)
        Me.btn_boutique_maintenance.Size = New System.Drawing.Size(241, 39)
        Me.btn_boutique_maintenance.TabIndex = 4
        Me.btn_boutique_maintenance.Tag = ""
        Me.btn_boutique_maintenance.TextAlignment = System.Drawing.StringAlignment.Near
        Me.btn_boutique_maintenance.TextPadding = 50
        Me.btn_boutique_maintenance.TextSpacing = 2
        '
        'btn_boutique_equipment
        '
        Me.btn_boutique_equipment.CheckButton = False
        Me.btn_boutique_equipment.Checked = False
        Me.btn_boutique_equipment.CheckedBackground = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_boutique_equipment.CheckedForeColor = System.Drawing.Color.White
        Me.btn_boutique_equipment.CheckedImageTint = System.Drawing.Color.White
        Me.btn_boutique_equipment.CheckedOutline = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_boutique_equipment.Content = "Equipment"
        Me.btn_boutique_equipment.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_boutique_equipment.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btn_boutique_equipment.Dock = System.Windows.Forms.DockStyle.Top
        Me.btn_boutique_equipment.Font = New System.Drawing.Font("Helvetica", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_boutique_equipment.ForeColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.btn_boutique_equipment.HoverBackground = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.btn_boutique_equipment.HoverForeColor = System.Drawing.Color.White
        Me.btn_boutique_equipment.HoverImageTint = System.Drawing.Color.White
        Me.btn_boutique_equipment.HoverOutline = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btn_boutique_equipment.Image = CType(resources.GetObject("btn_boutique_equipment.Image"), System.Drawing.Image)
        Me.btn_boutique_equipment.ImageExpand = New System.Drawing.Point(3, 3)
        Me.btn_boutique_equipment.Location = New System.Drawing.Point(0, 234)
        Me.btn_boutique_equipment.Name = "btn_boutique_equipment"
        Me.btn_boutique_equipment.NormalBackground = System.Drawing.Color.Transparent
        Me.btn_boutique_equipment.NormalForeColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.btn_boutique_equipment.NormalImageTint = System.Drawing.Color.White
        Me.btn_boutique_equipment.NormalOutline = System.Drawing.Color.Transparent
        Me.btn_boutique_equipment.OutlineThickness = 1.0!
        Me.btn_boutique_equipment.Padding = New System.Windows.Forms.Padding(50)
        Me.btn_boutique_equipment.PressedBackground = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.btn_boutique_equipment.PressedForeColor = System.Drawing.Color.White
        Me.btn_boutique_equipment.PressedImageTint = System.Drawing.Color.White
        Me.btn_boutique_equipment.PressedOutline = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btn_boutique_equipment.Rounding = New System.Windows.Forms.Padding(8)
        Me.btn_boutique_equipment.Size = New System.Drawing.Size(241, 39)
        Me.btn_boutique_equipment.TabIndex = 3
        Me.btn_boutique_equipment.Tag = ""
        Me.btn_boutique_equipment.TextAlignment = System.Drawing.StringAlignment.Near
        Me.btn_boutique_equipment.TextPadding = 50
        Me.btn_boutique_equipment.TextSpacing = 2
        '
        'btn_boutique_employees
        '
        Me.btn_boutique_employees.CheckButton = False
        Me.btn_boutique_employees.Checked = False
        Me.btn_boutique_employees.CheckedBackground = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_boutique_employees.CheckedForeColor = System.Drawing.Color.White
        Me.btn_boutique_employees.CheckedImageTint = System.Drawing.Color.White
        Me.btn_boutique_employees.CheckedOutline = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_boutique_employees.Content = "Employees"
        Me.btn_boutique_employees.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_boutique_employees.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btn_boutique_employees.Dock = System.Windows.Forms.DockStyle.Top
        Me.btn_boutique_employees.Font = New System.Drawing.Font("Helvetica", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_boutique_employees.ForeColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.btn_boutique_employees.HoverBackground = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.btn_boutique_employees.HoverForeColor = System.Drawing.Color.White
        Me.btn_boutique_employees.HoverImageTint = System.Drawing.Color.White
        Me.btn_boutique_employees.HoverOutline = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btn_boutique_employees.Image = CType(resources.GetObject("btn_boutique_employees.Image"), System.Drawing.Image)
        Me.btn_boutique_employees.ImageExpand = New System.Drawing.Point(3, 3)
        Me.btn_boutique_employees.Location = New System.Drawing.Point(0, 195)
        Me.btn_boutique_employees.Name = "btn_boutique_employees"
        Me.btn_boutique_employees.NormalBackground = System.Drawing.Color.Transparent
        Me.btn_boutique_employees.NormalForeColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.btn_boutique_employees.NormalImageTint = System.Drawing.Color.White
        Me.btn_boutique_employees.NormalOutline = System.Drawing.Color.Transparent
        Me.btn_boutique_employees.OutlineThickness = 1.0!
        Me.btn_boutique_employees.Padding = New System.Windows.Forms.Padding(50)
        Me.btn_boutique_employees.PressedBackground = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.btn_boutique_employees.PressedForeColor = System.Drawing.Color.White
        Me.btn_boutique_employees.PressedImageTint = System.Drawing.Color.White
        Me.btn_boutique_employees.PressedOutline = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btn_boutique_employees.Rounding = New System.Windows.Forms.Padding(8)
        Me.btn_boutique_employees.Size = New System.Drawing.Size(241, 39)
        Me.btn_boutique_employees.TabIndex = 5
        Me.btn_boutique_employees.Tag = ""
        Me.btn_boutique_employees.TextAlignment = System.Drawing.StringAlignment.Near
        Me.btn_boutique_employees.TextPadding = 50
        Me.btn_boutique_employees.TextSpacing = 2
        '
        'btn_customers
        '
        Me.btn_customers.CheckButton = False
        Me.btn_customers.Checked = False
        Me.btn_customers.CheckedBackground = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_customers.CheckedForeColor = System.Drawing.Color.White
        Me.btn_customers.CheckedImageTint = System.Drawing.Color.White
        Me.btn_customers.CheckedOutline = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_customers.Content = "Customers"
        Me.btn_customers.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_customers.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btn_customers.Dock = System.Windows.Forms.DockStyle.Top
        Me.btn_customers.Font = New System.Drawing.Font("Helvetica", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_customers.ForeColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.btn_customers.HoverBackground = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.btn_customers.HoverForeColor = System.Drawing.Color.White
        Me.btn_customers.HoverImageTint = System.Drawing.Color.White
        Me.btn_customers.HoverOutline = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btn_customers.Image = CType(resources.GetObject("btn_customers.Image"), System.Drawing.Image)
        Me.btn_customers.ImageExpand = New System.Drawing.Point(3, 3)
        Me.btn_customers.Location = New System.Drawing.Point(0, 156)
        Me.btn_customers.Name = "btn_customers"
        Me.btn_customers.NormalBackground = System.Drawing.Color.Transparent
        Me.btn_customers.NormalForeColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.btn_customers.NormalImageTint = System.Drawing.Color.White
        Me.btn_customers.NormalOutline = System.Drawing.Color.Transparent
        Me.btn_customers.OutlineThickness = 1.0!
        Me.btn_customers.Padding = New System.Windows.Forms.Padding(50)
        Me.btn_customers.PressedBackground = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.btn_customers.PressedForeColor = System.Drawing.Color.White
        Me.btn_customers.PressedImageTint = System.Drawing.Color.White
        Me.btn_customers.PressedOutline = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btn_customers.Rounding = New System.Windows.Forms.Padding(8)
        Me.btn_customers.Size = New System.Drawing.Size(241, 39)
        Me.btn_customers.TabIndex = 1
        Me.btn_customers.Tag = ""
        Me.btn_customers.TextAlignment = System.Drawing.StringAlignment.Near
        Me.btn_customers.TextPadding = 50
        Me.btn_customers.TextSpacing = 2
        '
        'btn_transactions
        '
        Me.btn_transactions.CheckButton = False
        Me.btn_transactions.Checked = False
        Me.btn_transactions.CheckedBackground = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_transactions.CheckedForeColor = System.Drawing.Color.White
        Me.btn_transactions.CheckedImageTint = System.Drawing.Color.White
        Me.btn_transactions.CheckedOutline = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_transactions.Content = "Transactions"
        Me.btn_transactions.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_transactions.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btn_transactions.Dock = System.Windows.Forms.DockStyle.Top
        Me.btn_transactions.Font = New System.Drawing.Font("Helvetica", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_transactions.ForeColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.btn_transactions.HoverBackground = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.btn_transactions.HoverForeColor = System.Drawing.Color.White
        Me.btn_transactions.HoverImageTint = System.Drawing.Color.White
        Me.btn_transactions.HoverOutline = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btn_transactions.Image = CType(resources.GetObject("btn_transactions.Image"), System.Drawing.Image)
        Me.btn_transactions.ImageExpand = New System.Drawing.Point(3, 3)
        Me.btn_transactions.Location = New System.Drawing.Point(0, 117)
        Me.btn_transactions.Name = "btn_transactions"
        Me.btn_transactions.NormalBackground = System.Drawing.Color.Transparent
        Me.btn_transactions.NormalForeColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.btn_transactions.NormalImageTint = System.Drawing.Color.White
        Me.btn_transactions.NormalOutline = System.Drawing.Color.Transparent
        Me.btn_transactions.OutlineThickness = 1.0!
        Me.btn_transactions.Padding = New System.Windows.Forms.Padding(50)
        Me.btn_transactions.PressedBackground = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.btn_transactions.PressedForeColor = System.Drawing.Color.White
        Me.btn_transactions.PressedImageTint = System.Drawing.Color.White
        Me.btn_transactions.PressedOutline = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btn_transactions.Rounding = New System.Windows.Forms.Padding(8)
        Me.btn_transactions.Size = New System.Drawing.Size(241, 39)
        Me.btn_transactions.TabIndex = 2
        Me.btn_transactions.Tag = ""
        Me.btn_transactions.TextAlignment = System.Drawing.StringAlignment.Near
        Me.btn_transactions.TextPadding = 50
        Me.btn_transactions.TextSpacing = 2
        '
        'btn_inventory
        '
        Me.btn_inventory.CheckButton = False
        Me.btn_inventory.Checked = False
        Me.btn_inventory.CheckedBackground = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_inventory.CheckedForeColor = System.Drawing.Color.White
        Me.btn_inventory.CheckedImageTint = System.Drawing.Color.White
        Me.btn_inventory.CheckedOutline = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_inventory.Content = "Inventory"
        Me.btn_inventory.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_inventory.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btn_inventory.Dock = System.Windows.Forms.DockStyle.Top
        Me.btn_inventory.Font = New System.Drawing.Font("Helvetica", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_inventory.ForeColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.btn_inventory.HoverBackground = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.btn_inventory.HoverForeColor = System.Drawing.Color.White
        Me.btn_inventory.HoverImageTint = System.Drawing.Color.White
        Me.btn_inventory.HoverOutline = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btn_inventory.Image = CType(resources.GetObject("btn_inventory.Image"), System.Drawing.Image)
        Me.btn_inventory.ImageExpand = New System.Drawing.Point(3, 3)
        Me.btn_inventory.Location = New System.Drawing.Point(0, 78)
        Me.btn_inventory.Name = "btn_inventory"
        Me.btn_inventory.NormalBackground = System.Drawing.Color.Transparent
        Me.btn_inventory.NormalForeColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.btn_inventory.NormalImageTint = System.Drawing.Color.White
        Me.btn_inventory.NormalOutline = System.Drawing.Color.Transparent
        Me.btn_inventory.OutlineThickness = 1.0!
        Me.btn_inventory.Padding = New System.Windows.Forms.Padding(50)
        Me.btn_inventory.PressedBackground = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.btn_inventory.PressedForeColor = System.Drawing.Color.White
        Me.btn_inventory.PressedImageTint = System.Drawing.Color.White
        Me.btn_inventory.PressedOutline = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btn_inventory.Rounding = New System.Windows.Forms.Padding(8)
        Me.btn_inventory.Size = New System.Drawing.Size(241, 39)
        Me.btn_inventory.TabIndex = 17
        Me.btn_inventory.Tag = ""
        Me.btn_inventory.TextAlignment = System.Drawing.StringAlignment.Near
        Me.btn_inventory.TextPadding = 50
        Me.btn_inventory.TextSpacing = 2
        '
        'btn_POS
        '
        Me.btn_POS.CheckButton = False
        Me.btn_POS.Checked = False
        Me.btn_POS.CheckedBackground = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_POS.CheckedForeColor = System.Drawing.Color.White
        Me.btn_POS.CheckedImageTint = System.Drawing.Color.White
        Me.btn_POS.CheckedOutline = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_POS.Content = "POS"
        Me.btn_POS.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_POS.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btn_POS.Dock = System.Windows.Forms.DockStyle.Top
        Me.btn_POS.Font = New System.Drawing.Font("Helvetica", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_POS.ForeColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.btn_POS.HoverBackground = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.btn_POS.HoverForeColor = System.Drawing.Color.White
        Me.btn_POS.HoverImageTint = System.Drawing.Color.White
        Me.btn_POS.HoverOutline = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btn_POS.Image = CType(resources.GetObject("btn_POS.Image"), System.Drawing.Image)
        Me.btn_POS.ImageExpand = New System.Drawing.Point(3, 3)
        Me.btn_POS.Location = New System.Drawing.Point(0, 39)
        Me.btn_POS.Name = "btn_POS"
        Me.btn_POS.NormalBackground = System.Drawing.Color.Transparent
        Me.btn_POS.NormalForeColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.btn_POS.NormalImageTint = System.Drawing.Color.White
        Me.btn_POS.NormalOutline = System.Drawing.Color.Transparent
        Me.btn_POS.OutlineThickness = 1.0!
        Me.btn_POS.Padding = New System.Windows.Forms.Padding(50)
        Me.btn_POS.PressedBackground = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.btn_POS.PressedForeColor = System.Drawing.Color.White
        Me.btn_POS.PressedImageTint = System.Drawing.Color.White
        Me.btn_POS.PressedOutline = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btn_POS.Rounding = New System.Windows.Forms.Padding(8)
        Me.btn_POS.Size = New System.Drawing.Size(241, 39)
        Me.btn_POS.TabIndex = 14
        Me.btn_POS.Tag = ""
        Me.btn_POS.TextAlignment = System.Drawing.StringAlignment.Near
        Me.btn_POS.TextPadding = 50
        Me.btn_POS.TextSpacing = 2
        '
        'btn_boutique_dashboard
        '
        Me.btn_boutique_dashboard.CheckButton = False
        Me.btn_boutique_dashboard.Checked = False
        Me.btn_boutique_dashboard.CheckedBackground = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_boutique_dashboard.CheckedForeColor = System.Drawing.Color.White
        Me.btn_boutique_dashboard.CheckedImageTint = System.Drawing.Color.White
        Me.btn_boutique_dashboard.CheckedOutline = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_boutique_dashboard.Content = "Dashboard"
        Me.btn_boutique_dashboard.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_boutique_dashboard.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btn_boutique_dashboard.Dock = System.Windows.Forms.DockStyle.Top
        Me.btn_boutique_dashboard.Font = New System.Drawing.Font("Helvetica", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_boutique_dashboard.ForeColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.btn_boutique_dashboard.HoverBackground = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.btn_boutique_dashboard.HoverForeColor = System.Drawing.Color.White
        Me.btn_boutique_dashboard.HoverImageTint = System.Drawing.Color.White
        Me.btn_boutique_dashboard.HoverOutline = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btn_boutique_dashboard.Image = CType(resources.GetObject("btn_boutique_dashboard.Image"), System.Drawing.Image)
        Me.btn_boutique_dashboard.ImageExpand = New System.Drawing.Point(3, 3)
        Me.btn_boutique_dashboard.Location = New System.Drawing.Point(0, 0)
        Me.btn_boutique_dashboard.Name = "btn_boutique_dashboard"
        Me.btn_boutique_dashboard.NormalBackground = System.Drawing.Color.Transparent
        Me.btn_boutique_dashboard.NormalForeColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.btn_boutique_dashboard.NormalImageTint = System.Drawing.Color.White
        Me.btn_boutique_dashboard.NormalOutline = System.Drawing.Color.Transparent
        Me.btn_boutique_dashboard.OutlineThickness = 1.0!
        Me.btn_boutique_dashboard.Padding = New System.Windows.Forms.Padding(50)
        Me.btn_boutique_dashboard.PressedBackground = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.btn_boutique_dashboard.PressedForeColor = System.Drawing.Color.White
        Me.btn_boutique_dashboard.PressedImageTint = System.Drawing.Color.White
        Me.btn_boutique_dashboard.PressedOutline = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btn_boutique_dashboard.Rounding = New System.Windows.Forms.Padding(8)
        Me.btn_boutique_dashboard.Size = New System.Drawing.Size(241, 39)
        Me.btn_boutique_dashboard.TabIndex = 16
        Me.btn_boutique_dashboard.Tag = ""
        Me.btn_boutique_dashboard.TextAlignment = System.Drawing.StringAlignment.Near
        Me.btn_boutique_dashboard.TextPadding = 50
        Me.btn_boutique_dashboard.TextSpacing = 2
        '
        'MaterialDivider4
        '
        Me.MaterialDivider4.BackColor = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.MaterialDivider4.Depth = 0
        Me.MaterialDivider4.Location = New System.Drawing.Point(3, 323)
        Me.MaterialDivider4.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER
        Me.MaterialDivider4.Name = "MaterialDivider4"
        Me.MaterialDivider4.Size = New System.Drawing.Size(240, 2)
        Me.MaterialDivider4.TabIndex = 15
        Me.MaterialDivider4.Text = "MaterialDivider4"
        '
        'core_panel
        '
        Me.core_panel.BackColor = System.Drawing.Color.Transparent
        Me.core_panel.Controls.Add(Me.actions_panel)
        Me.core_panel.Controls.Add(Me.boutique_submenu)
        Me.core_panel.Controls.Add(Me.btn_boutique)
        Me.core_panel.Controls.Add(Me.museum_submenu)
        Me.core_panel.Controls.Add(Me.btn_museum)
        Me.core_panel.Controls.Add(Me.logo_panel)
        Me.core_panel.Dock = System.Windows.Forms.DockStyle.Left
        Me.core_panel.GradientAngle = 0!
        Me.core_panel.Location = New System.Drawing.Point(0, 0)
        Me.core_panel.Name = "core_panel"
        Me.core_panel.OutlineThickness = 1.0!
        Me.core_panel.PanelColor1 = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.core_panel.PanelColor2 = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.core_panel.PanelOutlineColor1 = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.core_panel.PanelOutlineColor2 = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.core_panel.Rounding = New System.Windows.Forms.Padding(8)
        Me.core_panel.Size = New System.Drawing.Size(241, 1750)
        Me.core_panel.TabIndex = 13
        '
        'actions_panel
        '
        Me.actions_panel.Controls.Add(Me.btn_logout)
        Me.actions_panel.Controls.Add(Me.btn_settings)
        Me.actions_panel.Controls.Add(Me.btn_reports)
        Me.actions_panel.Controls.Add(Me.btn_users)
        Me.actions_panel.Controls.Add(Me.btn_positions)
        Me.actions_panel.Controls.Add(Me.btn_categories)
        Me.actions_panel.Dock = System.Windows.Forms.DockStyle.Top
        Me.actions_panel.Location = New System.Drawing.Point(0, 1036)
        Me.actions_panel.Name = "actions_panel"
        Me.actions_panel.OutlineThickness = 1.0!
        Me.actions_panel.PanelColor = System.Drawing.Color.Transparent
        Me.actions_panel.PanelOutlineColor = System.Drawing.Color.Transparent
        Me.actions_panel.Rounding = New System.Windows.Forms.Padding(8)
        Me.actions_panel.Size = New System.Drawing.Size(241, 354)
        Me.actions_panel.TabIndex = 19
        '
        'btn_logout
        '
        Me.btn_logout.CheckButton = False
        Me.btn_logout.Checked = False
        Me.btn_logout.CheckedBackground = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_logout.CheckedForeColor = System.Drawing.Color.White
        Me.btn_logout.CheckedImageTint = System.Drawing.Color.White
        Me.btn_logout.CheckedOutline = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_logout.Content = "Logout"
        Me.btn_logout.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_logout.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btn_logout.Dock = System.Windows.Forms.DockStyle.Top
        Me.btn_logout.Font = New System.Drawing.Font("Helvetica", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_logout.ForeColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.btn_logout.HoverBackground = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.btn_logout.HoverForeColor = System.Drawing.Color.White
        Me.btn_logout.HoverImageTint = System.Drawing.Color.White
        Me.btn_logout.HoverOutline = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btn_logout.Image = CType(resources.GetObject("btn_logout.Image"), System.Drawing.Image)
        Me.btn_logout.ImageExpand = New System.Drawing.Point(3, 3)
        Me.btn_logout.Location = New System.Drawing.Point(0, 290)
        Me.btn_logout.Name = "btn_logout"
        Me.btn_logout.NormalBackground = System.Drawing.Color.Transparent
        Me.btn_logout.NormalForeColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.btn_logout.NormalImageTint = System.Drawing.Color.White
        Me.btn_logout.NormalOutline = System.Drawing.Color.Transparent
        Me.btn_logout.OutlineThickness = 1.0!
        Me.btn_logout.Padding = New System.Windows.Forms.Padding(35)
        Me.btn_logout.PressedBackground = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.btn_logout.PressedForeColor = System.Drawing.Color.White
        Me.btn_logout.PressedImageTint = System.Drawing.Color.White
        Me.btn_logout.PressedOutline = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btn_logout.Rounding = New System.Windows.Forms.Padding(8)
        Me.btn_logout.Size = New System.Drawing.Size(241, 58)
        Me.btn_logout.TabIndex = 3
        Me.btn_logout.Tag = ""
        Me.btn_logout.TextAlignment = System.Drawing.StringAlignment.Near
        Me.btn_logout.TextPadding = 35
        Me.btn_logout.TextSpacing = 2
        '
        'btn_settings
        '
        Me.btn_settings.CheckButton = False
        Me.btn_settings.Checked = False
        Me.btn_settings.CheckedBackground = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_settings.CheckedForeColor = System.Drawing.Color.White
        Me.btn_settings.CheckedImageTint = System.Drawing.Color.White
        Me.btn_settings.CheckedOutline = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_settings.Content = "Settings"
        Me.btn_settings.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_settings.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btn_settings.Dock = System.Windows.Forms.DockStyle.Top
        Me.btn_settings.Font = New System.Drawing.Font("Helvetica", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_settings.ForeColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.btn_settings.HoverBackground = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.btn_settings.HoverForeColor = System.Drawing.Color.White
        Me.btn_settings.HoverImageTint = System.Drawing.Color.White
        Me.btn_settings.HoverOutline = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btn_settings.Image = CType(resources.GetObject("btn_settings.Image"), System.Drawing.Image)
        Me.btn_settings.ImageExpand = New System.Drawing.Point(3, 3)
        Me.btn_settings.Location = New System.Drawing.Point(0, 232)
        Me.btn_settings.Name = "btn_settings"
        Me.btn_settings.NormalBackground = System.Drawing.Color.Transparent
        Me.btn_settings.NormalForeColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.btn_settings.NormalImageTint = System.Drawing.Color.White
        Me.btn_settings.NormalOutline = System.Drawing.Color.Transparent
        Me.btn_settings.OutlineThickness = 1.0!
        Me.btn_settings.Padding = New System.Windows.Forms.Padding(35)
        Me.btn_settings.PressedBackground = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.btn_settings.PressedForeColor = System.Drawing.Color.White
        Me.btn_settings.PressedImageTint = System.Drawing.Color.White
        Me.btn_settings.PressedOutline = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btn_settings.Rounding = New System.Windows.Forms.Padding(8)
        Me.btn_settings.Size = New System.Drawing.Size(241, 58)
        Me.btn_settings.TabIndex = 2
        Me.btn_settings.Tag = ""
        Me.btn_settings.TextAlignment = System.Drawing.StringAlignment.Near
        Me.btn_settings.TextPadding = 35
        Me.btn_settings.TextSpacing = 2
        '
        'btn_reports
        '
        Me.btn_reports.CheckButton = False
        Me.btn_reports.Checked = False
        Me.btn_reports.CheckedBackground = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_reports.CheckedForeColor = System.Drawing.Color.White
        Me.btn_reports.CheckedImageTint = System.Drawing.Color.White
        Me.btn_reports.CheckedOutline = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_reports.Content = "Reports"
        Me.btn_reports.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_reports.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btn_reports.Dock = System.Windows.Forms.DockStyle.Top
        Me.btn_reports.Font = New System.Drawing.Font("Helvetica", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_reports.ForeColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.btn_reports.HoverBackground = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.btn_reports.HoverForeColor = System.Drawing.Color.White
        Me.btn_reports.HoverImageTint = System.Drawing.Color.White
        Me.btn_reports.HoverOutline = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btn_reports.Image = CType(resources.GetObject("btn_reports.Image"), System.Drawing.Image)
        Me.btn_reports.ImageExpand = New System.Drawing.Point(3, 3)
        Me.btn_reports.Location = New System.Drawing.Point(0, 174)
        Me.btn_reports.Name = "btn_reports"
        Me.btn_reports.NormalBackground = System.Drawing.Color.Transparent
        Me.btn_reports.NormalForeColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.btn_reports.NormalImageTint = System.Drawing.Color.White
        Me.btn_reports.NormalOutline = System.Drawing.Color.Transparent
        Me.btn_reports.OutlineThickness = 1.0!
        Me.btn_reports.Padding = New System.Windows.Forms.Padding(35)
        Me.btn_reports.PressedBackground = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.btn_reports.PressedForeColor = System.Drawing.Color.White
        Me.btn_reports.PressedImageTint = System.Drawing.Color.White
        Me.btn_reports.PressedOutline = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btn_reports.Rounding = New System.Windows.Forms.Padding(8)
        Me.btn_reports.Size = New System.Drawing.Size(241, 58)
        Me.btn_reports.TabIndex = 0
        Me.btn_reports.Tag = ""
        Me.btn_reports.TextAlignment = System.Drawing.StringAlignment.Near
        Me.btn_reports.TextPadding = 35
        Me.btn_reports.TextSpacing = 2
        '
        'btn_users
        '
        Me.btn_users.CheckButton = False
        Me.btn_users.Checked = False
        Me.btn_users.CheckedBackground = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_users.CheckedForeColor = System.Drawing.Color.White
        Me.btn_users.CheckedImageTint = System.Drawing.Color.White
        Me.btn_users.CheckedOutline = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_users.Content = "Users"
        Me.btn_users.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_users.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btn_users.Dock = System.Windows.Forms.DockStyle.Top
        Me.btn_users.Font = New System.Drawing.Font("Helvetica", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_users.ForeColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.btn_users.HoverBackground = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.btn_users.HoverForeColor = System.Drawing.Color.White
        Me.btn_users.HoverImageTint = System.Drawing.Color.White
        Me.btn_users.HoverOutline = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btn_users.Image = CType(resources.GetObject("btn_users.Image"), System.Drawing.Image)
        Me.btn_users.ImageExpand = New System.Drawing.Point(3, 3)
        Me.btn_users.Location = New System.Drawing.Point(0, 116)
        Me.btn_users.Name = "btn_users"
        Me.btn_users.NormalBackground = System.Drawing.Color.Transparent
        Me.btn_users.NormalForeColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.btn_users.NormalImageTint = System.Drawing.Color.White
        Me.btn_users.NormalOutline = System.Drawing.Color.Transparent
        Me.btn_users.OutlineThickness = 1.0!
        Me.btn_users.Padding = New System.Windows.Forms.Padding(35)
        Me.btn_users.PressedBackground = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.btn_users.PressedForeColor = System.Drawing.Color.White
        Me.btn_users.PressedImageTint = System.Drawing.Color.White
        Me.btn_users.PressedOutline = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btn_users.Rounding = New System.Windows.Forms.Padding(8)
        Me.btn_users.Size = New System.Drawing.Size(241, 58)
        Me.btn_users.TabIndex = 20
        Me.btn_users.Tag = ""
        Me.btn_users.TextAlignment = System.Drawing.StringAlignment.Near
        Me.btn_users.TextPadding = 35
        Me.btn_users.TextSpacing = 2
        '
        'btn_positions
        '
        Me.btn_positions.CheckButton = False
        Me.btn_positions.Checked = False
        Me.btn_positions.CheckedBackground = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_positions.CheckedForeColor = System.Drawing.Color.White
        Me.btn_positions.CheckedImageTint = System.Drawing.Color.White
        Me.btn_positions.CheckedOutline = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_positions.Content = "Positions"
        Me.btn_positions.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_positions.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btn_positions.Dock = System.Windows.Forms.DockStyle.Top
        Me.btn_positions.Font = New System.Drawing.Font("Helvetica", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_positions.ForeColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.btn_positions.HoverBackground = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.btn_positions.HoverForeColor = System.Drawing.Color.White
        Me.btn_positions.HoverImageTint = System.Drawing.Color.White
        Me.btn_positions.HoverOutline = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btn_positions.Image = CType(resources.GetObject("btn_positions.Image"), System.Drawing.Image)
        Me.btn_positions.ImageExpand = New System.Drawing.Point(3, 3)
        Me.btn_positions.Location = New System.Drawing.Point(0, 58)
        Me.btn_positions.Name = "btn_positions"
        Me.btn_positions.NormalBackground = System.Drawing.Color.Transparent
        Me.btn_positions.NormalForeColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.btn_positions.NormalImageTint = System.Drawing.Color.White
        Me.btn_positions.NormalOutline = System.Drawing.Color.Transparent
        Me.btn_positions.OutlineThickness = 1.0!
        Me.btn_positions.Padding = New System.Windows.Forms.Padding(35)
        Me.btn_positions.PressedBackground = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.btn_positions.PressedForeColor = System.Drawing.Color.White
        Me.btn_positions.PressedImageTint = System.Drawing.Color.White
        Me.btn_positions.PressedOutline = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btn_positions.Rounding = New System.Windows.Forms.Padding(8)
        Me.btn_positions.Size = New System.Drawing.Size(241, 58)
        Me.btn_positions.TabIndex = 21
        Me.btn_positions.Tag = ""
        Me.btn_positions.TextAlignment = System.Drawing.StringAlignment.Near
        Me.btn_positions.TextPadding = 35
        Me.btn_positions.TextSpacing = 2
        '
        'btn_categories
        '
        Me.btn_categories.CheckButton = False
        Me.btn_categories.Checked = False
        Me.btn_categories.CheckedBackground = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_categories.CheckedForeColor = System.Drawing.Color.White
        Me.btn_categories.CheckedImageTint = System.Drawing.Color.White
        Me.btn_categories.CheckedOutline = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_categories.Content = "Categories"
        Me.btn_categories.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_categories.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btn_categories.Dock = System.Windows.Forms.DockStyle.Top
        Me.btn_categories.Font = New System.Drawing.Font("Helvetica", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_categories.ForeColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.btn_categories.HoverBackground = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.btn_categories.HoverForeColor = System.Drawing.Color.White
        Me.btn_categories.HoverImageTint = System.Drawing.Color.White
        Me.btn_categories.HoverOutline = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btn_categories.Image = CType(resources.GetObject("btn_categories.Image"), System.Drawing.Image)
        Me.btn_categories.ImageExpand = New System.Drawing.Point(3, 3)
        Me.btn_categories.Location = New System.Drawing.Point(0, 0)
        Me.btn_categories.Name = "btn_categories"
        Me.btn_categories.NormalBackground = System.Drawing.Color.Transparent
        Me.btn_categories.NormalForeColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.btn_categories.NormalImageTint = System.Drawing.Color.White
        Me.btn_categories.NormalOutline = System.Drawing.Color.Transparent
        Me.btn_categories.OutlineThickness = 1.0!
        Me.btn_categories.Padding = New System.Windows.Forms.Padding(35)
        Me.btn_categories.PressedBackground = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.btn_categories.PressedForeColor = System.Drawing.Color.White
        Me.btn_categories.PressedImageTint = System.Drawing.Color.White
        Me.btn_categories.PressedOutline = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btn_categories.Rounding = New System.Windows.Forms.Padding(8)
        Me.btn_categories.Size = New System.Drawing.Size(241, 58)
        Me.btn_categories.TabIndex = 4
        Me.btn_categories.Tag = ""
        Me.btn_categories.TextAlignment = System.Drawing.StringAlignment.Near
        Me.btn_categories.TextPadding = 35
        Me.btn_categories.TextSpacing = 2
        '
        'logout_confirmation
        '
        Me.logout_confirmation.BackColor = System.Drawing.Color.White
        Me.logout_confirmation.ButtonSize = New System.Drawing.Size(80, 32)
        Me.logout_confirmation.CancelText = ""
        Me.logout_confirmation.DialogPadding = New System.Windows.Forms.Padding(30)
        Me.logout_confirmation.DialogSize = New System.Drawing.Size(430, 300)
        Me.logout_confirmation.DimColor = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.logout_confirmation.ForeColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.logout_confirmation.NoText = "No"
        Me.logout_confirmation.OKText = ""
        Me.logout_confirmation.Rounding = 12
        Me.logout_confirmation.YesText = "Yes"
        '
        'side_nav
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.core_panel)
        Me.Name = "side_nav"
        Me.Size = New System.Drawing.Size(241, 1750)
        Me.logo_panel.ResumeLayout(False)
        Me.museum_submenu.ResumeLayout(False)
        Me.boutique_submenu.ResumeLayout(False)
        Me.core_panel.ResumeLayout(False)
        Me.actions_panel.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents logo_panel As CuoreUI.Controls.cuiPanelGradient
    Friend WithEvents btn_museum As CuoreUI.Controls.cuiButton
    Friend WithEvents museum_submenu As CuoreUI.Controls.cuiPanel
    Friend WithEvents btn_museum_employees As CuoreUI.Controls.cuiButton
    Friend WithEvents btn_museum_maintenance As CuoreUI.Controls.cuiButton
    Friend WithEvents btn_museum_equipment As CuoreUI.Controls.cuiButton
    Friend WithEvents btn_donations As CuoreUI.Controls.cuiButton
    Friend WithEvents btn_guests As CuoreUI.Controls.cuiButton
    Friend WithEvents btn_countries As CuoreUI.Controls.cuiButton
    Friend WithEvents btn_sections As CuoreUI.Controls.cuiButton
    Friend WithEvents btn_classifications As CuoreUI.Controls.cuiButton
    Friend WithEvents btn_minerals As CuoreUI.Controls.cuiButton
    Friend WithEvents btn_museum_dashboard As CuoreUI.Controls.cuiButton
    Friend WithEvents btn_boutique As CuoreUI.Controls.cuiButton
    Friend WithEvents boutique_submenu As CuoreUI.Controls.cuiPanel
    Friend WithEvents btn_boutique_employees As CuoreUI.Controls.cuiButton
    Friend WithEvents btn_boutique_maintenance As CuoreUI.Controls.cuiButton
    Friend WithEvents btn_boutique_equipment As CuoreUI.Controls.cuiButton
    Friend WithEvents btn_transactions As CuoreUI.Controls.cuiButton
    Friend WithEvents btn_customers As CuoreUI.Controls.cuiButton
    Friend WithEvents core_panel As CuoreUI.Controls.cuiPanelGradient
    Friend WithEvents MaterialDivider1 As ReaLTaiizor.Controls.MaterialDivider
    Friend WithEvents login_museum_logo As CuoreUI.Controls.cuiPictureBox
    Friend WithEvents btn_POS As CuoreUI.Controls.cuiButton
    Friend WithEvents MaterialDivider2 As ReaLTaiizor.Controls.MaterialDivider
    Friend WithEvents btn_boutique_dashboard As CuoreUI.Controls.cuiButton
    Friend WithEvents btn_events As CuoreUI.Controls.cuiButton
    Friend WithEvents btn_inventory As CuoreUI.Controls.cuiButton
    Friend WithEvents actions_panel As CuoreUI.Controls.cuiPanel
    Friend WithEvents btn_categories As CuoreUI.Controls.cuiButton
    Friend WithEvents btn_positions As CuoreUI.Controls.cuiButton
    Friend WithEvents btn_logout As CuoreUI.Controls.cuiButton
    Friend WithEvents btn_users As CuoreUI.Controls.cuiButton
    Friend WithEvents btn_settings As CuoreUI.Controls.cuiButton
    Friend WithEvents btn_reports As CuoreUI.Controls.cuiButton
    Friend WithEvents MaterialDivider4 As ReaLTaiizor.Controls.MaterialDivider
    Friend WithEvents logout_confirmation As CuoreUI.Components.cuiMessageDialog
End Class
