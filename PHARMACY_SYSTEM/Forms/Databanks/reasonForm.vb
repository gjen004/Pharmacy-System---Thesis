Public Class reasonForm

    Dim c As New cControl
    Dim s As New cSQL

    Private Sub frmLoad(sender As Object, e As EventArgs) Handles MyBase.Load
        s.loadDTG(dgvReason, "reasonView")
        txtReason.Enabled = False
        btnUpdate.Enabled = False
        populate()
    End Sub

    Private Sub hideID(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles dgvReason.DataBindingComplete
        With dgvReason
            .Columns("ID").Visible = False
            dgvReason.ClearSelection()
        End With
    End Sub

    Private Sub enableText(sender As Object, e As EventArgs) Handles cmbReasonType.SelectedIndexChanged
        If cmbReasonType.SelectedIndex = -1 Then
            txtReason.Enabled = False
        Else
            txtReason.Enabled = True
        End If
    End Sub

    'Private Sub enableAdd(sender As Object, e As EventArgs) Handles txtReason.KeyUp
    '    If txtReason.Text IsNot "" Then
    '        btnAdd.Enabled = True
    '    Else
    '        btnAdd.Enabled = False
    '    End If
    'End Sub

    Private Sub enableDelete(sender As Object, e As EventArgs) Handles dgvReason.MouseClick
        If (dgvReason.CurrentCell.ColumnIndex = 0) Then
            btnUpdate.Enabled = False
        Else
            btnUpdate.Enabled = True
            txtReason.Enabled = True
            point = dgvReason.CurrentRow.Index
            id = dgvReason.Item(0, point).Value
            txtReason.Text = dgvReason.Item(1, point).Value
            cmbReasonType.Text = dgvReason.Item(2, point).Value
        End If
    End Sub

    Private Sub addReason(sender As Object, e As EventArgs) Handles btnAdd.Click
        's.addToDataByTXT(txtReason, dgvReason, 10)
        txtReason.Text = txtReason.Text.Substring(0, 1).ToUpper() + txtReason.Text.Substring(1).ToLower()
        If cmbReasonType.SelectedIndex = -1 Then
            MsgBox("ERROR! No Usage selected or Item does not exist on the list!", vbOKOnly, caption)
            Exit Sub
        ElseIf txtReason.Text = "" Then
            MsgBox("Please Fill In All Fields!", vbOKOnly, caption)
            txtReason.Select()
            Exit Sub
        Else
            Dim rsnTypeID As Integer
            rsnTypeID = c.getData(cmbReasonType)
            s.databankCheckingV2("reason", id, "fullReason", "rsntypeid", txtReason.Text, rsnTypeID, btnAdd, 1)
            populate()
            's.addToDataByTXT(txtUnit, dgvUnit, 9)
        End If
        populate()
        c.clrData(grpReason)
    End Sub

    Private Sub delRes(sender As Object, e As EventArgs) Handles btnUpdate.Click
        txtReason.Text = txtReason.Text.Substring(0, 1).ToUpper() + txtReason.Text.Substring(1).ToLower()
        If cmbReasonType.SelectedIndex = -1 Then
            MsgBox("ERROR! No Usage selected or Item does not exist on the list!", vbOKOnly, caption)
            cmbReasonType.Select()
            Exit Sub
        ElseIf txtReason.Text = "" Then
            MsgBox("Please Fill In All Fields!", vbOKOnly, caption)
            txtReason.Select()
            Exit Sub
        Else
            Dim rsnTypeID As Integer
            rsnTypeID = c.getData(cmbReasonType)
            s.databankCheckingV2("reason", id, "fullreason", "rsntypeid", (txtReason.Text), rsnTypeID, btnUpdate, 2)
            btnUpdate.Enabled = False

            populate()
        End If
        populate()
        c.clrData(grpReason)
    End Sub


    Private Sub populate()
        s.loadDTG(dgvReason, "reasonView")
        s.loadCBX(cmbReasonType, "reasonType", "id", "rsnType")
    End Sub

    Private Sub purge()
        dgvReason.DataSource = Nothing
    End Sub
End Class