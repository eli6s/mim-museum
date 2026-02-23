Public Class header

    Private Sub header_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        session_username_lbl.Text = session_manager.user_name
        position_lbl.Text = session_manager.position.ToString().ToLower()
    End Sub

End Class
