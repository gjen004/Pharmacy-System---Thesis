Public Class position
    Dim s As New cSQL
    Dim c As New cControl

    Private Sub hideID(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles dgvPosition.DataBindingComplete
        With dgvPosition
            .Columns("ID").Visible = False
            dgvPosition.ClearSelection()
        End With
    End Sub

    'Private Sub enableButton(sender As Object, e As EventArgs) Handles txtPosition.KeyUp
    '    If txtPosition.Text IsNot "" Then
    '        btnAdd.Enabled = True
    '    Else
    '        btnAdd.Enabled = False
    '    End If
    'End Sub

    Private Sub enableDelete(sender As Object, e As EventArgs) Handles dgvPosition.MouseClick
        If (dgvPosition.CurrentCell.ColumnIndex = 0) Then
            btnUpdate.Enabled = False
        Else
            btnUpdate.Enabled = True
            point = dgvPosition.CurrentRow.Index
            id = dgvPosition.Item(0, point).Value
            txtPosition.Text = dgvPosition.Item(1, point).Value
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        's.addToDataByTXT(txtCategory, dgvPosition, 11)
        If txtPosition.Text = "" Then
            MsgBox("Please Fill In All Fields!", vbOKOnly, caption)
            txtPosition.Select()
            Exit Sub
        ElseIf txtPosition.Text IsNot "" Then
            s.databankChecking("empPosition", id, "empPosName", (txtPosition.Text).ToUpper, btnAdd, 1)
            's.addToDataByTXT(txtUnit, dgvUnit, 9)
        End If
        populate()
        c.clrData(grpPosition)
    End Sub

    Private Sub del(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If txtPosition.Text = "" Then
            MsgBox("Please Fill In All Fields!", vbOKOnly, caption)
            txtPosition.Select()
            Exit Sub
        ElseIf txtPosition.Text IsNot "" Then
            s.databankChecking("empPosition", id, "empPosName", (txtPosition.Text).ToUpper, btnAdd, 2)
            's.addToDataByTXT(txtUnit, dgvUnit, 9)
            btnUpdate.Enabled = False

        End If
        populate()
        c.clrData(grpPosition)
    End Sub

    Private Sub populate()
        s.loadDTG(dgvPosition, "positionView")
    End Sub

    Private Sub purge()
        dgvPosition.DataSource = Nothing
    End Sub

    Private Sub position_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        s.loadDTG(dgvPosition, "positionView")
        btnUpdate.Enabled = False
        dgvPosition.CurrentCell = Nothing
    End Sub
End Class