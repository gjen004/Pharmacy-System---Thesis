Imports System.Data.SqlClient
Public Class ivPO
    Dim s As New cSQL
    Public Sub createPO(ByVal orderNum As String, ByVal suppID As Integer, ByVal ordDate As String, ByVal dtNeed As String, ByVal savedBy As String, ByVal remarks As String)
        'first query going to PO table
        Dim querPO As String
        querPO = "Insert into PO(PONum, supplierID, PODTCreate, PODTNeed, remarks,savedBy, savedDT,Status) "
        querPO = querPO + "values ('" & orderNum & "','" & suppID & "','" & ordDate & "','" & dtNeed & "','" & remarks & "','" & savedBy & "',GETDATE(),'Active')"
        Dim da As New SqlDataAdapter(querPO, SQLCon)
        Dim ds As New DataSet
        da.Fill(ds, "PO")
    End Sub
    Public Sub addProductsToPO(ByVal orderNo As Integer, ByVal prodID As Integer, ByVal quantity As Integer, ByVal price As Integer)
        Dim quer As String
        quer = "Insert into TempOrder(PONum, Product, Quantity, unitPrice) "
        quer = quer + "values ('" & orderNo & "','" & prodID & "','" & quantity & "','" & price & "')"
        s.RunQuery("insert into ProductPrice(ProductID,UnitPrice) values('" & prodID & "','" & price & "')") 'going to ProductPrice
        Dim da As New SqlDataAdapter(quer, SQLCon)
        Dim ds As New DataSet
        da.Fill(ds, "tempOrder")
    End Sub
    Public Sub savePO(ByVal orderNo As Integer, ByVal prodID As Integer, ByVal quantity As Integer, ByVal price As Integer)
        Dim quer As String
        quer = "Insert into PODetails(PONum, ProductID, Quantity, unitPrice,balance,Status) "
        quer = quer + "values('" & orderNo & "','" & prodID & "','" & quantity & "','" & price & "','" & quantity & "','Active')"
        Dim da As New SqlDataAdapter(quer, SQLCon)
        Dim ds As New DataSet
        da.Fill(ds, "PODetails")
    End Sub
    Public Sub clearTemp(ByVal tb As String)
        Dim quer As String
        quer = "delete from " + tb
        Dim da As New SqlDataAdapter(quer, SQLCon)
        Dim ds As New DataSet
        da.Fill(ds, tb)
    End Sub

    Public Sub loadPO(ByVal mode As Integer, ByVal type As Integer, ByRef dtg As DataGridView, ByVal startDT As String, ByVal endDT As String, ByVal supplier As String)
        Try
            If mode = 1 Then
                If type = 1 Then 'allow nulls
                    ' and PODTCreate = GETDATE()
                    s.loadDTGN(dtg, "POListSupp", "distinct [PO No.], PODTCreate as 'Date',Status", "[Supplier Name] = '" & supplier & "' order by Date, [PO No.]", 4)
                ElseIf type = 2 Then 'no nulls
                    s.loadDTGN(dtg, "POListSupp", "distinct [PO No.], PODTCreate as 'Date',Status", "[Supplier Name] = '" & supplier & "' and (voidReason is null and closedReason is null) order by Date, [PO No.]", 4)
                End If
            ElseIf mode = 2 Then
                If type = 1 Then 'allows nulls
                    s.loadDTGN(dtg, "POListSupp", "distinct [PO No.], PODTCreate as 'Date',Status", "PODTCreate >= '" & startDT & "' and PODTCreate <= '" & endDT & "' and [Supplier Name] like '" & supplier & "' order by Date, [PO No.]", 4)
                ElseIf type = 2 Then 'no nulls
                    s.loadDTGN(dtg, "POListSupp", "distinct [PO No.], PODTCreate as 'Date',Status", "PODTCreate >= '" & startDT & "' and PODTCreate <= '" & endDT & "' and [Supplier Name] like '" & supplier & "' and (voidReason is null and closedReason is null) order by Date, [PO No.]", 4)
                End If
            End If
            dtg.Columns(1).DefaultCellStyle.Format = "MM/dd/yyyy"

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub voidClsOrd(ByRef dt As DataGridView, ByVal table As String, ByVal type As Integer, ByVal PONum As Integer, ByVal reason As String, ByVal whoIs As String)
        Dim querPO As String
        If type = 1 Then 'void
            querPO = "UPDATE PO SET "
            querPO = querPO + "voidReason = '" & reason & "', voidBy = '" & whoIs & "',voidDT = GETDATE(), Status = 'Voided' where PONum = '" & PONum & "'"
            Dim da As New SqlDataAdapter(querPO, SQLCon)
            Dim ds As New DataSet
            da.Fill(ds, table)
            voidClsDet(1, PONum)
            MsgBox("PO Voided!")
        ElseIf type = 2 Then 'close
            querPO = "UPDATE PO SET "
            querPO = querPO + "closedReason = '" & reason & "', closedBy = '" & whoIs & "',closedDT = GETDATE(), Status = 'Closed' where PONum = '" & PONum & "'"
            Dim da As New SqlDataAdapter(querPO, SQLCon)
            Dim ds As New DataSet
            da.Fill(ds, table)
            voidClsDet(2, PONum)
            MsgBox("PO Closed!")
        End If
    End Sub
    Public Sub voidClsDet(ByVal mode As Integer, ByVal POnum As Integer)
        Dim querPO As String
        If mode = 1 Then 'void
            querPO = "UPDATE PODetails SET Status = 'Voided' where PONum = '" & POnum & "'"
            Dim da As New SqlDataAdapter(querPO, SQLCon)
            Dim ds As New DataSet
            da.Fill(ds, "PODetails")
        ElseIf mode = 2 Then 'close
            querPO = "UPDATE PODetails SET Status = 'Closed' where PONum = '" & POnum & "'"
            Dim da As New SqlDataAdapter(querPO, SQLCon)
            Dim ds As New DataSet
            da.Fill(ds, "PODetails")
        End If
    End Sub
    Public Sub CountToClose(ByVal PONum As Integer)
        Dim quer As String
        Dim test As Integer
        quer = "select count(*) from PODetails where PONum = '" & PONum & "' and status = 'Active'"
        Dim da As New SqlDataAdapter(quer, SQLCon)
        Dim ds As New DataSet
        da.Fill(ds, "PODetails")
        test = ds.Tables(0).Rows(0).Item(0).ToString
        If test = 0 Then
            s.RunQuery("Update PO set closedReason = 'Completed', Status = 'Completed' where PONum = '" & PONum & "'")
        Else
            Exit Sub
        End If
    End Sub
End Class
