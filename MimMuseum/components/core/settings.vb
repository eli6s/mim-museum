' settings form. shows the logged-in user's profile info.
' read-only labels for identity fields (name, gender, dob, hire date,
' position, salary, username). only email, phone, and home address
' are editable. password is changed via change_pass_btn which opens
' the new_pass form as a modal dialog.

Public Class settings
    Private ReadOnly db_obj As New db_controller()

    ' keep the original values around so cancel can restore them
    Private original_email As String = ""
    Private original_phone As String = ""
    Private original_addr As String = ""


    Private Sub settings_load(sender As Object, e As EventArgs) Handles MyBase.Load
        load_profile()
    End Sub


    Private Sub load_profile()
        Try
            Dim sql = "
                SELECT
                    e.first_name,
                    e.last_name,
                    e.gender,
                    e.date_of_birth,
                    e.hire_date,
                    e.email,
                    e.phone_num,
                    e.home_addr,
                    e.monthly_salary,
                    p.position_title,
                    u.username
                FROM employees e
                INNER JOIN positions p ON e.position_id = p.position_id
                INNER JOIN users u ON u.employee_id = e.employee_id
                WHERE e.employee_id = @employee_id
            "

            Dim rows = db_obj.fetch(sql,
                New Dictionary(Of String, Object) From {{"employee_id", session_manager.employee_id}})

            If rows.Count = 0 Then
                Vip.Notification.Alert.ShowError("Could not load profile.")
                Return
            End If

            Dim row = rows(0)

            ' populate the read-only labels
            first_name_lbl.Content = row("first_name").ToString()
            last_name_lbl.Content = row("last_name").ToString()
            gender_lbl.Content = capitalize_first(row("gender").ToString())
            dob_lbl.Content = Convert.ToDateTime(row("date_of_birth")).ToString("MMM d, yyyy")
            hire_date_lbl.Content = Convert.ToDateTime(row("hire_date")).ToString("MMM d, yyyy")
            position_lbl.Content = capitalize_first(row("position_title").ToString())
            salary_lbl.Content = CDec(row("monthly_salary")).ToString("C2")
            username_lbl.Content = row("username").ToString()

            ' populate the editable inputs and remember the originals
            original_email = row("email").ToString()
            original_phone = row("phone_num").ToString()
            original_addr = row("home_addr").ToString()

            email_input.Text = original_email
            phone_input.Text = original_phone
            home_addr_input.Text = original_addr
        Catch ex As Exception
            Vip.Notification.Alert.ShowError($"Profile load error: {ex.Message}")
        End Try
    End Sub


    ' simple helper to capitalize the first letter (e.g. "manager" → "Manager")
    Private Function capitalize_first(s As String) As String
        If String.IsNullOrEmpty(s) Then Return s
        Return s.Substring(0, 1).ToUpper() & s.Substring(1).ToLower()
    End Function


    Private Sub save_btn_click(sender As Object, e As EventArgs) Handles save_btn.Click
        Dim err = validate_inputs()
        If err IsNot Nothing Then
            Vip.Notification.Alert.ShowWarning(err)
            Return
        End If

        Try
            db_obj.execute(
                "
                UPDATE employees
                SET email     = @email,
                    phone_num = @phone_num,
                    home_addr = @home_addr
                WHERE employee_id = @employee_id
                ",
                New Dictionary(Of String, Object) From {
                    {"email", email_input.Text.Trim()},
                    {"phone_num", phone_input.Text.Trim()},
                    {"home_addr", home_addr_input.Text.Trim()},
                    {"employee_id", session_manager.employee_id}
                })

            ' update the original values so subsequent cancels restore the new state
            original_email = email_input.Text.Trim()
            original_phone = phone_input.Text.Trim()
            original_addr = home_addr_input.Text.Trim()

            Vip.Notification.Alert.ShowSucess("Profile updated.")
        Catch ex As Exception
            Vip.Notification.Alert.ShowError($"Update error: {ex.Message}")
        End Try
    End Sub


    Private Sub cancel_btn_click(sender As Object, e As EventArgs) Handles cancel_btn.Click
        ' revert to the originals
        email_input.Text = original_email
        phone_input.Text = original_phone
        home_addr_input.Text = original_addr
    End Sub


    ' opens the new_pass form as a modal dialog so it has a proper close behavior
    Private Sub change_pass_btn_click(sender As Object, e As EventArgs) Handles change_pass_btn.Click
        Try
            Dim pass_host As New Form()
            pass_host.Text = "Change Password"
            pass_host.StartPosition = FormStartPosition.CenterParent
            pass_host.FormBorderStyle = FormBorderStyle.FixedDialog
            pass_host.MinimizeBox = False
            pass_host.MaximizeBox = False
            pass_host.Size = New Size(500, 470)

            Dim pass_form As New new_pass()
            pass_form.Dock = DockStyle.Fill
            pass_host.Controls.Add(pass_form)

            pass_host.ShowDialog(Me.FindForm())
        Catch ex As Exception
            Vip.Notification.Alert.ShowError($"Could not open password form: {ex.Message}")
        End Try
    End Sub


    Private Function validate_inputs() As String
        If String.IsNullOrWhiteSpace(email_input.Text) Then Return "Email required."
        If Not valid_email(email_input.Text) Then Return "Invalid email format."
        If String.IsNullOrWhiteSpace(phone_input.Text) Then Return "Phone required."
        If Not valid_phone_num(phone_input.Text) Then Return "Invalid phone number format."
        If String.IsNullOrWhiteSpace(home_addr_input.Text) Then Return "Home address required."
        Return Nothing
    End Function

End Class