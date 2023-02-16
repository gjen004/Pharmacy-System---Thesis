Public Class bankForm
    Dim c As New cControl
    Dim s As New cSQL

    'ID in control 2

    'triggers
    Private Sub frmLoad(sender As Object, e As EventArgs) Handles Me.Load
        btnUpdate.Enabled = False
        dgvBank.CurrentCell = Nothing
        populate()
    End Sub

    Private Sub enableDelete(sender As Object, e As EventArgs) Handles dgvBank.MouseClick
        If (dgvBank.CurrentCell.ColumnIndex = 0) Then
            btnUpdate.Enabled = False
        Else
            point = dgvBank.CurrentRow.Index
            id = dgvBank.Item(0, point).Value
            txtBank.Text = dgvBank.Item(1, point).Value
            btnUpdate.Enabled = True
        End If
    End Sub

    'Private Sub enableButton(sender As Object, e As EventArgs) Handles txtBank.KeyUp
    '    If txtBank.Text IsNot "" Then
    '        btnAdd.Enabled = True
    '    Else
    '        btnAdd.Enabled = False
    '    End If
    'End Sub

    Private Sub addCateg(sender As Object, e As EventArgs) Handles btnAdd.Click
        's.addToDataByTXT(txtBank, dgvBank, 2)
        If txtBank.Text = "" Then
            MsgBox("Please Fill In All Fields!", vbOKOnly, caption)
            txtBank.Select()
            Exit Sub
        ElseIf txtBank.Text IsNot "" Then
            s.databankChecking("bank", id, "bankName", (txtBank.Text).ToUpper, btnAdd, 1)
            's.addToDataByTXT(txtUnit, dgvUnit, 9)
        End If
        populate()
        c.clrData(grpBank)
    End Sub

    Private Sub update(sender As Object, e As EventArgs) Handles btnUpdate.Click
        'point = dgvBank.CurrentRow.Index
        'id = dgvBank.Item(0, point).Value
        'Name = dgvBank.Item(1, point).Value
        'txtBank.Text = Name
        If txtBank.Text = "" Then
            MsgBox("Please Fill In All Fields!", vbOKOnly, caption)
            txtBank.Select()
            Exit Sub
        ElseIf txtBank.Text IsNot "" Then
            s.databankChecking("bank", id, "bankName", (txtBank.Text).ToUpper, btnAdd, 2)
            's.addToDataByTXT(txtUnit, dgvUnit, 9)
            btnUpdate.Enabled = False

        End If
        populate()
        c.clrData(grpBank)
    End Sub

    'my Functions
    Private Sub populate()
        s.loadDTG(dgvBank, "bankView")
    End Sub

    Private Sub hideID(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles dgvBank.DataBindingComplete
        With dgvBank
            .Columns("ID").Visible = False
            dgvBank.ClearSelection()
        End With
    End Sub

End Class