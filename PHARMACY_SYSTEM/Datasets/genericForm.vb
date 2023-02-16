Public Class genericForm
    '7 in control
    Dim s As New cSQL
    Dim c As New cControl

    'triggers
    Private Sub frmLoad(sender As Object, e As EventArgs) Handles Me.Load
        populate()
    End Sub

    Private Sub addCateg(sender As Object, e As EventArgs) Handles btnAdd.Click
        If txtGeneric.Text = "" Or cmbCategory.SelectedIndex = -1 Then
            MsgBox("Please fill in all fields!")
            Exit Sub
        Else
            Dim genName As String = txtGeneric.Text
            Dim catName As String = cmbCategory.Text
            s.RunQuery("insert into generic(genName,categName) values ('" & genName & "' ,'" & catName & "')")
            MsgBox("Added Successfully!")
            c.clrData(grpGeneric)
            populate()
        End If
    End Sub

    Private Sub del(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim des As Boolean
        point = dgvGeneric.CurrentRow.Index
        id = dgvGeneric.Item(0, point).Value
        Name = dgvGeneric.Item(1, point).Value
        des = c.notif(id, Name)
        If des = True Then
            s.delete(dgvGeneric, "generic", id)
        Else
            Exit Sub
        End If
    End Sub

    'my Functions
    Private Sub populate()
        s.loadDTG(dgvGeneric, "genericView")
        s.loadCBX(cmbCategory, "category", "id", "categName")
    End Sub

    Private Sub purge()
        dgvGeneric.DataSource = Nothing
    End Sub

    Private Sub cmbCategory_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbCategory.SelectedIndexChanged

    End Sub
End Class