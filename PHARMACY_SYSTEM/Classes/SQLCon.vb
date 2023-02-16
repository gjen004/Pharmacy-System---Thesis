Imports System.Data.Sql
Imports System.Data.SqlClient

Public Class SQLApp

    Public SQLCon As New SqlConnection With {.ConnectionString = "server=DESKTOP-OQMKEJC\SQLEXPRESS2008;database=dbPharamacy;Integrated Security=SSPI"}
    Public SQLCmd As SqlCommand
    Public SQLDA As SqlDataAdapter
    Public SQLDataset As New DataSet

    Public Function hasConnect() As Boolean
        Try
            SQLCon.Open()
            SQLCon.Close()
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function

    Public Sub RunQuery(ByVal Query As String)
        Try
            SQLCon.Open()
            SQLCmd = New SqlCommand(Query, SQLCon)
            SQLDA = New SqlDataAdapter(SQLCmd)
            SQLDA.Fill(SQLDataset)
            SQLCon.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            If SQLCon.State = ConnectionState.Open Then
                SQLCon.Close()
            End If
        End Try
    End Sub

    Public Sub getTableName(ByVal tb As String)
        SQLDA.Fill(SQLDataset, tb)
    End Sub

End Class
