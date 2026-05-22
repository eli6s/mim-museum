<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class reports
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(reports))
        Me.inventory_report_btn = New CuoreUI.Controls.cuiButton()
        Me.CuiGradientPanel2 = New CuoreUI.Controls.cuiPanelGradient()
        Me.lbl_revenue_value = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.CuiGradientPanel2.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'inventory_report_btn
        '
        Me.inventory_report_btn.CheckButton = False
        Me.inventory_report_btn.Checked = False
        Me.inventory_report_btn.CheckedBackground = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.inventory_report_btn.CheckedForeColor = System.Drawing.Color.White
        Me.inventory_report_btn.CheckedImageTint = System.Drawing.Color.White
        Me.inventory_report_btn.CheckedOutline = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.inventory_report_btn.Content = "Generate Report"
        Me.inventory_report_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.inventory_report_btn.DialogResult = System.Windows.Forms.DialogResult.None
        Me.inventory_report_btn.Font = New System.Drawing.Font("Helvetica", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.inventory_report_btn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.inventory_report_btn.HoverBackground = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.inventory_report_btn.HoverForeColor = System.Drawing.Color.White
        Me.inventory_report_btn.HoverImageTint = System.Drawing.Color.White
        Me.inventory_report_btn.HoverOutline = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.inventory_report_btn.Image = Nothing
        Me.inventory_report_btn.ImageExpand = New System.Drawing.Point(3, 3)
        Me.inventory_report_btn.ImeMode = System.Windows.Forms.ImeMode.Close
        Me.inventory_report_btn.Location = New System.Drawing.Point(138, 177)
        Me.inventory_report_btn.Name = "inventory_report_btn"
        Me.inventory_report_btn.NormalBackground = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.inventory_report_btn.NormalForeColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.inventory_report_btn.NormalImageTint = System.Drawing.Color.White
        Me.inventory_report_btn.NormalOutline = System.Drawing.Color.Transparent
        Me.inventory_report_btn.OutlineThickness = 1.0!
        Me.inventory_report_btn.Padding = New System.Windows.Forms.Padding(12)
        Me.inventory_report_btn.PressedBackground = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.inventory_report_btn.PressedForeColor = System.Drawing.Color.White
        Me.inventory_report_btn.PressedImageTint = System.Drawing.Color.White
        Me.inventory_report_btn.PressedOutline = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.inventory_report_btn.Rounding = New System.Windows.Forms.Padding(12)
        Me.inventory_report_btn.Size = New System.Drawing.Size(174, 32)
        Me.inventory_report_btn.TabIndex = 111
        Me.inventory_report_btn.TextAlignment = System.Drawing.StringAlignment.Center
        Me.inventory_report_btn.TextPadding = 12
        Me.inventory_report_btn.TextSpacing = 2
        '
        'CuiGradientPanel2
        '
        Me.CuiGradientPanel2.BackColor = System.Drawing.Color.Transparent
        Me.CuiGradientPanel2.Controls.Add(Me.inventory_report_btn)
        Me.CuiGradientPanel2.Controls.Add(Me.lbl_revenue_value)
        Me.CuiGradientPanel2.Controls.Add(Me.PictureBox2)
        Me.CuiGradientPanel2.GradientAngle = 0!
        Me.CuiGradientPanel2.Location = New System.Drawing.Point(935, 366)
        Me.CuiGradientPanel2.Name = "CuiGradientPanel2"
        Me.CuiGradientPanel2.OutlineThickness = 1.0!
        Me.CuiGradientPanel2.PanelColor1 = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.CuiGradientPanel2.PanelColor2 = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.CuiGradientPanel2.PanelOutlineColor1 = System.Drawing.Color.Transparent
        Me.CuiGradientPanel2.PanelOutlineColor2 = System.Drawing.Color.Transparent
        Me.CuiGradientPanel2.Rounding = New System.Windows.Forms.Padding(26)
        Me.CuiGradientPanel2.Size = New System.Drawing.Size(471, 344)
        Me.CuiGradientPanel2.TabIndex = 114
        '
        'lbl_revenue_value
        '
        Me.lbl_revenue_value.BackColor = System.Drawing.Color.Transparent
        Me.lbl_revenue_value.Font = New System.Drawing.Font("Helvetica", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_revenue_value.ForeColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.lbl_revenue_value.Location = New System.Drawing.Point(56, 221)
        Me.lbl_revenue_value.Name = "lbl_revenue_value"
        Me.lbl_revenue_value.Size = New System.Drawing.Size(378, 56)
        Me.lbl_revenue_value.TabIndex = 3
        Me.lbl_revenue_value.Text = "Inventory Snapshot"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(167, 22)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(109, 107)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 2
        Me.PictureBox2.TabStop = False
        '
        'reports
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(166, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Controls.Add(Me.CuiGradientPanel2)
        Me.Name = "reports"
        Me.Size = New System.Drawing.Size(2318, 1177)
        Me.CuiGradientPanel2.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents inventory_report_btn As CuoreUI.Controls.cuiButton
    Friend WithEvents CuiGradientPanel2 As CuoreUI.Controls.cuiPanelGradient
    Friend WithEvents lbl_revenue_value As Label
    Friend WithEvents PictureBox2 As PictureBox
End Class
