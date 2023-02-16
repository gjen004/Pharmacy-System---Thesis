Public Class provinceForm
    '8 in control
    Dim s As New cSQL
    Dim c As New cControl

    'triggers
    Private Sub frmLoad(sender As Object, e As EventArgs) Handles Me.Load
        populate()
    End Sub

    Private Sub hideID(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles dgvProvince.DataBindingComplete
        With dgvProvince
            .Columns("ID").Visible = False
        End With
    End Sub

    Private Sub addCateg(sender As Object, e As EventArgs) Handles btnAdd.Click
        s.addToDataByTXT(txtProvince, dgvProvince, 8)
    End Sub

    Private Sub del(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim des As Boolean
        point = dgvProvince.CurrentRow.Index
        id = dgvProvince.Item(0, point).Value
        Name = dgvProvince.Item(1, point).Value
        des = c.notif(id, Name)
        If des = True Then
            s.delete(dgvProvince, "province", id)
        Else
            Exit Sub
        End If
    End Sub

    'my Functions
    Private Sub populate()
        s.loadDTG(dgvProvince, "province")
    End Sub

    Private Sub purge()
        dgvProvince.DataSource = Nothing
    End Sub
End Class