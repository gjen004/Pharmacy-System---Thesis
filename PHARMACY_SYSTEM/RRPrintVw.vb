Imports System.Data.Sql
Imports System.Data.SqlClient
Imports Microsoft.SqlServer
Public Class RRPrintVw
    Dim s As New cSQL
    Dim c As New cControl

    Private Sub Print(sender As Object, e As EventArgs) Handles MyBase.Load
        'mode 1 = allRR by date

        Dim cmd As SqlCommand
        Dim adp As New SqlDataAdapter
        Dim dt As New DataSet
        Dim sql As String = querRR

        cmd = New SqlCommand(sql, SQLCon)
        adp.SelectCommand = cmd
        adp.Fill(dt, "RRReportHistory")


        Dim rptDocument As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        Dim filePath As String = Application.StartupPath + "\rpt\printRRReports.rpt"
        rptDocument.Load(filePath)
        rptDocument.SetDataSource(dt.Tables(0))
        'rptDocument.OpenSubreport("allRR").SetDataSource(dt.Tables(0))
        CrystalReportViewer1.ReportSource = rptDocument
        CrystalReportViewer1.Refresh()
        cmd.Dispose()
        adp.Dispose()
        dt.Dispose()
        querRR = Nothing
        rptSubPop = Nothing
    End Sub
End Class