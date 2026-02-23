Partial Public Class boutique_dashboard
    Inherits UserControl
    Private ReadOnly db_obj As New db_controller()


    'Private Sub Load_Boutique_Cards()
    '    Load_Card_TotalRevenue()
    '    Load_Card_TotalOrders()
    '    Load_Card_RegisteredCustomers()
    '    Load_Card_ActiveListings()
    'End Sub


    '' ── Card 1: Total Revenue ────────────────────────────────────
    'Private Sub Load_Card_TotalRevenue()
    '    Dim total_revenue As Decimal = CDec(db.fetch_val(
    '        "SELECT ISNULL(SUM(total), 0) FROM transactions"))

    '    Dim last_24h As Decimal = CDec(db.fetch_val(
    '        "SELECT ISNULL(SUM(total), 0)
    '     FROM   transactions
    '     WHERE  created_at >= DATEADD(HOUR, -24, SYSDATETIME())"))

    '    lbl_revenue_value.Text = total_revenue.ToString("C0")
    '    lbl_revenue_sub.Text = "after VAT · all time"
    '    lbl_revenue_delta.Text = If(last_24h > 0,
    '                                 $"+{last_24h:C0} today",
    '                                 "no sales in last 24h")
    'End Sub


    '' ── Card 2: Total Orders ─────────────────────────────────────
    'Private Sub Load_Card_TotalOrders()
    '    Dim total_orders As Integer = CInt(db.fetch_val(
    '        "SELECT COUNT(*) FROM transactions"))

    '    ' cash vs card split for the sub-label
    '    Dim split_row = db.fetch_row(
    '        "SELECT
    '         SUM(CASE WHEN payment_method = 'cash' THEN 1 ELSE 0 END) AS cash_count,
    '         SUM(CASE WHEN payment_method = 'card' THEN 1 ELSE 0 END) AS card_count
    '     FROM transactions")

    '    Dim cash_count As Integer = If(split_row IsNot Nothing, CInt(split_row("cash_count")), 0)
    '    Dim card_count As Integer = If(split_row IsNot Nothing, CInt(split_row("card_count")), 0)

    '    Dim last_24h As Integer = CInt(db.fetch_val(
    '        "SELECT COUNT(*)
    '     FROM   transactions
    '     WHERE  created_at >= DATEADD(HOUR, -24, SYSDATETIME())"))

    '    lbl_orders_value.Text = total_orders.ToString("N0")
    '    lbl_orders_sub.Text = $"{cash_count:N0} cash · {card_count:N0} card"
    '    lbl_orders_delta.Text = If(last_24h > 0,
    '                                $"+{last_24h} today",
    '                                "no orders in last 24h")
    'End Sub


    '' ── Card 3: Registered Customers ─────────────────────────────
    'Private Sub Load_Card_RegisteredCustomers()
    '    Dim total As Integer = CInt(db.fetch_val(
    '        "SELECT COUNT(*) FROM customers"))

    '    Dim anon_tx As Integer = CInt(db.fetch_val(
    '        "SELECT COUNT(*) FROM transactions WHERE customer_id IS NULL"))

    '    Dim added_today As Integer = CInt(db.fetch_val(
    '        "SELECT COUNT(*) FROM customers
    '     WHERE  registered_at >= DATEADD(HOUR, -24, SYSDATETIME())"))

    '    lbl_customers_value.Text = total.ToString("N0")
    '    lbl_customers_sub.Text = $"{anon_tx:N0} anonymous transactions"
    '    lbl_customers_delta.Text = If(added_today > 0,
    '                                   $"+{added_today} today",
    '                                   "none registered today")
    'End Sub


    '' ── Card 4: Active Listings ──────────────────────────────────
    'Private Sub Load_Card_ActiveListings()
    '    Dim active_count As Integer = CInt(db.fetch_val(
    '        "SELECT COUNT(*) FROM boutique_items
    '     WHERE  is_active = 1 AND quantity > 0"))

    '    Dim low_stock_count As Integer = CInt(db.fetch_val(
    '        "SELECT COUNT(*) FROM boutique_items
    '     WHERE  is_active = 1 AND quantity BETWEEN 1 AND 5"))

    '    lbl_listings_value.Text = active_count.ToString("N0")
    '    lbl_listings_sub.Text = If(low_stock_count > 0,
    '                                  $"{low_stock_count} low stock (≤5 units)",
    '                                  "all items well stocked")
    '    lbl_listings_delta.Text = "stable this week"
    'End Sub


    Private Sub boutique_dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        total_revenue_lbl.Text = db_obj.fetch_val(
            "
            SELECT SUM(total) AS total_revenue
            FROM transactions
            "
         )

        total_orders_lbl.Text = db_obj.fetch_val(
            "
            SELECT COUNT(*) AS total_orders
            FROM transactions
            "
         )

        reg_customers_lbl.Text = db_obj.fetch_val(
            "
            SELECT COUNT(*) AS total_customers
            FROM customers
            "
         )

        active_listings_lbl.Text = db_obj.fetch_val(
            "
            SELECT COUNT(*) AS active_listings
            FROM boutique_items
            WHERE is_active = 1
            "
         )

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

        'INNER JOIN is used to exclude anonymous (NULL) records
        top_customers_grid.DataSource = db_obj.fetch_datatable(
            "
            SELECT TOP 5
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
End Class
