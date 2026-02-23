' =============================================================================
' Module  : badge_helpers
' Project : Museum & Boutique Management System
' Purpose : Generates colored badge controls for status/state enums,
'           intended for use in MetroGrid CellPainting.
' =============================================================================
Imports System.Drawing

Module badge_helpers

    ' Badge color pairs (background, foreground)
    Private ReadOnly badge_styles As New Dictionary(Of String, (bg As Color, fg As Color)) From {
        {"green", (Color.FromArgb(220, 252, 231), Color.FromArgb(22, 101, 52))},
        {"blue", (Color.FromArgb(219, 234, 254), Color.FromArgb(30, 64, 175))},
        {"yellow", (Color.FromArgb(254, 249, 195), Color.FromArgb(133, 77, 14))},
        {"red", (Color.FromArgb(254, 226, 226), Color.FromArgb(153, 27, 27))},
        {"gray", (Color.FromArgb(243, 244, 246), Color.FromArgb(75, 85, 99))},
        {"purple", (Color.FromArgb(243, 232, 255), Color.FromArgb(107, 33, 168))}
    }

    ' =========================================================================
    ' Core painter — call this inside your DataGridView CellPainting event.
    ' Draws a rounded pill badge centered in the cell.
    '
    ' Usage in CellPainting:
    '   paint_badge(e, "Ongoing", "blue")
    ' =========================================================================
    Public Sub paint_badge(e As DataGridViewCellPaintingEventArgs, label_text As String, style_key As String)
        e.PaintBackground(e.ClipBounds, True)

        Dim style = badge_styles(style_key)
        Dim padding_x As Integer = 10
        Dim padding_y As Integer = 3
        Dim cell_rect As Rectangle = e.CellBounds

        Using badge_font As New Font("Segoe UI", 8, FontStyle.Regular)
            Dim text_size As SizeF = e.Graphics.MeasureString(label_text, badge_font)
            Dim badge_w As Integer = CInt(text_size.Width) + (padding_x * 2)
            Dim badge_h As Integer = CInt(text_size.Height) + (padding_y * 2)

            Dim badge_x As Integer = cell_rect.X + (cell_rect.Width - badge_w) \ 2
            Dim badge_y As Integer = cell_rect.Y + (cell_rect.Height - badge_h) \ 2
            Dim badge_rect As New Rectangle(badge_x, badge_y, badge_w, badge_h)

            ' Draw pill background
            Using bg_brush As New SolidBrush(style.bg)
                Dim radius As Integer = badge_h \ 2
                draw_rounded_rect(e.Graphics, bg_brush, badge_rect, radius)
            End Using

            ' Draw text
            Using fg_brush As New SolidBrush(style.fg)
                Dim text_x As Single = badge_x + padding_x
                Dim text_y As Single = badge_y + padding_y
                e.Graphics.DrawString(label_text, badge_font, fg_brush, text_x, text_y)
            End Using
        End Using

        e.Handled = True
    End Sub

    ' =========================================================================
    ' EventStatus badge
    ' =========================================================================
    Public Sub paint_event_status_badge(e As DataGridViewCellPaintingEventArgs, status As EventStatus)
        Select Case status
            Case EventStatus.Upcoming : paint_badge(e, "Upcoming", "blue")
            Case EventStatus.Ongoing : paint_badge(e, "Ongoing", "green")
            Case EventStatus.Completed : paint_badge(e, "Completed", "gray")
            Case EventStatus.Cancelled : paint_badge(e, "Cancelled", "red")
        End Select
    End Sub

    ' =========================================================================
    ' ItemStatus badge  (equipment)
    ' =========================================================================
    Public Sub paint_item_status_badge(e As DataGridViewCellPaintingEventArgs, status As ItemStatus)
        Select Case status
            Case ItemStatus.Active : paint_badge(e, "Active", "green")
            Case ItemStatus.InRepair : paint_badge(e, "In Repair", "yellow")
            Case ItemStatus.Inactive : paint_badge(e, "Inactive", "gray")
        End Select
    End Sub

    ' =========================================================================
    ' SessionStatus badge
    ' =========================================================================
    Public Sub paint_session_status_badge(e As DataGridViewCellPaintingEventArgs, status As SessionStatus)
        Select Case status
            Case SessionStatus.Active : paint_badge(e, "Active", "green")
            Case SessionStatus.Ended : paint_badge(e, "Ended", "gray")
        End Select
    End Sub

    ' =========================================================================
    ' PaymentMethod badge
    ' =========================================================================
    Public Sub paint_payment_method_badge(e As DataGridViewCellPaintingEventArgs, method As PaymentMethod)
        Select Case method
            Case PaymentMethod.Cash : paint_badge(e, "Cash", "purple")
            Case PaymentMethod.Card : paint_badge(e, "Card", "blue")
        End Select
    End Sub

    ' =========================================================================
    ' Rounded rectangle helper
    ' =========================================================================
    Private Sub draw_rounded_rect(g As Graphics, brush As Brush, rect As Rectangle, radius As Integer)
        Dim diameter As Integer = radius * 2
        Dim path As New Drawing2D.GraphicsPath()

        path.AddArc(rect.X, rect.Y, diameter, diameter, 180, 90)
        path.AddArc(rect.Right - diameter, rect.Y, diameter, diameter, 270, 90)
        path.AddArc(rect.Right - diameter, rect.Bottom - diameter, diameter, diameter, 0, 90)
        path.AddArc(rect.X, rect.Bottom - diameter, diameter, diameter, 90, 90)
        path.CloseFigure()

        g.SmoothingMode = Drawing2D.SmoothingMode.AntiAlias
        g.FillPath(brush, path)
    End Sub

End Module