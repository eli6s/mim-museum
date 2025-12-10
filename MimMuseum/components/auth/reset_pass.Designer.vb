<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class reset_pass
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(reset_pass))
        Me.reset_pass_panel = New CuoreUI.Controls.cuiGradientPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.email_txtbox = New CuoreUI.Controls.cuiTextBox()
        Me.verif_code_txtbox = New CuoreUI.Controls.cuiTextBox()
        Me.login_lbl = New System.Windows.Forms.Label()
        Me.send_code_btn = New CuoreUI.Controls.cuiButton()
        Me.proceed_btn = New CuoreUI.Controls.cuiButton()
        Me.reset_pass_panel.SuspendLayout()
        Me.SuspendLayout()
        '
        'reset_pass_panel
        '
        Me.reset_pass_panel.BackColor = System.Drawing.Color.Transparent
        Me.reset_pass_panel.Controls.Add(Me.Label1)
        Me.reset_pass_panel.Controls.Add(Me.email_txtbox)
        Me.reset_pass_panel.Controls.Add(Me.verif_code_txtbox)
        Me.reset_pass_panel.Controls.Add(Me.login_lbl)
        Me.reset_pass_panel.Controls.Add(Me.send_code_btn)
        Me.reset_pass_panel.Controls.Add(Me.proceed_btn)
        Me.reset_pass_panel.GradientAngle = 50.0!
        Me.reset_pass_panel.Location = New System.Drawing.Point(29, 23)
        Me.reset_pass_panel.Name = "reset_pass_panel"
        Me.reset_pass_panel.OutlineThickness = 5.0!
        Me.reset_pass_panel.PanelColor1 = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.reset_pass_panel.PanelColor2 = System.Drawing.Color.Transparent
        Me.reset_pass_panel.PanelOutlineColor1 = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.reset_pass_panel.PanelOutlineColor2 = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.reset_pass_panel.Rounding = New System.Windows.Forms.Padding(26)
        Me.reset_pass_panel.Size = New System.Drawing.Size(453, 321)
        Me.reset_pass_panel.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Helvetica", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Silver
        Me.Label1.Location = New System.Drawing.Point(110, 288)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(238, 24)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Press the ""left arrow"" key to go back"
        '
        'email_txtbox
        '
        Me.email_txtbox.BackColor = System.Drawing.Color.Transparent
        Me.email_txtbox.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.email_txtbox.Content = ""
        Me.email_txtbox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.email_txtbox.FocusBackgroundColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.email_txtbox.FocusImageTint = System.Drawing.Color.White
        Me.email_txtbox.FocusOutlineColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.email_txtbox.Font = New System.Drawing.Font("Helvetica", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.email_txtbox.ForeColor = System.Drawing.Color.Black
        Me.email_txtbox.Image = CType(resources.GetObject("email_txtbox.Image"), System.Drawing.Image)
        Me.email_txtbox.ImageExpand = New System.Drawing.Point(4, 4)
        Me.email_txtbox.ImageOffset = New System.Drawing.Point(0, 0)
        Me.email_txtbox.Location = New System.Drawing.Point(64, 137)
        Me.email_txtbox.Margin = New System.Windows.Forms.Padding(4)
        Me.email_txtbox.Multiline = False
        Me.email_txtbox.Name = "email_txtbox"
        Me.email_txtbox.NormalImageTint = System.Drawing.Color.White
        Me.email_txtbox.OutlineColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.email_txtbox.Padding = New System.Windows.Forms.Padding(53, 13, 53, 0)
        Me.email_txtbox.PasswordChar = False
        Me.email_txtbox.PlaceholderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(161, Byte), Integer))
        Me.email_txtbox.PlaceholderText = "Email"
        Me.email_txtbox.Rounding = New System.Windows.Forms.Padding(12)
        Me.email_txtbox.Size = New System.Drawing.Size(328, 44)
        Me.email_txtbox.TabIndex = 11
        Me.email_txtbox.TextOffset = New System.Drawing.Size(35, 0)
        Me.email_txtbox.UnderlinedStyle = True
        '
        'verif_code_txtbox
        '
        Me.verif_code_txtbox.BackColor = System.Drawing.Color.Transparent
        Me.verif_code_txtbox.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.verif_code_txtbox.Content = ""
        Me.verif_code_txtbox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.verif_code_txtbox.FocusBackgroundColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.verif_code_txtbox.FocusImageTint = System.Drawing.Color.White
        Me.verif_code_txtbox.FocusOutlineColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.verif_code_txtbox.Font = New System.Drawing.Font("Helvetica", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.verif_code_txtbox.ForeColor = System.Drawing.Color.Black
        Me.verif_code_txtbox.Image = CType(resources.GetObject("verif_code_txtbox.Image"), System.Drawing.Image)
        Me.verif_code_txtbox.ImageExpand = New System.Drawing.Point(5, 5)
        Me.verif_code_txtbox.ImageOffset = New System.Drawing.Point(0, 0)
        Me.verif_code_txtbox.Location = New System.Drawing.Point(64, 137)
        Me.verif_code_txtbox.Margin = New System.Windows.Forms.Padding(4)
        Me.verif_code_txtbox.Multiline = False
        Me.verif_code_txtbox.Name = "verif_code_txtbox"
        Me.verif_code_txtbox.NormalImageTint = System.Drawing.Color.White
        Me.verif_code_txtbox.OutlineColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.verif_code_txtbox.Padding = New System.Windows.Forms.Padding(53, 13, 53, 0)
        Me.verif_code_txtbox.PasswordChar = False
        Me.verif_code_txtbox.PlaceholderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(161, Byte), Integer))
        Me.verif_code_txtbox.PlaceholderText = "Enter Code"
        Me.verif_code_txtbox.Rounding = New System.Windows.Forms.Padding(12)
        Me.verif_code_txtbox.Size = New System.Drawing.Size(328, 44)
        Me.verif_code_txtbox.TabIndex = 18
        Me.verif_code_txtbox.TextOffset = New System.Drawing.Size(35, 0)
        Me.verif_code_txtbox.UnderlinedStyle = True
        '
        'login_lbl
        '
        Me.login_lbl.BackColor = System.Drawing.Color.Transparent
        Me.login_lbl.Font = New System.Drawing.Font("Helvetica", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.login_lbl.ForeColor = System.Drawing.Color.White
        Me.login_lbl.Location = New System.Drawing.Point(82, 49)
        Me.login_lbl.Name = "login_lbl"
        Me.login_lbl.Size = New System.Drawing.Size(297, 45)
        Me.login_lbl.TabIndex = 16
        Me.login_lbl.Text = "Reset Password"
        '
        'send_code_btn
        '
        Me.send_code_btn.CheckButton = False
        Me.send_code_btn.Checked = False
        Me.send_code_btn.CheckedBackground = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.send_code_btn.CheckedForeColor = System.Drawing.Color.White
        Me.send_code_btn.CheckedImageTint = System.Drawing.Color.White
        Me.send_code_btn.CheckedOutline = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.send_code_btn.Content = "Send Code"
        Me.send_code_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.send_code_btn.DialogResult = System.Windows.Forms.DialogResult.None
        Me.send_code_btn.Enabled = False
        Me.send_code_btn.Font = New System.Drawing.Font("Helvetica", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.send_code_btn.ForeColor = System.Drawing.Color.White
        Me.send_code_btn.HoverBackground = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.send_code_btn.HoverForeColor = System.Drawing.Color.White
        Me.send_code_btn.HoverImageTint = System.Drawing.Color.White
        Me.send_code_btn.HoverOutline = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.send_code_btn.Image = Nothing
        Me.send_code_btn.ImageAutoCenter = True
        Me.send_code_btn.ImageExpand = New System.Drawing.Point(0, 0)
        Me.send_code_btn.ImageOffset = New System.Drawing.Point(0, 0)
        Me.send_code_btn.Location = New System.Drawing.Point(64, 215)
        Me.send_code_btn.Name = "send_code_btn"
        Me.send_code_btn.NormalBackground = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(161, Byte), Integer))
        Me.send_code_btn.NormalForeColor = System.Drawing.Color.White
        Me.send_code_btn.NormalImageTint = System.Drawing.Color.White
        Me.send_code_btn.NormalOutline = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(161, Byte), Integer))
        Me.send_code_btn.OutlineThickness = 1.0!
        Me.send_code_btn.PressedBackground = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(161, Byte), Integer))
        Me.send_code_btn.PressedForeColor = System.Drawing.Color.White
        Me.send_code_btn.PressedImageTint = System.Drawing.Color.White
        Me.send_code_btn.PressedOutline = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(161, Byte), Integer))
        Me.send_code_btn.Rounding = New System.Windows.Forms.Padding(12)
        Me.send_code_btn.Size = New System.Drawing.Size(328, 45)
        Me.send_code_btn.TabIndex = 15
        Me.send_code_btn.TextAlignment = System.Drawing.StringAlignment.Center
        Me.send_code_btn.TextOffset = New System.Drawing.Point(0, 0)
        '
        'proceed_btn
        '
        Me.proceed_btn.CheckButton = False
        Me.proceed_btn.Checked = False
        Me.proceed_btn.CheckedBackground = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.proceed_btn.CheckedForeColor = System.Drawing.Color.White
        Me.proceed_btn.CheckedImageTint = System.Drawing.Color.White
        Me.proceed_btn.CheckedOutline = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.proceed_btn.Content = "Proceed"
        Me.proceed_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.proceed_btn.DialogResult = System.Windows.Forms.DialogResult.None
        Me.proceed_btn.Enabled = False
        Me.proceed_btn.Font = New System.Drawing.Font("Helvetica", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.proceed_btn.ForeColor = System.Drawing.Color.White
        Me.proceed_btn.HoverBackground = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.proceed_btn.HoverForeColor = System.Drawing.Color.White
        Me.proceed_btn.HoverImageTint = System.Drawing.Color.White
        Me.proceed_btn.HoverOutline = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.proceed_btn.Image = Nothing
        Me.proceed_btn.ImageAutoCenter = True
        Me.proceed_btn.ImageExpand = New System.Drawing.Point(0, 0)
        Me.proceed_btn.ImageOffset = New System.Drawing.Point(0, 0)
        Me.proceed_btn.Location = New System.Drawing.Point(64, 215)
        Me.proceed_btn.Name = "proceed_btn"
        Me.proceed_btn.NormalBackground = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(161, Byte), Integer))
        Me.proceed_btn.NormalForeColor = System.Drawing.Color.White
        Me.proceed_btn.NormalImageTint = System.Drawing.Color.White
        Me.proceed_btn.NormalOutline = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(161, Byte), Integer))
        Me.proceed_btn.OutlineThickness = 1.0!
        Me.proceed_btn.PressedBackground = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(161, Byte), Integer))
        Me.proceed_btn.PressedForeColor = System.Drawing.Color.White
        Me.proceed_btn.PressedImageTint = System.Drawing.Color.White
        Me.proceed_btn.PressedOutline = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(161, Byte), Integer))
        Me.proceed_btn.Rounding = New System.Windows.Forms.Padding(12)
        Me.proceed_btn.Size = New System.Drawing.Size(328, 45)
        Me.proceed_btn.TabIndex = 17
        Me.proceed_btn.TextAlignment = System.Drawing.StringAlignment.Center
        Me.proceed_btn.TextOffset = New System.Drawing.Point(0, 0)
        Me.proceed_btn.Visible = False
        '
        'reset_pass
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.reset_pass_panel)
        Me.Name = "reset_pass"
        Me.Size = New System.Drawing.Size(515, 372)
        Me.reset_pass_panel.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents reset_pass_panel As CuoreUI.Controls.cuiGradientPanel
    Friend WithEvents login_lbl As Label
    Friend WithEvents send_code_btn As CuoreUI.Controls.cuiButton
    Friend WithEvents email_txtbox As CuoreUI.Controls.cuiTextBox
    Friend WithEvents verif_code_txtbox As CuoreUI.Controls.cuiTextBox
    Friend WithEvents proceed_btn As CuoreUI.Controls.cuiButton
    Friend WithEvents Label1 As Label
End Class
