Public Class paymentHistory
    Dim c As New cControl
    Dim s As New cSQL
    Private Sub FormLoad(sender As Object, e As EventArgs) Handles MyBase.Load
        s.loadCBXN(cmbSupplier, "supplier", "ID", "suppName", "where deletedBy is NULL")
        c.formatDTP(dateFrom, dateTo)

    End Sub



    Private Sub BtnCheck_Click(sender As Object, e As EventArgs) Handles btnCheck.Click
        startAt = c.getData(dateFrom)
        endsAt = c.getData(dateTo)
        supp = c.getData(cmbSupplier)
        If chkDatePeriod.Checked = True Then
            If cmbSupplier.SelectedIndex = -1 Then
                MsgBox("Please select supplier!", vbOKOnly, caption)
                cmbSupplier.Select()
                Exit Sub
            ElseIf s.checkValStr("supplier", "suppname", cmbSupplier.Text) = False Then
                MsgBox("Supplier does not exist!", vbOKOnly, caption)
                cmbSupplier.Select()
                Exit Sub
            Else
                If c.getRange(startAt, endsAt) = True Then
                    Exit Sub
                Else
                    s.loadDTGN(dgvPaymentList, "paymentView", "distinct paymentNo as 'Payment No.',Date,suppName", "suppName = '" & cmbSupplier.Text & "' and Date between '" & startAt & "' and '" & endsAt & "'", 4)
                End If
            End If
        ElseIf chkDatePeriod.Checked = False Then
            If cmbSupplier.SelectedIndex = -1 Then
                MsgBox("Please select supplier!", vbOKOnly, caption)
                cmbSupplier.Select()
                Exit Sub
            ElseIf s.checkValStr("supplier", "suppname", cmbSupplier.Text) = False Then
                MsgBox("Supplier does not exist!", vbOKOnly, caption)
                cmbSupplier.Select()
                Exit Sub
            Else
                s.loadDTGN(dgvPaymentList, "paymentView", "distinct paymentNo as 'Payment No.',Date,suppName", "suppName = '" & cmbSupplier.Text & "'", 4)
            End If
        End If
        dgvPaymentList.Columns("Payment No.").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgvPaymentList.Columns("Payment No.").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgvPaymentList.Columns("Date").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgvPaymentList.Columns("Date").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
    End Sub

    Private Sub LoadDetails(sender As Object, e As EventArgs) Handles dgvPaymentList.CellClick
        _index = dgvPaymentList.CurrentRow.Index
        whereIs = dgvPaymentList.Item(0, _index).Value
        s.loadDTGN(dgvPaymentDetails, "paymentHistory", "", "paymentNo = '" & whereIs & "'", 3)
    End Sub

    Private Sub tago(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles dgvPaymentDetails.DataBindingComplete
        With dgvPaymentDetails
            .Columns("ID").Visible = False
            '.Columns("SupplierID").Visible = False
            .Columns("paymentNo").Visible = False
            dgvPaymentDetails.Columns(3).DefaultCellStyle.Format = "MM/dd/yyyy"

            dgvPaymentDetails.Columns("RR Amount").DefaultCellStyle.Format = "N"
            dgvPaymentDetails.Columns("Amount Paid").DefaultCellStyle.Format = "N"
            dgvPaymentDetails.Columns("Balance").DefaultCellStyle.Format = "N"

            dgvPaymentDetails.Columns("RRDate").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            dgvPaymentDetails.Columns("RRDate").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            dgvPaymentDetails.Columns("RR Amount").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            dgvPaymentDetails.Columns("RR Amount").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            dgvPaymentDetails.Columns("Amount Paid").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            dgvPaymentDetails.Columns("Amount Paid").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            dgvPaymentDetails.Columns("Balance").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            dgvPaymentDetails.Columns("Balance").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        End With
    End Sub

    Private Sub tagoo(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles dgvPaymentList.DataBindingComplete
        With dgvPaymentList
            .Columns("suppName").Visible = False
            dgvPaymentList.Columns(1).DefaultCellStyle.Format = "MM/dd/yyyy"
        End With
    End Sub

    Private Sub EnablePanelDate(sender As Object, e As EventArgs) Handles chkDatePeriod.CheckedChanged
        If chkDatePeriod.CheckState = CheckState.Checked Then
            panelDate.Enabled = True
        ElseIf chkDatePeriod.CheckState = CheckState.Unchecked Then
            panelDate.Enabled = False
        End If
    End Sub

    Private Sub BtnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        cmbSupplier.SelectedIndex = -1
        chkDatePeriod.Checked = False
        c.clrDS(dgvPaymentDetails)
        c.clrDS(dgvPaymentList)
    End Sub

    Private Sub datePeriodChecked(sender As Object, e As EventArgs) Handles chkDatePeriod.CheckedChanged
        c.clrDS(dgvPaymentList)
        c.clrDS(dgvPaymentDetails)
    End Sub

    Private Sub dateChanged(sender As Object, e As EventArgs) Handles dateFrom.TextChanged, dateTo.TextChanged
        c.clrDS(dgvPaymentList)
        c.clrDS(dgvPaymentDetails)
    End Sub
End Class