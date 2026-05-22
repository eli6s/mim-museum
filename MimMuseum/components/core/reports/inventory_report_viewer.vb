Imports Microsoft.Reporting.WinForms

''' <summary>
''' inventory snapshot report. no filters — just a flat list of all
''' active boutique items with their stock levels.
''' low-stock items (qty ≤ 5) flagged for restocking.
''' </summary>
Public Class inventory_report_viewer
    Private ReadOnly db_obj As New db_controller()


    Private Sub inventory_report_viewer_load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim inventory_dt = db_obj.fetch_datatable(
                "SELECT
                    b.item_id,
                    b.item_name,
                    b.unit_price,
                    b.quantity,
                    ISNULL(m.mineral_name, 'N/A') AS mineral_name,
                    CASE WHEN b.quantity <= 5 THEN 'Low Stock' ELSE '' END AS stock_status
                 FROM boutique_items b
                 LEFT JOIN minerals m ON b.ref_mineral = m.mineral_tag
                 WHERE b.is_active = 1
                 ORDER BY b.quantity ASC"
            )

            ReportViewer1.LocalReport.ReportEmbeddedResource = "MimMuseum.inventory_report.rdlc"
            ReportViewer1.LocalReport.DataSources.Clear()
            ReportViewer1.LocalReport.DataSources.Add(New ReportDataSource("ds_inventory", inventory_dt))

            ReportViewer1.SetDisplayMode(DisplayMode.PrintLayout)
            ReportViewer1.ZoomMode = ZoomMode.PageWidth
            ReportViewer1.RefreshReport()
        Catch ex As Exception
            MessageBox.Show($"Report error: {ex.Message}")
        End Try
    End Sub

End Class