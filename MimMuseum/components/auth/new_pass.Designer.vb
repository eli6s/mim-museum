<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class new_pass
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(new_pass))
        Me.new_pass_panel = New CuoreUI.Controls.cuiGradientPanel()
        Me.CuiTextBox1 = New CuoreUI.Controls.cuiTextBox()
        Me.login_lbl = New System.Windows.Forms.Label()
        Me.pass_txtbox = New CuoreUI.Controls.cuiTextBox()
        Me.login_btn = New CuoreUI.Controls.cuiButton()
        Me.new_pass_panel.SuspendLayout()
        Me.SuspendLayout()
        '
        'new_pass_panel
        '
        Me.new_pass_panel.BackColor = System.Drawing.Color.Transparent
        Me.new_pass_panel.Controls.Add(Me.CuiTextBox1)
        Me.new_pass_panel.Controls.Add(Me.login_lbl)
        Me.new_pass_panel.Controls.Add(Me.pass_txtbox)
        Me.new_pass_panel.Controls.Add(Me.login_btn)
        Me.new_pass_panel.GradientAngle = 50.0!
        Me.new_pass_panel.Location = New System.Drawing.Point(32, 20)
        Me.new_pass_panel.Name = "new_pass_panel"
        Me.new_pass_panel.OutlineThickness = 5.0!
        Me.new_pass_panel.PanelColor1 = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.new_pass_panel.PanelColor2 = System.Drawing.Color.Transparent
        Me.new_pass_panel.PanelOutlineColor1 = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.new_pass_panel.PanelOutlineColor2 = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.new_pass_panel.Rounding = New System.Windows.Forms.Padding(26)
        Me.new_pass_panel.Size = New System.Drawing.Size(453, 405)
        Me.new_pass_panel.TabIndex = 8
        '
        'CuiTextBox1
        '
        Me.CuiTextBox1.BackColor = System.Drawing.Color.Transparent
        Me.CuiTextBox1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.CuiTextBox1.Content = ""
        Me.CuiTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.CuiTextBox1.FocusBackgroundColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.CuiTextBox1.FocusImageTint = System.Drawing.Color.White
        Me.CuiTextBox1.FocusOutlineColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.CuiTextBox1.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CuiTextBox1.ForeColor = System.Drawing.Color.Black
        Me.CuiTextBox1.Image = CType(resources.GetObject("CuiTextBox1.Image"), System.Drawing.Image)
        Me.CuiTextBox1.ImageExpand = New System.Drawing.Point(4, 4)
        Me.CuiTextBox1.ImageOffset = New System.Drawing.Point(0, 0)
        Me.CuiTextBox1.Location = New System.Drawing.Point(64, 147)
        Me.CuiTextBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.CuiTextBox1.Multiline = False
        Me.CuiTextBox1.Name = "CuiTextBox1"
        Me.CuiTextBox1.NormalImageTint = System.Drawing.Color.White
        Me.CuiTextBox1.OutlineColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.CuiTextBox1.Padding = New System.Windows.Forms.Padding(53, 13, 53, 0)
        Me.CuiTextBox1.PasswordChar = True
        Me.CuiTextBox1.PlaceholderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(161, Byte), Integer))
        Me.CuiTextBox1.PlaceholderText = "New Password"
        Me.CuiTextBox1.Rounding = New System.Windows.Forms.Padding(12)
        Me.CuiTextBox1.Size = New System.Drawing.Size(328, 45)
        Me.CuiTextBox1.TabIndex = 24
        Me.CuiTextBox1.TextOffset = New System.Drawing.Size(35, 0)
        Me.CuiTextBox1.UnderlinedStyle = True
        '
        'login_lbl
        '
        Me.login_lbl.BackColor = System.Drawing.Color.Transparent
        Me.login_lbl.Font = New System.Drawing.Font("Helvetica", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.login_lbl.ForeColor = System.Drawing.Color.White
        Me.login_lbl.Location = New System.Drawing.Point(88, 56)
        Me.login_lbl.Name = "login_lbl"
        Me.login_lbl.Size = New System.Drawing.Size(284, 45)
        Me.login_lbl.TabIndex = 23
        Me.login_lbl.Text = "New Password"
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
        Me.pass_txtbox.PlaceholderText = "Confirm Password"
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
        Me.login_btn.Content = "Set Password"
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
        Me.login_btn.Location = New System.Drawing.Point(64, 293)
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
        'new_pass
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.new_pass_panel)
        Me.Name = "new_pass"
        Me.Size = New System.Drawing.Size(528, 471)
        Me.new_pass_panel.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents new_pass_panel As CuoreUI.Controls.cuiGradientPanel
    Friend WithEvents pass_txtbox As CuoreUI.Controls.cuiTextBox
    Friend WithEvents login_btn As CuoreUI.Controls.cuiButton
    Friend WithEvents CuiTextBox1 As CuoreUI.Controls.cuiTextBox
    Friend WithEvents login_lbl As Label
End Class
