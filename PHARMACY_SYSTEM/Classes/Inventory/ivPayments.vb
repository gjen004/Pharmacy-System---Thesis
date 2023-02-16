Imports System.Data.SqlClient
Public Class ivPayments
    Dim s As New cSQL
    Public Sub CreatePayment(ByVal paymentNo As Integer, ByVal supplierID As Integer, ByVal savedWho As String)
        Dim quer As String
        Dim rn As String
        Dim temp As DateTime
        temp = Date.Now.ToShortDateString
        rn = Format(temp, "yyyy-MM-dd")
        quer = "Insert into payment(paymentNo,paymentDT,savedBy,savedDT) values('" & paymentNo & "','" & rn & "','" & savedWho & "',GETDATE())"
        Dim da As New SqlDataAdapter(quer, SQLCon)
        Dim ds As New DataSet
        da.Fill(ds, "payment")
    End Sub
    Public Sub AddPaymentToList(ByRef dtg As DataGridView, ByVal payNo As String, ByVal RRDID As Integer, ByVal amt As Integer, ByVal paymeth As String, ByVal bank As String, ByVal transNo As Integer, ByVal supp As String)
        Dim quer As String
        quer = "INSERT INTO payList(PaymentNo,Supplier,RRNo,Amount,PaymentMethod,Bank,TransactionNo) values('" & payNo & "','" & supp & "','" & RRDID & "','" & amt & "','" & paymeth & "','" & bank & "','" & transNo & "')"
        Dim da As New SqlDataAdapter(quer, SQLCon)
        Dim ds As New DataSet
        da.Fill(ds, "payList")
        s.loadDTGN(dtg, "payList", "", "PaymentNo = '" & payNo & "'", 3)
    End Sub

    Public Function ComputeBayarin(ByVal ID As Integer, ByVal paid As Double)
        Dim quer, test As String
        Dim temp As Double
        quer = "SELECT Balance FROM RR Where RRNo = '" & ID & "'"
        Dim da As New SqlDataAdapter(quer, SQLCon)
        Dim ds As New DataSet
        da.Fill(ds, "RR")
        test = CDbl(ds.Tables(0).Rows(0).Item(0))
        Convert.ToDouble(test)
        temp = test - paid
        'MsgBox(temp) to see how much
        If temp = 0 Then
            updateBayarin(ID, temp, 2)
        Else
            updateBayarin(ID, temp, 1)
        End If

        Return temp
    End Function
    Public Sub updateBayarin(ByVal ID As Integer, ByVal newBal As Integer, ByVal mode As Integer)
        Dim quer As String
        'update RRDetails set TotalAmount = 400 where ID = 79
        If mode = 1 Then 'pay not complete
            quer = "Update RRDetails set [PO Amount] = '" & newBal & "' Where ID = '" & ID & "'"
            Dim da As New SqlDataAdapter(quer, SQLCon)
            Dim ds As New DataSet
            da.Fill(ds, "RRDetails")
        ElseIf mode = 2 Then 'pay complete
            quer = "Update RRDetails set [PO Amount] = 0 Where ID = '" & ID & "'"
            Dim da As New SqlDataAdapter(quer, SQLCon)
            Dim ds As New DataSet
            da.Fill(ds, "RRDetails")
        End If
    End Sub



End Class
