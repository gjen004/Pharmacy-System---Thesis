Public Class productUpdate

    Dim s As New cSQL
    Dim c As New cControl

    Private Sub frmLoad(sender As Object, e As EventArgs) Handles MyBase.Load
        populate()
        MyBase.MinimizeBox = False
        MyBase.MaximizeBox = False
        dgvProduct.AllowUserToAddRows = False
        btnSave.Enabled = False
        txtProdCode.Enabled = False
        grpProductInfo.Enabled = False
        rdbProdBrandName.Checked = False
        rdbProdCode.Checked = False
        dgvProduct.ClearSelection()
        c.clrData(grpProdSearch)
        c.clrData(grpProductInfo)

    End Sub

    'Private Sub enableSave(sender As Object, e As EventArgs) Handles cmbGenName.SelectedIndexChanged
    '    If txtProdCode.Text = "" And cmbProdCategory.SelectedIndex = 0 And txtProdBrandName.Text = "" And cmbGenName.SelectedIndex = 0 And cmbProdDosage.SelectedIndex = 0 And cmbProdForm.SelectedIndex = 0 And cmbProdUnit.SelectedIndex = 0 And cmbProdStatus.SelectedIndex = 0 Then
    '        btnSave.Enabled = False
    '    Else
    '        btnSave.Enabled = True
    '    End If
    'End Sub

    Private Sub dtgFocus(sender As Object, e As EventArgs) Handles dgvProduct.MouseClick
        point = dgvProduct.CurrentRow.Index
        c.loadDataProdUpdate(point, dgvProduct, txtProdCode, cmbProdCategory, txtProdBrandName, cmbGenName, cmbProdDosage, cmbProdUnit, cmbProdForm, cmbProdStatus)
        's.loadCBXN(cmbGenName, "generic", "ID", "genName", "where categName like '" & cmbProdCategory.Text & "'")
        grpProductInfo.Enabled = True
        txtProdCode.Enabled = False
        point = Nothing
        btnSave.Enabled = True
        Exit Sub
    End Sub

    Private Sub cmbGenericChange(sender As Object, e As EventArgs) Handles cmbProdCategory.SelectedIndexChanged
        s.loadCBXN(cmbGenName, "genericview", "ID", "Generic Names", "where [Category] like '" & cmbProdCategory.Text & "'")
    End Sub

    Private Sub hideID(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles dgvProduct.DataBindingComplete
        With dgvProduct
            .Columns("ID").Visible = False
            .Columns("deletedBy").Visible = False
            dgvProduct.ClearSelection()

        End With
    End Sub

    Private Sub upProd(sender As Object, e As EventArgs) Handles btnSave.Click, btnSave.Enter
        'getLoc
        point = dgvProduct.CurrentRow.Index
        'getData
        id = dgvProduct.Item(0, point).Value
        Convert.ToInt32(id)
        'prodCode = c.getData(txtProdCode)
        'categID = c.getData(cmbProdCategory).ToString.ToUpper
        'brndName = c.getData(txtProdBrandName).ToString.ToUpper
        'genID = c.getData(cmbGenName).ToString.ToUpper
        ''dID = c.getData(cmbProdDosage)
        'fID = c.getData(cmbProdForm).ToString.ToUpper
        'pUnit = c.getData(cmbProdUnit)
        'statID = c.getData(cmbProdStatus).ToString.ToUpper
        'temp = "user2"
        'pass values
        'If String.IsNullOrEmpty(prodCode) = True Or String.IsNullOrEmpty(brndName) = True Or String.IsNullOrEmpty(temp) = True Or categID < 1 Or genID < 1 Or dID < 1 Or fID < 1 Or pUnit < 1 Or statID < 1 Then
        '    MsgBox("Please Fill In All Fields")
        '    Exit Sub
        If cmbProdCategory.SelectedIndex = -1 Then                                                       'PINALITAN KO NG .SelectedIndex = -1 yung mga condition  01/03/2020
            SQLCon.Close()
            MsgBox("ERROR! No CATEGORY Selected or Item Does Not Exist on the List!", vbOKOnly, caption)
            cmbProdCategory.Select()
            Exit Sub
        ElseIf txtProdBrandName.Text = "" Then                                                                'DINAGDAG KO TO PARA SA BRAND NAME  01/03/2020
            SQLCon.Close()
            MsgBox("Please enter Brand Name!", vbOKOnly, caption)
            txtProdBrandName.Select()
            Exit Sub
        ElseIf cmbGenName.SelectedIndex = -1 Then
            SQLCon.Close()
            MsgBox("ERROR! No GENERIC Name Selected or Item Does Not Exist on the List!", vbOKOnly, caption)
            cmbGenName.Select()
            Exit Sub
        ElseIf cmbProdDosage.SelectedIndex = -1 Then
            SQLCon.Close()
            MsgBox("ERROR! No Product Dosage Selected or Item Does Not Exist on the List!", vbOKOnly, caption)
            cmbProdDosage.Select()
            Exit Sub
        ElseIf cmbProdForm.SelectedIndex = -1 Then
            SQLCon.Close()
            MsgBox("ERROR! No Product Form Selected or Item Does Not Exist on the List!", vbOKOnly, caption)
            cmbProdForm.Select()
            Exit Sub
        ElseIf cmbProdUnit.SelectedIndex = -1 Then
            SQLCon.Close()
            MsgBox("ERROR! No Product Unit Selected or Item Does Not Exist on the List!", vbOKOnly, caption)
            cmbProdUnit.Select()
            Exit Sub
        ElseIf cmbProdStatus.SelectedIndex = -1 Then
            SQLCon.Close()
            MsgBox("Invalid Input! No such status exists!", vbOKOnly, caption)
            cmbProdStatus.Select()
            Exit Sub
        Else
            'empName = s.getName()
            empName = s.GetDetailStr("employeeView", "EmployeeName", "userName", username)
            prodCode = c.getData(txtProdCode)
            categID = c.getData(cmbProdCategory).ToString.ToUpper
            brndName = c.getData(txtProdBrandName).ToString.ToUpper
            genID = c.getData(cmbGenName).ToString.ToUpper
            dID = c.getData(cmbProdDosage)
            fID = c.getData(cmbProdForm).ToString.ToUpper
            pUnit = c.getData(cmbProdUnit)
            'sellPrice = c.getData(txtSellPrice)
            statID = c.getData(cmbProdStatus).ToString.ToUpper
            temp = empName

            s.updProd(id, dgvProduct, "product", prodCode, categID, brndName, genID, dID, pUnit, fID, statID, temp, btnSave)
            s.loadDTGN(dgvProduct, "viewproduct", "", "deletedBy is NULL", 3)
        End If
        c.clrData(grpProdSearch)
        c.clrData(grpProductInfo)
        btnSave.Enabled = False
        grpProductInfo.Enabled = False
    End Sub

    Private Sub populate()
        dgvProduct.DataSource = Nothing
        'populate cbx's
        's.loadCBX(cmbGenName, "generic", "ID", "genName")
        s.loadCBX(cmbProdCategory, "category", "ID", "categName")
        s.loadCBX(cmbProdDosage, "dosage", "ID", "dsgName")
        s.loadCBX(cmbProdForm, "form", "ID", "formName")
        s.loadCBX(cmbProdStatus, "pStatus", "ID", "stat")
        s.loadCBX(cmbProdUnit, "productUnit", "ID", "unitMsr")

        'populate DTG
        s.loadDTGN(dgvProduct, "viewproduct", "", "deletedBy is NULL order by [Product Code]", 3)
    End Sub

    Private Sub btnProdClear_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        c.clrData(grpProductInfo)
        c.clrData(grpProdSearch)
        grpProductInfo.Enabled = False
        btnSave.Enabled = False
        populate()
    End Sub

    Private Sub btnProdSearch_Click(sender As Object, e As EventArgs) Handles btnProdSearch.Click
        Dim keyword As String
        keyword = txtProdSearch.Text
        If keyword = "" Then
            MsgBox("Please enter keyword!", vbOKOnly, caption)
            txtProdSearch.Select()
            Exit Sub
        Else
            If rdbProdCode.Checked = True Then
                s.searchProductToUpdate("product", dgvProduct, keyword, 1)
            ElseIf rdbProdBrandName.Checked = True Then
                s.searchProductToUpdate("product", dgvProduct, keyword, 2)
            ElseIf rdbProdBrandName.Checked = False And rdbProdCode.Checked = False Then
                s.searchProductToUpdate("product", dgvProduct, keyword, 3)
            End If
        End If
    End Sub
End Class