<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class purchaseReturnAdd
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(purchaseReturnAdd))
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.chkTimePeriod = New System.Windows.Forms.CheckBox()
        Me.panelDate = New System.Windows.Forms.Panel()
        Me.dateTo = New System.Windows.Forms.DateTimePicker()
        Me.dateFrom = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmbSupplier = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.dgvRRList = New System.Windows.Forms.DataGridView()
        Me.grpRRDetails = New System.Windows.Forms.GroupBox()
        Me.cmbReason = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtReturnQuantity = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.dgvRRDetails = New System.Windows.Forms.DataGridView()
        Me.grpReturn = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.dgvReturnDetails = New System.Windows.Forms.DataGridView()
        Me.btnCreate = New System.Windows.Forms.Button()
        Me.btnReturnSave = New System.Windows.Forms.Button()
        Me.dateReturn = New System.Windows.Forms.DateTimePicker()
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtReturnNo = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.btnCheck = New System.Windows.Forms.Button()
        Me.panelDate.SuspendLayout()
        CType(Me.dgvRRList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpRRDetails.SuspendLayout()
        CType(Me.dgvRRDetails, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpReturn.SuspendLayout()
        CType(Me.dgvReturnDetails, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'chkTimePeriod
        '
        Me.chkTimePeriod.AutoSize = True
        Me.chkTimePeriod.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkTimePeriod.Location = New System.Drawing.Point(12, 33)
        Me.chkTimePeriod.Name = "chkTimePeriod"
        Me.chkTimePeriod.Size = New System.Drawing.Size(82, 17)
        Me.chkTimePeriod.TabIndex = 24
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
        Me.panelDate.Location = New System.Drawing.Point(12, 56)
        Me.panelDate.Name = "panelDate"
        Me.panelDate.Size = New System.Drawing.Size(294, 72)
        Me.panelDate.TabIndex = 23
        '
        'dateTo
        '
        Me.dateTo.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dateTo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dateTo.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dateTo.Location = New System.Drawing.Point(82, 36)
        Me.dateTo.Name = "dateTo"
        Me.dateTo.Size = New System.Drawing.Size(150, 20)
        Me.dateTo.TabIndex = 17
        '
        'dateFrom
        '
        Me.dateFrom.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dateFrom.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dateFrom.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dateFrom.Location = New System.Drawing.Point(82, 9)
        Me.dateFrom.Name = "dateFrom"
        Me.dateFrom.Size = New System.Drawing.Size(150, 20)
        Me.dateFrom.TabIndex = 16
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(40, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(26, 13)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "To: "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(40, 15)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(36, 13)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "From: "
        '
        'cmbSupplier
        '
        Me.cmbSupplier.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSupplier.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbSupplier.FormattingEnabled = True
        Me.cmbSupplier.Location = New System.Drawing.Point(66, 6)
        Me.cmbSupplier.Name = "cmbSupplier"
        Me.cmbSupplier.Size = New System.Drawing.Size(240, 21)
        Me.cmbSupplier.TabIndex = 22
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(9, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 13)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "Supplier: "
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.SystemColors.Control
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(12, 194)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(49, 13)
        Me.Label9.TabIndex = 46
        Me.Label9.Text = "RR List"
        '
        'dgvRRList
        '
        Me.dgvRRList.AllowUserToResizeRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Gray
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvRRList.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvRRList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvRRList.Location = New System.Drawing.Point(12, 210)
        Me.dgvRRList.MultiSelect = False
        Me.dgvRRList.Name = "dgvRRList"
        Me.dgvRRList.ReadOnly = True
        Me.dgvRRList.RowHeadersVisible = False
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Gray
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        Me.dgvRRList.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvRRList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvRRList.Size = New System.Drawing.Size(294, 344)
        Me.dgvRRList.TabIndex = 45
        '
        'grpRRDetails
        '
        Me.grpRRDetails.Controls.Add(Me.cmbReason)
        Me.grpRRDetails.Controls.Add(Me.Label10)
        Me.grpRRDetails.Controls.Add(Me.txtReturnQuantity)
        Me.grpRRDetails.Controls.Add(Me.Label7)
        Me.grpRRDetails.Controls.Add(Me.btnAdd)
        Me.grpRRDetails.Controls.Add(Me.dgvRRDetails)
        Me.grpRRDetails.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpRRDetails.Location = New System.Drawing.Point(315, 2)
        Me.grpRRDetails.Name = "grpRRDetails"
        Me.grpRRDetails.Size = New System.Drawing.Size(569, 241)
        Me.grpRRDetails.TabIndex = 47
        Me.grpRRDetails.TabStop = False
        Me.grpRRDetails.Text = "RR Details"
        '
        'cmbReason
        '
        Me.cmbReason.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbReason.FormattingEnabled = True
        Me.cmbReason.Location = New System.Drawing.Point(59, 185)
        Me.cmbReason.Name = "cmbReason"
        Me.cmbReason.Size = New System.Drawing.Size(240, 21)
        Me.cmbReason.TabIndex = 38
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.SystemColors.Control
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(6, 188)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(47, 13)
        Me.Label10.TabIndex = 37
        Me.Label10.Text = "Reason:"
        '
        'txtReturnQuantity
        '
        Me.txtReturnQuantity.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtReturnQuantity.Location = New System.Drawing.Point(59, 212)
        Me.txtReturnQuantity.Name = "txtReturnQuantity"
        Me.txtReturnQuantity.Size = New System.Drawing.Size(150, 20)
        Me.txtReturnQuantity.TabIndex = 34
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.SystemColors.Control
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(6, 215)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(52, 13)
        Me.Label7.TabIndex = 33
        Me.Label7.Text = "Quantity: "
        '
        'btnAdd
        '
        Me.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.Image = CType(resources.GetObject("btnAdd.Image"), System.Drawing.Image)
        Me.btnAdd.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnAdd.Location = New System.Drawing.Point(503, 185)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(60, 50)
        Me.btnAdd.TabIndex = 7
        Me.btnAdd.Text = "Add"
        Me.btnAdd.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'dgvRRDetails
        '
        Me.dgvRRDetails.AllowUserToResizeRows = False
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Gray
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvRRDetails.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvRRDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvRRDetails.Location = New System.Drawing.Point(6, 15)
        Me.dgvRRDetails.MultiSelect = False
        Me.dgvRRDetails.Name = "dgvRRDetails"
        Me.dgvRRDetails.ReadOnly = True
        Me.dgvRRDetails.RowHeadersVisible = False
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Gray
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White
        Me.dgvRRDetails.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvRRDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvRRDetails.Size = New System.Drawing.Size(557, 164)
        Me.dgvRRDetails.TabIndex = 0
        '
        'grpReturn
        '
        Me.grpReturn.Controls.Add(Me.Label6)
        Me.grpReturn.Controls.Add(Me.dgvReturnDetails)
        Me.grpReturn.Controls.Add(Me.btnCreate)
        Me.grpReturn.Controls.Add(Me.btnReturnSave)
        Me.grpReturn.Controls.Add(Me.dateReturn)
        Me.grpReturn.Controls.Add(Me.btnRemove)
        Me.grpReturn.Controls.Add(Me.Label5)
        Me.grpReturn.Controls.Add(Me.txtReturnNo)
        Me.grpReturn.Controls.Add(Me.Label4)
        Me.grpReturn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpReturn.Location = New System.Drawing.Point(313, 249)
        Me.grpReturn.Name = "grpReturn"
        Me.grpReturn.Size = New System.Drawing.Size(569, 308)
        Me.grpReturn.TabIndex = 48
        Me.grpReturn.TabStop = False
        Me.grpReturn.Text = "Return Record"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.SystemColors.Control
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(5, 69)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(88, 13)
        Me.Label6.TabIndex = 51
        Me.Label6.Text = "Return Details"
        '
        'dgvReturnDetails
        '
        Me.dgvReturnDetails.AllowUserToResizeRows = False
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Gray
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvReturnDetails.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.dgvReturnDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvReturnDetails.Location = New System.Drawing.Point(8, 85)
        Me.dgvReturnDetails.MultiSelect = False
        Me.dgvReturnDetails.Name = "dgvReturnDetails"
        Me.dgvReturnDetails.ReadOnly = True
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Gray
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvReturnDetails.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.dgvReturnDetails.RowHeadersVisible = False
        Me.dgvReturnDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvReturnDetails.Size = New System.Drawing.Size(557, 164)
        Me.dgvReturnDetails.TabIndex = 0
        '
        'btnCreate
        '
        Me.btnCreate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnCreate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCreate.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnCreate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCreate.Image = CType(resources.GetObject("btnCreate.Image"), System.Drawing.Image)
        Me.btnCreate.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnCreate.Location = New System.Drawing.Point(2, 255)
        Me.btnCreate.Name = "btnCreate"
        Me.btnCreate.Size = New System.Drawing.Size(60, 50)
        Me.btnCreate.TabIndex = 16
        Me.btnCreate.Text = "Create"
        Me.btnCreate.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnCreate.UseVisualStyleBackColor = True
        '
        'btnReturnSave
        '
        Me.btnReturnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnReturnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReturnSave.Image = CType(resources.GetObject("btnReturnSave.Image"), System.Drawing.Image)
        Me.btnReturnSave.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnReturnSave.Location = New System.Drawing.Point(505, 255)
        Me.btnReturnSave.Name = "btnReturnSave"
        Me.btnReturnSave.Size = New System.Drawing.Size(60, 50)
        Me.btnReturnSave.TabIndex = 45
        Me.btnReturnSave.Text = "Save"
        Me.btnReturnSave.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnReturnSave.UseVisualStyleBackColor = True
        '
        'dateReturn
        '
        Me.dateReturn.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dateReturn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dateReturn.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dateReturn.Location = New System.Drawing.Point(347, 19)
        Me.dateReturn.Name = "dateReturn"
        Me.dateReturn.Size = New System.Drawing.Size(150, 20)
        Me.dateReturn.TabIndex = 11
        '
        'btnRemove
        '
        Me.btnRemove.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRemove.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRemove.Image = CType(resources.GetObject("btnRemove.Image"), System.Drawing.Image)
        Me.btnRemove.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnRemove.Location = New System.Drawing.Point(505, 29)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(60, 50)
        Me.btnRemove.TabIndex = 44
        Me.btnRemove.Text = "Remove"
        Me.btnRemove.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnRemove.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.SystemColors.Control
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(305, 22)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(36, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Date: "
        '
        'txtReturnNo
        '
        Me.txtReturnNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtReturnNo.Location = New System.Drawing.Point(84, 19)
        Me.txtReturnNo.Name = "txtReturnNo"
        Me.txtReturnNo.Size = New System.Drawing.Size(150, 20)
        Me.txtReturnNo.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.SystemColors.Control
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(16, 22)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Return No: "
        '
        'btnRefresh
        '
        Me.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRefresh.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRefresh.Image = CType(resources.GetObject("btnRefresh.Image"), System.Drawing.Image)
        Me.btnRefresh.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnRefresh.Location = New System.Drawing.Point(12, 134)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(60, 50)
        Me.btnRefresh.TabIndex = 50
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
        Me.btnCheck.Location = New System.Drawing.Point(246, 134)
        Me.btnCheck.Name = "btnCheck"
        Me.btnCheck.Size = New System.Drawing.Size(60, 50)
        Me.btnCheck.TabIndex = 49
        Me.btnCheck.Text = "Check"
        Me.btnCheck.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnCheck.UseVisualStyleBackColor = True
        '
        'purchaseReturnAdd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(894, 558)
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.btnCheck)
        Me.Controls.Add(Me.grpReturn)
        Me.Controls.Add(Me.grpRRDetails)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.dgvRRList)
        Me.Controls.Add(Me.chkTimePeriod)
        Me.Controls.Add(Me.panelDate)
        Me.Controls.Add(Me.cmbSupplier)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "purchaseReturnAdd"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "New Return Record"
        Me.panelDate.ResumeLayout(False)
        Me.panelDate.PerformLayout()
        CType(Me.dgvRRList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpRRDetails.ResumeLayout(False)
        Me.grpRRDetails.PerformLayout()
        CType(Me.dgvRRDetails, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpReturn.ResumeLayout(False)
        Me.grpReturn.PerformLayout()
        CType(Me.dgvReturnDetails, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents chkTimePeriod As CheckBox
    Friend WithEvents panelDate As Panel
    Friend WithEvents dateTo As DateTimePicker
    Friend WithEvents dateFrom As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents cmbSupplier As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents dgvRRList As DataGridView
    Friend WithEvents grpRRDetails As GroupBox
    Friend WithEvents txtReturnQuantity As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents btnAdd As Button
    Friend WithEvents dgvRRDetails As DataGridView
    Friend WithEvents grpReturn As GroupBox
    Friend WithEvents btnCreate As Button
    Friend WithEvents dateReturn As DateTimePicker
    Friend WithEvents Label5 As Label
    Friend WithEvents txtReturnNo As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents cmbReason As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents dgvReturnDetails As DataGridView
    Friend WithEvents btnReturnSave As Button
    Friend WithEvents btnRemove As Button
    Friend WithEvents btnRefresh As Button
    Friend WithEvents btnCheck As Button
    Friend WithEvents Label6 As Label
End Class
