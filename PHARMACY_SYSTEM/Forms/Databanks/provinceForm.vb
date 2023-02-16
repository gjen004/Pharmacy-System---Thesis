Public Class provinceForm
    '8 in control
    Dim s As New cSQL
    Dim c As New cControl

    'triggers
    Private Sub frmLoad(sender As Object, e As EventArgs) Handles Me.Load
        populate()
        btnUpdate.Enabled = False
    End Sub

    'Private Sub enableButton(sender As Object, e As EventArgs) Handles txtProvince.KeyUp
    '    If txtProvince.Text IsNot "" Then
    '        btnAdd.Enabled = True
    '    Else
    '        btnAdd.Enabled = False
    '    End If
    'End Sub

    Private Sub hideID(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles dgvProvince.DataBindingComplete
        With dgvProvince
            .Columns("ID").Visible = False
            dgvProvince.ClearSelection()
        End With
    End Sub

    Private Sub enableDelete(sender As Object, e As EventArgs) Handles dgvProvince.MouseClick
        If (dgvProvince.CurrentCell.ColumnIndex = 0) Then
            btnUpdate.Enabled = False
        Else
            btnUpdate.Enabled = True
            point = dgvProvince.CurrentRow.Index
            id = dgvProvince.Item(0, point).Value
            txtProvince.Text = dgvProvince.Item(1, point).Value
        End If
    End Sub

    Private Sub addCateg(sender As Object, e As EventArgs) Handles btnAdd.Click
        's.addToDataByTXT(txtProvince, dgvProvince, 8)
        Dim inp As String = txtProvince.Text
        If inp = "" Then
            MsgBox("Please Fill In All Fields!", vbOKOnly, caption)
            txtProvince.Select()
            Exit Sub
        ElseIf txtProvince.Text IsNot "" Then
            s.databankChecking("province", id, "provinceName", inp.ToUpper, btnAdd, 1)
            's.addToDataByTXT(txtUnit, dgvUnit, 9)
            populate()
        End If
        populate()
        c.clrData(grpProvince)
    End Sub

    Private Sub del(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If txtProvince.Text = "" Then
            MsgBox("Please Fill In All Fields!", vbOKOnly, caption)
            txtProvince.Select()
            Exit Sub
        ElseIf txtProvince.Text IsNot "" Then
            s.databankChecking("province", id, "provinceName", (txtProvince.Text).ToUpper, btnAdd, 2)
            's.addToDataByTXT(txtUnit, dgvUnit, 9)
            btnUpdate.Enabled = False

        End If
        populate()
        c.clrData(grpProvince)
    End Sub

    'my Functions
    Private Sub populate()
        s.loadDTG(dgvProvince, "provinceView")
    End Sub

    Private Sub purge()
        dgvProvince.DataSource = Nothing
    End Sub
End Class