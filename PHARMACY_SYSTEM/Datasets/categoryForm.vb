Public Class categoryForm

    'id in control 1
    Dim s As New cSQL
    Dim c As New cControl

    'triggers
    Private Sub frmLoad(sender As Object, e As EventArgs) Handles Me.Load
        populate()
        btnAdd.Enabled = False
        btnDelete.Enabled = False
        dgvCategory.CurrentCell = Nothing
    End Sub

    Private Sub hideID(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles dgvCategory.DataBindingComplete
        With dgvCategory
            .Columns("ID").Visible = False
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
            btnDelete.Enabled = False
        Else
            btnDelete.Enabled = True
        End If
    End Sub

    Private Sub addCateg(sender As Object, e As EventArgs) Handles btnAdd.Click
        's.addToDataByTXT(txtCategory, dgvCategory, 1)
        If txtCategory.Text = "" Then
            MsgBox("Please Fill In All Fields!")
            Exit Sub
        ElseIf txtCategory.Text IsNot "" Then
            s.databankChecking("category", "categName", (txtCategory.Text).ToUpper, btnAdd)
            's.addToDataByTXT(txtUnit, dgvUnit, 9)
        End If
        populate()
        c.clrData(grpCategory)
        c.clrData(txtCategory)
        populate()
    End Sub

    Private Sub del(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim des As Boolean
        point = dgvCategory.CurrentRow.Index
        id = dgvCategory.Item(0, point).Value
        Name = dgvCategory.Item(1, point).Value
        des = c.notif(id, Name)
        If des = True Then
            s.delete(dgvCategory, "category", id)
            populate()
            c.clrData(grpCategory)
        Else
            Exit Sub
        End If
    End Sub

    'my Functions
    Private Sub populate()
        s.loadDTG(dgvCategory, "categoryView")
    End Sub

    Private Sub purge()
        dgvCategory.DataSource = Nothing
    End Sub

End Class