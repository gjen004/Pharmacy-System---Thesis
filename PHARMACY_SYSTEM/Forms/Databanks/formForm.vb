Public Class formForm
    '6 in control

    Dim s As New cSQL
    Dim c As New cControl

    'triggers
    Private Sub frmLoad(sender As Object, e As EventArgs) Handles Me.Load
        populate()
        btnUpdate.Enabled = False
        dgvForm.CurrentCell = Nothing
    End Sub

    Private Sub enableDelete(sender As Object, e As EventArgs) Handles dgvForm.MouseClick
        If (dgvForm.CurrentCell.ColumnIndex = 0) Then
            btnUpdate.Enabled = False
        Else
            btnUpdate.Enabled = True
            point = dgvForm.CurrentRow.Index
            id = dgvForm.Item(0, point).Value
            txtForm.Text = dgvForm.Item(1, point).Value
        End If
    End Sub

    'Private Sub enableButton(sender As Object, e As EventArgs) Handles txtForm.KeyUp
    '    If txtForm.Text IsNot "" Then
    '        btnAdd.Enabled = True
    '    Else
    '        btnAdd.Enabled = False
    '    End If
    'End Sub

    Private Sub hideID(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles dgvForm.DataBindingComplete
        With dgvForm
            .Columns("ID").Visible = False
            dgvForm.ClearSelection()
        End With
    End Sub

    Private Sub addCateg(sender As Object, e As EventArgs) Handles btnAdd.Click
        's.addToDataByTXT(txtForm, dgvForm, 6)
        If txtForm.Text = "" Then
            MsgBox("Please Fill In All Fields!", vbOKOnly, caption)
            txtForm.Select()
            Exit Sub
        ElseIf txtForm.Text IsNot "" Then
            s.databankChecking("form", id, "formName", (txtForm.Text).ToUpper, btnAdd, 1)
            's.addToDataByTXT(txtUnit, dgvUnit, 9)
        End If
        populate()
        c.clrData(grpForm)
    End Sub

    Private Sub del(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If txtForm.Text = "" Then
            MsgBox("Please Fill In All Fields!", vbOKOnly, caption)
            txtForm.Select()
            Exit Sub
        ElseIf txtForm.Text IsNot "" Then
            s.databankChecking("form", id, "formName", (txtForm.Text).ToUpper, btnAdd, 2)
            's.addToDataByTXT(txtUnit, dgvUnit, 9)
            btnUpdate.Enabled = False

        End If
        populate()
        c.clrData(grpForm)
    End Sub

    'my Functions
    Private Sub populate()
        s.loadDTG(dgvForm, "formView")
    End Sub

    Private Sub purge()
        dgvForm.DataSource = Nothing
    End Sub

End Class