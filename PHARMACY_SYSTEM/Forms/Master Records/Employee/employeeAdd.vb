Imports System.Data.Sql
Imports System.Data.SqlClient

Public Class employeeAdd
    Dim s As New cSQL
    Dim c As New cControl
    Private Sub btnProdAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        getValAdd()
    End Sub

    Private Sub hideID(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles dgvEmployee.DataBindingComplete
        With dgvEmployee
            .Columns("ID").Visible = False
            .Columns("password").Visible = False
            dgvEmployee.ClearSelection()
        End With
    End Sub

    'Private Sub enableAdd(sender As Object, e As EventArgs) Handles txtPass.KeyDown
    '    If txtFname.Text = "" And txtLname.Text = "" And cmbSex.SelectedIndex = 0 And cmbPosition.SelectedIndex = 0 And txtUser.Text = "" And txtPass.Text = "" Then
    '        btnAdd.Enabled = False
    '    Else
    '        btnAdd.Enabled = True                                                                        TINANGGAL KO TONG BUONG PRIVATE SUB  01/03/2020
    '    End If
    'End Sub

    Private Sub getValAdd()
        'getData
        'fname = c.getData(txtFname).ToString.ToUpper
        'lname = c.getData(txtLname).ToString.ToUpper
        'sex = c.getData(cmbSex).ToString.ToUpper
        'pos = c.getData(cmbPosition)
        'hiredate = c.getData(dtHiredate)
        'user = c.getData(txtUser)
        'pass = c.getData(txtPass)
        'temp = "user"

        SQLCon.Open()
        Dim passCount As Integer
        passCount = txtPass.Text.Length()
        Dim checkQuery As String = "select * from employee where userName = '" & txtUser.Text & "'"
        Dim cmd As SqlCommand = New SqlCommand(checkQuery, SQLCon)
        Using reader As SqlDataReader = cmd.ExecuteReader()
            'If String.IsNullOrEmpty(fname) = True Or String.IsNullOrEmpty(lname) = True Or String.IsNullOrEmpty(user) = True Or String.IsNullOrEmpty(pass) = True Then
            '    MsgBox("Please Fill In All Fields")
            '    SQLCon.Close()
            '    reader.Close()
            '    Exit Sub
            If txtFname.Text = "" Then
                MsgBox("Please Fill In All Fields!", vbOKOnly, caption)
                txtFname.Select()
                SQLCon.Close()
                reader.Close()
                Exit Sub
            ElseIf txtLname.Text = "" Then
                MsgBox("Please Fill In All Fields!", vbOKOnly, caption)
                txtLname.Select()
                SQLCon.Close()
                reader.Close()
                Exit Sub
            ElseIf cmbSex.SelectedIndex = -1 Then
                MsgBox("ERROR! No Sex Selected or Item Does Not Exist on the List!", vbOKOnly, caption)
                cmbSex.Select()
                SQLCon.Close()
                reader.Close()
                Exit Sub
            ElseIf cmbPosition.SelectedIndex = -1 Then
                MsgBox("ERROR! No Position Selected or Item Does Not Exist on the List!", vbOKOnly, caption)
                cmbPosition.Select()
                SQLCon.Close()
                reader.Close()
                Exit Sub
            ElseIf dtHiredate.Value > Date.Now Then
                MsgBox("Invalid Input! Hiredate should not be greater than present date!", vbOKOnly, caption)
                dtHiredate.Select()
                SQLCon.Close()
                reader.Close()
                Exit Sub
            ElseIf txtUser.Text = "" Then
                MsgBox("Please Fill in All Fields!", vbOKOnly, caption)
                txtUser.Select()
                SQLCon.Close()
                reader.Close()
                Exit Sub
            ElseIf reader.HasRows Then
                MsgBox("Invalid Input! Username is already existing!", vbOKOnly, caption)
                'btnAdd.Enabled = True
                txtUser.Select()
                SQLCon.Close()
                reader.Close()
                Exit Sub
            ElseIf txtPass.Text = "" Or passCount < 8 Then
                reader.Close()
                MsgBox("ERROR! Password must be minimum of 8 characters!", vbOKOnly, caption)
                txtPass.Select()
                'btnAdd.Enabled = False
                SQLCon.Close()
                Exit Sub
            Else
                reader.Close()
                'empName = s.getName()
                empName = s.GetDetailStr("employeeView", "EmployeeName", "userName", username)
                fname = c.getData(txtFname).ToString.ToUpper
                lname = c.getData(txtLname).ToString.ToUpper
                sex = c.getData(cmbSex).ToString.ToUpper
                pos = c.getData(cmbPosition)
                hiredate = c.getData(dtHiredate)
                user = c.getData(txtUser)
                pass = c.getData(txtPass)
                temp = empName

                reader.Close()
                s.addEmployee(dgvEmployee, "employee", fname, lname, sex, pos, hiredate, user, pass, temp, btnAdd)
                s.loadDTG(dgvEmployee, "viewEmployee")
                SQLCon.Close()
                'btnAdd.Enabled = False
            End If
        End Using
        SQLCon.Close()
        c.clrData(grpEmpInfo)
        populate()
        'addData
        'magkalaman. magkalaman, magkalalaman
        'c.clrData(GroupBox9)
    End Sub

    Private Sub populate()
        dgvEmployee.DataSource = Nothing
        'populate DTG
        s.loadDTG(dgvEmployee, "viewEmployee")
        s.loadCBX(cmbPosition, "empposition", "ID", "empPosName")
        s.loadCBX(cmbSex, "sex", "ID", "sexName")
        dgvEmployee.Columns(5).DefaultCellStyle.Format = "MM/dd/yyyy"
    End Sub

    Private Sub employeeAdd_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        populate()
        dgvEmployee.ClearSelection()
        dtHiredate.Format = DateTimePickerFormat.Custom
        dtHiredate.CustomFormat = "MM/dd/yyyy"
        dgvEmployee.Columns(5).DefaultCellStyle.Format = "MM/dd/yyyy"
        c.clrData(dgvEmployee)
        'btnAdd.Enabled = False
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        populate()
        c.clrData(grpEmpInfo)
        'btnAdd.Enabled = False
    End Sub
End Class