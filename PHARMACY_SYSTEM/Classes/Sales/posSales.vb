Imports System.Data.SqlClient
Public Class posSales
    Dim s As New cSQL
    <CodeAnalysis.SuppressMessage("Microsoft.Security", "CA2100:Review SQL queries for security vulnerabilities")>
    Public Sub LoadProdStock(ByVal prodName As String)
        Dim quer As String
        quer = "SELECT * FROM viewProductQuantity Where Product = '" & prodName & "'"
        Dim da As New SqlDataAdapter(quer, SQLCon)
        Dim ds As New DataSet
        da.Fill(ds, "viewProductQuantity")
    End Sub
    Public Sub TempRecord(ByRef dtg As DataGridView, ByVal prodName As String, ByVal qty As Integer, ByVal subtotal As Integer)
        Dim quer As String
        quer = "Insert into tempBuyList(Product,Quantity,Subtotal) values('" & prodName & "','" & qty & "','" & subtotal & "')"
        Dim da As New SqlDataAdapter(quer, SQLCon)
        Dim ds As New DataSet
        da.Fill(ds, "tempBuyList")
        s.loadDTG(dtg, "tempBuyList")
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
        Dim quer, test As String
        quer = "SELECT PercentDscnt FROM discount Where ID = '" & id & "'"
        Dim da As New SqlDataAdapter(quer, SQLCon)
        Dim ds As New DataSet
        da.Fill(ds, "promo")
        test = ds.Tables(0).Rows(0).Item(0).ToString
        Return Convert.ToInt32(test)
    End Function
    Public Function GetCount()
        Dim quer, test As String
        Dim chk As Integer
        quer = "SELECT count(*) FROM sales"
        Dim da As New SqlDataAdapter(quer, SQLCon)
        Dim ds As New DataSet
        da.Fill(ds, "sales")
        test = ds.Tables(0).Rows(0).Item(0).ToString
        MsgBox(test)
        If test = "" Then
            chk = 1
        Else
            chk = test + 1
        End If
        Return chk
    End Function
    Public Sub salesDet(ByVal sn As Integer, ByVal prod As Integer, ByVal qty As Integer, ByVal free As Integer, ByVal promo As Integer)
        Dim quer As String
        quer = "Insert into salesDetails(salesID,productID,quantity,freeQty,promoID) values('" & sn & "','" & prod & "','" & qty & "','" & free & "','" & promo & "')"
        Dim da As New SqlDataAdapter(quer, SQLCon)
        Dim ds As New DataSet
        da.Fill(ds, "salesDetails")
    End Sub
End Class
