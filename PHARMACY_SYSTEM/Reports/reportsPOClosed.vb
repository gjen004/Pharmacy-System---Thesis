Public Class reportsPOClosed
    Dim c As New cControl
    Private Sub MeBaseLoad(sender As Object, e As EventArgs) Handles MyBase.Load
        c.FormProps(Me)
    End Sub
    Private Sub CreateQueryShowPrintPreview(sender As Object, e As EventArgs) Handles btnPrint.Click
        startAt = c.getData(dateFrom)
        endsAt = c.getData(dateTo)
        querPOCls = "select * from POHistoryClose where PODTCreate between '" & startAt & "' and '" & endsAt & "' and status = 'Closed'"
        PrintPOHistoryClsVw.Show()
    End Sub
End Class