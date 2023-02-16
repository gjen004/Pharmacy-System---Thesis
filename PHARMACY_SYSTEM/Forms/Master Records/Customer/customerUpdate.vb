Public Class customerUpdate

    Dim s As New cSQL
    Dim c As New cControl

    Private Sub frmLoad(sender As Object, e As EventArgs) Handles MyBase.Load
        populate()
        btnSave.Enabled = False
        grpCustInfo.Enabled = False
        c.clrData(grpCustSearch)
    End Sub

    Private Sub hideID(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles dgvCustomer.DataBindingComplete
        With dgvCustomer
            .Columns("ID").Visible = False
            .Columns("deletedBy").Visible = False
            dgvCustomer.ClearSelection()
        End With
    End Sub

    Private Sub dropdownClose(sender As Object, e As EventArgs) Handles cmbProvince.SelectedIndexChanged
        s.loadCBXN(cmbCity, "cityview", "ID", "Cities", "where Provinces like '" & cmbProvince.Text & "'")
    End Sub

    Private Sub dtgFocus(sender As Object, e As EventArgs) Handles dgvCustomer.CellClick
        point = dgvCustomer.CurrentRow.Index
        c.loadDataCust(point, dgvCustomer, txtCusName, txtCusAddress, cmbProvince, cmbCity, txtCusContact)
        point = Nothing
        's.loadCBXN(cmbCity, "city", "ID", "cityName", "where provinceName like '" & cmbProvince.Text & "'")
        grpCustInfo.Enabled = True
        btnSave.Enabled = True
        Exit Sub
    End Sub

    'Private Sub enableSave(sender As Object, e As EventArgs) Handles cmbCity.SelectedIndexChanged
    '    If txtCusName.Text = "" And txtCusAddress.Text = "" And cmbCity.SelectedIndex = 0 And cmbProvince.SelectedIndex = 0 And txtCusContact.Text = "" Then
    '        btnSave.Enabled = False
    '    Else
    '        btnSave.Enabled = True
    '    End If
    'End Sub

    Private Sub clr(sender As Object, e As EventArgs)
        c.clrData(grpCustSearch)
    End Sub

    Private Sub upProd(sender As Object, e As EventArgs) Handles btnSave.Click
        'getLoc
        point = dgvCustomer.CurrentRow.Index
        'getData
        'empName = s.getName()
        empName = s.GetDetailStr("employeeView", "EmployeeName", "userName", username)
        id = dgvCustomer.Item(0, point).Value
        Convert.ToInt32(id)
        custName = (txtCusName.Text).ToUpper
        custAdd = (txtCusAddress.Text).ToUpper
        cityID = cmbCity.SelectedValue
        provinceID = cmbProvince.SelectedValue
        contactNo = txtCusContact.Text
        updatedBy = empName

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
            s.updCust(id, dgvCustomer, "customer", custName, custAdd, cityID, provinceID, contactNo, updatedBy)
            grpCustInfo.Enabled = False
            c.clrData(grpCustSearch)
            btnSave.Enabled = False
        End If
        'clear field
        c.clrData(grpCustInfo)
        populate()

    End Sub

    Private Sub populate()
        dgvCustomer.DataSource = Nothing
        s.loadCBX(cmbCity, "city", "ID", "cityName")
        s.loadCBX(cmbProvince, "province", "ID", "provinceName")
        s.loadDTGN(dgvCustomer, "viewcustomer", "", "deletedBy is NULL", 3)
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        c.clrData(grpCustInfo)
        c.clrData(grpCustSearch)
        grpCustInfo.Enabled = False
        btnSave.Enabled = False
        populate()
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
                s.searchCustomerToUpdate("viewcustomer", dgvCustomer, keyword, 1)
            ElseIf rdbCustAddress.Checked = True Then
                s.searchCustomerToUpdate("viewcustomer", dgvCustomer, keyword, 2)
            ElseIf rdbCustName.Checked = False And rdbCustName.Checked = False Then
                s.searchCustomerToUpdate("viewcustomer", dgvCustomer, keyword, 3)
            End If
        End If
    End Sub
End Class