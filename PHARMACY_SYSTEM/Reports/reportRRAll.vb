Public Class reportRRAll
    Dim c As New cControl
    Dim s As New cSQL
    Private Sub reportsPO_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        c.FormProps(Me)
        c.formatDTP(dateFrom, dateTo)
        panelDate.Enabled = False
        Label1.Visible = False
        cmbSupplier.Visible = False
        s.loadCBX(cmbSupplier, "cmbSupp", "ID", "suppname")
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        If chkRRAll.CheckState = CheckState.Checked Then
            If chkDatePeriod.CheckState = CheckState.Checked Then
                startAt = c.getData(dateFrom)
                endsAt = c.getData(dateTo)
                querRR = "select * from RRReportHistory where RRDate between '" & startAt & "' and '" & endsAt & "'"
                rptSubPop = "allRR"
                RRPrintVw.Show()
                Exit Sub
            Else
                querRR = "select * from RRReportHistory"
                rptSubPop = "allRR"
                RRPrintVw.Show()
                Exit Sub
            End If
        ElseIf chkRRPaid.CheckState = CheckState.Checked Then
            If chkDatePeriod.CheckState = CheckState.Checked Then
                startAt = c.getData(dateFrom)
                endsAt = c.getData(dateTo)
                querRR = "select * from RRReportHistory where totalRR = '0.00' and RRDate between '" & startAt & "' and '" & endsAt & "'"
                rptSubPop = "allRR"
                RRPrintVw.Show()
                Exit Sub
            Else
                querRR = "select * from RRReportHistory where totalRR = '0.00'"
                rptSubPop = "allRR"
                RRPrintVw.Show()
                Exit Sub
            End If
        ElseIf chkRRUnpaid.CheckState = CheckState.Checked Then
            If chkDatePeriod.CheckState = CheckState.Checked Then
                startAt = c.getData(dateFrom)
                endsAt = c.getData(dateTo)
                querRR = "select * from RRReportHistory where totalRR > '0.00' and RRDate between '" & startAt & "' and '" & endsAt & "'"
                rptSubPop = "allRR"
                RRPrintVw.Show()
                Exit Sub
            Else
                querRR = "select * from RRReportHistory where totalRR > '0.00'"
                rptSubPop = "allRR"
                RRPrintVw.Show()
                Exit Sub
            End If
        ElseIf chkRRBySupplier.CheckState = CheckState.Checked Then
            Dim id As Integer = c.getData(cmbSupplier)
            Dim supplier As String = s.GetDetailStr("supplier", "suppName", "ID", id)
            querRR = "select * from RRReportHistory where suppName = '" & supplier & "'"
            rptSubPop = "allRR"
            RRPrintVw.Show()
            Exit Sub
        End If
    End Sub

    Private Sub ToggleChkBox1(sender As Object, e As EventArgs) Handles chkRRAll.CheckedChanged 'all PO
        If chkRRAll.CheckState = CheckState.Checked Then
            chkRRUnpaid.Enabled = False
            chkRRPaid.Enabled = False
            chkRRBySupplier.Enabled = False
        ElseIf chkRRAll.CheckState = CheckState.Unchecked Then 'all block
            chkRRUnpaid.Enabled = True
            chkRRPaid.Enabled = True
            chkRRBySupplier.Enabled = True
        End If
    End Sub

    Private Sub ToggleChkBox2(sender As Object, e As EventArgs) Handles chkRRUnpaid.CheckedChanged 'RR Unpaid
        If chkRRUnpaid.CheckState = CheckState.Checked Then
            chkRRAll.Enabled = False
            chkRRPaid.Enabled = False
            chkRRBySupplier.Enabled = False
        ElseIf chkRRUnpaid.CheckState = CheckState.Unchecked Then 'close block
            chkRRAll.Enabled = True
            chkRRPaid.Enabled = True
            chkRRBySupplier.Enabled = True
        End If
    End Sub

    Private Sub ToggleChkBox3(sender As Object, e As EventArgs) Handles chkRRPaid.CheckedChanged 'RR Paid
        If chkRRPaid.CheckState = CheckState.Checked Then
            chkRRUnpaid.Enabled = False
            chkRRAll.Enabled = False
            chkRRBySupplier.Enabled = False
        ElseIf chkRRPaid.CheckState = CheckState.Unchecked Then 'pending block
            chkRRUnpaid.Enabled = True
            chkRRAll.Enabled = True
            chkRRBySupplier.Enabled = True
        End If
    End Sub

    Private Sub ToggleChkBox5(sender As Object, e As EventArgs) Handles chkRRBySupplier.CheckedChanged 'by supplier
        If chkRRBySupplier.CheckState = CheckState.Checked Then
            Label1.Visible = True
            cmbSupplier.Enabled = True
            cmbSupplier.Visible = True
            panelDate.Enabled = False
            chkDatePeriod.Enabled = False
            chkRRUnpaid.Enabled = False
            chkRRPaid.Enabled = False
            chkRRAll.Enabled = False
        ElseIf chkRRBySupplier.CheckState = CheckState.Unchecked Then 'supplier block
            Label1.Visible = False
            cmbSupplier.Enabled = False
            cmbSupplier.Visible = False
            panelDate.Enabled = True
            chkDatePeriod.Enabled = True
            chkRRUnpaid.Enabled = True
            chkRRPaid.Enabled = True
            chkRRAll.Enabled = True
        End If
    End Sub

    Private Sub ToggleChkDate(sender As Object, e As EventArgs) Handles chkDatePeriod.CheckedChanged
        If chkDatePeriod.CheckState = CheckState.Checked Then
            panelDate.Enabled = True
        ElseIf chkDatePeriod.CheckState = CheckState.Unchecked Then 'supplier block
            panelDate.Enabled = False

        End If
    End Sub

End Class