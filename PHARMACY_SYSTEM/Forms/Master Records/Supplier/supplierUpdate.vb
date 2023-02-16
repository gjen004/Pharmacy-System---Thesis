Public Class supplierUpdate
    Dim c As New cControl
    Dim s As New cSQL

    Private Sub frmLoad(sender As Object, e As EventArgs) Handles MyBase.Load
        populate()
        c.clrData(grpSuppSearch)
        dgvSupplier.AllowUserToAddRows = False
        MyBase.MinimizeBox = False
        MyBase.MaximizeBox = False
        rdbSuppName.Checked = False
        dgvSupplier.ClearSelection()
        btnSupplierUpdate.Enabled = False
        grpSuppInfo.Enabled = False
        c.clrData(grpSuppSearch)
        c.clrData(grpSuppInfo)
    End Sub

    Private Sub hideID(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles dgvSupplier.DataBindingComplete
        With dgvSupplier
            .Columns("ID").Visible = False
            .Columns("deletedBy").Visible = False
            dgvSupplier.ClearSelection()

        End With
    End Sub

    Private Sub dtgFocus(sender As Object, e As EventArgs) Handles dgvSupplier.CellClick
        point = dgvSupplier.CurrentRow.Index
        c.loadDataSupp(point, dgvSupplier, txtSuppName, txtSuppAddress, cmbProvince, cmbCity, txtSuppContact, txtSuppContactPerson, txtSuppTin)
        point = Nothing
        's.loadCBXN(cmbCity, "city", "ID", "cityName", "where provinceName like '" & cmbProvince.Text & "'")
        grpSuppInfo.Enabled = True
        txtSuppName.Enabled = False
        btnSupplierUpdate.Enabled = True
        Exit Sub
    End Sub

    'Private Sub enableSave(sender As Object, e As EventArgs) Handles cmbCity.SelectedIndexChanged
    '    If txtSuppName.Text = "" And txtSuppAddress.Text = "" And cmbCity.SelectedIndex = 0 And cmbProvince.SelectedIndex = 0 And txtSuppContact.Text = "" And txtSuppContactPerson.Text = "" And txtSuppTin.Text = "" Then
    '        btnSupplierUpdate.Enabled = False
    '    Else
    '        btnSupplierUpdate.Enabled = True
    '    End If
    'End Sub

    Private Sub cmbProvinceChange(sender As Object, e As EventArgs) Handles cmbProvince.SelectedIndexChanged
        s.loadCBXN(cmbCity, "cityview", "ID", "Cities", "where Provinces like '" & cmbProvince.Text & "'")
    End Sub

    Private Sub updSup(sender As Object, e As EventArgs) Handles btnSupplierUpdate.Click
        'getLoc
        point = dgvSupplier.CurrentRow.Index
        'getData
        'id = dgvSupplier.Item(0, point).Value
        'Convert.ToInt32(id)
        'suppName = txtSuppName.Text
        'suppAddress = txtSuppAddress.Text
        'cityID = cmbCity.SelectedValue
        'provinceID = cmbProvince.SelectedValue
        'contactNo = txtSuppContact.Text
        'contactPerson = txtSuppContactPerson.Text
        'tin = txtSuppTin.Text
        'updatedBy = "user2"

        'If String.IsNullOrEmpty(suppName) = True Or String.IsNullOrEmpty(suppAddress) = True Or String.IsNullOrEmpty(contactPerson) = True Or String.IsNullOrEmpty(contactNo) = True Or cityID < 1 Or provinceID < 1 Then
        '    MsgBox("Please Fill In All Fields")
        '    Exit Sub
        'ElseIf IsNumeric(contactNo) = False Then
        '    MsgBox("Invalid Input! Contact No. must be numeric!")
        '    btnSupplierUpdate.Enabled = False
        '    Exit Sub
        If txtSuppAddress.Text = "" Then
            MsgBox("Please Fill In All Fields!", vbOKOnly, caption)
            txtSuppAddress.Select()
            SQLCon.Close()
            Exit Sub
        ElseIf cmbProvince.SelectedIndex = -1 Then
            MsgBox("ERROR! No PROVINCE Selected or Item Does Not Exist on the List!", vbOKOnly, caption)
            cmbProvince.Select()
            SQLCon.Close()
            Exit Sub
        ElseIf cmbCity.SelectedIndex = -1 Then
            MsgBox("ERROR! No CITY Selected or Item Does Not Exist on the List!", vbOKOnly, caption)
            cmbCity.Select()
            SQLCon.Close()
            Exit Sub
        ElseIf txtSuppContact.Text = "" Then
            MsgBox("Please Fill In All Fields!", vbOKOnly, caption)
            txtSuppContact.Select()
            SQLCon.Close()
            Exit Sub
        ElseIf IsNumeric(txtSuppContact.Text) = False Then
            MsgBox("Invalid Input! Contact No. must be numeric!", vbOKOnly, caption)
            txtSuppContact.Select()
            SQLCon.Close()
            Exit Sub
        ElseIf txtSuppContactPerson.Text = "" Then
            MsgBox("Please Fill In All Fields!", vbOKOnly, caption)
            txtSuppContactPerson.Select()
            SQLCon.Close()
            Exit Sub
        ElseIf txtSuppTin.Text = "" Then
            MsgBox("Please Fill In All Fields!", vbOKOnly, caption)
            txtSuppTin.Select()
            SQLCon.Close()
            Exit Sub
        ElseIf IsNumeric(txtSuppTin.Text) = False Then
            MsgBox("Invalid Input! TIN must be numeric!", vbOKOnly, caption)
            txtSuppTin.Select()
            SQLCon.Close()
            Exit Sub
        Else
            'empName = s.getName()
            empName = s.GetDetailStr("employeeView", "EmployeeName", "userName", username)
            id = dgvSupplier.Item(0, point).Value
            Convert.ToInt32(id)
            suppName = txtSuppName.Text
            suppAddress = txtSuppAddress.Text
            cityID = cmbCity.SelectedValue
            provinceID = cmbProvince.SelectedValue
            contactNo = txtSuppContact.Text
            contactPerson = txtSuppContactPerson.Text
            tin = txtSuppTin.Text
            updatedBy = empName

            s.updSup(id, dgvSupplier, "supplier", suppName, suppAddress, cityID, provinceID, contactNo, contactPerson, tin, updatedBy, btnSupplierUpdate)
            s.loadDTGN(dgvSupplier, "supplist", "", "deletedBy is NULL", 3)
        End If
        'clear field
        c.clrData(grpSuppInfo)
        c.clrData(grpSuppSearch)
        populate()
    End Sub


    Private Sub populate()
        dgvSupplier.DataSource = Nothing
        s.loadCBX(cmbCity, "city", "ID", "cityName")
        s.loadCBX(cmbProvince, "province", "ID", "provinceName")
        s.loadDTGN(dgvSupplier, "supplist", "", "deletedBy is NULL", 3)
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        c.clrData(grpSuppInfo)
        c.clrData(grpSuppSearch)
        grpSuppInfo.Enabled = False
        btnSupplierUpdate.Enabled = False
        populate()
    End Sub

    Private Sub btnSuppSearchToUpdate(sender As Object, e As EventArgs) Handles btnSuppSearch.Click
        Dim keyword As String
        keyword = txtSuppSearch.Text
        If keyword = "" Then
            MsgBox("Please enter keyword!", vbOKOnly, caption)
            txtSuppSearch.Select()
            Exit Sub
        Else
            If rdbSuppName.Checked = True Then
                s.searchSupplierToUpdate("suppList", dgvSupplier, keyword, 1)
            ElseIf rdbSuppProvince.Checked = True Then
                s.searchSupplierToUpdate("suppList", dgvSupplier, keyword, 2)
            ElseIf rdbSuppName.Checked = False And rdbSuppProvince.Checked = False Then
                s.searchSupplierToUpdate("suppList", dgvSupplier, keyword, 3)
            End If
        End If
    End Sub

    Private Sub txtSuppAddress_TextChanged(sender As Object, e As EventArgs) Handles txtSuppAddress.TextChanged

    End Sub
End Class