Public Class customerView
    Dim s As New cSQL
    Dim c As New cControl

    Private Sub frmload(sender As Object, e As EventArgs) Handles MyBase.Load
        s.loadDTGN(dgvCustomer, "customerView", "", "deletedBy is NULL", 3)
        c.clrData(GroupBox1)
    End Sub

    Private Sub hideID(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles dgvCustomer.DataBindingComplete
        With dgvCustomer
            .Columns("ID").Visible = False
            .Columns("deletedBy").Visible = False
            dgvCustomer.ClearSelection()
        End With
    End Sub

    Private Sub btnCusSearch_Click(sender As Object, e As EventArgs) Handles btnCusSearch.Click
        Dim keyword As String
        keyword = txtCusSearch.Text
        If keyword = "" Then
            MsgBox("Please enter keyword!", vbOKOnly, caption)
            txtCusSearch.Select()
            Exit Sub
        Else
            If rdbCustName.Checked = True Then
                s.searchCustomer("customerview", dgvCustomer, keyword, 1)
            ElseIf rdbCustAddress.Checked = True Then
                s.searchCustomer("customerview", dgvCustomer, keyword, 2)
            ElseIf rdbCustName.Checked = False And rdbCustName.Checked = False Then
                s.searchCustomer("customerview", dgvCustomer, keyword, 3)
            End If
        End If
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        c.clrData(GroupBox1)
        populate()
    End Sub

    Private Sub populate()
        dgvCustomer.DataSource = Nothing
        'load DTG
        s.loadDTGN(dgvCustomer, "customerView", "", "deletedBy is NULL", 3)
    End Sub
End Class