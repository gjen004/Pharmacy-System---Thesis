Public Class iconHolder
    Dim c As New cControl
    Dim s As New cSQL


    Private Sub iconHolder_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MaximizeBox = False
        MinimizeBox = False

        empName = s.GetDetailStr("employeeView", "EmployeeName", "userName", username)
        s.checkRestrict2(empName, "Reports", btnCreateSales)
        s.checkRestrict2(empName, "View Sales", btnViewSales)
        s.checkRestrict2(empName, "New PO", btnNewPO)
        s.checkRestrict2(empName, "View PO", btnViewPO)
        s.checkRestrict2(empName, "Close PO", btnClosePO)
        s.checkRestrict2(empName, "New RR", btnNewRR)
        s.checkRestrict2(empName, "View RR", btnViewRR)
        s.checkRestrict2(empName, "Create Payment", btnCreatePayment)
        s.checkRestrict2(empName, "View Payment", btnViewPayment)
    End Sub

    Private Sub btnNewPO_Click(sender As Object, e As EventArgs) Handles btnNewPO.Click
        For Each i As Form In Application.OpenForms
            If TypeOf i Is purchaseOrderAdd Then
                i.Activate()
                Return
            End If
        Next
        Dim f As New purchaseOrderAdd
        f.MdiParent = adminMDI
        f.Show()
    End Sub

    Private Sub btnViewPO_Click(sender As Object, e As EventArgs) Handles btnViewPO.Click
        For Each i As Form In Application.OpenForms
            If TypeOf i Is purchaseOrderView Then
                i.Activate()
                Return
            End If
        Next
        Dim f As New purchaseOrderView
        f.MdiParent = adminMDI
        f.Show()
    End Sub

    Private Sub btnClosePO_Click(sender As Object, e As EventArgs) Handles btnClosePO.Click
        For Each i As Form In Application.OpenForms
            If TypeOf i Is purchaseOrderClose Then
                i.Activate()
                Return
            End If
        Next
        Dim f As New purchaseOrderClose
        f.MdiParent = adminMDI
        f.Show()
    End Sub

    Private Sub btnNewRR_Click(sender As Object, e As EventArgs) Handles btnNewRR.Click
        For Each i As Form In Application.OpenForms
            If TypeOf i Is receivingRecordsAdd Then
                i.Activate()
                Return
            End If
        Next
        Dim f As New receivingRecordsAdd
        f.MdiParent = adminMDI
        f.Show()
    End Sub

    Private Sub btnViewRR_Click(sender As Object, e As EventArgs) Handles btnViewRR.Click
        For Each i As Form In Application.OpenForms
            If TypeOf i Is receivingRecordView Then
                i.Activate()
                Return
            End If
        Next
        Dim f As New receivingRecordView
        f.MdiParent = adminMDI
        f.Show()
    End Sub

    Private Sub btnCreatePayment_Click(sender As Object, e As EventArgs) Handles btnCreatePayment.Click
        For Each i As Form In Application.OpenForms
            If TypeOf i Is paymentAdd Then
                i.Activate()
                Return
            End If
        Next
        Dim f As New paymentAdd
        f.MdiParent = adminMDI
        f.Show()
    End Sub

    Private Sub btnViewPayment_Click(sender As Object, e As EventArgs) Handles btnViewPayment.Click
        For Each i As Form In Application.OpenForms
            If TypeOf i Is paymentHistory Then
                i.Activate()
                Return
            End If
        Next
        Dim f As New paymentHistory
        f.MdiParent = adminMDI
        f.Show()
    End Sub

    Private Sub btnCreateSales_Click(sender As Object, e As EventArgs) Handles btnCreateSales.Click
        For Each i As Form In Application.OpenForms
            If TypeOf i Is pointOfSale Then
                i.Activate()
                Return
            End If
        Next

        Dim f As New pointOfSale
        f.MdiParent = adminMDI
        f.Show()
    End Sub

    Private Sub btnViewSales_Click(sender As Object, e As EventArgs) Handles btnViewSales.Click
        For Each i As Form In Application.OpenForms
            If TypeOf i Is salesRecord Then
                i.Activate()
                Return
            End If
        Next
        Dim f As New salesRecord
        f.MdiParent = adminMDI
        f.Show()
    End Sub
End Class