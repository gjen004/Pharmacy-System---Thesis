Public Class productView
    Dim s As New cSQL
    Dim c As New cControl
    Private Sub frmload(sender As Object, e As EventArgs) Handles MyBase.Load
        s.loadDTGN(dgvProduct, "viewproduct", "", "[Status] = 'ACTIVE' and deletedBy is NULL order by [Product Code]", 3)
        MyBase.MinimizeBox = False
        MyBase.MaximizeBox = False
        dgvProduct.AllowUserToAddRows = False
    End Sub

    Private Sub hideID(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles dgvProduct.DataBindingComplete
        With dgvProduct
            .Columns("ID").Visible = False
            .Columns("deletedby").Visible = False
            dgvProduct.ClearSelection()
        End With
    End Sub


    Private Sub btnProdSearch_Click(sender As Object, e As EventArgs) Handles btnProdSearch.Click, btnProdSearch.Enter
        Dim keyword As String
        keyword = txtProdSearch.Text
        If keyword = "" Then
            MsgBox("Please enter keyword!", vbOKOnly, caption)
            txtProdSearch.Select()
            Exit Sub
        Else
            If rdbProdCode.Checked = True Then
                s.searchProduct("product", dgvProduct, keyword, 1)
            ElseIf rdbProdBrandName.Checked = True Then
                s.searchProduct("product", dgvProduct, keyword, 2)
            ElseIf rdbProdBrandName.Checked = False And rdbProdCode.Checked = False Then
                s.searchProduct("product", dgvProduct, keyword, 3)
            End If
        End If
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        s.loadDTGN(dgvProduct, "viewproduct", "", "[Status] = 'ACTIVE' and deletedBy is NULL", 3)
        c.clrData(grpProdList)
    End Sub
End Class