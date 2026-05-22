''' <summary>
''' reports hub. shows three buttons that open the report viewers in modal dialogs.
''' acts as the landing page for the Reports module.
''' </summary>
Public Class reports

    Private Sub inventory_report_btn_click(sender As Object, e As EventArgs) Handles inventory_report_btn.Click
        Dim viewer As New inventory_report_viewer()
        viewer.ShowDialog()
    End Sub

End Class