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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(boutique_dashboard))
        Me.ParrotPieGraph1 = New ReaLTaiizor.Controls.ParrotPieGraph()
        Me.ParrotPieGraph2 = New ReaLTaiizor.Controls.ParrotPieGraph()
        Me.SuspendLayout()
        '
        'ParrotPieGraph1
        '
        Me.ParrotPieGraph1.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.ParrotPieGraph1.Colors = CType(resources.GetObject("ParrotPieGraph1.Colors"), System.Collections.Generic.List(Of System.Drawing.Color))
        Me.ParrotPieGraph1.Location = New System.Drawing.Point(343, 177)
        Me.ParrotPieGraph1.Name = "ParrotPieGraph1"
        Me.ParrotPieGraph1.Numbers = CType(resources.GetObject("ParrotPieGraph1.Numbers"), System.Collections.Generic.List(Of Integer))
        Me.ParrotPieGraph1.Size = New System.Drawing.Size(100, 100)
        Me.ParrotPieGraph1.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias
        Me.ParrotPieGraph1.TabIndex = 0
        Me.ParrotPieGraph1.Text = "ParrotPieGraph1"
        '
        'ParrotPieGraph2
        '
        Me.ParrotPieGraph2.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.ParrotPieGraph2.Colors = CType(resources.GetObject("ParrotPieGraph2.Colors"), System.Collections.Generic.List(Of System.Drawing.Color))
        Me.ParrotPieGraph2.Location = New System.Drawing.Point(532, 225)
        Me.ParrotPieGraph2.Name = "ParrotPieGraph2"
        Me.ParrotPieGraph2.Numbers = CType(resources.GetObject("ParrotPieGraph2.Numbers"), System.Collections.Generic.List(Of Integer))
        Me.ParrotPieGraph2.Size = New System.Drawing.Size(100, 100)
        Me.ParrotPieGraph2.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias
        Me.ParrotPieGraph2.TabIndex = 1
        Me.ParrotPieGraph2.Text = "ParrotPieGraph2"
        '
        'boutique_dashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.Controls.Add(Me.ParrotPieGraph2)
        Me.Controls.Add(Me.ParrotPieGraph1)
        Me.Name = "boutique_dashboard"
        Me.Size = New System.Drawing.Size(819, 460)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ParrotPieGraph1 As ReaLTaiizor.Controls.ParrotPieGraph
    Friend WithEvents ParrotPieGraph2 As ReaLTaiizor.Controls.ParrotPieGraph
End Class
