Imports System.IO
Imports System.Net
Imports System.Net.Mail
Imports Newtonsoft.Json.Linq
Imports System.Text.RegularExpressions

'Public Sub ApplyRole(role As Role)
'btnDelete.Visible = role.CanDeleteExhibit
'btnAdd.Visible = role.CanAddExhibit
'btnEdit.Visible = role.CanEditExhibit
'End Sub

'turn ctrl names to enums?

Module helpers
    Public session_username As String

    'sets the path of the active user control in the header
    Public Sub set_active_path(parent As Control, ctrl_name As String, path As String)
        Dim ctrl As header = get_ctrl(parent, ctrl_name)
        ctrl.path_lbl.Text = path
    End Sub

    Private Sub load_countries_from_json(file_path As String)
        Try
            Dim json_str As String = File.ReadAllText(file_path)
            Dim countries As JArray = JArray.Parse(json_str)

            For Each country As JObject In countries
                Dim iso As String = country("iso").ToString()
                Dim name As String = country("name").ToString()
                Dim unicode As String = country("unicode").ToString()
                Dim flag As String = country("flag").ToString()

                MsgBox($"{name} {iso}")
                ' Now you can insert these values into your database
                ' InsertCountryIntoDatabase(iso, name, unicode, flag)
            Next
        Catch ex As Exception
            MessageBox.Show("Error loading countries: " & ex.Message)
        End Try
    End Sub

    'Private Sub btnLoadCountries_Click(sender As Object, e As EventArgs) Handles btnLoadCountries.Click
    '    Dim filePath As String = "path\to\your\countries.json"
    '    load_countries_from_json(filePath)
    'End Sub


    Public Function send_email(reciever As String, subject As String, content As String)
        '465 ssl, 587 tls
        Dim port As Integer = 587
        Dim email = "test@gmail.com"
        Dim email_pass = "pass here"

        'https://www.tutorialspoint.com/vb.net/vb.net_send_email.htm

        Try
            Dim smtp_client As New SmtpClient() With
                    {
                        .Credentials = New NetworkCredential(email, email_pass),
                        .EnableSsl = True,
                        .Port = port
                    }

            Dim message As New MailMessage() With
                        {
                            .From = New MailAddress(email),
                            .Subject = subject,
                            .Body = content
                        }

            message.To.Add(reciever)
            smtp_client.Send(message)

            'TODO: improve
            MsgBox("msg sent")

        Catch ex As Exception
            'TODO: improve
            MsgBox(ex.ToString)
        End Try

    End Function


    'disables the login button when both the username & password fields are empty, enables it otherwise
    Public Sub toggle_login_btn(login_form As login)
        If Not String.IsNullOrWhiteSpace(login_form.username_txtbox.Content) And
           Not String.IsNullOrWhiteSpace(login_form.pass_txtbox.Content) Then
            login_form.login_btn.Enabled = True
            Return
        End If
        login_form.login_btn.Enabled = False
    End Sub


    Public Function valid_username(dimensions As String) As Boolean
        'TODO
        Return Regex.IsMatch(dimensions, "^\+?\d{1,4}([ -]?\d+)*$")
    End Function


    Public Function valid_phone_num(dimensions As String) As Boolean
        'TODO: test
        Return Regex.IsMatch(dimensions, "^\+?\d{1,4}([ -]?\d+)*$")
    End Function


    Public Function valid_email(email As String) As Boolean
        Return Regex.IsMatch(email, "^[_a-z0-9-]+(.[a-z0-9-]+)@[a-z0-9-]+(.[a-z0-9-]+)*(.[a-z]{2,4})$")
    End Function


    Public Function gen_password_hash(pass As String) As String
        Return BCrypt.Net.BCrypt.EnhancedHashPassword(pass)
    End Function


    Public Function valid_password(pass As String, pass_hash As String) As Boolean
        Return BCrypt.Net.BCrypt.EnhancedVerify(pass, pass_hash)
    End Function


    Public Function valid_dimensions(dimensions As String) As Boolean
        Return Regex.IsMatch(dimensions, "^\d.*\sx\s\d.*\sx\s\d.*\scm$")
    End Function

End Module
