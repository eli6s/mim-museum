
Partial Public Class museum_dashboard
    Inherits UserControl
    Private ReadOnly db_obj As New db_controller()


    Private Sub load_cards()
        load_total_minerals_card()
        load_total_donations_card()
        load_upcoming_events_card()
        load_registered_guests_card()
    End Sub


    Private Sub load_total_minerals_card()
        Dim total As Integer = CInt(
            db_obj.fetch_val(
                "
                SELECT COUNT(*)
                FROM minerals
                ")
                )

        Dim class_count As Integer = CInt(
            db_obj.fetch_val(
                "
                SELECT COUNT(DISTINCT class_id)
                FROM minerals
                ")
                )

        Dim added_this_month As Integer = CInt(
            db_obj.fetch_val(
                "
                SELECT COUNT(*)
                FROM minerals
                WHERE MONTH(date_added) = MONTH(GETDATE())
                AND YEAR(date_added) = YEAR(GETDATE())
                ")
                )

        lbl_minerals_value.Text = total.ToString("N0")
        lbl_minerals_sub.Text = $"across {class_count} classifications"
        lbl_minerals_delta.Text = If(
                                    added_this_month > 0,
                                    $"+{added_this_month} this month",
                                    "none added this month"
                                    )

        set_delta_color(lbl_minerals_delta, added_this_month)
    End Sub


    Private Sub load_total_donations_card()
        Dim total_amount As Decimal = CDec(
            db_obj.fetch_val(
                "
                SELECT ISNULL(SUM(amount), 0)
                FROM donations
                ")
                )

        Dim donation_count As Integer = CInt(
            db_obj.fetch_val(
                "
                SELECT COUNT(*)
                FROM donations
                ")
                )

        Dim this_month_amount As Decimal = CDec(
            db_obj.fetch_val(
                "
                SELECT ISNULL(SUM(amount), 0)
                FROM donations
                WHERE MONTH(donation_date) = MONTH(GETDATE())
                AND YEAR(donation_date) = YEAR(GETDATE())
                ")
                )

        lbl_donations_value.Text = total_amount.ToString("C0")
        lbl_donations_sub.Text = $"{donation_count} donations · incl. anonymous"
        lbl_donations_delta.Text = If(
                                    this_month_amount > 0,
                                    $"+{this_month_amount:C0} this month",
                                    "no donations this month"
                                    )

        set_delta_color(lbl_donations_delta, this_month_amount)
    End Sub


    Private Sub load_upcoming_events_card()
        Dim upcoming_count As Integer = CInt(
            db_obj.fetch_val(
                "
                SELECT COUNT(*)
                FROM events
                WHERE event_date >= CAST(GETDATE() AS DATE)
                AND event_status <> 'cancelled'
                ")
                )

        'nearest upcoming event for the sub-label
        Dim next_event = db_obj.fetch_row(
                "
                SELECT TOP 1 event_name, event_date
                FROM events
                WHERE event_date >= CAST(GETDATE() AS DATE)
                AND event_status <> 'cancelled'
                ORDER BY event_date ASC
                ")

        'how many events were upcoming this time last month (MoM)
        Dim last_month_count As Integer = CInt(
            db_obj.fetch_val(
                "
                SELECT COUNT(*)
                FROM events
                WHERE event_date >= DATEADD(MONTH, -1, CAST(GETDATE() AS DATE))
                AND event_date < CAST(GETDATE() AS DATE)
                AND event_status <> 'cancelled'
                ")
                )

        Dim diff As Integer = upcoming_count - last_month_count

        lbl_events_value.Text = upcoming_count.ToString()

        If next_event IsNot Nothing Then
            Dim event_name As String = next_event("event_name").ToString()
            Dim event_date As Date = CDate(next_event("event_date"))
            lbl_events_sub.Text = $"next: {event_name} · {event_date:MMM d}"
        Else
            lbl_events_sub.Text = "no upcoming events"
        End If

        Select Case Math.Sign(diff)
            Case 1
                lbl_events_delta.Text = $"+{diff} vs last month"
            Case -1
                lbl_events_delta.Text = $"{diff} vs last month"
            Case Else
                lbl_events_delta.Text = "same as last month"
        End Select

        set_delta_color(lbl_events_delta, diff)
    End Sub


    Private Sub load_registered_guests_card()
        Dim total As Integer = CInt(
            db_obj.fetch_val(
                "
                SELECT COUNT(*)
                FROM guests
                ")
                )

        Dim added_this_month As Integer = CInt(
            db_obj.fetch_val(
                "
                SELECT COUNT(*)
                FROM guests
                WHERE MONTH(registered_at) = MONTH(GETDATE())
                AND YEAR(registered_at) = YEAR(GETDATE())
                ")
                )

        lbl_guests_value.Text = total.ToString("N0")
        lbl_guests_sub.Text = "with phone on record"
        lbl_guests_delta.Text = If(
                                added_this_month > 0,
                                $"+{added_this_month} this month",
                                "none registered this month"
                                )

        set_delta_color(lbl_guests_delta, added_this_month)
    End Sub


    Private Sub load_grid()

        top_donors_grid.AutoGenerateColumns = False
        top_donors_grid.Columns.Clear()

        Dim column_headers As New Dictionary(Of String, Object()) From {
            {"row_number", {"#", 30}},
            {"full_name", {"Full Name", 80}},
            {"total_donations", {"Total Donations", 180}},
            {"total_donated", {"Total Donated", 120}}
        }

        For Each col_header In column_headers
            Dim name As String = col_header.Key
            Dim header As String = col_header.Value(0)
            Dim width As Integer = col_header.Value(1)

            add_column(top_donors_grid, name, header, width)
        Next

        'INNER JOIN is used to exclude anonymous (NULL) records
        top_donors_grid.DataSource = db_obj.fetch_datatable(
            "
            SELECT TOP 7
                g.guest_id,
                g.first_name + ' ' + g.last_name AS full_name,
                g.phone_num,
                COUNT(d.donation_id) AS total_donations,
                SUM(d.amount) AS total_donated
            FROM guests g
            INNER JOIN donations d ON d.donor_id = g.guest_id
            GROUP BY g.guest_id, g.first_name, g.last_name, g.phone_num
            ORDER BY total_donated DESC
            ")
        top_donors_grid.Columns("row_number").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells

        populate_row_numbers(top_donors_grid)
    End Sub


    Private Sub museum_dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        load_cards()
        load_grid()

        'note: the query must return 2 columns - first for labels, second for values.
        gen_piechart(
            section_piechart_pnl,
            "Minerals by Classification",
            "
            SELECT c.class_name, COUNT(*) as count 
            FROM minerals m 
            INNER JOIN classifications c ON m.class_id = c.class_id 
            GROUP BY c.class_name
            ")
    End Sub
End Class
