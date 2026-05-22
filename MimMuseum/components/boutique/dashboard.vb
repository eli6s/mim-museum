Partial Public Class boutique_dashboard
    Inherits UserControl
    Private ReadOnly db_obj As New db_controller()

    Private Sub load_cards()
        load_total_revenue_card()
        load_total_orders_card()
        load_registered_customers_card()
        load_active_listings_card()
    End Sub


    Private Sub load_total_revenue_card()
        Dim total_revenue As Decimal = CDec(
            db_obj.fetch_val(
                "
                SELECT ISNULL(SUM(total), 0)
                FROM transactions
                ")
                )

        Dim last_24h As Decimal = CDec(
            db_obj.fetch_val(
                "
                SELECT ISNULL(SUM(total), 0)
                FROM transactions
                WHERE created_at >= DATEADD(hour, -24, SYSDATETIME())
                ")
                )

        lbl_revenue_value.text = total_revenue.ToString("c0")
        lbl_revenue_sub.text = "after vat · all time"
        lbl_revenue_delta.text = If(
                                    last_24h > 0,
                                    $"+{last_24h:c0} today",
                                    "no sales in last 24h"
                                    )

        set_delta_color(lbl_revenue_delta, last_24h)
    End Sub


    Private Sub load_total_orders_card()
        Dim total_orders As Integer = CInt(
            db_obj.fetch_val(
                "
                SELECT COUNT(*)
                FROM transactions
                ")
                )

        ' cash vs card split for the sub-label
        Dim split_row = db_obj.fetch_row(
            "
            SELECT
                SUM(CASE WHEN payment_method = 'cash' THEN 1 ELSE 0 END) as cash_count,
                SUM(CASE WHEN payment_method = 'card' THEN 1 ELSE 0 END) as card_count
            FROM transactions
            ")

        Dim cash_count As Integer = If(split_row IsNot Nothing, CInt(split_row("cash_count")), 0)
        Dim card_count As Integer = If(split_row IsNot Nothing, CInt(split_row("card_count")), 0)

        Dim last_24h As Integer = CInt(
            db_obj.fetch_val(
                "
                SELECT COUNT(*)
                FROM transactions
                WHERE created_at >= DATEADD(hour, -24, SYSDATETIME())
                ")
                )

        lbl_orders_value.text = total_orders.ToString("n0")
        lbl_orders_sub.text = $"{cash_count:n0} cash · {card_count:n0} card"
        lbl_orders_delta.Text = If(
                                last_24h > 0,
                                $"+{last_24h} today",
                                "no orders in last 24h"
                                )

        set_delta_color(lbl_orders_delta, last_24h)
    End Sub


    Private Sub load_registered_customers_card()
        Dim total As Integer = CInt(
            db_obj.fetch_val(
                "
                SELECT COUNT(*)
                FROM customers
                ")
                )

        Dim anon_tx As Integer = CInt(
            db_obj.fetch_val(
                "
                SELECT COUNT(*)
                FROM transactions 
                WHERE customer_id IS NULL
                ")
                )

        Dim added_today As Integer = CInt(
            db_obj.fetch_val(
                "
                SELECT COUNT(*)
                FROM customers
                WHERE registered_at >= DATEADD(hour, -24, SYSDATETIME())
                ")
                )

        lbl_customers_value.text = total.ToString("n0")
        lbl_customers_sub.text = $"{anon_tx:n0} anonymous transactions"
        lbl_customers_delta.text = If(
                                    added_today > 0,
                                    $"+{added_today} today",
                                    "none registered today"
                                    )
    End Sub


    Private Sub load_active_listings_card()
        Dim active_count As Integer = CInt(
            db_obj.fetch_val(
                "
                SELECT COUNT(*)
                FROM boutique_items
                WHERE is_active = 1 AND quantity > 0
                ")
                )

        Dim low_stock_count As Integer = CInt(
            db_obj.fetch_val(
                "
                SELECT COUNT(*)
                FROM boutique_items
                WHERE is_active = 1 AND quantity BETWEEN 1 AND 5
                ")
                )

        lbl_listings_value.text = active_count.ToString("n0")
        lbl_listings_sub.Text = If(
                                low_stock_count > 0,
                                $"{low_stock_count} low stock (≤ 5 units)",
                                "all items well stocked"
                                )
        lbl_listings_delta.Text = "stable this week"
    End Sub


    Private Sub load_grid()
        top_customers_grid.AutoGenerateColumns = False
        top_customers_grid.Columns.Clear()

        Dim column_headers As New Dictionary(Of String, Object()) From {
            {"row_number", {"#", 30}},
            {"full_name", {"Full Name", 80}},
            {"total_orders", {"Total Orders", 180}},
            {"total_spent", {"Total Spent", 120}}
        }

        For Each col_header In column_headers
            Dim name As String = col_header.Key
            Dim header As String = col_header.Value(0)
            Dim width As Integer = col_header.Value(1)

            add_column(top_customers_grid, name, header, width)
        Next

        ' INNER JOIN is used to exclude anonymous (NULL) records
        top_customers_grid.DataSource = db_obj.fetch_datatable(
            "
            SELECT TOP 7
                c.customer_id,
                c.first_name + ' ' + c.last_name  AS full_name,
                c.phone_num,
                COUNT(t.trans_uuid) AS total_orders,
                SUM(t.total) AS total_spent
            FROM customers c
            INNER JOIN transactions t ON t.customer_id = c.customer_id
            GROUP BY c.customer_id, c.first_name, c.last_name, c.phone_num
            ORDER BY total_spent DESC
            ")
        top_customers_grid.Columns("row_number").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells

        populate_row_numbers(top_customers_grid)
    End Sub


    Private Sub boutique_dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        load_cards()
        load_grid()

        ' note: the query must return 2 columns - first for labels, second for values.
        gen_piechart(
            section_piechart_pnl,
            "Revenue by Payment Method",
            "
            SELECT
                payment_method,
                COUNT(trans_uuid) AS transaction_count,
                SUM(total) AS total_revenue
            FROM transactions
            GROUP BY payment_method
            ")
    End Sub
End Class
