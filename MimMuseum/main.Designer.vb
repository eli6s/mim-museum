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
        Me.pagination_pnl = New CuoreUI.Controls.cuiPanel()
        Me.CuiButton2 = New CuoreUI.Controls.cuiButton()
        Me.search_btn = New CuoreUI.Controls.cuiButton()
        Me.pagination_pnl.SuspendLayout()
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
        Me.main_pnl.Size = New System.Drawing.Size(2318, 1177)
        Me.main_pnl.TabIndex = 2
        Me.main_pnl.Visible = False
        '
        'pagination_pnl
        '
        Me.pagination_pnl.Controls.Add(Me.CuiButton2)
        Me.pagination_pnl.Controls.Add(Me.search_btn)
        Me.pagination_pnl.Location = New System.Drawing.Point(241, 1325)
        Me.pagination_pnl.Name = "pagination_pnl"
        Me.pagination_pnl.OutlineThickness = 1.0!
        Me.pagination_pnl.PanelColor = System.Drawing.Color.FromArgb(CType(CType(166, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.pagination_pnl.PanelOutlineColor = System.Drawing.Color.Transparent
        Me.pagination_pnl.Rounding = New System.Windows.Forms.Padding(8)
        Me.pagination_pnl.Size = New System.Drawing.Size(2318, 117)
        Me.pagination_pnl.TabIndex = 3
        Me.pagination_pnl.Visible = False
        '
        'CuiButton2
        '
        Me.CuiButton2.CheckButton = False
        Me.CuiButton2.Checked = False
        Me.CuiButton2.CheckedBackground = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.CuiButton2.CheckedForeColor = System.Drawing.Color.White
        Me.CuiButton2.CheckedImageTint = System.Drawing.Color.White
        Me.CuiButton2.CheckedOutline = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.CuiButton2.Content = "Previous"
        Me.CuiButton2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CuiButton2.DialogResult = System.Windows.Forms.DialogResult.None
        Me.CuiButton2.Font = New System.Drawing.Font("Helvetica", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CuiButton2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.CuiButton2.HoverBackground = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(161, Byte), Integer))
        Me.CuiButton2.HoverForeColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.CuiButton2.HoverImageTint = System.Drawing.Color.White
        Me.CuiButton2.HoverOutline = System.Drawing.Color.Transparent
        Me.CuiButton2.Image = Nothing
        Me.CuiButton2.ImageExpand = New System.Drawing.Point(3, 3)
        Me.CuiButton2.ImeMode = System.Windows.Forms.ImeMode.Close
        Me.CuiButton2.Location = New System.Drawing.Point(1165, 30)
        Me.CuiButton2.Name = "CuiButton2"
        Me.CuiButton2.NormalBackground = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.CuiButton2.NormalForeColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.CuiButton2.NormalImageTint = System.Drawing.Color.White
        Me.CuiButton2.NormalOutline = System.Drawing.Color.Transparent
        Me.CuiButton2.OutlineThickness = 1.0!
        Me.CuiButton2.Padding = New System.Windows.Forms.Padding(12)
        Me.CuiButton2.PressedBackground = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.CuiButton2.PressedForeColor = System.Drawing.Color.White
        Me.CuiButton2.PressedImageTint = System.Drawing.Color.White
        Me.CuiButton2.PressedOutline = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.CuiButton2.Rounding = New System.Windows.Forms.Padding(12)
        Me.CuiButton2.Size = New System.Drawing.Size(166, 49)
        Me.CuiButton2.TabIndex = 19
        Me.CuiButton2.TextAlignment = System.Drawing.StringAlignment.Center
        Me.CuiButton2.TextPadding = 12
        Me.CuiButton2.TextSpacing = 2
        '
        'search_btn
        '
        Me.search_btn.CheckButton = False
        Me.search_btn.Checked = False
        Me.search_btn.CheckedBackground = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.search_btn.CheckedForeColor = System.Drawing.Color.White
        Me.search_btn.CheckedImageTint = System.Drawing.Color.White
        Me.search_btn.CheckedOutline = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.search_btn.Content = "Next"
        Me.search_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.search_btn.DialogResult = System.Windows.Forms.DialogResult.None
        Me.search_btn.Font = New System.Drawing.Font("Helvetica", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.search_btn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.search_btn.HoverBackground = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(161, Byte), Integer))
        Me.search_btn.HoverForeColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.search_btn.HoverImageTint = System.Drawing.Color.White
        Me.search_btn.HoverOutline = System.Drawing.Color.Transparent
        Me.search_btn.Image = Nothing
        Me.search_btn.ImageExpand = New System.Drawing.Point(3, 3)
        Me.search_btn.ImeMode = System.Windows.Forms.ImeMode.Close
        Me.search_btn.Location = New System.Drawing.Point(942, 30)
        Me.search_btn.Name = "search_btn"
        Me.search_btn.NormalBackground = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.search_btn.NormalForeColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.search_btn.NormalImageTint = System.Drawing.Color.White
        Me.search_btn.NormalOutline = System.Drawing.Color.Transparent
        Me.search_btn.OutlineThickness = 1.0!
        Me.search_btn.Padding = New System.Windows.Forms.Padding(12)
        Me.search_btn.PressedBackground = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.search_btn.PressedForeColor = System.Drawing.Color.White
        Me.search_btn.PressedImageTint = System.Drawing.Color.White
        Me.search_btn.PressedOutline = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.search_btn.Rounding = New System.Windows.Forms.Padding(12)
        Me.search_btn.Size = New System.Drawing.Size(166, 49)
        Me.search_btn.TabIndex = 18
        Me.search_btn.TextAlignment = System.Drawing.StringAlignment.Center
        Me.search_btn.TextPadding = 12
        Me.search_btn.TextSpacing = 2
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
        Me.Controls.Add(Me.pagination_pnl)
        Me.Controls.Add(Me.main_pnl)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MinimumSize = New System.Drawing.Size(261, 65)
        Me.Name = "main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.pagination_pnl.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents museum_conn As SqlClient.SqlConnection
    Friend WithEvents header_pnl As CuoreUI.Controls.cuiPanel
    Friend WithEvents side_nav_pnl As CuoreUI.Controls.cuiPanel
    Friend WithEvents main_pnl As CuoreUI.Controls.cuiPanel
    Friend WithEvents pagination_pnl As CuoreUI.Controls.cuiPanel
    Friend WithEvents CuiButton2 As CuoreUI.Controls.cuiButton
    Friend WithEvents search_btn As CuoreUI.Controls.cuiButton
End Class
