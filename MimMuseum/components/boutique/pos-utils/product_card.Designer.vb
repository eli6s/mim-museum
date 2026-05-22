<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class product_card
    Inherits System.Windows.Forms.UserControl

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

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.picItem = New System.Windows.Forms.PictureBox()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblPrice = New System.Windows.Forms.Label()
        CType(Me.picItem, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picItem
        '
        Me.picItem.BackColor = System.Drawing.Color.WhiteSmoke
        Me.picItem.Dock = System.Windows.Forms.DockStyle.Top
        Me.picItem.Location = New System.Drawing.Point(0, 0)
        Me.picItem.Name = "picItem"
        Me.picItem.Size = New System.Drawing.Size(152, 100)
        Me.picItem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picItem.TabIndex = 0
        Me.picItem.TabStop = False
        '
        'lblName
        '
        Me.lblName.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblName.Font = New System.Drawing.Font("Helvetica", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.lblName.Location = New System.Drawing.Point(0, 100)
        Me.lblName.Name = "lblName"
        Me.lblName.Padding = New System.Windows.Forms.Padding(4, 4, 4, 0)
        Me.lblName.Size = New System.Drawing.Size(152, 42)
        Me.lblName.TabIndex = 1
        Me.lblName.Text = "Item Name"
        Me.lblName.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblPrice
        '
        Me.lblPrice.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblPrice.Font = New System.Drawing.Font("Helvetica", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrice.ForeColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.lblPrice.Location = New System.Drawing.Point(0, 142)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(152, 24)
        Me.lblPrice.TabIndex = 2
        Me.lblPrice.Text = "$0.00"
        Me.lblPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'product_card
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Controls.Add(Me.lblPrice)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.picItem)
        Me.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Name = "product_card"
        Me.Size = New System.Drawing.Size(152, 182)
        CType(Me.picItem, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents picItem As PictureBox
    Friend WithEvents lblName As Label
    Friend WithEvents lblPrice As Label

End Class