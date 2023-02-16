Public Class supplierView
    Dim s As New cSQL
    Dim c As New cControl
    Private Sub frmLoad(sender As Object, e As EventArgs) Handles MyBase.Load
        s.loadDTGN(dgvSupplier, "Viewsupp", "", "deletedBy is NULL", 3)
        MyBase.MinimizeBox = False
        MyBase.MaximizeBox = False
        dgvSupplier.AllowUserToAddRows = False
        c.clrData(grpSuppList)
        rdbSuppName.Checked = False
    End Sub

    Private Sub hideID(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles dgvSupplier.DataBindingComplete
        With dgvSupplier
            .Columns("ID").Visible = False
            .Columns("deletedBy").Visible = False
            dgvSupplier.ClearSelection()
        End With
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

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        c.clrData(grpSuppList)
        populate()
    End Sub

    Private Sub populate()
        dgvSupplier.DataSource = Nothing
        s.loadDTGN(dgvSupplier, "Viewsupp", "", "deletedBy is NULL", 3)
    End Sub
End Class