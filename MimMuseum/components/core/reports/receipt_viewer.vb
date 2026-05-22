Imports Microsoft.Reporting.WinForms

''' <summary>
''' receipt viewer. takes the transaction uuid in the constructor,
''' fetches header + line items, binds them to the rdlc report.
''' opened after a successful pos sale or from the transactions browser.
''' </summary>
Public Class receipt_viewer
    Private ReadOnly db_obj As New db_controller()
    Private ReadOnly trans_uuid As Guid


    Public Sub New(trans_uuid As Guid)
        InitializeComponent()
        Me.trans_uuid = trans_uuid
    End Sub


    Private Sub receipt_viewer_load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim header_dt = db_obj.fetch_datatable(
                "SELECT
                t.trans_uuid,
                t.created_at,
                t.subtotal,
                t.vat,
                t.total,
                t.payment_method,
                t.amount_paid,
                t.change_due,
                e.first_name + ' ' + e.last_name AS cashier_name,
                ISNULL(c.first_name + ' ' + c.last_name, 'Walk-in Customer') AS customer_name
             FROM transactions t
             INNER JOIN employees e ON t.employee_id = e.employee_id
             LEFT JOIN customers c ON t.customer_id = c.customer_id
             WHERE t.trans_uuid = @trans_uuid",
                New Dictionary(Of String, Object) From {{"trans_uuid", trans_uuid}}
            )

            Dim items_dt = db_obj.fetch_datatable(
                "SELECT
                b.item_name,
                ti.quantity,
                ti.item_price,
                ti.quantity * ti.item_price AS line_total
             FROM transaction_items ti
             INNER JOIN boutique_items b ON ti.item_id = b.item_id
             WHERE ti.trans_uuid = @trans_uuid",
                New Dictionary(Of String, Object) From {{"trans_uuid", trans_uuid}}
            )

            ReportViewer1.LocalReport.ReportEmbeddedResource = "MimMuseum.receipt.rdlc"
            ReportViewer1.LocalReport.DataSources.Clear()
            ReportViewer1.LocalReport.DataSources.Add(New ReportDataSource("ds_header", header_dt))
            ReportViewer1.LocalReport.DataSources.Add(New ReportDataSource("ds_items", items_dt))

            ReportViewer1.LocalReport.EnableExternalImages = True
            ReportViewer1.SetDisplayMode(DisplayMode.PrintLayout)
            ReportViewer1.ZoomMode = ZoomMode.PageWidth
            ReportViewer1.RefreshReport()

        Catch ex As Exception
            MessageBox.Show($"ERROR: {ex.Message}{vbCrLf}{vbCrLf}STACK: {ex.StackTrace}")
        End Try
    End Sub
End Class