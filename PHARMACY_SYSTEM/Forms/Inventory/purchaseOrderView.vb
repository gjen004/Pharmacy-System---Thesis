Imports System.Data.Sql
Imports System.Data.SqlClient
Public Class purchaseOrderView
    Dim s As New cSQL
    Dim c As New cControl

    Private Sub frmload(sender As Object, e As EventArgs) Handles MyBase.Load
        c.setTrueFalse(Me, dgvPOList, Nothing)
        s.loadCBXN(cmbSupplier, "supplier", "ID", "suppName", "where deletedBy is NULL")
        panelDate.Enabled = False 'fix
        c.formatDTP(dateFrom, dateTo)

    End Sub

    Private Sub polistHideID(sender As Object, e As EventArgs) Handles dgvPOList.DataBindingComplete
        'dgvPOList.Columns(1).DefaultCellStyle.Format = "MM/dd/yyyy"
        dgvPOList.Columns("PO No.").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgvPOList.Columns("PO No.").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgvPOList.Columns("Date").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgvPOList.Columns("Date").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgvPOList.Columns("Status").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgvPOList.Columns("Status").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
    End Sub

    Private Sub hideID(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles dgvPODetails.DataBindingComplete
        Try
            With dgvPODetails
                .Columns("ID").Visible = False
                .Columns("PO No.").Visible = False
                '.Columns("Unit Cost").Visible = False
                'dgvPODetails.Columns(2).Width = 300

            End With
            dgvPODetails.Columns("Quantity").DefaultCellStyle.Format = "#,###"
            'dgvPODetails.Columns("Unit Cost").ValueType = GetType(Double)
            dgvPODetails.Columns("Unit Cost").DefaultCellStyle.Format = "N"
            dgvPODetails.Columns("Balance").DefaultCellStyle.Format = "#,###"
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub UnloadList(sender As Object, e As EventArgs) Handles dateFrom.TextChanged, dateTo.TextChanged
        c.clrDS(dgvPOList)
        c.clrDS(dgvPODetails)
    End Sub

    Private Sub clrDTG(sender As Object, e As EventArgs) Handles btnRefresh.Click
        dgvPOList.DataSource = Nothing
        dgvPODetails.DataSource = Nothing
        cmbSupplier.SelectedIndex = -1
        cmbSupplier.Text = ""
        panelDate.Enabled = False
        chkDatePeriod.Checked = False
    End Sub

    Private Sub showMatch(sender As Object, e As EventArgs) Handles btnCheck.Click
        c.setPOList(dgvPOList, chkDatePeriod, dateFrom, dateTo, cmbSupplier, 1)
        ''dgvPOList.Columns(1).DefaultCellStyle.Format = "MM/dd/yyyy"
        'dgvPOList.Columns("PO No.").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        'dgvPOList.Columns("PO No.").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        'dgvPOList.Columns("Date").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        'dgvPOList.Columns("Date").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        'dgvPOList.Columns("Status").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        'dgvPOList.Columns("Status").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
    End Sub

    Private Sub loadRelatedPO(sender As Object, e As EventArgs) Handles dgvPOList.CellClick
        _index = dgvPOList.CurrentRow.Index
        whereIs = dgvPOList.Item(0, _index).Value
        s.loadDTGN(dgvPODetails, "POCloseVoid", "ID, PONum as 'PO No.', Product, Quantity, unitPrice as 'Unit Cost', balance as 'Balance', Status", "PONum = " + whereIs, 4)
        dgvPODetails.Columns("Product").Width = 270
        dgvPODetails.Columns("Quantity").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgvPODetails.Columns("Quantity").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgvPODetails.Columns("Unit Cost").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgvPODetails.Columns("Unit Cost").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgvPODetails.Columns("Balance").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgvPODetails.Columns("Balance").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgvPODetails.Columns("Status").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgvPODetails.Columns("Status").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
    End Sub

    'fix
    Private Sub EnablePanelDate(sender As Object, e As EventArgs) Handles chkDatePeriod.CheckedChanged
        If chkDatePeriod.CheckState = CheckState.Checked Then
            panelDate.Enabled = True
        ElseIf chkDatePeriod.CheckState = CheckState.Unchecked Then
            panelDate.Enabled = False
        End If
    End Sub

    Private Sub cmbSupplierChanged(sender As Object, e As EventArgs) Handles cmbSupplier.SelectedIndexChanged
        c.clrDS(dgvPOList)
        c.clrDS(dgvPODetails)
    End Sub

    Private Sub PrintOrder(sender As Object, e As EventArgs) Handles btnPrint.Click
        c.SetID(dgvPOList.Item(0, dgvPOList.CurrentRow.Index).Value)
        PrintOnePO.Show()
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim list, temp As String
        'MsgBox(dgvPODetails.Rows.Count)
        For i As Integer = 1 To dgvPODetails.Rows.Count
            If i = dgvPODetails.Rows.Count Then
                temp = "'" + dgvPODetails.Item(2, i - 1).Value.ToString + "'"
                list = list + temp
            Else
                temp = "'" + dgvPODetails.Item(2, i - 1).Value.ToString + "',"
                list = list + temp
            End If
        Next
        'MsgBox(list)
        'c.SetID(dgvPOList.Item(0, dgvPOList.CurrentRow.Index).Value) 'for main report
        querPrevPrice = "select * from (select product,suppName,[Order Date],unitPrice,row_number() over(partition by product order by [Order Date] desc) as rn from PreviousPrices where unitPrice not like '0.00')t where t.rn = 1 and product in (" + list + ")"
        'And SupplierID = " + CStr(c.getData(cmbSupplier))
        'MsgBox(querPrevPrice)
        POwithPrc.Show()
    End Sub

End Class