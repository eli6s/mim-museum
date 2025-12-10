<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(login))
        Me.login_panel = New CuoreUI.Controls.cuiGradientPanel()
        Me.show_pass_lbl = New System.Windows.Forms.Label()
        Me.toggle_pass_switch = New CuoreUI.Controls.cuiSwitch()
        Me.forgot_pass_link = New System.Windows.Forms.LinkLabel()
        Me.login_lbl = New System.Windows.Forms.Label()
        Me.login_museum_logo = New CuoreUI.Controls.cuiPictureBox()
        Me.pass_txtbox = New CuoreUI.Controls.cuiTextBox()
        Me.login_btn = New CuoreUI.Controls.cuiButton()
        Me.username_txtbox = New CuoreUI.Controls.cuiTextBox()
        Me.login_panel.SuspendLayout()
        Me.SuspendLayout()
        '
        'login_panel
        '
        Me.login_panel.BackColor = System.Drawing.Color.Transparent
        Me.login_panel.Controls.Add(Me.show_pass_lbl)
        Me.login_panel.Controls.Add(Me.toggle_pass_switch)
        Me.login_panel.Controls.Add(Me.forgot_pass_link)
        Me.login_panel.Controls.Add(Me.login_lbl)
        Me.login_panel.Controls.Add(Me.login_museum_logo)
        Me.login_panel.Controls.Add(Me.pass_txtbox)
        Me.login_panel.Controls.Add(Me.login_btn)
        Me.login_panel.Controls.Add(Me.username_txtbox)
        Me.login_panel.GradientAngle = 50.0!
        Me.login_panel.Location = New System.Drawing.Point(3, 3)
        Me.login_panel.Name = "login_panel"
        Me.login_panel.OutlineThickness = 5.0!
        Me.login_panel.PanelColor1 = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.login_panel.PanelColor2 = System.Drawing.Color.Transparent
        Me.login_panel.PanelOutlineColor1 = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.login_panel.PanelOutlineColor2 = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.login_panel.Rounding = New System.Windows.Forms.Padding(26)
        Me.login_panel.Size = New System.Drawing.Size(453, 436)
        Me.login_panel.TabIndex = 7
        '
        'show_pass_lbl
        '
        Me.show_pass_lbl.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.show_pass_lbl.ForeColor = System.Drawing.Color.White
        Me.show_pass_lbl.Location = New System.Drawing.Point(118, 292)
        Me.show_pass_lbl.Name = "show_pass_lbl"
        Me.show_pass_lbl.Size = New System.Drawing.Size(112, 29)
        Me.show_pass_lbl.TabIndex = 22
        Me.show_pass_lbl.Text = "Show password"
        '
        'toggle_pass_switch
        '
        Me.toggle_pass_switch.Checked = False
        Me.toggle_pass_switch.CheckedBackground = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.toggle_pass_switch.CheckedForeground = System.Drawing.Color.White
        Me.toggle_pass_switch.CheckedOutlineColor = System.Drawing.Color.Empty
        Me.toggle_pass_switch.CheckedSymbolColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.toggle_pass_switch.Cursor = System.Windows.Forms.Cursors.Hand
        Me.toggle_pass_switch.Location = New System.Drawing.Point(64, 286)
        Me.toggle_pass_switch.MinimumSize = New System.Drawing.Size(12, 8)
        Me.toggle_pass_switch.Name = "toggle_pass_switch"
        Me.toggle_pass_switch.OutlineThickness = 1.0!
        Me.toggle_pass_switch.ShowSymbols = False
        Me.toggle_pass_switch.Size = New System.Drawing.Size(48, 26)
        Me.toggle_pass_switch.TabIndex = 21
        Me.toggle_pass_switch.ThumbSizeModifier = New System.Drawing.Size(0, 0)
        Me.toggle_pass_switch.UncheckedBackground = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.toggle_pass_switch.UncheckedForeground = System.Drawing.Color.White
        Me.toggle_pass_switch.UncheckedOutlineColor = System.Drawing.Color.Empty
        Me.toggle_pass_switch.UncheckedSymbolColor = System.Drawing.Color.Gray
        '
        'forgot_pass_link
        '
        Me.forgot_pass_link.ActiveLinkColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.forgot_pass_link.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.forgot_pass_link.LinkColor = System.Drawing.Color.White
        Me.forgot_pass_link.Location = New System.Drawing.Point(267, 292)
        Me.forgot_pass_link.Name = "forgot_pass_link"
        Me.forgot_pass_link.Size = New System.Drawing.Size(138, 20)
        Me.forgot_pass_link.TabIndex = 17
        Me.forgot_pass_link.TabStop = True
        Me.forgot_pass_link.Text = "Forgot password?"
        '
        'login_lbl
        '
        Me.login_lbl.BackColor = System.Drawing.Color.Transparent
        Me.login_lbl.Font = New System.Drawing.Font("Arial", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.login_lbl.ForeColor = System.Drawing.Color.White
        Me.login_lbl.Location = New System.Drawing.Point(190, 50)
        Me.login_lbl.Name = "login_lbl"
        Me.login_lbl.Size = New System.Drawing.Size(130, 45)
        Me.login_lbl.TabIndex = 16
        Me.login_lbl.Text = "Login"
        '
        'login_museum_logo
        '
        Me.login_museum_logo.BackColor = System.Drawing.Color.Transparent
        Me.login_museum_logo.BackgroundImage = CType(resources.GetObject("login_museum_logo.BackgroundImage"), System.Drawing.Image)
        Me.login_museum_logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.login_museum_logo.Content = Nothing
        Me.login_museum_logo.ImageTint = System.Drawing.Color.White
        Me.login_museum_logo.Location = New System.Drawing.Point(106, 39)
        Me.login_museum_logo.Name = "login_museum_logo"
        Me.login_museum_logo.OutlineThickness = 1.0!
        Me.login_museum_logo.PanelOutlineColor = System.Drawing.Color.Empty
        Me.login_museum_logo.Rotation = 0
        Me.login_museum_logo.Rounding = New System.Windows.Forms.Padding(8)
        Me.login_museum_logo.Size = New System.Drawing.Size(78, 72)
        Me.login_museum_logo.TabIndex = 5
        '
        'pass_txtbox
        '
        Me.pass_txtbox.BackColor = System.Drawing.Color.Transparent
        Me.pass_txtbox.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.pass_txtbox.Content = ""
        Me.pass_txtbox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.pass_txtbox.FocusBackgroundColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.pass_txtbox.FocusImageTint = System.Drawing.Color.White
        Me.pass_txtbox.FocusOutlineColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.pass_txtbox.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pass_txtbox.ForeColor = System.Drawing.Color.Black
        Me.pass_txtbox.Image = CType(resources.GetObject("pass_txtbox.Image"), System.Drawing.Image)
        Me.pass_txtbox.ImageExpand = New System.Drawing.Point(4, 4)
        Me.pass_txtbox.ImageOffset = New System.Drawing.Point(0, 0)
        Me.pass_txtbox.Location = New System.Drawing.Point(64, 213)
        Me.pass_txtbox.Margin = New System.Windows.Forms.Padding(4)
        Me.pass_txtbox.Multiline = False
        Me.pass_txtbox.Name = "pass_txtbox"
        Me.pass_txtbox.NormalImageTint = System.Drawing.Color.White
        Me.pass_txtbox.OutlineColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.pass_txtbox.Padding = New System.Windows.Forms.Padding(53, 13, 53, 0)
        Me.pass_txtbox.PasswordChar = True
        Me.pass_txtbox.PlaceholderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(161, Byte), Integer))
        Me.pass_txtbox.PlaceholderText = "Password"
        Me.pass_txtbox.Rounding = New System.Windows.Forms.Padding(12)
        Me.pass_txtbox.Size = New System.Drawing.Size(328, 45)
        Me.pass_txtbox.TabIndex = 10
        Me.pass_txtbox.TextOffset = New System.Drawing.Size(35, 0)
        Me.pass_txtbox.UnderlinedStyle = True
        '
        'login_btn
        '
        Me.login_btn.CheckButton = False
        Me.login_btn.Checked = False
        Me.login_btn.CheckedBackground = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.login_btn.CheckedForeColor = System.Drawing.Color.White
        Me.login_btn.CheckedImageTint = System.Drawing.Color.White
        Me.login_btn.CheckedOutline = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.login_btn.Content = "Login"
        Me.login_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.login_btn.DialogResult = System.Windows.Forms.DialogResult.None
        Me.login_btn.Enabled = False
        Me.login_btn.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.login_btn.ForeColor = System.Drawing.Color.White
        Me.login_btn.HoverBackground = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.login_btn.HoverForeColor = System.Drawing.Color.White
        Me.login_btn.HoverImageTint = System.Drawing.Color.White
        Me.login_btn.HoverOutline = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.login_btn.Image = Nothing
        Me.login_btn.ImageAutoCenter = True
        Me.login_btn.ImageExpand = New System.Drawing.Point(0, 0)
        Me.login_btn.ImageOffset = New System.Drawing.Point(0, 0)
        Me.login_btn.Location = New System.Drawing.Point(64, 338)
        Me.login_btn.Name = "login_btn"
        Me.login_btn.NormalBackground = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(161, Byte), Integer))
        Me.login_btn.NormalForeColor = System.Drawing.Color.White
        Me.login_btn.NormalImageTint = System.Drawing.Color.White
        Me.login_btn.NormalOutline = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(161, Byte), Integer))
        Me.login_btn.OutlineThickness = 1.0!
        Me.login_btn.PressedBackground = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(161, Byte), Integer))
        Me.login_btn.PressedForeColor = System.Drawing.Color.White
        Me.login_btn.PressedImageTint = System.Drawing.Color.White
        Me.login_btn.PressedOutline = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(161, Byte), Integer))
        Me.login_btn.Rounding = New System.Windows.Forms.Padding(12)
        Me.login_btn.Size = New System.Drawing.Size(328, 45)
        Me.login_btn.TabIndex = 15
        Me.login_btn.TextAlignment = System.Drawing.StringAlignment.Center
        Me.login_btn.TextOffset = New System.Drawing.Point(0, 0)
        '
        'username_txtbox
        '
        Me.username_txtbox.BackColor = System.Drawing.Color.Transparent
        Me.username_txtbox.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.username_txtbox.Content = ""
        Me.username_txtbox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.username_txtbox.FocusBackgroundColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.username_txtbox.FocusImageTint = System.Drawing.Color.White
        Me.username_txtbox.FocusOutlineColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.username_txtbox.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.username_txtbox.ForeColor = System.Drawing.Color.Black
        Me.username_txtbox.Image = CType(resources.GetObject("username_txtbox.Image"), System.Drawing.Image)
        Me.username_txtbox.ImageExpand = New System.Drawing.Point(4, 4)
        Me.username_txtbox.ImageOffset = New System.Drawing.Point(0, 0)
        Me.username_txtbox.Location = New System.Drawing.Point(64, 147)
        Me.username_txtbox.Margin = New System.Windows.Forms.Padding(4)
        Me.username_txtbox.Multiline = False
        Me.username_txtbox.Name = "username_txtbox"
        Me.username_txtbox.NormalImageTint = System.Drawing.Color.White
        Me.username_txtbox.OutlineColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.username_txtbox.Padding = New System.Windows.Forms.Padding(53, 13, 53, 0)
        Me.username_txtbox.PasswordChar = False
        Me.username_txtbox.PlaceholderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(161, Byte), Integer))
        Me.username_txtbox.PlaceholderText = "Username"
        Me.username_txtbox.Rounding = New System.Windows.Forms.Padding(12)
        Me.username_txtbox.Size = New System.Drawing.Size(328, 44)
        Me.username_txtbox.TabIndex = 11
        Me.username_txtbox.TextOffset = New System.Drawing.Size(35, 0)
        Me.username_txtbox.UnderlinedStyle = True
        '
        'login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.login_panel)
        Me.Name = "login"
        Me.Size = New System.Drawing.Size(462, 446)
        Me.login_panel.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents login_panel As CuoreUI.Controls.cuiGradientPanel
    Friend WithEvents show_pass_lbl As Label
    Friend WithEvents toggle_pass_switch As CuoreUI.Controls.cuiSwitch
    Friend WithEvents forgot_pass_link As LinkLabel
    Friend WithEvents login_lbl As Label
    Friend WithEvents login_museum_logo As CuoreUI.Controls.cuiPictureBox
    Friend WithEvents pass_txtbox As CuoreUI.Controls.cuiTextBox
    Friend WithEvents login_btn As CuoreUI.Controls.cuiButton
    Friend WithEvents username_txtbox As CuoreUI.Controls.cuiTextBox
End Class
