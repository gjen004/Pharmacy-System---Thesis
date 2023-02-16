<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class purchaseOrderAdd
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(purchaseOrderAdd))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.btnPOAdd = New System.Windows.Forms.Button()
        Me.grpNewPO = New System.Windows.Forms.GroupBox()
        Me.btnCreate = New System.Windows.Forms.Button()
        Me.txtPORemarks = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cmbPOSupplier = New System.Windows.Forms.ComboBox()
        Me.datePONeeded = New System.Windows.Forms.DateTimePicker()
        Me.datePOOrder = New System.Windows.Forms.DateTimePicker()
        Me.txtPONo = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.cmbPOProduct = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtPOPrice = New System.Windows.Forms.TextBox()
        Me.txtPOQuantity = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dgvPO = New System.Windows.Forms.DataGridView()
        Me.grpPODetails = New System.Windows.Forms.GroupBox()
        Me.btnPOSave = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.grpNewPO.SuspendLayout()
        CType(Me.dgvPO, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpPODetails.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnPOAdd
        '
        Me.btnPOAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnPOAdd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPOAdd.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnPOAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPOAdd.Image = CType(resources.GetObject("btnPOAdd.Image"), System.Drawing.Image)
        Me.btnPOAdd.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnPOAdd.Location = New System.Drawing.Point(389, 83)
        Me.btnPOAdd.Name = "btnPOAdd"
        Me.btnPOAdd.Padding = New System.Windows.Forms.Padding(0, 2, 0, 0)
        Me.btnPOAdd.Size = New System.Drawing.Size(70, 55)
        Me.btnPOAdd.TabIndex = 17
        Me.btnPOAdd.Text = "Add"
        Me.btnPOAdd.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnPOAdd.UseVisualStyleBackColor = True
        '
        'grpNewPO
        '
        Me.grpNewPO.Controls.Add(Me.btnCreate)
        Me.grpNewPO.Controls.Add(Me.txtPORemarks)
        Me.grpNewPO.Controls.Add(Me.Label8)
        Me.grpNewPO.Controls.Add(Me.cmbPOSupplier)
        Me.grpNewPO.Controls.Add(Me.datePONeeded)
        Me.grpNewPO.Controls.Add(Me.datePOOrder)
        Me.grpNewPO.Controls.Add(Me.txtPONo)
        Me.grpNewPO.Controls.Add(Me.Label1)
        Me.grpNewPO.Controls.Add(Me.Label4)
        Me.grpNewPO.Controls.Add(Me.Label2)
        Me.grpNewPO.Controls.Add(Me.Label3)
        Me.grpNewPO.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpNewPO.Location = New System.Drawing.Point(3, 3)
        Me.grpNewPO.Name = "grpNewPO"
        Me.grpNewPO.Size = New System.Drawing.Size(342, 417)
        Me.grpNewPO.TabIndex = 5
        Me.grpNewPO.TabStop = False
        Me.grpNewPO.Text = "NEW PO"
        '
        'btnCreate
        '
        Me.btnCreate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnCreate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCreate.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnCreate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCreate.Image = CType(resources.GetObject("btnCreate.Image"), System.Drawing.Image)
        Me.btnCreate.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnCreate.Location = New System.Drawing.Point(266, 356)
        Me.btnCreate.Name = "btnCreate"
        Me.btnCreate.Padding = New System.Windows.Forms.Padding(0, 2, 0, 0)
        Me.btnCreate.Size = New System.Drawing.Size(70, 55)
        Me.btnCreate.TabIndex = 6
        Me.btnCreate.Text = "Create"
        Me.btnCreate.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnCreate.UseVisualStyleBackColor = True
        '
        'txtPORemarks
        '
        Me.txtPORemarks.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPORemarks.Location = New System.Drawing.Point(89, 135)
        Me.txtPORemarks.Multiline = True
        Me.txtPORemarks.Name = "txtPORemarks"
        Me.txtPORemarks.Size = New System.Drawing.Size(240, 170)
        Me.txtPORemarks.TabIndex = 5
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.SystemColors.Control
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(6, 138)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(55, 13)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Remarks: "
        '
        'cmbPOSupplier
        '
        Me.cmbPOSupplier.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPOSupplier.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbPOSupplier.FormattingEnabled = True
        Me.cmbPOSupplier.Location = New System.Drawing.Point(89, 27)
        Me.cmbPOSupplier.Name = "cmbPOSupplier"
        Me.cmbPOSupplier.Size = New System.Drawing.Size(240, 21)
        Me.cmbPOSupplier.TabIndex = 1
        '
        'datePONeeded
        '
        Me.datePONeeded.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.datePONeeded.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.datePONeeded.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.datePONeeded.Location = New System.Drawing.Point(89, 109)
        Me.datePONeeded.Name = "datePONeeded"
        Me.datePONeeded.Size = New System.Drawing.Size(240, 20)
        Me.datePONeeded.TabIndex = 4
        '
        'datePOOrder
        '
        Me.datePOOrder.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.datePOOrder.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.datePOOrder.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.datePOOrder.Location = New System.Drawing.Point(89, 82)
        Me.datePOOrder.Name = "datePOOrder"
        Me.datePOOrder.Size = New System.Drawing.Size(240, 20)
        Me.datePOOrder.TabIndex = 3
        '
        'txtPONo
        '
        Me.txtPONo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPONo.Location = New System.Drawing.Point(89, 54)
        Me.txtPONo.Name = "txtPONo"
        Me.txtPONo.Size = New System.Drawing.Size(240, 20)
        Me.txtPONo.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "PO No: "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.SystemColors.Control
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(6, 115)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(77, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Date Needed: "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(6, 89)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Order Date: "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.Control
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(6, 33)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Supplier: "
        '
        'btnRefresh
        '
        Me.btnRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRefresh.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnRefresh.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRefresh.Image = CType(resources.GetObject("btnRefresh.Image"), System.Drawing.Image)
        Me.btnRefresh.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnRefresh.Location = New System.Drawing.Point(12, 426)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Padding = New System.Windows.Forms.Padding(0, 2, 0, 0)
        Me.btnRefresh.Size = New System.Drawing.Size(70, 55)
        Me.btnRefresh.TabIndex = 18
        Me.btnRefresh.Text = "Refresh"
        Me.btnRefresh.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'btnRemove
        '
        Me.btnRemove.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRemove.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRemove.Image = CType(resources.GetObject("btnRemove.Image"), System.Drawing.Image)
        Me.btnRemove.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnRemove.Location = New System.Drawing.Point(9, 83)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Padding = New System.Windows.Forms.Padding(0, 2, 0, 0)
        Me.btnRemove.Size = New System.Drawing.Size(70, 55)
        Me.btnRemove.TabIndex = 19
        Me.btnRemove.Text = "Remove"
        Me.btnRemove.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnRemove.UseVisualStyleBackColor = True
        '
        'cmbPOProduct
        '
        Me.cmbPOProduct.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPOProduct.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbPOProduct.FormattingEnabled = True
        Me.cmbPOProduct.Location = New System.Drawing.Point(62, 27)
        Me.cmbPOProduct.Name = "cmbPOProduct"
        Me.cmbPOProduct.Size = New System.Drawing.Size(397, 21)
        Me.cmbPOProduct.TabIndex = 14
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.SystemColors.Control
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(6, 30)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(50, 13)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Product: "
        '
        'txtPOPrice
        '
        Me.txtPOPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPOPrice.Location = New System.Drawing.Point(349, 53)
        Me.txtPOPrice.Name = "txtPOPrice"
        Me.txtPOPrice.Size = New System.Drawing.Size(110, 20)
        Me.txtPOPrice.TabIndex = 16
        '
        'txtPOQuantity
        '
        Me.txtPOQuantity.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPOQuantity.Location = New System.Drawing.Point(64, 54)
        Me.txtPOQuantity.Name = "txtPOQuantity"
        Me.txtPOQuantity.Size = New System.Drawing.Size(110, 20)
        Me.txtPOQuantity.TabIndex = 15
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.SystemColors.Control
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(284, 57)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(59, 13)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Unit Price: "
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.SystemColors.Control
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(6, 57)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(52, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Quantity: "
        '
        'dgvPO
        '
        Me.dgvPO.AllowUserToResizeRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Gray
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvPO.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvPO.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Gray
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvPO.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvPO.Location = New System.Drawing.Point(0, 144)
        Me.dgvPO.MultiSelect = False
        Me.dgvPO.Name = "dgvPO"
        Me.dgvPO.ReadOnly = True
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Gray
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvPO.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvPO.RowHeadersVisible = False
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Gray
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White
        Me.dgvPO.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvPO.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvPO.Size = New System.Drawing.Size(459, 273)
        Me.dgvPO.TabIndex = 18
        '
        'grpPODetails
        '
        Me.grpPODetails.Controls.Add(Me.txtPOPrice)
        Me.grpPODetails.Controls.Add(Me.btnPOSave)
        Me.grpPODetails.Controls.Add(Me.txtPOQuantity)
        Me.grpPODetails.Controls.Add(Me.btnRemove)
        Me.grpPODetails.Controls.Add(Me.dgvPO)
        Me.grpPODetails.Controls.Add(Me.btnPOAdd)
        Me.grpPODetails.Controls.Add(Me.Label7)
        Me.grpPODetails.Controls.Add(Me.cmbPOProduct)
        Me.grpPODetails.Controls.Add(Me.Label6)
        Me.grpPODetails.Controls.Add(Me.Label5)
        Me.grpPODetails.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpPODetails.Location = New System.Drawing.Point(351, 3)
        Me.grpPODetails.Name = "grpPODetails"
        Me.grpPODetails.Size = New System.Drawing.Size(462, 488)
        Me.grpPODetails.TabIndex = 40
        Me.grpPODetails.TabStop = False
        Me.grpPODetails.Text = "Details"
        '
        'btnPOSave
        '
        Me.btnPOSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPOSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPOSave.Image = CType(resources.GetObject("btnPOSave.Image"), System.Drawing.Image)
        Me.btnPOSave.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnPOSave.Location = New System.Drawing.Point(389, 423)
        Me.btnPOSave.Name = "btnPOSave"
        Me.btnPOSave.Padding = New System.Windows.Forms.Padding(0, 2, 0, 0)
        Me.btnPOSave.Size = New System.Drawing.Size(70, 55)
        Me.btnPOSave.TabIndex = 20
        Me.btnPOSave.Text = "Save"
        Me.btnPOSave.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnPOSave.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Control
        Me.Panel1.Controls.Add(Me.btnRefresh)
        Me.Panel1.Controls.Add(Me.grpPODetails)
        Me.Panel1.Controls.Add(Me.grpNewPO)
        Me.Panel1.Location = New System.Drawing.Point(0, 31)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(815, 494)
        Me.Panel1.TabIndex = 41
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.DodgerBlue
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(815, 25)
        Me.Panel2.TabIndex = 42
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.DodgerBlue
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(0, 536)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(815, 25)
        Me.Panel3.TabIndex = 43
        '
        'purchaseOrderAdd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.ClientSize = New System.Drawing.Size(815, 561)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "purchaseOrderAdd"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "New Purchase Order"
        Me.grpNewPO.ResumeLayout(False)
        Me.grpNewPO.PerformLayout()
        CType(Me.dgvPO, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpPODetails.ResumeLayout(False)
        Me.grpPODetails.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgvPO As System.Windows.Forms.DataGridView
    Friend WithEvents grpNewPO As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents datePONeeded As System.Windows.Forms.DateTimePicker
    Friend WithEvents datePOOrder As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtPONo As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtPOPrice As System.Windows.Forms.TextBox
    Friend WithEvents txtPOQuantity As System.Windows.Forms.TextBox
    Friend WithEvents cmbPOSupplier As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents btnPOAdd As System.Windows.Forms.Button
    Friend WithEvents cmbPOProduct As System.Windows.Forms.ComboBox
    Friend WithEvents txtPORemarks As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents btnRemove As Button
    Friend WithEvents btnCreate As Button
    Friend WithEvents grpPODetails As GroupBox
    Friend WithEvents btnPOSave As Button
    Friend WithEvents btnRefresh As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
End Class
