Public Class dosageForm
    '5 in control
    Dim s As New cSQL
    Dim c As New cControl
    'triggers
    Private Sub frmLoad(sender As Object, e As EventArgs) Handles Me.Load
        populate()
        btnUpdate.Enabled = False
        dgvDosage.CurrentCell = Nothing
    End Sub

    'Private Sub enableButton(sender As Object, e As EventArgs) Handles txtDosage.KeyUp
    '    If txtDosage.Text IsNot "" Then
    '        btnAdd.Enabled = True
    '    Else
    '        btnAdd.Enabled = False
    '    End If
    'End Sub

    Private Sub enableDelete(sender As Object, e As EventArgs) Handles dgvDosage.MouseClick
        If (dgvDosage.CurrentCell.ColumnIndex = 0) Then
            btnUpdate.Enabled = False
        Else
            btnUpdate.Enabled = True
            point = dgvDosage.CurrentRow.Index
            id = dgvDosage.Item(0, point).Value
            txtDosage.Text = dgvDosage.Item(1, point).Value
        End If
    End Sub

    Private Sub hideID(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles dgvDosage.DataBindingComplete
        With dgvDosage
            .Columns("ID").Visible = False
            dgvDosage.ClearSelection()
        End With
    End Sub

    Private Sub addCateg(sender As Object, e As EventArgs) Handles btnAdd.Click
        's.addToDataByTXT(txtDosage, dgvDosage, 5)
        If txtDosage.Text = "" Then
            MsgBox("Please Fill In All Fields!", vbOKOnly, caption)
            txtDosage.Select()
            Exit Sub
        ElseIf IsNumeric(txtDosage.Text) = False Then
            MsgBox("Invalid Input! Dosage must be numeric!", vbOKOnly, caption)
            txtDosage.Select()
            c.clrData(grpDosage)
            'btnAdd.Enabled = False
            Exit Sub
        ElseIf txtDosage.Text IsNot "" Then
            s.databankChecking("dosage", id, "dsgName", (txtDosage.Text).ToUpper, btnAdd, 1)
            's.addToDataByTXT(txtUnit, dgvUnit, 9)
        End If
        populate()
        c.clrData(grpDosage)
    End Sub

    Private Sub del(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If txtDosage.Text = "" Then
            MsgBox("Please Fill In All Fields!", vbOKOnly, caption)
            txtDosage.Select()
            Exit Sub
        ElseIf txtDosage.Text IsNot "" Then
            s.databankChecking("dosage", id, "dsgName", (txtDosage.Text).ToUpper, btnAdd, 2)
            's.addToDataByTXT(txtUnit, dgvUnit, 9)
            btnUpdate.Enabled = False

        End If
        populate()
        c.clrData(grpDosage)
    End Sub

    'my Functions
    Private Sub populate()
        s.loadDTG(dgvDosage, "dosageView")
    End Sub

    Private Sub purge()
        dgvDosage.DataSource = Nothing
    End Sub
End Class