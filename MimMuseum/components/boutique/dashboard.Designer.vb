<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class boutique_dashboard
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
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(boutique_dashboard))
        Me.section_piechart_pnl = New CuoreUI.Controls.cuiPanel()
        Me.top_customers_grid = New MetroFramework.Controls.MetroGrid()
        Me.CuiLabel5 = New CuoreUI.Controls.cuiLabel()
        Me.CuiPanelGradient2 = New CuoreUI.Controls.cuiPanelGradient()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.MaterialDivider4 = New ReaLTaiizor.Controls.MaterialDivider()
        Me.active_listings_lbl = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.CuiPanelGradient1 = New CuoreUI.Controls.cuiPanelGradient()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.MaterialDivider3 = New ReaLTaiizor.Controls.MaterialDivider()
        Me.reg_customers_lbl = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.CuiGradientPanel1 = New CuoreUI.Controls.cuiPanelGradient()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.MaterialDivider1 = New ReaLTaiizor.Controls.MaterialDivider()
        Me.total_orders_lbl = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.CuiGradientPanel2 = New CuoreUI.Controls.cuiPanelGradient()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.MaterialDivider2 = New ReaLTaiizor.Controls.MaterialDivider()
        Me.total_revenue_lbl = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        CType(Me.top_customers_grid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CuiPanelGradient2.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CuiPanelGradient1.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CuiGradientPanel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CuiGradientPanel2.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'section_piechart_pnl
        '
        Me.section_piechart_pnl.Location = New System.Drawing.Point(1234, 568)
        Me.section_piechart_pnl.Name = "section_piechart_pnl"
        Me.section_piechart_pnl.OutlineThickness = 1.0!
        Me.section_piechart_pnl.PanelColor = System.Drawing.Color.FromArgb(CType(CType(166, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.section_piechart_pnl.PanelOutlineColor = System.Drawing.Color.Transparent
        Me.section_piechart_pnl.Rounding = New System.Windows.Forms.Padding(8)
        Me.section_piechart_pnl.Size = New System.Drawing.Size(1038, 565)
        Me.section_piechart_pnl.TabIndex = 32
        '
        'top_customers_grid
        '
        Me.top_customers_grid.AllowUserToAddRows = False
        Me.top_customers_grid.AllowUserToDeleteRows = False
        Me.top_customers_grid.AllowUserToResizeColumns = False
        Me.top_customers_grid.AllowUserToResizeRows = False
        Me.top_customers_grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.top_customers_grid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.top_customers_grid.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.top_customers_grid.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.top_customers_grid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenHorizontal
        Me.top_customers_grid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(84, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Helvetica", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle5.Padding = New System.Windows.Forms.Padding(10, 0, 10, 0)
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(84, Byte), Integer))
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.top_customers_grid.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.top_customers_grid.ColumnHeadersHeight = 70
        Me.top_customers_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Helvetica", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.top_customers_grid.DefaultCellStyle = DataGridViewCellStyle6
        Me.top_customers_grid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2
        Me.top_customers_grid.EnableHeadersVisualStyles = False
        Me.top_customers_grid.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.top_customers_grid.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.top_customers_grid.Location = New System.Drawing.Point(42, 574)
        Me.top_customers_grid.Name = "top_customers_grid"
        Me.top_customers_grid.ReadOnly = True
        Me.top_customers_grid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(217, Byte), Integer))
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Helvetica", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(250, Byte), Integer))
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.top_customers_grid.RowHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.top_customers_grid.RowHeadersVisible = False
        Me.top_customers_grid.RowHeadersWidth = 50
        Me.top_customers_grid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(217, Byte), Integer))
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Helvetica", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle8.Padding = New System.Windows.Forms.Padding(0, 15, 0, 20)
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(250, Byte), Integer))
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White
        Me.top_customers_grid.RowsDefaultCellStyle = DataGridViewCellStyle8
        Me.top_customers_grid.RowTemplate.Height = 42
        Me.top_customers_grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.top_customers_grid.Size = New System.Drawing.Size(1041, 559)
        Me.top_customers_grid.TabIndex = 38
        '
        'CuiLabel5
        '
        Me.CuiLabel5.BackColor = System.Drawing.Color.Transparent
        Me.CuiLabel5.Content = "All-Time\ Top\ Customers"
        Me.CuiLabel5.Font = New System.Drawing.Font("Helvetica", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CuiLabel5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.CuiLabel5.HorizontalAlignment = System.Drawing.StringAlignment.Center
        Me.CuiLabel5.Location = New System.Drawing.Point(315, 487)
        Me.CuiLabel5.Name = "CuiLabel5"
        Me.CuiLabel5.Size = New System.Drawing.Size(473, 47)
        Me.CuiLabel5.TabIndex = 86
        Me.CuiLabel5.VerticalAlignment = System.Drawing.StringAlignment.Near
        '
        'CuiPanelGradient2
        '
        Me.CuiPanelGradient2.BackColor = System.Drawing.Color.Transparent
        Me.CuiPanelGradient2.Controls.Add(Me.Label8)
        Me.CuiPanelGradient2.Controls.Add(Me.Label9)
        Me.CuiPanelGradient2.Controls.Add(Me.MaterialDivider4)
        Me.CuiPanelGradient2.Controls.Add(Me.active_listings_lbl)
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
        Me.CuiPanelGradient2.TabIndex = 93
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Helvetica", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(43, 302)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(202, 19)
        Me.Label8.TabIndex = 33
        Me.Label8.Text = "−3 this week"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Helvetica", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(43, 222)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(170, 19)
        Me.Label9.TabIndex = 32
        Me.Label9.Text = "items currently in stock"
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
        'active_listings_lbl
        '
        Me.active_listings_lbl.BackColor = System.Drawing.Color.Transparent
        Me.active_listings_lbl.Font = New System.Drawing.Font("Helvetica", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.active_listings_lbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.active_listings_lbl.Location = New System.Drawing.Point(37, 150)
        Me.active_listings_lbl.Name = "active_listings_lbl"
        Me.active_listings_lbl.Size = New System.Drawing.Size(285, 56)
        Me.active_listings_lbl.TabIndex = 30
        Me.active_listings_lbl.Text = "738"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Helvetica", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.Label16.Location = New System.Drawing.Point(41, 112)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(145, 19)
        Me.Label16.TabIndex = 28
        Me.Label16.Text = "ACTIVE LISTINGS"
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
        'CuiPanelGradient1
        '
        Me.CuiPanelGradient1.BackColor = System.Drawing.Color.Transparent
        Me.CuiPanelGradient1.Controls.Add(Me.Label4)
        Me.CuiPanelGradient1.Controls.Add(Me.Label7)
        Me.CuiPanelGradient1.Controls.Add(Me.MaterialDivider3)
        Me.CuiPanelGradient1.Controls.Add(Me.reg_customers_lbl)
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
        Me.CuiPanelGradient1.TabIndex = 92
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Helvetica", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(47, 302)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(202, 19)
        Me.Label4.TabIndex = 27
        Me.Label4.Text = "+2 today"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Helvetica", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(47, 222)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(176, 19)
        Me.Label7.TabIndex = 26
        Me.Label7.Text = "non-anonymous buyers"
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
        'reg_customers_lbl
        '
        Me.reg_customers_lbl.BackColor = System.Drawing.Color.Transparent
        Me.reg_customers_lbl.Font = New System.Drawing.Font("Helvetica", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.reg_customers_lbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.reg_customers_lbl.Location = New System.Drawing.Point(41, 150)
        Me.reg_customers_lbl.Name = "reg_customers_lbl"
        Me.reg_customers_lbl.Size = New System.Drawing.Size(285, 56)
        Me.reg_customers_lbl.TabIndex = 24
        Me.reg_customers_lbl.Text = "3"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Helvetica", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.Label14.Location = New System.Drawing.Point(45, 112)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(223, 19)
        Me.Label14.TabIndex = 22
        Me.Label14.Text = "REGISTERED CUSTOMERS"
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
        'CuiGradientPanel1
        '
        Me.CuiGradientPanel1.BackColor = System.Drawing.Color.Transparent
        Me.CuiGradientPanel1.Controls.Add(Me.Label5)
        Me.CuiGradientPanel1.Controls.Add(Me.Label6)
        Me.CuiGradientPanel1.Controls.Add(Me.MaterialDivider1)
        Me.CuiGradientPanel1.Controls.Add(Me.total_orders_lbl)
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
        Me.CuiGradientPanel1.TabIndex = 91
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Helvetica", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(43, 302)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(202, 19)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "+18 today"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Helvetica", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(43, 222)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(173, 19)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "transactions processed"
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
        'total_orders_lbl
        '
        Me.total_orders_lbl.BackColor = System.Drawing.Color.Transparent
        Me.total_orders_lbl.Font = New System.Drawing.Font("Helvetica", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.total_orders_lbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.total_orders_lbl.Location = New System.Drawing.Point(37, 150)
        Me.total_orders_lbl.Name = "total_orders_lbl"
        Me.total_orders_lbl.Size = New System.Drawing.Size(285, 56)
        Me.total_orders_lbl.TabIndex = 18
        Me.total_orders_lbl.Text = "5,674"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Helvetica", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.Label12.Location = New System.Drawing.Point(41, 112)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(133, 19)
        Me.Label12.TabIndex = 16
        Me.Label12.Text = "TOTAL ORDERS"
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
        'CuiGradientPanel2
        '
        Me.CuiGradientPanel2.BackColor = System.Drawing.Color.Transparent
        Me.CuiGradientPanel2.Controls.Add(Me.Label3)
        Me.CuiGradientPanel2.Controls.Add(Me.Label2)
        Me.CuiGradientPanel2.Controls.Add(Me.MaterialDivider2)
        Me.CuiGradientPanel2.Controls.Add(Me.total_revenue_lbl)
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
        Me.CuiGradientPanel2.TabIndex = 90
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Helvetica", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(46, 300)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(144, 19)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "+$340 today"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Helvetica", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(44, 222)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(137, 19)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "after VAT · all time"
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
        'total_revenue_lbl
        '
        Me.total_revenue_lbl.BackColor = System.Drawing.Color.Transparent
        Me.total_revenue_lbl.Font = New System.Drawing.Font("Helvetica", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.total_revenue_lbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.total_revenue_lbl.Location = New System.Drawing.Point(38, 150)
        Me.total_revenue_lbl.Name = "total_revenue_lbl"
        Me.total_revenue_lbl.Size = New System.Drawing.Size(285, 56)
        Me.total_revenue_lbl.TabIndex = 3
        Me.total_revenue_lbl.Text = "3,490"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Helvetica", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(44, 110)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(143, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "TOTAL REVENUE"
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
        'boutique_dashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(166, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Controls.Add(Me.CuiPanelGradient2)
        Me.Controls.Add(Me.CuiPanelGradient1)
        Me.Controls.Add(Me.CuiGradientPanel1)
        Me.Controls.Add(Me.CuiGradientPanel2)
        Me.Controls.Add(Me.CuiLabel5)
        Me.Controls.Add(Me.section_piechart_pnl)
        Me.Controls.Add(Me.top_customers_grid)
        Me.Name = "boutique_dashboard"
        Me.Size = New System.Drawing.Size(2318, 1293)
        CType(Me.top_customers_grid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CuiPanelGradient2.ResumeLayout(False)
        Me.CuiPanelGradient2.PerformLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CuiPanelGradient1.ResumeLayout(False)
        Me.CuiPanelGradient1.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CuiGradientPanel1.ResumeLayout(False)
        Me.CuiGradientPanel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CuiGradientPanel2.ResumeLayout(False)
        Me.CuiGradientPanel2.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents section_piechart_pnl As CuoreUI.Controls.cuiPanel
    Friend WithEvents top_customers_grid As MetroFramework.Controls.MetroGrid
    Friend WithEvents CuiLabel5 As CuoreUI.Controls.cuiLabel
    Friend WithEvents CuiPanelGradient2 As CuoreUI.Controls.cuiPanelGradient
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents MaterialDivider4 As ReaLTaiizor.Controls.MaterialDivider
    Friend WithEvents active_listings_lbl As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents CuiPanelGradient1 As CuoreUI.Controls.cuiPanelGradient
    Friend WithEvents Label4 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents MaterialDivider3 As ReaLTaiizor.Controls.MaterialDivider
    Friend WithEvents reg_customers_lbl As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents CuiGradientPanel1 As CuoreUI.Controls.cuiPanelGradient
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents MaterialDivider1 As ReaLTaiizor.Controls.MaterialDivider
    Friend WithEvents total_orders_lbl As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents CuiGradientPanel2 As CuoreUI.Controls.cuiPanelGradient
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents MaterialDivider2 As ReaLTaiizor.Controls.MaterialDivider
    Friend WithEvents total_revenue_lbl As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox2 As PictureBox
End Class
