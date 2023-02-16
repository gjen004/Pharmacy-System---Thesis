Public Class pointOfSale
    Dim c As New cControl
    Dim s As New cSQL

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblDT.Text = Format(Now, "MM-dd-yyyy hh:mm:ss")
    End Sub
    Private Sub pointOfSale_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True

        If cmbPromo.SelectedIndex = -1 Then
            txtFreeQuantity.Enabled = False
        End If
        s.loadCBX(cmbCustomer, "cmbCustomer", "ID", "custName")
        s.loadCBX(cmbDiscount, "discount", "ID", "DiscountName")
        s.loadDTG(dgvItemList, "ProductOnSale")
        c.FormProps(Me)
        s.clearTemp("tempBuyList")
        dgvQuant.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells
        btnSave.Enabled = False
        btnDiscCompute.Enabled = False
        txtQuantity.Enabled = False
        grpCheckout.Enabled = False
    End Sub

    Private Sub FormClose(sender As Object, e As EventArgs) Handles Me.Closed
        ReturnToStocks()
        s.clearTemp("tempBuyList")
    End Sub

    Private Sub LookForItem(sender As Object, e As EventArgs) Handles txtSearch.KeyDown
        Dim possib As String
        prodName = c.getData(txtSearch)
        If String.IsNullOrEmpty(prodName) = False Then
            possib = "Product = '" & prodName & "' or Product like '" & prodName & "%' or Product like '%" & prodName & "%' or Product like '%" & prodName & "'"
            s.loadDTGN(dgvItemList, "ProductOnSale", "", possib, 3)
        End If
    End Sub

    Private Sub hideID(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles dgvItemList.DataBindingComplete
        With dgvItemList
            .Columns("ID").Visible = False
            .Columns("deletedBy").Visible = False
            dgvItemList.ClearSelection()
        End With
    End Sub

    Private Sub LoadInventory(sender As Object, e As EventArgs) Handles dgvItemList.CellClick
        prodName = dgvItemList.Item(1, dgvItemList.CurrentRow.Index).Value
        s.loadDTGN(dgvQuant, "ShowProductQuantity", "", "Product = '" & prodName & "' and Quantity > 0 order by ProdExpDate, RRDate, RRNo", 3)
        txtQuantity.Text = ""
    End Sub

    Private Sub promoSelect(sender As Object, e As EventArgs) Handles cmbPromo.SelectedIndexChanged
        txtQuantity.Text = ""
    End Sub

    Private Sub hidesDGVORD(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles dgvQuant.DataBindingComplete
        With dgvQuant
            .Columns("Product").Visible = False
            .Columns("ID").Visible = False
            .Columns("RRDate").Visible = False
            dgvQuant.Columns(5).DefaultCellStyle.Format = "MM/dd/yyyy"

            dgvQuant.Columns("Price").DefaultCellStyle.Format = "N"
            dgvQuant.Columns("Quantity").DefaultCellStyle.Format = "#,###"

            dgvQuant.Columns("Price").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            dgvQuant.Columns("Price").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            dgvQuant.Columns("Quantity").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            dgvQuant.Columns("Quantity").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            dgvQuant.Columns("ProdExpDate").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            dgvQuant.Columns("ProdExpDate").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        End With
    End Sub

    Private Sub dgvQuantCellClick(sender As Object, e As EventArgs) Handles dgvQuant.CellClick
        point = dgvItemList.CurrentRow.Index
        prodName = dgvItemList.Item(1, point).Value
        s.loadCBXN(cmbPromo, "promoView", "ID", "Promo Name", " where [Product] like '" & prodName & "' and voidBy is NULL")
        txtQuantity.Enabled = True
        txtQuantity.Text = ""

    End Sub

    Private Sub freeQty(sender As Object, e As EventArgs) Handles txtQuantity.KeyUp
        If cmbPromo.SelectedIndex = -1 Then
            Exit Sub
        Else
            minQty = s.GetDetailStr("promoView", "[Min. Purchase]", "[Promo Name]", cmbPromo.Text)
            frQty = s.GetDetailStr("promoView", "[Free Qty]", "[Promo Name]", cmbPromo.Text)
            Dim multi As Double
            Dim res As Integer

            If txtQuantity.Text = "" Then
                txtFreeQuantity.Text = 0
                txtQuantity.Text = 0
            ElseIf txtQuantity.Text < minQty Then
                txtFreeQuantity.Text = 0
            ElseIf txtQuantity.Text >= minQty Then
                'res = Convert.ToInt32(txtFreeQuantity.Text)
                multi = CDbl(txtQuantity.Text) / minQty
                txtFreeQuantity.Text = Math.Floor(frQty * multi)
                'res = Math.Floor(res)
            End If
        End If
    End Sub

    Private Sub AddItem(sender As Object, e As EventArgs) Handles btnAdd.Click
        Try
            'minQty = s.GetDetailStr("promoView", "[Min. Purchase]", "[Promo Name]", cmbPromo.Text)
            '    frQty = s.GetDetailStr("promoView", "[Free Qty]", "[Promo Name]", cmbPromo.Text)

            'Dim freeProd As String = s.GetDetailStr("promoView", "[Free Product]", "[Promo Name]", cmbPromo.Text)
            Dim itemPrc As Integer
            Dim dspST, temp As Double
            Dim sbT, tax As Decimal
            Dim stx, upd, RRID, RRID2, stx2, upd2, balQty, freePrice As Integer
            Dim dt, dt2 As String
            promoSales = cmbPromo.Text

            freePrice = 0
            btnSave.Enabled = True
            'goint to ordersummary
            _index = dgvQuant.CurrentRow.Index
            qtyProd = c.getData(txtQuantity)
            'If CInt(qtyProd) > dgvQuant.Item(4, dgvQuant.CurrentRow.Index).Value Then
            '    MsgBox("Quantity Bought Cannot Exceed Stock Available", vbOKOnly, caption)
            '    qtyProd = Nothing
            '    Exit Sub
            If IsNumeric(qtyProd) = True Then
                If dgvQuant.SelectedRows.Count = 0 Then
                    MsgBox("No Item Selected", vbOKOnly, caption)
                    Exit Sub
                'ElseIf s.checkVal("tembuylist", "Product", dgvQuant.Item(2, dgvQuant.CurrentRow.Index).Value) Then
                '    MsgBox("Product already Added!", vbOKOnly, caption)
                '    Exit Sub
            ElseIf cmbPromo.SelectedIndex = -1 Then
                    'get product details
                    prodName = dgvQuant.Item(2, dgvQuant.CurrentRow.Index).Value 'name of item
                    itemPrc = dgvQuant.Item(3, dgvQuant.CurrentRow.Index).Value 'price of item
                    sbT = itemPrc * Convert.ToInt32(qtyProd) 'subtotal of selected item
                    dt = Format(dgvQuant.Item(5, _index).Value, "yyyy-MM-dd") 'get prod exp date
                    RRID = dgvQuant.Item(0, _index).Value
                    stx = s.GetQty(dgvQuant.Item(0, _index).Value)
                    upd = stx - qtyProd

                    If qtyProd > stx Then
                        RRID2 = dgvQuant.Item(0, _index + 1).Value
                        dt2 = Format(dgvQuant.Item(5, _index + 1).Value, "yyyy-MM-dd")
                        balQty = qtyProd - stx
                        stx2 = s.GetQty(dgvQuant.Item(0, _index + 1).Value)
                        upd2 = stx2 - balQty

                        s.RunQuery("UPDATE RRDetails set stock = '0' where ID = '" & RRID & "' and ProdExpDate = '" & dt & "'")
                        s.RunQuery("UPDATE RRDetails set stock = '" & upd2 & "' where ID = '" & RRID2 & "' and ProdExpDate = '" & dt2 & "'")
                        s.TempRecord(dgvOrderSummary, prodName, qtyProd, RRID, sbT, 0)

                        If txtTotal.Text = "" Then
                            txtTotal.Text = CStr(sbT)
                            tax = sbT * 0.12
                            txtVat.Text = CStr(tax)
                            txtVatSales.Text = (sbT - tax)
                        Else
                            dspST = CDbl(txtTotal.Text) + sbT
                            txtTotal.Text = CStr(dspST)
                            tax = sbT * 0.12
                            temp = sbT - tax
                            txtVat.Text = CStr(CDbl(txtVat.Text) + tax)
                            txtVat.Text = Format(Val(txtVat.Text), "N")
                            txtVatSales.Text = CStr(CDbl(txtVatSales.Text) + temp)
                            txtVatSales.Text = Format(Val(txtVatSales.Text), "N")
                        End If
                        cmbPromo.SelectedIndex = -1
                        txtFreeQuantity.Text = ""
                        c.clrDS(dgvQuant)
                        grpCheckout.Enabled = True

                    Else
                        'insert to tempList
                        s.RunQuery("UPDATE RRDetails set stock = '" & upd & "' where ID = '" & RRID & "' and ProdExpDate = '" & dt & "'")
                        s.TempRecord(dgvOrderSummary, prodName, qtyProd, RRID, sbT, 0)
                        s.loadDTGN(dgvQuant, "showProductQuantity", "", "Product = '" & prodName & "' and Quantity > 0", 3)

                        'If chkVAT.Checked = True Then
                        '    If txtTotal.Text = "" Then
                        '        tax = sbT * 0.12
                        '        txtTotal.Text = CStr(sbT - tax)
                        '        txtVat.Text = 0
                        '        txtVatSales.Text = 0
                        '    Else
                        '        dspST = CDbl(txtTotal.Text)
                        '    End If
                        'End If
                        If txtTotal.Text = "" Then
                            txtTotal.Text = CStr(sbT)
                            tax = sbT * 0.12
                            txtVat.Text = CStr(tax)
                            txtVatSales.Text = (sbT - tax)
                        Else
                            dspST = CDbl(txtTotal.Text) + sbT
                            txtTotal.Text = CStr(dspST)
                            tax = sbT * 0.12
                            temp = sbT - tax
                            txtVat.Text = CStr(CDbl(txtVat.Text) + tax)
                            txtVat.Text = Format(Val(txtVat.Text), "N")
                            txtVatSales.Text = CStr(CDbl(txtVatSales.Text) + temp)
                            txtVatSales.Text = Format(Val(txtVatSales.Text), "N")
                        End If
                        cmbPromo.SelectedIndex = -1
                        txtFreeQuantity.Text = ""
                        c.clrDS(dgvQuant)
                        grpCheckout.Enabled = True
                    End If

                ElseIf cmbPromo.SelectedIndex > -1 Then
                    frQty = c.getData(txtFreeQuantity)

                    prodName = dgvQuant.Item(2, dgvQuant.CurrentRow.Index).Value 'name of item
                    itemPrc = dgvQuant.Item(3, dgvQuant.CurrentRow.Index).Value 'price of item
                    sbT = itemPrc * Convert.ToInt32(qtyProd) 'subtotal of selected item
                    dt = Format(dgvQuant.Item(5, _index).Value, "yyyy-MM-dd") 'get prod exp date
                    RRID = dgvQuant.Item(0, _index).Value
                    stx = s.GetQty(dgvQuant.Item(0, _index).Value)
                    upd = stx - (qtyProd + frQty)

                    If (qtyProd + frQty) > stx Then
                        RRID2 = dgvQuant.Item(0, _index + 1).Value
                        dt2 = Format(dgvQuant.Item(5, _index + 1).Value, "yyyy-MM-dd")
                        balQty = (qtyProd + frQty) - stx
                        stx2 = s.GetQty(dgvQuant.Item(0, _index + 1).Value)
                        upd2 = stx2 - balQty

                        s.RunQuery("UPDATE RRDetails set stock = '0' where ID = '" & RRID & "' and ProdExpDate = '" & dt & "'")
                        s.RunQuery("UPDATE RRDetails set stock = '" & upd2 & "' where ID = '" & RRID2 & "' and ProdExpDate = '" & dt2 & "'")
                        s.TempRecord(dgvOrderSummary, prodName, qtyProd, RRID, sbT, txtFreeQuantity.Text)

                        If txtTotal.Text = "" Then
                            txtTotal.Text = CStr(sbT)
                            tax = sbT * 0.12
                            txtVat.Text = CStr(tax)
                            txtVat.Text = Format(Val(txtVat.Text), "N")
                            txtVatSales.Text = (sbT - tax)
                            txtVatSales.Text = Format(Val(txtVatSales.Text), "N")
                        Else
                            dspST = CDbl(txtTotal.Text) + sbT
                            txtTotal.Text = CStr(dspST)
                            tax = sbT * 0.12
                            temp = sbT - tax
                            txtVat.Text = CStr(CDbl(txtVat.Text) + tax)
                            txtVat.Text = Format(Val(txtVat.Text), "N")
                            txtVatSales.Text = CStr(CDbl(txtVatSales.Text) + temp)
                            txtVatSales.Text = Format(Val(txtVatSales.Text), "N")
                        End If

                        cmbPromo.SelectedIndex = -1
                        txtFreeQuantity.Text = ""
                        c.clrDS(dgvQuant)
                        grpCheckout.Enabled = True

                    Else
                        s.RunQuery("UPDATE RRDetails set stock = '" & upd & "' where ID = '" & RRID & "' and ProdExpDate = '" & dt & "'")
                        s.TempRecord(dgvOrderSummary, prodName, qtyProd, RRID, sbT, txtFreeQuantity.Text)
                        's.TempRecord(dgvOrderSummary, prodName, txtFreeQuantity.Text, RRID, freePrice)

                        If txtTotal.Text = "" Then
                            txtTotal.Text = CStr(sbT)
                            tax = sbT * 0.12
                            txtVat.Text = CStr(tax)
                            txtVat.Text = Format(Val(txtVat.Text), "N")
                            txtVatSales.Text = (sbT - tax)
                            txtVatSales.Text = Format(Val(txtVatSales.Text), "N")
                        Else
                            dspST = CDbl(txtTotal.Text) + sbT
                            txtTotal.Text = CStr(dspST)
                            tax = sbT * 0.12
                            temp = sbT - tax
                            txtVat.Text = CStr(CDbl(txtVat.Text) + tax)
                            txtVat.Text = Format(Val(txtVat.Text), "N")
                            txtVatSales.Text = CStr(CDbl(txtVatSales.Text) + temp)
                            txtVatSales.Text = Format(Val(txtVatSales.Text), "N")
                        End If

                        cmbPromo.SelectedIndex = -1
                        txtFreeQuantity.Text = ""
                        c.clrDS(dgvQuant)
                        grpCheckout.Enabled = True
                    End If
                End If



            Else
                MsgBox("Invalid Quantity", vbOKOnly, caption)
                txtQuantity.Select()
            End If
            txtTotal.Text = Format(Val(txtTotal.Text), "N")
            'reset values
            txtQuantity.Text = ""
            qtyProd = Nothing
            _index = Nothing
            prodName = Nothing
            cmbDiscount.Enabled = True
        Catch ex As Exception
        Dim msg1 As String = ex.GetType.ToString
        If msg1 = "System.NullReferenceException" Then
            MsgBox("No Item Selected", vbOKOnly, caption)
        End If
        End Try
    End Sub

    Private Sub hides(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles dgvOrderSummary.DataBindingComplete
        With dgvOrderSummary
            .Columns("stockID").Visible = False

            dgvOrderSummary.Columns("Subtotal").DefaultCellStyle.Format = "N"
            dgvOrderSummary.Columns("Quantity").DefaultCellStyle.Format = "#,###"
            dgvOrderSummary.Columns("FreeQuantity").DefaultCellStyle.Format = "#,###"

            dgvOrderSummary.Columns("Quantity").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            dgvOrderSummary.Columns("Quantity").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            dgvOrderSummary.Columns("FreeQuantity").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            dgvOrderSummary.Columns("FreeQuantity").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            dgvOrderSummary.Columns("Subtotal").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            dgvOrderSummary.Columns("Subtotal").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        End With
    End Sub

    'Private Sub dscnt(sender As Object, e As EventArgs) Handles cmbDiscount.SelectedIndexChanged
    '    Dim num As Integer = s.GetCount("sales")
    '    Dim dscntType As Integer
    '    dscntType = c.getData(cmbDiscount)
    '    Dim st, dspSTDsc, per As Double
    '    If dscntType > 0 Then
    '        per = CDbl(s.getDsc(dscntType)) / 100
    '        st = CDbl(txtTotal.Text) * per
    '        dspSTDsc = CDbl(txtTotal.Text) - st
    '        txtTotal.Text = CStr(dspSTDsc)
    '        Dim msg As String = "Please Pay: " + CStr(dspSTDsc)
    '    End If
    'End Sub

    Private Sub checkout(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim num As Integer = s.GetCount("sales")
        'Dim dscntType As Integer = c.getData(cmbDiscount)
        Dim dscntType As String = cmbDiscount.Text
        Dim st, dspSTDsc, per As Double
        Dim cash As String
        cash = c.getData(txtCash)
        'If dscntType = 0 Then
        '    MsgBox("Discount does not exists", vbOKOnly, caption)
        '    cmbDiscount.Select()
        '    Exit Sub
        'If cmbDiscount.SelectedIndex = -1 Then
        '    per = 0
        '    dscntType = ""
        'ElseIf txtCash.Text = "" Then
        '    MsgBox("Please enter cash!", vbOKOnly, caption)
        '    Exit Sub
        If cmbDiscount.SelectedIndex > -1 Then
            If txtCash.Text = "" Then
                MsgBox("Please enter Cash!", vbOKOnly, caption)
                txtCash.Select()
                Exit Sub
            ElseIf CDbl(c.getData(txtTotal)) > CDbl(c.getData(txtCash)) Then
                MsgBox("Insufficient cash!", vbOKOnly, caption)
                txtCash.Select()
                Exit Sub
            End If
        ElseIf String.IsNullOrEmpty(cash) Then
            MsgBox("Please enter Cash!", vbOKOnly, caption)
            txtCash.Select()
            Exit Sub
        ElseIf CDbl(c.getData(txtTotal)) > CDbl(c.getData(txtCash)) Then
            MsgBox("Insufficient cash!", vbOKOnly, caption)
            Exit Sub
        ElseIf cmbDiscount.SelectedIndex = -1 Then
            per = 0
            dscntType = ""
            'Else
            '    per = CDbl(s.getDsc(dscntType)) / 100
            '    st = CDbl(txtTotal.Text) * per
            '    dspSTDsc = CDbl(txtTotal.Text) - st
            '    txtTotal.Text = CStr(dspSTDsc)
            '    Dim msg As String = "Please Pay: " + CStr(dspSTDsc)
            '    MsgBox(msg, vbOKOnly, caption)
        End If
        custID = c.getData(cmbCustomer)
        empName = s.GetDetailStr("employeeView", "EmployeeName", "userName", username)
        s.RunQuery("Insert into sales(salesNO,customerID,discountName,Amount,savedBy,savedDT) values('" & num & "','" & custID & "', '" & dscntType & "','" & CDbl(txtTotal.Text) & "','" & empName & "',GETDATE())")
        MsgBox("Transaction Complete!", vbOKOnly, caption)
        cmbDiscount.SelectedIndex = -1
        RunLoop(num)
        FormReset()
        s.loadDTG(dgvItemList, "ProductOnSale")
        grpCheckout.Enabled = False
        chkVAT.Checked = False
    End Sub

    Private Sub RunLoop(ByVal salesNum As Integer)
        Try

            dgvOrderSummary.Rows(0).Selected = True
            'Dim totamnt As Double
            For index As Integer = 0 To c.countDtgItem(dgvOrderSummary)
                'pID = Convert.ToInt32(s.getProdID(dgvOrderSummary.Item(0, index).Value))
                prodSales = dgvOrderSummary.Item(0, index).Value
                qtyProd = dgvOrderSummary.Item(1, index).Value
                transAmt = dgvOrderSummary.Item(3, index).Value
                RRDiD = dgvOrderSummary.Item(4, index).Value
                'promo = cmbPromo.Text
                freeProd = dgvOrderSummary.Item(2, index).Value
                'If cmbPromo.SelectedIndex = -1 Then
                '    promo = ""
                '    freeProd = 0
                'End If

                's.salesDets(salesNum, pID, qtyProd, freeProd, promo, RRDiD)
                s.RunQuery("Insert into salesDetailss(salesID,prodName,quantity,freeQty,promoName,Total,stockID) values('" & salesNum & "', '" & prodSales & "', '" & qtyProd & "', '" & freeProd & "', '" & promoSales & "', '" & transAmt & "', '" & RRDiD & "')")
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub DispChange(sender As Object, e As EventArgs) Handles txtCash.KeyUp
        Dim totaltemp As String = txtTotal.Text
        Dim paidtemp As String = txtCash.Text
        Dim total, paid As Double
        If txtCash.Text = "" Then
            Exit Sub
        ElseIf txtTotal.Text = "" Then
            Exit Sub
        Else
            total = CDbl(totaltemp)
            paid = CDbl(paidtemp)
            Dim comp As Double
            comp = paid - total
            txtChange.Text = comp
            txtChange.Text = Format(Val(txtChange.Text), "N")
        End If
    End Sub

    Private Sub FormReset()
        c.clrDS(dgvOrderSummary)
        c.clrDS(dgvQuant)
        c.clrData(grpCheckout)
        c.clrDS(dgvItemList)
        s.clearTemp("tempBuyList")
        txtTotal.Text = Nothing
        txtVat.Text = Nothing
        txtVatSales.Text = Nothing
    End Sub

    Private Sub ComputeDiscount(sender As Object, e As EventArgs) Handles cmbDiscount.SelectedIndexChanged
        btnDiscCompute.Enabled = True
        'If cmbDiscount.SelectedIndex = -1 Then
        '    Exit Sub
        'End If
        'Dim dscntType As Integer
        'Dim st, dspSTDsc As Double
        'Dim per As Double = CDbl(s.getDsc(dscntType)) / 100
        'If dscntType = 0 Then
        '    'MsgBox("Discount does Not exists")
        '    Exit Sub
        'ElseIf dscntType = 1 Then
        '    Exit Sub
        '    'ElseIf cmbDiscount.SelectedIndex > -1 Then
        '    '    'Dim dscntType As Integer
        '    '    'Dim st, dspSTDsc As Double
        '    '    Dim test As String = s.GetDetailStr("discount", "PercentDscnt", "DiscountName", cmbDiscount.Text)
        '    '    MsgBox(test)
        '    '    Dim st, dspSTDsc As Double
        '    '    Dim per As Double
        '    st = CDbl(txtTotal.Text) * per
        '    dspSTDsc = CDbl(txtTotal.Text) - st
        '    txtTotal.Text = CStr(dspSTDsc)
        '    MsgBox(dspSTDsc)
        'End If
        'If cmbDiscount.SelectedIndex = -1 Then
        '    Exit Sub
        'Else
        '    Dim dis As Integer
        '    dis = s.GetDetailStr("discount", "PercentDscnt", "DiscountName", test)
        '    Dim st, dspSTDsc As Double
        '    Dim per As Double
        '    per = dis / 100
        '    st = CDbl(txtTotal.Text) * per
        '    dspSTDsc = CDbl(txtTotal.Text) - st
        '    txtTotal.Text = CStr(dspSTDsc)
        '    MsgBox(dspSTDsc)
        'End If
    End Sub

    Private Sub ReturnToStocks()
        Dim stx, qty, newQ As Integer
        For index As Integer = 0 To c.countDtgItem(dgvOrderSummary)
            stx = dgvOrderSummary.Item(4, index).Value
            qty = (dgvOrderSummary.Item(1, index).Value) + (dgvOrderSummary.Item(2, index).Value)
            Dim existing As Integer = s.GetDetail("ShowProductQuantity", "Quantity", "ID", stx)
            'MsgBox(existing)
            newQ = existing + qty
            'MsgBox(newQ)
            s.RunQuery("UPDATE RRDetails Set stock = '" & newQ & "' where ID = '" & stx & "'")

        Next
        s.clearTemp("tempBuyList")
    End Sub

    Private Sub refreshssss(sender As Object, e As EventArgs) Handles btnRef.Click
        ReturnToStocks()
        c.clrDS(dgvOrderSummary)
        c.clrDS(dgvQuant)
        dgvItemList.ClearSelection()
    End Sub

    Private Sub BtnDiscCompute_Click(sender As Object, e As EventArgs) Handles btnDiscCompute.Click
        Dim num As Integer = s.GetCount("sales")
        Dim dscntType As Integer = c.getData(cmbDiscount)
        Dim st, dspSTDsc, per, tax, computed As Double

        If chkVAT.Checked = True Then
            'tax = CDbl(txtTotal.Text) * 0.12
            computed = CStr(CDbl(txtTotal.Text) / 1.12)
            txtVat.Text = 0
            txtVatSales.Text = 0

            'If dscntType = 0 Then
            '    MsgBox("Discount does not exists", vbOKOnly, caption)
            '    cmbDiscount.Select()
            '    Exit Sub
            'Else
            If dscntType = -1 Then
                per = 0
                txtTotal.Text = CStr(computed)
                txtTotal.Text = Format(Val(txtTotal.Text), "N")
                'ElseIf txtCash.Text = "" Then
                '    MsgBox("Please enter Cash!", vbOKOnly, caption)
                '    txtCash.Select()
                '    Exit Sub
                'ElseIf txtCash.Text < txtTotal.Text Then
                '    MsgBox("Insufficient cash!", vbOKOnly, caption)
                '    txtCash.Select()
                '    Exit Sub
            Else
                per = CDbl(s.getDsc(dscntType)) / 100
                st = CDbl(computed) * per
                dspSTDsc = CDbl(computed) - st
                txtTotal.Text = CStr(dspSTDsc)
                txtTotal.Text = Format(Val(txtTotal.Text), "N")
                'Dim msg As String = "Please Pay: " + CStr(dspSTDsc)
                'MsgBox(msg, vbOKOnly, caption)
                cmbDiscount.Enabled = False
                Exit Sub
            End If
        Else
            'If cmbDiscount.SelectedIndex Then
            'ElseIf dscntType = 0 Then
            '    MsgBox("Discount does not exists", vbOKOnly, caption)
            '    cmbDiscount.Select()
            '    Exit Sub
            If dscntType = -1 Then
                per = 0
                'ElseIf txtCash.Text = "" Then
                '    MsgBox("Please enter Cash!", vbOKOnly, caption)
                '    txtCash.Select()
                '    Exit Sub
                'ElseIf txtCash.Text < txtTotal.Text Then
                '    MsgBox("Insufficient cash!", vbOKOnly, caption)
                '    txtCash.Select()
                '    Exit Sub
            Else
                per = CDbl(s.getDsc(dscntType)) / 100
                st = CDbl(txtTotal.Text) * per
                dspSTDsc = CDbl(txtTotal.Text) - st
                txtTotal.Text = CStr(dspSTDsc)
                txtTotal.Text = Format(Val(txtTotal.Text), "N")
                'Dim msg As String = "Please Pay: " + CStr(dspSTDsc)
                'MsgBox(msg, vbOKOnly, caption)
                cmbDiscount.Enabled = False
                Exit Sub
            End If
        End If


    End Sub

    Private Sub btnDisable(sender As Object, e As EventArgs) Handles btnDiscCompute.Click
        btnDiscCompute.Enabled = False
    End Sub

    Private Sub chkstate(sender As Object, e As EventArgs) Handles chkVAT.CheckStateChanged
        btnDiscCompute.Enabled = True
    End Sub

End Class
