<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class museum_dashboard
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(museum_dashboard))
        Dim DataGridViewCellStyle21 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle22 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle23 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle24 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.lbl_minerals_value = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CuiGradientPanel2 = New CuoreUI.Controls.cuiPanelGradient()
        Me.lbl_minerals_delta = New System.Windows.Forms.Label()
        Me.lbl_minerals_sub = New System.Windows.Forms.Label()
        Me.MaterialDivider2 = New ReaLTaiizor.Controls.MaterialDivider()
        Me.CuiGradientPanel1 = New CuoreUI.Controls.cuiPanelGradient()
        Me.lbl_donations_delta = New System.Windows.Forms.Label()
        Me.lbl_donations_sub = New System.Windows.Forms.Label()
        Me.MaterialDivider1 = New ReaLTaiizor.Controls.MaterialDivider()
        Me.lbl_donations_value = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.top_donors_grid = New MetroFramework.Controls.MetroGrid()
        Me.section_piechart_pnl = New CuoreUI.Controls.cuiPanel()
        Me.CuiLabel5 = New CuoreUI.Controls.cuiLabel()
        Me.CuiPanelGradient1 = New CuoreUI.Controls.cuiPanelGradient()
        Me.lbl_events_delta = New System.Windows.Forms.Label()
        Me.lbl_events_sub = New System.Windows.Forms.Label()
        Me.MaterialDivider3 = New ReaLTaiizor.Controls.MaterialDivider()
        Me.lbl_events_value = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.CuiPanelGradient2 = New CuoreUI.Controls.cuiPanelGradient()
        Me.lbl_guests_delta = New System.Windows.Forms.Label()
        Me.lbl_guests_sub = New System.Windows.Forms.Label()
        Me.MaterialDivider4 = New ReaLTaiizor.Controls.MaterialDivider()
        Me.lbl_guests_value = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CuiGradientPanel2.SuspendLayout()
        Me.CuiGradientPanel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.top_donors_grid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CuiPanelGradient1.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CuiPanelGradient2.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_minerals_value
        '
        Me.lbl_minerals_value.BackColor = System.Drawing.Color.Transparent
        Me.lbl_minerals_value.Font = New System.Drawing.Font("Helvetica", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_minerals_value.ForeColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.lbl_minerals_value.Location = New System.Drawing.Point(40, 148)
        Me.lbl_minerals_value.Name = "lbl_minerals_value"
        Me.lbl_minerals_value.Size = New System.Drawing.Size(285, 56)
        Me.lbl_minerals_value.TabIndex = 3
        Me.lbl_minerals_value.Text = "0"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(50, 22)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(69, 60)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 2
        Me.PictureBox2.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Helvetica", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(44, 110)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(146, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "TOTAL MINERALS"
        '
        'CuiGradientPanel2
        '
        Me.CuiGradientPanel2.BackColor = System.Drawing.Color.Transparent
        Me.CuiGradientPanel2.Controls.Add(Me.lbl_minerals_delta)
        Me.CuiGradientPanel2.Controls.Add(Me.lbl_minerals_sub)
        Me.CuiGradientPanel2.Controls.Add(Me.MaterialDivider2)
        Me.CuiGradientPanel2.Controls.Add(Me.lbl_minerals_value)
        Me.CuiGradientPanel2.Controls.Add(Me.Label1)
        Me.CuiGradientPanel2.Controls.Add(Me.PictureBox2)
        Me.CuiGradientPanel2.GradientAngle = 0!
        Me.CuiGradientPanel2.Location = New System.Drawing.Point(42, 72)
        Me.CuiGradientPanel2.Name = "CuiGradientPanel2"
        Me.CuiGradientPanel2.OutlineThickness = 1.0!
        Me.CuiGradientPanel2.PanelColor1 = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.CuiGradientPanel2.PanelColor2 = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.CuiGradientPanel2.PanelOutlineColor1 = System.Drawing.Color.Transparent
        Me.CuiGradientPanel2.PanelOutlineColor2 = System.Drawing.Color.Transparent
        Me.CuiGradientPanel2.Rounding = New System.Windows.Forms.Padding(26)
        Me.CuiGradientPanel2.Size = New System.Drawing.Size(471, 344)
        Me.CuiGradientPanel2.TabIndex = 4
        '
        'lbl_minerals_delta
        '
        Me.lbl_minerals_delta.Font = New System.Drawing.Font("Helvetica", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_minerals_delta.ForeColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.lbl_minerals_delta.Location = New System.Drawing.Point(46, 300)
        Me.lbl_minerals_delta.Name = "lbl_minerals_delta"
        Me.lbl_minerals_delta.Size = New System.Drawing.Size(397, 19)
        Me.lbl_minerals_delta.TabIndex = 15
        Me.lbl_minerals_delta.Text = "N/A"
        '
        'lbl_minerals_sub
        '
        Me.lbl_minerals_sub.AutoSize = True
        Me.lbl_minerals_sub.Font = New System.Drawing.Font("Helvetica", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_minerals_sub.ForeColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.lbl_minerals_sub.Location = New System.Drawing.Point(44, 222)
        Me.lbl_minerals_sub.Name = "lbl_minerals_sub"
        Me.lbl_minerals_sub.Size = New System.Drawing.Size(36, 19)
        Me.lbl_minerals_sub.TabIndex = 14
        Me.lbl_minerals_sub.Text = "N/A"
        '
        'MaterialDivider2
        '
        Me.MaterialDivider2.BackColor = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.MaterialDivider2.Depth = 0
        Me.MaterialDivider2.Location = New System.Drawing.Point(3, 275)
        Me.MaterialDivider2.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER
        Me.MaterialDivider2.Name = "MaterialDivider2"
        Me.MaterialDivider2.Size = New System.Drawing.Size(470, 2)
        Me.MaterialDivider2.TabIndex = 13
        Me.MaterialDivider2.Text = "MaterialDivider2"
        '
        'CuiGradientPanel1
        '
        Me.CuiGradientPanel1.BackColor = System.Drawing.Color.Transparent
        Me.CuiGradientPanel1.Controls.Add(Me.lbl_donations_delta)
        Me.CuiGradientPanel1.Controls.Add(Me.lbl_donations_sub)
        Me.CuiGradientPanel1.Controls.Add(Me.MaterialDivider1)
        Me.CuiGradientPanel1.Controls.Add(Me.lbl_donations_value)
        Me.CuiGradientPanel1.Controls.Add(Me.Label12)
        Me.CuiGradientPanel1.Controls.Add(Me.PictureBox1)
        Me.CuiGradientPanel1.GradientAngle = 0!
        Me.CuiGradientPanel1.Location = New System.Drawing.Point(636, 72)
        Me.CuiGradientPanel1.Name = "CuiGradientPanel1"
        Me.CuiGradientPanel1.OutlineThickness = 1.0!
        Me.CuiGradientPanel1.PanelColor1 = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.CuiGradientPanel1.PanelColor2 = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.CuiGradientPanel1.PanelOutlineColor1 = System.Drawing.Color.Transparent
        Me.CuiGradientPanel1.PanelOutlineColor2 = System.Drawing.Color.Transparent
        Me.CuiGradientPanel1.Rounding = New System.Windows.Forms.Padding(26)
        Me.CuiGradientPanel1.Size = New System.Drawing.Size(471, 344)
        Me.CuiGradientPanel1.TabIndex = 27
        '
        'lbl_donations_delta
        '
        Me.lbl_donations_delta.Font = New System.Drawing.Font("Helvetica", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_donations_delta.ForeColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.lbl_donations_delta.Location = New System.Drawing.Point(43, 302)
        Me.lbl_donations_delta.Name = "lbl_donations_delta"
        Me.lbl_donations_delta.Size = New System.Drawing.Size(404, 19)
        Me.lbl_donations_delta.TabIndex = 21
        Me.lbl_donations_delta.Text = "N/A"
        '
        'lbl_donations_sub
        '
        Me.lbl_donations_sub.AutoSize = True
        Me.lbl_donations_sub.Font = New System.Drawing.Font("Helvetica", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_donations_sub.ForeColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.lbl_donations_sub.Location = New System.Drawing.Point(43, 222)
        Me.lbl_donations_sub.Name = "lbl_donations_sub"
        Me.lbl_donations_sub.Size = New System.Drawing.Size(36, 19)
        Me.lbl_donations_sub.TabIndex = 20
        Me.lbl_donations_sub.Text = "N/A"
        '
        'MaterialDivider1
        '
        Me.MaterialDivider1.BackColor = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.MaterialDivider1.Depth = 0
        Me.MaterialDivider1.Location = New System.Drawing.Point(0, 277)
        Me.MaterialDivider1.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER
        Me.MaterialDivider1.Name = "MaterialDivider1"
        Me.MaterialDivider1.Size = New System.Drawing.Size(470, 2)
        Me.MaterialDivider1.TabIndex = 19
        Me.MaterialDivider1.Text = "MaterialDivider1"
        '
        'lbl_donations_value
        '
        Me.lbl_donations_value.BackColor = System.Drawing.Color.Transparent
        Me.lbl_donations_value.Font = New System.Drawing.Font("Helvetica", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_donations_value.ForeColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.lbl_donations_value.Location = New System.Drawing.Point(37, 150)
        Me.lbl_donations_value.Name = "lbl_donations_value"
        Me.lbl_donations_value.Size = New System.Drawing.Size(285, 56)
        Me.lbl_donations_value.TabIndex = 18
        Me.lbl_donations_value.Text = "0"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Helvetica", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.Label12.Location = New System.Drawing.Point(41, 112)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(158, 19)
        Me.Label12.TabIndex = 16
        Me.Label12.Text = "TOTAL DONATIONS"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(47, 24)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(69, 60)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 17
        Me.PictureBox1.TabStop = False
        '
        'top_donors_grid
        '
        Me.top_donors_grid.AllowUserToAddRows = False
        Me.top_donors_grid.AllowUserToDeleteRows = False
        Me.top_donors_grid.AllowUserToResizeColumns = False
        Me.top_donors_grid.AllowUserToResizeRows = False
        Me.top_donors_grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.top_donors_grid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.top_donors_grid.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.top_donors_grid.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.top_donors_grid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenHorizontal
        Me.top_donors_grid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle21.BackColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(84, Byte), Integer))
        DataGridViewCellStyle21.Font = New System.Drawing.Font("Helvetica", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle21.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle21.Padding = New System.Windows.Forms.Padding(10, 0, 10, 0)
        DataGridViewCellStyle21.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(84, Byte), Integer))
        DataGridViewCellStyle21.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle21.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.top_donors_grid.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle21
        Me.top_donors_grid.ColumnHeadersHeight = 70
        Me.top_donors_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle22.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle22.Font = New System.Drawing.Font("Helvetica", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle22.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
        DataGridViewCellStyle22.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle22.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle22.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.top_donors_grid.DefaultCellStyle = DataGridViewCellStyle22
        Me.top_donors_grid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2
        Me.top_donors_grid.EnableHeadersVisualStyles = False
        Me.top_donors_grid.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.top_donors_grid.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.top_donors_grid.Location = New System.Drawing.Point(42, 574)
        Me.top_donors_grid.Name = "top_donors_grid"
        Me.top_donors_grid.ReadOnly = True
        Me.top_donors_grid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle23.BackColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(217, Byte), Integer))
        DataGridViewCellStyle23.Font = New System.Drawing.Font("Helvetica", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle23.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle23.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(250, Byte), Integer))
        DataGridViewCellStyle23.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.top_donors_grid.RowHeadersDefaultCellStyle = DataGridViewCellStyle23
        Me.top_donors_grid.RowHeadersVisible = False
        Me.top_donors_grid.RowHeadersWidth = 50
        Me.top_donors_grid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle24.BackColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(217, Byte), Integer))
        DataGridViewCellStyle24.Font = New System.Drawing.Font("Helvetica", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle24.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle24.Padding = New System.Windows.Forms.Padding(0, 15, 0, 20)
        DataGridViewCellStyle24.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(250, Byte), Integer))
        DataGridViewCellStyle24.SelectionForeColor = System.Drawing.Color.White
        Me.top_donors_grid.RowsDefaultCellStyle = DataGridViewCellStyle24
        Me.top_donors_grid.RowTemplate.Height = 42
        Me.top_donors_grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.top_donors_grid.Size = New System.Drawing.Size(1041, 559)
        Me.top_donors_grid.TabIndex = 30
        '
        'section_piechart_pnl
        '
        Me.section_piechart_pnl.Location = New System.Drawing.Point(1105, 473)
        Me.section_piechart_pnl.Name = "section_piechart_pnl"
        Me.section_piechart_pnl.OutlineThickness = 1.0!
        Me.section_piechart_pnl.PanelColor = System.Drawing.Color.FromArgb(CType(CType(166, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.section_piechart_pnl.PanelOutlineColor = System.Drawing.Color.Transparent
        Me.section_piechart_pnl.Rounding = New System.Windows.Forms.Padding(8)
        Me.section_piechart_pnl.Size = New System.Drawing.Size(1167, 660)
        Me.section_piechart_pnl.TabIndex = 19
        '
        'CuiLabel5
        '
        Me.CuiLabel5.BackColor = System.Drawing.Color.Transparent
        Me.CuiLabel5.Content = "Top\ 7\ Donors"
        Me.CuiLabel5.Font = New System.Drawing.Font("Helvetica", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CuiLabel5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.CuiLabel5.HorizontalAlignment = System.Drawing.StringAlignment.Center
        Me.CuiLabel5.Location = New System.Drawing.Point(323, 487)
        Me.CuiLabel5.Name = "CuiLabel5"
        Me.CuiLabel5.Size = New System.Drawing.Size(473, 47)
        Me.CuiLabel5.TabIndex = 87
        Me.CuiLabel5.VerticalAlignment = System.Drawing.StringAlignment.Near
        '
        'CuiPanelGradient1
        '
        Me.CuiPanelGradient1.BackColor = System.Drawing.Color.Transparent
        Me.CuiPanelGradient1.Controls.Add(Me.lbl_events_delta)
        Me.CuiPanelGradient1.Controls.Add(Me.lbl_events_sub)
        Me.CuiPanelGradient1.Controls.Add(Me.MaterialDivider3)
        Me.CuiPanelGradient1.Controls.Add(Me.lbl_events_value)
        Me.CuiPanelGradient1.Controls.Add(Me.Label14)
        Me.CuiPanelGradient1.Controls.Add(Me.PictureBox3)
        Me.CuiPanelGradient1.GradientAngle = 0!
        Me.CuiPanelGradient1.Location = New System.Drawing.Point(1234, 72)
        Me.CuiPanelGradient1.Name = "CuiPanelGradient1"
        Me.CuiPanelGradient1.OutlineThickness = 1.0!
        Me.CuiPanelGradient1.PanelColor1 = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.CuiPanelGradient1.PanelColor2 = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.CuiPanelGradient1.PanelOutlineColor1 = System.Drawing.Color.Transparent
        Me.CuiPanelGradient1.PanelOutlineColor2 = System.Drawing.Color.Transparent
        Me.CuiPanelGradient1.Rounding = New System.Windows.Forms.Padding(26)
        Me.CuiPanelGradient1.Size = New System.Drawing.Size(471, 344)
        Me.CuiPanelGradient1.TabIndex = 88
        '
        'lbl_events_delta
        '
        Me.lbl_events_delta.Font = New System.Drawing.Font("Helvetica", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_events_delta.ForeColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.lbl_events_delta.Location = New System.Drawing.Point(47, 302)
        Me.lbl_events_delta.Name = "lbl_events_delta"
        Me.lbl_events_delta.Size = New System.Drawing.Size(400, 19)
        Me.lbl_events_delta.TabIndex = 27
        Me.lbl_events_delta.Text = "N/A"
        '
        'lbl_events_sub
        '
        Me.lbl_events_sub.AutoSize = True
        Me.lbl_events_sub.Font = New System.Drawing.Font("Helvetica", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_events_sub.ForeColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.lbl_events_sub.Location = New System.Drawing.Point(47, 222)
        Me.lbl_events_sub.Name = "lbl_events_sub"
        Me.lbl_events_sub.Size = New System.Drawing.Size(36, 19)
        Me.lbl_events_sub.TabIndex = 26
        Me.lbl_events_sub.Text = "N/A"
        '
        'MaterialDivider3
        '
        Me.MaterialDivider3.BackColor = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.MaterialDivider3.Depth = 0
        Me.MaterialDivider3.Location = New System.Drawing.Point(4, 277)
        Me.MaterialDivider3.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER
        Me.MaterialDivider3.Name = "MaterialDivider3"
        Me.MaterialDivider3.Size = New System.Drawing.Size(470, 2)
        Me.MaterialDivider3.TabIndex = 25
        Me.MaterialDivider3.Text = "MaterialDivider3"
        '
        'lbl_events_value
        '
        Me.lbl_events_value.BackColor = System.Drawing.Color.Transparent
        Me.lbl_events_value.Font = New System.Drawing.Font("Helvetica", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_events_value.ForeColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.lbl_events_value.Location = New System.Drawing.Point(41, 150)
        Me.lbl_events_value.Name = "lbl_events_value"
        Me.lbl_events_value.Size = New System.Drawing.Size(285, 56)
        Me.lbl_events_value.TabIndex = 24
        Me.lbl_events_value.Text = "0"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Helvetica", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.Label14.Location = New System.Drawing.Point(45, 112)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(167, 19)
        Me.Label14.TabIndex = 22
        Me.Label14.Text = "UPCOMING EVENTS"
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(51, 24)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(69, 60)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 23
        Me.PictureBox3.TabStop = False
        '
        'CuiPanelGradient2
        '
        Me.CuiPanelGradient2.BackColor = System.Drawing.Color.Transparent
        Me.CuiPanelGradient2.Controls.Add(Me.lbl_guests_delta)
        Me.CuiPanelGradient2.Controls.Add(Me.lbl_guests_sub)
        Me.CuiPanelGradient2.Controls.Add(Me.MaterialDivider4)
        Me.CuiPanelGradient2.Controls.Add(Me.lbl_guests_value)
        Me.CuiPanelGradient2.Controls.Add(Me.Label16)
        Me.CuiPanelGradient2.Controls.Add(Me.PictureBox4)
        Me.CuiPanelGradient2.GradientAngle = 0!
        Me.CuiPanelGradient2.Location = New System.Drawing.Point(1793, 72)
        Me.CuiPanelGradient2.Name = "CuiPanelGradient2"
        Me.CuiPanelGradient2.OutlineThickness = 1.0!
        Me.CuiPanelGradient2.PanelColor1 = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.CuiPanelGradient2.PanelColor2 = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.CuiPanelGradient2.PanelOutlineColor1 = System.Drawing.Color.Transparent
        Me.CuiPanelGradient2.PanelOutlineColor2 = System.Drawing.Color.Transparent
        Me.CuiPanelGradient2.Rounding = New System.Windows.Forms.Padding(26)
        Me.CuiPanelGradient2.Size = New System.Drawing.Size(471, 344)
        Me.CuiPanelGradient2.TabIndex = 89
        '
        'lbl_guests_delta
        '
        Me.lbl_guests_delta.Font = New System.Drawing.Font("Helvetica", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_guests_delta.ForeColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.lbl_guests_delta.Location = New System.Drawing.Point(43, 302)
        Me.lbl_guests_delta.Name = "lbl_guests_delta"
        Me.lbl_guests_delta.Size = New System.Drawing.Size(396, 19)
        Me.lbl_guests_delta.TabIndex = 33
        Me.lbl_guests_delta.Text = "N/A"
        '
        'lbl_guests_sub
        '
        Me.lbl_guests_sub.AutoSize = True
        Me.lbl_guests_sub.Font = New System.Drawing.Font("Helvetica", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_guests_sub.ForeColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.lbl_guests_sub.Location = New System.Drawing.Point(43, 222)
        Me.lbl_guests_sub.Name = "lbl_guests_sub"
        Me.lbl_guests_sub.Size = New System.Drawing.Size(36, 19)
        Me.lbl_guests_sub.TabIndex = 32
        Me.lbl_guests_sub.Text = "N/A"
        '
        'MaterialDivider4
        '
        Me.MaterialDivider4.BackColor = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.MaterialDivider4.Depth = 0
        Me.MaterialDivider4.Location = New System.Drawing.Point(0, 277)
        Me.MaterialDivider4.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER
        Me.MaterialDivider4.Name = "MaterialDivider4"
        Me.MaterialDivider4.Size = New System.Drawing.Size(470, 2)
        Me.MaterialDivider4.TabIndex = 31
        Me.MaterialDivider4.Text = "MaterialDivider4"
        '
        'lbl_guests_value
        '
        Me.lbl_guests_value.BackColor = System.Drawing.Color.Transparent
        Me.lbl_guests_value.Font = New System.Drawing.Font("Helvetica", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_guests_value.ForeColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.lbl_guests_value.Location = New System.Drawing.Point(37, 150)
        Me.lbl_guests_value.Name = "lbl_guests_value"
        Me.lbl_guests_value.Size = New System.Drawing.Size(285, 56)
        Me.lbl_guests_value.TabIndex = 30
        Me.lbl_guests_value.Text = "0"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Helvetica", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.Label16.Location = New System.Drawing.Point(41, 112)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(186, 19)
        Me.Label16.TabIndex = 28
        Me.Label16.Text = "REGISTERED GUESTS"
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(47, 24)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(69, 60)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 29
        Me.PictureBox4.TabStop = False
        '
        'museum_dashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(166, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Controls.Add(Me.CuiPanelGradient2)
        Me.Controls.Add(Me.CuiPanelGradient1)
        Me.Controls.Add(Me.CuiLabel5)
        Me.Controls.Add(Me.top_donors_grid)
        Me.Controls.Add(Me.CuiGradientPanel1)
        Me.Controls.Add(Me.CuiGradientPanel2)
        Me.Controls.Add(Me.section_piechart_pnl)
        Me.Name = "museum_dashboard"
        Me.Size = New System.Drawing.Size(2318, 1293)
        Me.Tag = "Dashboard"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CuiGradientPanel2.ResumeLayout(False)
        Me.CuiGradientPanel2.PerformLayout()
        Me.CuiGradientPanel1.ResumeLayout(False)
        Me.CuiGradientPanel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.top_donors_grid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CuiPanelGradient1.ResumeLayout(False)
        Me.CuiPanelGradient1.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CuiPanelGradient2.ResumeLayout(False)
        Me.CuiPanelGradient2.PerformLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lbl_minerals_value As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents CuiGradientPanel2 As CuoreUI.Controls.cuiPanelGradient
    Friend WithEvents CuiGradientPanel1 As CuoreUI.Controls.cuiPanelGradient
    Friend WithEvents top_donors_grid As MetroFramework.Controls.MetroGrid
    Friend WithEvents section_piechart_pnl As CuoreUI.Controls.cuiPanel
    Friend WithEvents CuiLabel5 As CuoreUI.Controls.cuiLabel
    Friend WithEvents CuiPanelGradient1 As CuoreUI.Controls.cuiPanelGradient
    Friend WithEvents CuiPanelGradient2 As CuoreUI.Controls.cuiPanelGradient
    Friend WithEvents lbl_minerals_sub As Label
    Friend WithEvents MaterialDivider2 As ReaLTaiizor.Controls.MaterialDivider
    Friend WithEvents lbl_minerals_delta As Label
    Friend WithEvents lbl_donations_delta As Label
    Friend WithEvents lbl_donations_sub As Label
    Friend WithEvents MaterialDivider1 As ReaLTaiizor.Controls.MaterialDivider
    Friend WithEvents lbl_donations_value As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lbl_events_delta As Label
    Friend WithEvents lbl_events_sub As Label
    Friend WithEvents MaterialDivider3 As ReaLTaiizor.Controls.MaterialDivider
    Friend WithEvents lbl_events_value As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents lbl_guests_delta As Label
    Friend WithEvents lbl_guests_sub As Label
    Friend WithEvents MaterialDivider4 As ReaLTaiizor.Controls.MaterialDivider
    Friend WithEvents lbl_guests_value As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents PictureBox4 As PictureBox
End Class
