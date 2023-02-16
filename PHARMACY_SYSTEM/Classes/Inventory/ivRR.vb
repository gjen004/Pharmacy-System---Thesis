Imports System.Data.SqlClient
Public Class ivRR
    Dim s As New cSQL
    Public Sub createRR(ByVal RRno As Integer, ByVal supplierID As Integer, ByVal rrDT As String, ByVal rcvr As String, ByVal remarks As String)
        Dim quer As String
        quer = "INSERT INTO RR(RRNo, SupplierID, RRDate, ReceivedBy,Remarks,savedBy, savedDT) "
        quer = quer + "values('" & RRno & "','" & supplierID & "','" & rrDT & "','" & rcvr & "','" & remarks & "','" & savedBy & "',GETDATE())"
        Dim da As New SqlDataAdapter(quer, SQLCon)
        Dim ds As New DataSet
        da.Fill(ds, "RR")
    End Sub
    Public Sub addRRDetails(ByVal mode As Integer, ByVal RRno As Integer, ByVal PONo As Integer, ByVal pName As String, ByVal expDate As String, ByVal sellprice As Double, ByVal unitPrice As Double, ByVal amt As Double, ByVal qty As Integer, ByVal bal As Integer, ByVal tAmt As Double, ByVal saan As Integer)
        'Try
        Dim quer As String
            If mode = 1 Then 'for new RR
                quer = "Insert into tempDetails(RRID,PODetailsID,Product,ProdExpDate,SellingPrice,unitPrice,[RR Amount],Quantity,Balance,[PO Amount]) "
                quer = quer + "values('" & RRno & "','" & PONo & "','" & pName & "','" & expDate & "','" & sellprice & "','" & unitPrice & "','" & amt & "','" & qty & "','" & bal & "','" & tAmt & "')"
            ElseIf mode = 2 Then 'for update RR
                quer = "Insert into tempDetails(RRID,PODetailsID,Product,ProdExpDate,SellingPrice,unitPrice,[RR Amount],Quantity,Balance,[PO Amount],upWhere) "
                quer = quer + "values('" & RRno & "','" & PONo & "','" & pName & "','" & expDate & "','" & sellprice & "','" & unitPrice & "','" & amt & "','" & qty & "','" & bal & "','" & tAmt & "','" & saan & "')"
            End If
            Dim da As New SqlDataAdapter(quer, SQLCon)
            Dim ds As New DataSet
            da.Fill(ds, "tempDetails")
        'Catch ex As Exception
        '    MsgBox(ex.Message)
        'End Try
    End Sub
    Public Sub saveRR(RRno As Integer, ByVal PONo As Integer, ByVal expDate As String, ByVal sellprice As Double, ByVal amt As Double, ByVal qty As Integer, ByVal bal As Integer, ByVal tAmt As Integer)
        Dim quer As String
        quer = "Insert into RRDetails(RRID,PODetailsID,ProdExpDate,SellingPrice,[RR Amount],Quantity,Balance,[PO Amount],stock) "
        quer = quer + "values('" & RRno & "','" & PONo & "','" & expDate & "','" & sellprice & "','" & amt & "','" & qty & "','" & bal & "','" & tAmt & "','" & bal & "')"
        Dim da As New SqlDataAdapter(quer, SQLCon)
        Dim ds As New DataSet
        da.Fill(ds, "RRDetails")
        's.RunQuery("Insert into ProductInventory(RRDetailsID,PODetailsID,Quantity,ProdExpDate) values('" & RRno & "','" & PONo & "','" & qty & "','" & expDate & "')")
    End Sub
    Public Sub updateRR(ByVal saan As Integer, ByVal expDate As String, ByVal amt As Integer, ByVal bal As Integer, ByVal sellprice As Double)
        Dim quer As String
        quer = "UPDATE RRDetails set "
        quer = quer + "ProdExpDate = '" & expDate & "', [RR Amount] = '" & amt & "', Balance = '" & bal & "', SellingPrice = '" & sellprice & "'  where ID = '" & saan & "'"
        Dim da As New SqlDataAdapter(quer, SQLCon)
        Dim ds As New DataSet
        da.Fill(ds, "RRDetails")
        's.RunQuery("Update ProductInventory set Quantity = '" & bal & "', ProdExpDate = '" & expDate & "' where RRDetailsID = '" & saan & "'")
    End Sub
End Class
