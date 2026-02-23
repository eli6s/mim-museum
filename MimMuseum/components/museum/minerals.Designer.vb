<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class minerals
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(minerals))
        Me.MineralsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Mim_museum_dataset = New MimMuseum.mim_museum_dataset()
        Me.MineralsTableAdapter = New MimMuseum.mim_museum_datasetTableAdapters.mineralsTableAdapter()
        Me.minerals_grid = New MetroFramework.Controls.MetroGrid()
        Me.MineraltagDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MineralnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ChemformulaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ClassidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CountryidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SectionidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DimensionsDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HardnesslvlDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MineraldescDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IsfluorescentDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.IsradioactiveDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.CuiPanel1 = New CuoreUI.Controls.cuiPanel()
        Me.fluorescent_switch = New CuoreUI.Controls.cuiSwitch()
        Me.section_cmbbox = New CuoreUI.Controls.cuiComboBox()
        Me.CuiLabel8 = New CuoreUI.Controls.cuiLabel()
        Me.class_cmbbox = New CuoreUI.Controls.cuiComboBox()
        Me.CuiLabel4 = New CuoreUI.Controls.cuiLabel()
        Me.country_cmbbox = New CuoreUI.Controls.cuiComboBox()
        Me.hardness_scale = New ReaLTaiizor.Controls.HopeNumeric()
        Me.radioactive_switch = New CuoreUI.Controls.cuiSwitch()
        Me.reset_btn = New CuoreUI.Controls.cuiButton()
        Me.search_btn = New CuoreUI.Controls.cuiButton()
        Me.CuiLabel7 = New CuoreUI.Controls.cuiLabel()
        Me.CuiLabel3 = New CuoreUI.Controls.cuiLabel()
        Me.CuiLabel1 = New CuoreUI.Controls.cuiLabel()
        Me.CuiLabel2 = New CuoreUI.Controls.cuiLabel()
        Me.CuiLabel6 = New CuoreUI.Controls.cuiLabel()
        Me.dimensions_txtbox = New CuoreUI.Controls.cuiTextBox()
        Me.name_cmbbox = New CuoreUI.Controls.cuiTextBox()
        Me.CuiLabel5 = New CuoreUI.Controls.cuiLabel()
        Me.CuiLabel15 = New CuoreUI.Controls.cuiLabel()
        Me.CuiButton2 = New CuoreUI.Controls.cuiButton()
        Me.MaterialDivider1 = New ReaLTaiizor.Controls.MaterialDivider()
        Me.HopeContextMenuStrip1 = New ReaLTaiizor.Controls.HopeContextMenuStrip()
        Me.LOLToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.MineralsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Mim_museum_dataset, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.minerals_grid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CuiPanel1.SuspendLayout()
        Me.HopeContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MineralsBindingSource
        '
        Me.MineralsBindingSource.DataMember = "minerals"
        Me.MineralsBindingSource.DataSource = Me.Mim_museum_dataset
        '
        'Mim_museum_dataset
        '
        Me.Mim_museum_dataset.DataSetName = "mim_museum_dataset"
        Me.Mim_museum_dataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MineralsTableAdapter
        '
        Me.MineralsTableAdapter.ClearBeforeFill = True
        '
        'minerals_grid
        '
        Me.minerals_grid.AllowUserToAddRows = False
        Me.minerals_grid.AllowUserToDeleteRows = False
        Me.minerals_grid.AllowUserToResizeColumns = False
        Me.minerals_grid.AllowUserToResizeRows = False
        Me.minerals_grid.AutoGenerateColumns = False
        Me.minerals_grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.minerals_grid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.minerals_grid.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.minerals_grid.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.minerals_grid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenHorizontal
        Me.minerals_grid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(84, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Helvetica", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle1.Padding = New System.Windows.Forms.Padding(10, 0, 10, 0)
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(84, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.minerals_grid.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.minerals_grid.ColumnHeadersHeight = 70
        Me.minerals_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.minerals_grid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.MineraltagDataGridViewTextBoxColumn, Me.MineralnameDataGridViewTextBoxColumn, Me.ChemformulaDataGridViewTextBoxColumn, Me.ClassidDataGridViewTextBoxColumn, Me.CountryidDataGridViewTextBoxColumn, Me.SectionidDataGridViewTextBoxColumn, Me.DimensionsDataGridViewTextBoxColumn, Me.HardnesslvlDataGridViewTextBoxColumn, Me.MineraldescDataGridViewTextBoxColumn, Me.IsfluorescentDataGridViewCheckBoxColumn, Me.IsradioactiveDataGridViewCheckBoxColumn})
        Me.minerals_grid.DataSource = Me.MineralsBindingSource
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Helvetica", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.minerals_grid.DefaultCellStyle = DataGridViewCellStyle2
        Me.minerals_grid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2
        Me.minerals_grid.EnableHeadersVisualStyles = False
        Me.minerals_grid.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.minerals_grid.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.minerals_grid.Location = New System.Drawing.Point(83, 247)
        Me.minerals_grid.Name = "minerals_grid"
        Me.minerals_grid.ReadOnly = True
        Me.minerals_grid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(217, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Helvetica", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(250, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.minerals_grid.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.minerals_grid.RowHeadersVisible = False
        Me.minerals_grid.RowHeadersWidth = 50
        Me.minerals_grid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(217, Byte), Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Helvetica", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle4.Padding = New System.Windows.Forms.Padding(0, 15, 0, 20)
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(250, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White
        Me.minerals_grid.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.minerals_grid.RowTemplate.Height = 42
        Me.minerals_grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.minerals_grid.Size = New System.Drawing.Size(2147, 873)
        Me.minerals_grid.TabIndex = 1
        '
        'MineraltagDataGridViewTextBoxColumn
        '
        Me.MineraltagDataGridViewTextBoxColumn.DataPropertyName = "mineral_tag"
        Me.MineraltagDataGridViewTextBoxColumn.HeaderText = "mineral_tag"
        Me.MineraltagDataGridViewTextBoxColumn.Name = "MineraltagDataGridViewTextBoxColumn"
        Me.MineraltagDataGridViewTextBoxColumn.ReadOnly = True
        '
        'MineralnameDataGridViewTextBoxColumn
        '
        Me.MineralnameDataGridViewTextBoxColumn.DataPropertyName = "mineral_name"
        Me.MineralnameDataGridViewTextBoxColumn.HeaderText = "mineral_name"
        Me.MineralnameDataGridViewTextBoxColumn.Name = "MineralnameDataGridViewTextBoxColumn"
        Me.MineralnameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ChemformulaDataGridViewTextBoxColumn
        '
        Me.ChemformulaDataGridViewTextBoxColumn.DataPropertyName = "chem_formula"
        Me.ChemformulaDataGridViewTextBoxColumn.HeaderText = "chem_formula"
        Me.ChemformulaDataGridViewTextBoxColumn.Name = "ChemformulaDataGridViewTextBoxColumn"
        Me.ChemformulaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ClassidDataGridViewTextBoxColumn
        '
        Me.ClassidDataGridViewTextBoxColumn.DataPropertyName = "class_id"
        Me.ClassidDataGridViewTextBoxColumn.HeaderText = "class_id"
        Me.ClassidDataGridViewTextBoxColumn.Name = "ClassidDataGridViewTextBoxColumn"
        Me.ClassidDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CountryidDataGridViewTextBoxColumn
        '
        Me.CountryidDataGridViewTextBoxColumn.DataPropertyName = "country_id"
        Me.CountryidDataGridViewTextBoxColumn.HeaderText = "country_id"
        Me.CountryidDataGridViewTextBoxColumn.Name = "CountryidDataGridViewTextBoxColumn"
        Me.CountryidDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SectionidDataGridViewTextBoxColumn
        '
        Me.SectionidDataGridViewTextBoxColumn.DataPropertyName = "section_id"
        Me.SectionidDataGridViewTextBoxColumn.HeaderText = "section_id"
        Me.SectionidDataGridViewTextBoxColumn.Name = "SectionidDataGridViewTextBoxColumn"
        Me.SectionidDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DimensionsDataGridViewTextBoxColumn
        '
        Me.DimensionsDataGridViewTextBoxColumn.DataPropertyName = "dimensions"
        Me.DimensionsDataGridViewTextBoxColumn.HeaderText = "dimensions"
        Me.DimensionsDataGridViewTextBoxColumn.Name = "DimensionsDataGridViewTextBoxColumn"
        Me.DimensionsDataGridViewTextBoxColumn.ReadOnly = True
        '
        'HardnesslvlDataGridViewTextBoxColumn
        '
        Me.HardnesslvlDataGridViewTextBoxColumn.DataPropertyName = "hardness_lvl"
        Me.HardnesslvlDataGridViewTextBoxColumn.HeaderText = "hardness_lvl"
        Me.HardnesslvlDataGridViewTextBoxColumn.Name = "HardnesslvlDataGridViewTextBoxColumn"
        Me.HardnesslvlDataGridViewTextBoxColumn.ReadOnly = True
        '
        'MineraldescDataGridViewTextBoxColumn
        '
        Me.MineraldescDataGridViewTextBoxColumn.DataPropertyName = "mineral_desc"
        Me.MineraldescDataGridViewTextBoxColumn.HeaderText = "mineral_desc"
        Me.MineraldescDataGridViewTextBoxColumn.Name = "MineraldescDataGridViewTextBoxColumn"
        Me.MineraldescDataGridViewTextBoxColumn.ReadOnly = True
        '
        'IsfluorescentDataGridViewCheckBoxColumn
        '
        Me.IsfluorescentDataGridViewCheckBoxColumn.DataPropertyName = "is_fluorescent"
        Me.IsfluorescentDataGridViewCheckBoxColumn.HeaderText = "is_fluorescent"
        Me.IsfluorescentDataGridViewCheckBoxColumn.Name = "IsfluorescentDataGridViewCheckBoxColumn"
        Me.IsfluorescentDataGridViewCheckBoxColumn.ReadOnly = True
        '
        'IsradioactiveDataGridViewCheckBoxColumn
        '
        Me.IsradioactiveDataGridViewCheckBoxColumn.DataPropertyName = "is_radioactive"
        Me.IsradioactiveDataGridViewCheckBoxColumn.HeaderText = "is_radioactive"
        Me.IsradioactiveDataGridViewCheckBoxColumn.Name = "IsradioactiveDataGridViewCheckBoxColumn"
        Me.IsradioactiveDataGridViewCheckBoxColumn.ReadOnly = True
        '
        'CuiPanel1
        '
        Me.CuiPanel1.BackColor = System.Drawing.Color.Transparent
        Me.CuiPanel1.Controls.Add(Me.fluorescent_switch)
        Me.CuiPanel1.Controls.Add(Me.section_cmbbox)
        Me.CuiPanel1.Controls.Add(Me.CuiLabel8)
        Me.CuiPanel1.Controls.Add(Me.class_cmbbox)
        Me.CuiPanel1.Controls.Add(Me.CuiLabel4)
        Me.CuiPanel1.Controls.Add(Me.country_cmbbox)
        Me.CuiPanel1.Controls.Add(Me.hardness_scale)
        Me.CuiPanel1.Controls.Add(Me.radioactive_switch)
        Me.CuiPanel1.Controls.Add(Me.reset_btn)
        Me.CuiPanel1.Controls.Add(Me.search_btn)
        Me.CuiPanel1.Controls.Add(Me.CuiLabel7)
        Me.CuiPanel1.Controls.Add(Me.CuiLabel3)
        Me.CuiPanel1.Controls.Add(Me.CuiLabel1)
        Me.CuiPanel1.Controls.Add(Me.CuiLabel2)
        Me.CuiPanel1.Controls.Add(Me.CuiLabel6)
        Me.CuiPanel1.Controls.Add(Me.dimensions_txtbox)
        Me.CuiPanel1.Controls.Add(Me.name_cmbbox)
        Me.CuiPanel1.Controls.Add(Me.CuiLabel5)
        Me.CuiPanel1.Controls.Add(Me.CuiLabel15)
        Me.CuiPanel1.Controls.Add(Me.CuiButton2)
        Me.CuiPanel1.Location = New System.Drawing.Point(2, 2)
        Me.CuiPanel1.Margin = New System.Windows.Forms.Padding(2)
        Me.CuiPanel1.Name = "CuiPanel1"
        Me.CuiPanel1.OutlineThickness = 1.0!
        Me.CuiPanel1.PanelColor = System.Drawing.Color.FromArgb(CType(CType(166, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CuiPanel1.PanelOutlineColor = System.Drawing.Color.Transparent
        Me.CuiPanel1.Rounding = New System.Windows.Forms.Padding(8)
        Me.CuiPanel1.Size = New System.Drawing.Size(2314, 186)
        Me.CuiPanel1.TabIndex = 7
        '
        'fluorescent_switch
        '
        Me.fluorescent_switch.Checked = False
        Me.fluorescent_switch.CheckedBackground = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.fluorescent_switch.CheckedForeground = System.Drawing.Color.White
        Me.fluorescent_switch.CheckedOutlineColor = System.Drawing.Color.Empty
        Me.fluorescent_switch.CheckedSymbolColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.fluorescent_switch.Cursor = System.Windows.Forms.Cursors.Hand
        Me.fluorescent_switch.Location = New System.Drawing.Point(1565, 117)
        Me.fluorescent_switch.MinimumSize = New System.Drawing.Size(12, 8)
        Me.fluorescent_switch.Name = "fluorescent_switch"
        Me.fluorescent_switch.OutlineThickness = 1.0!
        Me.fluorescent_switch.ShowSymbols = False
        Me.fluorescent_switch.Size = New System.Drawing.Size(48, 26)
        Me.fluorescent_switch.TabIndex = 111
        Me.fluorescent_switch.ThumbSizeModifier = New System.Drawing.Size(0, 0)
        Me.fluorescent_switch.UncheckedBackground = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.fluorescent_switch.UncheckedForeground = System.Drawing.Color.White
        Me.fluorescent_switch.UncheckedOutlineColor = System.Drawing.Color.Empty
        Me.fluorescent_switch.UncheckedSymbolColor = System.Drawing.Color.Gray
        '
        'section_cmbbox
        '
        Me.section_cmbbox.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(217, Byte), Integer))
        'Me.section_cmbbox.ButtonCursor = System.Windows.Forms.Cursors.Arrow
        'Me.section_cmbbox.ButtonHoverBackground = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(0, Byte), Integer))
        'Me.section_cmbbox.ButtonHoverOutline = System.Drawing.Color.Empty
        'Me.section_cmbbox.ButtonNormalBackground = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(217, Byte), Integer))
        'Me.section_cmbbox.ButtonNormalOutline = System.Drawing.Color.Empty
        'Me.section_cmbbox.ButtonPressedBackground = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(0, Byte), Integer))
        'Me.section_cmbbox.ButtonPressedOutline = System.Drawing.Color.Empty
        'Me.section_cmbbox.DropDownBackgroundColor = System.Drawing.Color.White
        'Me.section_cmbbox.DropDownOutlineColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.section_cmbbox.ExpandArrowColor = System.Drawing.Color.Gray
        Me.section_cmbbox.Font = New System.Drawing.Font("Helvetica", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.section_cmbbox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.section_cmbbox.Items = New String(-1) {}
        Me.section_cmbbox.Location = New System.Drawing.Point(855, 110)
        Me.section_cmbbox.Margin = New System.Windows.Forms.Padding(6)
        Me.section_cmbbox.Name = "section_cmbbox"
        'Me.section_cmbbox.NoSelectionDropdownText = "Empty"
        Me.section_cmbbox.NoSelectionText = "Select"
        Me.section_cmbbox.OutlineColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.section_cmbbox.OutlineThickness = 1.0!
        Me.section_cmbbox.Rounding = 12
        Me.section_cmbbox.Size = New System.Drawing.Size(245, 49)
        Me.section_cmbbox.TabIndex = 120
        '
        'CuiLabel8
        '
        Me.CuiLabel8.BackColor = System.Drawing.Color.Transparent
        Me.CuiLabel8.Content = "Section"
        Me.CuiLabel8.Font = New System.Drawing.Font("Helvetica", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CuiLabel8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.CuiLabel8.HorizontalAlignment = System.Drawing.StringAlignment.Center
        Me.CuiLabel8.Location = New System.Drawing.Point(814, 80)
        Me.CuiLabel8.Name = "CuiLabel8"
        Me.CuiLabel8.Size = New System.Drawing.Size(166, 30)
        Me.CuiLabel8.TabIndex = 119
        Me.CuiLabel8.VerticalAlignment = System.Drawing.StringAlignment.Near
        '
        'class_cmbbox
        '
        Me.class_cmbbox.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(217, Byte), Integer))
        'Me.class_cmbbox.ButtonCursor = System.Windows.Forms.Cursors.Arrow
        'Me.class_cmbbox.ButtonHoverBackground = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(0, Byte), Integer))
        'Me.class_cmbbox.ButtonHoverOutline = System.Drawing.Color.Empty
        'Me.class_cmbbox.ButtonNormalBackground = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(217, Byte), Integer))
        'Me.class_cmbbox.ButtonNormalOutline = System.Drawing.Color.Empty
        'Me.class_cmbbox.ButtonPressedBackground = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(0, Byte), Integer))
        'Me.class_cmbbox.ButtonPressedOutline = System.Drawing.Color.Empty
        'Me.class_cmbbox.DropDownBackgroundColor = System.Drawing.Color.White
        'Me.class_cmbbox.DropDownOutlineColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.class_cmbbox.ExpandArrowColor = System.Drawing.Color.Gray
        Me.class_cmbbox.Font = New System.Drawing.Font("Helvetica", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.class_cmbbox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.class_cmbbox.Items = New String(-1) {}
        Me.class_cmbbox.Location = New System.Drawing.Point(588, 110)
        Me.class_cmbbox.Margin = New System.Windows.Forms.Padding(6)
        Me.class_cmbbox.Name = "class_cmbbox"
        'Me.class_cmbbox.NoSelectionDropdownText = "Empty"
        Me.class_cmbbox.NoSelectionText = "Select"
        Me.class_cmbbox.OutlineColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.class_cmbbox.OutlineThickness = 1.0!
        Me.class_cmbbox.Rounding = 12
        Me.class_cmbbox.Size = New System.Drawing.Size(246, 49)
        Me.class_cmbbox.TabIndex = 118
        '
        'CuiLabel4
        '
        Me.CuiLabel4.BackColor = System.Drawing.Color.Transparent
        Me.CuiLabel4.Content = "Class"
        Me.CuiLabel4.Font = New System.Drawing.Font("Helvetica", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CuiLabel4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.CuiLabel4.HorizontalAlignment = System.Drawing.StringAlignment.Center
        Me.CuiLabel4.Location = New System.Drawing.Point(537, 80)
        Me.CuiLabel4.Name = "CuiLabel4"
        Me.CuiLabel4.Size = New System.Drawing.Size(166, 30)
        Me.CuiLabel4.TabIndex = 117
        Me.CuiLabel4.VerticalAlignment = System.Drawing.StringAlignment.Near
        '
        'country_cmbbox
        '
        Me.country_cmbbox.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(217, Byte), Integer))
        'Me.country_cmbbox.ButtonCursor = System.Windows.Forms.Cursors.Arrow
        'Me.country_cmbbox.ButtonHoverBackground = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(0, Byte), Integer))
        'Me.country_cmbbox.ButtonHoverOutline = System.Drawing.Color.Empty
        'Me.country_cmbbox.ButtonNormalBackground = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(217, Byte), Integer))
        'Me.country_cmbbox.ButtonNormalOutline = System.Drawing.Color.Empty
        'Me.country_cmbbox.ButtonPressedBackground = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(0, Byte), Integer))
        'Me.country_cmbbox.ButtonPressedOutline = System.Drawing.Color.Empty
        'Me.country_cmbbox.DropDownBackgroundColor = System.Drawing.Color.White
        'Me.country_cmbbox.DropDownOutlineColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.country_cmbbox.ExpandArrowColor = System.Drawing.Color.Gray
        Me.country_cmbbox.Font = New System.Drawing.Font("Helvetica", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.country_cmbbox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.country_cmbbox.Items = New String(-1) {}
        Me.country_cmbbox.Location = New System.Drawing.Point(313, 110)
        Me.country_cmbbox.Margin = New System.Windows.Forms.Padding(6)
        Me.country_cmbbox.Name = "country_cmbbox"
        'Me.country_cmbbox.NoSelectionDropdownText = "Empty"
        Me.country_cmbbox.NoSelectionText = "Select"
        Me.country_cmbbox.OutlineColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.country_cmbbox.OutlineThickness = 1.0!
        Me.country_cmbbox.Rounding = 12
        Me.country_cmbbox.Size = New System.Drawing.Size(254, 49)
        Me.country_cmbbox.TabIndex = 116
        '
        'hardness_scale
        '
        Me.hardness_scale.BackColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.hardness_scale.BaseColor = System.Drawing.Color.FromArgb(CType(CType(166, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.hardness_scale.BorderColorA = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.hardness_scale.BorderColorB = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.hardness_scale.BorderHoverColorA = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.hardness_scale.ButtonTextColorA = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.hardness_scale.ButtonTextColorB = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.hardness_scale.Cursor = System.Windows.Forms.Cursors.Hand
        Me.hardness_scale.EnterKey = True
        Me.hardness_scale.Font = New System.Drawing.Font("Helvetica", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hardness_scale.ForeColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.hardness_scale.HoverButtonTextColorA = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.hardness_scale.HoverButtonTextColorB = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.hardness_scale.Location = New System.Drawing.Point(1388, 117)
        Me.hardness_scale.MaxNum = 10.0!
        Me.hardness_scale.MinNum = 1.0!
        Me.hardness_scale.Name = "hardness_scale"
        Me.hardness_scale.Precision = 0
        Me.hardness_scale.Size = New System.Drawing.Size(120, 32)
        Me.hardness_scale.Step = 1.0!
        Me.hardness_scale.Style = ReaLTaiizor.Controls.HopeNumeric.NumericStyle.LeftRight
        Me.hardness_scale.TabIndex = 115
        Me.hardness_scale.Text = "HopeNumeric1"
        Me.hardness_scale.ValueNumber = 1.0!
        '
        'radioactive_switch
        '
        Me.radioactive_switch.Checked = False
        Me.radioactive_switch.CheckedBackground = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.radioactive_switch.CheckedForeground = System.Drawing.Color.White
        Me.radioactive_switch.CheckedOutlineColor = System.Drawing.Color.Empty
        Me.radioactive_switch.CheckedSymbolColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.radioactive_switch.Cursor = System.Windows.Forms.Cursors.Hand
        Me.radioactive_switch.Location = New System.Drawing.Point(1720, 117)
        Me.radioactive_switch.MinimumSize = New System.Drawing.Size(12, 8)
        Me.radioactive_switch.Name = "radioactive_switch"
        Me.radioactive_switch.OutlineThickness = 1.0!
        Me.radioactive_switch.ShowSymbols = False
        Me.radioactive_switch.Size = New System.Drawing.Size(48, 26)
        Me.radioactive_switch.TabIndex = 109
        Me.radioactive_switch.ThumbSizeModifier = New System.Drawing.Size(0, 0)
        Me.radioactive_switch.UncheckedBackground = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.radioactive_switch.UncheckedForeground = System.Drawing.Color.White
        Me.radioactive_switch.UncheckedOutlineColor = System.Drawing.Color.Empty
        Me.radioactive_switch.UncheckedSymbolColor = System.Drawing.Color.Gray
        '
        'reset_btn
        '
        Me.reset_btn.CheckButton = False
        Me.reset_btn.Checked = False
        Me.reset_btn.CheckedBackground = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.reset_btn.CheckedForeColor = System.Drawing.Color.White
        Me.reset_btn.CheckedImageTint = System.Drawing.Color.White
        Me.reset_btn.CheckedOutline = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.reset_btn.Content = "Reset"
        Me.reset_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.reset_btn.DialogResult = System.Windows.Forms.DialogResult.None
        Me.reset_btn.Font = New System.Drawing.Font("Helvetica", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.reset_btn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.reset_btn.HoverBackground = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(161, Byte), Integer))
        Me.reset_btn.HoverForeColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.reset_btn.HoverImageTint = System.Drawing.Color.White
        Me.reset_btn.HoverOutline = System.Drawing.Color.Transparent
        Me.reset_btn.Image = Nothing
        'Me.reset_btn.ImageAutoCenter = False
        Me.reset_btn.ImageExpand = New System.Drawing.Point(3, 3)
        'Me.reset_btn.ImageOffset = New System.Drawing.Point(0, 0)
        Me.reset_btn.ImeMode = System.Windows.Forms.ImeMode.Close
        Me.reset_btn.Location = New System.Drawing.Point(2161, 110)
        Me.reset_btn.Name = "reset_btn"
        Me.reset_btn.NormalBackground = System.Drawing.Color.Transparent
        Me.reset_btn.NormalForeColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.reset_btn.NormalImageTint = System.Drawing.Color.White
        Me.reset_btn.NormalOutline = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.reset_btn.OutlineThickness = 3.0!
        Me.reset_btn.PressedBackground = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.reset_btn.PressedForeColor = System.Drawing.Color.White
        Me.reset_btn.PressedImageTint = System.Drawing.Color.White
        Me.reset_btn.PressedOutline = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.reset_btn.Rounding = New System.Windows.Forms.Padding(12)
        Me.reset_btn.Size = New System.Drawing.Size(126, 49)
        Me.reset_btn.TabIndex = 108
        Me.reset_btn.TextAlignment = System.Drawing.StringAlignment.Center
        'Me.reset_btn.TextOffset = New System.Drawing.Point(0, 0)
        '
        'search_btn
        '
        Me.search_btn.CheckButton = False
        Me.search_btn.Checked = False
        Me.search_btn.CheckedBackground = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.search_btn.CheckedForeColor = System.Drawing.Color.White
        Me.search_btn.CheckedImageTint = System.Drawing.Color.White
        Me.search_btn.CheckedOutline = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.search_btn.Content = "Search"
        Me.search_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.search_btn.DialogResult = System.Windows.Forms.DialogResult.None
        Me.search_btn.Font = New System.Drawing.Font("Helvetica", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.search_btn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.search_btn.HoverBackground = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(161, Byte), Integer))
        Me.search_btn.HoverForeColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.search_btn.HoverImageTint = System.Drawing.Color.White
        Me.search_btn.HoverOutline = System.Drawing.Color.Transparent
        Me.search_btn.Image = Nothing
        'Me.search_btn.ImageAutoCenter = False
        Me.search_btn.ImageExpand = New System.Drawing.Point(3, 3)
        'Me.search_btn.ImageOffset = New System.Drawing.Point(0, 0)
        Me.search_btn.ImeMode = System.Windows.Forms.ImeMode.Close
        Me.search_btn.Location = New System.Drawing.Point(1984, 110)
        Me.search_btn.Name = "search_btn"
        Me.search_btn.NormalBackground = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.search_btn.NormalForeColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.search_btn.NormalImageTint = System.Drawing.Color.White
        Me.search_btn.NormalOutline = System.Drawing.Color.Transparent
        Me.search_btn.OutlineThickness = 1.0!
        Me.search_btn.PressedBackground = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.search_btn.PressedForeColor = System.Drawing.Color.White
        Me.search_btn.PressedImageTint = System.Drawing.Color.White
        Me.search_btn.PressedOutline = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.search_btn.Rounding = New System.Windows.Forms.Padding(12)
        Me.search_btn.Size = New System.Drawing.Size(156, 49)
        Me.search_btn.TabIndex = 10
        Me.search_btn.TextAlignment = System.Drawing.StringAlignment.Center
        'Me.search_btn.TextOffset = New System.Drawing.Point(0, 0)
        '
        'CuiLabel7
        '
        Me.CuiLabel7.BackColor = System.Drawing.Color.Transparent
        Me.CuiLabel7.Content = "Hardness"
        Me.CuiLabel7.Font = New System.Drawing.Font("Helvetica", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CuiLabel7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.CuiLabel7.HorizontalAlignment = System.Drawing.StringAlignment.Center
        Me.CuiLabel7.Location = New System.Drawing.Point(1388, 80)
        Me.CuiLabel7.Name = "CuiLabel7"
        Me.CuiLabel7.Size = New System.Drawing.Size(116, 24)
        Me.CuiLabel7.TabIndex = 107
        Me.CuiLabel7.VerticalAlignment = System.Drawing.StringAlignment.Near
        '
        'CuiLabel3
        '
        Me.CuiLabel3.BackColor = System.Drawing.Color.Transparent
        Me.CuiLabel3.Content = "Dimensions"
        Me.CuiLabel3.Font = New System.Drawing.Font("Helvetica", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CuiLabel3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.CuiLabel3.HorizontalAlignment = System.Drawing.StringAlignment.Center
        Me.CuiLabel3.Location = New System.Drawing.Point(1109, 80)
        Me.CuiLabel3.Name = "CuiLabel3"
        Me.CuiLabel3.Size = New System.Drawing.Size(166, 32)
        Me.CuiLabel3.TabIndex = 105
        Me.CuiLabel3.VerticalAlignment = System.Drawing.StringAlignment.Near
        '
        'CuiLabel1
        '
        Me.CuiLabel1.BackColor = System.Drawing.Color.Transparent
        Me.CuiLabel1.Content = "Fluorescent"
        Me.CuiLabel1.Font = New System.Drawing.Font("Helvetica", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CuiLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.CuiLabel1.HorizontalAlignment = System.Drawing.StringAlignment.Center
        Me.CuiLabel1.Location = New System.Drawing.Point(1510, 80)
        Me.CuiLabel1.Name = "CuiLabel1"
        Me.CuiLabel1.Size = New System.Drawing.Size(166, 24)
        Me.CuiLabel1.TabIndex = 104
        Me.CuiLabel1.VerticalAlignment = System.Drawing.StringAlignment.Near
        '
        'CuiLabel2
        '
        Me.CuiLabel2.BackColor = System.Drawing.Color.Transparent
        Me.CuiLabel2.Content = "Radioactive"
        Me.CuiLabel2.Font = New System.Drawing.Font("Helvetica", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CuiLabel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.CuiLabel2.HorizontalAlignment = System.Drawing.StringAlignment.Center
        Me.CuiLabel2.Location = New System.Drawing.Point(1651, 80)
        Me.CuiLabel2.Name = "CuiLabel2"
        Me.CuiLabel2.Size = New System.Drawing.Size(180, 24)
        Me.CuiLabel2.TabIndex = 98
        Me.CuiLabel2.VerticalAlignment = System.Drawing.StringAlignment.Near
        '
        'CuiLabel6
        '
        Me.CuiLabel6.BackColor = System.Drawing.Color.Transparent
        Me.CuiLabel6.Content = "Country"
        Me.CuiLabel6.Font = New System.Drawing.Font("Helvetica", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CuiLabel6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.CuiLabel6.HorizontalAlignment = System.Drawing.StringAlignment.Center
        Me.CuiLabel6.Location = New System.Drawing.Point(275, 80)
        Me.CuiLabel6.Name = "CuiLabel6"
        Me.CuiLabel6.Size = New System.Drawing.Size(166, 30)
        Me.CuiLabel6.TabIndex = 95
        Me.CuiLabel6.VerticalAlignment = System.Drawing.StringAlignment.Near
        '
        'dimensions_txtbox
        '
        Me.dimensions_txtbox.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.dimensions_txtbox.Content = ""
        Me.dimensions_txtbox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.dimensions_txtbox.FocusBackgroundColor = System.Drawing.Color.FromArgb(CType(CType(166, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dimensions_txtbox.FocusImageTint = System.Drawing.Color.White
        Me.dimensions_txtbox.FocusOutlineColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.dimensions_txtbox.Font = New System.Drawing.Font("Helvetica", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dimensions_txtbox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.dimensions_txtbox.Image = Nothing
        Me.dimensions_txtbox.ImageExpand = New System.Drawing.Point(0, 0)
        Me.dimensions_txtbox.ImageOffset = New System.Drawing.Point(0, 0)
        Me.dimensions_txtbox.Location = New System.Drawing.Point(1121, 110)
        Me.dimensions_txtbox.Margin = New System.Windows.Forms.Padding(4)
        Me.dimensions_txtbox.Multiline = False
        Me.dimensions_txtbox.Name = "dimensions_txtbox"
        Me.dimensions_txtbox.NormalImageTint = System.Drawing.Color.Silver
        Me.dimensions_txtbox.OutlineColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.dimensions_txtbox.Padding = New System.Windows.Forms.Padding(23, 13, 23, 0)
        Me.dimensions_txtbox.PasswordChar = False
        Me.dimensions_txtbox.PlaceholderColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.dimensions_txtbox.PlaceholderText = "ex: 1 x 1 x 1 cm"
        Me.dimensions_txtbox.Rounding = New System.Windows.Forms.Padding(12)
        Me.dimensions_txtbox.Size = New System.Drawing.Size(240, 49)
        Me.dimensions_txtbox.TabIndex = 92
        Me.dimensions_txtbox.TextOffset = New System.Drawing.Size(0, 0)
        Me.dimensions_txtbox.UnderlinedStyle = True
        '
        'name_cmbbox
        '
        Me.name_cmbbox.BackColor = System.Drawing.Color.Transparent
        Me.name_cmbbox.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.name_cmbbox.Content = ""
        Me.name_cmbbox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.name_cmbbox.FocusBackgroundColor = System.Drawing.Color.FromArgb(CType(CType(166, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.name_cmbbox.FocusImageTint = System.Drawing.Color.White
        Me.name_cmbbox.FocusOutlineColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.name_cmbbox.Font = New System.Drawing.Font("Helvetica", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.name_cmbbox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.name_cmbbox.Image = Nothing
        Me.name_cmbbox.ImageExpand = New System.Drawing.Point(0, 0)
        Me.name_cmbbox.ImageOffset = New System.Drawing.Point(0, 0)
        Me.name_cmbbox.Location = New System.Drawing.Point(41, 110)
        Me.name_cmbbox.Margin = New System.Windows.Forms.Padding(4)
        Me.name_cmbbox.Multiline = False
        Me.name_cmbbox.Name = "name_cmbbox"
        Me.name_cmbbox.NormalImageTint = System.Drawing.Color.Silver
        Me.name_cmbbox.OutlineColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.name_cmbbox.Padding = New System.Windows.Forms.Padding(23, 13, 23, 0)
        Me.name_cmbbox.PasswordChar = False
        Me.name_cmbbox.PlaceholderColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.name_cmbbox.PlaceholderText = "Mineral Name"
        Me.name_cmbbox.Rounding = New System.Windows.Forms.Padding(12)
        Me.name_cmbbox.Size = New System.Drawing.Size(253, 49)
        Me.name_cmbbox.TabIndex = 83
        Me.name_cmbbox.TextOffset = New System.Drawing.Size(0, 0)
        Me.name_cmbbox.UnderlinedStyle = True
        '
        'CuiLabel5
        '
        Me.CuiLabel5.BackColor = System.Drawing.Color.Transparent
        Me.CuiLabel5.Content = "Minerals"
        Me.CuiLabel5.Font = New System.Drawing.Font("Helvetica", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CuiLabel5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.CuiLabel5.HorizontalAlignment = System.Drawing.StringAlignment.Center
        Me.CuiLabel5.Location = New System.Drawing.Point(-11, 13)
        Me.CuiLabel5.Name = "CuiLabel5"
        Me.CuiLabel5.Size = New System.Drawing.Size(235, 37)
        Me.CuiLabel5.TabIndex = 85
        Me.CuiLabel5.VerticalAlignment = System.Drawing.StringAlignment.Near
        '
        'CuiLabel15
        '
        Me.CuiLabel15.BackColor = System.Drawing.Color.Transparent
        Me.CuiLabel15.Content = "Name"
        Me.CuiLabel15.Font = New System.Drawing.Font("Helvetica", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CuiLabel15.ForeColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.CuiLabel15.HorizontalAlignment = System.Drawing.StringAlignment.Center
        Me.CuiLabel15.Location = New System.Drawing.Point(17, 80)
        Me.CuiLabel15.Name = "CuiLabel15"
        Me.CuiLabel15.Size = New System.Drawing.Size(128, 30)
        Me.CuiLabel15.TabIndex = 87
        Me.CuiLabel15.VerticalAlignment = System.Drawing.StringAlignment.Near
        '
        'CuiButton2
        '
        Me.CuiButton2.BackColor = System.Drawing.Color.Transparent
        Me.CuiButton2.CheckButton = False
        Me.CuiButton2.Checked = False
        Me.CuiButton2.CheckedBackground = System.Drawing.Color.FromArgb(CType(CType(166, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CuiButton2.CheckedForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(161, Byte), Integer))
        Me.CuiButton2.CheckedImageTint = System.Drawing.Color.White
        Me.CuiButton2.CheckedOutline = System.Drawing.Color.FromArgb(CType(CType(166, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CuiButton2.Content = "Add Mineral"
        Me.CuiButton2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CuiButton2.DialogResult = System.Windows.Forms.DialogResult.None
        Me.CuiButton2.Font = New System.Drawing.Font("Helvetica", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CuiButton2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.CuiButton2.HoverBackground = System.Drawing.Color.FromArgb(CType(CType(166, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CuiButton2.HoverForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(161, Byte), Integer))
        Me.CuiButton2.HoverImageTint = System.Drawing.Color.White
        Me.CuiButton2.HoverOutline = System.Drawing.Color.Transparent
        Me.CuiButton2.Image = CType(resources.GetObject("CuiButton2.Image"), System.Drawing.Image)
        'Me.CuiButton2.ImageAutoCenter = True
        Me.CuiButton2.ImageExpand = New System.Drawing.Point(0, 0)
        'Me.CuiButton2.ImageOffset = New System.Drawing.Point(0, 0)
        Me.CuiButton2.Location = New System.Drawing.Point(2143, 13)
        Me.CuiButton2.Margin = New System.Windows.Forms.Padding(2)
        Me.CuiButton2.Name = "CuiButton2"
        Me.CuiButton2.NormalBackground = System.Drawing.Color.FromArgb(CType(CType(166, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CuiButton2.NormalForeColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.CuiButton2.NormalImageTint = System.Drawing.Color.White
        Me.CuiButton2.NormalOutline = System.Drawing.Color.Transparent
        Me.CuiButton2.OutlineThickness = 1.0!
        Me.CuiButton2.PressedBackground = System.Drawing.Color.FromArgb(CType(CType(166, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CuiButton2.PressedForeColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.CuiButton2.PressedImageTint = System.Drawing.Color.White
        Me.CuiButton2.PressedOutline = System.Drawing.Color.Transparent
        Me.CuiButton2.Rounding = New System.Windows.Forms.Padding(8)
        Me.CuiButton2.Size = New System.Drawing.Size(144, 37)
        Me.CuiButton2.TabIndex = 86
        Me.CuiButton2.TextAlignment = System.Drawing.StringAlignment.Center
        'Me.CuiButton2.TextOffset = New System.Drawing.Point(5, 0)
        '
        'MaterialDivider1
        '
        Me.MaterialDivider1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(161, Byte), Integer))
        Me.MaterialDivider1.Depth = 0
        Me.MaterialDivider1.Location = New System.Drawing.Point(2, 186)
        Me.MaterialDivider1.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER
        Me.MaterialDivider1.Name = "MaterialDivider1"
        Me.MaterialDivider1.Size = New System.Drawing.Size(2314, 1)
        Me.MaterialDivider1.TabIndex = 9
        Me.MaterialDivider1.Text = "MaterialDivider1"
        '
        'HopeContextMenuStrip1
        '
        Me.HopeContextMenuStrip1.AutoSize = False
        Me.HopeContextMenuStrip1.BackColor = System.Drawing.Color.White
        Me.HopeContextMenuStrip1.Font = New System.Drawing.Font("Helvetica", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HopeContextMenuStrip1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.HopeContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LOLToolStripMenuItem, Me.ToolStripMenuItem1, Me.DeleteToolStripMenuItem})
        Me.HopeContextMenuStrip1.Name = "HopeContextMenuStrip1"
        Me.HopeContextMenuStrip1.Size = New System.Drawing.Size(182, 105)
        '
        'LOLToolStripMenuItem
        '
        Me.LOLToolStripMenuItem.AutoSize = False
        Me.LOLToolStripMenuItem.Font = New System.Drawing.Font("Helvetica", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LOLToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LOLToolStripMenuItem.Name = "LOLToolStripMenuItem"
        Me.LOLToolStripMenuItem.Size = New System.Drawing.Size(180, 32)
        Me.LOLToolStripMenuItem.Text = "View"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.AutoSize = False
        Me.ToolStripMenuItem1.Font = New System.Drawing.Font("Helvetica", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripMenuItem1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(180, 32)
        Me.ToolStripMenuItem1.Text = "Edit"
        '
        'DeleteToolStripMenuItem
        '
        Me.DeleteToolStripMenuItem.AutoSize = False
        Me.DeleteToolStripMenuItem.Font = New System.Drawing.Font("Helvetica", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DeleteToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem"
        Me.DeleteToolStripMenuItem.Size = New System.Drawing.Size(180, 32)
        Me.DeleteToolStripMenuItem.Text = "Delete"
        '
        'minerals
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(166, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Controls.Add(Me.MaterialDivider1)
        Me.Controls.Add(Me.CuiPanel1)
        Me.Controls.Add(Me.minerals_grid)
        Me.Name = "minerals"
        Me.Size = New System.Drawing.Size(2318, 1177)
        CType(Me.MineralsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Mim_museum_dataset, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.minerals_grid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CuiPanel1.ResumeLayout(False)
        Me.HopeContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Mim_museum_dataset As mim_museum_dataset
    Friend WithEvents MineralsBindingSource As BindingSource
    Friend WithEvents MineralsTableAdapter As mim_museum_datasetTableAdapters.mineralsTableAdapter
    Friend WithEvents minerals_grid As MetroFramework.Controls.MetroGrid
    Friend WithEvents CuiPanel1 As CuoreUI.Controls.cuiPanel
    Friend WithEvents CuiLabel7 As CuoreUI.Controls.cuiLabel
    Friend WithEvents CuiLabel3 As CuoreUI.Controls.cuiLabel
    Friend WithEvents CuiLabel1 As CuoreUI.Controls.cuiLabel
    Friend WithEvents CuiLabel2 As CuoreUI.Controls.cuiLabel
    Friend WithEvents CuiLabel6 As CuoreUI.Controls.cuiLabel
    Friend WithEvents dimensions_txtbox As CuoreUI.Controls.cuiTextBox
    Friend WithEvents name_cmbbox As CuoreUI.Controls.cuiTextBox
    Friend WithEvents CuiLabel5 As CuoreUI.Controls.cuiLabel
    Friend WithEvents CuiLabel15 As CuoreUI.Controls.cuiLabel
    Friend WithEvents CuiButton2 As CuoreUI.Controls.cuiButton
    Friend WithEvents search_btn As CuoreUI.Controls.cuiButton
    Friend WithEvents reset_btn As CuoreUI.Controls.cuiButton
    Friend WithEvents fluorescent_switch As CuoreUI.Controls.cuiSwitch
    Friend WithEvents radioactive_switch As CuoreUI.Controls.cuiSwitch
    Friend WithEvents section_cmbbox As CuoreUI.Controls.cuiComboBox
    Friend WithEvents CuiLabel8 As CuoreUI.Controls.cuiLabel
    Friend WithEvents class_cmbbox As CuoreUI.Controls.cuiComboBox
    Friend WithEvents CuiLabel4 As CuoreUI.Controls.cuiLabel
    Friend WithEvents country_cmbbox As CuoreUI.Controls.cuiComboBox
    Friend WithEvents hardness_scale As ReaLTaiizor.Controls.HopeNumeric
    Friend WithEvents MaterialDivider1 As ReaLTaiizor.Controls.MaterialDivider
    Friend WithEvents HopeContextMenuStrip1 As ReaLTaiizor.Controls.HopeContextMenuStrip
    Friend WithEvents LOLToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DeleteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents MineraltagDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MineralnameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ChemformulaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ClassidDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CountryidDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SectionidDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DimensionsDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents HardnesslvlDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MineraldescDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IsfluorescentDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents IsradioactiveDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
End Class
