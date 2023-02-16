Public Class customerDelete
    Dim c As New cControl
    Dim s As New cSQL

    Private Sub frmload(sender As Object, e As EventArgs) Handles MyBase.Load
        populate()
        rdbCustAddress.Checked = False
        rdbCustName.Checked = False
        c.clrData(GroupBox10)
    End Sub

    Private Sub hideID(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles dgvCustomer.DataBindingComplete
        With dgvCustomer
            .Columns("ID").Visible = False
            .Columns("deletedBy").Visible = False
            dgvCustomer.ClearSelection()
        End With
    End Sub

    Private Sub del(sender As Object, e As EventArgs) Handles btnCusDelete.Click
        empName = s.GetDetailStr("employeeView", "EmployeeName", "userName", username)
        Try
            If dgvCustomer.SelectedRows.Count = 0 Then
                MsgBox("No Item Selected", vbOKOnly, caption)
                Exit Sub
            Else
                Dim des As Boolean
                point = dgvCustomer.CurrentRow.Index
                id = dgvCustomer.Item(0, point).Value
                brndName = dgvCustomer.Item(1, point).Value
                des = c.notif(id, brndName)
                If des = True Then
                    s.softdelete(dgvCustomer, "customer", id, empName)
                    populate()
                Else
                    Exit Sub
                End If
            End If
        Catch ex As Exception
            Dim msg1 As String = ex.GetType.ToString
            If msg1 = "System.NullReferenceException" Then
                MsgBox("No Item Selected", vbOKOnly, caption)
            End If
        End Try
    End Sub

    Private Sub populate()
        dgvCustomer.DataSource = Nothing
        s.loadDTGN(dgvCustomer, "customerView", "", "deletedBy is NULL", 3)
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        c.clrData(GroupBox10)
        populate()
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
End Class