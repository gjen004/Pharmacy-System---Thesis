Public Class reportVoidedPO
    Dim c As New cControl
    Private Sub MeBaseLoad(sender As Object, e As EventArgs) Handles MyBase.Load
        c.FormProps(Me)
    End Sub
    Private Sub CreateQueryShowPrintPreview(sender As Object, e As EventArgs) Handles btnPrint.Click
        startAt = c.getData(dateFrom)
        endsAt = c.getData(dateTo)
        querPOVd = "select * from POHistoryVoid where PODTCreate between '" & startAt & "' and '" & endsAt & "' and status = 'Voided'"
        PrintPOHistoryVoidVw.Show()
    End Sub
End Class