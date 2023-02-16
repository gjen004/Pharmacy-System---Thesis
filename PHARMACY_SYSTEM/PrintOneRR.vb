Imports System.Data.SqlClient
Public Class PrintOneRR
    Dim s As New cSQL
    Dim c As New cControl
    Private Sub Print(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim cmd1, cmd2 As SqlCommand
        Dim adp1 As New SqlDataAdapter
        Dim dt1 As New DataSet
        Dim sql1, sql2 As String

        Dim nani As Integer = c.UseId(SetPONum)
        SetPONum = Nothing

        sql1 = "select RRNo, Supplier, RRDate, totalRR from RRList where RRNo = '" & nani & "'"
        sql2 = "select QuantityReceived,Product,ProdExpDate,[Unit Cost],RRAmount from UpdateRR where RRID  = '" & nani & "'"

        cmd1 = New SqlCommand(sql1, SQLCon)
        cmd2 = New SqlCommand(sql2, SQLCon)
        adp1.SelectCommand = cmd1
        adp1.Fill(dt1, "RRList")
        adp1.SelectCommand = cmd2
        adp1.Fill(dt1, "UpdateRR")

        Dim rptDocument As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        Dim filepath As String = Application.StartupPath + "\rpt\CrystalReport2.rpt"
        rptDocument.Load(filePath)
        rptDocument.SetDataSource(dt1.Tables(0))
        rptDocument.OpenSubreport("RRDetails").SetDataSource(dt1.Tables(1))
        CrystalReportViewer1.ReportSource = rptDocument
        'end of new block

        'Dim rpt As New CrystalReport2
        'rpt.SetDataSource(dt1)
        'CrystalReportViewer1.ReportSource = rpt
        CrystalReportViewer1.Refresh()
        cmd1.Dispose()
        adp1.Dispose()
        dt1.Dispose()
        cmd2.Dispose()
    End Sub
End Class