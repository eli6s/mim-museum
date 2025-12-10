Public Class minerals
    Private Sub minerals_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.ClassificationsTableAdapter.Fill(Me.Mim_museum_dataset.classifications)
    End Sub

    Private Sub MetroGrid1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles MetroGrid1.CellContentClick

    End Sub
End Class
