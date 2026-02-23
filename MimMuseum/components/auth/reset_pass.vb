Imports System.Random
Imports System.Security

Public Class reset_pass
    Private ReadOnly db_obj As New db_controller()
    Dim verification_code As Integer

    Private Sub send_code_btn_Click(sender As Object, e As EventArgs) Handles send_code_btn.Click
        Dim email As String = email_txtbox.Content.ToLower()

        If Not valid_email(email) Then
            Vip.Notification.Alert.ShowError("Invalid email.. make sure the format is correct")
            Return
        End If

        Dim user_info = db_obj.fetch_row(
            "
            SELECT e.employee_id, u.username
            FROM employees e
            INNER JOIN users u ON e.employee_id = u.employee_id
            WHERE e.email = @email
            ",
            New Dictionary(Of String, Object) From {
                {"email", email}
            }
        )

        'if no record was found of the user
        If user_info Is Nothing Then
            Vip.Notification.Alert.ShowError("The email you entered is not registered in our database")
            Return
        End If

        Dim employee_id = user_info("employee_id")
        Dim username = user_info("username")

        session_manager.start_password_reset(employee_id, username)

        Dim rnd As New Random()
        verification_code = rnd.Next(100000, 990000)

        Dim subject As String = "MIM Museum Password Reset"
        Dim content As String =
$"
Hi there,

You, or someone who thinks they are you, have requested a password reset for {email}

To reset your password, enter this verification code when prompted:
{verification_code}

If you did not make this request, you can ignore this email.

Regards,
MIM Museum
https://www.mim.museum/
"
        'If email = "johndoe@gmail.com" Then
        '    Vip.Notification.Alert.ShowSucess($"A reset password verification code has been sent to your email {verification_code}")
        '    send_code_btn.Visible = False
        '    email_txtbox.Visible = False
        '    verif_code_box.Visible = True

        'End If

        Dim status As Integer = send_email(email, subject, content)

        If status = 1 Then
            Vip.Notification.Alert.ShowSucess("A reset password verification code has been sent to your email")
            send_code_btn.Visible = False
            email_txtbox.Visible = False
            verif_code_box.Visible = True
        Else
            Vip.Notification.Alert.ShowError("An error occured while trying to send you an email. Please try again later")
            Return
        End If
    End Sub


    Private Sub verif_code_box_FinishedTypingContent(sender As Object, e As EventArgs) Handles verif_code_box.FinishedTypingContent
        Dim entered_code As Integer = verif_code_box.Content

        If entered_code <> verification_code Then
            Vip.Notification.Alert.ShowError("Invalid code entered")
            Return
        End If

        remove_ctrl(main, ctrl_names.reset_pass)
        Dim new_pass_ctrl = add_ctrl(Of new_pass)(main, ctrl_names.new_pass)
    End Sub
End Class
