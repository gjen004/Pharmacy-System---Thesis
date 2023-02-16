Public Class salesRecord
    Dim c As New cControl
    Dim s As New cSQL

    Private Sub LoadForm(sender As Object, e As EventArgs) Handles MyBase.Load
        'dateSR.Format = DateTimePickerFormat.Custom
        'dateSR.CustomFormat = "MM/dd/yyyy"
        's.loadDTG(dgvSR, "sales")
        'dgvSales.Columns(6).DefaultCellStyle.Format = "MM/dd/yyyy HH:mm"
        panelDate.Enabled = False
        c.formatDTP(dateFrom, dateTo)
    End Sub

    Private Sub hides(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles dgvSR.DataBindingComplete
        With dgvSR

            dgvSR.Columns("Amount").DefaultCellStyle.Format = "N"
            dgvSR.Columns("Quantity").DefaultCellStyle.Format = "#,###"
            dgvSR.Columns("FreeQuantity").DefaultCellStyle.Format = "#,###"

            dgvSR.Columns("Quantity").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            dgvSR.Columns("Quantity").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            dgvSR.Columns("Promo").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            dgvSR.Columns("Promo").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            dgvSR.Columns("FreeQuantity").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            dgvSR.Columns("FreeQuantity").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            dgvSR.Columns("Discount").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            dgvSR.Columns("Discount").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            dgvSR.Columns("Amount").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            dgvSR.Columns("Amount").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            dgvSR.Columns("Saved By").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            dgvSR.Columns("Saved By").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        End With
    End Sub

    Private Sub BtnSRPrint_Click(sender As Object, e As EventArgs) Handles btnSRPrint.Click
        print1.Show()
    End Sub

    Private Sub BtnSRSearch_Click(sender As Object, e As EventArgs)
        Dim dt As String
        'dt = c.getData(dateSR)
        MsgBox(dt)
        s.loadDTGN(dgvSR, "sales", "", "savedDT like '" & dt & "'", 3)
    End Sub

    Private Sub BtnCheck_Click(sender As Object, e As EventArgs) Handles btnCheck.Click
        If chkDatePeriod.Checked = True Then
            panelDate.Enabled = True
            startAt = c.getData(dateFrom)
            endsAt = c.getData(dateTo)
            'If String.IsNullOrEmpty(suppName) = True Then
            '    MsgBox("Please Select a Supplier!")
            '    Exit Sub
            'ElseIf s.checkValStr("cmbSupp", "suppname", suppName) = False Then
            '    MsgBox("Supplier Does not Exist!")
            '    suppName = Nothing
            '    Exit Sub
            If String.IsNullOrEmpty(startAt) = True And String.IsNullOrEmpty(endsAt) = True Then
                MsgBox("Please Select Date Range!")
                Exit Sub
            ElseIf String.IsNullOrEmpty(startAt) = True Or String.IsNullOrEmpty(endsAt) = True Then
                MsgBox("Please Select Date Range!")
                Exit Sub
                'ElseIf String.IsNullOrEmpty(startAt) = True Or String.IsNullOrEmpty(endsAt) = True Or String.IsNullOrEmpty(suppName) = True Then
                '    MsgBox("Please Fill In All Fields!")
                '    Exit Sub
            Else
                If c.getRange(startAt, endsAt) = True Then
                    'MsgBox("Invalid Date Selection!")
                    Exit Sub
                Else
                    s.loadDTGN(dgvSales, "sales", "salesNo as 'Sales No.', savedDT as 'DateTime', Amount", "savedDT between '" & startAt & "' and '" & endsAt & "'", 4)
                End If
            End If
        ElseIf chkDatePeriod.Checked = False Then
            s.loadDTGN(dgvSales, "sales", "salesNo as 'Sales No.', savedDT as 'DateTime', Amount", "", 2)
        End If

    End Sub

    Private Sub salesClick(sender As Object, e As EventArgs) Handles dgvSales.CellClick
        Dim index As Integer
        index = dgvSales.CurrentRow.Index
        num = dgvSales.Item(0, index).Value
        's.loadDTGX(dgvSR, "salesView", num)
        s.loadDTGX(dgvSR, "salesView", "salesNo as 'Sales No.', Product, Quantity, Promo, FreeQuantity, Discount, Amount, savedBy as 'Saved By'", num)
        txtTotal.Text = dgvSales.Item(2, index).Value
        txtTotal.Text = Format(Val(txtTotal.Text), "N")
    End Sub

    Private Sub dgvSalesBinding(sender As Object, e As EventArgs) Handles dgvSales.DataBindingComplete
        With dgvSales
            .Columns("Amount").Visible = False
            dgvSales.Columns(1).DefaultCellStyle.Format = "MM/dd/yyyy HH:mm"

            dgvSales.Columns("Sales No.").Width = 100

            dgvSales.Columns("Sales No.").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            dgvSales.Columns("Sales No.").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            dgvSales.Columns("DateTime").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            dgvSales.Columns("DateTime").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        End With
    End Sub

    Private Sub BtnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        c.clrDS(dgvSales)
        c.clrDS(dgvSR)
        chkDatePeriod.Checked = False
        panelDate.Enabled = False
        txtTotal.Text = ""
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub EnablePanelDate(sender As Object, e As EventArgs) Handles chkDatePeriod.CheckedChanged
        If chkDatePeriod.CheckState = CheckState.Checked Then
            panelDate.Enabled = True
        ElseIf chkDatePeriod.CheckState = CheckState.Unchecked Then
            panelDate.Enabled = False
        End If
    End Sub

    Private Sub ClearRRList(sender As Object, e As EventArgs) Handles dateFrom.TextChanged, dateTo.TextChanged
        c.clrDS(dgvSales)
        c.clrDS(dgvSR)
    End Sub
End Class