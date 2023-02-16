Imports System.Data.Sql
Imports System.Data.SqlClient

Public Class supplierAdd

    Dim c As New cControl
    Dim s As New cSQL

    'event listeners
    Private Sub frmLoad(sender As Object, e As EventArgs) Handles MyBase.Load
        populate()
        dgvSupplier.AllowUserToAddRows = False
        MyBase.MaximizeBox = False
        MyBase.MinimizeBox = False
        c.clrData(grpSuppInfo)
        c.clrData(GroupBox14)
        'btnSuppAdd.Enabled = False
    End Sub

    'Private Sub enableAdd(sender As Object, e As EventArgs) Handles txtSuppTin.KeyDown
    '    If txtSuppName.Text = "" And txtSuppAddress.Text = "" And cmbSuppProvince.SelectedIndex = 0 And cmbCity.SelectedIndex = 0 And txtSuppContact.Text = "" And txtSuppContactPerson.Text = "" And txtSuppTin.Text = "" Then
    '        btnSuppAdd.Enabled = False
    '    Else
    '        btnSuppAdd.Enabled = True
    '    End If
    'End Sub

    Private Sub hideID(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles dgvSupplier.DataBindingComplete
        With dgvSupplier
            .Columns("ID").Visible = False
            .Columns("deletedBy").Visible = False
            dgvSupplier.ClearSelection()
        End With
    End Sub

    Private Sub addSupp(sender As Object, e As EventArgs) Handles btnSuppAdd.Click
        getValAdd()
    End Sub

    Private Sub dropdownClose(sender As Object, e As EventArgs) Handles cmbSuppProvince.SelectedIndexChanged
        s.loadCBXN(cmbCity, "cityview", "ID", "Cities", "where Provinces like '" & cmbSuppProvince.Text & "'")
    End Sub

    'controls
    Private Sub populate()
        dgvSupplier.DataSource = Nothing
        'load CBX
        s.loadCBX(cmbCity, "city", "ID", "cityName")
        s.loadCBX(cmbSuppProvince, "province", "ID", "provinceName")
        'load DTG
        s.loadDTGN(dgvSupplier, "Viewsupp", "", "deletedBy is NULL", 3)
    End Sub

    Private Sub getValAdd()
        'getData
        'suppName = txtSuppName.Text.ToUpper
        'suppAddress = txtSuppAddress.Text.ToUpper
        'cityID = cmbCity.SelectedValue
        'provinceID = cmbSuppProvince.SelectedValue
        'contactNo = txtSuppContact.Text
        'contactPerson = txtSuppContactPerson.Text.ToUpper
        'tin = txtSuppTin.Text
        'savedBy = "user"

        'valdata or add
        SQLCon.Open()
        Dim checkQuery As String = "select * from supplier where suppName = '" & txtSuppName.Text & "'"
        Dim cmd As SqlCommand = New SqlCommand(checkQuery, SQLCon)
        Using reader As SqlDataReader = cmd.ExecuteReader()
            'If String.IsNullOrEmpty(suppName) = True Or String.IsNullOrEmpty(suppAddress) = True Or String.IsNullOrEmpty(contactPerson) = True Or String.IsNullOrEmpty(contactNo) = True Or cityID < 1 Or provinceID < 1 Then
            '    MsgBox("Please Fill In All Fields")
            '    SQLCon.Close()
            '    Exit Sub
            If txtSuppName.Text = "" Then
                MsgBox("Please Fill In All Fields!", vbOKOnly, caption)
                txtSuppName.Select()
                SQLCon.Close()
                reader.Close()
                Exit Sub
            ElseIf reader.HasRows Then
                MsgBox("Invalid Input! Supplier name already exist!", vbOKOnly, caption)
                txtSuppName.Select()
                reader.Close()
                SQLCon.Close()

                Exit Sub
            ElseIf txtSuppAddress.Text = "" Then
                MsgBox("Please Fill In All Fields!", vbOKOnly, caption)
                txtSuppAddress.Select()
                SQLCon.Close()
                reader.Close()
                Exit Sub
            ElseIf cmbSuppProvince.SelectedIndex = -1 Then
                MsgBox("ERROR! No PROVINCE Selected or Item Does Not Exist on the List!", vbOKOnly, caption)
                cmbSuppProvince.Select()
                SQLCon.Close()
                reader.Close()
                Exit Sub
            ElseIf cmbCity.SelectedIndex = -1 Then
                MsgBox("ERROR! No CITY Selected or Item Does Not Exist on the List!", vbOKOnly, caption)
                cmbCity.Select()
                SQLCon.Close()
                reader.Close()
                Exit Sub
            ElseIf txtSuppContact.Text = "" Then
                MsgBox("Please Fill In All Fields!", vbOKOnly, caption)
                txtSuppContact.Select()
                SQLCon.Close()
                reader.Close()
                Exit Sub
            ElseIf IsNumeric(txtSuppContact.Text) = False Then
                reader.Close()
                MsgBox("Invalid Input! Contact No. must be numeric!", vbOKOnly, caption)
                txtSuppContact.Select()
                SQLCon.Close()
                Exit Sub
            ElseIf txtSuppContactPerson.Text = "" Then
                MsgBox("Please Fill In All Fields!", vbOKOnly, caption)
                txtSuppContactPerson.Select()
                SQLCon.Close()
                reader.Close()
                Exit Sub
            ElseIf txtSuppTin.Text = "" Then
                MsgBox("Please Fill In All Fields!", vbOKOnly, caption)
                txtSuppTin.Select()
                SQLCon.Close()
                reader.Close()
                Exit Sub
            ElseIf IsNumeric(txtSuppTin.Text) = False Then
                reader.Close()
                MsgBox("Invalid Input! TIN must be numeric!", vbOKOnly, caption)
                txtSuppTin.Select()
                SQLCon.Close()
                Exit Sub
            Else
                reader.Close()
                'empName = s.getName()
                empName = s.GetDetailStr("employeeView", "EmployeeName", "userName", username)
                suppName = txtSuppName.Text.ToUpper
                suppAddress = txtSuppAddress.Text.ToUpper
                cityID = cmbCity.SelectedValue
                provinceID = cmbSuppProvince.SelectedValue
                contactNo = txtSuppContact.Text
                contactPerson = txtSuppContactPerson.Text.ToUpper
                tin = txtSuppTin.Text
                savedBy = empName

                reader.Close()
                s.addSup(dgvSupplier, "supplier", suppName, suppAddress, cityID, provinceID, contactNo, contactPerson, tin, savedBy, btnSuppAdd)
                s.loadDTGN(dgvSupplier, "Viewsupp", "", "deletedBy is NULL", 3)
                SQLCon.Close()
            End If
            SQLCon.Close()
        End Using
        SQLCon.Close()
        'clrField
        c.clrData(grpSuppInfo)
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        s.loadDTGN(dgvSupplier, "Viewsupp", "", "deletedBy is NULL", 3)
        c.clrData(grpSuppInfo)
        c.clrData(GroupBox14)
        'btnSuppAdd.Enabled = False
    End Sub

    Private Sub btnSuppSearch_click(sender As Object, e As EventArgs) Handles btnSuppSearch.Click
        Dim keyword As String
        keyword = txtSuppSearch.Text
        If keyword = "" Then
            MsgBox("Please enter keyword!", vbOKOnly, caption)
            txtSuppSearch.Select()
            Exit Sub
        Else
            If rdbSuppName.Checked = True Then
                s.searchSupplier("viewSupp", dgvSupplier, keyword, 1)
            ElseIf rdbSuppProvince.Checked = True Then
                s.searchSupplier("viewSupp", dgvSupplier, keyword, 2)
            ElseIf rdbSuppName.Checked = False And rdbSuppProvince.Checked = False Then
                s.searchSupplier("viewSupp", dgvSupplier, keyword, 3)
            End If
        End If
    End Sub
End Class