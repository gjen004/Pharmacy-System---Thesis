Imports System.Data.Sql
Imports System.Data.SqlClient
Imports Microsoft.SqlServer
Public Class POHistory
    Dim s As New cSQL
    Dim c As New cControl

    Private Sub Print(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim cmd As SqlCommand
        Dim adp As New SqlDataAdapter
        Dim dt As New DataSet
        Dim sql As String = querPODR
        Dim con As String = My.Computer.FileSystem.ReadAllText(Application.StartupPath + "\db\srvrnm.txt")
        Dim newCon As New SqlConnection(con)
        cmd = New SqlCommand(sql, newCon)
        adp.SelectCommand = cmd
        adp.Fill(dt, "POReportHistory")
        Dim rptDocument As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        Dim filePath As String = Application.StartupPath + "\rpt\printPOHistory.rpt"
        rptDocument.Load(filePath)
        rptDocument.SetDataSource(dt.Tables(0))
        CrystalReportViewer1.ReportSource = rptDocument
        CrystalReportViewer1.Refresh()
        cmd.Dispose()
        adp.Dispose()
        dt.Dispose()
        querPODR = Nothing
    End Sub

End Class