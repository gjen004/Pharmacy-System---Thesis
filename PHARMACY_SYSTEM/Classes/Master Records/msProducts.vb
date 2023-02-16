Imports System.Data.SqlClient
Public Class dbProducts
    Dim s As New cSQL
    Public Sub addProduct(ByRef dt As DataGridView, ByVal table As String, ByVal prod As String, ByVal cat As Integer, ByVal brnd As String, ByVal gn As Integer, ByVal dos As Integer, ByVal unt As Integer, ByVal frm As Integer, ByVal stat As Integer, ByVal user As String, ByRef btn As Button)
        SQLCon.Open()
        Dim checkQuery1 As String = "select * from " & table & " where proCode = '" & prod & "'"
        Dim cmd As SqlCommand = New SqlCommand(checkQuery1, SQLCon)
        Using reader As SqlDataReader = cmd.ExecuteReader()
            If reader.HasRows Then
                MsgBox("Invalid Input! Product Code already exist!")
                SQLCon.Close()
                btn.Enabled = False
                Exit Sub
            Else
                reader.Close()
                Dim quer As String
                quer = "Insert into product(proCode,categID,genericID,brandName,prodUnit,dosageID,formID,prodStatID,savedBy,SavedDT) "
                quer = quer + "values ('" & prod & "','" & cat & "','" & gn & "','" & brnd & "','" & unt & "','" & dos & "','" & frm & "','" & stat & "','" & user & "',GETDATE())"

                Dim da As New SqlDataAdapter(quer, SQLCon)
                Dim ds As New DataSet
                da.Fill(ds, table)
                MsgBox("Product Added Successfully!")
                s.loadDTG(dt, "product")
                btn.Enabled = False
            End If
        End Using
    End Sub
    Public Sub updProd(ByVal id As Integer, ByRef dt As DataGridView, ByVal table As String, ByVal prod As String, ByVal cat As Integer, ByVal brnd As String, ByVal gn As Integer, ByVal dos As Integer, ByVal unt As Integer, ByVal frm As Integer, ByVal stat As Integer, ByVal user As String, ByRef btn As Button)
        Dim quer As String
        quer = "UPDATE product SET "
        quer = quer + "proCode = '" & prod & "', categID = '" & cat & "',genericId = '" & gn & "', brandName = '" & brnd & "',prodUnit = '" & unt & "',dosageID = '" & dos & "',formID = '" & frm & "',prodStatID = '" & stat & "',updatedBy = '" & user & "',updatedDT = GETDATE() where ID = '" & id & "'"

        Dim da As New SqlDataAdapter(quer, SQLCon)
        Dim ds As New DataSet
        da.Fill(ds, table)
        MsgBox("Product Updated Successfully!")
        s.loadDTG(dt, "viewproduct")
        btn.Enabled = False
    End Sub
    Public Sub searchProduct(ByVal table As String, ByRef dt As DataGridView, valueToSearch As String, ByVal mode As Integer)
        SQLCon.Open()
        Dim searchQuery As String
        If mode = 1 Then
            searchQuery = "Select * from viewFullProd where [Product Code] like '%" & valueToSearch & "%'"
        ElseIf mode = 2 Then
            searchQuery = "Select * from viewFullProd where [Product] like '%" & valueToSearch & "%'"
        ElseIf mode = 3 Then
            searchQuery = "Select * from viewFullProd where ([Product Code] + [Product] + [Form] + [Category] + [Status]) like '%" & valueToSearch & "%'"
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
            searchQuery = "Select * from product where proCode like '%" & valueToSearch & "%'"
        ElseIf mode = 2 Then
            searchQuery = "Select * from product where brandName like '%" & valueToSearch & "%'"
        ElseIf mode = 3 Then
            searchQuery = "Select * from viewproduct where ([Product Code] + [Category] + [Generic Name] + [Brand Name] + [Unit] + [Dosage] + [Form] + [Status]) like '%" & valueToSearch & "%'"
        End If

        Dim da As New SqlDataAdapter(searchQuery, SQLCon)
        Dim ds As New DataSet
        da.Fill(ds, table)
        SQLCon.Close()
        dt.DataSource = ds.Tables(0)
    End Sub
End Class
