Public Class salesReturn

    Dim s As New cSQL
    Dim c As New cControl
    Private Sub salesReturn_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'dtpSalesDate.Format = DateTimePickerFormat.Custom
        'dtpSalesDate.CustomFormat = "MM/dd/yyyy"
        'dgvSR.Columns(5).DefaultCellStyle.Format = "MM/dd/yyyy"
        c.formatDTPN(dateTrans)
        c.formatDTP(dateFrom, dateTo)
        s.loadCBXN(cmbReason, "reasonview", "id", "Reasons", "where Usage = 'Sales Return'")
        panelDate.Enabled = False
        GroupBox1.Enabled = False
    End Sub

    Private Sub cellklik(sender As Object, e As EventArgs) Handles dgvSales.CellClick
        GroupBox1.Enabled = True

    End Sub

    Private Sub BtnCheck_Click(sender As Object, e As EventArgs) Handles btnCheck.Click
        If chkDatePeriod.Checked = True Then
            panelDate.Enabled = True
            startAt = c.getData(dateFrom)
            endsAt = c.getData(dateTo)
            'If String.IsNullOrEmpty(suppName) = True Then
            '    MsgBox("Please Select a Supplier!")
            '    Exit Sub
            'ElseIf s.checkValStr("cmbSupp", "suppname", suppName) = False Then
            '    MsgBox("Supplier Does not Exist!")
            '    suppName = Nothing
            '    Exit Sub
            If String.IsNullOrEmpty(startAt) = True And String.IsNullOrEmpty(endsAt) = True Then
                MsgBox("Please Select Date Range!")
                Exit Sub
            ElseIf String.IsNullOrEmpty(startAt) = True Or String.IsNullOrEmpty(endsAt) = True Then
                MsgBox("Please Select Date Range!")
                Exit Sub
                'ElseIf String.IsNullOrEmpty(startAt) = True Or String.IsNullOrEmpty(endsAt) = True Or String.IsNullOrEmpty(suppName) = True Then
                '    MsgBox("Please Fill In All Fields!")
                '    Exit Sub
            Else
                If c.getRange(startAt, endsAt) = True Then
                    'MsgBox("Invalid Date Selection!")
                    Exit Sub
                Else
                    s.loadDTGN(dgvSales, "sales", "salesNo as 'Sales No.', savedDT as 'DateTime', Amount", "savedDT >= '" & startAt & "' and savedDT <= '" & endsAt & "'", 4)
                End If
            End If
        ElseIf chkDatePeriod.Checked = False Then
            s.loadDTGN(dgvSales, "sales", "salesNo as 'Sales No.', savedDT as 'DateTime', Amount", "", 2)
        End If
    End Sub

    Private Sub salesClick(sender As Object, e As EventArgs) Handles dgvSales.CellClick
        Dim index As Integer
        index = dgvSales.CurrentRow.Index
        num = dgvSales.Item(0, index).Value
        s.loadDTGX(dgvSR, "salesView", "ID, salesNo as 'Sales No.', Product, Quantity, Promo, FreeQuantity, Discount, Amount, savedBy as 'Saved By', stockID", num)
        txtTransNo.Text = dgvSales.Item(0, index).Value
        dateTrans.Value = dgvSales.Item(1, index).Value
    End Sub

    Private Sub dgvSalesBinding(sender As Object, e As EventArgs) Handles dgvSales.DataBindingComplete
        With dgvSales
            .Columns("Amount").Visible = False
            dgvSales.Columns(1).DefaultCellStyle.Format = "MM/dd/yyyy HH:mm"
        End With
    End Sub

    Private Sub dateChanged(sender As Object, e As EventArgs) Handles dateFrom.TextChanged, dateTo.TextChanged
        c.clrDS(dgvSales)
        c.clrDS(dgvSR)
    End Sub

    Private Sub HideFields(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles dgvSR.DataBindingComplete
        With dgvSR
            .Columns("ID").Visible = False
            .Columns("stockID").Visible = False
            .Columns("Saved By").Visible = False
            dgvSR.ClearSelection()
        End With
    End Sub

    Private Sub dateChecked(sender As Object, e As EventArgs) Handles chkDatePeriod.CheckedChanged
        If chkDatePeriod.Checked = True Then
            panelDate.Enabled = True
        Else
            panelDate.Enabled = False
        End If
        c.clrDS(dgvSales)
        c.clrDS(dgvSR)
    End Sub

    Private Sub BtnSRAdd_Click(sender As Object, e As EventArgs) Handles btnSRAdd.Click
        If dgvSR.SelectedRows.Count = 0 Then
            MsgBox("No Selected Item", vbOKOnly, caption)
            Exit Sub
        Else
            Dim retProd As String
            Dim retQty, retfrQty, index As Integer
            index = dgvSR.CurrentRow.Index
            retProd = dgvSR.Item(2, index).Value
            retQty = dgvSR.Item(3, index).Value
            retfrQty = dgvSR.Item(5, index).Value
            returnNo = c.getData(txtSRNo)
            transNo = c.getData(txtTransNo)
            transDate = c.getData(dateTrans)

            retReas = c.getData(cmbReason)
            If String.IsNullOrEmpty(returnNo) = True Or String.IsNullOrEmpty(transNo) = True Or String.IsNullOrEmpty(transDate) = True Or String.IsNullOrEmpty(txtSRQuantity.Text) = True Or String.IsNullOrEmpty(txtSRfreeQty.Text) = True Or String.IsNullOrEmpty(txtSRAmount.Text) = True Then
                MsgBox("Please Fill in All Fields", vbOKOnly, "Pharmacy System")
                Exit Sub
            ElseIf IsNumeric(returnNo) = False Then
                MsgBox("Return No. must be numeric!", vbOKOnly, caption)
                txtSRNo.Select()
                Exit Sub
            ElseIf s.checkVal("salesReturn", "returnNo", Convert.ToInt32(returnNo)) = True Then
                MsgBox("Return No. Already Exists!", vbOKOnly, caption)
                txtSRNo.Select()
                Exit Sub
            ElseIf IsNumeric(txtSRQuantity.Text) = False Then
                MsgBox("Return Quantity must be numeric!", vbOKOnly, caption)
                txtSRQuantity.Select()
                Exit Sub
            ElseIf txtSRQuantity.Text > retQty Or txtSRQuantity.Text < retQty Then 'over return
                MsgBox("Return quantity must be equal bought quantity!", vbOKOnly, caption)
                txtSRQuantity.Select()
                Exit Sub
            ElseIf IsNumeric(txtSRfreeQty.Text) = False Then
                MsgBox("Free Quantity must be numeric!", vbOKOnly, caption)
                txtSRfreeQty.Select()
                Exit Sub
            ElseIf txtSRfreeQty.Text < retfrQty Or txtSRfreeQty.Text > retfrQty Then
                MsgBox("Return Free Quantity must be equal to Transaction Free Quantity!", vbOKOnly, caption)
                txtSRfreeQty.Select()
                Exit Sub
            ElseIf IsNumeric(txtSRAmount.Text) = False Then
                MsgBox("Amount must be numeric!", vbOKOnly, caption)
                txtSRAmount.Select()
                Exit Sub
            ElseIf retReas = 0 Then 'no reason exist
                MsgBox("Reason does not exist!", vbOKOnly, caption)
                cmbReason.Select()
                Exit Sub
            ElseIf retReas = -1 Then 'no reason selected
                MsgBox("No reason selected!", vbOKOnly, caption)
                cmbReason.Select()
                Exit Sub
            Else
                qtyRet = c.getData(txtSRQuantity)
                frQtyRet = c.getData(txtSRfreeQty)
                RRDiD = dgvSR.Item(9, dgvSR.CurrentRow.Index).Value
                Dim stx As Integer = s.GetDetail("ShowProductQuantity", "Quantity", "ID", RRDiD)
                Dim updStx As Integer = stx + CInt(qtyRet + frQtyRet)
                empName = s.GetDetailStr("employeeView", "EmployeeName", "userName", username)
                s.RunQuery("Update RRDetails set Stock = '" & updStx & "' where ID = '" & RRDiD & "'")
                s.RunQuery("insert into salesReturn(returnNo,returnDT,savedBy,savedDT) values('" & returnNo & "','" & transDate & "','" & empName & "',GETDATE())")
                s.RunQuery("insert into salesReturnDetails(salesReturnID,salesDetailsID,qty,reasonID,freeQty,amount) values('" & returnNo & "','" & transNo & "','" & qtyRet & "','" & retReas & "','" & frQtyRet & "','" & txtSRAmount.Text & "')")
                s.RunQuery("update salesDetailss set quantity = NULL, salesID = NULL where ID = '" & dgvSR.Item(0, dgvSR.CurrentRow.Index).Value & "'")
                ResetForm()

                MsgBox("Item Returned ...", vbOKOnly, caption)
                ResetForm()
            End If
        End If
    End Sub
    Private Sub ResetForm()
        c.clrData(GroupBox1)
        c.clrDS(dgvSales)
        c.clrDS(dgvSR)
        chkDatePeriod.Checked = False
        GroupBox1.Enabled = False
    End Sub

    Private Sub ClickClear(sender As Object, e As EventArgs)
        ResetForm()

    End Sub

    Private Sub BtnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        ResetForm()
    End Sub
End Class