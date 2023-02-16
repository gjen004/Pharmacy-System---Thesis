Public Class paymentAdd
    Dim c As New cControl
    Dim s As New cSQL
    Dim PA As New ivPayments
    Private Sub FrmLoad(sender As Object, e As EventArgs) Handles MyBase.Load
        s.loadCBXN(cmbPaySupplier, "supplier", "ID", "suppName", "where deletedBy is NULL")
        s.loadCBX(cmbBankDep, "bank", "ID", "bankName")
        s.loadCBX(cmbChequeBank, "bank", "ID", "bankName")
        btnRemove.Enabled = False
        btnRemoveAll.Enabled = False
        btnPaymentSave.Enabled = False
        grpMOP.Enabled = False
        grpRRDetails.Enabled = False
        c.formatDTP(dateBankDep, dateCash)
        c.formatDTPN(dateCheque)
        c.setTrueFalse(Me, dgvPaymentDetails, Nothing)
        txtPaymentNo.Text = s.GetCount("payment")
        s.clearTemp("paylist")
    End Sub

    Private Sub FrmClose(sender As Object, e As EventArgs) Handles MyBase.Closing
        s.clearTemp("payList")
    End Sub

    Private Sub LoadList(sender As Object, e As EventArgs) Handles btnViewPayables.Click
        suppName = cmbPaySupplier.Text
        If String.IsNullOrEmpty(suppName) = True Then
            MsgBox("Select Supplier First", vbOKOnly, caption)
            cmbPaySupplier.Select()
        Else
            s.loadDTGN(dgvRRDetails, "RRList", "ID, RRNo as 'RR No.', Supplier, RRDate as 'RR Date', totalRR as 'RR Amount', balance as 'Balance'", "Supplier = '" & suppName & "' and Balance > 0.00 order by RRDate, RRNo", 4)
            grpRRDetails.Enabled = True
        End If

        'dgvRRDetails.Columns("RR Amount").Width = 80
        'dgvRRDetails.Columns("Balance").Width = 80


    End Sub



    'Private Sub hideDets(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles dgvRRList.DataBindingComplete
    '    With dgvRRList
    '        .Columns("RRDate").Visible = False
    '        .Columns("userName").Visible = False
    '        .Columns("Remarks").Visible = False
    '    End With
    'End Sub

    'Private Sub showRec(sender As Object, e As EventArgs) Handles dgvRRList.CellClick
    '    If btnCreate.Enabled = False Then
    '        GroupBox2.Enabled = True
    '        btnAdd.Enabled = True

    '    ElseIf btnCreate.Enabled = True Then
    '        GroupBox2.Enabled = True
    '        btnAdd.Enabled = False

    '    End If
    '    'load details
    '    _index = dgvRRList.CurrentRow.Index
    '    whereIs = dgvRRList.Item(1, _index).Value
    '    s.loadDTGN(dgvRRDetails, "RR", "RRDate,totalRR as 'Total',Balance", "RRNo = " + whereIs + "and Balance > 0.00", 4)
    '    'compute total
    '    Dim tBal As Double = 0
    '    txtTotalBal.Text = dgvRRDetails.Item(2, dgvRRDetails.CurrentRow.Index).Value
    'End Sub



    Private Sub hideDets(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles dgvRRDetails.DataBindingComplete
        With dgvRRDetails
            .Columns("ID").Visible = False
            .Columns("Supplier").Visible = False
            dgvRRDetails.Columns(3).DefaultCellStyle.Format = "MM/dd/yyyy"
            dgvRRDetails.ClearSelection()

            dgvRRDetails.Columns("Balance").DefaultCellStyle.Format = "N"
            dgvRRDetails.Columns("RR Amount").DefaultCellStyle.Format = "N"

            dgvRRDetails.Columns("RR No.").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            dgvRRDetails.Columns("RR No.").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            dgvRRDetails.Columns("RR Date").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            dgvRRDetails.Columns("RR Date").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            dgvRRDetails.Columns("RR Amount").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            dgvRRDetails.Columns("RR Amount").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight
            dgvRRDetails.Columns("Balance").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            dgvRRDetails.Columns("Balance").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight
        End With
    End Sub

    Private Sub hideIDPNo(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles dgvPaymentDetails.DataBindingComplete
        With dgvPaymentDetails
            .Columns("ID").Visible = False
            .Columns("PaymentNo").Visible = False
            .Columns("Supplier").Visible = False

            dgvPaymentDetails.Columns("Amount").DefaultCellStyle.Format = "N"
        End With
        dgvPaymentDetails.ClearSelection()

    End Sub

    'Private Sub detailsClick(sender As Object, e As EventArgs) Handles dgvRRDetails.CellClick
    '    c.clrData(Panel11)
    '    c.clrData(Panel12)
    '    c.clrData(Panel13)
    'End Sub


    Private Sub CreatePayNo(sender As Object, e As EventArgs) Handles btnCreate.Click
        paymentNo = c.getData(txtPaymentNo)
        supp = c.getData(cmbPaySupplier)
        empName = s.GetDetailStr("employeeView", "EmployeeName", "userName", username)

        If String.IsNullOrEmpty(paymentNo) = True Then
            MsgBox("Please Provide a Payment Number", vbOKOnly, caption)
            txtPaymentNo.Select()
        ElseIf supp = 0 Then
            MsgBox("Please Select a Supplier", vbOKOnly, caption)
            cmbPaySupplier.Select()
        Else
            PA.CreatePayment(paymentNo, supp, empName)
            btnAdd.Enabled = True

            grpMOP.Enabled = True
            btnCreate.Enabled = False
            txtPaymentNo.Enabled = False
            cmbPaySupplier.Enabled = False
            btnViewPayables.Enabled = False
        End If
    End Sub

    Private Sub SelectModeCash(sender As Object, e As EventArgs) Handles chkCash.CheckedChanged
        If chkCash.CheckState = CheckState.Checked Then
            Panel13.Enabled = True

            chkCheque.Checked = False
            chkBankDep.Checked = False
            Panel11.Enabled = False
            Panel12.Enabled = False

        ElseIf chkCash.CheckState = CheckState.Unchecked Then
            Panel13.Enabled = False
        End If
    End Sub

    Private Sub SelectModeChq(sender As Object, e As EventArgs) Handles chkCheque.CheckedChanged
        If chkCheque.CheckState = CheckState.Checked Then
            Panel12.Enabled = True

            chkCash.Checked = False
            'chkCheque.Checked = True
            chkBankDep.Checked = False
            Panel11.Enabled = False
            Panel13.Enabled = False
        ElseIf chkCheque.CheckState = CheckState.Unchecked Then
            Panel12.Enabled = False
        End If
    End Sub

    Private Sub SelectModeDep(sender As Object, e As EventArgs) Handles chkBankDep.CheckedChanged
        If chkBankDep.CheckState = CheckState.Checked Then
            Panel11.Enabled = True

            chkCash.Checked = False
            chkCheque.Checked = False
            'chkBankDep.Checked = True
            Panel12.Enabled = False
            Panel13.Enabled = False
        ElseIf chkBankDep.CheckState = CheckState.Unchecked Then
            Panel11.Enabled = False
        End If
    End Sub

    Private Sub AddItems(sender As Object, e As EventArgs) Handles btnAdd.Click
        Try
            If dgvRRDetails.SelectedRows.Count = 0 Then
                MsgBox("No Item Selected", vbOKOnly, caption)
                Exit Sub
            Else
                RRDiD = dgvRRDetails.Item(1, dgvRRDetails.CurrentRow.Index).Value
                paymentNo = c.getData(txtPaymentNo)
                If s.checkVal("payList", "RRNo", RRDiD) = True Then 'chk item to be paid if its in the list
                    MsgBox("Item already Added!", vbOKOnly, caption)
                    RRDiD = Nothing
                    Exit Sub
                Else
                    grpPayments.Enabled = True
                    btnPaymentSave.Enabled = True
                    PayMeths()
                End If
            End If
            dgvPaymentDetails.Columns("Amount").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            dgvPaymentDetails.Columns("Amount").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            dgvPaymentDetails.Columns("PaymentMethod").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            dgvPaymentDetails.Columns("PaymentMethod").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            dgvPaymentDetails.Columns("Bank").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            dgvPaymentDetails.Columns("Bank").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            dgvPaymentDetails.Columns("TransactionNo").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            dgvPaymentDetails.Columns("TransactionNo").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub RemoveOnPay(sender As Object, e As EventArgs) Handles btnRemove.Click
        Try
            paymentNo = c.getData(txtPaymentNo)
            point = dgvPaymentDetails.CurrentRow.Index
            id = dgvPaymentDetails.Item(0, point).Value
            s.delete(dgvPaymentDetails, "payList", id)
            s.loadDTGN(dgvPaymentDetails, "payList", "", "PaymentNo = '" & paymentNo & "'", 3)
        Catch ex As Exception
            MsgBox("No selected Item!", vbOKOnly, caption)
        End Try

    End Sub

    Private Sub RemoveAllOnPay(sender As Object, e As EventArgs) Handles btnRemoveAll.Click
        Try
            paymentNo = c.getData(txtPaymentNo)
            dgvPaymentDetails.Rows(0).Selected = True
            For index As Integer = 0 To c.countDtgItem(dgvPaymentDetails)
                s.delete(dgvPaymentDetails, "payList", dgvPaymentDetails.Item(0, index).Value)
            Next
            s.loadDTGN(dgvPaymentDetails, "payList", "", "PaymentNo = '" & paymentNo & "'", 3)
            txtTotalAmount.Text = ""
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    'Private Sub SavePayments(sender As Object, e As EventArgs) Handles btnPaymentSave.Click
    '    'Try
    '    dgvPaymentDetails.Rows(0).Selected = True
    '        For index As Integer = 0 To c.countDtgItem(dgvPaymentDetails)
    '            'CODE TO CALCULATE AMOUNT LEFT
    '            'code to tell if it is RRDetailsID or RRNo
    '            Dim suppNum As Integer = s.GetDetailStr("cmbSupp", "ID", "suppname", dgvPaymentDetails.Item(2, index).Value)
    '            s.RunQuery("insert into paymentDetails(PaymentNo,RRDetailsID,amount,Supplier) values('" & dgvPaymentDetails.Item(1, index).Value & "','" & dgvPaymentDetails.Item(3, index).Value & "','" & dgvPaymentDetails.Item(4, index).Value & "','" & suppNum & "')")
    '            If dgvPaymentDetails.Item(5, index).Value = "Cash" Then
    '                s.RunQuery("insert into paymentType(paymentNo,cashAmt) values('" & dgvPaymentDetails.Item(1, index).Value & "','" & dgvPaymentDetails.Item(3, index).Value & "')")
    '                PA.ComputeBayarin(dgvPaymentDetails.Item(3, index).Value, dgvPaymentDetails.Item(4, index).Value) 'for RRDetails
    '                ComputeAmountLeft(dgvPaymentDetails.Item(3, index).Value, dgvPaymentDetails.Item(4, index).Value) 'for RR
    '            ElseIf dgvPaymentDetails.Item(5, index).Value = "Cheque" Then
    '                s.RunQuery("insert into paymentType(paymentNo,chequeNo,chequeAmt,chequeBankID) values('" & dgvPaymentDetails.Item(1, index).Value & "','" & dgvPaymentDetails.Item(7, index).Value & "','" & dgvPaymentDetails.Item(4, index).Value & "','" & WhichBank(dgvPaymentDetails.Item(6, index).Value) & "')")
    '                PA.ComputeBayarin(dgvPaymentDetails.Item(3, index).Value, dgvPaymentDetails.Item(4, index).Value)
    '                ComputeAmountLeft(dgvPaymentDetails.Item(3, index).Value, dgvPaymentDetails.Item(4, index).Value) 'for RR
    '            ElseIf dgvPaymentDetails.Item(5, index).Value = "Bank Deposit" Then
    '                s.RunQuery("insert into paymentType(paymentNo,bankDepositNo,bankDepositAmt,bankDepositID) values('" & dgvPaymentDetails.Item(1, index).Value & "','" & dgvPaymentDetails.Item(7, index).Value & "','" & dgvPaymentDetails.Item(4, index).Value & "','" & WhichBank(dgvPaymentDetails.Item(6, index).Value) & "')")
    '                PA.ComputeBayarin(dgvPaymentDetails.Item(3, index).Value, dgvPaymentDetails.Item(4, index).Value)
    '                ComputeAmountLeft(dgvPaymentDetails.Item(3, index).Value, dgvPaymentDetails.Item(4, index).Value) 'for RR
    '            End If
    '        Next
    '        MsgBox("Payments Saved!")
    '        ResetForm()
    '    'Catch ex As Exception
    '    '    MsgBox(ex.Message)
    '    'End Try
    'End Sub
    Private Sub SavePayments(sender As Object, e As EventArgs) Handles btnPaymentSave.Click
        Try
            dgvPaymentDetails.Rows(0).Selected = True
            For index As Integer = 0 To c.countDtgItem(dgvPaymentDetails)
                RRDiD = dgvPaymentDetails.Item(3, index).Value
                Dim suppNum As Integer = s.GetDetailStr("cmbSupp", "ID", "suppname", dgvPaymentDetails.Item(2, index).Value)
                s.RunQuery("insert into paymentDetails(PaymentNo,RRNo,amount,SupplierID) values('" & dgvPaymentDetails.Item(1, index).Value & "','" & dgvPaymentDetails.Item(3, index).Value & "','" & dgvPaymentDetails.Item(4, index).Value & "','" & suppNum & "')")
                If dgvPaymentDetails.Item(5, index).Value = "Cash" Then
                    s.RunQuery("insert into paymentType(paymentNo,cashAmt) values('" & dgvPaymentDetails.Item(1, index).Value & "','" & dgvPaymentDetails.Item(3, index).Value & "')")
                    'PA.ComputeBayarin(dgvPaymentDetails.Item(3, index).Value, dgvPaymentDetails.Item(4, index).Value) 'for RRDetails
                    ComputeAmountLeft(dgvPaymentDetails.Item(3, index).Value, dgvPaymentDetails.Item(4, index).Value) 'for RR
                ElseIf dgvPaymentDetails.Item(5, index).Value = "Cheque" Then
                    s.RunQuery("insert into paymentType(paymentNo,chequeNo,chequeAmt,chequeBankID) values('" & dgvPaymentDetails.Item(1, index).Value & "','" & dgvPaymentDetails.Item(7, index).Value & "','" & dgvPaymentDetails.Item(4, index).Value & "','" & WhichBank(dgvPaymentDetails.Item(6, index).Value) & "')")
                    'PA.ComputeBayarin(dgvPaymentDetails.Item(3, index).Value, dgvPaymentDetails.Item(4, index).Value)
                    ComputeAmountLeft(dgvPaymentDetails.Item(3, index).Value, dgvPaymentDetails.Item(4, index).Value) 'for RR
                ElseIf dgvPaymentDetails.Item(5, index).Value = "Bank Deposit" Then
                    s.RunQuery("insert into paymentType(paymentNo,bankDepositNo,bankDepositAmt,bankDepositID) values('" & dgvPaymentDetails.Item(1, index).Value & "','" & dgvPaymentDetails.Item(7, index).Value & "','" & dgvPaymentDetails.Item(4, index).Value & "','" & WhichBank(dgvPaymentDetails.Item(6, index).Value) & "')")
                    'PA.ComputeBayarin(dgvPaymentDetails.Item(3, index).Value, dgvPaymentDetails.Item(4, index).Value)
                    ComputeAmountLeft(dgvPaymentDetails.Item(3, index).Value, dgvPaymentDetails.Item(4, index).Value) 'for RR
                End If
                btnViewPayables.Enabled = True
                cmbPaySupplier.Enabled = True
            Next
            MsgBox("Payments Saved!", vbOKOnly, caption)
            ResetForm()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    'misc subs
    Private Sub ComputeTotal(ByVal mode As Integer)
        Try
            Dim tAmtToPay As Double = 0
            If mode = 1 Then
                dgvPaymentDetails.Rows(0).Selected = True
                For index As Integer = 0 To c.countDtgItem(dgvPaymentDetails)
                    tAmtToPay = tAmtToPay + dgvPaymentDetails.Item(4, index).Value
                Next
                txtTotalAmount.Text = tAmtToPay
                txtTotalAmount.Text = Format(Val(txtTotalAmount.Text), "N")
                btnRemove.Enabled = True
                btnRemoveAll.Enabled = True
                btnPaymentSave.Enabled = True
            ElseIf mode = 2 Then

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub ComputeAmountLeft(ByVal RRDetID As Integer, ByVal amtPd As Double)
        'RRDiD = dgvRRDetails.Item(1, dgvRRDetails.CurrentRow.Index).Value
        'Dim RRNum As Integer = s.GetDetail("RRDetails", "RRID", "ID", RRDetID)
        Dim rrbal As Double = s.GetDetail("RRList", "Balance", "RRNo", RRDiD)

        Dim amtLeft As Double = rrbal - amtPd
        s.RunQuery("update RR set Balance = '" & amtLeft & "' where RRNo =  '" & RRDiD & "'")
    End Sub

    Private Sub ResetForm()
        's.RunQuery("delete from payment where paymentNo = '" & txtPaymentNo.Text & "'")
        s.clearTemp("payList")
        c.clrDS(dgvPaymentDetails)
        c.clrDS(dgvRRDetails)
        btnCreate.Enabled = True
        btnRemove.Enabled = False
        btnRemoveAll.Enabled = False
        btnPaymentSave.Enabled = False
        grpMOP.Enabled = False
        c.clrData(grpMOP)
        grpRRDetails.Enabled = False
        c.clrData(grpRRDetails)
        c.clrData(grpPayments)
        txtPaymentNo.Text = s.GetCount("payment")
        txtTotalAmount.Text = ""
        txtTotalBal.Text = ""
        cmbPaySupplier.SelectedIndex = -1
    End Sub

    Private Sub FormRefresh(sender As Object, e As EventArgs) Handles btnRefresh.Click
        ResetForm()
        c.clrData(Panel11)
        c.clrData(Panel12)
        c.clrData(Panel13)
        chkCash.CheckState = CheckState.Unchecked
        chkCheque.CheckState = CheckState.Unchecked
        chkBankDep.CheckState = CheckState.Unchecked
        btnViewPayables.Enabled = True
        cmbPaySupplier.Enabled = True
    End Sub

    Private Function WhichBank(ByVal bnkName As String)
        Dim temp As String = s.GetDetailStr("bank", "ID", "bankName", bnkName)
        'MsgBox(temp)
        Return temp
    End Function

    Private Sub PayMeths()
        Dim paymentSum As Integer
        Dim totAmt, totBal As String
        point = dgvRRDetails.CurrentRow.Index
        totAmt = c.getData(txtTotalAmount)
        totBal = dgvRRDetails.Item(5, point).Value

        If chkCash.CheckState = CheckState.Checked Then
            chkCheque.CheckState = CheckState.Unchecked
            chkBankDep.CheckState = CheckState.Unchecked
            payCsh = c.getData(txtCashAmount)
            payOn = c.getData(dateCash)

            If txtCashAmount.Text = "" Then
                MsgBox("Please enter cash amount!", vbOKOnly, caption)
                txtCashAmount.Select()
                Exit Sub
            ElseIf IsNumeric(txtCashAmount.Text) = False Then
                MsgBox("Cash amount must be a number!", vbOKOnly, caption)
                Exit Sub
            ElseIf payOn > Date.Now Then
                MsgBox("Payment date cannot be greater than date today!", vbOKOnly, caption)
                dateCash.Select()
                Exit Sub
            ElseIf CDbl(payCsh) > CDbl(totBal) Then
                MsgBox("Payment input exceeded the Total RR Balance!", vbOKOnly, caption)
                txtCashAmount.Select()
                Exit Sub
                'ElseIf String.IsNullOrEmpty(totAmt) = False Then
                '    paymentSum = Convert.ToInt32(txtCashAmount.Text) + Convert.ToInt32(txtTotalAmount.Text)
                '    If paymentSum > totBal Then
                '        MsgBox("Total Payment Amount will exceed the Total RR Balance!", vbOKOnly, caption)
                '        txtCashAmount.Select()
                '        Exit Sub
                '    End If
            End If
            PA.AddPaymentToList(dgvPaymentDetails, paymentNo, RRDiD, payCsh, "Cash", "", 0, cmbPaySupplier.Text)
            c.clrData(Panel13)
            chkCash.Checked = False
            Panel13.Enabled = False
            ComputeTotal(1)
            dgvPaymentDetails.ClearSelection()
        End If
        If chkCheque.CheckState = CheckState.Checked Then
            chkCash.CheckState = CheckState.Unchecked
            chkBankDep.CheckState = CheckState.Unchecked
            payDtChq = c.getData(dateCheque)
            If txtChequeAmount.Text = "" Then
                MsgBox("Please enter cheque amount!", vbOKOnly, caption)
                txtChequeAmount.Select()
                Exit Sub
            ElseIf IsNumeric(txtChequeAmount.Text) = False Then
                MsgBox("Cheque amount must be a number!", vbOKOnly, caption)
                Exit Sub
            ElseIf txtChequeNo.Text = "" Then
                MsgBox("Please enter cheque no.!", vbOKOnly, caption)
                txtChequeNo.Select()
                Exit Sub
            ElseIf IsNumeric(txtChequeNo.Text) = False Then
                MsgBox("Cheque No. must be a number!", vbOKOnly, caption)
                txtChequeNo.Select()
                chqNo = Nothing
                Exit Sub
            ElseIf cmbChequeBank.SelectedIndex < 0 Then
                MsgBox("Please select bank!", vbOKOnly, caption)
                cmbChequeBank.Select()
                Exit Sub
            ElseIf CDbl(txtChequeAmount.Text) > CDbl(totBal) Then
                MsgBox("Payment input exceeded the Total RR Balance!", vbOKOnly, caption)
                txtChequeAmount.Select()
                Exit Sub
                'ElseIf String.IsNullOrEmpty(totAmt) = False Then
                '    'paymentSum = Convert.ToInt32(txtChequeAmount.Text) + Convert.ToInt32(txtTotalAmount.Text)
                '    'If paymentSum > totBal Then
                '    '    MsgBox("Total Payment Amount will exceed the Total RR Balance!", vbOKOnly, caption)
                '    '    txtChequeAmount.Select()
                '    '    Exit Sub
                '    'End If
            ElseIf payDtChq > Date.Now Then
                MsgBox("Payment date cannot be greater than date today!", vbOKOnly, caption)
                dateCheque.Select()
                Exit Sub
            End If

            chqAmt = c.getData(txtChequeAmount)
            payDtChq = c.getData(dateCheque)
            chqBnk = cmbChequeBank.Text
            chqNo = c.getData(txtChequeNo)

            PA.AddPaymentToList(dgvPaymentDetails, paymentNo, RRDiD, chqAmt, "Cheque", chqBnk, chqNo, cmbPaySupplier.Text)
            c.clrData(Panel12)
            chkCheque.Checked = False
            Panel12.Enabled = False
            ComputeTotal(1)
            dgvPaymentDetails.ClearSelection()

        End If
        If chkBankDep.CheckState = CheckState.Checked Then
            chkCheque.CheckState = CheckState.Unchecked
            chkCash.CheckState = CheckState.Unchecked
            payDtDpst = c.getData(dateBankDep)

            If txtBankDep.Text = "" Then
                MsgBox("Please enter amount deposited!", vbOKOnly, caption)
                txtBankDep.Select()
                Exit Sub
            ElseIf IsNumeric(txtDepNo.Text) = False Then
                MsgBox("Invalid Number!", vbOKOnly, caption)
                txtDepNo.Select()
                Exit Sub
            ElseIf cmbBankDep.SelectedIndex < 0 Then
                MsgBox("Please select bank!", vbOKOnly, caption)
                cmbBankDep.Select()
                Exit Sub
            ElseIf CDbl(txtBankDep.Text) > CDbl(totBal) Then
                MsgBox("Payment input exceeded the Total RR Balance!", vbOKOnly, caption)
                txtBankDep.Select()
                Exit Sub
                'ElseIf String.IsNullOrEmpty(totAmt) = False Then
                '    paymentSum = Convert.ToInt32(txtBankDep.Text) + Convert.ToInt32(txtTotalAmount.Text)
                '    If paymentSum > totBal Then
                '        MsgBox("Total Payment Amount will exceed the Total RR Balance!", vbOKOnly, caption)
                '        txtBankDep.Select()
                '        Exit Sub
                '    End If
            ElseIf payDtDpst > Date.Now Then
                MsgBox("Payment date cannot be greater than date today!", vbOKOnly, caption)
                dateBankDep.Select()
                Exit Sub
            End If

            dpstAmt = c.getData(txtBankDep)
            dpstBnk = cmbBankDep.Text
            dpstNo = c.getData(txtDepNo)

            PA.AddPaymentToList(dgvPaymentDetails, paymentNo, RRDiD, dpstAmt, "Bank Deposit", dpstBnk, dpstNo, cmbPaySupplier.Text)
            c.clrData(Panel11)
            chkBankDep.Checked = False
            Panel11.Enabled = False
            ComputeTotal(1)
            dgvPaymentDetails.ClearSelection()

        End If



    End Sub


    'Private Function deleteUnsaveDet(sender As Object, e As EventArgs)
    '    If s.checkVal("Pay") Then
    'End Function

End Class