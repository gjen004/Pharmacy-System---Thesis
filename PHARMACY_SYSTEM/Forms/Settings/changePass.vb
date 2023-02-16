Imports System.Data.Sql
Imports System.Data.SqlClient

Public Class changePass
    Private Sub changePass_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtOldPass.Select()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim test As Boolean
        'test = txtNewPass.Text IsNot txtConPass.Text
        If txtOldPass.Text.Equals(password) Then
            If txtNewPass.Text.Length < 8 Then
                MsgBox("Password must be minimum of 8 characters!")
                txtOldPass.Clear()
                txtNewPass.Clear()
                txtConPass.Clear()
                txtOldPass.Select()
                Exit Sub
            ElseIf Not txtNewPass.Text.Equals(txtConPass.Text) Then
                MsgBox("New password and Confirm password did not match!")
                txtOldPass.Clear()
                txtNewPass.Clear()
                txtConPass.Clear()
                txtOldPass.Select()
                Exit Sub
            Else
                Dim quer As String = "UPDATE employee SET pword = '" & txtNewPass.Text & "' where userName = '" & username & "'"
                Dim da As New SqlDataAdapter(quer, SQLCon)
                Dim ds As New DataSet
                da.Fill(ds, "employee")
                MsgBox("Change password successful!")
                txtOldPass.Clear()
                txtNewPass.Clear()
                txtConPass.Clear()
                txtOldPass.Select()
                Exit Sub
            End If
        Else
            MsgBox("Incorrect password!")
            txtOldPass.Clear()
            txtNewPass.Clear()
            txtConPass.Clear()
            txtOldPass.Select()
            Exit Sub
        End If
    End Sub
End Class