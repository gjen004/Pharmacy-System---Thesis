Public Class cControl
    Dim s As New cSQL
    Dim PO As New ivPO
    Public Sub clrData(ByRef pan As Object)
        If pan.HasChildren Then
            For Each ctrl As Control In pan.Controls
                If (ctrl.GetType() Is GetType(TextBox)) Then
                    Dim txt As TextBox = CType(ctrl, TextBox)
                    txt.Text = ""
                ElseIf (ctrl.GetType() Is GetType(ComboBox)) Then
                    Dim cbx As ComboBox = CType(ctrl, ComboBox)
                    cbx.SelectedIndex = -1
                    cbx.Text = ""
                ElseIf (ctrl.GetType() Is GetType(RadioButton)) Then
                    Dim rdb As RadioButton = CType(ctrl, RadioButton)
                    rdb.Checked = False
                End If
            Next
        End If
    End Sub

    Public Function lackData(ByRef pan As Object)
        Dim count As Integer = 0
        Dim ctrls As Integer = 0
        Dim dsp As String
        'Checks components in the panel if its blank or not
        If pan.HasChildren Then
            For Each ctrl As Control In pan.Controls
                If (ctrl.GetType() Is GetType(TextBox)) Then
                    Dim txt As TextBox = CType(ctrl, TextBox)
                    MsgBox(txt.Name)
                    If String.IsNullOrEmpty(txt.Text) Then
                        MsgBox("Walang Laman")
                        count += 1
                        ctrls += 1
                    Else
                        dsp = "Value: " + " " + txt.Text
                        MsgBox(dsp)
                    End If
                ElseIf (ctrl.GetType() Is GetType(ComboBox)) Then
                    Dim cbx As ComboBox = CType(ctrl, ComboBox)
                    MsgBox(cbx.Name)
                    If cbx.SelectedIndex > 0 Then
                        dsp = "value: " + CStr(cbx.SelectedValue)
                        MsgBox(dsp)
                    Else
                        MsgBox("Walang Napili")
                        count += 1
                        ctrls += 1
                    End If

                End If
            Next
        End If
        'If count > 0 Then
        '    Return True
        'Else
        '    Return False
        'End If
        Return ctrls
    End Function

    Public Function getData(ByRef ctrl As Control)
        'gets the values in the components
        If (ctrl.GetType() Is GetType(TextBox)) Then
            Dim txt As TextBox = CType(ctrl, TextBox)
            Return txt.Text.ToString
        ElseIf (ctrl.GetType() Is GetType(ComboBox)) Then
            Dim cbx As ComboBox = CType(ctrl, ComboBox)
            Return cbx.SelectedValue
        ElseIf (ctrl.GetType() Is GetType(DateTimePicker)) Then
            Dim dtpck As DateTimePicker = CType(ctrl, DateTimePicker)
            Return Format(dtpck.Value, "yyyy-MM-dd")
        ElseIf (ctrl.GetType() Is GetType(RadioButton)) Then
            Dim rdb As RadioButton = CType(ctrl, RadioButton)
            If rdb.Checked = True Then
                Return rdb.Text
            Else
            End If
        End If
    End Function

    Public Sub clrDS(ByRef dt As DataGridView)
        dt.DataSource = Nothing
    End Sub

    Public Sub loadData(ByVal point As Integer, ByRef dtg As DataGridView, ByRef tbCode As TextBox, ByRef cmbCat As ComboBox, ByRef tbBr As TextBox, ByRef cmbGen As ComboBox, ByRef cmbDos As ComboBox, ByRef cmbUn As ComboBox, ByRef cmbFrm As ComboBox, ByRef cmbSt As ComboBox)
        tbCode.Text = dtg.Item(1, point).Value
        cmbCat.Text = dtg.Item(2, point).Value
        tbBr.Text = dtg.Item(4, point).Value
        cmbGen.Text = dtg.Item(3, point).Value
        cmbDos.Text = dtg.Item(6, point).Value
        cmbUn.Text = dtg.Item(5, point).Value
        cmbFrm.Text = dtg.Item(7, point).Value
        cmbSt.Text = dtg.Item(8, point).Value
    End Sub

    Public Sub loadDataProdUpdate(ByVal point As Integer, ByRef dtg As DataGridView, ByRef tbCode As TextBox, ByRef cmbCat As ComboBox, ByRef tbBr As TextBox, ByRef cmbGen As ComboBox, ByRef cmbDos As ComboBox, ByRef cmbUn As ComboBox, ByRef cmbFrm As ComboBox, ByRef cmbSt As ComboBox)
        tbCode.Text = dtg.Item(1, point).Value
        cmbCat.Text = dtg.Item(2, point).Value
        tbBr.Text = dtg.Item(4, point).Value
        cmbGen.Text = dtg.Item(3, point).Value
        cmbDos.Text = dtg.Item(6, point).Value
        cmbUn.Text = dtg.Item(5, point).Value
        cmbFrm.Text = dtg.Item(7, point).Value
        'txtsell.Text = dtg.Item(8, point).Value
        cmbSt.Text = dtg.Item(8, point).Value
    End Sub

    Public Sub loadDataSupp(ByVal point As Integer, ByRef dtg As DataGridView, ByRef tbName As TextBox, ByRef tbAdd As TextBox, ByRef city As ComboBox, ByRef prov As ComboBox, ByRef tbCont As TextBox, ByRef tbPers As TextBox, ByRef tin As TextBox)
        tbName.Text = dtg.Item(1, point).Value
        tbAdd.Text = dtg.Item(2, point).Value
        city.Text = dtg.Item(4, point).Value
        prov.Text = dtg.Item(3, point).Value
        tbCont.Text = dtg.Item(5, point).Value
        tbPers.Text = dtg.Item(6, point).Value
        tin.Text = dtg.Item(7, point).Value
        'MAY BINAGO AKO DITO PRE
    End Sub

    Public Sub loadDataCust(ByVal point As Integer, ByRef dtg As DataGridView, ByRef tbName As TextBox, ByRef tbAdd As TextBox, ByRef city As ComboBox, ByRef prov As ComboBox, ByRef tbCont As TextBox)
        tbName.Text = dtg.Item(1, point).Value
        tbAdd.Text = dtg.Item(2, point).Value
        city.Text = dtg.Item(4, point).Value
        prov.Text = dtg.Item(3, point).Value
        tbCont.Text = dtg.Item(5, point).Value
    End Sub

    Public Sub loadDataDelv(ByVal point As Integer, ByRef dtg As DataGridView, ByRef cbxSupp As ComboBox, ByRef tbRRNo As TextBox, ByRef dt As DateTimePicker, ByRef orderNo As TextBox, ByRef quantity As TextBox, ByRef amt As TextBox, ByRef rcvr As TextBox, ByRef remarks As TextBox)
        cbxSupp.SelectedValue = dtg.Item(15, point).Value
        tbRRNo.Text = dtg.Item(14, point).Value
        dt.Value = Convert.ToDateTime(dtg.Item(16, point).Value)
        orderNo.Text = dtg.Item(24, point).Value
        quantity.Text = dtg.Item(25, point).Value
        amt.Text = dtg.Item(26, point).Value
        rcvr.Text = dtg.Item(23, point).Value
        remarks.Text = dtg.Item(17, point).Value
    End Sub 'anomatopea

    Public Sub loadDataEmp(ByVal point As Integer, ByRef dtg As DataGridView, ByRef tbFname As TextBox, ByRef tbLname As TextBox, ByRef cmbsx As ComboBox, ByRef cmbpos As ComboBox, dt As DateTimePicker, ByRef tbuser As TextBox, ByRef tbpass As TextBox)
        tbFname.Text = dtg.Item(1, point).Value
        tbLname.Text = dtg.Item(2, point).Value
        cmbsx.Text = dtg.Item(3, point).Value
        cmbpos.Text = dtg.Item(4, point).Value
        dt.Value = Convert.ToDateTime(dtg.Item(5, point).Value)
        'dt.Value = CDate(dtg(4, point).Value)
        tbuser.Text = dtg.Item(6, point).Value
        tbpass.Text = dtg.Item(7, point).Value
        'MAY BINAGO AKO DITO PRE
    End Sub

    Public Function notif(ByVal id As Integer, ByVal name As String)
        Dim msg As String
        Dim response
        msg = "Delete item" + " " + name
        response = MsgBox(msg, vbYesNo, "Prompt")
        If response = vbYes Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function paymentType(ByRef opt1 As CheckBox, ByRef opt2 As CheckBox, ByRef opt3 As CheckBox)
        If opt1.Checked = True Then
            Return 1
        ElseIf opt2.Checked = True Then
            Return 2
        ElseIf opt3.Checked = True Then
            Return 3
        ElseIf opt1.Checked = False Or opt2.Checked = False Or opt3.Checked = False Then
            MsgBox("Select Payment Type", vbOKOnly, "Prompt")
        End If
    End Function

    'setting the place where it should be
    Public Function countDtgItem(ByRef dtg As DataGridView)
        Dim r, _point As Integer
        r = dtg.RowCount
        If r = 1 Then
            _point = 0
        Else
            _point = r - 1
        End If
        Return _point
    End Function

    'date range
    Public Function getRange(ByVal startDT As String, ByVal endDT As String) 'pending
        Dim tS, tE As Date
        tS = Convert.ToDateTime(startDT)
        tE = Convert.ToDateTime(endDT)
        If tE < tS Then
            MsgBox("Invalid Date!" & vbNewLine & "Starting Date Cannot Be Greater than Ending Date!") 'fixed prompt
            Return True
        Else
            Return False
        End If
    End Function

    Public Function CheckProdExpDT(ByVal expDT As String)
        Dim t, temp As Date
        Dim rn As String
        t = Convert.ToDateTime(expDT)
        temp = Date.Now
        rn = Format(temp, "yyyy-MM-dd")
        If t = rn Then
            MsgBox("Invalid Expiration Date! " & vbNewLine & "Date cannot be the same as date today")
            Return True
        ElseIf t < rn Then
            MsgBox("Date cannot be less than today!", vbOKOnly, "Notice")
            Return True
        End If
    End Function
    'fixed
    Public Function valOrdDate(ByVal orderDT As String, ByVal needDT As String)
        Dim datePO, dateND, temp As Date
        Dim dateRN As String
        temp = Date.Now
        dateRN = Format(temp, "yyyy-MM-dd")
        datePO = Convert.ToDateTime(orderDT)
        dateND = Convert.ToDateTime(needDT)

        If dateND > datePO And datePO = dateRN Then
            Return True
        ElseIf dateND > datePO And datePO > dateRN Then
            Return True
        Else
            If datePO < dateRN Then
                MsgBox("Invalid Date!" & vbNewLine & "Date Needed Cannot Be Less than Date Today!")
                Return False
            ElseIf datePO > dateND Then
                MsgBox("Invalid Date!" & vbNewLine & "Date PO cannot be greater then Date Needed!")
                Return False
            ElseIf datePO = dateND Then
                MsgBox("Invalid Date!" & vbNewLine & "Date PO and Date Needed cannot be the same!")
                Return False
            End If
        End If
    End Function

    Public Function whoSupps(ByVal supp As Integer)
        Dim temp As Integer
        temp = supp
        Return temp
    End Function

    Public Function checkProdEx(ByRef dtg As DataGridView, ByVal prod As String)
        Dim flag As Integer = 0
        For index As Integer = 0 To countDtgItem(dtg)
            If prod = dtg.Item(2, index).Value Then
                flag = 1
            End If
        Next
        If flag > 0 Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function checkProdExRR(ByRef dtg As DataGridView, ByVal prod As String)
        Dim flag As Integer = 0
        For index As Integer = 0 To countDtgItem(dtg)
            If prod = dtg.Item(3, index).Value Then
                flag = 1
            End If
        Next
        If flag > 0 Then
            Return True
        Else
            Return False
        End If
    End Function

    'custom formats and enables
    Public Sub setTrueFalse(ByRef frm As Form, ByRef dtg As DataGridView, ByRef grp As GroupBox)
        If grp Is Nothing Then
            frm.MaximizeBox = False
            frm.MinimizeBox = False
            dtg.AllowUserToAddRows = False
        ElseIf dtg Is Nothing Then
            grp.Enabled = False
            frm.MaximizeBox = False
            frm.MinimizeBox = False
        ElseIf grp Is Nothing And dtg Is Nothing Then
            frm.MaximizeBox = False
            frm.MinimizeBox = False
        Else
            grp.Enabled = False
            frm.MaximizeBox = False
            frm.MinimizeBox = False
            dtg.AllowUserToAddRows = False
        End If
    End Sub

    Public Sub FormProps(ByRef frm As Form)
        frm.MaximizeBox = False
        frm.MinimizeBox = False
    End Sub

    Public Sub formatDTP(ByRef dtp1 As DateTimePicker, ByRef dtp2 As DateTimePicker)
        dtp1.Format = DateTimePickerFormat.Custom
        dtp1.CustomFormat = "MM/dd/yyyy"
        dtp2.Format = DateTimePickerFormat.Custom
        dtp2.CustomFormat = "MM/dd/yyyy"
    End Sub

    Public Sub formatDTPN(ByRef dtp1 As DateTimePicker)
        dtp1.Format = DateTimePickerFormat.Custom
        dtp1.CustomFormat = "MM/dd/yyyy"
    End Sub

    Public Sub setPOList(ByRef dtg As DataGridView, ByRef chk As CheckBox, ByRef dateFrom As DateTimePicker, ByRef dateTo As DateTimePicker, ByRef cbx As ComboBox, ByVal type As Integer)
        If chk.Checked = True Then
            startAt = getData(dateFrom)
            endsAt = getData(dateTo)
            suppName = cbx.Text
            If String.IsNullOrEmpty(suppName) = True Then
                MsgBox("Please Select a Supplier!")
                suppName = Nothing
                Exit Sub
            ElseIf s.checkValStr("cmbSupp", "suppname", suppName) = False Then
                MsgBox("Supplier Does not Exist!")
                suppName = Nothing
                Exit Sub
            ElseIf String.IsNullOrEmpty(startAt) = True And String.IsNullOrEmpty(endsAt) = True Then
                MsgBox("Please Select Date Range!")
                Exit Sub
            ElseIf String.IsNullOrEmpty(startAt) = True Or String.IsNullOrEmpty(endsAt) = True Then
                MsgBox("Please Select Date Range!")
                Exit Sub
            ElseIf String.IsNullOrEmpty(startAt) = True Or String.IsNullOrEmpty(endsAt) = True Or String.IsNullOrEmpty(suppName) = True Then
                MsgBox("Please Fill In All Fields!")
                Exit Sub
            Else
                If getRange(startAt, endsAt) = True Then
                    Exit Sub
                Else

                    PO.loadPO(2, type, dtg, startAt, endsAt, suppName)
                End If
            End If
        ElseIf chk.Checked = False Then
            suppName = cbx.Text
            If String.IsNullOrEmpty(suppName) = True Then
                MsgBox("Please Select a Supplier!")
                Exit Sub
            ElseIf s.checkValStr("cmbSupp", "suppname", suppName) = False Then
                MsgBox("Supplier Does not Exist!")
                suppName = Nothing
                Exit Sub
            Else
                PO.loadPO(1, type, dtg, "", "", suppName)
            End If
        End If

    End Sub

    Public Sub setRRList(ByRef dtg As DataGridView, ByRef chk As CheckBox, ByRef dateFrom As DateTimePicker, ByRef dateTo As DateTimePicker, ByRef cbx As ComboBox)
        If chk.Checked = True Then
            startAt = getData(dateFrom)
            endsAt = getData(dateTo)
            suppName = cbx.Text
            If String.IsNullOrEmpty(suppName) = True Then
                MsgBox("Please Select a Supplier!")
                Exit Sub
            ElseIf s.checkValStr("cmbSupp", "suppname", suppName) = False Then
                MsgBox("Supplier Does not Exist!")
                suppName = Nothing
                Exit Sub
            ElseIf String.IsNullOrEmpty(startAt) = True And String.IsNullOrEmpty(endsAt) = True Then
                MsgBox("Please Select Date Range!")
                Exit Sub
            ElseIf String.IsNullOrEmpty(startAt) = True Or String.IsNullOrEmpty(endsAt) = True Then
                MsgBox("Please Select Date Range!")
                Exit Sub
            ElseIf String.IsNullOrEmpty(startAt) = True Or String.IsNullOrEmpty(endsAt) = True Or String.IsNullOrEmpty(suppName) = True Then
                MsgBox("Please Fill In All Fields!")
                Exit Sub
            Else
                If getRange(startAt, endsAt) = True Then
                    'MsgBox("Invalid Date Selection!")
                    Exit Sub
                Else
                    s.loadRR(2, dtg, startAt, endsAt, suppName)
                End If
            End If
        ElseIf chk.Checked = False Then
            suppName = cbx.Text
            If String.IsNullOrEmpty(suppName) = True Then
                MsgBox("Please Select a Supplier!")
                Exit Sub
            ElseIf s.checkValStr("cmbSupp", "suppname", suppName) = False Then
                MsgBox("Supplier Does not Exist!")
                suppName = Nothing
                Exit Sub
            Else
                s.loadRR(1, dtg, "", "", suppName)
            End If
        End If
    End Sub

    Public Sub setPORRList(ByRef dtg As DataGridView, ByRef chk As CheckBox, ByRef dateFrom As DateTimePicker, ByRef dateTo As DateTimePicker, ByRef cbx As ComboBox, ByVal type As Integer, ByRef grpbx1 As GroupBox, ByRef grpbx2 As GroupBox, ByRef btn As Button)
        If chk.Checked = True Then
            startAt = getData(dateFrom)
            endsAt = getData(dateTo)
            suppName = cbx.Text
            If String.IsNullOrEmpty(suppName) = True Then
                MsgBox("Please Select a Supplier!")
                suppName = Nothing
                Exit Sub
            ElseIf s.checkValStr("cmbSupp", "suppname", suppName) = False Then
                MsgBox("Supplier Does not Exist!")
                suppName = Nothing
                Exit Sub
            ElseIf String.IsNullOrEmpty(startAt) = True And String.IsNullOrEmpty(endsAt) = True Then
                MsgBox("Please Select Date Range!")
                Exit Sub
            ElseIf String.IsNullOrEmpty(startAt) = True Or String.IsNullOrEmpty(endsAt) = True Then
                MsgBox("Please Select Date Range!")
                Exit Sub
            ElseIf String.IsNullOrEmpty(startAt) = True Or String.IsNullOrEmpty(endsAt) = True Or String.IsNullOrEmpty(suppName) = True Then
                MsgBox("Please Fill In All Fields!")
                Exit Sub
            Else
                If getRange(startAt, endsAt) = True Then
                    Exit Sub
                Else
                    PO.loadPO(2, type, dtg, startAt, endsAt, suppName)
                    grpbx1.Enabled = True
                    grpbx2.Enabled = True
                    btn.Enabled = False
                End If
            End If
        ElseIf chk.Checked = False Then
            suppName = cbx.Text
            If String.IsNullOrEmpty(suppName) = True Then
                MsgBox("Please Select a Supplier!")
                Exit Sub
            ElseIf s.checkValStr("cmbSupp", "suppname", suppName) = False Then
                MsgBox("Supplier Does not Exist!")
                suppName = Nothing
                Exit Sub
            Else
                PO.loadPO(1, type, dtg, "", "", suppName)
                grpbx1.Enabled = True
                grpbx2.Enabled = True
                btn.Enabled = False
            End If
        End If
    End Sub

    Public Sub setUpRRList(ByRef dtg As DataGridView, ByRef chk As CheckBox, ByRef dateFrom As DateTimePicker, ByRef dateTo As DateTimePicker, ByRef cbx As ComboBox)
        If chk.Checked = True Then
            startAt = getData(dateFrom)
            endsAt = getData(dateTo)
            suppName = cbx.Text
            If String.IsNullOrEmpty(suppName) = True Then
                MsgBox("Please Select a Supplier!")
                Exit Sub
            ElseIf s.checkValStr("cmbSupp", "suppname", suppName) = False Then
                MsgBox("Supplier Does not Exist!")
                suppName = Nothing
                Exit Sub
            ElseIf String.IsNullOrEmpty(startAt) = True And String.IsNullOrEmpty(endsAt) = True Then
                MsgBox("Please Select Date Range!")
                Exit Sub
            ElseIf String.IsNullOrEmpty(startAt) = True Or String.IsNullOrEmpty(endsAt) = True Then
                MsgBox("Please Select Date Range!")
                Exit Sub
            ElseIf String.IsNullOrEmpty(startAt) = True Or String.IsNullOrEmpty(endsAt) = True Or String.IsNullOrEmpty(suppName) = True Then
                MsgBox("Please Fill In All Fields!")
                Exit Sub
            Else
                If getRange(startAt, endsAt) = True Then
                    Exit Sub
                Else
                    s.loadRR(4, dtg, startAt, endsAt, suppName)
                End If
            End If
        ElseIf chk.Checked = False Then
            suppName = cbx.Text
            If String.IsNullOrEmpty(suppName) = True Then
                MsgBox("Please Select a Supplier!")
                Exit Sub
            ElseIf s.checkValStr("cmbSupp", "suppname", suppName) = False Then
                MsgBox("Supplier Does not Exist!")
                suppName = Nothing
                Exit Sub
            Else
                s.loadRR(3, dtg, "", "", suppName)
            End If
        End If
    End Sub

    Public Sub SetID(ByVal id As Integer)
        SetPONum = id
    End Sub

    Public Function UseId(ByVal num As Integer)
        Dim ito As Integer = num
        Return ito
    End Function


End Class
