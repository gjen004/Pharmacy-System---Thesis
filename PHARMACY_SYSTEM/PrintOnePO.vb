
Imports System.Data.Sql
Imports System.Data.SqlClient
Imports Microsoft.SqlServer

Public Class PrintOnePO
    Dim s As New cSQL
    Dim c As New cControl
    Private Sub Print(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim cmd1, cmd2 As SqlCommand
        Dim adp1 As New SqlDataAdapter
        Dim dt1 As New DataSet
        Dim sql1, sql2 As String

        Dim nani As Integer = c.UseId(SetPONum)
        SetPONum = Nothing

        sql1 = "select PONum, suppName, PODTCreate, PODTNeed from POList where PONum = '" & nani & "'"
        sql2 = "select Quantity,Product,unitPrice from PODetShowProd where PONum  = '" & nani & "'"

        cmd1 = New SqlCommand(sql1, SQLCon)
        cmd2 = New SqlCommand(sql2, SQLCon)
        adp1.SelectCommand = cmd1
        adp1.Fill(dt1, "POList")
        adp1.SelectCommand = cmd2
        adp1.Fill(dt1, "PODetShowProd")

        Dim rptDocument As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        Dim filepath As String = Application.StartupPath + "\rpt\CrystalReport2.rpt"
        'MsgBox(filepath)
        rptDocument.Load(filepath)
        rptDocument.SetDataSource(dt1.Tables(0))
        rptDocument.OpenSubreport("Items").SetDataSource(dt1.Tables(1))
        CrystalReportViewer1.ReportSource = rptDocument
        'end of new block

        CrystalReportViewer1.Refresh()
        cmd1.Dispose()
        adp1.Dispose()
        dt1.Dispose()
        cmd2.Dispose()
        'Dim rpt As New CrystalReport2
        'rpt.SetDataSource(dt1)
        'CrystalReportViewer1.ReportSource = rpt
        'Try

        'Catch ex As Exception
        '    MsgBox(ex.Message)
        'End Try
    End Sub


End Class