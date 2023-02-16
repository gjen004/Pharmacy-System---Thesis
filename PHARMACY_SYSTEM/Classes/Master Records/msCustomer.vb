Imports System.Data.SqlClient
Public Class dbCustomer
    Dim s As New cSQL
    Public Sub addCust(ByRef dt As DataGridView, ByVal table As String, ByVal custName As String, ByVal custAddress As String, ByVal cityID As Integer, ByVal provinceID As Integer, ByVal contactNo As String, ByVal savedBy As String)
        If IsNumeric(contactNo) = False Then
            MsgBox("Invalid Input! Contact number must be numeric!")
            Exit Sub
        Else
            Dim quer As String
            quer = "Insert into customer(custName, custAddress,cityID, provinceID,contactNo, savedBy, savedDT) "
            quer = quer + "values ('" & custName & "','" & custAddress & "','" & cityID & "','" & provinceID & "','" & contactNo & "','" & savedBy & "',GETDATE())"
            Dim da As New SqlDataAdapter(quer, SQLCon)
            Dim ds As New DataSet
            da.Fill(ds, table)
            MsgBox("Customer Added Successfully!")
            s.loadDTG(dt, "customerView")
        End If
    End Sub
    Public Sub updCust(ByVal id As Integer, ByRef dt As DataGridView, ByVal table As String, ByVal custName As String, ByVal custAddress As String, ByVal cityID As Integer, ByVal provinceID As Integer, ByVal contactNo As String, ByVal updatedBy As String)
        If IsNumeric(contactNo) = False Then
            MsgBox("Invalid Input! Contact number must be numeric!")
            Exit Sub
        Else
            Dim quer As String
            quer = "UPDATE customer SET "
            quer = quer + "custName = '" & custName & "', custAddress = '" & custAddress & "',cityID = '" & cityID & "', provinceID = '" & provinceID & "',contactNo = '" & contactNo & "',updatedBy = '" & updatedBy & "',updatedDT = GETDATE() where ID = '" & id & "'"

            Dim da As New SqlDataAdapter(quer, SQLCon)
            Dim ds As New DataSet
            da.Fill(ds, table)
            MsgBox("Customer Record Updated Successfully!")
            s.loadDTG(dt, "customer")
        End If
    End Sub
    Public Sub searchCustomer(ByVal table As String, ByRef dt As DataGridView, valueToSearch As String, ByVal mode As Integer)
        SQLCon.Open()
        Dim searchQuery As String
        If mode = 1 Then
            searchQuery = "Select * from customerView where [Customer Name] like '%" & valueToSearch & "%'"
        ElseIf mode = 2 Then
            searchQuery = "Select * from customerView where [Address] like '%" & valueToSearch & "%'"
        ElseIf mode = 3 Then
            'searchQuery = "Select * from CustomerView where ([Customer Name] + [Address] + [City] + [Province] + [Contact No.]) like '%" & valueToSearch & "%'"
            searchQuery = "Select * from CustomerView where ([Customer Name] + [Address] + [Contact No.]) like '%" & valueToSearch & "%'"
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
            searchQuery = "Select * from viewcustomer where [Customer Name] like '%" & valueToSearch & "%'"
        ElseIf mode = 2 Then
            searchQuery = "Select * from viewcustomer where [Address] like '%" & valueToSearch & "%'"
        ElseIf mode = 3 Then
            searchQuery = "Select * from viewCustomer where ([Customer Name] + [Address] + [City] + [Province] + [Contact No.]) like '%" & valueToSearch & "%'"
        End If

        Dim da As New SqlDataAdapter(searchQuery, SQLCon)
        Dim ds As New DataSet
        da.Fill(ds, table)
        SQLCon.Close()
        dt.DataSource = ds.Tables(0)
    End Sub
End Class
