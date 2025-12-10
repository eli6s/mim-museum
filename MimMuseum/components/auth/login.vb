Public Class login
    Dim db_obj As New db_controller()

    Private Sub toggle_pass_switch_CheckedChanged(sender As Object, e As EventArgs) Handles toggle_pass_switch.CheckedChanged
        If pass_txtbox.PasswordChar Then
            pass_txtbox.PasswordChar = False
            Return
        End If
        pass_txtbox.PasswordChar = True
    End Sub


    Private Sub pass_txtbox_ContentChanged(sender As Object, e As EventArgs) Handles pass_txtbox.ContentChanged
        toggle_login_btn(Me)
    End Sub


    Private Sub username_txtbox_ContentChanged(sender As Object, e As EventArgs) Handles username_txtbox.ContentChanged
        toggle_login_btn(Me)
    End Sub

    'TODO: KeyDown might not be firing cus of the focus
    Private Sub forgot_pass_link_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles forgot_pass_link.LinkClicked
        remove_ctrl(main, "login")
        Dim reset_pass_ctrl = add_ctrl(Of reset_pass)(main, "reset-pass")
        reset_pass_ctrl.Focus()

    End Sub

    'TODO
    Private Sub login_btn_Click(sender As Object, e As EventArgs) Handles login_btn.Click
        Dim username = username_txtbox.Content.ToLower()
        Dim pass_hash = db_obj.fetch_val(
            "
            SELECT password_hash
            FROM users
            WHERE username = @username
            ",
            New Dictionary(Of String, Object) From {
                {"username", username}
            }
        )

        ' if no record was found for the user
        If pass_hash Is Nothing Then
            MsgBox("invalid username or Pass")
            Return
        End If

        Dim is_valid_pass = valid_password(pass_txtbox.Content, pass_hash)

        'remove the login user control and load the admin panel ones
        If is_valid_pass Then
            session_username = username
            main.BackgroundImage = Nothing
            remove_ctrl(main, "login")

            Dim header_ctrl = add_ctrl(Of header)(main, "header", location:=New Point(0, 0))
            Dim side_nav_ctrl = add_ctrl(Of side_nav)(main, "side-nav", DockStyle.Left)
            side_nav_ctrl.BringToFront()

            Dim museum_dashboard_ctrl = add_ctrl(Of museum_dashboard)(main, "admin-active-ctrl", DockStyle.Fill)
            museum_dashboard_ctrl.Focus()

            ' by default, the active user control is the museum dashboard
            Dim active_ctrl_path As String = $"{side_nav_ctrl.museum_submenu.Tag} | {main.ActiveControl.Tag}"
            set_active_path(main, "header", active_ctrl_path)
        Else
            MsgBox("invalid pass")
        End If
        '1234 hash
    End Sub

End Class
