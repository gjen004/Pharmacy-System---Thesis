Public Class cityForm
    '3 in control
    Dim s As New cSQL
    Dim c As New cControl
    'triggers
    Private Sub frmLoad(sender As Object, e As EventArgs) Handles Me.Load
        txtCity.Enabled = False
        btnUpdate.Enabled = False
        dgvCity.CurrentCell = Nothing
        populate()
    End Sub

    Private Sub hideID(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles dgvCity.DataBindingComplete
        With dgvCity
            .Columns("ID").Visible = False
            dgvCity.ClearSelection()
        End With
    End Sub

    Private Sub enableText(sender As Object, e As EventArgs) Handles cmbProvince.SelectedIndexChanged
        If cmbProvince.SelectedIndex = -1 Then
            txtCity.Enabled = False
        Else
            txtCity.Enabled = True
        End If
    End Sub

    'Private Sub enableAdd(sender As Object, e As EventArgs) Handles txtCity.KeyUp
    '    If txtCity.Text IsNot "" Then
    '        btnAdd.Enabled = True
    '    Else
    '        btnAdd.Enabled = False
    '    End If
    'End Sub

    Private Sub enableDelete(sender As Object, e As EventArgs) Handles dgvCity.MouseClick
        If (dgvCity.CurrentCell.ColumnIndex = 0) Then
            btnUpdate.Enabled = False
        Else
            btnUpdate.Enabled = True
            txtCity.Enabled = True
            point = dgvCity.CurrentRow.Index
            id = dgvCity.Item(0, point).Value
            txtCity.Text = dgvCity.Item(1, point).Value
            cmbProvince.Text = dgvCity.Item(2, point).Value
        End If
    End Sub

    Private Sub addCateg(sender As Object, e As EventArgs) Handles btnAdd.Click
        If cmbProvince.SelectedIndex = -1 Then
            MsgBox("ERROR! No Province Selected or Item does not exist on the list!", vbOKOnly, caption)
            Exit Sub
        ElseIf txtCity.Text = "" Then
            MsgBox("Please Fill In All Fields!")
            Exit Sub
        Else
            Dim provID As Integer
            provID = c.getData(cmbProvince)
            s.databankCheckingV2("city", id, "cityName", "provinceID", (txtCity.Text).ToUpper, provID, btnAdd, 1)
            populate()
        End If
        populate()
        c.clrData(grpCity)
    End Sub

    Private Sub del(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If cmbProvince.SelectedIndex = -1 Then
            MsgBox("ERROR! No Province selected or Item does not exist on the list!", vbOKOnly, caption)
            cmbProvince.Select()
            Exit Sub
        ElseIf txtCity.Text = "" Then
            MsgBox("Please Fill In All Fields!", vbOKOnly, caption)
            txtCity.Select()
            Exit Sub
        Else
            Dim provID As Integer
            provID = c.getData(cmbProvince)
            s.databankCheckingV2("city", id, "cityName", "provinceName", (txtCity.Text).ToUpper, provID, btnAdd, 2)
            populate()
            btnUpdate.Enabled = False

        End If
        populate()
        c.clrData(grpCity)
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