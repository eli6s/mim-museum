' boutique equipment host. wraps the shared museum_equipment user control
' with building_filter = "boutique" so the grid + inserts use that building tag.
Public Class boutique_equipment

    Private Sub boutique_equipment_load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' spin up the shared form, override the filter, dock to fill
        Dim shared_form As New museum_equipment() With {
            .building_filter = "boutique",
            .Dock = DockStyle.Fill
        }
        Me.Controls.Clear()
        Me.Controls.Add(shared_form)
    End Sub

End Class