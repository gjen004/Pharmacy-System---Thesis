Public Class reportSalesPerProduct
    Dim s As New cSQL
    Dim c As New cControl

    Private Sub reportsPO_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        c.formatDTP(dateFrom, dateTo)
        s.loadCBX(cmbProduct, "ProductOnSale", "ID", "Product")
        c.FormProps(Me)
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        Dim id As Integer = c.getData(cmbProduct)
        Dim prod As String = s.GetDetailStr("ProductOnSale", "Product", "ID", id)
        startAt = c.getData(dateFrom)
        endsAt = c.getData(dateTo)
        querSales = "select * from salesProdShow where prodName like '" & prod & "'"
        rptSubPop = "salesReportPerProd"
        SalesHistoryVw.Show()
    End Sub
End Class