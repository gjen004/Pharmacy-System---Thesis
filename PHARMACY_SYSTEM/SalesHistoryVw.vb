Imports System.Data.Sql
Imports System.Data.SqlClient
Imports Microsoft.SqlServer
Public Class SalesHistoryVw
    Dim s As New cSQL
    Dim c As New cControl

    Private Sub Print(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim cmd As SqlCommand
        Dim adp As New SqlDataAdapter
        Dim dt As New DataSet
        Dim sql As String = querSales
        Dim locVal As String = table
        cmd = New SqlCommand(sql, SQLCon)
        adp.SelectCommand = cmd
        adp.Fill(dt, locVal)


        Dim rptDocument As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        Dim filePath As String = Application.StartupPath + "\rpt\salesHistoryNew.rpt"
        rptDocument.Load(filePath)
        rptDocument.OpenSubreport(rptSubPop).SetDataSource(dt.Tables(0))
        CrystalReportViewer1.ReportSource = rptDocument
        CrystalReportViewer1.Refresh()
        cmd.Dispose()
        adp.Dispose()
        dt.Dispose()
        querSales = Nothing
        rptSubPop = Nothing
        table = Nothing
    End Sub
End Class