Imports System.Data.SqlClient
Public Class ivReturns
    Dim s As New cSQL
    Public Sub retAdd(ByRef dt As DataGridView, ByVal table As String, ByVal retNo As String, ByVal orderNo As String, ByVal suppID As Integer, ByVal quant As Integer, ByVal ordDate As String, ByVal reason As Integer, ByVal whoIs As String)
        Dim quer As String
        quer = "Insert into purchaseReturn(returnNo, orderNo, suppID, quant, ordDate, reason, savedBy, savedDT) "
        quer = quer + "values('" & retNo & "','" & orderNo & "','" & suppID & "','" & quant & "','" & ordDate & "','" & reason & "','" & whoIs & "',GETDATE())"

        Dim da As New SqlDataAdapter(quer, SQLCon)
        Dim ds As New DataSet
        da.Fill(ds, table)
        MsgBox("Added Successfully!")
        s.loadDTG(dt, "purchaseReturn")
    End Sub
    Public Sub voidRet(ByRef dt As DataGridView, ByVal table As String, ByVal ID As Integer, ByVal closedBy As String, ByVal clsReason As Integer)
        Dim quer As String
        quer = "UPDATE purchaseReturn SET "
        quer = quer + "closedBy = '" & closedBy & "',closedDT = GETDATE(), clsReason = '" & clsReason & "' where ID = '" & ID & "'"
        Dim da As New SqlDataAdapter(quer, SQLCon)
        Dim ds As New DataSet
        da.Fill(ds, table)
        MsgBox("Voided/Closed!")
        s.loadDTG(dt, "purchaseReturn")
    End Sub
End Class
