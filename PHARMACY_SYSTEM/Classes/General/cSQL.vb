Imports System.Data.Sql
Imports System.Data.SqlClient
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
    End Sub
    Public Sub loadDTGN(ByRef dt As DataGridView, ByVal table As String, ByVal Col As String, ByVal con As String, ByVal mode As Integer)
        SQLCon.Open()
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
            dt.AllowUserToAddRows = False
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
            dt.AllowUserToAddRows = False
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
            dt.AllowUserToAddRows = False
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
            dt.AllowUserToAddRows = False
            Exit Sub
        End If
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
        dt.AllowUserToAddRows = False
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
        MsgBox("Item Removed!")
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
            quer = "Update PODetails set balance = '" & newBal & "', Status  = 'Closed' Where ID = '" & ID & "'"
            Dim da As New SqlDataAdapter(quer, SQLCon)
            Dim ds As New DataSet
            da.Fill(ds, "PODetails")
        End If
    End Sub
    'validation for PO and RR
    Public Function checkVal(ByVal table As String, ByVal num As Integer)
        Dim quer, test As String
        quer = "SELECT COUNT(1) FROM PODetails Where POID = '" & num & "'"
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
        quer = "SELECT balance FROM RRDetails Where PODetailsID = '" & ID & "'"
        Dim da As New SqlDataAdapter(quer, SQLCon)
        Dim ds As New DataSet
        da.Fill(ds, "ProductInventory")
        test = ds.Tables(0).Rows(0).Item(0)
        Return test
    End Function
    Public Function GetDetail(ByVal table As String, ByVal col As String, ByVal ID As Integer)
        Dim quer, flag As String
        quer = "SELECT " + col + " FROM " + table + " Where ID = '" & ID & "'"
        Dim da As New SqlDataAdapter(quer, SQLCon)
        Dim ds As New DataSet
        da.Fill(ds, table)
        flag = ds.Tables(0).Rows(0).Item(0)
        Return flag
    End Function
End Class
