'Imports System.Data.SqlClient
'Imports System.Transactions

'Public Class cSqlTest
'    Private Const connString As String = "server=DESKTOP-QAELHH0\SQLEXPRESS;database=newPDB;Integrated Security=SSPI"

'    Public Sub SaveChanges()
'        Try
'            Using scope As New TransactionScope()
'                Using conn As New SqlConnection(connString)
'                    conn.Open()
'                    Dim cmd As New SqlCommand()
'                    cmd.Connection = conn

'                    cmd.CommandText = "update anjo_account set balance = balance + 10 where username = 'anjo'"
'                    cmd.ExecuteNonQuery()


'                    ' select if balance  < = zero
'                    Exit Sub

'                    cmd.CommandText = "insert into anjo_history (saveddt,refNumber,[in]) select getdate(),'test1',10"
'                    cmd.ExecuteNonQuery()

'                    scope.Complete()
'                End Using
'            End Using
'        Catch ex As Exception
'            MsgBox(ex.Message)
'        End Try
'    End Sub
'End Class
