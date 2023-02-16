Public Class cityForm
    '3 in control
    Dim s As New cSQL
    Dim c As New cControl
    'triggers
    Private Sub frmLoad(sender As Object, e As EventArgs) Handles Me.Load
        populate()
    End Sub

    Private Sub hideID(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles dgvCity.DataBindingComplete
        With dgvCity
            .Columns("ID").Visible = False
        End With
    End Sub

    Private Sub addCateg(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim prov As String = cmbProvince.Text
        Dim city As String = txtCity.Text
        s.RunQuery("insert into city values ('" & city & "' ,'" & prov & "')")
        MsgBox("Added Successfully!")
        s.loadDTG(dgvCity, "cityview")
        cmbProvince.SelectedIndex = -1
        txtCity.Text = ""
    End Sub

    Private Sub del(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim des As Boolean
        point = dgvCity.CurrentRow.Index
        id = dgvCity.Item(0, point).Value
        Name = dgvCity.Item(1, point).Value
        des = c.notif(id, Name)
        If des = True Then
            s.delete(dgvCity, "city", id)
            s.loadDTG(dgvCity, "cityview")
        Else
            Exit Sub
        End If
    End Sub

    'my Functions
    Private Sub populate()
        s.loadDTG(dgvCity, "cityview")
        s.loadCBX(cmbProvince, "province", "ID", "provinceName")
    End Sub

    Private Sub purge()
        dgvCity.DataSource = Nothing
    End Sub
End Class