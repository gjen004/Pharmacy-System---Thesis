Public Class reasonForm

    Dim c As New cControl
    Dim s As New cSQL

    Private Sub frmLoad(sender As Object, e As EventArgs) Handles MyBase.Load
        s.loadDTG(dgvReason, "reason")
    End Sub

    Private Sub hideID(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles dgvReason.DataBindingComplete
        With dgvReason
            .Columns("ID").Visible = False
        End With
    End Sub

    Private Sub addReason(sender As Object, e As EventArgs) Handles btnAdd.Click
        s.addToDataByTXT(txtReason, dgvReason, 10)
    End Sub

    Private Sub delRes(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim des As Boolean
        point = dgvReason.CurrentRow.Index
        id = dgvReason.Item(0, point).Value
        Name = dgvReason.Item(1, point).Value
        des = c.notif(id, Name)
        If des = True Then
            s.delete(dgvReason, "dosage", id)
        Else
            Exit Sub
        End If
    End Sub

End Class