Module ctrl_helpers

    'Public Sub clear_ctrls(parent As Control)
    '    parent.Controls.Clear()
    'End Sub

    ' gets a user control by its name, or Nothing if not found
    Public Function get_ctrl(parent As Control, name As String) As UserControl
        If parent.Controls.ContainsKey(name) Then
            Return parent.Controls(name)
        End If
        Return Nothing
    End Function


    ' adds a user control to the specified form
    Public Function add_ctrl(Of T As {UserControl, New})(
        parent As Control,
        name As String,
        Optional dock As DockStyle = DockStyle.None,
        Optional location As Point? = Nothing,
        Optional remove_existing As Boolean = True
        ) As T

        ' remove the old instance if it exists
        If remove_existing AndAlso parent.Controls.ContainsKey(name) Then
            parent.Controls.RemoveByKey(name)
        End If

        Dim ctrl As New T With {
        .Name = name,
        .Dock = dock
        }

        ' auto-size for proper centering
        ctrl.Size = ctrl.PreferredSize

        ' if no location is specified, place the user control in the center of the parent
        If Not location.HasValue Then
            ctrl.Location = New Point(
            (parent.Width - ctrl.Width) \ 2,
            (parent.Height - ctrl.Height) \ 2
        )
        Else
            ctrl.Location = location.Value
        End If


        parent.Controls.Add(ctrl)

        Return ctrl
    End Function


    ' removes a user control from the specified form
    Public Sub remove_ctrl(parent As Control, name As String)
        If parent.Controls.ContainsKey(name) Then
            Dim c = parent.Controls(name)
            parent.Controls.Remove(c)
            c.Dispose()
        End If
    End Sub


End Module
