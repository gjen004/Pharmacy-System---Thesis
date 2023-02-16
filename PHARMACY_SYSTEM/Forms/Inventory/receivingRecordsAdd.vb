Public Class receivingRecordsAdd
    Dim s As New cSQL
    Dim c As New cControl
    Dim RR As New ivRR
    Dim PO As New ivPO
    Dim suppName As String
    Private Sub frmload(sender As Object, e As EventArgs) Handles MyBase.Load
        populate()
        panelDate.Enabled = True
        grpPODetails.Enabled = False
        grpRR.Enabled = False
        'txtRRNo.Text = s.GetCount("RR")
        panelDate.Enabled = False
        c.formatDTP(dateFrom, dateTo)
        c.formatDTP(dateExpiry, dateRR)
        s.clearTemp("tempDetails")
    End Sub

    Private Sub disregard(sender As Object, e As EventArgs) Handles MyBase.Closing
        Dim count As Integer
        If grpPODetails.Enabled = False Then
            RRID = Nothing
            rcvr = Nothing
            DTDlvr = Nothing
        ElseIf grpRR.Enabled = True And innerRR.Enabled = False Then
            count = dgvRRDetails.Rows.Count
            If count = 0 Then
                MsgBox("There is no product selected, RR will be disregarded ...", vbOKOnly, caption)
                s.RunQuery("delete from RR where RRNo = '" & delvNo & "'")
                s.RunQuery("delete from tempDetails")
            ElseIf count > 0 Then
                MsgBox("There are products selected, RR will be disregarded ...", vbOKOnly, caption)
                s.RunQuery("delete from RR where RRNo = '" & delvNo & "'")
                s.RunQuery("delete from tempDetails")
            End If
        End If
    End Sub

    Private Sub populate()
        s.loadCBXN(cmbSupplier, "supplier", "ID", "suppName", "where deletedBy is NULL")
        s.loadCBXN(cmbReceivedBy, "employeeview", "ID", "EmployeeName", "where [EmployeeName] not like('%admin%')")
    End Sub

    Private Sub ClearPOList(sender As Object, e As EventArgs) Handles dateFrom.TextChanged, dateTo.TextChanged
        c.clrDS(dgPOList)
        c.clrDS(dgvPODetails)
    End Sub

    'PO according to values
    Private Sub loadRR(sender As Object, e As EventArgs) Handles btnCheck.Click
        c.setPORRList(dgPOList, chkTimePeriod, dateFrom, dateTo, cmbSupplier, 2, grpRR, innerRR, btnRemove)
        'dgPOList.Columns(1).DefaultCellStyle.Format = "MM/dd/yyyy"

        'dgPOList.Columns("PO No.").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        'dgPOList.Columns("PO No.").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        'dgPOList.Columns("Date").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        'dgPOList.Columns("Date").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        'dgPOList.Columns("Status").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        'dgPOList.Columns("Status").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
    End Sub

    Private Sub tago1(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles dgPOList.DataBindingComplete
        With dgvPODetails
            dgPOList.Columns(1).DefaultCellStyle.Format = "MM/dd/yyyy"

            dgPOList.Columns("PO No.").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            dgPOList.Columns("PO No.").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            dgPOList.Columns("Date").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            dgPOList.Columns("Date").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            dgPOList.Columns("Status").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            dgPOList.Columns("Status").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        End With
    End Sub

    Private Sub EnablePanelDate(sender As Object, e As EventArgs) Handles chkTimePeriod.CheckedChanged
        If chkTimePeriod.CheckState = CheckState.Checked Then
            panelDate.Enabled = True
        ElseIf chkTimePeriod.CheckState = CheckState.Unchecked Then
            panelDate.Enabled = False
        End If
    End Sub

    'load data to PODetails Grid
    Private Sub loadDetails(sender As Object, e As EventArgs) Handles dgPOList.CellMouseClick
        Try
            _index = dgPOList.CurrentRow.Index
            whereIs = dgPOList.Item(0, _index).Value
            s.loadDTGN(dgvPODetails, "PODetShowProd", "ID, PONum as 'PO No.', Product, Quantity, unitPrice as 'Unit Cost', balance as 'Balance'", "PONum = " + whereIs + " and balance > 0", 4)
            'grpPODetails.Enabled = True
            grpRR.Enabled = True
            btnRemove.Enabled = False
            btnRRSave.Enabled = False

            dgvPODetails.Columns("Product").Width = 450
            dgvPODetails.Columns("Unit Cost").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            dgvPODetails.Columns("Unit Cost").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            dgvPODetails.Columns("Balance").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            dgvPODetails.Columns("Balance").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub tago(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles dgvPODetails.DataBindingComplete
        With dgvPODetails
            .Columns("ID").Visible = False
            .Columns("PO No.").Visible = False
            .Columns("Quantity").Visible = False
            dgvPODetails.Columns("Unit Cost").DefaultCellStyle.Format = "N"
            dgvPODetails.Columns("Balance").DefaultCellStyle.Format = "#,###"
            dgvPODetails.ClearSelection()
        End With
    End Sub

    'create RR
    Private Sub BtnCreate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Try
            supp = c.getData(cmbSupplier)
            delvNo = c.getData(txtRRNo)
            rcvr = c.getData(cmbReceivedBy)
            DTDlvr = c.getData(dateRR)
            remarks = c.getData(txtRRRemarks)
            If String.IsNullOrEmpty(DTDlvr) = True Or String.IsNullOrEmpty(delvNo) = True Or supp < 1 Then
                MsgBox("Please Fill In All Fields", vbOKOnly, caption)
                innerRR.Select()
                Exit Sub
            ElseIf rcvr = 0 Or rcvr < 1 Then
                MsgBox("Employee Does Not Exists", vbOKOnly, caption)
                cmbReceivedBy.Select()
                Exit Sub
            ElseIf IsNumeric(delvNo) = False Then
                MsgBox("Invalid RR Number", vbOKOnly, caption)
                txtRRNo.Select()
                Exit Sub
            Else
                If s.checkVal("RR", "RRNo", Convert.ToInt32(delvNo)) = True Then
                    MsgBox("RR Number Already Exists!", vbOKOnly, caption)
                    txtRRNo.Select()
                Else
                    RR.createRR(delvNo, supp, DTDlvr, rcvr, remarks)
                    innerRR.Enabled = False
                    dateExpiry.Enabled = True
                    txtRRQuantity.Enabled = True
                    btnAdd.Enabled = True
                    btnCheck.Enabled = False
                    grpPODetails.Enabled = True
                End If

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    'add  delivered items
    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Try
            If dgvPODetails.SelectedRows.Count = 0 Then
                MsgBox("No Items Selected", vbOKOnly, caption)
                Exit Sub
            ElseIf chkFree.Checked = False Then
                Dim dt As Date = Date.Now
                delvNo = c.getData(txtRRNo)
                _index = dgvPODetails.CurrentRow.Index
                PODeID = dgvPODetails.Item(0, dgvPODetails.CurrentRow.Index).Value
                ordQty = dgvPODetails.Item(5, dgvPODetails.CurrentRow.Index).Value
                prodName = s.getProdName(PODeID)


                'check values proceed if OK
                If dateExpiry.Value <= Date.Now() Then
                    MsgBox("Expiration date must be greater than the date today!", vbOKOnly, caption)
                    dateExpiry.Select()
                    Exit Sub
                ElseIf txtRRQuantity.Text = "" Then
                    MsgBox("Please enter Quantity!", vbOKOnly, caption)
                    txtRRQuantity.Select()
                    Exit Sub
                ElseIf IsNumeric(txtRRQuantity.Text) = False Then
                    MsgBox("Quantity must be numeric!", vbOKOnly, caption)
                    txtRRQuantity.Select()
                    Exit Sub
                ElseIf txtRRQuantity.Text < 0 Then
                    MsgBox("Quantity must be greater than 0!", vbOKOnly, caption)
                    txtRRQuantity.Select()
                    Exit Sub
                ElseIf txtRRQuantity.Text > ordQty Then
                    MsgBox("Quantity Received Cannot be more than Ordered Quantity!", vbOKOnly, caption)
                    txtRRQuantity.Select()
                    Exit Sub
                ElseIf txtUnitCost.Text = "" Then
                    MsgBox("Please enter Unit Cost!", vbOKOnly, caption)
                    txtUnitCost.Select()
                ElseIf IsNumeric(txtUnitCost.Text) = False Then
                    MsgBox("Unit Cost must be numeric!", vbOKOnly, caption)
                    txtUnitCost.Select()
                    Exit Sub
                ElseIf txtUnitCost.Text <= 0 Then                                  'additional elseif 01/21/2020
                    MsgBox("Price must be greater than 0!", vbOKOnly, caption)
                    txtUnitCost.Select()
                    Exit Sub
                ElseIf txtSellPrice.Text = "" Then
                    MsgBox("Please enter Selling Price!", vbOKOnly, caption)
                    txtSellPrice.Select()
                    Exit Sub
                ElseIf IsNumeric(txtSellPrice.Text) = False Then
                    MsgBox("Selling Price must be numeric!", vbOKOnly, caption)
                    txtSellPrice.Select()
                    Exit Sub
                ElseIf c.checkProdExRR(dgvRRDetails, prodName) = True Then 'dupes
                    MsgBox("Item already exists!", vbOKOnly, caption)
                    prodName = Nothing
                    Exit Sub
                ElseIf CDbl(c.getData(txtUnitCost)) > CDbl(c.getData(txtSellPrice)) Then
                    MsgBox("Unit Cost should not be greater than Selling Price!", vbOKOnly, caption)
                    txtSellPrice.Select()
                    Exit Sub
                Else
                    expDate = c.getData(dateExpiry)
                    qtyRcvd = c.getData(txtRRQuantity)
                    prodName = s.getProdName(PODeID)
                    sellPrice = c.getData(txtSellPrice)
                    price = c.getData(txtUnitCost)

                    Convert.ToInt32(qtyRcvd)
                    Convert.ToDouble(amt)
                    Dim amtRR As Double
                    amtRR = qtyRcvd * Convert.ToDouble(price) 'rramt
                    toPay = ordQty * Convert.ToDouble(price) 'total amount
                    dgvRRDetails.Enabled = True

                    RR.addRRDetails(1, delvNo, PODeID, prodName, expDate, sellPrice, price, amtRR, ordQty, qtyRcvd, toPay, 0)
                    s.loadDTGN(dgvRRDetails, "tempDetailsview", "", "RRID = " + delvNo, 3)
                    btnRemove.Enabled = True
                    btnRRSave.Enabled = True
                    txtRRQuantity.Text = ""
                    dateExpiry.Value = dt
                    chkFree.Checked = False
                    dgvPODetails.ClearSelection()
                    prodName = Nothing
                    txtUnitCost.Text = ""
                    txtSellPrice.Text = ""
                    Exit Sub
                End If
            ElseIf chkFree.Checked = True Then
                Dim dt As Date = Date.Now
                delvNo = c.getData(txtRRNo)
                _index = dgvPODetails.CurrentRow.Index
                PODeID = dgvPODetails.Item(0, dgvPODetails.CurrentRow.Index).Value
                ordQty = dgvPODetails.Item(5, dgvPODetails.CurrentRow.Index).Value
                'If String.IsNullOrEmpty(delvNo) = True Or String.IsNullOrEmpty(expDate) = True Or String.IsNullOrEmpty(qtyRcvd) = True Or String.IsNullOrEmpty(sellPrice) = True Then 'missing
                '    MsgBox("Please Fill In All Fields", vbOKOnly, caption)
                '    Exit Sub
                'ElseIf c.CheckProdExpDT(expDate) = True Then 'expdate
                '    qtyRcvd = Nothing
                '    expDate = Nothing
                '    Exit Sub
                'ElseIf IsNumeric(qtyRcvd) = False Then 'chk qty
                '    MsgBox("Invalid Quantity!", vbOKOnly, caption)
                '    txtRRQuantity.Select()
                '    Exit Sub
                'ElseIf Convert.ToInt32(qtyRcvd) <= 0 Then
                '    MsgBox("Quantity must be greater than 0!", vbOKOnly, caption)
                '    txtRRQuantity.Select()
                '    Exit Sub
                'ElseIf IsNumeric(sellPrice) = False Then
                '    MsgBox("Selling Price must be numeric!", vbOKOnly, caption)
                '    txtSellPrice.Select()
                '    Exit Sub

                'ElseIf c.checkProdExRR(dgvRRDetails, prodName) = False Then 'dupes
                '    MsgBox("You cannot add a free item unless a non-free item is added!", vbOKOnly, caption)
                '    prodName = Nothing
                '    Exit Sub
                If dateExpiry.Value <= Date.Now() Then
                    MsgBox("Expiration date must be greater than the date today!", vbOKOnly, caption)
                    dateExpiry.Select()
                    Exit Sub
                ElseIf txtRRQuantity.Text = "" Then
                    MsgBox("Please enter Quantity!", vbOKOnly, caption)
                    txtRRQuantity.Select()
                    Exit Sub
                ElseIf IsNumeric(txtRRQuantity.Text) = False Then
                    MsgBox("Quantity must be numeric!", vbOKOnly, caption)
                    txtRRQuantity.Select()
                    Exit Sub
                ElseIf txtRRQuantity.Text < 0 Then
                    MsgBox("Quantity must be greater than 0!", vbOKOnly, caption)
                    txtRRQuantity.Select()
                    Exit Sub
                    'ElseIf txtUnitCost.Text = "" Then
                    '    MsgBox("Please enter Unit Cost!", vbOKOnly, caption)
                    '    txtUnitCost.Select()
                    'ElseIf IsNumeric(txtUnitCost.Text) = False Then
                    '    MsgBox("Invalid Price", vbOKOnly, caption)
                    '    txtUnitCost.Select()
                    '    Exit Sub
                    'ElseIf txtUnitCost.Text <= 0 Then                                  'additional elseif 01/21/2020
                    '    MsgBox("Price must be greater than 0!", vbOKOnly, caption)
                    '    txtUnitCost.Select()
                    '    Exit Sub
                ElseIf txtSellPrice.Text = "" Then
                    MsgBox("Please enter Selling Price!", vbOKOnly, caption)
                    txtSellPrice.Select()
                    Exit Sub
                ElseIf IsNumeric(txtSellPrice.Text) = False Then
                    MsgBox("Selling Price must be numeric!", vbOKOnly, caption)
                    Exit Sub
                ElseIf s.checkVal("tempDetailsView", "PODetailsID", PODeID) = False Then 'dupes
                    MsgBox("You cannot add free items unless PO items are added!", vbOKOnly, caption)
                    prodName = Nothing
                    Exit Sub
                Else
                    expDate = c.getData(dateExpiry)
                    qtyRcvd = c.getData(txtRRQuantity)
                    prodName = s.getProdName(PODeID)
                    sellPrice = c.getData(txtSellPrice)
                    price = c.getData(txtUnitCost)

                    Convert.ToInt32(qtyRcvd)
                    Convert.ToDouble(amt)
                    Dim amtRR As Double
                    amtRR = 0
                    toPay = ordQty * Convert.ToDouble(price) 'total amount
                    dgvRRDetails.Enabled = True

                    RR.addRRDetails(1, delvNo, PODeID, prodName, expDate, sellPrice, price, amtRR, ordQty, qtyRcvd, toPay, 0)
                    s.loadDTGN(dgvRRDetails, "tempDetailsview", "", "RRID = " + delvNo, 3)
                    btnRemove.Enabled = True
                    btnRRSave.Enabled = True
                    txtRRQuantity.Text = ""
                    dateExpiry.Value = dt
                    chkFree.Checked = False
                    dgvPODetails.ClearSelection()
                    txtUnitCost.Text = ""
                    txtSellPrice.Text = ""
                    Exit Sub
                End If
            End If

        Catch ex As Exception
            Dim msg1 As String = ex.GetType.ToString
            If msg1 = "System.NullReferenceException" Then
                MsgBox("No Item Selected", vbOKOnly, caption)
            End If
        End Try
    End Sub

    Private Sub freeQty(sender As Object, e As EventArgs) Handles chkFree.CheckStateChanged
        If chkFree.CheckState = CheckState.Checked Then
            txtUnitCost.Enabled = False
        Else
            txtUnitCost.Enabled = True
        End If
    End Sub

    Private Sub hideID(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles dgvRRDetails.DataBindingComplete
        With dgvRRDetails
            .Columns("ID").Visible = False
            .Columns("RRID").Visible = False
            .Columns("PODetailsID").Visible = False
            .Columns("upWhere").Visible = False
            dgvRRDetails.Columns(4).DefaultCellStyle.Format = "MM/dd/yyyy"

            dgvRRDetails.Columns("Unit Cost").DefaultCellStyle.Format = "N"
            dgvRRDetails.Columns("SellingPrice").DefaultCellStyle.Format = "N"
            dgvRRDetails.Columns("RR Amount").DefaultCellStyle.Format = "N"
            dgvRRDetails.Columns("PO Amount").DefaultCellStyle.Format = "N"
            dgvRRDetails.Columns("RR Quantity").DefaultCellStyle.Format = "#,###"
            dgvRRDetails.Columns("PO Balance").DefaultCellStyle.Format = "#,###"

            dgvRRDetails.Columns("ProdExpDate").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            dgvRRDetails.Columns("SellingPrice").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            dgvRRDetails.Columns("Unit Cost").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            dgvRRDetails.Columns("RR Amount").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            dgvRRDetails.Columns("RR Quantity").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            dgvRRDetails.Columns("PO Balance").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            dgvRRDetails.Columns("PO Amount").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        End With
    End Sub

    'save RRDets
    Private Sub BtnRRSave_Click(sender As Object, e As EventArgs) Handles btnRRSave.Click

        Try
            Dim totalRR As Double = 0
            Dim unitPrice As Double
            Dim poNum As Integer
            delvNo = c.getData(txtRRNo)
            poNum = dgvPODetails.Item(1, _index).Value
            dgvRRDetails.Rows(0).Selected = True
            For index As Integer = 0 To c.countDtgItem(dgvRRDetails)

                PODeID = dgvRRDetails.Item(2, index).Value
                expDate = Format(dgvRRDetails.Item(4, index).Value, "yyyy-MM-dd")
                sellPrice = CDbl(dgvRRDetails.Item(5, index).Value)
                amt = CDbl(dgvRRDetails.Item(7, index).Value)
                ordQty = dgvRRDetails.Item(9, index).Value
                qtyRcvd = dgvRRDetails.Item(8, index).Value
                toPay = CDbl(dgvRRDetails.Item(10, index).Value)

                If amt = CDbl(0) Then
                    'qtyRcvd = 0
                    RR.saveRR(delvNo, PODeID, expDate, sellPrice, CDbl(amt), ordQty, qtyRcvd, toPay)
                Else
                    s.computeBal(PODeID, qtyRcvd)
                    'Else
                    '    qtyRcvd = dgvRRDetails.Item(8, index).Value
                    '    's.computeBal(PODeID, qtyRcvd)
                    unitPrice = CDbl(amt / CInt(qtyRcvd))
                    totalRR += amt
                    s.RunQuery("update PODetails set unitPrice = '" & unitPrice & "' where ID = '" & PODeID & "' and PONum = '" & poNum & "'")
                    RR.saveRR(delvNo, PODeID, expDate, sellPrice, CDbl(amt), ordQty, qtyRcvd, toPay)
                End If
                'RR.saveRR(delvNo, PODeID, expDate, sellPrice, CDbl(amt), ordQty, qtyRcvd, toPay)
                's.computeBal(PODeID, qtyRcvd)
                'unitPrice = CDbl(amt / CInt(qtyRcvd))
                'totalRR += amt
                's.RunQuery("update PODetails set unitPrice = '" & unitPrice & "' where ID = '" & PODeID & "' and PONum = '" & poNum & "'")
                PODeID = Nothing
                expDate = Nothing
                sellPrice = Nothing
                amt = Nothing
                ordQty = Nothing
                qtyRcvd = Nothing
                toPay = Nothing
                price = Nothing
            Next

            _index = dgPOList.CurrentRow.Index
            whereIs = dgPOList.Item(0, _index).Value

            PO.CountToClose(whereIs)
            s.RunQuery("Update RR set totalRR =  '" & totalRR & "', Balance = '" & totalRR & "' where RRNo =  '" & delvNo & "'")
            c.clrData(grpRR)
            c.clrData(grpPODetails)
            c.clrData(grpRR)
            txtRRNo.Text = ""
            cmbReceivedBy.Text = ""
            cmbReceivedBy.SelectedIndex = -1
            txtRRRemarks.Text = ""
            c.clrDS(dgvPODetails)
            c.clrDS(dgvRRDetails)
            c.clrDS(dgPOList)
            s.clearTemp("tempDetails")
            PODeID = Nothing
            expDate = Nothing
            amt = Nothing
            ordQty = Nothing
            qtyRcvd = Nothing
            toPay = Nothing
            grpPODetails.Enabled = False
            grpRR.Enabled = False
            btnCheck.Enabled = True
            cmbSupplier.Text = ""
            cmbSupplier.SelectedIndex = -1
            MsgBox("Saved!", vbOKOnly, caption)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub BtnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        c.clrDS(dgvPODetails)
        c.clrDS(dgvRRDetails)
        c.clrDS(dgPOList)
        delvNo = c.getData(txtRRNo)
        s.RunQuery("delete from RR where RRNo = '" & delvNo & "'")
        s.RunQuery("delete from RRDetails where RRID = '" & delvNo & "'")
        delvNo = Nothing
        txtRRQuantity.Text = ""
        txtRRRemarks.Text = ""
        dateExpiry.Value = Date.Now
        cmbReceivedBy.SelectedIndex = -1
        cmbSupplier.Text = ""
        cmbSupplier.SelectedIndex = -1
        chkTimePeriod.Checked = False
        txtRRNo.Text = ""
        grpPODetails.Enabled = False
        grpRR.Enabled = False
        panelDate.Enabled = False
        btnRefresh.Enabled = True
        btnCheck.Enabled = True
    End Sub

    Private Sub RemoveItem(sender As Object, e As EventArgs) Handles btnRemove.Click
        Try
            If dgvRRDetails.SelectedRows.Count = 0 Then
                MsgBox("No Item Selected", vbOKOnly, caption)
                Exit Sub
            Else
                delvNo = c.getData(txtRRNo)
                point = dgvRRDetails.CurrentRow.Index
                id = dgvRRDetails.Item(0, point).Value
                Dim message As String = "Are you sure you want to remove item?"
                Dim icons As Integer = MessageBoxIcon.Question
                Dim buttons As Integer = MessageBoxButtons.YesNo
                Dim result As DialogResult
                result = MessageBox.Show(Me, message, caption, buttons, icons)
                If result = DialogResult.Yes Then
                    s.delete(dgvRRDetails, "tempDetails", id)
                    s.loadDTGN(dgvRRDetails, "tempDetails", "", "RRID = " + delvNo, 3)
                    point = Nothing
                    id = Nothing
                End If
            End If
        Catch ex As Exception
            Dim msg1 As String = ex.GetType.ToString
            If msg1 = "System.NullReferenceException" Then
                MsgBox("No Item Selected!", vbOKOnly, caption)
            End If
        End Try
    End Sub

    Private Sub freeChecked(sender As Object, e As EventArgs) Handles chkFree.CheckedChanged
        If chkFree.Checked = True Then
            txtUnitCost.Enabled = False
            txtUnitCost.Text = 0
            txtUnitCost.Text = Format(Val(txtUnitCost.Text), "0.00")
        End If
    End Sub
End Class
