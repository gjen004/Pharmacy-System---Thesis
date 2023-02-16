Public Class discountForm
    Dim c As New cControl
    Dim s As New cSQL

    Private Sub frmLoad(sender As Object, e As EventArgs) Handles MyBase.Load
        s.loadDTG(dgvDiscount, "discount")
        btnUpdate.Enabled = False
    End Sub

    Private Sub hideID(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles dgvDiscount.DataBindingComplete
        With dgvDiscount
            .Columns("ID").Visible = False
            dgvDiscount.ClearSelection()
        End With
    End Sub

    Private Sub enableDelete(sender As Object, e As EventArgs) Handles dgvDiscount.MouseClick
        If (dgvDiscount.CurrentCell.ColumnIndex = 0) Then
            btnUpdate.Enabled = False
        Else
            btnUpdate.Enabled = True
            point = dgvDiscount.CurrentRow.Index
            id = dgvDiscount.Item(0, point).Value
            txtDiscount.Text = dgvDiscount.Item(1, point).Value
            txtPercent.Text = dgvDiscount.Item(2, point).Value
        End If
    End Sub

    Private Sub addDscnt(sender As Object, e As EventArgs) Handles btnAdd.Click
        dscName = c.getData(txtDiscount).ToString.ToUpper
        percent = c.getData(txtPercent)
        s.addDsc(dgvDiscount, "discount", dscName, percent)
        c.clrData(GroupBox1)
    End Sub

    Private Sub delDscnt(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If txtDiscount.Text = "" Then
            MsgBox("ERROR! No Province selected or Item does not exist on the list!", vbOKOnly, caption)
            txtDiscount.Select()
            Exit Sub
        ElseIf txtPercent.Text = "" Then
            MsgBox("Please Fill In All Fields!", vbOKOnly, caption)
            txtPercent.Select()
            Exit Sub
        Else
            s.databankCheckingV2("discount", id, "discountName", "percentDscnt", (txtDiscount.Text).ToUpper, txtPercent.Text, btnAdd, 2)
            s.loadDTG(dgvDiscount, "discount")
            btnUpdate.Enabled = False

        End If
        s.loadDTG(dgvDiscount, "discount")
        c.clrData(GroupBox1)
    End Sub

End Class