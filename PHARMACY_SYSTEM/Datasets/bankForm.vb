Public Class bankForm
    Dim c As New cControl
    Dim s As New cSQL

    'ID in control 2

    'triggers
    Private Sub frmLoad(sender As Object, e As EventArgs) Handles Me.Load
        btnAdd.Enabled = False
        btnDelete.Enabled = False
        dgvBank.CurrentCell = Nothing
        populate()
    End Sub

    Private Sub enableDelete(sender As Object, e As EventArgs) Handles dgvBank.MouseClick
        If (dgvBank.CurrentCell.ColumnIndex = 0) Then
            btnDelete.Enabled = False
        Else
            btnDelete.Enabled = True
        End If
    End Sub

    Private Sub enableButton(sender As Object, e As EventArgs) Handles txtBank.KeyUp
        If txtBank.Text IsNot "" Then
            btnAdd.Enabled = True
        Else
            btnAdd.Enabled = False
        End If
    End Sub

    Private Sub addCateg(sender As Object, e As EventArgs) Handles btnAdd.Click
        's.addToDataByTXT(txtBank, dgvBank, 2)
        If txtBank.Text = "" Then
            MsgBox("Please Fill In All Fields!")
            Exit Sub
        ElseIf txtBank.Text IsNot "" Then
            s.databankChecking("bank", "bankName", (txtBank.Text).ToUpper, btnAdd)
            's.addToDataByTXT(txtUnit, dgvUnit, 9)
        End If
        populate()
        c.clrData(grpBank)
    End Sub

    Private Sub del(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim des As Boolean
        point = dgvBank.CurrentRow.Index
        id = dgvBank.Item(0, point).Value
        Name = dgvBank.Item(1, point).Value
        des = c.notif(id, Name)
        If des = True Then
            s.delete(dgvBank, "bank", id)
            populate()
            c.clrData(grpBank)
        Else
            Exit Sub
        End If
    End Sub

    'my Functions
    Private Sub populate()
        s.loadDTG(dgvBank, "bankView")
    End Sub

    Private Sub hideID(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles dgvBank.DataBindingComplete
        With dgvBank
            .Columns("ID").Visible = False
        End With
    End Sub

End Class