Public Class genericForm
    '7 in control
    Dim s As New cSQL
    Dim c As New cControl

    'triggers
    Private Sub frmLoad(sender As Object, e As EventArgs) Handles Me.Load
        populate()
        txtGeneric.Enabled = False
        btnUpdate.Enabled = False
        dgvGeneric.CurrentCell = Nothing
    End Sub

    'Private Sub enableAdd(sender As Object, e As EventArgs) Handles txtGeneric.KeyUp
    '    If txtGeneric.Text IsNot "" Then
    '        btnAdd.Enabled = True
    '    Else
    '        btnAdd.Enabled = False
    '    End If
    'End Sub

    Private Sub enableDelete(sender As Object, e As EventArgs) Handles dgvGeneric.MouseClick
        If (dgvGeneric.CurrentCell.ColumnIndex = 0) Then
            btnUpdate.Enabled = False
        Else
            btnUpdate.Enabled = True
            txtGeneric.Enabled = True
            point = dgvGeneric.CurrentRow.Index
            id = dgvGeneric.Item(0, point).Value
            txtGeneric.Text = dgvGeneric.Item(1, point).Value
            cmbCategory.Text = dgvGeneric.Item(2, point).Value
        End If
    End Sub

    Private Sub hideID(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles dgvGeneric.DataBindingComplete
        With dgvGeneric
            .Columns("ID").Visible = False
            dgvGeneric.ClearSelection()
        End With
    End Sub

    Private Sub addCateg(sender As Object, e As EventArgs) Handles btnAdd.Click
        'If txtGeneric.Text = "" Or cmbCategory.SelectedIndex = -1 Then
        '    MsgBox("Please fill in all fields!")
        '    Exit Sub
        'Else
        '    Dim genName As String = txtGeneric.Text
        '    Dim catName As String = cmbCategory.Text
        '    s.RunQuery("insert into generic(genName,categName) values ('" & genName & "' ,'" & catName & "')")
        '    MsgBox("Added Successfully!")
        '    c.clrData(grpGeneric)
        '    populate()

        If cmbCategory.SelectedIndex = -1 Then
            MsgBox("ERROR! No Category selected or Item does not exist on the list!", vbOKOnly, caption)
            Exit Sub
        ElseIf txtGeneric.Text = "" Then
            MsgBox("Please Fill In All Fields!", vbOKOnly, caption)
            txtGeneric.Select()
            Exit Sub
        Else
            Dim catID As Integer
            catID = c.getData(cmbCategory)
            s.databankCheckingV2("generic", id, "genName", "categID", (txtGeneric.Text).ToUpper, catID, btnAdd, 1)
            populate()
            's.addToDataByTXT(txtUnit, dgvUnit, 9)
        End If
        populate()
        c.clrData(grpGeneric)

    End Sub

    Private Sub updt(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If cmbCategory.SelectedIndex = -1 Then
            MsgBox("ERROR! No Category selected or Item does not exist on the list!", vbOKOnly, caption)
            cmbCategory.Select()
            Exit Sub
        ElseIf txtGeneric.Text = "" Then
            MsgBox("Please Fill In All Fields!", vbOKOnly, caption)
            txtGeneric.Select()
            Exit Sub
        Else
            Dim catID As Integer
            catID = c.getData(cmbCategory)
            s.databankCheckingV2("generic", id, "genName", "categID", (txtGeneric.Text).ToUpper, catID, btnAdd, 2)
            populate()
            's.addToDataByTXT(txtUnit, dgvUnit, 9)
            btnUpdate.Enabled = False
        End If
        populate()
        c.clrData(grpGeneric)
    End Sub

    'my Functions
    Private Sub populate()
        s.loadDTG(dgvGeneric, "genericView")
        s.loadCBX(cmbCategory, "category", "id", "categName")
    End Sub

    Private Sub purge()
        dgvGeneric.DataSource = Nothing
    End Sub

    Private Sub enableText(sender As Object, e As EventArgs) Handles cmbCategory.SelectedIndexChanged
        If cmbCategory.SelectedIndex = -1 Then
            txtGeneric.Enabled = False
        Else
            txtGeneric.Enabled = True
        End If
    End Sub
End Class