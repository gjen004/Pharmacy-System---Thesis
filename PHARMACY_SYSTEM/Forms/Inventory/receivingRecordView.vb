Public Class receivingRecordView
    Dim s As New cSQL
    Dim c As New cControl
    Private Sub frmLoad(sender As Object, e As EventArgs) Handles MyBase.Load
        s.loadCBXN(cmbSupplier, "supplier", "ID", "suppName", "where deletedBy is NULL")
        panelDate.Enabled = False
        c.formatDTP(dateFrom, dateTo)
    End Sub

    Private Sub EnablePanelDate(sender As Object, e As EventArgs) Handles chkDatePeriod.CheckedChanged
        If chkDatePeriod.CheckState = CheckState.Checked Then
            panelDate.Enabled = True
        ElseIf chkDatePeriod.CheckState = CheckState.Unchecked Then
            panelDate.Enabled = False
        End If
    End Sub

    Private Sub getargs(sender As Object, e As EventArgs) Handles btnCheck.Click
        c.setRRList(dgvRRList, chkDatePeriod, dateFrom, dateTo, cmbSupplier)

    End Sub

    Private Sub ClearRRList(sender As Object, e As EventArgs) Handles dateFrom.TextChanged, dateTo.TextChanged
        c.clrDS(dgvRRList)
        c.clrDS(dgvRRDetails)
    End Sub

    Private Sub loadRelatedPO(sender As Object, e As EventArgs) Handles dgvRRList.CellClick
        Try
            _index = dgvRRList.CurrentRow.Index
            whereIs = dgvRRList.Item(0, _index).Value
            s.loadDTGN(dgvRRDetails, "UpdateRR", "Product,ProdExpDate,[Unit Cost],QuantityReceived,RRAmount", "RRID = " + whereIs, 4)

            dgvRRDetails.Columns("ProdExpDate").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            dgvRRDetails.Columns("ProdExpDate").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            dgvRRDetails.Columns("Unit Cost").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            dgvRRDetails.Columns("Unit Cost").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            dgvRRDetails.Columns("QuantityReceived").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            dgvRRDetails.Columns("QuantityReceived").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            dgvRRDetails.Columns("RRAmount").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            dgvRRDetails.Columns("RRAmount").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub RefreshForm(sender As Object, e As EventArgs) Handles btnRefresh.Click
        c.clrDS(dgvRRDetails)
        c.clrDS(dgvRRList)
        cmbSupplier.SelectedIndex = -1
        cmbSupplier.Text = ""
        panelDate.Enabled = False
        chkDatePeriod.Checked = False
        s.loadCBXN(cmbSupplier, "supplier", "ID", "suppName", "where deletedBy is NULL")
    End Sub

    Private Sub HideOtherDetails(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles dgvRRList.DataBindingComplete
        With dgvRRList
            .Columns("suppName").Visible = False
            '.Columns("employee").Visible = False
            .Columns("Remarks").Visible = False
            .Columns("receivedBy").Visible = False
            '.Columns("stock").Visible = False
            '.Columns("balance").Visible = False
            dgvRRList.Columns(2).DefaultCellStyle.Format = "MM/dd/yyyy"
            dgvRRList.Columns("RR No.").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            dgvRRList.Columns("RR No.").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            dgvRRList.Columns("Date").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            dgvRRList.Columns("Date").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        End With
    End Sub

    Private Sub HideOtherDetailss(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles dgvRRDetails.DataBindingComplete
        With dgvRRDetails

            dgvRRDetails.Columns(1).DefaultCellStyle.Format = "MM/dd/yyyy"

            dgvRRDetails.Columns("Unit Cost").DefaultCellStyle.Format = "N"
            dgvRRDetails.Columns("RRAmount").DefaultCellStyle.Format = "N"
            dgvRRDetails.Columns("QuantityReceived").DefaultCellStyle.Format = "#,###"


        End With
    End Sub

    Private Sub BtnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        c.SetID(dgvRRList.Item(0, dgvRRList.CurrentRow.Index).Value)
        PrintOneRR.Show()
    End Sub
End Class