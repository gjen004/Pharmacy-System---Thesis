Public Class employeeUpdate
    Dim s As New cSQL
    Dim c As New cControl
    Private Sub EmployeeUpdate_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        populate()
        btnSave.Enabled = False
        grpEmpInfo.Enabled = False
        dtHiredate.Format = DateTimePickerFormat.Custom
        dtHiredate.CustomFormat = "MM/dd/yyyy"
        dgvEmployee.Columns(5).DefaultCellStyle.Format = "MM/dd/yyyy"
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        c.clrData(grpEmpInfo)
        grpEmpInfo.Enabled = False
        btnSave.Enabled = False
        populate()
    End Sub

    Private Sub hideID(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles dgvEmployee.DataBindingComplete
        With dgvEmployee
            .Columns("ID").Visible = False
            .Columns("Password").Visible = False
            dgvEmployee.ClearSelection()
        End With
    End Sub

    Private Sub dtgFocus(sender As Object, e As EventArgs) Handles dgvEmployee.CellClick
        point = dgvEmployee.CurrentRow.Index
        c.loadDataEmp(point, dgvEmployee, txtFname, txtLname, cmbSex, cmbPosition, dtHiredate, txtUser, txtPass)
        point = Nothing
        grpEmpInfo.Enabled = True
        btnSave.Enabled = True
        txtUser.Enabled = False
        'txtPass.Enabled = False
        Exit Sub
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        'getLoc
        point = dgvEmployee.CurrentRow.Index
        Dim passCount As Integer
        passCount = txtPass.Text.Length()

        If txtFname.Text = "" Then
            MsgBox("Please Fill In All Fields!", vbOKOnly, caption)
            txtFname.Select()
            SQLCon.Close()
            Exit Sub
        ElseIf txtLname.Text = "" Then
            MsgBox("Please Fill In All Fields!", vbOKOnly, caption)
            txtLname.Select()
            SQLCon.Close()
            Exit Sub
        ElseIf cmbSex.SelectedIndex = -1 Then
            MsgBox("ERROR! No Sex Selected or Item Does Not Exist on the List!", vbOKOnly, caption)
            cmbSex.Select()
            SQLCon.Close()
            Exit Sub
        ElseIf cmbPosition.SelectedIndex = -1 Then
            MsgBox("ERROR! No Position Selected or Item Does Not Exist on the List!", vbOKOnly, caption)
            cmbPosition.Select()
            SQLCon.Close()
            Exit Sub
        ElseIf dtHiredate.Value > Date.Now Then
            MsgBox("Invalid Input! Hiredate should not be greater than present date!", vbOKOnly, caption)
            dtHiredate.Select()
            SQLCon.Close()
            Exit Sub
        ElseIf txtUser.Text = "" Then
            MsgBox("Please Fill in All Fields!", vbOKOnly, caption)
            txtUser.Select()
            SQLCon.Close()
            Exit Sub
        ElseIf txtPass.Text = "" Or passCount < 8 Then
            MsgBox("ERROR! Password must be minimum of 8 characters!", vbOKOnly, caption)
            txtPass.Select()
            'btnAdd.Enabled = False
            SQLCon.Close()
            Exit Sub
        Else
            'getData
            id = dgvEmployee.Item(0, point).Value
            Convert.ToInt32(id)
            'empName = s.getName()
            empName = s.GetDetailStr("employeeView", "EmployeeName", "userName", username)
            fname = c.getData(txtFname).ToString.ToUpper
            lname = c.getData(txtLname).ToString.ToUpper
            sex = c.getData(cmbSex).ToString.ToUpper
            pos = c.getData(cmbPosition)
            hiredate = c.getData(dtHiredate)
            user = c.getData(txtUser)
            pass = c.getData(txtPass)
            updatedBy = empName

            s.updEmp(id, dgvEmployee, "employee", fname, lname, sex, pos, hiredate, user, pass, updatedBy, btnSave)
            grpEmpInfo.Enabled = False
            '   clear field
            c.clrData(grpEmpInfo)
            populate()
        End If
    End Sub

    Private Sub populate()
        dgvEmployee.ClearSelection()
        dgvEmployee.DataSource = Nothing

        'populate DTG

        s.loadCBX(cmbPosition, "empposition", "ID", "empPosName")
        s.loadCBX(cmbSex, "sex", "ID", "sexName")

        s.loadDTG(dgvEmployee, "viewemployee")
        dgvEmployee.Columns(5).DefaultCellStyle.Format = "MM/dd/yyyy"
    End Sub

    'Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
    '    s.searchEmployeeToUpdate("employee", dgvEmployee, txtSearch.Text)
    'End Sub
End Class