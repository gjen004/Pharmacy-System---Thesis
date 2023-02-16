Public Class reportRRPaid
    Dim c As New cControl
    Private Sub reportsPO_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        c.FormProps(Me)
        c.formatDTP(dateFrom, dateTo)
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        startAt = c.getData(dateFrom)
        endsAt = c.getData(dateTo)
        querRR = "select * from RRReportHistory where totalRR = '0.00'"
        rptSubPop = "allRR"
        RRPrintVw.Show()
    End Sub
End Class