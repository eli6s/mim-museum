<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class header
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(header))
        Me.header_core_pnl = New CuoreUI.Controls.cuiPanelGradient()
        Me.clock = New ReaLTaiizor.Controls.ParrotClock()
        Me.breadcrumb_btn = New CuoreUI.Controls.cuiButton()
        Me.position_lbl = New System.Windows.Forms.Label()
        Me.session_username_lbl = New System.Windows.Forms.Label()
        Me.session_pfp = New System.Windows.Forms.PictureBox()
        Me.header_core_pnl.SuspendLayout()
        CType(Me.session_pfp, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'header_core_pnl
        '
        Me.header_core_pnl.BackColor = System.Drawing.Color.Transparent
        Me.header_core_pnl.Controls.Add(Me.clock)
        Me.header_core_pnl.Controls.Add(Me.breadcrumb_btn)
        Me.header_core_pnl.Controls.Add(Me.position_lbl)
        Me.header_core_pnl.Controls.Add(Me.session_username_lbl)
        Me.header_core_pnl.Controls.Add(Me.session_pfp)
        Me.header_core_pnl.GradientAngle = 0!
        Me.header_core_pnl.Location = New System.Drawing.Point(-12, 0)
        Me.header_core_pnl.Name = "header_core_pnl"
        Me.header_core_pnl.OutlineThickness = 1.0!
        Me.header_core_pnl.PanelColor1 = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.header_core_pnl.PanelColor2 = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.header_core_pnl.PanelOutlineColor1 = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.header_core_pnl.PanelOutlineColor2 = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.header_core_pnl.Rounding = New System.Windows.Forms.Padding(8)
        Me.header_core_pnl.Size = New System.Drawing.Size(2332, 149)
        Me.header_core_pnl.TabIndex = 0
        '
        'clock
        '
        Me.clock.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.clock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.clock.CircleThickness = 6
        Me.clock.CompositingQualityType = System.Drawing.Drawing2D.CompositingQuality.HighQuality
        Me.clock.DisplayFormat = ReaLTaiizor.Controls.ParrotClock.HourFormat.TwelveHour
        Me.clock.FilledHourColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.clock.FilledMinuteColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.clock.FilledSecondColor = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.clock.Font = New System.Drawing.Font("Impact", 15.0!)
        Me.clock.HexagonColor = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.clock.InterpolationType = System.Drawing.Drawing2D.InterpolationMode.HighQualityBilinear
        Me.clock.Location = New System.Drawing.Point(1165, 18)
        Me.clock.Name = "clock"
        Me.clock.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality
        Me.clock.ShowAmPm = True
        Me.clock.ShowHexagon = False
        Me.clock.ShowMinutesCircle = True
        Me.clock.ShowSecondsCircle = True
        Me.clock.Size = New System.Drawing.Size(133, 116)
        Me.clock.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias
        Me.clock.TabIndex = 21
        Me.clock.Text = "ParrotClock1"
        Me.clock.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit
        Me.clock.TimeAMFormat = "hh:mm"
        Me.clock.TimeColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.clock.TimePMFormat = "HH:mm"
        Me.clock.UnfilledHourColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.clock.UnfilledMinuteColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.clock.UnfilledSecondColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer))
        '
        'breadcrumb_btn
        '
        Me.breadcrumb_btn.CheckButton = False
        Me.breadcrumb_btn.Checked = False
        Me.breadcrumb_btn.CheckedBackground = System.Drawing.Color.Transparent
        Me.breadcrumb_btn.CheckedForeColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.breadcrumb_btn.CheckedImageTint = System.Drawing.Color.White
        Me.breadcrumb_btn.CheckedOutline = System.Drawing.Color.Transparent
        Me.breadcrumb_btn.Content = "Path Here"
        Me.breadcrumb_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.breadcrumb_btn.DialogResult = System.Windows.Forms.DialogResult.None
        Me.breadcrumb_btn.Enabled = False
        Me.breadcrumb_btn.Font = New System.Drawing.Font("Helvetica", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.breadcrumb_btn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.breadcrumb_btn.HoverBackground = System.Drawing.Color.Transparent
        Me.breadcrumb_btn.HoverForeColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.breadcrumb_btn.HoverImageTint = System.Drawing.Color.White
        Me.breadcrumb_btn.HoverOutline = System.Drawing.Color.Transparent
        Me.breadcrumb_btn.Image = Nothing
        Me.breadcrumb_btn.ImageExpand = New System.Drawing.Point(3, 3)
        Me.breadcrumb_btn.Location = New System.Drawing.Point(199, 41)
        Me.breadcrumb_btn.Name = "breadcrumb_btn"
        Me.breadcrumb_btn.NormalBackground = System.Drawing.Color.Transparent
        Me.breadcrumb_btn.NormalForeColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.breadcrumb_btn.NormalImageTint = System.Drawing.Color.White
        Me.breadcrumb_btn.NormalOutline = System.Drawing.Color.Transparent
        Me.breadcrumb_btn.OutlineThickness = 1.0!
        Me.breadcrumb_btn.Padding = New System.Windows.Forms.Padding(12)
        Me.breadcrumb_btn.PressedBackground = System.Drawing.Color.Transparent
        Me.breadcrumb_btn.PressedForeColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.breadcrumb_btn.PressedImageTint = System.Drawing.Color.White
        Me.breadcrumb_btn.PressedOutline = System.Drawing.Color.Transparent
        Me.breadcrumb_btn.Rounding = New System.Windows.Forms.Padding(8)
        Me.breadcrumb_btn.Size = New System.Drawing.Size(468, 58)
        Me.breadcrumb_btn.TabIndex = 20
        Me.breadcrumb_btn.Tag = ""
        Me.breadcrumb_btn.TextAlignment = System.Drawing.StringAlignment.Near
        Me.breadcrumb_btn.TextPadding = 12
        Me.breadcrumb_btn.TextSpacing = 2
        '
        'position_lbl
        '
        Me.position_lbl.BackColor = System.Drawing.Color.Transparent
        Me.position_lbl.Font = New System.Drawing.Font("Helvetica", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.position_lbl.ForeColor = System.Drawing.Color.DarkGray
        Me.position_lbl.Location = New System.Drawing.Point(2039, 78)
        Me.position_lbl.Name = "position_lbl"
        Me.position_lbl.Size = New System.Drawing.Size(230, 30)
        Me.position_lbl.TabIndex = 18
        Me.position_lbl.Text = "Position Title"
        '
        'session_username_lbl
        '
        Me.session_username_lbl.BackColor = System.Drawing.Color.Transparent
        Me.session_username_lbl.Font = New System.Drawing.Font("Helvetica", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.session_username_lbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.session_username_lbl.Location = New System.Drawing.Point(2037, 35)
        Me.session_username_lbl.Name = "session_username_lbl"
        Me.session_username_lbl.Size = New System.Drawing.Size(278, 43)
        Me.session_username_lbl.TabIndex = 17
        Me.session_username_lbl.Text = "session username"
        '
        'session_pfp
        '
        Me.session_pfp.BackgroundImage = CType(resources.GetObject("session_pfp.BackgroundImage"), System.Drawing.Image)
        Me.session_pfp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.session_pfp.Location = New System.Drawing.Point(1960, 35)
        Me.session_pfp.Name = "session_pfp"
        Me.session_pfp.Size = New System.Drawing.Size(71, 64)
        Me.session_pfp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.session_pfp.TabIndex = 1
        Me.session_pfp.TabStop = False
        '
        'header
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.header_core_pnl)
        Me.Name = "header"
        Me.Size = New System.Drawing.Size(2332, 149)
        Me.header_core_pnl.ResumeLayout(False)
        CType(Me.session_pfp, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents header_core_pnl As CuoreUI.Controls.cuiPanelGradient
    Friend WithEvents session_pfp As PictureBox
    Friend WithEvents session_username_lbl As Label
    Friend WithEvents position_lbl As Label
    Friend WithEvents breadcrumb_btn As CuoreUI.Controls.cuiButton
    Friend WithEvents clock As ReaLTaiizor.Controls.ParrotClock
End Class
