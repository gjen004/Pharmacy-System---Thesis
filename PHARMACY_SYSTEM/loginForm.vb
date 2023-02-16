Imports System.Data.SqlClient

Public Class loginForm
    Dim c As New cControl
    Dim t As New SQLApp

    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtUser.Select()
        'Dim testsql As New cSqlTest
        'testsql.SaveChanges()
    End Sub

    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        't.hasConnect()
        'If txtUser.Text = "1" And txtPass.Text = "12108071" Then
        '    username = "1"
        '    adminMDI.Show()
        '    Me.Hide()
        '    Exit Sub
        'Else
        SQLCon.Open()
            Dim quer As String = "select * from employee where userName = '" & txtUser.Text & "'"
            Dim quer2 As String = "select pword from employee where userName = '" & txtUser.Text & "'"
            Dim userPass As String
            Dim cmd As SqlCommand = New SqlCommand(quer, SQLCon)
            Using reader As SqlDataReader = cmd.ExecuteReader()
                If txtUser.Text = "" Or txtPass.Text = "" Then
                    MsgBox("Please enter username and password!")
                    reader.Close()
                    SQLCon.Close()
                    Exit Sub
                ElseIf reader.HasRows = True Then
                    While reader.Read
                        username = reader("userName")
                    End While
                    reader.Close()
                    Dim cmd2 As SqlCommand = New SqlCommand(quer2, SQLCon)
                    Using reader2 As SqlDataReader = cmd2.ExecuteReader()
                        While reader2.Read
                            userPass = reader2("pword")
                        End While
                        If userPass.Equals(txtPass.Text) Then
                            reader2.Close()
                            adminMDI.Show()
                            Me.Hide()
                            SQLCon.Close()
                        Else
                            reader.Close()
                            reader2.Close()
                            MsgBox("Incorrect password!")
                            txtPass.Clear()
                            txtPass.Select()
                            SQLCon.Close()
                            Exit Sub
                        End If
                        reader.Close()
                        reader2.Close()
                        SQLCon.Close()
                    End Using
                    reader.Close()
                    SQLCon.Close()
                Else
                    reader.Close()
                    MsgBox("Username not found!")
                    txtUser.Clear()
                    username = ""
                    txtPass.Clear()
                    txtUser.Select()
                    SQLCon.Close()
                    Exit Sub
                End If
                reader.Close()
                SQLCon.Close()
            End Using
            SQLCon.Close()
        'End If
    End Sub

End Class