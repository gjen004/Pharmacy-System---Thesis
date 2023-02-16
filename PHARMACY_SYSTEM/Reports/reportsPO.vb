Public Class reportsPO
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
        If chkPOAll.CheckState = CheckState.Checked Then
            If chkDatePeriod.CheckState = CheckState.Checked Then
                startAt = c.getData(dateFrom)
                endsAt = c.getData(dateTo)
                querPODR = "select * from POReportHistory where PODTCreate between '" & startAt & "' and '" & endsAt & "'"
                POHistory.Show()
                Exit Sub
            Else
                querPODR = "select * from POReportHistory"
                POHistory.Show()
                Exit Sub
            End If
        ElseIf chkPOPending.CheckState = CheckState.Checked Then
            If chkDatePeriod.CheckState = CheckState.Checked Then
                startAt = c.getData(dateFrom)
                endsAt = c.getData(dateTo)
                querPOPnd = "select * from POReportHistory where PODTCreate between '" & startAt & "' and '" & endsAt & "' and status = 'Active'"
                PrintPOHistoryPendingVw.Show()
                Exit Sub
            Else
                querPOPnd = "select * from POReportHistory where status = 'Active'"
                PrintPOHistoryPendingVw.Show()
                Exit Sub
            End If
        ElseIf chkPOVoid.CheckState = CheckState.Checked Then
            If chkDatePeriod.CheckState = CheckState.Checked Then
                startAt = c.getData(dateFrom)
                endsAt = c.getData(dateTo)
                querPOVd = "select * from POHistoryVoid where PODTCreate between '" & startAt & "' and '" & endsAt & "' and status = 'Voided'"
                PrintPOHistoryVoidVw.Show()
                Exit Sub
            Else
                querPOVd = "select * from POHistoryVoid where status = 'Voided'"
                PrintPOHistoryVoidVw.Show()
                Exit Sub
            End If
        ElseIf chkPOClose.CheckState = CheckState.Checked Then
            If chkDatePeriod.CheckState = CheckState.Checked Then
                startAt = c.getData(dateFrom)
                endsAt = c.getData(dateTo)
                querPOCls = "select * from POHistoryClose where PODTCreate between '" & startAt & "' and '" & endsAt & "' and status = 'Closed'"
                PrintPOHistoryClsVw.Show()
                Exit Sub
            Else
                querPOCls = "select * from POHistoryClose where status = 'Closed'"
                PrintPOHistoryClsVw.Show()
                Exit Sub
            End If
        ElseIf chkPOBySupplier.CheckState = CheckState.Checked Then
            Dim id As Integer = c.getData(cmbSupplier)
            Dim supplier As String = s.GetDetailStr("supplier", "suppName", "ID", id)
            querPOSupp = "select * from POReportHistory where suppName = '" & supplier & "'"
            POHistoryBySupplier.Show()
            Exit Sub
        End If
    End Sub

    Private Sub ToggleChkBox1(sender As Object, e As EventArgs) Handles chkPOAll.CheckedChanged 'all PO
        If chkPOAll.CheckState = CheckState.Checked Then
            chkPOClose.Enabled = False
            chkPOPending.Enabled = False
            chkPOVoid.Enabled = False
            chkPOBySupplier.Enabled = False
        ElseIf chkPOAll.CheckState = CheckState.Unchecked Then 'all block
            chkPOClose.Enabled = True
            chkPOPending.Enabled = True
            chkPOVoid.Enabled = True
            chkPOBySupplier.Enabled = True
        End If
    End Sub

    Private Sub ToggleChkBox2(sender As Object, e As EventArgs) Handles chkPOClose.CheckedChanged 'closed PO
        If chkPOClose.CheckState = CheckState.Checked Then
            chkPOAll.Enabled = False
            chkPOPending.Enabled = False
            chkPOVoid.Enabled = False
            chkPOBySupplier.Enabled = False
        ElseIf chkPOClose.CheckState = CheckState.Unchecked Then 'close block
            chkPOAll.Enabled = True
            chkPOPending.Enabled = True
            chkPOVoid.Enabled = True
            chkPOBySupplier.Enabled = True
        End If
    End Sub

    Private Sub ToggleChkBox3(sender As Object, e As EventArgs) Handles chkPOPending.CheckedChanged 'pending po
        If chkPOPending.CheckState = CheckState.Checked Then
            chkPOClose.Enabled = False
            chkPOAll.Enabled = False
            chkPOVoid.Enabled = False
            chkPOBySupplier.Enabled = False
        ElseIf chkPOPending.CheckState = CheckState.Unchecked Then 'pending block
            chkPOClose.Enabled = True
            chkPOAll.Enabled = True
            chkPOVoid.Enabled = True
            chkPOBySupplier.Enabled = True
        End If
    End Sub

    Private Sub ToggleChkBox4(sender As Object, e As EventArgs) Handles chkPOVoid.CheckedChanged 'void po
        If chkPOVoid.CheckState = CheckState.Checked Then
            chkPOClose.Enabled = False
            chkPOPending.Enabled = False
            chkPOAll.Enabled = False
            chkPOBySupplier.Enabled = False
        ElseIf chkPOVoid.CheckState = CheckState.Unchecked Then 'void block
            chkPOClose.Enabled = True
            chkPOPending.Enabled = True
            chkPOAll.Enabled = True
            chkPOBySupplier.Enabled = True
        End If
    End Sub

    Private Sub ToggleChkBox5(sender As Object, e As EventArgs) Handles chkPOBySupplier.CheckedChanged 'by supplier
        If chkPOBySupplier.CheckState = CheckState.Checked Then
            Label1.Visible = True
            cmbSupplier.Enabled = True
            cmbSupplier.Visible = True
            panelDate.Enabled = False
            chkDatePeriod.Enabled = False
            chkPOClose.Enabled = False
            chkPOPending.Enabled = False
            chkPOAll.Enabled = False
            chkPOVoid.Enabled = False
        ElseIf chkPOBySupplier.CheckState = CheckState.Unchecked Then 'supplier block
            Label1.Visible = False
            cmbSupplier.Enabled = False
            cmbSupplier.Visible = False
            panelDate.Enabled = True
            chkDatePeriod.Enabled = True
            chkPOClose.Enabled = True
            chkPOPending.Enabled = True
            chkPOAll.Enabled = True
            chkPOVoid.Enabled = True
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