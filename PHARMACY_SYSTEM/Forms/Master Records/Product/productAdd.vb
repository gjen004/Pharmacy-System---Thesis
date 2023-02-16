Imports System.Data.Sql
Imports System.Data.SqlClient

'fixes
'line 94 - 105 added trapping in combo boxes

Public Class productAdd
    Dim s As New cSQL
    Dim c As New cControl

    Private Sub frmLoad(sender As Object, e As EventArgs) Handles MyBase.Load
        'SQLCon.Open()
        'Dim quer As String = "select max(ID) from product"
        'Dim cmd As SqlCommand = New SqlCommand(quer, SQLCon)
        'Using reader As SqlDataReader = cmd.ExecuteReader
        '    While reader.Read
        '        code = reader("ID")
        '    End While
        '    reader.Close()
        'End Using
        'SQLCon.Close()

        'txtProdCode.Text = "RP-" & (code + 1).ToString
        'txtProdCode.Enabled = False

        populate()
        MyBase.MinimizeBox = False
        MyBase.MaximizeBox = False
        dgvProduct.AllowUserToAddRows = False
        dgvProduct.ClearSelection()
        c.clrData(grpProdSearch)
        c.clrData(grpProductInfo)
        'btnProdAdd.Enabled = False                                                                            TINANGGAL KO LAHAT btnProdAdd.Enabled = False

    End Sub

    Private Sub addProduct(sender As Object, e As EventArgs) Handles btnProdAdd.Click
        getValAdd()
    End Sub

    Private Sub clr(sender As Object, e As EventArgs) Handles btnProdRefresh.Click
        c.clrData(grpProductInfo)
        c.clrData(grpProdSearch)
        'btnProdAdd.Enabled = False
        populate()
    End Sub

    Private Sub genericcmb(sender As Object, e As EventArgs) Handles cmbProdCategory.SelectedIndexChanged
        s.loadCBXN(cmbGenName, "genericview", "ID", "Generic Names", "where [Category] like '" & cmbProdCategory.Text & "'")
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
        s.loadDTGN(dgvProduct, "viewproduct", "", "[Status] = 'ACTIVE' and deletedBy is NULL order by [Product Code]", 3)
    End Sub

    'Private Sub enableAdd(sender As Object, e As EventArgs) Handles cmbProdStatus.SelectedIndexChanged                        
    '    If txtProdCode.Text = "" And cmbProdCategory.SelectedIndex = 0 And txtProdBrandName.Text = "" And cmbGenName.SelectedIndex = 0 And cmbProdDosage.SelectedIndex = 0 And cmbProdForm.SelectedIndex = 0 And cmbProdUnit.SelectedIndex = 0 And cmbProdStatus.SelectedIndex = 0 Then
    '        btnProdAdd.Enabled = False
    '    Else
    '        btnProdAdd.Enabled = True                                                                           TINANGGAL KO TO PRE BUONG PRIVATE SUB. 01/03/2020
    '    End If
    'End Sub

    Private Sub getValAdd()
        'getData                                                           
        'prodCode = c.getData(txtProdCode).ToString.ToUpper
        'categID = c.getData(cmbProdCategory)
        'brndName = c.getData(txtProdBrandName).ToString.ToUpper                                                 NILIPAT KO TO SA ELSE PRE  01/03/2020
        'genID = c.getData(cmbGenName)
        'dID = c.getData(cmbProdDosage)
        'fID = c.getData(cmbProdForm)
        'pUnit = c.getData(cmbProdUnit)
        'statID = c.getData(cmbProdStatus).ToString.ToUpper
        'temp = "user"

        SQLCon.Open()
        Dim checkQuery1 As String = "select * from product where proCode = '" & txtProdCode.Text & "'"
        Dim checkQuery2 As String = "select * from viewProduct where Category = '" & cmbProdCategory.Text & "' and [Generic Name] = '" & cmbGenName.Text & "' and [Brand Name] = '" & txtProdBrandName.Text & "' and Unit = '" & cmbProdUnit.Text & "' and Dosage = '" & cmbProdDosage.Text & "' and Form = '" & cmbProdForm.Text & "' and deletedBy is NULL"
        Dim cmd As SqlCommand = New SqlCommand(checkQuery1, SQLCon)
        Using reader As SqlDataReader = cmd.ExecuteReader()
            'If String.IsNullOrEmpty(prodCode) = True Or String.IsNullOrEmpty(brndName) = True Or String.IsNullOrEmpty(temp) = True Or categID < 1 Or genID < 1 Or dID < 1 Or fID < 1 Or pUnit < 1 Or statID < 1 Then
            '    MsgBox("Please Fill In All Fields")
            '    Exit Sub                                                                                        TINANGGAL KO TONG "FILL IN ALL FIELDS"  01/03/2020
            '    SQLCon.Close()
            'If reader.HasRows Then
            '    'SQLCon.Close()
            '    MsgBox("Invalid Input! Product Code already exist!")                                            NILIPAT KO SA ELSEIF  01/03/2020
            '    'btnProdAdd.Enabled = True
            '    SQLCon.Close()
            '    reader.Close()
            '    Exit Sub
            If txtProdCode.Text = "" Then
                reader.Close()
                SQLCon.Close()
                MsgBox("Please enter Product Code!", buttons, caption)                                                             'DINAGDAG KO TONG IF  01/03/2020
                txtProdCode.Select()
                Exit Sub
            ElseIf reader.HasRows Then
                'SQLCon.Close()
                MsgBox("Invalid Input! Product Code already exists!", buttons, caption)
                txtProdCode.Select()
                'btnProdAdd.Enabled = True                                                                       
                SQLCon.Close()
                reader.Close()
                Exit Sub
            ElseIf cmbProdCategory.SelectedIndex = -1 Then                                                       'PINALITAN KO NG .SelectedIndex = -1 yung mga condition  01/03/2020
                SQLCon.Close()
                reader.Close()
                MsgBox("ERROR! No CATEGORY Selected or Item Does Not Exist on the List!", buttons, caption)
                cmbProdCategory.Select()
                Exit Sub
                'ElseIf s.checkValStr("category", "categName", cmbProdCategory.Text) Then
                '    SQLCon.Close()
                '    reader.Close()
                '    MsgBox("Category Does not Exist!")
                '    Exit Sub
            ElseIf txtProdBrandName.Text = "" Then                                                                'DINAGDAG KO TO PARA SA BRAND NAME  01/03/2020
                SQLCon.Close()
                reader.Close()
                MsgBox("Please enter Brand Name!", buttons, caption)
                txtProdBrandName.Select()
                Exit Sub
            ElseIf cmbGenName.SelectedIndex = -1 Then
                SQLCon.Close()
                reader.Close()
                MsgBox("ERROR! No GENERIC Name Selected or Item Does Not Exist on the List!", buttons, caption)
                cmbGenName.Select()
                Exit Sub
            ElseIf cmbProdDosage.SelectedIndex = -1 Then
                SQLCon.Close()
                reader.Close()
                MsgBox("ERROR! No Product DOSAGE Selected or Item Does Not Exist on the List!", buttons, caption)
                cmbProdDosage.Select()
                Exit Sub
            ElseIf cmbProdUnit.SelectedIndex = -1 Then
                SQLCon.Close()
                reader.Close()
                MsgBox("ERROR! No Product UNIT Selected or Item Does Not Exist on the List!", buttons, caption)
                cmbProdUnit.Select()
                Exit Sub
            ElseIf cmbProdForm.SelectedIndex = -1 Then
                SQLCon.Close()
                reader.Close()
                MsgBox("ERROR! No Product FORM Selected or Item Does Not Exist on the List!", buttons, caption)
                cmbProdForm.Select()
                Exit Sub
                'ElseIf txtSellprice.Text = "" Then
                '    SQLCon.Close()
                '    reader.Close()
                '    MsgBox("Please enter Selling Price!", vbOKOnly, caption)
                '    txtSellprice.Select()
                '    Exit Sub
                'ElseIf IsNumeric(txtSellprice.Text) = False Then
                '    SQLCon.Close()
                '    reader.Close()
                '    MsgBox("Selling Price must be numeric!", vbOKOnly, caption)
                '    txtSellprice.Select()
                '    Exit Sub
                'ElseIf txtSellprice.Text < 1 Then
                '    SQLCon.Close()
                '    reader.Close()
                '    MsgBox("Selling Price must be higher than 0!", vbOKOnly, caption)
                '    txtSellprice.Select()
                '    Exit Sub
            ElseIf cmbProdStatus.SelectedIndex = -1 Then
                SQLCon.Close()
                reader.Close()
                MsgBox("Invalid Input! No such status exists!", buttons, caption)
                cmbProdStatus.Select()
                Exit Sub
            Else
                SQLCon.Close()
                'empName = s.getName()
                empName = s.GetDetailStr("employeeView", "EmployeeName", "userName", username)
                prodCode = c.getData(txtProdCode).ToString.ToUpper
                categID = c.getData(cmbProdCategory)
                brndName = c.getData(txtProdBrandName).ToString.ToUpper
                genID = c.getData(cmbGenName)
                dID = c.getData(cmbProdDosage)
                fID = c.getData(cmbProdForm)
                pUnit = c.getData(cmbProdUnit)
                'sellPrice = c.getData(txtSellprice)
                statID = c.getData(cmbProdStatus).ToString.ToUpper
                savedBy = empName
                SQLCon.Open()
                Dim cmd2 As SqlCommand = New SqlCommand(checkQuery2, SQLCon)
                Using reader2 As SqlDataReader = cmd2.ExecuteReader()
                    If reader2.HasRows Then
                        MsgBox("Product is already existing in the Master List!", buttons, caption)
                        reader2.Close()
                        SQLCon.Close()
                        Exit Sub
                    Else
                        SQLCon.Close()
                        reader.Close()
                        reader2.Close()
                        s.addProduct(dgvProduct, "product", prodCode, categID, brndName, genID, dID, pUnit, fID, statID, savedBy, btnProdAdd)
                        SQLCon.Close()
                        'txtProdCode.Text = "RP-" & (code + 1).ToString
                        c.clrData(grpProductInfo)
                        populate()
                        SQLCon.Close()
                        'btnProdAdd.Enabled = False
                    End If
                    reader2.Close()
                    SQLCon.Close()
                End Using
                SQLCon.Close()
                SQLCon.Close()
                SQLCon.Close()
            End If
            SQLCon.Close()
            reader.Close()
            SQLCon.Close()
        End Using
        SQLCon.Close()
        'addData
        'magkalaman. magkalaman, magkalalaman
        'c.clrData(GroupBox9)
    End Sub

    Private Sub btnProdSearch_Click(sender As Object, e As EventArgs) Handles btnProdSearch.Click
        Dim keyword As String
        keyword = txtProdSearch.Text
        If keyword = "" Then
            MsgBox("Please enter keyword!", buttons, caption)
            txtProdSearch.Select()
            Exit Sub
        Else
            If rdbProdCode.Checked = True Then
                s.searchProduct("product", dgvProduct, keyword, 1)
            ElseIf rdbProdBrandName.Checked = True Then
                s.searchProduct("product", dgvProduct, keyword, 2)
            ElseIf rdbProdBrandName.Checked = False And rdbProdCode.Checked = False Then
                s.searchProduct("product", dgvProduct, keyword, 3)
            End If
        End If
    End Sub

    Private Sub hideID(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles dgvProduct.DataBindingComplete
        With dgvProduct
            .Columns("ID").Visible = False
            .Columns("deletedby").Visible = False
            dgvProduct.ClearSelection()
        End With
    End Sub
End Class