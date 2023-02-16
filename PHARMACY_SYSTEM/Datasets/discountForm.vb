Public Class discountForm
    Dim c As New cControl
    Dim s As New cSQL

    Private Sub frmLoad(sender As Object, e As EventArgs) Handles MyBase.Load
        s.loadDTG(dgvDiscount, "discount")
    End Sub

    Private Sub hideID(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles dgvDiscount.DataBindingComplete
        With dgvDiscount
            .Columns("ID").Visible = False
        End With
    End Sub

    Private Sub addDscnt(sender As Object, e As EventArgs) Handles btnAdd.Click
        dscName = c.getData(txtDiscount)
        percent = c.getData(txtPercent)
        s.addDsc(dgvDiscount, "discount", dscName, percent)
        c.clrData(GroupBox1)
    End Sub

    Private Sub delDscnt(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim des As Boolean
        point = dgvDiscount.CurrentRow.Index
        id = dgvDiscount.Item(0, point).Value
        dscName = dgvDiscount.Item(1, point).Value
        des = c.notif(id, dscName)
        If des = True Then
            s.delete(dgvDiscount, "discount", id)
        Else
            Exit Sub
        End If
    End Sub

End Class