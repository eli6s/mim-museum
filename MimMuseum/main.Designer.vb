<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class main
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(main))
        Me.museum_conn = New System.Data.SqlClient.SqlConnection()
        Me.header_pnl = New CuoreUI.Controls.cuiPanel()
        Me.side_nav_pnl = New CuoreUI.Controls.cuiPanel()
        Me.main_pnl = New CuoreUI.Controls.cuiPanel()
        Me.SuspendLayout()
        '
        'museum_conn
        '
        Me.museum_conn.ConnectionString = "Data Source=localhost;Initial Catalog=mim_museum;Integrated Security=True"
        Me.museum_conn.FireInfoMessageEventOnUserErrors = False
        '
        'header_pnl
        '
        Me.header_pnl.Dock = System.Windows.Forms.DockStyle.Top
        Me.header_pnl.Location = New System.Drawing.Point(241, 0)
        Me.header_pnl.Name = "header_pnl"
        Me.header_pnl.OutlineThickness = 1.0!
        Me.header_pnl.PanelColor = System.Drawing.Color.FromArgb(CType(CType(166, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.header_pnl.PanelOutlineColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.header_pnl.Rounding = New System.Windows.Forms.Padding(8)
        Me.header_pnl.Size = New System.Drawing.Size(2319, 149)
        Me.header_pnl.TabIndex = 0
        Me.header_pnl.Visible = False
        '
        'side_nav_pnl
        '
        Me.side_nav_pnl.Dock = System.Windows.Forms.DockStyle.Left
        Me.side_nav_pnl.Location = New System.Drawing.Point(0, 0)
        Me.side_nav_pnl.Name = "side_nav_pnl"
        Me.side_nav_pnl.OutlineThickness = 1.0!
        Me.side_nav_pnl.PanelColor = System.Drawing.Color.FromArgb(CType(CType(166, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.side_nav_pnl.PanelOutlineColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.side_nav_pnl.Rounding = New System.Windows.Forms.Padding(8)
        Me.side_nav_pnl.Size = New System.Drawing.Size(241, 1440)
        Me.side_nav_pnl.TabIndex = 1
        Me.side_nav_pnl.Visible = False
        '
        'main_pnl
        '
        Me.main_pnl.Location = New System.Drawing.Point(241, 149)
        Me.main_pnl.Name = "main_pnl"
        Me.main_pnl.OutlineThickness = 1.0!
        Me.main_pnl.PanelColor = System.Drawing.Color.FromArgb(CType(CType(166, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.main_pnl.PanelOutlineColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.main_pnl.Rounding = New System.Windows.Forms.Padding(8)
        Me.main_pnl.Size = New System.Drawing.Size(2318, 1291)
        Me.main_pnl.TabIndex = 2
        Me.main_pnl.Visible = False
        '
        'main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(166, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(2560, 1440)
        Me.Controls.Add(Me.header_pnl)
        Me.Controls.Add(Me.side_nav_pnl)
        Me.Controls.Add(Me.main_pnl)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MinimumSize = New System.Drawing.Size(261, 65)
        Me.Name = "main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents museum_conn As SqlClient.SqlConnection
    Friend WithEvents header_pnl As CuoreUI.Controls.cuiPanel
    Friend WithEvents side_nav_pnl As CuoreUI.Controls.cuiPanel
    Friend WithEvents main_pnl As CuoreUI.Controls.cuiPanel
End Class
