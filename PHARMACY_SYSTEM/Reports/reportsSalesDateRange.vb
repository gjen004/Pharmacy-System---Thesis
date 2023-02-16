Public Class reportsSalesDateRange
    Dim c As New cControl
    Dim s As New cSQL

    Private Sub reportsPO_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        c.formatDTP(dateFrom, dateTo)
        c.FormProps(Me)
        s.loadCBX(cmbProduct, "ProductOnSale", "ID", "Product")
        s.loadCBX(cmbEmployee, "employeeView", "id", "EmployeeName")
        s.loadCBX(cmbCat, "category", "ID", "categName")
        s.loadCBXN(cmbPromo, "promoView", "ID", "Promo Name", " where voidBy is NULL")
        panelDate.Enabled = False
        Label1.Visible = False
        cmbProduct.Visible = False
        Label4.Visible = False
        cmbEmployee.Visible = False
        Label5.Visible = False
        cmbCat.Visible = False
        Label6.Enabled = False
        cmbPromo.Enabled = False
        Label6.Visible = False
        cmbPromo.Visible = False
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        If chkAllSales.CheckState = CheckState.Checked Then
            If chkDatePeriod.CheckState = CheckState.Checked Then
                startAt = c.getData(dateFrom)
                endsAt = c.getData(dateTo)
                querSales = "select * from ReportSalesDetails where savedDT between '" & startAt & " 00:00:00.000' and '" & endsAt & " 23:59:59.999'"
                rptSubPop = "salesReportAllDR"
                table = "ReportSalesDetails"
                SalesHistoryVw.Show()
                Exit Sub
            Else
                querSales = "select * from ReportSalesDetails"
                rptSubPop = "salesReportAllDR"
                table = "ReportSalesDetails"
                SalesHistoryVw.Show()
                Exit Sub
            End If
        ElseIf chkPerProd.CheckState = CheckState.Checked Then
            If chkDatePeriod.CheckState = CheckState.Checked Then
                Dim id As Integer = c.getData(cmbProduct)
                Dim prod As String = s.GetDetailStr("ProductOnSale", "Product", "ID", id)
                startAt = c.getData(dateFrom)
                endsAt = c.getData(dateTo)
                'querSales = "select * from ReportSalesDetails where Product = '" & prod & "' and ID > 0 and savedDT between '" & startAt & " 00:00:00.000' and '" & endsAt & " 23:59:59.999'"
                querSales = "select * from ReportSalesDetails where Product = '" & prod & "' and savedDT between '" & startAt & " 00:00:00.000' and '" & endsAt & " 23:59:59.999'"
                rptSubPop = "salesReportPerProd"
                table = "ReportSalesDetails"
                SalesHistoryVw.Show()
                Exit Sub
            Else
                Dim id As Integer = c.getData(cmbProduct)
                Dim prod As String = s.GetDetailStr("ProductOnSale", "Product", "ID", id)
                startAt = c.getData(dateFrom)
                endsAt = c.getData(dateTo)
                querSales = "select * from ReportSalesDetails where Product = '" & prod & "'"
                rptSubPop = "salesReportPerProd"
                table = "ReportSalesDetails"
                SalesHistoryVw.Show()
                Exit Sub
            End If
        ElseIf chkPerEmp.CheckState = CheckState.Checked Then
            If chkDatePeriod.CheckState = CheckState.Checked Then
                Dim id As Integer = c.getData(cmbEmployee)
                'Dim emp As String = s.GetDetailStr("employee", "userName", "ID", id)
                Dim emp As String = s.GetDetailStr("employeeView", "EmployeeName", "id", id)

                startAt = c.getData(dateFrom)
                endsAt = c.getData(dateTo)
                'querSales = "select * from ReportSalesDetails where savedBy = '" & emp & "' and savedDT between '" & startAt & " 00:00:00.000' and '" & endsAt & " 23:59:59.999'"
                querSales = "select * from ReportSalesDetails where savedBy = '" & emp & "' and savedDT between '" & startAt & "' and '" & endsAt & "'"

                rptSubPop = "salesReportPerEmp"
                table = "ReportSalesDetails"
                SalesHistoryVw.Show()
                Exit Sub
            Else
                Dim id As Integer = c.getData(cmbEmployee)
                Dim emp As String = s.GetDetailStr("employeeView", "EmployeeName", "id", id)
                startAt = c.getData(dateFrom)
                endsAt = c.getData(dateTo)
                'MsgBox(emp)
                querSales = "select * from ReportSalesDetails where savedBy = '" & emp & "'"
                rptSubPop = "salesReportPerEmp"
                table = "ReportSalesDetails"
                SalesHistoryVw.Show()
                Exit Sub
            End If
        ElseIf chkPerCat.CheckState = CheckState.Checked Then
            If chkDatePeriod.CheckState = CheckState.Checked Then
                startAt = c.getData(dateFrom)
                endsAt = c.getData(dateTo)
                Dim id As Integer = c.getData(cmbCat)
                Dim categ As String = s.GetDetailStr("category", "categName", "ID", id)
                'querSales = "select * from ReportSalesDetails where Category = '" & categ & "' and (savedDT between '" & startAt & " 00:00:00.000' and '" & endsAt & " 23:59:59.999')"
                querSales = "select * from ReportSalesDetails where Category = '" & categ & "' and savedDT between '" & startAt & " 00:00:00.000' and '" & endsAt & " 23:59:59.999'"
                rptSubPop = "salesReportCat"
                table = "ReportSalesDetails"
                SalesHistoryVw.Show()
                Exit Sub
            Else
                Dim id As Integer = c.getData(cmbCat)
                Dim categ As String = s.GetDetailStr("category", "categName", "ID", id)
                querSales = "select * from ReportSalesDetails where Category ='" & categ & "'"
                rptSubPop = "salesReportCat"
                table = "ReportSalesDetails"
                SalesHistoryVw.Show()
                Exit Sub
            End If
        ElseIf chkWdc.CheckState = CheckState.Checked Then
            If chkDatePeriod.CheckState = CheckState.Checked Then
                startAt = c.getData(dateFrom)
                endsAt = c.getData(dateTo)
                querSales = "select * from ReportSalesDetails where discountName not like '' and (savedDT between '" & startAt & " 00:00:00.000' and '" & endsAt & " 23:59:59.999')"
                rptSubPop = "salesReportWDC"
                table = "ReportSalesDetails"
                SalesHistoryVw.Show()
                Exit Sub
            Else
                Dim id As Integer = c.getData(cmbCat)
                Dim categ As String = s.GetDetailStr("category", "categName", "ID", id)
                querSales = "select * from ReportSalesDetails where discountName not like ''"
                rptSubPop = "salesReportWDC"
                table = "ReportSalesDetails"
                SalesHistoryVw.Show()
                Exit Sub
            End If
        ElseIf chkWp.CheckState = CheckState.Checked Then
            If chkDatePeriod.CheckState = CheckState.Checked Then
                Dim id As Integer = c.getData(cmbPromo)
                Dim promo As String = s.GetDetailStr("promoView", "[Promo Name]", "ID", id)
                startAt = c.getData(dateFrom)
                endsAt = c.getData(dateTo)
                'MsgBox(categ)
                querSales = "select * from ReportSalesDetails where promoName = '" & promo & "' and (savedDT between '" & startAt & " 00:00:00.000' and '" & endsAt & " 23:59:59.999')"
                rptSubPop = "salesReportWP"
                table = "ReportSalesDetails"
                SalesHistoryVw.Show()
                Exit Sub
            Else
                Dim id As Integer = c.getData(cmbPromo)
                Dim promo As String = s.GetDetailStr("promoView", "[Promo Name]", "ID", id)
                'MsgBox(categ)
                querSales = "select * from ReportSalesDetails where promoName = '" & promo & "'"
                rptSubPop = "salesReportWP"
                table = "ReportSalesDetails"
                SalesHistoryVw.Show()
                Exit Sub
            End If
        End If
    End Sub

    Private Sub ToggleChkDate(sender As Object, e As EventArgs) Handles chkDatePeriod.CheckedChanged
        If chkDatePeriod.CheckState = CheckState.Checked Then
            panelDate.Enabled = True
        ElseIf chkDatePeriod.CheckState = CheckState.Unchecked Then 'supplier block
            panelDate.Enabled = False
        End If
    End Sub

    Private Sub ToggleChkBox1(sender As Object, e As EventArgs) Handles chkAllSales.CheckedChanged 'all sales
        If chkAllSales.CheckState = CheckState.Checked Then
            chkPerCat.Enabled = False
            chkPerEmp.Enabled = False
            chkPerProd.Enabled = False
            chkWp.Enabled = False
            chkWdc.Enabled = False
        ElseIf chkAllSales.CheckState = CheckState.Unchecked Then
            chkPerCat.Enabled = True
            chkPerEmp.Enabled = True
            chkPerProd.Enabled = True
            chkWdc.Enabled = True
            chkWp.Enabled = True
        End If
    End Sub

    Private Sub ToggleChkBox2(sender As Object, e As EventArgs) Handles chkPerEmp.CheckedChanged 'sales /emp
        If chkPerEmp.CheckState = CheckState.Checked Then
            Label4.Visible = True
            cmbEmployee.Visible = True
            chkPerCat.Enabled = False
            chkAllSales.Enabled = False
            chkPerProd.Enabled = False
            chkWdc.Enabled = False
            chkWp.Enabled = False
        ElseIf chkPerEmp.CheckState = CheckState.Unchecked Then
            Label4.Visible = False
            cmbEmployee.Visible = False
            chkPerCat.Enabled = True
            chkAllSales.Enabled = True
            chkPerProd.Enabled = True
            chkWdc.Enabled = True
            chkWp.Enabled = True
        End If
    End Sub

    Private Sub ToggleChkBox3(sender As Object, e As EventArgs) Handles chkPerProd.CheckedChanged 'sales/prod
        If chkPerProd.CheckState = CheckState.Checked Then
            Label1.Visible = True
            cmbProduct.Visible = True
            chkPerCat.Enabled = False
            chkAllSales.Enabled = False
            chkPerEmp.Enabled = False
            chkWdc.Enabled = False
            chkWp.Enabled = False
        ElseIf chkPerProd.CheckState = CheckState.Unchecked Then
            Label1.Visible = False
            cmbProduct.Visible = False
            chkPerCat.Enabled = True
            chkAllSales.Enabled = True
            chkPerEmp.Enabled = True
            chkWdc.Enabled = True
            chkWp.Enabled = True
        End If
    End Sub

    Private Sub ToggleChkBox4(sender As Object, e As EventArgs) Handles chkPerCat.CheckedChanged 'sales/cat
        If chkPerCat.CheckState = CheckState.Checked Then
            chkPerProd.Enabled = False
            chkAllSales.Enabled = False
            chkPerEmp.Enabled = False
            Label5.Visible = True
            cmbCat.Visible = True
            chkWdc.Enabled = False
            chkWp.Enabled = False
        ElseIf chkPerCat.CheckState = CheckState.Unchecked Then 'void block
            chkPerProd.Enabled = True
            chkAllSales.Enabled = True
            chkPerEmp.Enabled = True
            chkWdc.Enabled = True
            chkWp.Enabled = True
            Label5.Visible = False
            cmbCat.Visible = False
        End If
    End Sub

    Private Sub ToggleChkBox5(sender As Object, e As EventArgs) Handles chkWdc.CheckedChanged 'sales/cat
        If chkWdc.CheckState = CheckState.Checked Then
            chkWdc.Enabled = True
            chkPerProd.Enabled = False
            chkAllSales.Enabled = False
            chkPerEmp.Enabled = False
            chkWp.Enabled = False
            chkPerCat.Enabled = False
        ElseIf chkWdc.CheckState = CheckState.Unchecked Then 'void block
            chkPerProd.Enabled = True
            chkAllSales.Enabled = True
            chkPerEmp.Enabled = True
            chkWp.Enabled = True
            chkWdc.Enabled = True
            chkPerCat.Enabled = True
        End If
    End Sub

    Private Sub ToggleChkBox6(sender As Object, e As EventArgs) Handles chkWp.CheckedChanged 'promo
        If chkWp.CheckState = CheckState.Checked Then
            chkWp.Enabled = True
            Label6.Enabled = True
            cmbPromo.Enabled = True
            Label6.Visible = True
            cmbPromo.Visible = True
            chkPerProd.Enabled = False
            chkAllSales.Enabled = False
            chkPerEmp.Enabled = False
            chkWdc.Enabled = False
            chkPerCat.Enabled = False
        ElseIf chkWp.CheckState = CheckState.Unchecked Then 'void block
            chkPerProd.Enabled = True
            chkAllSales.Enabled = True
            chkPerEmp.Enabled = True
            chkWp.Enabled = True
            chkWdc.Enabled = True
            chkPerCat.Enabled = True
            Label6.Enabled = False
            cmbPromo.Enabled = False
            Label6.Visible = False
            cmbPromo.Visible = False
        End If
    End Sub

End Class