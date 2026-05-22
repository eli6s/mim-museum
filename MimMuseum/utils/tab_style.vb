Module tab_style
    Private ReadOnly clr_active_bg As Color = Color.FromArgb(12, 37, 84)    ' navy
    Private ReadOnly clr_strip_bg As Color = Color.FromArgb(166, 209, 255) ' matches tab page bg
    Private ReadOnly clr_active_text As Color = Color.White
    Private ReadOnly clr_inactive_bg As Color = Color.FromArgb(106, 158, 217) ' mid blue
    Private ReadOnly clr_inactive_text As Color = Color.FromArgb(220, 235, 255)
    Private ReadOnly tab_font As New Font("Helvetica", 12, FontStyle.Regular, GraphicsUnit.Point)

    ' call once in a form/usercontrol load
    Public Sub style_tabs(tc As TabControl)
        tc.DrawMode = TabDrawMode.OwnerDrawFixed
        tc.SizeMode = TabSizeMode.Fixed
        tc.ItemSize = New Size(160, 42)
        tc.Font = tab_font

        ' paint the tab strip background
        tc.Padding = New Point(0, 0)
        AddHandler tc.Paint, Sub(s, ev)
                                 Dim strip As New Rectangle(0, 0, tc.Width, tc.ItemSize.Height + 4)
                                 Using b As New SolidBrush(clr_strip_bg)
                                     ev.Graphics.FillRectangle(b, strip)
                                 End Using
                             End Sub

        For Each page As TabPage In tc.TabPages
            page.BackColor = Color.FromArgb(166, 209, 255)
        Next

        AddHandler tc.DrawItem, AddressOf draw_tab_item
    End Sub


    Private Sub draw_tab_item(sender As Object, e As DrawItemEventArgs)
        Dim tc = DirectCast(sender, TabControl)
        Dim page = tc.TabPages(e.Index)
        Dim is_selected = (tc.SelectedIndex = e.Index)

        Dim bg_color = If(is_selected, clr_active_bg, clr_inactive_bg)
        Dim text_color = If(is_selected, clr_active_text, clr_inactive_text)

        ' fill tab background
        Using brush As New SolidBrush(bg_color)
            e.Graphics.FillRectangle(brush, e.Bounds)
        End Using

        ' draw bottom border on inactive tabs to blend with the page border
        If Not is_selected Then
            Using pen As New Pen(clr_active_bg, 2)
                e.Graphics.DrawLine(pen,
                    e.Bounds.Left, e.Bounds.Bottom - 1,
                    e.Bounds.Right, e.Bounds.Bottom - 1)
            End Using
        End If

        ' centre the tab text
        Dim text_rect = e.Bounds
        Dim sf As New StringFormat With {
            .Alignment = StringAlignment.Center,
            .LineAlignment = StringAlignment.Center
        }

        Using brush As New SolidBrush(text_color)
            e.Graphics.DrawString(page.Text, tab_font, brush, RectangleF.op_Implicit(text_rect), sf)
        End Using
    End Sub

End Module
