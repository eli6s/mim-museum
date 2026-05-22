<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class positions
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.MaterialDivider1 = New ReaLTaiizor.Controls.MaterialDivider()
        Me.search_input = New CuoreUI.Controls.cuiTextBox()
        Me.positions_grid = New MetroFramework.Controls.MetroGrid()
        CType(Me.positions_grid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MaterialDivider1
        '
        Me.MaterialDivider1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(161, Byte), Integer))
        Me.MaterialDivider1.Depth = 0
        Me.MaterialDivider1.Location = New System.Drawing.Point(2, 189)
        Me.MaterialDivider1.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER
        Me.MaterialDivider1.Name = "MaterialDivider1"
        Me.MaterialDivider1.Size = New System.Drawing.Size(2314, 1)
        Me.MaterialDivider1.TabIndex = 129
        Me.MaterialDivider1.Text = "MaterialDivider1"
        '
        'search_input
        '
        Me.search_input.BackColor = System.Drawing.Color.Transparent
        Me.search_input.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.search_input.Content = ""
        Me.search_input.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.search_input.FocusBackgroundColor = System.Drawing.Color.FromArgb(CType(CType(166, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.search_input.FocusImageTint = System.Drawing.Color.White
        Me.search_input.FocusOutlineColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.search_input.Font = New System.Drawing.Font("Helvetica", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.search_input.ForeColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.search_input.Image = Nothing
        Me.search_input.ImageExpand = New System.Drawing.Point(0, 0)
        Me.search_input.ImageOffset = New System.Drawing.Point(0, 0)
        Me.search_input.Location = New System.Drawing.Point(499, 90)
        Me.search_input.Margin = New System.Windows.Forms.Padding(4)
        Me.search_input.Multiline = False
        Me.search_input.Name = "search_input"
        Me.search_input.NormalImageTint = System.Drawing.Color.Silver
        Me.search_input.OutlineColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.search_input.Padding = New System.Windows.Forms.Padding(23, 19, 23, 0)
        Me.search_input.PasswordChar = False
        Me.search_input.PlaceholderColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.search_input.PlaceholderText = "Search"
        Me.search_input.Rounding = New System.Windows.Forms.Padding(12)
        Me.search_input.Size = New System.Drawing.Size(1304, 61)
        Me.search_input.TabIndex = 128
        Me.search_input.TextOffset = New System.Drawing.Size(0, 0)
        Me.search_input.UnderlinedStyle = True
        '
        'positions_grid
        '
        Me.positions_grid.AllowUserToAddRows = False
        Me.positions_grid.AllowUserToDeleteRows = False
        Me.positions_grid.AllowUserToResizeColumns = False
        Me.positions_grid.AllowUserToResizeRows = False
        Me.positions_grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.positions_grid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.positions_grid.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.positions_grid.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.positions_grid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenHorizontal
        Me.positions_grid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(84, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Helvetica", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle1.Padding = New System.Windows.Forms.Padding(10, 0, 10, 0)
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(84, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.positions_grid.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.positions_grid.ColumnHeadersHeight = 70
        Me.positions_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Helvetica", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.positions_grid.DefaultCellStyle = DataGridViewCellStyle2
        Me.positions_grid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2
        Me.positions_grid.EnableHeadersVisualStyles = False
        Me.positions_grid.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.positions_grid.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.positions_grid.Location = New System.Drawing.Point(84, 230)
        Me.positions_grid.Name = "positions_grid"
        Me.positions_grid.ReadOnly = True
        Me.positions_grid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(217, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Helvetica", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(250, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.positions_grid.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.positions_grid.RowHeadersVisible = False
        Me.positions_grid.RowHeadersWidth = 50
        Me.positions_grid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(217, Byte), Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Helvetica", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle4.Padding = New System.Windows.Forms.Padding(0, 15, 0, 20)
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(250, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White
        Me.positions_grid.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.positions_grid.RowTemplate.Height = 42
        Me.positions_grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.positions_grid.Size = New System.Drawing.Size(2147, 970)
        Me.positions_grid.TabIndex = 127
        '
        'positions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(166, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Controls.Add(Me.MaterialDivider1)
        Me.Controls.Add(Me.search_input)
        Me.Controls.Add(Me.positions_grid)
        Me.Name = "positions"
        Me.Size = New System.Drawing.Size(2318, 1291)
        CType(Me.positions_grid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MaterialDivider1 As ReaLTaiizor.Controls.MaterialDivider
    Friend WithEvents search_input As CuoreUI.Controls.cuiTextBox
    Friend WithEvents positions_grid As MetroFramework.Controls.MetroGrid
End Class
