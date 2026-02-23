Module ctrl_helpers


    ' get a user control by its name, or Nothing if not found
    Public Function get_ctrl(parent As Control, name As String) As UserControl
        If parent.Controls.ContainsKey(name) Then
            Return parent.Controls(name)
        End If
        Return Nothing
    End Function


    ' add a user control to the specified form
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

        ' only scale if not at the max resolution
        If (Not main.Size.Width = 2560 AndAlso Not main.Size.Height = 1440) Then
            scale_step(ctrl, cratio_x, cratio_y)
        End If

        parent.Controls.Add(ctrl)

        Dim screen_width As Integer = Screen.PrimaryScreen.WorkingArea.Width
        Dim screen_height As Integer = Screen.PrimaryScreen.WorkingArea.Height
        Dim ratio_X As Single = CSng(screen_width) / max_width!
        Dim ratio_Y As Single = CSng(screen_height) / max_height!


        Return ctrl
    End Function


    ' remove a user control from the specified form
    Public Sub remove_ctrl(parent As Control, name As String)
        If parent.Controls.ContainsKey(name) Then
            Dim c = parent.Controls(name)
            parent.Controls.Remove(c)
            c.Dispose()
        End If
    End Sub

End Module
