<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class paymentAdd
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(paymentAdd))
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.cmbPaySupplier = New System.Windows.Forms.ComboBox()
        Me.Label84 = New System.Windows.Forms.Label()
        Me.txtPaymentNo = New System.Windows.Forms.TextBox()
        Me.Label83 = New System.Windows.Forms.Label()
        Me.grpRRDetails = New System.Windows.Forms.GroupBox()
        Me.dgvRRDetails = New System.Windows.Forms.DataGridView()
        Me.txtTotalBal = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnCreate = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.Panel11 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmbBankDep = New System.Windows.Forms.ComboBox()
        Me.Label76 = New System.Windows.Forms.Label()
        Me.txtBankDep = New System.Windows.Forms.TextBox()
        Me.Label77 = New System.Windows.Forms.Label()
        Me.dateBankDep = New System.Windows.Forms.DateTimePicker()
        Me.txtDepNo = New System.Windows.Forms.TextBox()
        Me.Label78 = New System.Windows.Forms.Label()
        Me.chkBankDep = New System.Windows.Forms.CheckBox()
        Me.Panel12 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dateCheque = New System.Windows.Forms.DateTimePicker()
        Me.Label79 = New System.Windows.Forms.Label()
        Me.txtChequeAmount = New System.Windows.Forms.TextBox()
        Me.Label80 = New System.Windows.Forms.Label()
        Me.txtChequeNo = New System.Windows.Forms.TextBox()
        Me.Label81 = New System.Windows.Forms.Label()
        Me.cmbChequeBank = New System.Windows.Forms.ComboBox()
        Me.chkCheque = New System.Windows.Forms.CheckBox()
        Me.Panel13 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtCashAmount = New System.Windows.Forms.TextBox()
        Me.Label82 = New System.Windows.Forms.Label()
        Me.dateCash = New System.Windows.Forms.DateTimePicker()
        Me.chkCash = New System.Windows.Forms.CheckBox()
        Me.btnPaymentSave = New System.Windows.Forms.Button()
        Me.grpMOP = New System.Windows.Forms.GroupBox()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.btnViewPayables = New System.Windows.Forms.Button()
        Me.grpPayments = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtTotalAmount = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnRemoveAll = New System.Windows.Forms.Button()
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.dgvPaymentDetails = New System.Windows.Forms.DataGridView()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.grpRRDetails.SuspendLayout()
        CType(Me.dgvRRDetails, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel11.SuspendLayout()
        Me.Panel12.SuspendLayout()
        Me.Panel13.SuspendLayout()
        Me.grpMOP.SuspendLayout()
        Me.grpPayments.SuspendLayout()
        CType(Me.dgvPaymentDetails, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmbPaySupplier
        '
        Me.cmbPaySupplier.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPaySupplier.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbPaySupplier.FormattingEnabled = True
        Me.cmbPaySupplier.Location = New System.Drawing.Point(64, 13)
        Me.cmbPaySupplier.Name = "cmbPaySupplier"
        Me.cmbPaySupplier.Size = New System.Drawing.Size(240, 21)
        Me.cmbPaySupplier.TabIndex = 13
        '
        'Label84
        '
        Me.Label84.AutoSize = True
        Me.Label84.BackColor = System.Drawing.SystemColors.Control
        Me.Label84.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label84.Location = New System.Drawing.Point(7, 16)
        Me.Label84.Name = "Label84"
        Me.Label84.Size = New System.Drawing.Size(51, 13)
        Me.Label84.TabIndex = 12
        Me.Label84.Text = "Supplier: "
        '
        'txtPaymentNo
        '
        Me.txtPaymentNo.Enabled = False
        Me.txtPaymentNo.Location = New System.Drawing.Point(86, 20)
        Me.txtPaymentNo.Name = "txtPaymentNo"
        Me.txtPaymentNo.Size = New System.Drawing.Size(150, 20)
        Me.txtPaymentNo.TabIndex = 36
        '
        'Label83
        '
        Me.Label83.AutoSize = True
        Me.Label83.BackColor = System.Drawing.SystemColors.Control
        Me.Label83.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label83.Location = New System.Drawing.Point(6, 23)
        Me.Label83.Name = "Label83"
        Me.Label83.Size = New System.Drawing.Size(74, 13)
        Me.Label83.TabIndex = 35
        Me.Label83.Text = "Payment No.: "
        '
        'grpRRDetails
        '
        Me.grpRRDetails.Controls.Add(Me.dgvRRDetails)
        Me.grpRRDetails.Controls.Add(Me.txtTotalBal)
        Me.grpRRDetails.Controls.Add(Me.Label1)
        Me.grpRRDetails.Controls.Add(Me.btnCreate)
        Me.grpRRDetails.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpRRDetails.Location = New System.Drawing.Point(6, 65)
        Me.grpRRDetails.Name = "grpRRDetails"
        Me.grpRRDetails.Size = New System.Drawing.Size(524, 248)
        Me.grpRRDetails.TabIndex = 41
        Me.grpRRDetails.TabStop = False
        Me.grpRRDetails.Text = "RR Details"
        '
        'dgvRRDetails
        '
        Me.dgvRRDetails.AllowUserToResizeRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Gray
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvRRDetails.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvRRDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvRRDetails.Location = New System.Drawing.Point(6, 16)
        Me.dgvRRDetails.MultiSelect = False
        Me.dgvRRDetails.Name = "dgvRRDetails"
        Me.dgvRRDetails.ReadOnly = True
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Gray
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvRRDetails.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvRRDetails.RowHeadersVisible = False
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Gray
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White
        Me.dgvRRDetails.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvRRDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvRRDetails.Size = New System.Drawing.Size(515, 162)
        Me.dgvRRDetails.TabIndex = 0
        '
        'txtTotalBal
        '
        Me.txtTotalBal.Enabled = False
        Me.txtTotalBal.Location = New System.Drawing.Point(368, 185)
        Me.txtTotalBal.Name = "txtTotalBal"
        Me.txtTotalBal.Size = New System.Drawing.Size(150, 20)
        Me.txtTotalBal.TabIndex = 43
        Me.txtTotalBal.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(280, 188)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 13)
        Me.Label1.TabIndex = 42
        Me.Label1.Text = "Total Balance.: "
        Me.Label1.Visible = False
        '
        'btnCreate
        '
        Me.btnCreate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnCreate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCreate.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnCreate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCreate.Image = CType(resources.GetObject("btnCreate.Image"), System.Drawing.Image)
        Me.btnCreate.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnCreate.Location = New System.Drawing.Point(6, 184)
        Me.btnCreate.Name = "btnCreate"
        Me.btnCreate.Padding = New System.Windows.Forms.Padding(0, 2, 0, 0)
        Me.btnCreate.Size = New System.Drawing.Size(70, 55)
        Me.btnCreate.TabIndex = 40
        Me.btnCreate.Text = "Create"
        Me.btnCreate.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnCreate.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.Image = CType(resources.GetObject("btnAdd.Image"), System.Drawing.Image)
        Me.btnAdd.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnAdd.Location = New System.Drawing.Point(172, 19)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Padding = New System.Windows.Forms.Padding(0, 2, 0, 0)
        Me.btnAdd.Size = New System.Drawing.Size(70, 55)
        Me.btnAdd.TabIndex = 44
        Me.btnAdd.Text = "Add"
        Me.btnAdd.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'Panel11
        '
        Me.Panel11.BackColor = System.Drawing.Color.LightGray
        Me.Panel11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel11.Controls.Add(Me.Label4)
        Me.Panel11.Controls.Add(Me.cmbBankDep)
        Me.Panel11.Controls.Add(Me.Label76)
        Me.Panel11.Controls.Add(Me.txtBankDep)
        Me.Panel11.Controls.Add(Me.Label77)
        Me.Panel11.Controls.Add(Me.dateBankDep)
        Me.Panel11.Controls.Add(Me.txtDepNo)
        Me.Panel11.Controls.Add(Me.Label78)
        Me.Panel11.Enabled = False
        Me.Panel11.Location = New System.Drawing.Point(6, 368)
        Me.Panel11.Name = "Panel11"
        Me.Panel11.Size = New System.Drawing.Size(236, 123)
        Me.Panel11.TabIndex = 46
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.SystemColors.Control
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(10, 13)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 13)
        Me.Label4.TabIndex = 32
        Me.Label4.Text = "Amount: "
        '
        'cmbBankDep
        '
        Me.cmbBankDep.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbBankDep.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbBankDep.FormattingEnabled = True
        Me.cmbBankDep.Location = New System.Drawing.Point(88, 88)
        Me.cmbBankDep.Name = "cmbBankDep"
        Me.cmbBankDep.Size = New System.Drawing.Size(135, 21)
        Me.cmbBankDep.TabIndex = 24
        '
        'Label76
        '
        Me.Label76.AutoSize = True
        Me.Label76.BackColor = System.Drawing.Color.Azure
        Me.Label76.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label76.Location = New System.Drawing.Point(10, 91)
        Me.Label76.Name = "Label76"
        Me.Label76.Size = New System.Drawing.Size(38, 13)
        Me.Label76.TabIndex = 28
        Me.Label76.Text = "Bank: "
        '
        'txtBankDep
        '
        Me.txtBankDep.Location = New System.Drawing.Point(88, 10)
        Me.txtBankDep.Name = "txtBankDep"
        Me.txtBankDep.Size = New System.Drawing.Size(135, 20)
        Me.txtBankDep.TabIndex = 19
        '
        'Label77
        '
        Me.Label77.AutoSize = True
        Me.Label77.BackColor = System.Drawing.SystemColors.Control
        Me.Label77.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label77.Location = New System.Drawing.Point(10, 39)
        Me.Label77.Name = "Label77"
        Me.Label77.Size = New System.Drawing.Size(69, 13)
        Me.Label77.TabIndex = 24
        Me.Label77.Text = "Deposit No.: "
        '
        'dateBankDep
        '
        Me.dateBankDep.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dateBankDep.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dateBankDep.Location = New System.Drawing.Point(88, 62)
        Me.dateBankDep.Name = "dateBankDep"
        Me.dateBankDep.Size = New System.Drawing.Size(135, 20)
        Me.dateBankDep.TabIndex = 27
        '
        'txtDepNo
        '
        Me.txtDepNo.Location = New System.Drawing.Point(88, 36)
        Me.txtDepNo.Name = "txtDepNo"
        Me.txtDepNo.Size = New System.Drawing.Size(135, 20)
        Me.txtDepNo.TabIndex = 25
        '
        'Label78
        '
        Me.Label78.AutoSize = True
        Me.Label78.BackColor = System.Drawing.SystemColors.Control
        Me.Label78.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label78.Location = New System.Drawing.Point(10, 68)
        Me.Label78.Name = "Label78"
        Me.Label78.Size = New System.Drawing.Size(36, 13)
        Me.Label78.TabIndex = 26
        Me.Label78.Text = "Date: "
        '
        'chkBankDep
        '
        Me.chkBankDep.AutoSize = True
        Me.chkBankDep.BackColor = System.Drawing.SystemColors.Control
        Me.chkBankDep.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkBankDep.Location = New System.Drawing.Point(6, 345)
        Me.chkBankDep.Name = "chkBankDep"
        Me.chkBankDep.Size = New System.Drawing.Size(90, 17)
        Me.chkBankDep.TabIndex = 16
        Me.chkBankDep.Text = "Bank Deposit"
        Me.chkBankDep.UseVisualStyleBackColor = False
        '
        'Panel12
        '
        Me.Panel12.BackColor = System.Drawing.Color.LightGray
        Me.Panel12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel12.Controls.Add(Me.Label2)
        Me.Panel12.Controls.Add(Me.dateCheque)
        Me.Panel12.Controls.Add(Me.Label79)
        Me.Panel12.Controls.Add(Me.txtChequeAmount)
        Me.Panel12.Controls.Add(Me.Label80)
        Me.Panel12.Controls.Add(Me.txtChequeNo)
        Me.Panel12.Controls.Add(Me.Label81)
        Me.Panel12.Controls.Add(Me.cmbChequeBank)
        Me.Panel12.Enabled = False
        Me.Panel12.Location = New System.Drawing.Point(6, 199)
        Me.Panel12.Name = "Panel12"
        Me.Panel12.Size = New System.Drawing.Size(236, 122)
        Me.Panel12.TabIndex = 45
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(10, 14)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 13)
        Me.Label2.TabIndex = 30
        Me.Label2.Text = "Amount: "
        '
        'dateCheque
        '
        Me.dateCheque.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dateCheque.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dateCheque.Location = New System.Drawing.Point(88, 63)
        Me.dateCheque.Name = "dateCheque"
        Me.dateCheque.Size = New System.Drawing.Size(135, 20)
        Me.dateCheque.TabIndex = 29
        '
        'Label79
        '
        Me.Label79.AutoSize = True
        Me.Label79.BackColor = System.Drawing.SystemColors.Control
        Me.Label79.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label79.Location = New System.Drawing.Point(10, 70)
        Me.Label79.Name = "Label79"
        Me.Label79.Size = New System.Drawing.Size(36, 13)
        Me.Label79.TabIndex = 29
        Me.Label79.Text = "Date: "
        '
        'txtChequeAmount
        '
        Me.txtChequeAmount.Location = New System.Drawing.Point(88, 11)
        Me.txtChequeAmount.Name = "txtChequeAmount"
        Me.txtChequeAmount.Size = New System.Drawing.Size(135, 20)
        Me.txtChequeAmount.TabIndex = 18
        '
        'Label80
        '
        Me.Label80.AutoSize = True
        Me.Label80.BackColor = System.Drawing.SystemColors.Control
        Me.Label80.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label80.Location = New System.Drawing.Point(10, 40)
        Me.Label80.Name = "Label80"
        Me.Label80.Size = New System.Drawing.Size(70, 13)
        Me.Label80.TabIndex = 20
        Me.Label80.Text = "Cheque No.: "
        '
        'txtChequeNo
        '
        Me.txtChequeNo.Location = New System.Drawing.Point(88, 37)
        Me.txtChequeNo.Name = "txtChequeNo"
        Me.txtChequeNo.Size = New System.Drawing.Size(135, 20)
        Me.txtChequeNo.TabIndex = 21
        '
        'Label81
        '
        Me.Label81.AutoSize = True
        Me.Label81.BackColor = System.Drawing.SystemColors.Control
        Me.Label81.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label81.Location = New System.Drawing.Point(8, 92)
        Me.Label81.Name = "Label81"
        Me.Label81.Size = New System.Drawing.Size(38, 13)
        Me.Label81.TabIndex = 22
        Me.Label81.Text = "Bank: "
        '
        'cmbChequeBank
        '
        Me.cmbChequeBank.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbChequeBank.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbChequeBank.FormattingEnabled = True
        Me.cmbChequeBank.Location = New System.Drawing.Point(88, 89)
        Me.cmbChequeBank.Name = "cmbChequeBank"
        Me.cmbChequeBank.Size = New System.Drawing.Size(135, 21)
        Me.cmbChequeBank.TabIndex = 23
        '
        'chkCheque
        '
        Me.chkCheque.AutoSize = True
        Me.chkCheque.BackColor = System.Drawing.SystemColors.Control
        Me.chkCheque.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkCheque.Location = New System.Drawing.Point(3, 176)
        Me.chkCheque.Name = "chkCheque"
        Me.chkCheque.Size = New System.Drawing.Size(63, 17)
        Me.chkCheque.TabIndex = 15
        Me.chkCheque.Text = "Cheque"
        Me.chkCheque.UseVisualStyleBackColor = False
        '
        'Panel13
        '
        Me.Panel13.BackColor = System.Drawing.Color.LightGray
        Me.Panel13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel13.Controls.Add(Me.Label3)
        Me.Panel13.Controls.Add(Me.txtCashAmount)
        Me.Panel13.Controls.Add(Me.Label82)
        Me.Panel13.Controls.Add(Me.dateCash)
        Me.Panel13.Enabled = False
        Me.Panel13.Location = New System.Drawing.Point(6, 81)
        Me.Panel13.Name = "Panel13"
        Me.Panel13.Size = New System.Drawing.Size(236, 73)
        Me.Panel13.TabIndex = 44
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.Control
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(10, 13)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 13)
        Me.Label3.TabIndex = 31
        Me.Label3.Text = "Amount: "
        '
        'txtCashAmount
        '
        Me.txtCashAmount.Location = New System.Drawing.Point(88, 10)
        Me.txtCashAmount.Name = "txtCashAmount"
        Me.txtCashAmount.Size = New System.Drawing.Size(135, 20)
        Me.txtCashAmount.TabIndex = 17
        '
        'Label82
        '
        Me.Label82.AutoSize = True
        Me.Label82.BackColor = System.Drawing.SystemColors.Control
        Me.Label82.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label82.Location = New System.Drawing.Point(10, 42)
        Me.Label82.Name = "Label82"
        Me.Label82.Size = New System.Drawing.Size(36, 13)
        Me.Label82.TabIndex = 13
        Me.Label82.Text = "Date: "
        '
        'dateCash
        '
        Me.dateCash.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dateCash.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dateCash.Location = New System.Drawing.Point(88, 36)
        Me.dateCash.Name = "dateCash"
        Me.dateCash.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.dateCash.Size = New System.Drawing.Size(135, 20)
        Me.dateCash.TabIndex = 28
        '
        'chkCash
        '
        Me.chkCash.AutoSize = True
        Me.chkCash.BackColor = System.Drawing.SystemColors.Control
        Me.chkCash.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkCash.Location = New System.Drawing.Point(6, 58)
        Me.chkCash.Name = "chkCash"
        Me.chkCash.Size = New System.Drawing.Size(50, 17)
        Me.chkCash.TabIndex = 14
        Me.chkCash.Text = "Cash"
        Me.chkCash.UseVisualStyleBackColor = False
        '
        'btnPaymentSave
        '
        Me.btnPaymentSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPaymentSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPaymentSave.Image = CType(resources.GetObject("btnPaymentSave.Image"), System.Drawing.Image)
        Me.btnPaymentSave.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnPaymentSave.Location = New System.Drawing.Point(705, 520)
        Me.btnPaymentSave.Name = "btnPaymentSave"
        Me.btnPaymentSave.Padding = New System.Windows.Forms.Padding(0, 2, 0, 0)
        Me.btnPaymentSave.Size = New System.Drawing.Size(70, 55)
        Me.btnPaymentSave.TabIndex = 56
        Me.btnPaymentSave.Text = "Save"
        Me.btnPaymentSave.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnPaymentSave.UseVisualStyleBackColor = True
        '
        'grpMOP
        '
        Me.grpMOP.Controls.Add(Me.chkCash)
        Me.grpMOP.Controls.Add(Me.btnAdd)
        Me.grpMOP.Controls.Add(Me.Panel13)
        Me.grpMOP.Controls.Add(Me.chkCheque)
        Me.grpMOP.Controls.Add(Me.chkBankDep)
        Me.grpMOP.Controls.Add(Me.Panel12)
        Me.grpMOP.Controls.Add(Me.Panel11)
        Me.grpMOP.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpMOP.Location = New System.Drawing.Point(533, 3)
        Me.grpMOP.Name = "grpMOP"
        Me.grpMOP.Size = New System.Drawing.Size(248, 502)
        Me.grpMOP.TabIndex = 58
        Me.grpMOP.TabStop = False
        Me.grpMOP.Text = "Mode of Payment"
        '
        'btnRefresh
        '
        Me.btnRefresh.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRefresh.Image = CType(resources.GetObject("btnRefresh.Image"), System.Drawing.Image)
        Me.btnRefresh.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnRefresh.Location = New System.Drawing.Point(539, 520)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Padding = New System.Windows.Forms.Padding(0, 2, 0, 0)
        Me.btnRefresh.Size = New System.Drawing.Size(70, 55)
        Me.btnRefresh.TabIndex = 47
        Me.btnRefresh.Text = "Refresh"
        Me.btnRefresh.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'btnViewPayables
        '
        Me.btnViewPayables.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnViewPayables.Image = CType(resources.GetObject("btnViewPayables.Image"), System.Drawing.Image)
        Me.btnViewPayables.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnViewPayables.Location = New System.Drawing.Point(356, 13)
        Me.btnViewPayables.Name = "btnViewPayables"
        Me.btnViewPayables.Size = New System.Drawing.Size(137, 50)
        Me.btnViewPayables.TabIndex = 59
        Me.btnViewPayables.Text = "View Payables"
        Me.btnViewPayables.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnViewPayables.UseVisualStyleBackColor = True
        '
        'grpPayments
        '
        Me.grpPayments.Controls.Add(Me.Label7)
        Me.grpPayments.Controls.Add(Me.txtTotalAmount)
        Me.grpPayments.Controls.Add(Me.Label6)
        Me.grpPayments.Controls.Add(Me.btnRemoveAll)
        Me.grpPayments.Controls.Add(Me.btnRemove)
        Me.grpPayments.Controls.Add(Me.dgvPaymentDetails)
        Me.grpPayments.Controls.Add(Me.Label83)
        Me.grpPayments.Controls.Add(Me.txtPaymentNo)
        Me.grpPayments.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpPayments.Location = New System.Drawing.Point(6, 314)
        Me.grpPayments.Name = "grpPayments"
        Me.grpPayments.Size = New System.Drawing.Size(524, 272)
        Me.grpPayments.TabIndex = 60
        Me.grpPayments.TabStop = False
        Me.grpPayments.Text = "Payment Details"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.SystemColors.Control
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(283, 248)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(79, 13)
        Me.Label7.TabIndex = 45
        Me.Label7.Text = "Total Amount.: "
        '
        'txtTotalAmount
        '
        Me.txtTotalAmount.Enabled = False
        Me.txtTotalAmount.Location = New System.Drawing.Point(368, 245)
        Me.txtTotalAmount.Name = "txtTotalAmount"
        Me.txtTotalAmount.Size = New System.Drawing.Size(150, 20)
        Me.txtTotalAmount.TabIndex = 44
        Me.txtTotalAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(3, 61)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(96, 13)
        Me.Label6.TabIndex = 41
        Me.Label6.Text = "Payments Made"
        '
        'btnRemoveAll
        '
        Me.btnRemoveAll.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnRemoveAll.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRemoveAll.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnRemoveAll.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRemoveAll.Image = CType(resources.GetObject("btnRemoveAll.Image"), System.Drawing.Image)
        Me.btnRemoveAll.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnRemoveAll.Location = New System.Drawing.Point(448, 10)
        Me.btnRemoveAll.Name = "btnRemoveAll"
        Me.btnRemoveAll.Padding = New System.Windows.Forms.Padding(0, 2, 0, 0)
        Me.btnRemoveAll.Size = New System.Drawing.Size(70, 55)
        Me.btnRemoveAll.TabIndex = 39
        Me.btnRemoveAll.Text = "Remove All"
        Me.btnRemoveAll.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnRemoveAll.UseVisualStyleBackColor = True
        '
        'btnRemove
        '
        Me.btnRemove.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnRemove.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRemove.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnRemove.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRemove.Image = CType(resources.GetObject("btnRemove.Image"), System.Drawing.Image)
        Me.btnRemove.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnRemove.Location = New System.Drawing.Point(372, 10)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(70, 55)
        Me.btnRemove.TabIndex = 38
        Me.btnRemove.Text = "Remove"
        Me.btnRemove.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnRemove.UseVisualStyleBackColor = True
        '
        'dgvPaymentDetails
        '
        Me.dgvPaymentDetails.AllowUserToResizeRows = False
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Gray
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvPaymentDetails.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvPaymentDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Gray
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvPaymentDetails.DefaultCellStyle = DataGridViewCellStyle5
        Me.dgvPaymentDetails.Location = New System.Drawing.Point(6, 77)
        Me.dgvPaymentDetails.MultiSelect = False
        Me.dgvPaymentDetails.Name = "dgvPaymentDetails"
        Me.dgvPaymentDetails.ReadOnly = True
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Gray
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvPaymentDetails.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.dgvPaymentDetails.RowHeadersVisible = False
        Me.dgvPaymentDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvPaymentDetails.Size = New System.Drawing.Size(515, 162)
        Me.dgvPaymentDetails.TabIndex = 37
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.DodgerBlue
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(0, 626)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(784, 25)
        Me.Panel3.TabIndex = 61
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Control
        Me.Panel1.Controls.Add(Me.btnRefresh)
        Me.Panel1.Controls.Add(Me.grpPayments)
        Me.Panel1.Controls.Add(Me.grpRRDetails)
        Me.Panel1.Controls.Add(Me.btnViewPayables)
        Me.Panel1.Controls.Add(Me.btnPaymentSave)
        Me.Panel1.Controls.Add(Me.grpMOP)
        Me.Panel1.Controls.Add(Me.cmbPaySupplier)
        Me.Panel1.Controls.Add(Me.Label84)
        Me.Panel1.Location = New System.Drawing.Point(0, 31)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(784, 589)
        Me.Panel1.TabIndex = 62
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.DodgerBlue
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(784, 25)
        Me.Panel2.TabIndex = 63
        '
        'paymentAdd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.ClientSize = New System.Drawing.Size(784, 651)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "paymentAdd"
        Me.Text = "New Payment Record"
        Me.grpRRDetails.ResumeLayout(False)
        Me.grpRRDetails.PerformLayout()
        CType(Me.dgvRRDetails, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel11.ResumeLayout(False)
        Me.Panel11.PerformLayout()
        Me.Panel12.ResumeLayout(False)
        Me.Panel12.PerformLayout()
        Me.Panel13.ResumeLayout(False)
        Me.Panel13.PerformLayout()
        Me.grpMOP.ResumeLayout(False)
        Me.grpMOP.PerformLayout()
        Me.grpPayments.ResumeLayout(False)
        Me.grpPayments.PerformLayout()
        CType(Me.dgvPaymentDetails, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents cmbPaySupplier As ComboBox
    Friend WithEvents Label84 As Label
    Friend WithEvents txtPaymentNo As TextBox
    Friend WithEvents Label83 As Label
    Friend WithEvents grpRRDetails As GroupBox
    Friend WithEvents dgvRRDetails As DataGridView
    Friend WithEvents txtTotalBal As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel11 As Panel
    Friend WithEvents cmbBankDep As ComboBox
    Friend WithEvents Label76 As Label
    Friend WithEvents chkBankDep As CheckBox
    Friend WithEvents txtBankDep As TextBox
    Friend WithEvents Label77 As Label
    Friend WithEvents dateBankDep As DateTimePicker
    Friend WithEvents txtDepNo As TextBox
    Friend WithEvents Label78 As Label
    Friend WithEvents Panel12 As Panel
    Friend WithEvents dateCheque As DateTimePicker
    Friend WithEvents Label79 As Label
    Friend WithEvents chkCheque As CheckBox
    Friend WithEvents txtChequeAmount As TextBox
    Friend WithEvents Label80 As Label
    Friend WithEvents txtChequeNo As TextBox
    Friend WithEvents Label81 As Label
    Friend WithEvents cmbChequeBank As ComboBox
    Friend WithEvents Panel13 As Panel
    Friend WithEvents chkCash As CheckBox
    Friend WithEvents txtCashAmount As TextBox
    Friend WithEvents Label82 As Label
    Friend WithEvents dateCash As DateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnPaymentSave As Button
    Friend WithEvents grpMOP As GroupBox
    Friend WithEvents btnViewPayables As Button
    Friend WithEvents grpPayments As GroupBox
    Friend WithEvents dgvPaymentDetails As DataGridView
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnRemoveAll As Button
    Friend WithEvents btnRemove As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents txtTotalAmount As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents btnCreate As Button
    Friend WithEvents btnRefresh As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
End Class
