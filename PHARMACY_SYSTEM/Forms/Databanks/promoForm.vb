Public Class promoForm
    Dim c As New cControl
    Dim s As New cSQL

    Private Sub frmLoad(sender As Object, e As EventArgs) Handles MyBase.Load
        s.loadDTGN(dgvPromo, "promoView", "", "voidBy is NULL", 3)
        s.loadCBXN(cmbProProd, "viewFullProd", "ID", "Product", "where Status = 'ACTIVE' and deletedBy is NULL")
        c.setTrueFalse(Me, dgvPromo, Nothing)
        c.formatDTP(dtpStart, dtpEnd)
        dgvPromo.Columns(6).DefaultCellStyle.Format = "MM/dd/yyyy"
        dgvPromo.Columns(7).DefaultCellStyle.Format = "MM/dd/yyyy"
    End Sub

    Private Sub hideID(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles dgvPromo.DataBindingComplete
        With dgvPromo
            .Columns("ID").Visible = False
            .Columns("voidBy").Visible = False
            dgvPromo.ClearSelection()
        End With
    End Sub

    Private Sub addPromo(sender As Object, e As EventArgs) Handles btnAdd.Click
        startDT = c.getData(dtpStart)
        endDT = c.getData(dtpEnd)
        If txtPromoName.Text = "" Then
            MsgBox("Please enter Promo Name!", vbOKOnly, caption)
            txtPromoName.Select()
            Exit Sub
        ElseIf cmbProProd.SelectedIndex = -1 Then
            MsgBox("No Promo Product Selected!", vbOKOnly, caption)
            cmbProProd.Select()
            Exit Sub
        ElseIf txtMinQty.Text = "" Then
            MsgBox("Please enter Minimum Purchase!", vbOKOnly, caption)
            txtMinQty.Select()
            Exit Sub
        ElseIf IsNumeric(txtMinQty.Text) = False Then
            MsgBox("Minimum Purchase must be numeric!", vbOKOnly, caption)
            txtMinQty.Select()
            Exit Sub
            'ElseIf cmbFrProd.SelectedIndex = -1 Then
            '    MsgBox("No Free Product Selected", vbOKOnly, caption)
            '    cmbFrProd.Select()
            '    Exit Sub
        ElseIf txtFrQty.Text = "" Then
            MsgBox("Please enter Free Quantity!", vbOKOnly, caption)
            txtFrQty.Select()
            Exit Sub
        ElseIf IsNumeric(txtFrQty.Text) = False Then
            MsgBox("Free Quantity must be numeric!", vbOKOnly, caption)
            txtFrQty.Select()
            Exit Sub
        ElseIf startDT >= endDT Then
            MsgBox("Ending date must be greater than the Starting Date!", vbOKOnly, caption)
            dtpStart.Select()
            Exit Sub
        Else
            promoName = c.getData(txtPromoName).ToString.ToUpper
            startDT = c.getData(dtpStart)
            endDT = c.getData(dtpEnd)
            prodID = c.getData(cmbProProd)
            minQty = c.getData(txtMinQty)
            'frProdID = c.getData(cmbFrProd)
            frQty = c.getData(txtFrQty)
            savedBy = s.GetDetailStr("employeeView", "EmployeeName", "userName", username)
            s.addPromo(dgvPromo, "promo", prodID, startDT, endDT, minQty, frQty, savedBy, promoName)
            c.clrData(GroupBox1)
        End If
    End Sub

    Private Sub btnVoid_Click(sender As Object, e As EventArgs) Handles btnVoid.Click
        point = dgvPromo.CurrentRow.Index
        id = dgvPromo.Item(0, point).Value
        empName = s.GetDetailStr("employeeView", "EmployeeName", "userName", username)
        s.RunQuery("Update promo set voidBy = '" & empName & "', voidDT = GETDATE() where ID = '" & id & "'")
        MsgBox("Promo Voided!", vbOKOnly, caption)
        s.loadDTGN(dgvPromo, "promoView", "", "voidBy is NULL", 3)
        c.clrData(GroupBox1)
    End Sub

    'Private Sub delPromo(sender As Object, e As EventArgs) Handles btnDelete.Click
    ''    Dim des As Boolean
    ''    point = dgvPromo.CurrentRow.Index
    ''    id = dgvPromo.Item(0, point).Value
    ''    promoName = dgvPromo.Item(1, point).Value
    ''    des = c.notif(id, promoName)
    ''    If des = True Then
    ''        s.delete(dgvPromo, "promo", id)
    ''    Else
    ''        Exit Sub
    ''    End If
    ''End Sub

End Class