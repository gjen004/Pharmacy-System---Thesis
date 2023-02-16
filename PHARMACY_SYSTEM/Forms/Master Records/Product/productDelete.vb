Public Class productDelete
    Dim s As New cSQL
    Dim c As New cControl

    Private Sub loadFrm(sender As Object, e As EventArgs) Handles MyBase.Load
        populate()
        MyBase.MinimizeBox = False
        MyBase.MaximizeBox = False
        dgvProduct.AllowUserToAddRows = False
        rdbProdBrandName.Checked = False
        rdbProdCode.Checked = False
        c.clrData(grpProdList)
        'btnProdDelete.Enabled = False
    End Sub

    Private Sub getRow(sender As Object, e As EventArgs) Handles dgvProduct.RowHeaderMouseClick
        point = dgvProduct.CurrentRow.Index
        'btnProdDelete.Enabled = True
    End Sub

    Private Sub hideID(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles dgvProduct.DataBindingComplete
        With dgvProduct
            .Columns("ID").Visible = False
            .Columns("deletedby").Visible = False
            dgvProduct.ClearSelection()

        End With
    End Sub

    Private Sub del(sender As Object, e As EventArgs) Handles btnProdDelete.Click
        empName = s.GetDetailStr("employeeView", "EmployeeName", "userName", username)
        Try
            If dgvProduct.SelectedRows.Count = 0 Then
                MsgBox("No Item Selected", vbOKOnly, caption)
                Exit Sub
            Else
                Dim des As Boolean
                point = dgvProduct.CurrentRow.Index
                id = dgvProduct.Item(0, point).Value
                brndName = dgvProduct.Item(4, point).Value
                des = c.notif(id, brndName)
                If des = True Then
                    s.softdelete(dgvProduct, "product", id, empName)
                    populate()
                Else
                    Exit Sub
                End If
                SQLCon.Close()
            End If
        Catch ex As Exception
            Dim msg1 As String = ex.GetType.ToString
            If msg1 = "System.NullReferenceException" Then
                MsgBox("No Item Selected", vbOKOnly, caption)
            End If
        End Try
    End Sub

    Private Sub populate()
        dgvProduct.DataSource = Nothing

        'populate DTG
        s.loadDTGN(dgvProduct, "viewproduct", "", "[Status] = 'ACTIVE' and deletedBy is NULL order by [Product Code]", 3)
    End Sub

    Private Sub btnProdSearch_Click(sender As Object, e As EventArgs) Handles btnProdSearch.Click
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
        dgvProduct.ClearSelection()
        'btnProdDelete.Enabled = False
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        s.loadDTGN(dgvProduct, "viewproduct", "", "[Status] = 'ACTIVE' and deletedBy is NULL", 3)
        c.clrData(grpProdList)
    End Sub

End Class