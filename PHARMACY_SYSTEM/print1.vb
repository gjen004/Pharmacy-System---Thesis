Public Class print1
    Dim s As New cSQL
    Private Sub Print1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Dim ds As New DataSet1
        'Dim ad1 As New DataSet1TableAdapters.salesTableAdapter
        'ad1.Fill(ds.sales)
        Dim rpt As New CrystalReportViewer2
        'rpt.SetDataSource(ds)
        'CrystalReportViewer2.ReportSource = rpt
        s.GenerateReport("Select * from sales", "sales", CrystalReportViewer2, rpt)
    End Sub
End Class

'pwede for daily sales