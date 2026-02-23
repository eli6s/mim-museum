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
        Me.new_pass_panel = New CuoreUI.Controls.cuiPanelGradient()
        Me.new_pass_txtbox = New CuoreUI.Controls.cuiTextBox()
        Me.new_pass_lbl = New System.Windows.Forms.Label()
        Me.confirm_pass_txtbox = New CuoreUI.Controls.cuiTextBox()
        Me.set_pass_btn = New CuoreUI.Controls.cuiButton()
        Me.new_pass_panel.SuspendLayout()
        Me.SuspendLayout()
        '
        'new_pass_panel
        '
        Me.new_pass_panel.BackColor = System.Drawing.Color.Transparent
        Me.new_pass_panel.Controls.Add(Me.new_pass_txtbox)
        Me.new_pass_panel.Controls.Add(Me.new_pass_lbl)
        Me.new_pass_panel.Controls.Add(Me.confirm_pass_txtbox)
        Me.new_pass_panel.Controls.Add(Me.set_pass_btn)
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
        'new_pass_txtbox
        '
        Me.new_pass_txtbox.BackColor = System.Drawing.Color.Transparent
        Me.new_pass_txtbox.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.new_pass_txtbox.Content = ""
        Me.new_pass_txtbox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.new_pass_txtbox.FocusBackgroundColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.new_pass_txtbox.FocusImageTint = System.Drawing.Color.White
        Me.new_pass_txtbox.FocusOutlineColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.new_pass_txtbox.Font = New System.Drawing.Font("Helvetica", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.new_pass_txtbox.ForeColor = System.Drawing.Color.Black
        Me.new_pass_txtbox.Image = CType(resources.GetObject("new_pass_txtbox.Image"), System.Drawing.Image)
        Me.new_pass_txtbox.ImageExpand = New System.Drawing.Point(4, 4)
        Me.new_pass_txtbox.ImageOffset = New System.Drawing.Point(0, 0)
        Me.new_pass_txtbox.Location = New System.Drawing.Point(64, 147)
        Me.new_pass_txtbox.Margin = New System.Windows.Forms.Padding(4)
        Me.new_pass_txtbox.Multiline = False
        Me.new_pass_txtbox.Name = "new_pass_txtbox"
        Me.new_pass_txtbox.NormalImageTint = System.Drawing.Color.White
        Me.new_pass_txtbox.OutlineColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.new_pass_txtbox.Padding = New System.Windows.Forms.Padding(53, 13, 53, 0)
        Me.new_pass_txtbox.PasswordChar = True
        Me.new_pass_txtbox.PlaceholderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(161, Byte), Integer))
        Me.new_pass_txtbox.PlaceholderText = "New Password"
        Me.new_pass_txtbox.Rounding = New System.Windows.Forms.Padding(12)
        Me.new_pass_txtbox.Size = New System.Drawing.Size(328, 45)
        Me.new_pass_txtbox.TabIndex = 24
        Me.new_pass_txtbox.TextOffset = New System.Drawing.Size(35, 0)
        Me.new_pass_txtbox.UnderlinedStyle = True
        '
        'new_pass_lbl
        '
        Me.new_pass_lbl.BackColor = System.Drawing.Color.Transparent
        Me.new_pass_lbl.Font = New System.Drawing.Font("Helvetica", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.new_pass_lbl.ForeColor = System.Drawing.Color.White
        Me.new_pass_lbl.Location = New System.Drawing.Point(88, 56)
        Me.new_pass_lbl.Name = "new_pass_lbl"
        Me.new_pass_lbl.Size = New System.Drawing.Size(284, 45)
        Me.new_pass_lbl.TabIndex = 23
        Me.new_pass_lbl.Text = "New Password"
        '
        'confirm_pass_txtbox
        '
        Me.confirm_pass_txtbox.BackColor = System.Drawing.Color.Transparent
        Me.confirm_pass_txtbox.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.confirm_pass_txtbox.Content = ""
        Me.confirm_pass_txtbox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.confirm_pass_txtbox.FocusBackgroundColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.confirm_pass_txtbox.FocusImageTint = System.Drawing.Color.White
        Me.confirm_pass_txtbox.FocusOutlineColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.confirm_pass_txtbox.Font = New System.Drawing.Font("Helvetica", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.confirm_pass_txtbox.ForeColor = System.Drawing.Color.Black
        Me.confirm_pass_txtbox.Image = CType(resources.GetObject("confirm_pass_txtbox.Image"), System.Drawing.Image)
        Me.confirm_pass_txtbox.ImageExpand = New System.Drawing.Point(4, 4)
        Me.confirm_pass_txtbox.ImageOffset = New System.Drawing.Point(0, 0)
        Me.confirm_pass_txtbox.Location = New System.Drawing.Point(64, 213)
        Me.confirm_pass_txtbox.Margin = New System.Windows.Forms.Padding(4)
        Me.confirm_pass_txtbox.Multiline = False
        Me.confirm_pass_txtbox.Name = "confirm_pass_txtbox"
        Me.confirm_pass_txtbox.NormalImageTint = System.Drawing.Color.White
        Me.confirm_pass_txtbox.OutlineColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.confirm_pass_txtbox.Padding = New System.Windows.Forms.Padding(53, 13, 53, 0)
        Me.confirm_pass_txtbox.PasswordChar = True
        Me.confirm_pass_txtbox.PlaceholderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(161, Byte), Integer))
        Me.confirm_pass_txtbox.PlaceholderText = "Confirm Password"
        Me.confirm_pass_txtbox.Rounding = New System.Windows.Forms.Padding(12)
        Me.confirm_pass_txtbox.Size = New System.Drawing.Size(328, 45)
        Me.confirm_pass_txtbox.TabIndex = 10
        Me.confirm_pass_txtbox.TextOffset = New System.Drawing.Size(35, 0)
        Me.confirm_pass_txtbox.UnderlinedStyle = True
        '
        'set_pass_btn
        '
        Me.set_pass_btn.CheckButton = False
        Me.set_pass_btn.Checked = False
        Me.set_pass_btn.CheckedBackground = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.set_pass_btn.CheckedForeColor = System.Drawing.Color.White
        Me.set_pass_btn.CheckedImageTint = System.Drawing.Color.White
        Me.set_pass_btn.CheckedOutline = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.set_pass_btn.Content = "Set Password"
        Me.set_pass_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.set_pass_btn.DialogResult = System.Windows.Forms.DialogResult.None
        Me.set_pass_btn.Font = New System.Drawing.Font("Helvetica", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.set_pass_btn.ForeColor = System.Drawing.Color.White
        Me.set_pass_btn.HoverBackground = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.set_pass_btn.HoverForeColor = System.Drawing.Color.White
        Me.set_pass_btn.HoverImageTint = System.Drawing.Color.White
        Me.set_pass_btn.HoverOutline = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.set_pass_btn.Image = Nothing
        'Me.set_pass_btn.ImageAutoCenter = True
        Me.set_pass_btn.ImageExpand = New System.Drawing.Point(0, 0)
        'Me.set_pass_btn.ImageOffset = New System.Drawing.Point(0, 0)
        Me.set_pass_btn.Location = New System.Drawing.Point(64, 293)
        Me.set_pass_btn.Name = "set_pass_btn"
        Me.set_pass_btn.NormalBackground = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(161, Byte), Integer))
        Me.set_pass_btn.NormalForeColor = System.Drawing.Color.White
        Me.set_pass_btn.NormalImageTint = System.Drawing.Color.White
        Me.set_pass_btn.NormalOutline = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(161, Byte), Integer))
        Me.set_pass_btn.OutlineThickness = 1.0!
        Me.set_pass_btn.PressedBackground = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(161, Byte), Integer))
        Me.set_pass_btn.PressedForeColor = System.Drawing.Color.White
        Me.set_pass_btn.PressedImageTint = System.Drawing.Color.White
        Me.set_pass_btn.PressedOutline = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(161, Byte), Integer))
        Me.set_pass_btn.Rounding = New System.Windows.Forms.Padding(12)
        Me.set_pass_btn.Size = New System.Drawing.Size(328, 45)
        Me.set_pass_btn.TabIndex = 15
        Me.set_pass_btn.TextAlignment = System.Drawing.StringAlignment.Center
        'Me.set_pass_btn.TextOffset = New System.Drawing.Point(0, 0)
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

    Friend WithEvents new_pass_panel As CuoreUI.Controls.cuiPanelGradient
    Friend WithEvents confirm_pass_txtbox As CuoreUI.Controls.cuiTextBox
    Friend WithEvents set_pass_btn As CuoreUI.Controls.cuiButton
    Friend WithEvents new_pass_txtbox As CuoreUI.Controls.cuiTextBox
    Friend WithEvents new_pass_lbl As Label
End Class
