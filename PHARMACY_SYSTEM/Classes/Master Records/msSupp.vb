Imports System.Data.SqlClient
Public Class dbSupp
    Dim s As New cSQL
    Public Sub addSup(ByRef dt As DataGridView, ByVal table As String, ByVal suppName As String, ByVal suppAddress As String, ByVal cityID As Integer, ByVal provinceID As Integer, ByVal contactNo As String, ByVal contactPerson As String, ByVal tin As String, ByVal savedBy As String, ByRef btn As Button)
        SQLCon.Open()
        Dim checkQuery As String = "select * from supplier where suppName = '" & suppName & "'"
        Dim cmd As SqlCommand = New SqlCommand(checkQuery, SQLCon)
        Using reader As SqlDataReader = cmd.ExecuteReader()
            If reader.HasRows Then
                MsgBox("Invalid Input! Supplier name already exist!")
                btn.Enabled = False
                SQLCon.Close()
                Exit Sub
                'ElseIf IsNumeric(contactNo) Then
                '    MsgBox("Invalid Input! Contact number must be numeric!")
            ElseIf IsNumeric(tin) = False Then
                MsgBox("Invalid Input! TIN must be numeric!")
            Else
                reader.Close()
                Dim quer As String
                quer = "Insert into supplier(suppName, suppAddress,cityID, provinceID,contactNo, contactPerson, tin, savedBy, savedDT) "
                quer = quer + "values ('" & suppName & "','" & suppAddress & "','" & cityID & "','" & provinceID & "','" & contactNo & "','" & contactPerson & "','" & tin & "','" & savedBy & "',GETDATE())"
                Dim da As New SqlDataAdapter(quer, SQLCon)
                Dim ds As New DataSet
                da.Fill(ds, table)
                MsgBox("Supplier Added Successfully!")
                btn.Enabled = False
            End If
        End Using
    End Sub
    Public Sub updSup(ByVal id As Integer, ByRef dt As DataGridView, ByVal table As String, ByVal suppName As String, ByVal suppAddress As String, ByVal cityID As Integer, ByVal provinceID As Integer, ByVal contactNo As String, ByVal contactPerson As String, ByVal tin As String, ByVal updatedBy As String, ByRef btn As Button)
        If IsNumeric(contactNo) = False Then
            MsgBox("Invalid Input! Contact number must be numeric!")
        ElseIf IsNumeric(tin) = False Then
            MsgBox("Invalid Input! TIN must be numeric!")
        Else
            Dim quer As String
            quer = "UPDATE supplier SET "
            quer = quer + "suppName = '" & suppName & "', suppAddress = '" & suppAddress & "',cityID = '" & cityID & "', provinceID = '" & provinceID & "',contactNo = '" & contactNo & "',contactPerson = '" & contactPerson & "',TIN = '" & tin & "',updatedBy = '" & updatedBy & "',updatedDT = GETDATE() where ID = '" & id & "'"

            Dim da As New SqlDataAdapter(quer, SQLCon)
            Dim ds As New DataSet
            da.Fill(ds, table)
            MsgBox("Supplier Record Updated Successfully!")
            btn.Enabled = False
            s.loadDTG(dt, "supplier")
        End If
    End Sub
    Public Sub searchSupplier(ByVal table As String, ByRef dt As DataGridView, valueToSearch As String, ByVal mode As Integer)
        SQLCon.Open()
        Dim searchQuery As String
        If mode = 1 Then
            searchQuery = "Select * from viewSupp where [Supplier Name] like '%" & valueToSearch & "%'"
        ElseIf mode = 2 Then
            searchQuery = "Select * from viewSupp where [Address] like '%" & valueToSearch & "%'"
        ElseIf mode = 3 Then
            searchQuery = "Select * from viewSupp where ([Supplier Name] + [Address] + [Contact No.] + [Contact Person] + [TIN]) like '%" & valueToSearch & "%'"
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
            searchQuery = "Select * from supplier where suppName like '%" & valueToSearch & "%'"
        ElseIf mode = 2 Then
            searchQuery = "Select * from supplier where provinceID like '%" & valueToSearch & "%'"
            'ElseIf mode = 3 Then
            '    searchQuery = "Select * from viewFullProd where CONCAT([Product Code], [Product], [Form], [Category], [Status]) like '%" & valueToSearch & "%'"
        End If

        Dim da As New SqlDataAdapter(searchQuery, SQLCon)
        Dim ds As New DataSet
        da.Fill(ds, table)
        SQLCon.Close()
        dt.DataSource = ds.Tables(0)
    End Sub
End Class
