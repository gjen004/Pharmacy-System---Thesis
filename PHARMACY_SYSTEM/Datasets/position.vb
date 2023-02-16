Public Class position
    Dim s As New cSQL
    Dim c As New cControl

    Private Sub hideID(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles dgvPosition.DataBindingComplete
        With dgvPosition
            .Columns("ID").Visible = False
        End With
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        s.addToDataByTXT(txtCategory, dgvPosition, 11)
    End Sub

    Private Sub del(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim des As Boolean
        point = dgvPosition.CurrentRow.Index
        id = dgvPosition.Item(0, point).Value
        Name = dgvPosition.Item(1, point).Value
        des = c.notif(id, Name)
        If des = True Then
            s.delete(dgvPosition, "empPosition", id)
        Else
            Exit Sub
        End If
    End Sub

    Private Sub populate()
        s.loadDTG(dgvPosition, "empPosition")
    End Sub

    Private Sub purge()
        dgvPosition.DataSource = Nothing
    End Sub

    Private Sub position_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        s.loadDTG(dgvPosition, "empPosition")
    End Sub
End Class