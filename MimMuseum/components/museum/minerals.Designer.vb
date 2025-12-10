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
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(minerals))
        Me.MetroGrid1 = New MetroFramework.Controls.MetroGrid()
        Me.ClassidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ClassnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ClassificationsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Mim_museum_dataset = New MimMuseum.mim_museum_dataset()
        Me.ClassificationsTableAdapter = New MimMuseum.mim_museum_datasetTableAdapters.classificationsTableAdapter()
        Me.minerals_btn = New CuoreUI.Controls.cuiButton()
        CType(Me.MetroGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClassificationsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Mim_museum_dataset, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MetroGrid1
        '
        Me.MetroGrid1.AllowUserToAddRows = False
        Me.MetroGrid1.AllowUserToResizeRows = False
        Me.MetroGrid1.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.MetroGrid1.AutoGenerateColumns = False
        Me.MetroGrid1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.MetroGrid1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.MetroGrid1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.MetroGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.MetroGrid1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.MetroGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(250, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Helvetica", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(250, Byte), Integer))
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.MetroGrid1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.MetroGrid1.ColumnHeadersHeight = 60
        Me.MetroGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.MetroGrid1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ClassidDataGridViewTextBoxColumn, Me.ClassnameDataGridViewTextBoxColumn})
        Me.MetroGrid1.DataSource = Me.ClassificationsBindingSource
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.MetroGrid1.DefaultCellStyle = DataGridViewCellStyle6
        Me.MetroGrid1.EnableHeadersVisualStyles = False
        Me.MetroGrid1.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.MetroGrid1.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MetroGrid1.Location = New System.Drawing.Point(25, 137)
        Me.MetroGrid1.Name = "MetroGrid1"
        Me.MetroGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(250, Byte), Integer))
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Helvetica", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(250, Byte), Integer))
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.MetroGrid1.RowHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.MetroGrid1.RowHeadersWidth = 50
        Me.MetroGrid1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(217, Byte), Integer))
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Helvetica", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(250, Byte), Integer))
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White
        Me.MetroGrid1.RowsDefaultCellStyle = DataGridViewCellStyle8
        Me.MetroGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.MetroGrid1.Size = New System.Drawing.Size(1773, 742)
        Me.MetroGrid1.TabIndex = 1
        '
        'ClassidDataGridViewTextBoxColumn
        '
        Me.ClassidDataGridViewTextBoxColumn.DataPropertyName = "class_id"
        Me.ClassidDataGridViewTextBoxColumn.HeaderText = "class_id"
        Me.ClassidDataGridViewTextBoxColumn.Name = "ClassidDataGridViewTextBoxColumn"
        Me.ClassidDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ClassnameDataGridViewTextBoxColumn
        '
        Me.ClassnameDataGridViewTextBoxColumn.DataPropertyName = "class_name"
        Me.ClassnameDataGridViewTextBoxColumn.HeaderText = "class_name"
        Me.ClassnameDataGridViewTextBoxColumn.Name = "ClassnameDataGridViewTextBoxColumn"
        '
        'ClassificationsBindingSource
        '
        Me.ClassificationsBindingSource.DataMember = "classifications"
        Me.ClassificationsBindingSource.DataSource = Me.Mim_museum_dataset
        '
        'Mim_museum_dataset
        '
        Me.Mim_museum_dataset.DataSetName = "mim_museum_dataset"
        Me.Mim_museum_dataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ClassificationsTableAdapter
        '
        Me.ClassificationsTableAdapter.ClearBeforeFill = True
        '
        'minerals_btn
        '
        Me.minerals_btn.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.minerals_btn.CheckButton = False
        Me.minerals_btn.Checked = False
        Me.minerals_btn.CheckedBackground = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.minerals_btn.CheckedForeColor = System.Drawing.Color.White
        Me.minerals_btn.CheckedImageTint = System.Drawing.Color.White
        Me.minerals_btn.CheckedOutline = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.minerals_btn.Content = "Add Mineral"
        Me.minerals_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.minerals_btn.DialogResult = System.Windows.Forms.DialogResult.None
        Me.minerals_btn.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.minerals_btn.Font = New System.Drawing.Font("Helvetica", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.minerals_btn.ForeColor = System.Drawing.Color.White
        Me.minerals_btn.HoverBackground = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.minerals_btn.HoverForeColor = System.Drawing.Color.White
        Me.minerals_btn.HoverImageTint = System.Drawing.Color.White
        Me.minerals_btn.HoverOutline = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.minerals_btn.Image = CType(resources.GetObject("minerals_btn.Image"), System.Drawing.Image)
        Me.minerals_btn.ImageAutoCenter = False
        Me.minerals_btn.ImageExpand = New System.Drawing.Point(3, 3)
        Me.minerals_btn.ImageOffset = New System.Drawing.Point(50, 0)
        Me.minerals_btn.ImeMode = System.Windows.Forms.ImeMode.Close
        Me.minerals_btn.Location = New System.Drawing.Point(0, 892)
        Me.minerals_btn.Name = "minerals_btn"
        Me.minerals_btn.NormalBackground = System.Drawing.Color.Transparent
        Me.minerals_btn.NormalForeColor = System.Drawing.Color.White
        Me.minerals_btn.NormalImageTint = System.Drawing.Color.White
        Me.minerals_btn.NormalOutline = System.Drawing.Color.Transparent
        Me.minerals_btn.OutlineThickness = 1.0!
        Me.minerals_btn.PressedBackground = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.minerals_btn.PressedForeColor = System.Drawing.Color.White
        Me.minerals_btn.PressedImageTint = System.Drawing.Color.White
        Me.minerals_btn.PressedOutline = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.minerals_btn.Rounding = New System.Windows.Forms.Padding(8)
        Me.minerals_btn.Size = New System.Drawing.Size(1840, 63)
        Me.minerals_btn.TabIndex = 4
        Me.minerals_btn.TextAlignment = System.Drawing.StringAlignment.Near
        Me.minerals_btn.TextOffset = New System.Drawing.Point(60, 0)
        '
        'minerals
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(166, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Controls.Add(Me.minerals_btn)
        Me.Controls.Add(Me.MetroGrid1)
        Me.Name = "minerals"
        Me.Size = New System.Drawing.Size(1840, 955)
        CType(Me.MetroGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClassificationsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Mim_museum_dataset, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MetroGrid1 As MetroFramework.Controls.MetroGrid
    Friend WithEvents Mim_museum_dataset As mim_museum_dataset
    Friend WithEvents ClassidDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ClassnameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ClassificationsBindingSource As BindingSource
    Friend WithEvents ClassificationsTableAdapter As mim_museum_datasetTableAdapters.classificationsTableAdapter
    Friend WithEvents minerals_btn As CuoreUI.Controls.cuiButton
End Class
