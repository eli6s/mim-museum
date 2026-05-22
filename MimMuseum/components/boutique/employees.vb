' boutique employees host. wraps the shared museum_employees user control
' with building_filter = "boutique" so it only shows cashiers.
Public Class boutique_employees

    Private Sub employees_load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' spin up the shared form, set the filter to boutique, dock it to fill the host
        Dim shared_form As New museum_employees() With {
            .building_filter = "boutique",
            .Dock = DockStyle.Fill
        }
        Me.Controls.Clear()
        Me.Controls.Add(shared_form)
    End Sub

End Class