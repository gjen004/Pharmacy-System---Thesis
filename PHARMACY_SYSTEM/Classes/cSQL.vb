Imports System.Data.Sql
Imports System.Data.SqlClient
'logs and new fixes
'dec 26
'fixed combobox autocomplete and dropdown style

Public Class cSQL

    Public Function hasConnect() As Boolean
        Try
            SQLCon.Open()
            SQLCon.Close()
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function
    Public Sub RunQuery(ByVal Query As String)
        Try
            SQLCon.Open()
            SQLCmd = New SqlCommand(Query, SQLCon)
            SQLDA = New SqlDataAdapter(SQLCmd)
            SQLDA.Fill(SQLDataset)
            SQLCon.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            If SQLCon.State = ConnectionState.Open Then
                SQLCon.Close()
            End If
        End Try
    End Sub
    'loading DTG, CBX
    Public Sub loadCBX(ByRef cbx As ComboBox, ByVal table As String, ByVal valMem As String, ByVal dspMem As String)
        SQLCon.Open()
        Dim quer As String = "select * from " + table
        Dim da As New SqlDataAdapter(quer, SQLCon)
        Dim ds As New DataSet
        da.Fill(ds, table)
        SQLCon.Close()
        cbx.DataSource = ds.Tables(0)
        cbx.ValueMember = valMem
        cbx.DisplayMember = dspMem
        cbx.SelectedIndex = -1
        'fix
        cbx.DropDownStyle = ComboBoxStyle.DropDown
        cbx.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        cbx.AutoCompleteSource = AutoCompleteSource.ListItems
    End Sub
    Public Sub loadCBXN(ByRef cbx As ComboBox, ByVal table As String, ByVal valMem As String, ByVal dspMem As String, ByVal condition As String)
        SQLCon.Open()
        Dim quer As String = "select * from " + table + " " + condition
        Dim da As New SqlDataAdapter(quer, SQLCon)
        Dim ds As New DataSet
        da.Fill(ds, table)
        SQLCon.Close()
        cbx.DataSource = ds.Tables(0)
        cbx.ValueMember = valMem
        cbx.DisplayMember = dspMem
        cbx.SelectedIndex = -1
        'fix
        cbx.DropDownStyle = ComboBoxStyle.DropDown
        cbx.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        cbx.AutoCompleteSource = AutoCompleteSource.ListItems
    End Sub

    Public Sub loadDTGN(ByRef dt As DataGridView, ByVal table As String, ByVal Col As String, ByVal con As String, ByVal mode As Integer)
        If mode = 1 Then 'normal select all
            Dim quer As String = "select * from " + table
            Dim da As New SqlDataAdapter(quer, SQLCon)
            Dim ds As New DataSet
            da.Fill(ds, table)
            SQLCon.Close()
            dt.DataSource = ds.Tables(0)
            dt.DataSource = ds.Tables(0)
            dt.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            dt.RowHeadersVisible = False
            dt.SelectionMode = DataGridViewSelectionMode.FullRowSelect
            dt.ClearSelection()
            dt.AllowUserToAddRows = False
            dt.AllowUserToResizeRows = False
            Exit Sub
        ElseIf mode = 2 Then 'specific columns only
            Dim quer As String = "select " + Col + " from " + table
            Dim da As New SqlDataAdapter(quer, SQLCon)
            Dim ds As New DataSet
            da.Fill(ds, table)
            SQLCon.Close()
            dt.DataSource = ds.Tables(0)
            dt.DataSource = ds.Tables(0)
            dt.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            dt.RowHeadersVisible = False
            dt.SelectionMode = DataGridViewSelectionMode.FullRowSelect
            dt.ClearSelection()
            dt.AllowUserToAddRows = False
            dt.AllowUserToResizeRows = False
            Exit Sub
        ElseIf mode = 3 Then 'condition
            Dim quer As String = "SELECT * FROM " + table + " where " + con
            Dim da As New SqlDataAdapter(quer, SQLCon)
            Dim ds As New DataSet
            da.Fill(ds, table)
            SQLCon.Close()
            dt.DataSource = ds.Tables(0)
            dt.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            dt.RowHeadersVisible = False
            dt.SelectionMode = DataGridViewSelectionMode.FullRowSelect
            dt.ClearSelection()
            dt.AllowUserToAddRows = False
            dt.AllowUserToResizeRows = False
            Exit Sub
        ElseIf mode = 4 Then 'columns and condition
            Dim quer As String = "SELECT " + Col + " FROM " + table + " where " + con
            Dim da As New SqlDataAdapter(quer, SQLCon)
            Dim ds As New DataSet
            da.Fill(ds, table)
            SQLCon.Close()
            dt.DataSource = ds.Tables(0)
            dt.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            dt.RowHeadersVisible = False
            dt.SelectionMode = DataGridViewSelectionMode.FullRowSelect
            dt.ClearSelection()
            dt.AllowUserToAddRows = False
            dt.AllowUserToResizeRows = False
            Exit Sub
        ElseIf mode = 5 Then
            Dim quer As String = "SELECT TOP 1 * FROM " + table + " where " + con
            Dim da As New SqlDataAdapter(quer, SQLCon)
            Dim ds As New DataSet
            da.Fill(ds, table)
            SQLCon.Close()
            dt.DataSource = ds.Tables(0)
            dt.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            dt.RowHeadersVisible = False
            dt.SelectionMode = DataGridViewSelectionMode.FullRowSelect
            dt.ClearSelection()
            dt.AllowUserToAddRows = False
            dt.AllowUserToResizeRows = False
            Exit Sub
        End If
    End Sub

    Public Sub loadDTGX(ByRef dt As DataGridView, ByVal table As String, ByVal col As String, ByVal con As Integer)
        SQLCon.Open()
        Dim quer As String = "SELECT " & col & " FROM " & table & " where salesNo = '" & con & "'"
        Dim da As New SqlDataAdapter(quer, SQLCon)
        Dim ds As New DataSet
        da.Fill(ds, table)
        SQLCon.Close()
        dt.DataSource = ds.Tables(0)
        dt.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dt.RowHeadersVisible = False
        dt.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dt.ClearSelection()
        dt.AllowUserToAddRows = False
        dt.AllowUserToResizeRows = False
    End Sub

    Public Sub loadDTG(ByRef dt As DataGridView, ByVal table As String)
        Dim quer As String = "select * from " + table
        Dim da As New SqlDataAdapter(quer, SQLCon)
        Dim ds As New DataSet
        da.Fill(ds, table)
        SQLCon.Close()
        dt.DataSource = ds.Tables(0)
        dt.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dt.RowHeadersVisible = False
        dt.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dt.ClearSelection()
        dt.AllowUserToAddRows = False
        dt.AllowUserToResizeRows = False
    End Sub

    'databank
    Public Sub addToDataByTXT(ByRef txt As TextBox, ByRef dt As DataGridView, ByVal type As Integer)
        If type = 1 Then
            RunQuery("Insert into category(categName) values('" & txt.Text & "')")
            MsgBox("Added Successfully!")
            loadDTG(dt, "category")
        ElseIf type = 2 Then
            RunQuery("Insert into bank(bankName) values('" & txt.Text & "')")
            MsgBox("Added Successfully!")
            loadDTG(dt, "bank")
        ElseIf type = 3 Then
            RunQuery("Insert into city(cityName) values('" & txt.Text & "')")
            MsgBox("Added Successfully!")
            loadDTG(dt, "city")
        ElseIf type = 4 Then
            RunQuery("Insert into discount(dscType) values('" & txt.Text & "')")
            MsgBox("Added Successfully!")
            loadDTG(dt, "discount")
        ElseIf type = 5 Then
            RunQuery("Insert into dosage(dsgName) values('" & txt.Text & "')")
            MsgBox("Added Successfully!")
            loadDTG(dt, "dosage")
        ElseIf type = 6 Then
            RunQuery("Insert into form(formName) values('" & txt.Text & "')")
            MsgBox("Added Successfully!")
            loadDTG(dt, "form")
        ElseIf type = 7 Then
            RunQuery("Insert into generic(genName) values('" & txt.Text & "')")
            MsgBox("Added Successfully!")
            loadDTG(dt, "generic")
        ElseIf type = 8 Then
            RunQuery("Insert into province(provinceName) values('" & txt.Text & "')")
            MsgBox("Added Successfully!")
            loadDTG(dt, "province")
        ElseIf type = 9 Then
            RunQuery("Insert into productUnit(unitMsr) values('" & txt.Text & "')")
            MsgBox("Added Successfully!")
            loadDTG(dt, "productUnit")
        ElseIf type = 10 Then
            RunQuery("Insert into reason(fullReason) values('" & txt.Text & "')")
            MsgBox("Added Successfully!")
            loadDTG(dt, "reason")
        ElseIf type = 11 Then
            RunQuery("Insert into empPosition(empPosName) values('" & txt.Text & "')")
            MsgBox("Added Successfully!")
            loadDTG(dt, "empPosition")
        End If
    End Sub
    Public Sub addPromo(ByRef dt As DataGridView, ByVal table As String, ByVal prodID As Integer, ByVal startDT As String, ByVal endDT As String, ByVal minQty As Integer, ByVal frQty As Integer, ByVal savedBy As String, ByVal promoName As String)
        Dim quer As String
        quer = "Insert INTO promo(PromoName,ProductID,minQty,freeQty,StartDate,EndDate,savedBy,savedDT) "
        quer = quer + "values('" & promoName & "','" & prodID & "','" & minQty & "','" & frQty & "','" & startDT & "','" & endDT & "','" & savedBy & "', GETDATE())"
        Dim da As New SqlDataAdapter(quer, SQLCon)
        Dim ds As New DataSet
        da.Fill(ds, table)
        MsgBox("New Promo Added!", vbOKOnly, caption)
        loadDTGN(dt, "promoView", "", "voidBy is NULL", 3)
    End Sub
    Public Sub addDsc(ByRef dt As DataGridView, ByVal table As String, ByVal name As String, ByVal percentage As Integer)
        Dim quer As String
        quer = "INSERT INTO discount(DiscountName,PercentDscnt) values('" & name & "','" & percentage & "')"
        Dim da As New SqlDataAdapter(quer, SQLCon)
        Dim ds As New DataSet
        da.Fill(ds, table)
        MsgBox("Item Added!", vbOKOnly, caption)
        loadDTG(dt, "discount")
    End Sub
    'delete function
    Public Sub delete(ByRef dt As DataGridView, ByVal table As String, ByVal id As Integer)
        Dim quer As String
        quer = "DELETE FROM " + table
        quer = quer + " WHERE ID = " + CStr(id)
        Dim da As New SqlDataAdapter(quer, SQLCon)
        Dim ds As New DataSet
        da.Fill(ds, table)
    End Sub
    Public Sub softdelete(ByRef dt As DataGridView, ByVal table As String, ByVal id As Integer, ByVal sino As String)
        Dim quer As String
        quer = "UPDATE " + table + " SET deletedBy = '" & sino & "', deletedDT = GETDATE()"
        quer = quer + " WHERE ID = " + CStr(id)
        Dim da As New SqlDataAdapter(quer, SQLCon)
        Dim ds As New DataSet
        da.Fill(ds, table)
        MsgBox("Item Removed!", vbOKOnly, caption)
    End Sub

    'products
    Public Sub addProduct(ByRef dt As DataGridView, ByVal table As String, ByVal prod As String, ByVal cat As Integer, ByVal brnd As String, ByVal gn As Integer, ByVal dos As Integer, ByVal unt As Integer, ByVal frm As Integer, ByVal stat As Integer, ByVal user As String, ByRef btn As Button)
        'SQLCon.Open()
        'Dim checkQuery1 As String = "select * from " & table & " where proCode = '" & prod & "'"
        'Dim cmd As SqlCommand = New SqlCommand(checkQuery1, SQLCon)
        'Using reader As SqlDataReader = cmd.ExecuteReader()
        '    If reader.HasRows Then
        '        MsgBox("Invalid Input! Product Code already exist!")
        '        SQLCon.Close()
        '        btn.Enabled = False
        '        Exit Sub
        '    Else
        'reader.Close()
        Dim quer As String
        quer = "Insert into product(proCode,categID,genericID,brandName,prodUnit,dosageID,formID,prodStatID,savedBy,SavedDT) "
        quer = quer + "values ('" & prod & "','" & cat & "','" & gn & "','" & brnd & "','" & unt & "','" & dos & "','" & frm & "','" & stat & "','" & user & "',GETDATE())"

        Dim da As New SqlDataAdapter(quer, SQLCon)
        Dim ds As New DataSet
        da.Fill(ds, table)
        MsgBox("Product Added Successfully!", vbOKOnly, caption)
        loadDTG(dt, "viewproduct")

        '    End If
        'End Using
    End Sub
    Public Sub updProd(ByVal id As Integer, ByRef dt As DataGridView, ByVal table As String, ByVal prod As String, ByVal cat As Integer, ByVal brnd As String, ByVal gn As Integer, ByVal dos As Integer, ByVal unt As Integer, ByVal frm As Integer, ByVal stat As Integer, ByVal user As String, ByRef btn As Button)
        Dim quer As String
        quer = "UPDATE product SET "
        quer = quer + "proCode = '" & prod & "', categID = '" & cat & "',genericId = '" & gn & "', brandName = '" & brnd & "',prodUnit = '" & unt & "',dosageID = '" & dos & "',formID = '" & frm & "', prodStatID = '" & stat & "',updatedBy = '" & user & "',updatedDT = GETDATE() where ID = '" & id & "'"

        Dim da As New SqlDataAdapter(quer, SQLCon)
        Dim ds As New DataSet
        da.Fill(ds, table)
        MsgBox("Product Updated Successfully!", vbOKOnly, caption)
        loadDTG(dt, "viewproduct")
        btn.Enabled = False
    End Sub

    'employee
    Public Sub addEmployee(ByRef dt As DataGridView, ByVal table As String, ByVal fnm As String, ByVal lnm As String, ByVal sx As String, ByVal pos As String, ByVal hdate As String, ByVal usr As String, ByVal pss As String, ByVal savedBy As String, ByRef btn As Button)
        'SQLCon.Open()
        'SQLCon.Open()
        'Dim checkQuery As String = "select * from " & table & " where userName = '" & usr & "'"
        'Dim cmd As SqlCommand = New SqlCommand(checkQuery, SQLCon)
        'Using reader As SqlDataReader = cmd.ExecuteReader()
        '    If reader.HasRows Then
        '        MsgBox("Invalid Input! Username already taken!")
        '        btn.Enabled = False
        '        SQLCon.Close()
        '        Exit Sub
        '    Else
        '        reader.Close()
        Dim quer As String
        quer = "Insert into employee(fname,lname,sexID,posID,hiredate,userName,pword,savedBy, savedDT,Access) "
        quer = quer + "values ('" & fnm & "','" & lnm & "','" & sx & "','" & pos & "','" & hdate & "','" & usr & "','" & pss & "','" & temp & "',GETDATE(),'000000000000000000000000000000000000000000')"

        Dim da As New SqlDataAdapter(quer, SQLCon)
        Dim ds As New DataSet
        da.Fill(ds, table)
        MsgBox("Employee Added Successfully!", vbOKOnly, caption)
        loadDTG(dt, "viewEmployee")
        '    End If
        'End Using
    End Sub
    Public Sub updEmp(ByVal id As Integer, ByRef dt As DataGridView, ByVal table As String, ByVal fname As String, ByVal lname As String, ByVal sexID As Integer, ByVal posID As Integer, ByVal hdate As String, ByVal usr As String, ByVal pss As String, ByVal updatedBy As String, ByRef btn As Button)
        Dim quer As String
        quer = "UPDATE employee SET "
        quer = quer + "fname = '" & fname & "', lname = '" & lname & "', sexID = '" & sexID & "', posID = '" & posID & "', hiredate = '" & hdate & "', userName = '" & usr & "', pword = '" & pss & "', updatedBy = '" & updatedBy & "', updatedDT = GETDATE() where ID = '" & id & "'"

        Dim da As New SqlDataAdapter(quer, SQLCon)
        Dim ds As New DataSet
        da.Fill(ds, table)
        MsgBox("Employee Record Updated Successfully!", vbOKOnly, caption)
        btn.Enabled = False
        'loadDTG(dt, "viewemployee")
    End Sub

    'supplier
    Public Sub addSup(ByRef dt As DataGridView, ByVal table As String, ByVal suppName As String, ByVal suppAddress As String, ByVal cityID As Integer, ByVal provinceID As Integer, ByVal contactNo As String, ByVal contactPerson As String, ByVal tin As String, ByVal savedBy As String, ByRef btn As Button)
        'SQLCon.Open()
        'Dim checkQuery As String = "select * from supplier where suppName = '" & suppName & "'"
        'Dim cmd As SqlCommand = New SqlCommand(checkQuery, SQLCon)
        'Using reader As SqlDataReader = cmd.ExecuteReader()
        '    If reader.HasRows Then
        '        MsgBox("Invalid Input! Supplier name already exist!", vbOKOnly, caption)
        '        btn.Enabled = False
        '        SQLCon.Close()
        '        Exit Sub
        '        'ElseIf IsNumeric(contactNo) Then
        '        '    MsgBox("Invalid Input! Contact number must be numeric!")
        '    ElseIf IsNumeric(tin) = False Then
        '        MsgBox("Invalid Input! TIN must be numeric!")
        '    Else
        '        reader.Close()
        Dim quer As String
        quer = "Insert into supplier(suppName, suppAddress,cityID, provinceID,contactNo, contactPerson, tin, savedBy, savedDT) "
        quer = quer + "values ('" & suppName & "','" & suppAddress & "','" & cityID & "','" & provinceID & "','" & contactNo & "','" & contactPerson & "','" & tin & "','" & savedBy & "',GETDATE())"

        Dim da As New SqlDataAdapter(quer, SQLCon)
        Dim ds As New DataSet
        da.Fill(ds, table)
        MsgBox("Supplier Added Successfully!", vbOKOnly, caption)

        '    End If
        'End Using
    End Sub
    Public Sub updSup(ByVal id As Integer, ByRef dt As DataGridView, ByVal table As String, ByVal suppName As String, ByVal suppAddress As String, ByVal cityID As Integer, ByVal provinceID As Integer, ByVal contactNo As String, ByVal contactPerson As String, ByVal tin As String, ByVal updatedBy As String, ByRef btn As Button)
        'If IsNumeric(contactNo) = False Then
        '    MsgBox("Invalid Input! Contact number must be numeric!")
        'ElseIf IsNumeric(tin) = False Then
        '    MsgBox("Invalid Input! TIN must be numeric!")
        'Else
        Dim quer As String
        quer = "UPDATE supplier SET "
        quer = quer + "suppName = '" & suppName & "', suppAddress = '" & suppAddress & "',cityID = '" & cityID & "', provinceID = '" & provinceID & "',contactNo = '" & contactNo & "',contactPerson = '" & contactPerson & "',TIN = '" & tin & "',updatedBy = '" & updatedBy & "',updatedDT = GETDATE() where ID = '" & id & "'"

        Dim da As New SqlDataAdapter(quer, SQLCon)
        Dim ds As New DataSet
        da.Fill(ds, table)
        MsgBox("Supplier Record Updated Successfully!", vbOKOnly, caption)
        btn.Enabled = False
        loadDTG(dt, "supplier")
        'End If
    End Sub

    'customer
    Public Sub addCust(ByRef dt As DataGridView, ByVal table As String, ByVal custName As String, ByVal custAddress As String, ByVal cityID As Integer, ByVal provinceID As Integer, ByVal contactNo As String, ByVal savedBy As String)
        'If IsNumeric(contactNo) = False Then
        '    MsgBox("Invalid Input! Contact number must be numeric!")
        '    Exit Sub
        'Else
        Dim quer As String
            quer = "Insert into customer(custName, custAddress,cityID, provinceID,contactNo, savedBy, savedDT) "
            quer = quer + "values ('" & custName & "','" & custAddress & "','" & cityID & "','" & provinceID & "','" & contactNo & "','" & savedBy & "',GETDATE())"
            Dim da As New SqlDataAdapter(quer, SQLCon)
            Dim ds As New DataSet
            da.Fill(ds, table)
        MsgBox("Customer Added Successfully!", vbOKOnly, caption)
        loadDTG(dt, "customerView")
        'End If
    End Sub
    Public Sub updCust(ByVal id As Integer, ByRef dt As DataGridView, ByVal table As String, ByVal custName As String, ByVal custAddress As String, ByVal cityID As Integer, ByVal provinceID As Integer, ByVal contactNo As String, ByVal updatedBy As String)
        'If IsNumeric(contactNo) = False Then
        '    MsgBox("Invalid Input! Contact number must be numeric!")
        '    Exit Sub
        'Else
        Dim quer As String
            quer = "UPDATE customer SET "
            quer = quer + "custName = '" & custName & "', custAddress = '" & custAddress & "',cityID = '" & cityID & "', provinceID = '" & provinceID & "',contactNo = '" & contactNo & "',updatedBy = '" & updatedBy & "',updatedDT = GETDATE() where ID = '" & id & "'"

            Dim da As New SqlDataAdapter(quer, SQLCon)
            Dim ds As New DataSet
            da.Fill(ds, table)
        MsgBox("Customer Record Updated Successfully!", vbOKOnly, caption)
        loadDTG(dt, "customer")
        'End If
    End Sub
    '------------------------------------------------------------------------'
    Public Sub clearTemp(ByVal tb As String)
        Dim quer As String
        quer = "delete from " + tb
        Dim da As New SqlDataAdapter(quer, SQLCon)
        Dim ds As New DataSet
        da.Fill(ds, tb)
    End Sub

    'Purchase Orders
    Public Sub CountToClose(ByVal PONum As Integer)
        Dim quer As String
        Dim test As Integer
        quer = "select count(*) from PODetails where PONum = '" & PONum & "' and status = 'Active'"
        Dim da As New SqlDataAdapter(quer, SQLCon)
        Dim ds As New DataSet
        da.Fill(ds, "PODetails")
        test = ds.Tables(0).Rows(0).Item(0).ToString
        If test = 0 Then
            RunQuery("Update PO set Status = 'Completed', closedReason = 'Completed' where PONum = '" & PONum & "'")
        Else
            Exit Sub
        End If
    End Sub
    'returns
    Public Sub retAdd(ByRef dt As DataGridView, ByVal table As String, ByVal retNo As String, ByVal orderNo As String, ByVal suppID As Integer, ByVal quant As Integer, ByVal ordDate As String, ByVal reason As Integer, ByVal whoIs As String)
        Dim quer As String
        quer = "Insert into purchaseReturn(returnNo, orderNo, suppID, quant, ordDate, reason, savedBy, savedDT) "
        quer = quer + "values('" & retNo & "','" & orderNo & "','" & suppID & "','" & quant & "','" & ordDate & "','" & reason & "','" & whoIs & "',GETDATE())"

        Dim da As New SqlDataAdapter(quer, SQLCon)
        Dim ds As New DataSet
        da.Fill(ds, table)
        MsgBox("Added Successfully!", vbOKOnly, caption)
        loadDTG(dt, "purchaseReturn")
    End Sub
    Public Sub voidRet(ByRef dt As DataGridView, ByVal table As String, ByVal ID As Integer, ByVal closedBy As String, ByVal clsReason As Integer)
        Dim quer As String
        quer = "UPDATE purchaseReturn SET "
        quer = quer + "closedBy = '" & closedBy & "',closedDT = GETDATE(), clsReason = '" & clsReason & "' where ID = '" & ID & "'"
        Dim da As New SqlDataAdapter(quer, SQLCon)
        Dim ds As New DataSet
        da.Fill(ds, table)
        MsgBox("Voided/Closed!", vbOKOnly, caption)
        loadDTG(dt, "purchaseReturn")
    End Sub

    'Receiving Records

    Public Sub loadRR(ByVal mode As Integer, ByRef dtg As DataGridView, ByVal startDT As String, ByVal endDT As String, ByVal supplier As String)
        If mode = 1 Then 'supplier only
            loadDTGN(dtg, "RRListS", "distinct RRNo as 'RR No.', suppName, RRDate as 'Date', ReceivedBy, Remarks", "suppName = '" & supplier & "' order by RRDate, [RR No.]", 4)
        ElseIf mode = 2 Then 'with dates
            loadDTGN(dtg, "RRListS", "distinct RRNo as 'RR No.', suppName, RRDate as 'Date', ReceivedBy, Remarks", "RRDate >= '" & startDT & "' and RRDate <= '" & endDT & "' and suppName like '" & supplier & "' order by RRDate, [RR No.]", 4)
        ElseIf mode = 3 Then 'supplier only
            loadDTGN(dtg, "RRListS", "distinct RRNo as 'RR No.', suppName, RRDate as 'Date', ReceivedBy, Remarks, stock, Balance", "suppName = '" & supplier & "' and Stock = Balance order by RRDate, [RR No.]", 4)
        ElseIf mode = 4 Then 'with dates
            loadDTGN(dtg, "RRListS", "distinct RRNo as 'RR No.', suppName, RRDate as 'Date', ReceivedBy, Remarks, stock, Balance", "RRDate >= '" & startDT & "' and RRDate <= '" & endDT & "' and suppName like '" & supplier & "' and Stock = Balance order by RRDate, [RR No.]", 4)
        End If
    End Sub

    'compting balances and updating POStatus OK
    Public Function computeBal(ByVal ID As Integer, ByVal qtyRcv As Integer)
        Dim quer, test As String
        Dim temp As Integer
        quer = "SELECT Balance FROM PODetails Where ID = '" & ID & "'"
            Dim da As New SqlDataAdapter(quer, SQLCon)
        Dim ds As New DataSet
        da.Fill(ds, "PODetails")
        test = ds.Tables(0).Rows(0).Item(0).ToString
        Convert.ToInt32(test)
        temp = test - qtyRcv
        If temp = 0 Then
            updateBal(ID, temp, 2)
        Else
            updateBal(ID, temp, 1)
        End If

        Return temp
    End Function
    Public Sub updateBal(ByVal ID As Integer, ByVal newBal As Integer, ByVal mode As Integer)
        Dim quer As String
        If mode = 1 Then 'order not yet complete
            quer = "Update PODetails set balance = '" & newBal & "' Where ID = '" & ID & "'"
            Dim da As New SqlDataAdapter(quer, SQLCon)
            Dim ds As New DataSet
            da.Fill(ds, "PODetails")
        ElseIf mode = 2 Then 'order completed
            quer = "Update PODetails set balance = '" & newBal & "', Status  = 'Completed' Where ID = '" & ID & "'"
            Dim da As New SqlDataAdapter(quer, SQLCon)
            Dim ds As New DataSet
            da.Fill(ds, "PODetails")
        End If
    End Sub

    'validation for PO and RR
    Public Function checkVal(ByVal table As String, ByVal param As String, ByVal num As Integer)
        Dim quer, test As String
        quer = "SELECT COUNT(1) FROM " + table + " Where " + param + " = '" & num & "'"
        Dim da As New SqlDataAdapter(quer, SQLCon)
        Dim ds As New DataSet
        da.Fill(ds, table)
        test = ds.Tables(0).Rows(0).Item(0).ToString
        If test > 0 Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function checkValStr(ByVal table As String, ByVal param As String, ByVal tok As String)
        Dim quer, test As String
        quer = "SELECT COUNT(1) FROM " + table + " Where " + param + " = '" & tok & "'"
        Dim da As New SqlDataAdapter(quer, SQLCon)
        Dim ds As New DataSet
        da.Fill(ds, table)
        test = ds.Tables(0).Rows(0).Item(0).ToString
        If test > 0 Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function checkRRID(ByVal table As String, ByVal num As Integer)
        Dim quer, test As String
        quer = "SELECT COUNT(1) FROM RRDetails Where RRID = '" & num & "'"
        Dim da As New SqlDataAdapter(quer, SQLCon)
        Dim ds As New DataSet
        da.Fill(ds, table)
        test = ds.Tables(0).Rows(0).Item(0).ToString
        If test > 0 Then
            Return True
        Else
            Return False
        End If
    End Function
    Public Function checkProdID(ByVal table As String, ByVal ID As Integer)
        Dim quer, test As String
        quer = "SELECT COUNT(1) FROM promo Where ID = '" & ID & "'"
        Dim da As New SqlDataAdapter(quer, SQLCon)
        Dim ds As New DataSet
        da.Fill(ds, table)
        test = ds.Tables(0).Rows(0).Item(0).ToString
        If test > 0 Then
            Return True
        Else
            Return False
        End If
    End Function


    'anomatopea
    'anomatopea

    'write search  function dine

    'write sales parts here

    Public Sub LoadProdStock(ByVal prodName As String)
        Dim quer As String
        quer = "SELECT * FROM viewProductQuantity Where Product = '" & prodName & "'"
        Dim da As New SqlDataAdapter(quer, SQLCon)
        Dim ds As New DataSet
        da.Fill(ds, "viewProductQuantity")
    End Sub

    'get specific details

    Public Sub searchProduct(ByVal table As String, ByRef dt As DataGridView, valueToSearch As String, ByVal mode As Integer)
        SQLCon.Open()
        Dim searchQuery As String
        If mode = 1 Then
            searchQuery = "Select * from viewproduct where [Product Code] like '%" & valueToSearch & "%' and [Status] = 'ACTIVE' and deletedBy is NULL"
        ElseIf mode = 2 Then
            searchQuery = "Select * from viewproduct where [Brand Name] like '%" & valueToSearch & "%' and [Status] = 'ACTIVE' and deletedBy is NULL"
        ElseIf mode = 3 Then
            searchQuery = "Select * from viewproduct where ([Product Code] + [Category] + [Generic Name] + [Brand Name] + [Dosage] + [Unit] + [Form] + [Category] + [Status]) like '%" & valueToSearch & "%' and [Status] = 'ACTIVE' and deletedBy is NULL"
        End If

        Dim da As New SqlDataAdapter(searchQuery, SQLCon)
        Dim ds As New DataSet
        da.Fill(ds, table)
        SQLCon.Close()
        dt.DataSource = ds.Tables(0)
    End Sub

    Public Sub searchProductToUpdate(ByVal table As String, ByRef dt As DataGridView, valueToSearch As String, ByVal mode As Integer)
        SQLCon.Open()
        Dim searchQuery As String
        If mode = 1 Then
            searchQuery = "Select * from viewproduct where [Product Code] like '%" & valueToSearch & "%' and deletedBy is NULL"
        ElseIf mode = 2 Then
            searchQuery = "Select * from viewproduct where [Brand Name] like '%" & valueToSearch & "%' and deletedBy is NULL"
        ElseIf mode = 3 Then
            searchQuery = "Select * from viewproduct where ([Product Code] + [Category] + [Generic Name] + [Brand Name] + [Unit] + [Dosage] + [Form] + [Status]) like '%" & valueToSearch & "%' and deletedBy is NULL"
        End If

        Dim da As New SqlDataAdapter(searchQuery, SQLCon)
        Dim ds As New DataSet
        da.Fill(ds, table)
        SQLCon.Close()
        dt.DataSource = ds.Tables(0)
    End Sub

    'Public Sub searchEmployeeToUpdate(ByVal table As String, ByRef dt As DataGridView, valueToSearch As String)
    '    SQLCon.Open()
    '    Dim searchQuery As String = "select * from viewemployee where ([Name] + [Sex] + [Postion] + [Hiredate] + [Username] + [Password]) like '%" & valueToSearch & "%'"
    '    Dim da As New SqlDataAdapter(searchQuery, SQLCon)
    '    Dim ds As New DataSet
    '    da.Fill(ds, table)
    '    SQLCon.Close()
    '    dt.DataSource = ds.Tables(0)
    'End Sub

    'supplier searching
    Public Sub searchSupplier(ByVal table As String, ByRef dt As DataGridView, valueToSearch As String, ByVal mode As Integer)
        SQLCon.Open()
        Dim searchQuery As String
        If mode = 1 Then
            searchQuery = "Select * from viewSupp where [Supplier Name] like '%" & valueToSearch & "%' and deletedBy is NULL"
        ElseIf mode = 2 Then
            searchQuery = "Select * from viewSupp where [Address] like '%" & valueToSearch & "%' and deletedBy is NULL"
        ElseIf mode = 3 Then
            searchQuery = "Select * from viewSupp where ([Supplier Name] + [Address] + [Contact No.] + [Contact Person] + [TIN]) like '%" & valueToSearch & "%' and deletedBy is NULL"
        End If

        Dim da As New SqlDataAdapter(searchQuery, SQLCon)
        Dim ds As New DataSet
        da.Fill(ds, table)
        SQLCon.Close()
        dt.DataSource = ds.Tables(0)
    End Sub

    Public Sub searchSupplierToUpdate(ByVal table As String, ByRef dt As DataGridView, valueToSearch As String, ByVal mode As Integer)
        SQLCon.Open()
        Dim searchQuery As String
        If mode = 1 Then
            searchQuery = "Select * from suppList where [Supplier] like '%" & valueToSearch & "%' and deletedBy is NULL"
        ElseIf mode = 2 Then
            searchQuery = "Select * from suppList where [Address] + [City] + [Province] like '%" & valueToSearch & "%' and deletedBy is NULL"
        ElseIf mode = 3 Then
            searchQuery = "Select * from suppList where ([Supplier] + [Address] + [City] + [Province] + [Contact #] + [Contact Person] + [TIN]) like '%" & valueToSearch & "%' and deletedBy is NULL"
        End If

        Dim da As New SqlDataAdapter(searchQuery, SQLCon)
        Dim ds As New DataSet
        da.Fill(ds, table)
        SQLCon.Close()
        dt.DataSource = ds.Tables(0)
    End Sub

    'customer searching
    Public Sub searchCustomer(ByVal table As String, ByRef dt As DataGridView, valueToSearch As String, ByVal mode As Integer)
        SQLCon.Open()
        Dim searchQuery As String
        If mode = 1 Then
            searchQuery = "Select * from customerView where [Customer Name] like '%" & valueToSearch & "%' and deletedBy is NULL"
        ElseIf mode = 2 Then
            searchQuery = "Select * from customerView where [Address] like '%" & valueToSearch & "%' and deletedBy is NULL"
        ElseIf mode = 3 Then
            'searchQuery = "Select * from CustomerView where ([Customer Name] + [Address] + [City] + [Province] + [Contact No.]) like '%" & valueToSearch & "%'"
            searchQuery = "Select * from CustomerView where ([Customer Name] + [Address] + [Contact No.]) like '%" & valueToSearch & "%' and deletedBy is NULL"
        End If

        Dim da As New SqlDataAdapter(searchQuery, SQLCon)
        Dim ds As New DataSet
        da.Fill(ds, table)
        SQLCon.Close()
        dt.DataSource = ds.Tables(0)
    End Sub

    Public Sub searchCustomerToUpdate(ByVal table As String, ByRef dt As DataGridView, valueToSearch As String, ByVal mode As Integer)
        SQLCon.Open()
        Dim searchQuery As String
        If mode = 1 Then
            searchQuery = "Select * from viewcustomer where [Customer Name] like '%" & valueToSearch & "%' and deletedBy is NULL"
        ElseIf mode = 2 Then
            searchQuery = "Select * from viewcustomer where [Address] + [City] + [Province] like '%" & valueToSearch & "%' and deletedBy is NULL"
        ElseIf mode = 3 Then
            searchQuery = "Select * from viewCustomer where ([Customer Name] + [Address] + [City] + [Province] + [Contact No.]) like '%" & valueToSearch & "%' and deletedBy is NULL"
        End If

        Dim da As New SqlDataAdapter(searchQuery, SQLCon)
        Dim ds As New DataSet
        da.Fill(ds, table)
        SQLCon.Close()
        dt.DataSource = ds.Tables(0)
    End Sub

    'databank insertion/validation
    Public Sub databankChecking(ByVal table As String, ByVal id As Integer, ByVal column As String, ByVal input As String, ByRef btn As Button, ByVal mode As Integer)
        SQLCon.Open()
        Dim checkQuery As String = "select * from " & table & " where " & column & " = '" & input & "'"
        Dim cmd As SqlCommand = New SqlCommand(checkQuery, SQLCon)
        Using reader As SqlDataReader = cmd.ExecuteReader()
            If reader.HasRows Then
                MsgBox("Invalid Input! Item already exist!", vbOKOnly, caption)
                SQLCon.Close()
                Exit Sub
            ElseIf mode = 1 Then
                reader.Close()
                Dim ex As SqlCommand = New SqlCommand("Insert into " & table & " values('" & input & "')", SQLCon)
                ex.ExecuteNonQuery()
                MsgBox("Item added!", vbOKOnly, caption)
            ElseIf mode = 2 Then
                reader.Close()
                Dim ex2 As SqlCommand = New SqlCommand("Update " & table & " set " & column & " = '" & input & "' where id = '" & id & "'", SQLCon)
                ex2.ExecuteNonQuery()
                MsgBox("Item updated!", vbOKOnly, caption)

            End If
            reader.Close()
        End Using
        SQLCon.Close()
    End Sub

    Public Sub databankCheckingV2(ByVal table As String, ByVal id As Integer, ByVal column1 As String, ByVal column2 As String, ByVal input1 As String, ByVal input2 As Integer, ByRef btn As Button, ByVal mode As Integer)
        SQLCon.Open()
        Dim checkQuery As String = "select * from " & table & " where " & column1 & " = '" & input1 & "' and " & column2 & " = '" & input2 & "'"
        Dim cmd As SqlCommand = New SqlCommand(checkQuery, SQLCon)
        Using reader As SqlDataReader = cmd.ExecuteReader()
            If reader.HasRows Then
                MsgBox("Invalid Input! Item already exist!", vbOKOnly, caption)
                SQLCon.Close()
                Exit Sub
            ElseIf mode = 1 Then
                reader.Close()
                Dim ex As SqlCommand = New SqlCommand("Insert into " & table & " values('" & input1 & "','" & input2 & "')", SQLCon)
                ex.ExecuteNonQuery()
                MsgBox("Item added!", vbOKOnly, caption)
            ElseIf mode = 2 Then
                reader.Close()
                Dim ex2 As SqlCommand = New SqlCommand("Update " & table & " set " & column1 & " = '" & input1 & "', " & column2 & " = '" & input2 & "' where id = '" & id & "'", SQLCon)
                ex2.ExecuteNonQuery()
                MsgBox("Item updated!", vbOKOnly, caption)
            End If
        End Using
        SQLCon.Close()
    End Sub
    'write sales parts here
    Public Sub TempRecord(ByRef dtg As DataGridView, ByVal prodName As String, ByVal qty As Integer, ByVal stockID As Integer, ByVal subtotal As Integer, ByVal free As Integer)
        Dim quer As String
        quer = "Insert into tempBuyList(Product,Quantity,FreeQuantity,Subtotal,stockID) values('" & prodName & "','" & qty & "','" & free & "','" & subtotal & "','" & stockID & "')"
        Dim da As New SqlDataAdapter(quer, SQLCon)
        Dim ds As New DataSet
        da.Fill(ds, "tempBuyList")
        loadDTG(dtg, "tempBuyList")
    End Sub
    Public Function getPromo(ByVal id As Integer)
        Dim quer, test As String
        quer = "SELECT FreeQuantity FROM promo Where ID = '" & id & "'"
        Dim da As New SqlDataAdapter(quer, SQLCon)
        Dim ds As New DataSet
        da.Fill(ds, "promo")
        test = ds.Tables(0).Rows(0).Item(0).ToString
        Return Convert.ToInt32(test)
    End Function
    Public Function getDsc(ByVal id As Integer)
        If id = 0 Then
            Exit Function
        End If
        Dim quer, test As String
        quer = "SELECT PercentDscnt FROM discount Where ID = '" & id & "'"
        Dim da As New SqlDataAdapter(quer, SQLCon)
        Dim ds As New DataSet
        da.Fill(ds, "discount")
        test = ds.Tables(0).Rows(0).Item(0).ToString
        Return Convert.ToInt32(test)
    End Function
    Public Function GetCount(ByVal table As String)
        Dim quer, test As String
        Dim chk As Integer
        quer = "SELECT count(*) FROM " + table
        Dim da As New SqlDataAdapter(quer, SQLCon)
        Dim ds As New DataSet
        da.Fill(ds, table)
        test = ds.Tables(0).Rows(0).Item(0).ToString
        If test = "" Then
            chk = 1
        Else
            chk = test + 1
        End If
        Return chk
    End Function
    Public Sub salesDet(ByVal sn As Integer, ByVal prod As Integer, ByVal qty As Integer, ByVal free As Integer, ByVal promo As Integer, ByVal RRID As Integer)
        Dim quer As String
        quer = "Insert into salesDetailss(salesID,productID,quantity,freeQty,promoID,stockID) values('" & sn & "','" & prod & "','" & qty & "','" & free & "','" & promo & "','" & RRID & "')"
        Dim da As New SqlDataAdapter(quer, SQLCon)
        Dim ds As New DataSet
        da.Fill(ds, "salesDetails")
    End Sub

    Public Sub salesDets(ByVal sn As Integer, ByVal prod As String, ByVal qty As Integer, ByVal free As Integer, ByVal promo As String, ByVal RRID As Integer)
        Dim quer As String
        quer = "Insert into salesDetailss(salesID,prodName,quantity,freeQty,promoName,stockID) values('" & sn & "','" & prod & "','" & qty & "','" & free & "','" & promo & "','" & RRID & "')"
        Dim da As New SqlDataAdapter(quer, SQLCon)
        Dim ds As New DataSet
        da.Fill(ds, "salesDetails")
    End Sub

    'get specific details
    Public Function getProdID(ByVal name As String)
        Dim quer, test As String
        quer = "SELECT ID FROM ProductOnSale Where Product = '" & name & "'"
        Dim da As New SqlDataAdapter(quer, SQLCon)
        Dim ds As New DataSet
        da.Fill(ds, "promo")
        test = ds.Tables(0).Rows(0).Item(0)
        Return Convert.ToInt32(test)
    End Function
    Public Function getProdName(ByVal POID As Integer)
        Dim quer, test As String
        quer = "SELECT Product FROM POCloseVoid Where ID = '" & POID & "'"
        Dim da As New SqlDataAdapter(quer, SQLCon)
        Dim ds As New DataSet
        da.Fill(ds, "promo")
        test = ds.Tables(0).Rows(0).Item(0)
        Return test
    End Function
    Public Function GetQty(ByVal ID As Integer)
        Dim quer, test As String
        quer = "SELECT stock FROM RRDetails Where ID = '" & ID & "'"
        Dim da As New SqlDataAdapter(quer, SQLCon)
        Dim ds As New DataSet
        da.Fill(ds, "RRDetails")
        test = ds.Tables(0).Rows(0).Item(0)
        Return test
    End Function
    Public Function GetDetail(ByVal table As String, ByVal col As String, ByVal param As String, ByVal tok As Integer)
        Dim quer, flag As String
        quer = "SELECT " + col + " FROM " + table + " Where " + param + " = '" & tok & "'"
        Dim da As New SqlDataAdapter(quer, SQLCon)
        Dim ds As New DataSet
        da.Fill(ds, table)
        flag = ds.Tables(0).Rows(0).Item(0)
        Return flag
    End Function
    Public Function GetDetailStr(ByVal table As String, ByVal col As String, ByVal param As String, ByVal tok As String)
        Try
            Dim quer, flag As String
            quer = "SELECT " + col + " FROM " + table + " Where " + param + " = '" & tok & "'"
            Dim da As New SqlDataAdapter(quer, SQLCon)
            Dim ds As New DataSet
            da.Fill(ds, table)
            flag = ds.Tables(0).Rows(0).Item(0)
            Return flag
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function



    Public Sub GenerateReport(ByVal quer As String, ByVal table As String, ByRef cryIns As Object, ByRef rep As Object)
        Try
            SQLCon.Open()
            Dim da As New SqlDataAdapter(quer, SQLCon)
            Dim ds As New DataSet
            da.Fill(ds, table)
            rep.SetDataSource(ds)
            cryIns.ReportSource = rep
            cryIns.Refresh
            SQLCon.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    'Public Function getName()
    '    SQLCon.Open()
    '    Dim usr As String
    '    Dim quer As String = "Select fname + ' ' + lname as EmployeeName from Employee where userName = '" & username & "'"
    '    Dim cmd As SqlCommand = New SqlCommand(quer, SQLCon)
    '    Using reader As SqlDataReader = cmd.ExecuteReader()
    '        If reader.HasRows Then
    '            While reader.Read
    '                usr = reader("EmployeeName")
    '            End While
    '            reader.Close()
    '            SQLCon.Close()
    '        End If
    '        reader.Close()
    '        SQLCon.Close()
    '    End Using
    '    Return usr
    '    SQLCon.Close()
    'End Function


    Public Sub checkRestrict(ByVal usr As String, ByVal ctrl As String, ByRef control As ToolStripMenuItem)
        'SQLCon.Open()
        SQLCon.Close()
        Dim quer As String = "select * from restrictionView where [User] = '" & usr & "' and [Control Name] = '" & ctrl & "'"
        Dim cmd As New SqlCommand
        cmd = New SqlCommand(quer, SQLCon)
        SQLCon.Open()
        Using reader As SqlDataReader = cmd.ExecuteReader()
            'reader.Close()

            If reader.HasRows Then
                reader.Close()
                'SQLCon.Close()
                control.Enabled = False
                SQLCon.Close()
            Else
                reader.Close()
                'SQLCon.Close()
                control.Enabled = True
                SQLCon.Close()
            End If
            reader.Close()
            SQLCon.Close()
        End Using
        If (SQLCon.State = ConnectionState.Open) Then
            SQLCon.Close()
        End If
        'SQLCon.Close()
    End Sub

    'Public Function Res(ByVal ID As Integer)
    '    Try
    '        Dim quer, flag As String
    '        quer = "SELECT controlName from Controls where ID = '" & ID & "'"
    '        Dim da As New SqlDataAdapter(quer, SQLCon)
    '        Dim ds As New DataSet
    '        da.Fill(ds, "Controls")
    '        flag = ds.Tables(0).Rows(0).Item(0)
    '        If flag = Nothing Then
    '            Return Nothing
    '        Else
    '            flag = ds.Tables(0).Rows(0).Item(0)
    '            Return flag
    '        End If
    '    Catch ex As Exception
    '        MsgBox(ex.Message)
    '    End Try
    'End Function

    'Public Function Itm(ByVal ID As Integer)
    '    Try
    '        Dim quer, flag As String
    '        quer = "SELECT controlName from Controls where ID = '" & ID & "'"
    '        Dim da As New SqlDataAdapter(quer, SQLCon)
    '        Dim ds As New DataSet
    '        da.Fill(ds, "Controls")
    '        flag = ds.Tables(0).Rows(0).Item(0)
    '        If flag = Nothing Then
    '            Return Nothing
    '        Else
    '            flag = ds.Tables(0).Rows(0).Item(0)
    '            Return flag
    '        End If
    '    Catch ex As Exception
    '        MsgBox(ex.Message)
    '    End Try
    'End Function


    Public Sub checkRestrict2(ByVal usr As String, ByVal ctrl As String, ByRef control As Button)
        'SQLCon.Open()
        SQLCon.Close()
        Dim quer As String = "select * from restrictionView where [User] = '" & usr & "' and [Control Name] = '" & ctrl & "'"
        Dim cmd As New SqlCommand
        cmd = New SqlCommand(quer, SQLCon)
        SQLCon.Open()
        Using reader As SqlDataReader = cmd.ExecuteReader()
            'reader.Close()

            If reader.HasRows Then
                reader.Close()
                'SQLCon.Close()
                control.Enabled = False
                SQLCon.Close()
            Else
                reader.Close()
                'SQLCon.Close()
                control.Enabled = True
                SQLCon.Close()
            End If
            reader.Close()
            SQLCon.Close()
        End Using
        If (SQLCon.State = ConnectionState.Open) Then
            SQLCon.Close()
        End If
        'SQLCon.Close()
    End Sub


    Public Sub loadRRPay(ByVal mode As Integer, ByRef dtg As DataGridView, ByVal startDT As String, ByVal endDT As String, ByVal supplier As String)
        If mode = 1 Then 'supplier only
            loadDTGN(dtg, "RRList", "", "Supplier = '" & supplier & "' and totalRR > 0.00 order by RRDate", 3)
        ElseIf mode = 2 Then 'with dates
            loadDTGN(dtg, "RRList", "", "RRDate >= '" & startDT & "' and RRDate <= '" & endDT & "' and suppName like '" & supplier & "' order by RRDate", 3)

        End If
    End Sub

    Public Sub loadCBXS(ByRef cbx As ComboBox, ByVal table As String, ByVal valMem As String, ByVal dspMem As String)
        SQLCon.Open()
        Dim quer As String = "select * from " + table
        Dim da As New SqlDataAdapter(quer, SQLCon)
        Dim ds As New DataSet
        da.Fill(ds, table)
        SQLCon.Close()
        cbx.DataSource = ds.Tables(0)
        cbx.ValueMember = valMem
        cbx.DisplayMember = dspMem
        'cbx.SelectedIndex = -1
        'fix
        cbx.DropDownStyle = ComboBoxStyle.DropDown
        cbx.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        cbx.AutoCompleteSource = AutoCompleteSource.ListItems
    End Sub
End Class
