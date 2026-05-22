' boutique maintenance host. wraps the shared museum_maintenance user control
' with building_filter = "boutique".
Public Class maintenance

    Private Sub maintenance_load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim shared_form As New museum_maintenance() With {
            .building_filter = "boutique",
            .Dock = DockStyle.Fill
        }
        Me.Controls.Clear()
        Me.Controls.Add(shared_form)
    End Sub

End Class