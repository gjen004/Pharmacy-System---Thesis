Public Class promoForm
    Dim c As New cControl
    Dim s As New cSQL

    Private Sub frmLoad(sender As Object, e As EventArgs) Handles MyBase.Load
        s.loadDTG(dgvPromo, "promo")
        s.loadCBX(cmbProd, "viewPromoProd", "ID", "Product")
        c.setTrueFalse(Me, dgvPromo, Nothing)
        c.formatDTP(dtpStart, dtpEnd)
    End Sub

    Private Sub hideID(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles dgvPromo.DataBindingComplete
        With dgvPromo
            .Columns("ID").Visible = False
        End With
    End Sub

    Private Sub addPromo(sender As Object, e As EventArgs) Handles btnAdd.Click
        promoName = c.getData(txtDiscount)
        startDT = c.getData(dtpStart)
        endDT = c.getData(dtpEnd)
        percentDsc = c.getData(txtPercent)
        prodID = c.getData(cmbProd)
        savedBy = "coder"
        s.addPromo(dgvPromo, "promo", prodID, startDT, endDT, percentDsc, savedBy, promoName)
    End Sub

    Private Sub delPromo(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim des As Boolean
        point = dgvPromo.CurrentRow.Index
        id = dgvPromo.Item(0, point).Value
        promoName = dgvPromo.Item(1, point).Value
        des = c.notif(id, promoName)
        If des = True Then
            s.delete(dgvPromo, "promo", id)
        Else
            Exit Sub
        End If
    End Sub

End Class