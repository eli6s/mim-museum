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
        Me.CuiGradientPanel1 = New CuoreUI.Controls.cuiGradientPanel()
        Me.path_lbl = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.session_username_lbl = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.CuiGradientPanel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CuiGradientPanel1
        '
        Me.CuiGradientPanel1.BackColor = System.Drawing.Color.Transparent
        Me.CuiGradientPanel1.Controls.Add(Me.path_lbl)
        Me.CuiGradientPanel1.Controls.Add(Me.Label1)
        Me.CuiGradientPanel1.Controls.Add(Me.session_username_lbl)
        Me.CuiGradientPanel1.Controls.Add(Me.PictureBox1)
        Me.CuiGradientPanel1.GradientAngle = 0!
        Me.CuiGradientPanel1.Location = New System.Drawing.Point(-12, 0)
        Me.CuiGradientPanel1.Name = "CuiGradientPanel1"
        Me.CuiGradientPanel1.OutlineThickness = 1.0!
        Me.CuiGradientPanel1.PanelColor1 = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.CuiGradientPanel1.PanelColor2 = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.CuiGradientPanel1.PanelOutlineColor1 = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.CuiGradientPanel1.PanelOutlineColor2 = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.CuiGradientPanel1.Rounding = New System.Windows.Forms.Padding(8)
        Me.CuiGradientPanel1.Size = New System.Drawing.Size(2600, 149)
        Me.CuiGradientPanel1.TabIndex = 0
        '
        'path_lbl
        '
        Me.path_lbl.BackColor = System.Drawing.Color.Transparent
        Me.path_lbl.Font = New System.Drawing.Font("Helvetica", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.path_lbl.ForeColor = System.Drawing.Color.White
        Me.path_lbl.Location = New System.Drawing.Point(470, 52)
        Me.path_lbl.Name = "path_lbl"
        Me.path_lbl.Size = New System.Drawing.Size(477, 60)
        Me.path_lbl.TabIndex = 19
        Me.path_lbl.Text = "Museum | Minerals"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Helvetica", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkGray
        Me.Label1.Location = New System.Drawing.Point(2346, 74)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(230, 30)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Manager"
        '
        'session_username_lbl
        '
        Me.session_username_lbl.BackColor = System.Drawing.Color.Transparent
        Me.session_username_lbl.Font = New System.Drawing.Font("Helvetica", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.session_username_lbl.ForeColor = System.Drawing.Color.White
        Me.session_username_lbl.Location = New System.Drawing.Point(2344, 31)
        Me.session_username_lbl.Name = "session_username_lbl"
        Me.session_username_lbl.Size = New System.Drawing.Size(242, 43)
        Me.session_username_lbl.TabIndex = 17
        Me.session_username_lbl.Text = "session username"
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(2256, 31)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(71, 64)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'header
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.CuiGradientPanel1)
        Me.Name = "header"
        Me.Size = New System.Drawing.Size(3500, 149)
        Me.CuiGradientPanel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents CuiGradientPanel1 As CuoreUI.Controls.cuiGradientPanel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents session_username_lbl As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents path_lbl As Label
End Class
