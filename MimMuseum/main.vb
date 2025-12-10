Partial Public Class main
    Inherits Form
    Private Sub main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.KeyPreview = True
        Me.TabStop = False
        Me.ActiveControl = Nothing

        AddHandler Me.KeyDown, AddressOf main_KeyDown
        add_ctrl(Of login)(Me, "login")
    End Sub

    Private Sub main_KeyDown(sender As Object, e As KeyEventArgs)
        'upon clicking the left arrow key, if the active control is the reset pass user control,
        'load the login control again
        If e.KeyCode = Keys.Left And Me.ActiveControl.Name = "reset-pass" Then
            remove_ctrl(Me, "reset-pass")
            add_ctrl(Of login)(Me, "login")
        End If

        'Dim db_obj As New db_controller()

        'Dim row = db_obj.fetch_one(
        '    "SELECT * FROM classifications WHERE class_id = @class_id",
        '    New Dictionary(Of String, Object) From {
        '        {"class_id", 6}
        '    }
        ')

        'Dim rows = db.Fetch(
        '    "
        '    SELECT t.transaction_id, u.username, t.amount
        '    FROM Transactions t
        '    JOIN Users u ON u.id = t.user_id
        '    WHERE u.username LIKE @search
        '    ORDER BY t.transaction_id DESC
        '    ",
        '    New Dictionary(Of String, Object) From {
        '        {"search", "%john%"}
        '    }
        '    )

        'db.Execute(
        '    "
        '    INSERT INTO Users (username, age, email)
        '    VALUES (@username, @age, @email)
        '    ",
        '    New Dictionary(Of String, Object) From {
        '        {"username", "john"},
        '        {"age", 22},
        '        {"email", "john@example.com"}
        '    }
        ')

        'Dim count = db.fetch_val(
        '    "SELECT COUNT(*) FROM exhibits",
        '    Nothing
        '    )


        'db.execute(
        '    "
        '    INSERT INTO exhibits (title, category)
        '    VALUES (@title, @category)
        '    ",
        '    New Dictionary(Of String, Object) From {
        '        {"title", "New Exhibit"},
        '        {"category", "Art"}
        '    }
        ')

    End Sub

End Class
