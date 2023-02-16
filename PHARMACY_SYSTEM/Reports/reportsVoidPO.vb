Public Class reportsPOBySupplier
    Dim c As New cControl
    Dim s As New cSQL


    Private Sub reportsVoidPO_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        s.loadCBX(cmbSupplier, "cmbSupp", "ID", "suppname")
        c.FormProps(Me)
    End Sub
    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        Dim id As Integer = c.getData(cmbSupplier)
        Dim supplier As String = s.GetDetailStr("supplier", "suppName", "ID", id)
        querPOSupp = "select * from POReportHistory where suppName = '" & supplier & "'"
        POHistoryBySupplier.Show()
    End Sub
End Class