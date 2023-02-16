Imports System.Windows.Forms
Public Class receivingRecordUpdate
    Dim s As New cSQL
    Dim c As New cControl
    Dim RR As New ivRR
    Dim suppName As String

    Private Sub frmload(sender As Object, e As EventArgs) Handles MyBase.Load
        populate()
        panelDate.Enabled = True
        grpPODetails.Enabled = False
        grpRR.Enabled = False
        panelDate.Enabled = False
        c.formatDTP(dateFrom, dateTo)
        c.formatDTP(dateExpiry, dateRR)
        c.FormProps(Me)
        s.RunQuery("delete from tempDetails")
        prodName = ""
    End Sub

    Private Sub frmclose(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dim count As Integer = dgvUpDetails.Rows.Count
        If count > 0 Then
            'Dim result As DialogResult
            'MsgBox("There is an item selected, changes will be disregarded ...", vbOKCancel, caption)
            's.RunQuery("delete from tempDetails")
            Dim message As String = "There is an item selected, changes will be disregarded ..."
            Dim icons As Integer = MessageBoxIcon.Question
            Dim buttons As Integer = MessageBoxButtons.YesNo

            Dim result As DialogResult

            result = MessageBox.Show(Me, message, caption, buttons, icons)

            If result = DialogResult.Yes Then
                e.Cancel = False
                s.clearTemp("tempDetails")
            Else
                e.Cancel = True
            End If

        End If
        's.RunQuery("delete from tempDetails")
    End Sub

    Private Sub EnablePanelDate(sender As Object, e As EventArgs) Handles chkTimePeriod.CheckedChanged
        If chkTimePeriod.CheckState = CheckState.Checked Then
            panelDate.Enabled = True
        ElseIf chkTimePeriod.CheckState = CheckState.Unchecked Then
            panelDate.Enabled = False
        End If
    End Sub

    Private Sub ClearRRList(sender As Object, e As EventArgs) Handles dateFrom.TextChanged, dateTo.TextChanged
        c.clrDS(dgvRRList)
        c.clrDS(dgvRRDetails)
    End Sub

    Private Sub populate()
        s.loadCBXN(cmbSupplier, "supplier", "ID", "suppName", "where deletedBy is NULL")
        s.loadCBXN(cmbReceivedBy, "employeeview", "ID", "EmployeeName", "where [EmployeeName] not like('%admin%')")
    End Sub
    'PO according to values
    Private Sub loadPO(sender As Object, e As EventArgs) Handles btnCheck.Click
        c.setUpRRList(dgvRRList, chkTimePeriod, dateFrom, dateTo, cmbSupplier)

    End Sub

    Private Sub hideDets(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles dgvRRList.DataBindingComplete
        With dgvRRList
            .Columns("suppName").Visible = False
            .Columns("ReceivedBy").Visible = False
            .Columns("Remarks").Visible = False
            .Columns("stock").Visible = False
            .Columns("balance").Visible = False
            dgvRRList.Columns(2).DefaultCellStyle.Format = "MM/dd/yyyy"
            dgvRRList.Columns("RR No.").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            dgvRRList.Columns("RR No.").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            dgvRRList.Columns("Date").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            dgvRRList.Columns("Date").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        End With
    End Sub

    'load data to PODetails Grid
    Private Sub loadDetails(sender As Object, e As EventArgs) Handles dgvRRList.CellMouseClick
        Try
            _index = dgvRRList.CurrentRow.Index
            whereIs = dgvRRList.Item(0, _index).Value
            txtRRNo.Text = dgvRRList.Item(0, _index).Value
            s.loadDTGN(dgvRRDetails, "UpdateRR", "", "RRID = " + whereIs, 3)
            grpPODetails.Enabled = True
            dateExpiry.Enabled = True
            txtRRQuantity.Enabled = True
            btnAdd.Enabled = True
            grpRR.Enabled = True
            cmbReceivedBy.Enabled = False

            cmbReceivedBy.Text = dgvRRList.Item(3, _index).Value
            dateRR.Value = Convert.ToDateTime(dgvRRList.Item(2, _index).Value)

            btnRemove.Enabled = False
            btnRRSave.Enabled = False

            dgvRRDetails.Columns("ProdExpDate").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            dgvRRDetails.Columns("ProdExpDate").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            dgvRRDetails.Columns("SellingPrice").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            dgvRRDetails.Columns("SellingPrice").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            dgvRRDetails.Columns("OrderQuantity").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            dgvRRDetails.Columns("OrderQuantity").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            dgvRRDetails.Columns("PO Amount").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            dgvRRDetails.Columns("PO Amount").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            dgvRRDetails.Columns("Unit Cost").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            dgvRRDetails.Columns("Unit Cost").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            dgvRRDetails.Columns("QuantityReceived").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            dgvRRDetails.Columns("QuantityReceived").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            dgvRRDetails.Columns("RRAmount").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            dgvRRDetails.Columns("RRAmount").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub HideUnneccessary(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles dgvRRDetails.DataBindingComplete
        With dgvRRDetails
            .Columns("ID").Visible = False
            .Columns("RRID").Visible = False
            .Columns("PODetailsID").Visible = False
            '.Columns("[Order Quantity]").Visible = False
            '.Columns("unitPrice").Visible = False
            .Columns("EmployeeName").Visible = False
            dgvRRDetails.Columns(4).DefaultCellStyle.Format = "MM/dd/yyyy"

            dgvRRDetails.Columns("Unit Cost").DefaultCellStyle.Format = "N"
            dgvRRDetails.Columns("SellingPrice").DefaultCellStyle.Format = "N"
            dgvRRDetails.Columns("RRAmount").DefaultCellStyle.Format = "N"
            dgvRRDetails.Columns("PO Amount").DefaultCellStyle.Format = "N"
            dgvRRDetails.Columns("QuantityReceived").DefaultCellStyle.Format = "#,###"
            'dgvRRDetails.Columns("PO Balance").DefaultCellStyle.Format = "#,###"

            dgvRRDetails.Columns("ProdExpDate").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            dgvRRDetails.Columns("SellingPrice").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            dgvRRDetails.Columns("Unit Cost").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            dgvRRDetails.Columns("RRAmount").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            dgvRRDetails.Columns("QuantityReceived").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            'dgvRRDetails.Columns("PO Balance").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            dgvRRDetails.Columns("PO Amount").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

        End With
    End Sub

    Private Sub LoadProdExpDateQty(sender As Object, e As EventArgs) Handles dgvRRDetails.CellMouseClick
        txtRRQuantity.Text = dgvRRDetails.Item(9, dgvRRDetails.CurrentRow.Index).Value
        dateExpiry.Value = Convert.ToDateTime(dgvRRDetails.Item(4, dgvRRDetails.CurrentRow.Index).Value)
        txtSellPrice.Text = dgvRRDetails.Item(5, dgvRRDetails.CurrentRow.Index).Value
        txtUnitCost.Text = dgvRRDetails.Item(8, dgvRRDetails.CurrentRow.Index).Value
    End Sub

    'add  delivered items
    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        'Dim PObal As Integer = s.GetDetailStr("POCloseVoid", "balance", )
        Try
            Dim dt As Date = Date.Now
            delvNo = c.getData(txtRRNo)
            _index = dgvRRDetails.CurrentRow.Index
            PODeID = dgvRRDetails.Item(2, dgvRRDetails.CurrentRow.Index).Value
            expDate = c.getData(dateExpiry)
            ordQty = dgvRRDetails.Item(6, dgvRRDetails.CurrentRow.Index).Value
            qtyRcvd = c.getData(txtRRQuantity) '*6
            sellPrice = c.getData(txtSellPrice)
            price = c.getData(txtUnitCost)
            'check values proceed if OK
            If c.CheckProdExpDT(expDate) = True Then 'expdate
                qtyRcvd = Nothing
                expDate = Nothing
                Exit Sub
            ElseIf IsNumeric(qtyRcvd) = False Then 'chk qty
                MsgBox("Invalid Quantity!", vbOKOnly, caption)
                txtRRQuantity.Select()
                Exit Sub
            ElseIf Convert.ToInt32(qtyRcvd) > Convert.ToInt32(ordQty) Then 'qty left to be delv'd
                MsgBox("Quantity Recieved Cannot Be More than Ordered Quantity!", vbOKOnly, caption)
                txtRRQuantity.Select()
                qtyRcvd = Nothing
                Exit Sub
            ElseIf String.IsNullOrEmpty(delvNo) = True Or String.IsNullOrEmpty(expDate) = True Or String.IsNullOrEmpty(qtyRcvd) = True Then 'missing
                MsgBox("Please Fill In All Fields", vbOKOnly, caption)
                Exit Sub
            ElseIf c.checkProdExRR(dgvRRDetails, prodName) = True Then 'dupes
                MsgBox("Item already exists!", vbOKOnly, caption)
                prodName = Nothing
                Exit Sub
            ElseIf CInt(qtyRcvd) > CInt(dgvRRDetails.Item(6, dgvRRDetails.CurrentRow.Index).Value) Then 'qty left
                MsgBox("Quantity Recieved Cannot Be More than Ordered Quantity!", vbOKOnly, caption)
                txtRRQuantity.Select()
                Exit Sub
            Else
                amt = CDbl(qtyRcvd) * dgvRRDetails.Item(8, dgvRRDetails.CurrentRow.Index).Value
                toPay = dgvRRDetails.Item(10, dgvRRDetails.CurrentRow.Index).Value
                dgvUpDetails.Enabled = True
                prodName = s.getProdName(PODeID)
                price = c.getData(txtUnitCost)
                RRDiD = dgvRRDetails.Item(0, dgvRRDetails.CurrentRow.Index).Value
                RR.addRRDetails(2, delvNo, PODeID, prodName, expDate, sellPrice, price, amt, ordQty, qtyRcvd, toPay, RRDiD)
                s.loadDTGN(dgvUpDetails, "tempDetailsview", "", "", 1)
                btnRemove.Enabled = True
                btnRRSave.Enabled = True
                cmbSupplier.Enabled = False
                panelDate.Enabled = False
            End If
            '3 for podetailsID
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub tago(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles dgvUpDetails.DataBindingComplete
        With dgvUpDetails
            .Columns("ID").Visible = False
            .Columns("RRID").Visible = False
            .Columns("PODetailsID").Visible = False
            .Columns("upWhere").Visible = False
            '.Columns("upWhere").Visible = False
            dgvUpDetails.Columns(4).DefaultCellStyle.Format = "MM/dd/yyyy"

        End With
    End Sub
    'save RRDets
    Private Sub BtnRRSave_Click(sender As Object, e As EventArgs) Handles btnRRSave.Click
        'new update query
        Dim newbal As Integer
        Try
            dgvUpDetails.Rows(0).Selected = True
            For index As Integer = 0 To c.countDtgItem(dgvUpDetails)
                _place = dgvUpDetails.Item(11, index).Value
                PODeID = dgvUpDetails.Item(2, index).Value
                expDate = Format(dgvUpDetails.Item(4, index).Value, "yyyy-MM-dd")
                amt = dgvUpDetails.Item(7, index).Value
                ordQty = dgvUpDetails.Item(9, index).Value
                qtyRcvd = dgvUpDetails.Item(8, index).Value
                toPay = dgvUpDetails.Item(10, index).Value
                price = dgvUpDetails.Item(6, index).Value
                sellPrice = dgvUpDetails.Item(5, index).Value
                newbal = ordQty - qtyRcvd
                RR.updateRR(_place, expDate, amt, qtyRcvd, sellPrice)
                s.updateBal(PODeID, newbal, 1)
                s.RunQuery("update PODetails set unitPrice = '" & price & "' where ID = '" & PODeID & "'")
            Next

            c.clrData(grpRR)
            c.clrData(grpPODetails)
            c.clrDS(dgvUpDetails)
            c.clrDS(dgvRRDetails)
            c.clrDS(dgvRRList)
            s.clearTemp("tempDetails")
            grpPODetails.Enabled = False
            grpRR.Enabled = False
            cmbSupplier.Enabled = True
            cmbSupplier.SelectedIndex = -1
            MsgBox("Saved!", vbOKOnly, caption)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub FormRefresh(sender As Object, e As EventArgs) Handles btnRefresh.Click
        s.RunQuery("delete from tempDetails")
        cmbSupplier.SelectedIndex = -1
        cmbSupplier.Text = ""
        cmbSupplier.Enabled = True
        chkTimePeriod.Checked = False
        panelDate.Enabled = False
        c.clrDS(dgvRRList)
        c.clrDS(dgvRRDetails)
        c.clrDS(dgvUpDetails)
        s.clearTemp("tempDetails")
        c.clrData(dgvUpDetails)
        c.clrData(dgvRRDetails)
        cmbReceivedBy.Text = ""
        cmbReceivedBy.SelectedIndex = -1
        txtRRQuantity.Text = ""
        grpPODetails.Enabled = False
        grpRR.Enabled = False
        prodName = ""
    End Sub
    Private Sub RemoveItem(sender As Object, e As EventArgs) Handles btnRemove.Click
        If dgvUpDetails.SelectedRows.Count = 0 Then
            MsgBox("No item selected!", vbOKOnly, caption)
            Exit Sub
        Else
            Try
                delvNo = c.getData(txtRRNo)
                point = dgvUpDetails.CurrentRow.Index
                id = dgvUpDetails.Item(0, point).Value
                Dim message As String = "Are you sure you want to remove item?"
                Dim icons As Integer = MessageBoxIcon.Question
                Dim buttons As Integer = MessageBoxButtons.YesNo
                Dim result As DialogResult
                result = MessageBox.Show(Me, message, caption, buttons, icons)
                If result = DialogResult.Yes Then
                    s.delete(dgvUpDetails, "tempDetails", id)
                    s.loadDTGN(dgvUpDetails, "tempDetailsView", "", "RRID = " + delvNo, 3)
                    'point = Nothing
                    'id = Nothing
                End If
            Catch ex As Exception
                Dim msg1 As String = ex.GetType.ToString
                If msg1 = "System.NullReferenceException" Then
                    MsgBox("No Item Selected", vbOKOnly, caption)
                End If
            End Try
        End If
    End Sub

    Private Sub clearField(sender As Object, e As EventArgs) Handles dgvRRList.SelectionChanged
        c.clrData(grpPODetails)
    End Sub
End Class