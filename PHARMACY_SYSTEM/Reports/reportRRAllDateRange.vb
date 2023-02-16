Public Class reportRRAllDateRange
    Dim c As New cControl
    Dim s As New cSQL

    Private Sub reportsPO_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        c.FormProps(Me)
        c.formatDTP(dateFrom, dateTo)
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        startAt = c.getData(dateFrom)
        endsAt = c.getData(dateTo)
        querRR = "select * from RRReportHistory where RRDate between '" & startAt & "' and '" & endsAt & "'"
        rptSubPop = "allRR"
        RRPrintVw.Show()
    End Sub
End Class