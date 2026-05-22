Module ctrl_helpers

    ' get a user control by its name, or Nothing if not found
    Public Function get_ctrl(parent As Control, name As String) As UserControl
        If parent.Controls.ContainsKey(name) Then
            Return parent.Controls(name)
        End If
        Return Nothing
    End Function


    ' add a user control to the specified parent
    '
    ' centering logic:
    '   - if dock = Fill, centering is irrelevant — skip it
    '   - if dock = None and no location given, center in parent
    '   - if a location is given, use it as-is
    '
    ' scaling logic:
    '   - scale the control first, then center
    '   - this way the centering math uses the already-scaled size,
    '     so the control lands in the correct position
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

        ' set natural size before scaling
        ctrl.Size = ctrl.PreferredSize

        ' scale first — centering must happen after so it uses the scaled size
        Dim needs_scaling = (main.Width <> max_width OrElse main.Height <> max_height)
        If needs_scaling AndAlso cratio_x > 0 AndAlso cratio_y > 0 Then
            scale_step(ctrl, cratio_x, cratio_y)
        End If

        ' position; only meaningful when not docked
        If dock = DockStyle.None Then
            If location.HasValue Then
                ctrl.Location = location.Value
            Else
                ' center in parent using the (now scaled) size
                ctrl.Location = New Point(
                    (parent.Width - ctrl.Width) \ 2,
                    (parent.Height - ctrl.Height) \ 2
                )
            End If
        End If

        parent.Controls.Add(ctrl)

        Return ctrl
    End Function


    ' remove a user control from the specified parent
    Public Sub remove_ctrl(parent As Control, name As String)
        If parent.Controls.ContainsKey(name) Then
            Dim c = parent.Controls(name)
            parent.Controls.Remove(c)
            c.Dispose()
        End If
    End Sub

End Module
