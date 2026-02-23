Imports System.Configuration
Imports System.IO

Imports System.Net
Imports System.Net.Mail

Imports System.Text
Imports System.Text.RegularExpressions

Imports CuoreUI.Controls
Imports MetroFramework.Controls

Imports Newtonsoft.Json.Linq

Imports OxyPlot
Imports OxyPlot.Series
Imports OxyPlot.WindowsForms


Module helpers
    Private ReadOnly db_obj As New db_controller()

    '2880x1800 at 150%
    Public cratio_x As Single
    Public cratio_y As Single

    Public ReadOnly max_width As Integer = 2560
    Public ReadOnly max_height As Integer = 1440


    'TODO: fix the location of the title
    'generate a (pie chart) populated with data from the given query
    Public Sub gen_piechart(parent As Control, title As String, query As String)
        Dim plot_view As New PlotView()
        plot_view.Dock = DockStyle.Fill
        plot_view.BringToFront()
        plot_view.BackColor = parent.BackColor

        Dim model As New PlotModel With {
            .title = title,
            .TitleColor = OxyColors.White,
            .TitleFontSize = 26,
            .TitleFontWeight = FontWeights.Bold,
            .Background = OxyColor.FromRgb(parent.BackColor.R, parent.BackColor.G, parent.BackColor.B),
            .PlotAreaBorderThickness = New OxyThickness(0),
            .TextColor = OxyColor.FromRgb(12, 37, 84)
        }

        Dim pie_series As New PieSeries With {
            .StrokeThickness = 2.0,
            .Stroke = OxyColors.White,
            .InsideLabelPosition = 0.7,
            .OutsideLabelFormat = "{1}",
            .InsideLabelFormat = "{2:0}%",
            .AngleSpan = 360,
            .StartAngle = 0,
            .FontSize = 13,
            .FontWeight = FontWeights.Bold,
            .TextColor = OxyColor.FromRgb(12, 37, 84)
        }

        Dim data = db_obj.fetch(query)
        Dim color_index = 0

        For Each row In data
            Dim label = row.Values(0).ToString()
            Dim count = Convert.ToDouble(row.Values(1))

            Dim slice As New PieSlice(label, count) With {
                .Fill = piechart_colours(color_index Mod piechart_colours.Length
                )
            }
            pie_series.Slices.Add(slice)
            color_index += 1
        Next

        model.Series.Add(pie_series)
        plot_view.Model = model
        parent.Controls.Add(plot_view)
    End Sub


    'TODO: dissect this later to understand how things operate under the hood
    Public Sub fit_to_screen(f As Form)
        Dim screen_width As Integer = Screen.PrimaryScreen.WorkingArea.Width
        Dim screen_height As Integer = Screen.PrimaryScreen.WorkingArea.Height

        If Math.Abs(screen_width - max_width) < 50 And Math.Abs(screen_height - max_height) < 50 Then Return

        Dim ratio_x As Single = CSng(screen_width) / CSng(max_width)
        Dim ratio_y As Single = CSng(screen_height) / CSng(max_height)

        cratio_x = ratio_x
        cratio_y = ratio_y

        scale_step(f, ratio_x, ratio_y)
    End Sub


    'TODO: dissect this later to understand how things operate under the hood
    Public Sub scale_step(parent As Control, rX As Single, rY As Single)
        For Each c As Control In parent.Controls
            c.Left = CInt(c.Left * rX)
            c.Top = CInt(c.Top * rY)

            c.Width = Math.Max(1, CInt(c.Width * rX))
            c.Height = Math.Max(1, CInt(c.Height * rY))

            Dim new_font_size = c.Font.Size * Math.Min(rX, rY)
            c.Font = New Font(c.Font.FontFamily, Math.Max(new_font_size, 8.0!), c.Font.Style)

            If c.HasChildren Then scale_step(c, rX, rY)
            c.Invalidate()
        Next
    End Sub


    'add a column to a MetroGrid
    Public Sub add_column(
            grid As MetroGrid,
            name As String,
            header As String,
            Optional width As Integer = 100,
            Optional visible As Boolean = True
            )

        grid.Columns.Add(
            New DataGridViewTextBoxColumn With {
                .Name = name,
                .DataPropertyName = name,
                .HeaderText = header,
                .Width = width,
                .Visible = visible
                }
            )
    End Sub


    'populate a MetroGrid with row numbers
    Public Sub populate_row_numbers(grid As MetroGrid)
        For i As Integer = 0 To grid.Rows.Count - 1
            If Not grid.Rows(i).IsNewRow Then
                grid.Rows(i).Cells("row_number").Value = i + 1
            End If
        Next
    End Sub


    'recursively register click handlers for all buttons in a control hierarchy
    Public Sub register_click_handlers(parent As Control, handler As EventHandler)
        For Each ctrl As Control In parent.Controls
            If TypeOf ctrl Is cuiButton Then
                AddHandler ctrl.Click, handler
            End If

            If ctrl.HasChildren Then
                ' recursively register click handlers for the children
                register_click_handlers(ctrl, handler)
            End If
        Next
    End Sub


    'convert a string to pascal case
    Public Function to_pascal_case(snake_case As String) As String
        Dim parts() As String = snake_case.Split("_"c)
        Dim result As String = ""
        For Each part As String In parts
            If part.Length > 0 Then
                result &= Char.ToUpper(part(0)) & part.Substring(1).ToLower()
            End If
        Next
        Return result
    End Function


    'read and execute the sql schema of an sql file
    Public Sub exec_schema_file(path As String)
        Try
            Dim sql_script As String = File.ReadAllText(path, Encoding.UTF8)
            db_obj.execute(sql_script)
        Catch ex As Exception
            MsgBox(ex.Message)
            Throw
        End Try
    End Sub


    'load the countries from a JSON file and populate the database with any missing ones
    Public Sub load_countries_from_json(file_path As String)
        Try
            Dim json_str As String = File.ReadAllText(file_path)
            Dim countries As JArray = JArray.Parse(json_str)

            For Each country As JObject In countries
                Dim name As String = country("name").ToString()

                If Not country_exists(name) Then
                    db_obj.execute(
                        "
                        INSERT INTO countries (country_name)
                        VALUES (@country_name)
                        ",
                        New Dictionary(Of String, Object) From {
                            {"country_name", name}
                        }
                    )
                End If
            Next
        Catch ex As Exception
            MessageBox.Show("error loading countries: " & ex.Message)
        End Try
    End Sub


    'check if the given country exists in the database
    Public Function country_exists(country_name As String) As Boolean
        Dim count = db_obj.fetch_val(
            "
            SELECT COUNT(*)
            FROM countries
            WHERE country_name = @country_name
            ",
            New Dictionary(Of String, Object) From {
                {"country_name", country_name}
            }
        )
        Return count > 0
    End Function


    ' send an email via the SMTP protocol
    Public Function send_email(reciever As String, subject As String, content As String) As Integer
        Dim host As String = ConfigurationManager.AppSettings("smtp_host")
        Dim port As Integer = Convert.ToInt32(ConfigurationManager.AppSettings("smtp_port"))
        Dim email As String = ConfigurationManager.AppSettings("smtp_email")
        Dim email_pass As String = ConfigurationManager.AppSettings("smtp_password")

        Try
            Dim smtp_client As New SmtpClient() With
                    {
                        .Credentials = New NetworkCredential(email, email_pass),
                        .EnableSsl = True,
                        .Port = port,
                        .Host = host
                    }

            Dim message As New MailMessage() With
                        {
                            .From = New MailAddress(email),
                            .Subject = subject,
                            .Body = content
                        }

            message.To.Add(reciever)
            smtp_client.Send(message)
            Return 1

        Catch ex As Exception
            MsgBox(ex.ToString)
            Return 0
        End Try
    End Function


    Public Sub set_delta_color(lbl As Label, value As Decimal)
        If value > 0 Then
            lbl.ForeColor = Color.FromArgb(98, 252, 170)       ' green
        ElseIf value < 0 Then
            lbl.ForeColor = Color.FromArgb(255, 128, 128)   ' red
        Else
            lbl.ForeColor = Color.FromArgb(187, 225, 252)   ' neutral
        End If
    End Sub


    'TODO: utilise this
    'generate a username for an employee
    Public Function generate_username(
                        first_name As String,
                        last_name As String,
                        employee_id As Integer
                        ) As String
        If String.IsNullOrWhiteSpace(first_name) OrElse String.IsNullOrWhiteSpace(last_name) Then
            Return ""
        End If

        Dim initial = first_name.Trim().Substring(0, 1).ToLower()
        Dim clean_last_name = last_name.Trim().ToLower() _
            .Replace("'", "") _
            .Replace(" ", "") _
            .Replace("-", "")

        Return $"{initial}{clean_last_name}-{employee_id}"
    End Function


    'TODO: MAYBE utilise this
    'check if a username's format matches the regex validation pattern
    Public Function valid_username(username As String) As Boolean
        'TODO
        'Dim username = GenerateUsername(firstName, lastName, employeeId)

        '    If Not ValidateUsernameLength(username) Then
        '        Throw New ArgumentException(
        '            $"Generated username '{username}' exceeds 30 characters. " &
        '            "Please use a shorter last name or contact system administrator.")
        '    End If

        Return Regex.IsMatch(username, "^\+?\d{1,4}([ -]?\d+)*$")
    End Function


    'generate a hash for a password
    Public Function generate_password_hash(pass As String) As String
        Return BCrypt.Net.BCrypt.EnhancedHashPassword(pass)
    End Function


    'check if a password matches the specified hash
    Public Function valid_password(pass As String, pass_hash As String) As Boolean
        Return BCrypt.Net.BCrypt.EnhancedVerify(pass, pass_hash)
    End Function


    'check if a phone number's format matches the regex validation pattern
    Public Function valid_phone_num(phone_num As String) As Boolean
        Return Regex.IsMatch(phone_num, "^\+?\d{1,4}([ -]?\d+)*$")
    End Function


    'check if an email's format matches the regex validation pattern
    Public Function valid_email(email As String) As Boolean
        Return Regex.IsMatch(email, "^[_a-z0-9-]+(.[a-z0-9-]+)@[a-z0-9-]+(.[a-z0-9-]+)*(.[a-z]{2,4})$")
    End Function


    'check if the dimensions's format matches the regex validation pattern
    Public Function valid_dimensions(dimensions As String) As Boolean
        Return Regex.IsMatch(dimensions, "^\d.*\sx\s\d.*\sx\s\d.*\scm$")
    End Function

End Module
