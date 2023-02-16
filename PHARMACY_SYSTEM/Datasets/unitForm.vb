Public Class unitForm
    '9 in control
    Dim s As New cSQL
    Dim c As New cControl

    'triggers
    Private Sub frmLoad(sender As Object, e As EventArgs) Handles Me.Load
        populate()
    End Sub

    Private Sub hideID(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles dgvUnit.DataBindingComplete
        With dgvUnit
            .Columns("ID").Visible = False
        End With
    End Sub

    Private Sub addCateg(sender As Object, e As EventArgs) Handles btnAdd.Click
        s.addToDataByTXT(txtUnit, dgvUnit, 9)
    End Sub

    Private Sub del(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim des As Boolean
        point = dgvUnit.CurrentRow.Index
        id = dgvUnit.Item(0, point).Value
        Name = dgvUnit.Item(1, point).Value
        des = c.notif(id, Name)
        If des = True Then
            s.delete(dgvUnit, "productUnit", id)
        Else
            Exit Sub
        End If
    End Sub

    'my Functions
    Private Sub populate()
        s.loadDTG(dgvUnit, "productUnit")
    End Sub
End Class