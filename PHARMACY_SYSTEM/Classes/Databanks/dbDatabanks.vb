Imports System.Data.SqlClient
Public Class dbDatabanks
    Dim s As New cSQL
    'databank
    Public Sub addToDataByTXT(ByRef txt As TextBox, ByRef dt As DataGridView, ByVal type As Integer)
        If type = 1 Then
            s.RunQuery("Insert into category(categName) values('" & txt.Text & "')")
            MsgBox("Added Successfully!")
            s.loadDTG(dt, "category")
        ElseIf type = 2 Then
            s.RunQuery("Insert into bank(bankName) values('" & txt.Text & "')")
            MsgBox("Added Successfully!")
            s.loadDTG(dt, "bank")
        ElseIf type = 3 Then
            s.RunQuery("Insert into city(cityName) values('" & txt.Text & "')")
            MsgBox("Added Successfully!")
            s.loadDTG(dt, "city")
        ElseIf type = 4 Then
            s.RunQuery("Insert into discount(dscType) values('" & txt.Text & "')")
            MsgBox("Added Successfully!")
            s.loadDTG(dt, "discount")
        ElseIf type = 5 Then
            s.RunQuery("Insert into dosage(dsgName) values('" & txt.Text & "')")
            MsgBox("Added Successfully!")
            s.loadDTG(dt, "dosage")
        ElseIf type = 6 Then
            s.RunQuery("Insert into form(formName) values('" & txt.Text & "')")
            MsgBox("Added Successfully!")
            s.loadDTG(dt, "form")
        ElseIf type = 7 Then
            s.RunQuery("Insert into generic(genName) values('" & txt.Text & "')")
            MsgBox("Added Successfully!")
            s.loadDTG(dt, "generic")
        ElseIf type = 8 Then
            s.RunQuery("Insert into province(provinceName) values('" & txt.Text & "')")
            MsgBox("Added Successfully!")
            s.loadDTG(dt, "province")
        ElseIf type = 9 Then
            s.RunQuery("Insert into productUnit(unitMsr) values('" & txt.Text & "')")
            MsgBox("Added Successfully!")
            s.loadDTG(dt, "productUnit")
        ElseIf type = 10 Then
            s.RunQuery("Insert into reason(fullReason) values('" & txt.Text & "')")
            MsgBox("Added Successfully!")
            s.loadDTG(dt, "reason")
        ElseIf type = 11 Then
            s.RunQuery("Insert into empPosition(empPosName) values('" & txt.Text & "')")
            MsgBox("Added Successfully!")
            s.loadDTG(dt, "empPosition")
        End If
    End Sub
    Public Sub addPromo(ByRef dt As DataGridView, ByVal table As String, ByVal prodID As Integer, ByVal startDT As String, ByVal endDT As String, ByVal percentage As Integer, ByVal savedBy As String, ByVal promoName As String)
        Dim quer As String
        quer = "Insert INTO promo(PromoName,ProductID,StartDate,EndDate,PercentDsc,savedBy,savedDT) "
        quer = quer + "values('" & promoName & "','" & prodID & "','" & startDT & "','" & endDT & "','" & percentage & "','" & savedBy & "',GETDATE())"
        Dim da As New SqlDataAdapter(quer, SQLCon)
        Dim ds As New DataSet
        da.Fill(ds, table)
        MsgBox("Added!")
        s.loadDTG(dt, "promo")
    End Sub
    Public Sub addDsc(ByRef dt As DataGridView, ByVal table As String, ByVal name As String, ByVal percentage As Integer)
        Dim quer As String
        quer = "INSERT INTO discount(DiscountName,PercentDscnt) values('" & name & "','" & percentage & "')"
        Dim da As New SqlDataAdapter(quer, SQLCon)
        Dim ds As New DataSet
        da.Fill(ds, table)
        MsgBox("Added!")
        s.loadDTG(dt, "discount")
    End Sub

    Public Sub databankChecking(ByVal table As String, ByVal column As String, ByVal input As String, ByRef btn As Button)
        SQLCon.Open()
        Dim checkQuery As String = "select * from " & table & " where " & column & " like '%" & input & "%'"
        Dim cmd As SqlCommand = New SqlCommand(checkQuery, SQLCon)
        Using reader As SqlDataReader = cmd.ExecuteReader()
            If reader.HasRows Then
                MsgBox("Invalid Input! Data already exist!")
                btn.Enabled = False
                SQLCon.Close()
                Exit Sub
            Else
                reader.Close()
                Dim ex As SqlCommand = New SqlCommand("Insert into " & table & " values('" & input & "')", SQLCon)
                ex.ExecuteNonQuery()
                MsgBox("Record successfully added!")
                btn.Enabled = False
            End If
        End Using
        SQLCon.Close()
    End Sub

    Public Sub databankCheckingV2(ByVal table As String, ByVal column1 As String, ByVal input1 As String, ByVal input2 As String, ByRef btn As Button)
        SQLCon.Open()
        Dim checkQuery As String = "select * from " & table & " where " & column1 & " like '%" & input1 & "%'"
        Dim cmd As SqlCommand = New SqlCommand(checkQuery, SQLCon)
        Using reader As SqlDataReader = cmd.ExecuteReader()
            If reader.HasRows Then
                MsgBox("Invalid Input! Data already exist!")
                btn.Enabled = False
                SQLCon.Close()
                Exit Sub
            Else
                reader.Close()
                Dim ex As SqlCommand = New SqlCommand("Insert into " & table & " values('" & input1 & "','" & input2 & "')", SQLCon)
                ex.ExecuteNonQuery()
                MsgBox("Record successfully added!")
                btn.Enabled = False
            End If
        End Using
        SQLCon.Close()
    End Sub
End Class
