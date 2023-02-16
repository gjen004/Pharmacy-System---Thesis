Public Class purchaseOrderAdd
    Dim c As New cControl
    Dim s As New cSQL
    Dim PO As New ivPO
    Private Sub frmLoad(sender As Object, e As EventArgs) Handles MyBase.Load
        populate()
        s.clearTemp("tempOrder")
        txtPOPrice.Enabled = False
        txtPOPrice.Visible = False
        Label6.Visible = False
    End Sub

    Private Sub disregard(sender As Object, e As EventArgs) Handles MyBase.Closing
        Dim count As Integer
        If grpNewPO.Enabled = True Then
            orderNo = Nothing
            prod = Nothing
            quant = Nothing
            price = Nothing
            Exit Sub
        ElseIf grpNewPO.Enabled = False Then
            count = dgvPO.Rows.Count
            If count = 0 Then
                MsgBox("There is no product selected, PO will be disregarded ...", vbOKOnly, caption)
                s.RunQuery("delete from PO where PONum = '" & orderNo & "'")
                s.RunQuery("delete from tempOrder")
            ElseIf count > 0 Then
                MsgBox("There are products selected, PO will be disregarded ...", vbOKOnly, caption)
                s.RunQuery("delete from PO where PONum = '" & orderNo & "'")
                s.RunQuery("delete from tempOrder")
            End If
        End If
    End Sub

    Private Sub BtnCreate_Click(sender As Object, e As EventArgs) Handles btnCreate.Click
        supp = c.getData(cmbPOSupplier)
        orderNo = c.getData(txtPONo)
        createPO = c.getData(datePOOrder)
        needPO = c.getData(datePONeeded)
        remarks = c.getData(txtPORemarks)
        savedBy = username
        If String.IsNullOrEmpty(orderNo) = True Or String.IsNullOrEmpty(createPO) = True Or String.IsNullOrEmpty(needPO) = True Or supp < 1 Then
            If supp = 0 Then
                If s.checkValStr("cmbSupp", "suppname", cmbPOSupplier.Text) = False Then
                    MsgBox("Supplier does not Exist!", vbOKOnly, caption)
                    cmbPOSupplier.Select()
                    cmbPOSupplier.Text = ""
                End If
            Else
                MsgBox("Please Fill In All Fields", vbOKOnly, caption)
                Exit Sub
            End If
        ElseIf IsNumeric(orderNo) = False Then
            MsgBox("Invalid PO Number!", vbOKOnly, caption)
            txtPONo.Select()
            Exit Sub
        ElseIf c.valOrdDate(createPO, needPO) = False Then
            needPO = Nothing
            createPO = Nothing
            Exit Sub
        Else
            If s.checkVal("PO", "PONum", Convert.ToInt32(orderNo)) = True Then
                MsgBox("PO Number already exists!", vbOKOnly, caption)
                txtPONo.Select()
            Else
                PO.createPO(orderNo, supp, createPO, needPO, savedBy, remarks)
                grpNewPO.Enabled = False
                grpPODetails.Enabled = True
                dgvPO.Enabled = True
                btnPOSave.Enabled = False
                btnRemove.Enabled = False
                txtPOPrice.Enabled = False
                txtPOPrice.Text = 0
            End If
        End If
    End Sub

    Private Sub addProducts(sender As Object, e As EventArgs) Handles btnPOAdd.Click
        If grpNewPO.Enabled = True Then
            MsgBox("Create Purchase Order First!", vbOKOnly, caption)
            cmbPOSupplier.Focus()
            Exit Sub
        Else
            orderNo = c.getData(txtPONo)
            prod = c.getData(cmbPOProduct)
            quant = c.getData(txtPOQuantity)
            price = c.getData(txtPOPrice)
            If String.IsNullOrEmpty(quant) = True Or String.IsNullOrEmpty(price) = True Then
                MsgBox("Please Fill In All Fields", vbOKOnly, caption)
                Exit Sub
            ElseIf IsNumeric(quant) = False Then
                MsgBox("Invalid Quantity", vbOKOnly, caption)
                txtPOQuantity.Select()
                Exit Sub
            ElseIf quant <= 0 Then                                  'additional elseif 01/21/2020
                MsgBox("Quantity must be greater than 0!", vbOKOnly, caption)
                txtPOQuantity.Select()
                Exit Sub
                'ElseIf IsNumeric(price) = False Then
                '    MsgBox("Invalid Price", vbOKOnly, caption)
                '    txtPOPrice.Select()
                '    Exit Sub
                'ElseIf price <= 0 Then                                  'additional elseif 01/21/2020
                '    MsgBox("Price must be greater than 0!", vbOKOnly, caption)
                '    txtPOPrice.Select()
                '    Exit Sub
            Else
                If c.checkProdEx(dgvPO, cmbPOProduct.Text) = True Then
                    MsgBox("Item already exists!", vbOKOnly, caption)
                ElseIf prod = 0 Then
                    If s.checkVal("ProductOnSale", "ID", prod) = False Then
                        MsgBox("Product Does Not Exists!", vbOKOnly, caption)
                        cmbPOProduct.Select()
                        Exit Sub
                    End If
                Else

                    PO.addProductsToPO(orderNo, prod, quant, price)
                    s.loadDTGN(dgvPO, "showTempOrder", "", "PONum = " + orderNo, 3)
                    txtPOPrice.Text = 0
                    txtPOQuantity.Text = ""
                    prod = Nothing
                    quant = Nothing
                    price = Nothing
                    cmbPOProduct.Text = ""
                    cmbPOProduct.SelectedIndex = -1
                    btnRemove.Enabled = True
                    btnPOSave.Enabled = True
                End If
            End If
        End If
        dgvPO.Columns(2).Width = 390
        dgvPO.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
    End Sub

    Private Sub hideID(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles dgvPO.DataBindingComplete
        With dgvPO
            .Columns("ID").Visible = False
            .Columns("PONum").Visible = False
            .Columns("unitPrice").Visible = False
            dgvPO.Columns(3).DefaultCellStyle.Format = "#,###"
        End With
    End Sub

    Private Sub removeProduct(sender As Object, e As EventArgs) Handles btnRemove.Click
        Try
            If dgvPO.SelectedRows.Count = 0 Then
                MsgBox("No Item Selected", vbOKOnly, caption)
                Exit Sub
            Else
                orderNo = c.getData(txtPONo)
                Dim message As String = "Are you sure you want to remove item?"
                Dim icons As Integer = MessageBoxIcon.Question
                Dim buttons As Integer = MessageBoxButtons.YesNo
                Dim result As DialogResult
                result = MessageBox.Show(Me, message, caption, buttons, icons)
                If result = DialogResult.Yes Then
                    point = dgvPO.CurrentRow.Index
                    id = dgvPO.Item(0, point).Value
                    s.delete(dgvPO, "tempOrder", id)
                    s.loadDTGN(dgvPO, "showTempOrder", "", "PONum = " + orderNo, 3)
                End If
            End If
        Catch ex As Exception
            Dim msg1 As String = ex.GetType.ToString
            If msg1 = "System.NullReferenceException" Then
                MsgBox("No Item Selected", vbOKOnly, caption)
            End If
        End Try
    End Sub
    Private Sub savePO(sender As Object, e As EventArgs) Handles btnPOSave.Click
        dgvPO.Rows(0).Selected = True
        orderNo = c.getData(txtPONo)
        For index As Integer = 0 To c.countDtgItem(dgvPO)
            PO.savePO(orderNo, s.getProdID(dgvPO.Item(2, index).Value), dgvPO.Item(3, index).Value, dgvPO.Item(4, index).Value)
        Next
        c.clrData(grpNewPO)
        c.clrData(grpPODetails)
        c.clrDS(dgvPO)
        s.clearTemp("tempOrder")
        grpNewPO.Enabled = True
        orderNo = Nothing
        c.setTrueFalse(Me, dgvPO, grpPODetails)
        MsgBox("Purchase Order Saved!", vbOKOnly, caption)
    End Sub

    'loading stuffs
    Private Sub populate()
        s.loadCBXN(cmbPOSupplier, "supplier", "ID", "suppName", "where deletedBy is NULL")
        s.loadCBX(cmbPOProduct, "ProductOnSale", "ID", "Product")
        c.formatDTP(datePOOrder, datePONeeded)
        c.setTrueFalse(Me, dgvPO, grpPODetails)
        btnPOSave.Enabled = False
    End Sub

    'fixes
    Private Sub FormRefresh(sender As Object, e As EventArgs) Handles btnRefresh.Click
        If dgvPO.Rows.Count > 0 Then
            Dim result As DialogResult
            result = MessageBox.Show(Me, "There are Products Selected, Refresh Form?", caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result = DialogResult.Yes Then
                s.clearTemp("tempOrder")
                s.RunQuery("delete from PO where PONum = '" & txtPONo.Text & "'")
                c.clrData(grpNewPO)
                c.clrData(grpPODetails)
                c.clrDS(dgvPO)
                c.setTrueFalse(Me, dgvPO, grpPODetails)
                orderNo = Nothing
                btnPOSave.Enabled = False
                grpNewPO.Enabled = True
                Exit Sub
            Else

                Exit Sub
            End If
        Else
            s.clearTemp("tempOrder")
            s.RunQuery("delete from PO where PONum = '" & txtPONo.Text & "'")
            c.clrData(grpNewPO)
            c.clrData(grpPODetails)
            c.clrDS(dgvPO)
            c.setTrueFalse(Me, dgvPO, grpPODetails)
            orderNo = Nothing
            btnPOSave.Enabled = False
            grpNewPO.Enabled = True

            Exit Sub
        End If
    End Sub
End Class
