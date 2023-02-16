Public Class unitForm
    '9 in control
    Dim s As New cSQL
    Dim c As New cControl

    'triggers
    Private Sub frmLoad(sender As Object, e As EventArgs) Handles Me.Load
        btnUpdate.Enabled = False
        dgvUnit.CurrentCell = Nothing
        populate()
    End Sub

    Private Sub hideID(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles dgvUnit.DataBindingComplete
        With dgvUnit
            .Columns("ID").Visible = False
            dgvUnit.ClearSelection()
        End With
    End Sub

    'Private Sub enableButton(sender As Object, e As EventArgs) Handles txtUnit.KeyUp
    '    If txtUnit.Text IsNot "" Then
    '        btnAdd.Enabled = True
    '    Else
    '        btnAdd.Enabled = False
    '        point = dgvUnit.CurrentRow.Index
    '        id = dgvUnit.Item(0, point).Value
    '        txtUnit.Text = dgvUnit.Item(1, point).Value
    '    End If
    'End Sub

    Private Sub addCateg(sender As Object, e As EventArgs) Handles btnAdd.Click
        'Dim checkQuery As String = "select * from productUnit where unitMsr like '%" & txtUnit.Text & "%'"
        'Dim da As New s.SqlDataAdapter(searchQuery, SQLCon)
        'Dim ds As New DataSet
        If txtUnit.Text = "" Then
            MsgBox("Please Fill In All Fields!", vbOKOnly, caption)
            txtUnit.Select()
            Exit Sub
        ElseIf txtUnit.Text IsNot "" Then
            s.databankChecking("productUnit", id, "unitMsr", txtUnit.Text, btnAdd, 1)
            's.addToDataByTXT(txtUnit, dgvUnit, 9)
        End If
        populate()
        c.clrData(grpUnit)
    End Sub

    Private Sub enableDelete(sender As Object, e As EventArgs) Handles dgvUnit.MouseClick
        If (dgvUnit.CurrentCell.ColumnIndex = 0) Then
            btnUpdate.Enabled = False
        Else
            btnUpdate.Enabled = True
            point = dgvUnit.CurrentRow.Index
            id = dgvUnit.Item(0, point).Value
            txtUnit.Text = dgvUnit.Item(1, point).Value
        End If
    End Sub

    Private Sub del(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If txtUnit.Text = "" Then
            MsgBox("Please Fill In All Fields!", vbOKOnly, caption)
            txtUnit.Select()
            Exit Sub
        ElseIf txtUnit.Text IsNot "" Then
            s.databankChecking("productUnit", id, "unitMsr", (txtUnit.Text), btnAdd, 2)
            's.addToDataByTXT(txtUnit, dgvUnit, 9)
            btnUpdate.Enabled = False

        End If
        populate()
        c.clrData(grpUnit)
    End Sub

    'my Functions
    Private Sub populate()
        s.loadDTG(dgvUnit, "unitView")
    End Sub
End Class