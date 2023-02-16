Imports System.Data.Sql
Imports System.Data.SqlClient


Public Class userSettings
    Dim c As New cControl
    Dim s As New cSQL

    Private Sub FormLoad(sender As Object, e As EventArgs) Handles MyBase.Load
        s.loadCBX(cmbUser, "employeeView", "ID", "employeeName")
        's.loadCBX(cmbUser, "employeeView", "ID", "employeeName")
        c.clrData(dgvRestrictions)
        Populate()
    End Sub

    Private Sub hideID(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles dgvControls.DataBindingComplete
        With dgvControls
            .Columns("ID").Visible = False
            .Columns("formName").Visible = False
            dgvControls.ClearSelection()
        End With
    End Sub

    Private Sub hideIDandName(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles dgvRestrictions.DataBindingComplete
        With dgvRestrictions
            .Columns("ID").Visible = False
            .Columns("User").Visible = False
            dgvRestrictions.ClearSelection()
        End With
    End Sub

    Private Sub cellClick(sender As Object, e As EventArgs) Handles dgvControls.CellClick
        Dim i As Integer
        i = dgvControls.CurrentRow.Index
        contID = dgvControls.Item(0, i).Value
        empID = c.getData(cmbUser)
    End Sub

    Private Sub btnProdAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If String.IsNullOrEmpty(cmbUser.Text) = True Then
            MsgBox("Please select a User!")
            Exit Sub
        ElseIf s.checkValStr("employeeView", "[employeeName]", cmbUser.Text) = False Then
            MsgBox("User does Not exist!")
            Exit Sub
        ElseIf dgvControls.SelectedRows.Count < 1 Then
            MsgBox("Please select a Control!")
            Exit Sub
        Else

            SQLCon.Open()
            Dim quer As String = "select * from Restrictions where userID = '" & empID & "' and controlID = '" & contID & "'"
        Dim quer1 As String = "insert into Restrictions values('" & empID & "','" & contID & "')"
            Dim cmd As SqlCommand = New SqlCommand(quer, SQLCon)
            Using reader As SqlDataReader = cmd.ExecuteReader()
                If reader.HasRows = True Then
                    MsgBox("Control already exists in the User's Restrictions!")
                    reader.Close()
                    SQLCon.Close()
                    Exit Sub
                Else
                    reader.Close()
                    Dim da As New SqlDataAdapter(quer1, SQLCon)
                    Dim ds As New DataSet
                    da.Fill(ds, "Restrictions")
                    SQLCon.Close()
                    s.loadDTGN(dgvRestrictions, "restrictionView", "[User]", "[User] = '" & cmbUser.Text & "'", 3)
                End If
            End Using
            SQLCon.Close()
        End If
    End Sub

    Private Sub Populate()
        s.loadDTGN(dgvControls, "Controls", "ID, controlName as 'Control Name', formName", "", 2)
    End Sub

    Private Sub userChange(sender As Object, e As EventArgs) Handles cmbUser.SelectedIndexChanged
        'If cmbUser.SelectedIndex > -1 Then
        s.loadDTGN(dgvRestrictions, "restrictionView", "[User]", "[User] = '" & cmbUser.Text & "'", 3)
        'End If
    End Sub

    Private Sub restriction(sender As Object, e As EventArgs) Handles cmbUser.TextChanged
        c.clrDS(dgvRestrictions)
    End Sub

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        Try
            Dim i As Integer
            i = dgvRestrictions.CurrentRow.Index
            id = dgvRestrictions.Item(0, i).Value
            s.delete(dgvRestrictions, "restrictions", id)
            s.loadDTGN(dgvRestrictions, "restrictionView", "[User]", "[User] = '" & cmbUser.Text & "'", 3)
        Catch ex As Exception
            MsgBox("No Item Selected!", vbOKOnly, caption)
        End Try

    End Sub

    'Private Sub SeeAccess(sender As Object, e As EventArgs) Handles cmbUser.DropDownClosed
    '    Dim vals As String
    '    whereIs = c.getData(cmbUser)
    '    'vals = s.GetDetail("employee", "Access", whereIs)
    '    s.LoadAccess(vals, grpChoice)
    'End Sub

    'Private Sub UncheckAll(sender As Object, e As EventArgs)
    '    s.BoomLoop(grpChoice)
    'End Sub

    'Private Sub CheckAll(sender As Object, e As EventArgs)
    '    s.GoodLoop(grpChoice)
    'End Sub

    'Private Sub SaveChanges(sender As Object, e As EventArgs)
    '    _index = c.getData(cmbUser)
    '    s.AlterAccess(grpChoice, _index)
    '    MsgBox("Success!")
    '    s.BoomLoop(grpChoice)
    'End Sub

End Class