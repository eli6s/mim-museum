Imports System.IO

Partial Public Class main
    Inherits Form

    Private Sub main_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' if needed, adjust the size of components based on the screen resolution
        fit_to_screen(Me)

        ' get the parent directory since countries.json & schema.sql are in the same directory as the solution file
        Dim parent_dir_path As String = Directory.GetParent(Application.StartupPath).Parent.Parent.FullName
        Dim json_file_path As String = Path.Combine(parent_dir_path, "countries.json")
        Dim schema_file_path As String = Path.Combine(parent_dir_path, "schema.sql")

        ' parse and execute the database schema from `schema.sql`
        exec_schema_file(schema_file_path)

        If File.Exists(json_file_path) Then
            load_countries_from_json(json_file_path)
        End If

        Me.KeyPreview = True

        AddHandler Me.KeyDown, AddressOf main_KeyDown
        add_ctrl(Of login)(Me, ctrl_names.login)
    End Sub


    Private Sub main_KeyDown(sender As Object, e As KeyEventArgs)

        ' take the user back to the login form if the left key is pressed while on the reset password form
        If e.KeyCode = Keys.Left And Me.ActiveControl.Name = ctrl_names.reset_pass Then
            remove_ctrl(Me, ctrl_names.reset_pass)
            add_ctrl(Of login)(Me, ctrl_names.login)
        End If
    End Sub

End Class
