
Public Class login
    Private ReadOnly db_obj As New db_controller()


    'disable the login button when both the username & password fields are empty, enable it otherwise
    Public Sub toggle_login_btn(login_form As login)
        If Not String.IsNullOrWhiteSpace(login_form.username_txtbox.Content) And
           Not String.IsNullOrWhiteSpace(login_form.pass_txtbox.Content) Then
            login_form.login_btn.Enabled = True
            Return
        End If
        login_form.login_btn.Enabled = False
    End Sub


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


    Private Sub forgot_pass_link_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles forgot_pass_link.LinkClicked
        remove_ctrl(main, ctrl_names.login)
        Dim reset_pass_ctrl = add_ctrl(Of reset_pass)(main, ctrl_names.reset_pass)
        reset_pass_ctrl.Focus()
    End Sub


    'TODO
    Private Sub login_btn_Click(sender As Object, e As EventArgs) Handles login_btn.Click
        ' ENUM TESTING
        '' In dropdown
        ''event_status_combo.DataSource = [Enum].GetValues(GetType(EventStatus))
        ''event_status_combo.SelectedItem = EventStatus.Active

        Dim username = username_txtbox.Content.ToLower()

        'validate input
        If String.IsNullOrEmpty(username) Or String.IsNullOrEmpty(pass_txtbox.Content) Then
            Vip.Notification.Alert.ShowError("Please enter both username and password")
            Return
        End If

        Dim user_data = db_obj.fetch_row(
            "
            SELECT
                e.employee_id,
                u.password_hash,
                e.position_id,
                p.position_title
            FROM users u
            INNER JOIN employees e ON u.employee_id = e.employee_id
            INNER JOIN positions p ON e.position_id = p.position_id
            WHERE u.username = @username
            ",
            New Dictionary(Of String, Object) From {
                {"username", username}
            }
        )

        'user not found
        If user_data Is Nothing Then
            Vip.Notification.Alert.ShowError("Invalid username or password")
            Return
        End If

        'validate password
        Dim pass_hash = user_data("password_hash").ToString()
        If Not valid_password(pass_txtbox.Content, pass_hash) Then
            Vip.Notification.Alert.ShowError("Invalid username or password")
            Return
        End If

        db_obj.execute(
            "
            UPDATE users
            SET last_login = SYSDATETIME()
            WHERE username = @username
            ",
            New Dictionary(Of String, Object) From {
                {"username", username}
            }
        )

        Dim employee_id = CInt(user_data("employee_id"))
        Dim position_title = user_data("position_title")
        'convert the position title to an enum
        Dim position As UserPosition = [Enum].Parse(GetType(UserPosition), position_title, True)

        session_manager.login(employee_id, username, position)

        MsgBox(session_manager.employee_id)
        MsgBox(session_manager.user_name)
        MsgBox(session_manager.position)


        main.BackgroundImage = Nothing
        remove_ctrl(main, ctrl_names.login)

        main.header_pnl.Visible = True
        main.side_nav_pnl.Visible = True
        main.main_pnl.Visible = True
        'main.pagination_pnl.Visible = True     // TODO: only make it visible in certain forms

        Dim header_ctrl = add_ctrl(Of header)(
            main.header_pnl,
            ctrl_names.header,
            DockStyle.Top
            )

        Dim side_nav_ctrl = add_ctrl(Of side_nav)(
            main.side_nav_pnl,
            ctrl_names.side_nav,
            DockStyle.Fill
            )

        Dim museum_dashboard_ctrl = add_ctrl(Of museum_dashboard)(
            main.main_pnl,
            ctrl_names.admin_active,
            DockStyle.Fill
            )

        museum_dashboard_ctrl.Focus()
    End Sub

End Class
