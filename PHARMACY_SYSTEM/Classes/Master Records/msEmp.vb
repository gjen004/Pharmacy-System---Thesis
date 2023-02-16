Imports System.Data.SqlClient
Public Class dbEmp
    Dim s As New cSQL
    Public Sub addEmployee(ByRef dt As DataGridView, ByVal table As String, ByVal fnm As String, ByVal lnm As String, ByVal sx As String, ByVal pos As String, ByVal hdate As String, ByVal usr As String, ByVal pss As String, ByVal savedBy As String, ByRef btn As Button)
        SQLCon.Open()
        Dim checkQuery As String = "select * from " & table & " where userName = '" & usr & "'"
        Dim cmd As SqlCommand = New SqlCommand(checkQuery, SQLCon)
        Using reader As SqlDataReader = cmd.ExecuteReader()
            If reader.HasRows Then
                MsgBox("Invalid Input! Username already taken!")
                btn.Enabled = False
                SQLCon.Close()
                Exit Sub
            Else
                reader.Close()
                Dim quer As String
                quer = "Insert into employee(fname,lname,sexID,posID,hiredate,userName,pword,savedBy, savedDT) "
                quer = quer + "values ('" & fnm & "','" & lnm & "','" & sx & "','" & pos & "','" & hdate & "','" & usr & "','" & pss & "','" & temp & "',GETDATE())"

                Dim da As New SqlDataAdapter(quer, SQLCon)
                Dim ds As New DataSet
                da.Fill(ds, table)
                MsgBox("Employee Added Successfully!")
                s.loadDTG(dt, "viewEmployee")
            End If
        End Using
    End Sub
    Public Sub updEmp(ByVal id As Integer, ByRef dt As DataGridView, ByVal table As String, ByVal fname As String, ByVal lname As String, ByVal sexID As Integer, ByVal posID As Integer, ByVal hdate As String, ByVal usr As String, ByVal pss As String, ByVal updatedBy As String, ByRef btn As Button)
        Dim quer As String
        quer = "UPDATE employee SET "
        quer = quer + "fname = '" & fname & "', lname = '" & lname & "', sexID = '" & sexID & "', posID = '" & posID & "', hiredate = '" & hdate & "', userName = '" & usr & "', pword = '" & pss & "', updatedBy = '" & updatedBy & "', updatedDT = GETDATE() where ID = '" & id & "'"

        Dim da As New SqlDataAdapter(quer, SQLCon)
        Dim ds As New DataSet
        da.Fill(ds, table)
        MsgBox("Employee Record Updated Successfully!")
        btn.Enabled = False
        s.loadDTG(dt, "employee")
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
End Class
