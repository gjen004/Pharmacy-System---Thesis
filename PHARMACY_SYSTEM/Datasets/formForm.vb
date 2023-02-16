Public Class formForm
    '6 in control

    Dim s As New cSQL
    Dim c As New cControl

    'triggers
    Private Sub frmLoad(sender As Object, e As EventArgs) Handles Me.Load
        populate()
    End Sub

    Private Sub hideID(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles dgvForm.DataBindingComplete
        With dgvForm
            .Columns("ID").Visible = False
        End With
    End Sub

    Private Sub addCateg(sender As Object, e As EventArgs) Handles btnAdd.Click
        s.addToDataByTXT(txtForm, dgvForm, 6)
    End Sub

    Private Sub del(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim des As Boolean
        point = dgvForm.CurrentRow.Index
        id = dgvForm.Item(0, point).Value
        Name = dgvForm.Item(1, point).Value
        des = c.notif(id, Name)
        If des = True Then
            s.delete(dgvForm, "form", id)
        Else
            Exit Sub
        End If
    End Sub

    'my Functions
    Private Sub populate()
        s.loadDTG(dgvForm, "form")
    End Sub

    Private Sub purge()
        dgvForm.DataSource = Nothing
    End Sub

End Class