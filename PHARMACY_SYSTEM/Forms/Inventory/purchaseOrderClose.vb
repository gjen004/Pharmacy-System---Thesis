Public Class purchaseOrderClose
    Dim s As New cSQL
    Dim c As New cControl
    Dim PO As New ivPO
    Private Sub frmload(sender As Object, e As EventArgs) Handles MyBase.Load
        populate()
        panelDate.Enabled = False 'fix
        c.formatDTP(dateFrom, dateTo)

    End Sub

    Private Sub hideID(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles dgvPODetails.DataBindingComplete
        With dgvPODetails
            .Columns("ID").Visible = False
            .Columns("PO No.").Visible = False
            .Columns("Status").Visible = False
            .Columns("Unit Cost").Visible = False
            dgvPODetails.Columns("Quantity").DefaultCellStyle.Format = "#,###"
            dgvPODetails.Columns("Balance").DefaultCellStyle.Format = "#,###"
        End With
    End Sub

    'Private Sub hideIDd(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles dgvPOList.DataBindingComplete
    '    With dgvPOList
    '        dgvPOList.Columns(1).DefaultCellStyle.Format = "MM/dd/yyyy"

    '    End With
    'End Sub

    Private Sub showMatch(sender As Object, e As EventArgs) Handles btnCheck.Click
        c.setPOList(dgvPOList, chkDatePeriod, dateFrom, dateTo, cmbSupplier, 2)

    End Sub

    Private Sub polistHideID(sender As Object, e As EventArgs) Handles dgvPOList.DataBindingComplete
        'dgvPOList.Columns(1).DefaultCellStyle.Format = "MM/dd/yyyy"
        dgvPOList.Columns("PO No.").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgvPOList.Columns("PO No.").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgvPOList.Columns("Date").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgvPOList.Columns("Date").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgvPOList.Columns("Status").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgvPOList.Columns("Status").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
    End Sub

    Private Sub populate()
        s.loadCBXN(cmbSupplier, "supplier", "ID", "suppName", "where deletedBy is NULL")
        s.loadCBXN(cmbReason, "reasonview", "ID", "Reasons", "where Usage  = 'Close PO'")
    End Sub

    Private Sub loadRelatedPO(sender As Object, e As EventArgs) Handles dgvPOList.CellClick
        Try
            _index = dgvPOList.CurrentRow.Index
            whereIs = dgvPOList.Item(0, _index).Value
            dgvPODetails.Enabled = False
            's.loadDTGN(dgvPODetails, "POCloseVoid", "", "PONum = " + whereIs, 3)
            s.loadDTGN(dgvPODetails, "POCloseVoid", "ID, PONum as 'PO No.', Product, Quantity, unitPrice as 'Unit Cost', balance as 'Balance', Status", "PONum = " + whereIs, 4)
            btnPOClose.Enabled = True
            cmbReason.Enabled = True

            dgvPODetails.Columns("Product").Width = 400
            dgvPODetails.Columns("Quantity").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            dgvPODetails.Columns("Quantity").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            dgvPODetails.Columns("Balance").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            dgvPODetails.Columns("Balance").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            dgvPODetails.Columns("Status").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            dgvPODetails.Columns("Status").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub closeRecord(sender As Object, e As EventArgs) Handles btnPOClose.Click
        Try
            _index = dgvPOList.CurrentRow.Index
            whereIs = dgvPOList.Item(0, _index).Value
            res = c.getData(cmbReason)
            If res < 1 Then
                MsgBox("No Reason Selected", vbOKOnly, caption)
                cmbReason.Select()
                Exit Sub
                'ElseIf s.checkValStr("reason", "fullReason", cmbReason.Text) = False Then
                '    MsgBox("Reason Does Not Exist")
                '    res = Nothing
                '    Exit Sub
            Else
                'MsgBox("Corny")
                'PO.voidClsOrd(dgvPODetails, "PO", 2, whereIs, res, username)
                'Reset()
                Dim message As String = "Are you sure you want to Close PO?"                    'added 01/21/2020
                Dim icons As Integer = MessageBoxIcon.Question
                Dim buttons As Integer = MessageBoxButtons.YesNo
                Dim result As DialogResult
                result = MessageBox.Show(Me, message, caption, buttons, icons)
                If result = DialogResult.Yes Then
                    PO.voidClsOrd(dgvPODetails, "PO", 2, whereIs, cmbReason.Text, username)
                    Reset()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    'fixes
    Private Sub FormRefresh(sender As Object, e As EventArgs) Handles btnRefresh.Click
        Reset()
    End Sub
    Private Sub EnablePanelDate(sender As Object, e As EventArgs) Handles chkDatePeriod.CheckedChanged
        If chkDatePeriod.CheckState = CheckState.Checked Then
            panelDate.Enabled = True
        ElseIf chkDatePeriod.CheckState = CheckState.Unchecked Then
            panelDate.Enabled = False
        End If
    End Sub

    Private Sub UnloadList(sender As Object, e As EventArgs) Handles dateFrom.TextChanged, dateTo.TextChanged
        c.clrDS(dgvPOList)
        c.clrDS(dgvPODetails)
    End Sub

    Private Sub cmbSupplierChanged(sender As Object, e As EventArgs) Handles cmbSupplier.SelectedIndexChanged
        c.clrDS(dgvPOList)
        c.clrDS(dgvPODetails)
    End Sub

    Private Sub Reset()
        dgvPOList.DataSource = Nothing
        dgvPODetails.DataSource = Nothing
        cmbSupplier.SelectedIndex = -1
        cmbSupplier.Text = ""
        panelDate.Enabled = False
        chkDatePeriod.Checked = False
        btnPOClose.Enabled = False
        cmbReason.Enabled = False
        cmbReason.SelectedIndex = -1
        cmbReason.Text = ""
    End Sub

End Class