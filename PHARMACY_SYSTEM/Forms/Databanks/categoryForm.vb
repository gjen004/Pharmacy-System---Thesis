Public Class categoryForm

    'id in control 1
    Dim s As New cSQL
    Dim c As New cControl

    'triggers
    Private Sub frmLoad(sender As Object, e As EventArgs) Handles Me.Load
        populate()
        btnUpdate.Enabled = False
        dgvCategory.CurrentCell = Nothing
    End Sub

    Private Sub hideID(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles dgvCategory.DataBindingComplete
        With dgvCategory
            .Columns("ID").Visible = False
            dgvCategory.ClearSelection()
        End With
    End Sub

    Private Sub enableButton(sender As Object, e As EventArgs) Handles txtCategory.KeyUp
        If txtCategory.Text IsNot "" Then
            btnAdd.Enabled = True
        Else
            btnAdd.Enabled = False
        End If
    End Sub

    Private Sub enableDelete(sender As Object, e As EventArgs) Handles dgvCategory.MouseClick
        If (dgvCategory.CurrentCell.ColumnIndex = 0) Then
            btnUpdate.Enabled = False
        Else
            btnUpdate.Enabled = True
            point = dgvCategory.CurrentRow.Index
            id = dgvCategory.Item(0, point).Value
            txtCategory.Text = dgvCategory.Item(1, point).Value
        End If
    End Sub

    Private Sub addCateg(sender As Object, e As EventArgs) Handles btnAdd.Click
        's.addToDataByTXT(txtCategory, dgvCategory, 1)
        If txtCategory.Text = "" Then
            MsgBox("Please Fill In All Fields!", vbOKOnly, caption)
            txtCategory.Select()
            Exit Sub
        ElseIf txtCategory.Text IsNot "" Then
            s.databankChecking("category", id, "categName", (txtCategory.Text).ToUpper, btnAdd, 1)
            's.addToDataByTXT(txtUnit, dgvUnit, 9)
        End If
        populate()
        c.clrData(grpCategory)
        c.clrData(txtCategory)
        populate()
    End Sub

    Private Sub del(sender As Object, e As EventArgs) Handles btnUpdate.Click
        'point = dgvCategory.CurrentRow.Index
        'id = dgvCategory.Item(0, point).Value
        'Name = dgvCategory.Item(1, point).Value
        'txtCategory.Text = Name
        If txtCategory.Text = "" Then
            MsgBox("Please Fill In All Fields!", vbOKOnly, caption)
            txtCategory.Select()
            Exit Sub
        ElseIf txtCategory.Text IsNot "" Then
            s.databankChecking("category", id, "categName", (txtCategory.Text).ToUpper, btnAdd, 2)
            's.addToDataByTXT(txtUnit, dgvUnit, 9)
            btnUpdate.Enabled = False

        End If
        populate()
        c.clrData(grpCategory)
    End Sub

    'my Functions
    Private Sub populate()
        s.loadDTG(dgvCategory, "categoryView")
    End Sub

    Private Sub purge()
        dgvCategory.DataSource = Nothing
    End Sub

End Class