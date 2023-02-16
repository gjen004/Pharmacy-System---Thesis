Public Class reportSalesPerEmployee
    Dim s As New cSQL
    Dim c As New cControl

    Private Sub reportsPO_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        c.formatDTP(dateFrom, dateTo)
        s.loadCBX(cmbEmployee, "employee", "ID", "userName")
        c.FormProps(Me)
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        Dim id As Integer = c.getData(cmbEmployee)
        Dim emp As String = s.GetDetailStr("employee", "userName", "ID", id)
        startAt = c.getData(dateFrom)
        endsAt = c.getData(dateTo)
        querSales = "select * from sales where savedBy like'" & emp & "' and (savedDT between '" & startAt & " 00:00:00.000' and '" & endsAt & " 23:59:59.999')"
        rptSubPop = "salesReportPerEmp"
        SalesHistoryVw.Show()
    End Sub

End Class