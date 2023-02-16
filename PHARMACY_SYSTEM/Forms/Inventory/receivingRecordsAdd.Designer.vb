<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class receivingRecordsAdd
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(receivingRecordsAdd))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.chkTimePeriod = New System.Windows.Forms.CheckBox()
        Me.panelDate = New System.Windows.Forms.Panel()
        Me.dateTo = New System.Windows.Forms.DateTimePicker()
        Me.dateFrom = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.grpPODetails = New System.Windows.Forms.GroupBox()
        Me.txtUnitCost = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtSellPrice = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.chkFree = New System.Windows.Forms.CheckBox()
        Me.txtRRQuantity = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.dateExpiry = New System.Windows.Forms.DateTimePicker()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.dgvPODetails = New System.Windows.Forms.DataGridView()
        Me.dgPOList = New System.Windows.Forms.DataGridView()
        Me.cmbSupplier = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.grpRR = New System.Windows.Forms.GroupBox()
        Me.innerRR = New System.Windows.Forms.GroupBox()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cmbReceivedBy = New System.Windows.Forms.ComboBox()
        Me.txtRRRemarks = New System.Windows.Forms.TextBox()
        Me.dateRR = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtRRNo = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btnRRSave = New System.Windows.Forms.Button()
        Me.dgvRRDetails = New System.Windows.Forms.DataGridView()
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.btnCheck = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.panelDate.SuspendLayout()
        Me.grpPODetails.SuspendLayout()
        CType(Me.dgvPODetails, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgPOList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpRR.SuspendLayout()
        Me.innerRR.SuspendLayout()
        CType(Me.dgvRRDetails, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'chkTimePeriod
        '
        Me.chkTimePeriod.AutoSize = True
        Me.chkTimePeriod.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkTimePeriod.Location = New System.Drawing.Point(12, 43)
        Me.chkTimePeriod.Name = "chkTimePeriod"
        Me.chkTimePeriod.Size = New System.Drawing.Size(82, 17)
        Me.chkTimePeriod.TabIndex = 20
        Me.chkTimePeriod.Text = "Date Period"
        Me.chkTimePeriod.UseVisualStyleBackColor = True
        '
        'panelDate
        '
        Me.panelDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelDate.Controls.Add(Me.dateTo)
        Me.panelDate.Controls.Add(Me.dateFrom)
        Me.panelDate.Controls.Add(Me.Label2)
        Me.panelDate.Controls.Add(Me.Label3)
        Me.panelDate.Location = New System.Drawing.Point(12, 66)
        Me.panelDate.Name = "panelDate"
        Me.panelDate.Size = New System.Drawing.Size(294, 72)
        Me.panelDate.TabIndex = 19
        '
        'dateTo
        '
        Me.dateTo.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dateTo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dateTo.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dateTo.Location = New System.Drawing.Point(87, 36)
        Me.dateTo.Name = "dateTo"
        Me.dateTo.Size = New System.Drawing.Size(150, 20)
        Me.dateTo.TabIndex = 17
        '
        'dateFrom
        '
        Me.dateFrom.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dateFrom.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dateFrom.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dateFrom.Location = New System.Drawing.Point(87, 10)
        Me.dateFrom.Name = "dateFrom"
        Me.dateFrom.Size = New System.Drawing.Size(150, 20)
        Me.dateFrom.TabIndex = 16
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(45, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(26, 13)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "To: "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(45, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(36, 13)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "From: "
        '
        'grpPODetails
        '
        Me.grpPODetails.Controls.Add(Me.txtUnitCost)
        Me.grpPODetails.Controls.Add(Me.Label13)
        Me.grpPODetails.Controls.Add(Me.txtSellPrice)
        Me.grpPODetails.Controls.Add(Me.Label12)
        Me.grpPODetails.Controls.Add(Me.chkFree)
        Me.grpPODetails.Controls.Add(Me.txtRRQuantity)
        Me.grpPODetails.Controls.Add(Me.Label7)
        Me.grpPODetails.Controls.Add(Me.dateExpiry)
        Me.grpPODetails.Controls.Add(Me.Label11)
        Me.grpPODetails.Controls.Add(Me.btnAdd)
        Me.grpPODetails.Controls.Add(Me.dgvPODetails)
        Me.grpPODetails.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpPODetails.Location = New System.Drawing.Point(319, 3)
        Me.grpPODetails.Name = "grpPODetails"
        Me.grpPODetails.Size = New System.Drawing.Size(712, 263)
        Me.grpPODetails.TabIndex = 13
        Me.grpPODetails.TabStop = False
        Me.grpPODetails.Text = "PO Details"
        '
        'txtUnitCost
        '
        Me.txtUnitCost.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUnitCost.Location = New System.Drawing.Point(144, 209)
        Me.txtUnitCost.Name = "txtUnitCost"
        Me.txtUnitCost.Size = New System.Drawing.Size(150, 20)
        Me.txtUnitCost.TabIndex = 39
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.SystemColors.Control
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(67, 214)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(56, 13)
        Me.Label13.TabIndex = 38
        Me.Label13.Text = "Unit Cost: "
        '
        'txtSellPrice
        '
        Me.txtSellPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSellPrice.Location = New System.Drawing.Point(419, 208)
        Me.txtSellPrice.Name = "txtSellPrice"
        Me.txtSellPrice.Size = New System.Drawing.Size(150, 20)
        Me.txtSellPrice.TabIndex = 37
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.SystemColors.Control
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(342, 213)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(71, 13)
        Me.Label12.TabIndex = 36
        Me.Label12.Text = "Selling Price: "
        '
        'chkFree
        '
        Me.chkFree.AutoSize = True
        Me.chkFree.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkFree.Location = New System.Drawing.Point(575, 183)
        Me.chkFree.Name = "chkFree"
        Me.chkFree.Size = New System.Drawing.Size(50, 17)
        Me.chkFree.TabIndex = 35
        Me.chkFree.Text = "Free "
        Me.chkFree.UseVisualStyleBackColor = True
        '
        'txtRRQuantity
        '
        Me.txtRRQuantity.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRRQuantity.Location = New System.Drawing.Point(419, 184)
        Me.txtRRQuantity.Name = "txtRRQuantity"
        Me.txtRRQuantity.Size = New System.Drawing.Size(150, 20)
        Me.txtRRQuantity.TabIndex = 34
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.SystemColors.Control
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(361, 187)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(52, 13)
        Me.Label7.TabIndex = 33
        Me.Label7.Text = "Quantity: "
        '
        'dateExpiry
        '
        Me.dateExpiry.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dateExpiry.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dateExpiry.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dateExpiry.Location = New System.Drawing.Point(144, 183)
        Me.dateExpiry.Name = "dateExpiry"
        Me.dateExpiry.Size = New System.Drawing.Size(150, 20)
        Me.dateExpiry.TabIndex = 32
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.SystemColors.Control
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(53, 189)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(85, 13)
        Me.Label11.TabIndex = 31
        Me.Label11.Text = "Expiration Date: "
        '
        'btnAdd
        '
        Me.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.Image = CType(resources.GetObject("btnAdd.Image"), System.Drawing.Image)
        Me.btnAdd.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnAdd.Location = New System.Drawing.Point(633, 202)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Padding = New System.Windows.Forms.Padding(0, 2, 0, 0)
        Me.btnAdd.Size = New System.Drawing.Size(70, 55)
        Me.btnAdd.TabIndex = 7
        Me.btnAdd.Text = "Add"
        Me.btnAdd.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'dgvPODetails
        '
        Me.dgvPODetails.AllowUserToResizeRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Gray
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvPODetails.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvPODetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvPODetails.Location = New System.Drawing.Point(5, 13)
        Me.dgvPODetails.MultiSelect = False
        Me.dgvPODetails.Name = "dgvPODetails"
        Me.dgvPODetails.ReadOnly = True
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Gray
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvPODetails.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvPODetails.RowHeadersVisible = False
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Gray
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White
        Me.dgvPODetails.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvPODetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvPODetails.Size = New System.Drawing.Size(701, 164)
        Me.dgvPODetails.TabIndex = 0
        '
        'dgPOList
        '
        Me.dgPOList.AllowUserToResizeRows = False
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Gray
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgPOList.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgPOList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgPOList.Location = New System.Drawing.Point(12, 218)
        Me.dgPOList.MultiSelect = False
        Me.dgPOList.Name = "dgPOList"
        Me.dgPOList.ReadOnly = True
        Me.dgPOList.RowHeadersVisible = False
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Gray
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White
        Me.dgPOList.RowsDefaultCellStyle = DataGridViewCellStyle5
        Me.dgPOList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgPOList.Size = New System.Drawing.Size(294, 411)
        Me.dgPOList.TabIndex = 12
        '
        'cmbSupplier
        '
        Me.cmbSupplier.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSupplier.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbSupplier.FormattingEnabled = True
        Me.cmbSupplier.Location = New System.Drawing.Point(66, 9)
        Me.cmbSupplier.Name = "cmbSupplier"
        Me.cmbSupplier.Size = New System.Drawing.Size(240, 21)
        Me.cmbSupplier.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Supplier: "
        '
        'grpRR
        '
        Me.grpRR.Controls.Add(Me.innerRR)
        Me.grpRR.Controls.Add(Me.Label10)
        Me.grpRR.Controls.Add(Me.btnRRSave)
        Me.grpRR.Controls.Add(Me.dgvRRDetails)
        Me.grpRR.Controls.Add(Me.btnRemove)
        Me.grpRR.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpRR.Location = New System.Drawing.Point(316, 266)
        Me.grpRR.Name = "grpRR"
        Me.grpRR.Size = New System.Drawing.Size(715, 369)
        Me.grpRR.TabIndex = 21
        Me.grpRR.TabStop = False
        Me.grpRR.Text = "RR"
        '
        'innerRR
        '
        Me.innerRR.Controls.Add(Me.btnUpdate)
        Me.innerRR.Controls.Add(Me.Label8)
        Me.innerRR.Controls.Add(Me.Label6)
        Me.innerRR.Controls.Add(Me.cmbReceivedBy)
        Me.innerRR.Controls.Add(Me.txtRRRemarks)
        Me.innerRR.Controls.Add(Me.dateRR)
        Me.innerRR.Controls.Add(Me.Label5)
        Me.innerRR.Controls.Add(Me.txtRRNo)
        Me.innerRR.Controls.Add(Me.Label4)
        Me.innerRR.Location = New System.Drawing.Point(6, 19)
        Me.innerRR.Name = "innerRR"
        Me.innerRR.Size = New System.Drawing.Size(709, 100)
        Me.innerRR.TabIndex = 44
        Me.innerRR.TabStop = False
        '
        'btnUpdate
        '
        Me.btnUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnUpdate.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnUpdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.Image = CType(resources.GetObject("btnUpdate.Image"), System.Drawing.Image)
        Me.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnUpdate.Location = New System.Drawing.Point(630, 45)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Padding = New System.Windows.Forms.Padding(0, 2, 0, 0)
        Me.btnUpdate.Size = New System.Drawing.Size(70, 55)
        Me.btnUpdate.TabIndex = 25
        Me.btnUpdate.Text = "Create"
        Me.btnUpdate.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.SystemColors.Control
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(83, 60)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(52, 13)
        Me.Label8.TabIndex = 24
        Me.Label8.Text = "Remarks:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.SystemColors.Control
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(65, 36)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(70, 13)
        Me.Label6.TabIndex = 23
        Me.Label6.Text = "Received by:"
        '
        'cmbReceivedBy
        '
        Me.cmbReceivedBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbReceivedBy.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbReceivedBy.FormattingEnabled = True
        Me.cmbReceivedBy.Location = New System.Drawing.Point(141, 33)
        Me.cmbReceivedBy.Name = "cmbReceivedBy"
        Me.cmbReceivedBy.Size = New System.Drawing.Size(425, 21)
        Me.cmbReceivedBy.TabIndex = 22
        '
        'txtRRRemarks
        '
        Me.txtRRRemarks.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRRRemarks.Location = New System.Drawing.Point(141, 60)
        Me.txtRRRemarks.Multiline = True
        Me.txtRRRemarks.Name = "txtRRRemarks"
        Me.txtRRRemarks.Size = New System.Drawing.Size(425, 40)
        Me.txtRRRemarks.TabIndex = 21
        '
        'dateRR
        '
        Me.dateRR.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dateRR.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dateRR.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dateRR.Location = New System.Drawing.Point(416, 4)
        Me.dateRR.Name = "dateRR"
        Me.dateRR.Size = New System.Drawing.Size(150, 20)
        Me.dateRR.TabIndex = 20
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.SystemColors.Control
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(374, 7)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(36, 13)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "Date: "
        '
        'txtRRNo
        '
        Me.txtRRNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRRNo.Location = New System.Drawing.Point(141, 7)
        Me.txtRRNo.Name = "txtRRNo"
        Me.txtRRNo.Size = New System.Drawing.Size(150, 20)
        Me.txtRRNo.TabIndex = 18
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.SystemColors.Control
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(89, 10)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 13)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "RR No: "
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(3, 122)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(68, 13)
        Me.Label10.TabIndex = 17
        Me.Label10.Text = "RR Details"
        '
        'btnRRSave
        '
        Me.btnRRSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRRSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRRSave.Image = CType(resources.GetObject("btnRRSave.Image"), System.Drawing.Image)
        Me.btnRRSave.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnRRSave.Location = New System.Drawing.Point(639, 308)
        Me.btnRRSave.Name = "btnRRSave"
        Me.btnRRSave.Padding = New System.Windows.Forms.Padding(0, 2, 0, 0)
        Me.btnRRSave.Size = New System.Drawing.Size(70, 55)
        Me.btnRRSave.TabIndex = 43
        Me.btnRRSave.Text = "Save"
        Me.btnRRSave.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnRRSave.UseVisualStyleBackColor = True
        '
        'dgvRRDetails
        '
        Me.dgvRRDetails.AllowUserToResizeRows = False
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Gray
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvRRDetails.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.dgvRRDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvRRDetails.Location = New System.Drawing.Point(6, 138)
        Me.dgvRRDetails.MultiSelect = False
        Me.dgvRRDetails.Name = "dgvRRDetails"
        Me.dgvRRDetails.ReadOnly = True
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.Gray
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvRRDetails.RowHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.dgvRRDetails.RowHeadersVisible = False
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.Gray
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White
        Me.dgvRRDetails.RowsDefaultCellStyle = DataGridViewCellStyle8
        Me.dgvRRDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvRRDetails.Size = New System.Drawing.Size(703, 164)
        Me.dgvRRDetails.TabIndex = 1
        '
        'btnRemove
        '
        Me.btnRemove.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRemove.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRemove.Image = CType(resources.GetObject("btnRemove.Image"), System.Drawing.Image)
        Me.btnRemove.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnRemove.Location = New System.Drawing.Point(6, 308)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Padding = New System.Windows.Forms.Padding(0, 2, 0, 0)
        Me.btnRemove.Size = New System.Drawing.Size(70, 55)
        Me.btnRemove.TabIndex = 42
        Me.btnRemove.Text = "Remove"
        Me.btnRemove.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnRemove.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.SystemColors.Control
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(12, 202)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(48, 13)
        Me.Label9.TabIndex = 44
        Me.Label9.Text = "PO List"
        '
        'btnRefresh
        '
        Me.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRefresh.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRefresh.Image = CType(resources.GetObject("btnRefresh.Image"), System.Drawing.Image)
        Me.btnRefresh.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnRefresh.Location = New System.Drawing.Point(12, 144)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Padding = New System.Windows.Forms.Padding(0, 2, 0, 0)
        Me.btnRefresh.Size = New System.Drawing.Size(70, 55)
        Me.btnRefresh.TabIndex = 46
        Me.btnRefresh.Text = "Refresh"
        Me.btnRefresh.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'btnCheck
        '
        Me.btnCheck.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCheck.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCheck.Image = CType(resources.GetObject("btnCheck.Image"), System.Drawing.Image)
        Me.btnCheck.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnCheck.Location = New System.Drawing.Point(236, 144)
        Me.btnCheck.Name = "btnCheck"
        Me.btnCheck.Padding = New System.Windows.Forms.Padding(0, 2, 0, 0)
        Me.btnCheck.Size = New System.Drawing.Size(70, 55)
        Me.btnCheck.TabIndex = 45
        Me.btnCheck.Text = "Go"
        Me.btnCheck.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnCheck.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.DodgerBlue
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(0, 676)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1034, 25)
        Me.Panel3.TabIndex = 47
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Control
        Me.Panel1.Controls.Add(Me.grpRR)
        Me.Panel1.Controls.Add(Me.btnRefresh)
        Me.Panel1.Controls.Add(Me.grpPODetails)
        Me.Panel1.Controls.Add(Me.chkTimePeriod)
        Me.Panel1.Controls.Add(Me.dgPOList)
        Me.Panel1.Controls.Add(Me.panelDate)
        Me.Panel1.Controls.Add(Me.btnCheck)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.cmbSupplier)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(0, 31)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1034, 639)
        Me.Panel1.TabIndex = 48
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.DodgerBlue
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1034, 25)
        Me.Panel2.TabIndex = 49
        '
        'receivingRecordsAdd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.ClientSize = New System.Drawing.Size(1034, 701)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "receivingRecordsAdd"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "New Receiving Report"
        Me.panelDate.ResumeLayout(False)
        Me.panelDate.PerformLayout()
        Me.grpPODetails.ResumeLayout(False)
        Me.grpPODetails.PerformLayout()
        CType(Me.dgvPODetails, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgPOList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpRR.ResumeLayout(False)
        Me.grpRR.PerformLayout()
        Me.innerRR.ResumeLayout(False)
        Me.innerRR.PerformLayout()
        CType(Me.dgvRRDetails, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents chkTimePeriod As CheckBox
    Friend WithEvents panelDate As Panel
    Friend WithEvents dateTo As DateTimePicker
    Friend WithEvents dateFrom As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents grpPODetails As GroupBox
    Friend WithEvents dgvPODetails As DataGridView
    Friend WithEvents dgPOList As DataGridView
    Friend WithEvents cmbSupplier As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnAdd As Button
    Friend WithEvents dateExpiry As DateTimePicker
    Friend WithEvents Label11 As Label
    Friend WithEvents txtRRQuantity As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents grpRR As GroupBox
    Friend WithEvents dgvRRDetails As DataGridView
    Friend WithEvents btnRRSave As Button
    Friend WithEvents btnRemove As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents btnRefresh As Button
    Friend WithEvents btnCheck As Button
    Friend WithEvents innerRR As GroupBox
    Friend WithEvents btnUpdate As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents cmbReceivedBy As ComboBox
    Friend WithEvents txtRRRemarks As TextBox
    Friend WithEvents dateRR As DateTimePicker
    Friend WithEvents Label5 As Label
    Friend WithEvents txtRRNo As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents chkFree As CheckBox
    Friend WithEvents txtSellPrice As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents txtUnitCost As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
End Class
