Public Class new_pass
    Private ReadOnly db_obj As New db_controller()

    Private Sub set_pass_btn_Click(sender As Object, e As EventArgs) Handles set_pass_btn.Click
        Dim new_pass As String = new_pass_txtbox.Content
        Dim confirmed_new_pass As String = confirm_pass_txtbox.Content

        If new_pass <> confirmed_new_pass Then
            Vip.Notification.Alert.ShowError("Confirmed password does not match")
            Return
        End If

        Dim password_hash As String = db_obj.fetch_val(
            "
            SELECT password_hash
            FROM users
            WHERE employee_id = @employee_id
            ",
            New Dictionary(Of String, Object) From {
                {"employee_id", session_manager.employee_id}
            }
        )

        ' compare the current password's hash to the new password
        ' if they match, it means the new password is the same as the current one
        ' therefore an error must be displayed
        If valid_password(new_pass, password_hash) Then
            Vip.Notification.Alert.ShowError("The new password cannot be the same as your old one")
            Return
        End If

        Dim new_hash As String = generate_password_hash(new_pass)

        db_obj.execute(
            "
            UPDATE users 
            SET password_hash = @new_hash
            WHERE employee_id = @employee_id
            ",
            New Dictionary(Of String, Object) From {
                {"employee_id", session_manager.employee_id},
                {"new_hash", new_hash}
            }
        )
        Vip.Notification.Alert.ShowSucess("Your password has been changed successfully")

        ' only redirect to login if we're in the forgot-password flow (not from settings)
        If main.Controls.OfType(Of new_pass)().Any() Then
            remove_ctrl(main, ctrl_names.new_pass)
            add_ctrl(Of login)(main, ctrl_names.login)
        Else
            ' settings flow — we're hosted in a modal wrapper, close it
            Me.FindForm()?.Close()
        End If
    End Sub

End Class
