Public Class dosageForm
    '5 in control
    Dim s As New cSQL
    Dim c As New cControl
    'triggers
    Private Sub frmLoad(sender As Object, e As EventArgs) Handles Me.Load
        populate()
    End Sub

    Private Sub hideID(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles dgvDosage.DataBindingComplete
        With dgvDosage
            .Columns("ID").Visible = False
        End With
    End Sub

    Private Sub addCateg(sender As Object, e As EventArgs) Handles btnAdd.Click
        s.addToDataByTXT(txtDosage, dgvDosage, 5)
    End Sub

    Private Sub del(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim des As Boolean
        point = dgvDosage.CurrentRow.Index
        id = dgvDosage.Item(0, point).Value
        Name = dgvDosage.Item(1, point).Value
        des = c.notif(id, Name)
        If des = True Then
            s.delete(dgvDosage, "dosage", id)
        Else
            Exit Sub
        End If
    End Sub

    'my Functions
    Private Sub populate()
        s.loadDTG(dgvDosage, "dosage")
    End Sub

    Private Sub purge()
        dgvDosage.DataSource = Nothing
    End Sub
End Class