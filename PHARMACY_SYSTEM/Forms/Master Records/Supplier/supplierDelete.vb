Public Class supplierDelete
    Dim c As New cControl
    Dim s As New cSQL

    Private Sub frmload(sender As Object, e As EventArgs) Handles MyBase.Load
        populate()
        c.setTrueFalse(Me, dgvSupplier, Nothing)
        rdbSuppName.Checked = False
        c.clrData(GroupBox10)
    End Sub

    Private Sub hideID(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles dgvSupplier.DataBindingComplete
        With dgvSupplier
            .Columns("ID").Visible = False
            .Columns("deletedBy").Visible = False
            dgvSupplier.ClearSelection()

        End With
    End Sub

    Private Sub del(sender As Object, e As EventArgs) Handles btnSuppDelete.Click
        empName = s.GetDetailStr("employeeView", "EmployeeName", "userName", username)
        Try
            If dgvSupplier.SelectedRows.Count = 0 Then
                MsgBox("No Item Selected", vbOKOnly, caption)
                Exit Sub
            Else
                Dim des As Boolean
                point = dgvSupplier.CurrentRow.Index
                id = dgvSupplier.Item(0, point).Value
                brndName = dgvSupplier.Item(1, point).Value
                des = c.notif(id, brndName)
                If des = True Then
                    s.softdelete(dgvSupplier, "supplier", id, empName)
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
        dgvSupplier.DataSource = Nothing
        s.loadDTGN(dgvSupplier, "Viewsupp", "", "deletedBy is NULL", 3)
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        c.clrData(GroupBox10)
        populate()
    End Sub

    Private Sub btnSuppSearch_click(sender As Object, e As EventArgs) Handles btnSuppSearch.Click
        Dim keyword As String
        keyword = txtSuppSearch.Text
        If keyword = "" Then
            MsgBox("Please enter keyword!", vbOKOnly, caption)
            txtSuppSearch.Select()
            Exit Sub
        Else
            If rdbSuppName.Checked = True Then
                s.searchSupplier("supplier", dgvSupplier, keyword, 1)
            ElseIf rdbSuppProvince.Checked = True Then
                s.searchSupplier("supplier", dgvSupplier, keyword, 2)
            ElseIf rdbSuppName.Checked = False And rdbSuppProvince.Checked = False Then
                s.searchSupplier("supplier", dgvSupplier, keyword, 3)
            End If
        End If
    End Sub
End Class