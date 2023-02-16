Public Class customerAdd
    Dim c As New cControl
    Dim s As New cSQL

    'event listeners
    Private Sub frmLoad(sender As Object, e As EventArgs) Handles MyBase.Load
        populate()
        c.clrData(grpCustSearch)
        'btnCusAdd.Enabled = False
    End Sub

    Private Sub hideID(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles dgvCustomer.DataBindingComplete
        With dgvCustomer
            .Columns("ID").Visible = False
            .Columns("deletedBy").Visible = False
            dgvCustomer.ClearSelection()
        End With
    End Sub

    'Private Sub enableAdd(sender As Object, e As EventArgs) Handles txtCusContact.KeyUp
    '    If txtCusName.Text = "" And txtCusAddress.Text = "" And cmbCity.SelectedIndex = 0 And cmbProvince.SelectedIndex = 0 And txtCusContact.Text = "" Then
    '        btnCusAdd.Enabled = False
    '    Else
    '        btnCusAdd.Enabled = True
    '    End If
    'End Sub

    Private Sub dropdownClose(sender As Object, e As EventArgs) Handles cmbProvince.SelectedIndexChanged
        s.loadCBXN(cmbCity, "cityview", "ID", "Cities", "where Provinces like '" & cmbProvince.Text & "'")
    End Sub

    Private Sub addCust(sender As Object, e As EventArgs) Handles btnCusAdd.Click
        getValAdd()
        'btnCusAdd.Enabled = False
    End Sub

    Private Sub clr(sender As Object, e As EventArgs)
        c.clrData(grpCustSearch)
    End Sub

    'controls
    Private Sub populate()
        dgvCustomer.DataSource = Nothing
        'load CBX
        s.loadCBX(cmbCity, "city", "ID", "cityName")
        s.loadCBX(cmbProvince, "province", "ID", "provinceName")
        'load DTG
        s.loadDTGN(dgvCustomer, "customerView", "", "deletedBy is NULL", 3)
    End Sub

    Private Sub getValAdd()
        'valdata

        'getData
        'custName = (txtCusName.Text).ToUpper
        'custAdd = (txtCusAddress.Text).ToUpper
        'cityID = cmbCity.SelectedValue
        'provinceID = cmbProvince.SelectedValue
        'contactNo = txtCusContact.Text
        'savedBy = "user"

        'addData
        'If String.IsNullOrEmpty(custName) = True Or String.IsNullOrEmpty(custAdd) = True Or String.IsNullOrEmpty(contactNo) = True Or cityID < 1 Or provinceID < 1 Then
        '    MsgBox("Please Fill In All Fields")
        '    Exit Sub
        If txtCusName.Text = "" Then
            MsgBox("Please Fill In All Fields!", vbOKOnly, caption)
            txtCusName.Select()
            Exit Sub
        ElseIf txtCusAddress.Text = "" Then
            MsgBox("Please Fill In All Fields!", vbOKOnly, caption)
            txtCusAddress.Select()
            Exit Sub
        ElseIf cmbProvince.SelectedIndex = -1 Then
            MsgBox("ERROR! No PROVINCE Selected or Item Does Not Exist on the List!", vbOKOnly, caption)
            cmbProvince.Select()
            Exit Sub
        ElseIf cmbCity.SelectedIndex = -1 Then
            MsgBox("ERROR! No CITY Selected or Item Does Not Exist on the List!", vbOKOnly, caption)
            cmbCity.Select()
            Exit Sub
        ElseIf txtCusContact.Text = "" Then
            MsgBox("Please Fill In All Fields!", vbOKOnly, caption)
            txtCusContact.Select()
            Exit Sub
        ElseIf IsNumeric(txtCusContact.Text) = False Then
            MsgBox("Invalid input! Contact number must be numeric!", vbOKOnly, caption)
            txtCusContact.Select()
            Exit Sub
        Else
            'empName = s.getName()
            empName = s.GetDetailStr("employeeView", "EmployeeName", "userName", username)
            custName = (txtCusName.Text).ToUpper
            custAdd = (txtCusAddress.Text).ToUpper
            cityID = cmbCity.SelectedValue
            provinceID = cmbProvince.SelectedValue
            contactNo = txtCusContact.Text
            savedBy = empName

            s.addCust(dgvCustomer, "customer", custName, custAdd, cityID, provinceID, contactNo, savedBy)
            c.clrData(grpCustInfo)
            populate()
        End If
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        c.clrData(grpCustInfo)
        c.clrData(grpCustSearch)
        populate()
        'btnCusAdd.Enabled = False
    End Sub

    Private Sub btnCusSearch_Click(sender As Object, e As EventArgs) Handles btnCusSearch.Click
        Dim keyword As String
        keyword = txtCusSearch.Text
        If keyword = "" Then
            MsgBox("Please enter keyword!", vbOKOnly, caption)
            txtCusSearch.Select()
            Exit Sub
        Else
            If rdbCustName.Checked = True Then
                s.searchCustomer("customerview", dgvCustomer, keyword, 1)
            ElseIf rdbCustAddress.Checked = True Then
                s.searchCustomer("customerview", dgvCustomer, keyword, 2)
            ElseIf rdbCustName.Checked = False And rdbCustName.Checked = False Then
                s.searchCustomer("customerview", dgvCustomer, keyword, 3)
            End If
        End If
    End Sub
End Class