<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class purchaseOrderClose
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(purchaseOrderClose))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.btnCheck = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.chkDatePeriod = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbReason = New System.Windows.Forms.ComboBox()
        Me.panelDate = New System.Windows.Forms.Panel()
        Me.dateTo = New System.Windows.Forms.DateTimePicker()
        Me.dateFrom = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.dgvPODetails = New System.Windows.Forms.DataGridView()
        Me.btnPOClose = New System.Windows.Forms.Button()
        Me.dgvPOList = New System.Windows.Forms.DataGridView()
        Me.cmbSupplier = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.panelDate.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.dgvPODetails, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvPOList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnRefresh
        '
        Me.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRefresh.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRefresh.Image = CType(resources.GetObject("btnRefresh.Image"), System.Drawing.Image)
        Me.btnRefresh.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnRefresh.Location = New System.Drawing.Point(6, 140)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Padding = New System.Windows.Forms.Padding(0, 2, 0, 0)
        Me.btnRefresh.Size = New System.Drawing.Size(70, 55)
        Me.btnRefresh.TabIndex = 39
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
        Me.btnCheck.Location = New System.Drawing.Point(233, 140)
        Me.btnCheck.Name = "btnCheck"
        Me.btnCheck.Padding = New System.Windows.Forms.Padding(0, 2, 0, 0)
        Me.btnCheck.Size = New System.Drawing.Size(70, 55)
        Me.btnCheck.TabIndex = 38
        Me.btnCheck.Text = "Go"
        Me.btnCheck.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnCheck.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.SystemColors.Control
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(3, 199)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(48, 13)
        Me.Label5.TabIndex = 37
        Me.Label5.Text = "PO List"
        '
        'chkDatePeriod
        '
        Me.chkDatePeriod.AutoSize = True
        Me.chkDatePeriod.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkDatePeriod.Location = New System.Drawing.Point(12, 39)
        Me.chkDatePeriod.Name = "chkDatePeriod"
        Me.chkDatePeriod.Size = New System.Drawing.Size(82, 17)
        Me.chkDatePeriod.TabIndex = 20
        Me.chkDatePeriod.Text = "Date Period"
        Me.chkDatePeriod.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(505, 55)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 13)
        Me.Label1.TabIndex = 35
        Me.Label1.Text = "Reason:"
        '
        'cmbReason
        '
        Me.cmbReason.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbReason.FormattingEnabled = True
        Me.cmbReason.Location = New System.Drawing.Point(558, 51)
        Me.cmbReason.Name = "cmbReason"
        Me.cmbReason.Size = New System.Drawing.Size(240, 21)
        Me.cmbReason.TabIndex = 36
        '
        'panelDate
        '
        Me.panelDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelDate.Controls.Add(Me.dateTo)
        Me.panelDate.Controls.Add(Me.dateFrom)
        Me.panelDate.Controls.Add(Me.Label2)
        Me.panelDate.Controls.Add(Me.Label3)
        Me.panelDate.Location = New System.Drawing.Point(9, 62)
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
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.dgvPODetails)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(309, 78)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(571, 418)
        Me.GroupBox3.TabIndex = 13
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "PO Details"
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
        Me.dgvPODetails.Location = New System.Drawing.Point(6, 15)
        Me.dgvPODetails.MultiSelect = False
        Me.dgvPODetails.Name = "dgvPODetails"
        Me.dgvPODetails.ReadOnly = True
        Me.dgvPODetails.RowHeadersVisible = False
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Gray
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        Me.dgvPODetails.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvPODetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvPODetails.Size = New System.Drawing.Size(559, 397)
        Me.dgvPODetails.TabIndex = 0
        '
        'btnPOClose
        '
        Me.btnPOClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPOClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPOClose.Image = CType(resources.GetObject("btnPOClose.Image"), System.Drawing.Image)
        Me.btnPOClose.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnPOClose.Location = New System.Drawing.Point(804, 17)
        Me.btnPOClose.Name = "btnPOClose"
        Me.btnPOClose.Padding = New System.Windows.Forms.Padding(0, 2, 0, 0)
        Me.btnPOClose.Size = New System.Drawing.Size(70, 55)
        Me.btnPOClose.TabIndex = 34
        Me.btnPOClose.Text = "Close"
        Me.btnPOClose.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnPOClose.UseVisualStyleBackColor = True
        '
        'dgvPOList
        '
        Me.dgvPOList.AllowUserToResizeRows = False
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Gray
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvPOList.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvPOList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvPOList.Location = New System.Drawing.Point(6, 215)
        Me.dgvPOList.MultiSelect = False
        Me.dgvPOList.Name = "dgvPOList"
        Me.dgvPOList.ReadOnly = True
        Me.dgvPOList.RowHeadersVisible = False
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Gray
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White
        Me.dgvPOList.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvPOList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvPOList.Size = New System.Drawing.Size(297, 275)
        Me.dgvPOList.TabIndex = 12
        '
        'cmbSupplier
        '
        Me.cmbSupplier.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSupplier.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbSupplier.FormattingEnabled = True
        Me.cmbSupplier.Location = New System.Drawing.Point(63, 12)
        Me.cmbSupplier.Name = "cmbSupplier"
        Me.cmbSupplier.Size = New System.Drawing.Size(240, 21)
        Me.cmbSupplier.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(6, 15)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Supplier: "
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.DodgerBlue
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(0, 536)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(884, 25)
        Me.Panel3.TabIndex = 44
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Control
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.dgvPOList)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.cmbSupplier)
        Me.Panel1.Controls.Add(Me.btnCheck)
        Me.Panel1.Controls.Add(Me.cmbReason)
        Me.Panel1.Controls.Add(Me.btnRefresh)
        Me.Panel1.Controls.Add(Me.btnPOClose)
        Me.Panel1.Controls.Add(Me.chkDatePeriod)
        Me.Panel1.Controls.Add(Me.GroupBox3)
        Me.Panel1.Controls.Add(Me.panelDate)
        Me.Panel1.Location = New System.Drawing.Point(0, 31)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(881, 499)
        Me.Panel1.TabIndex = 45
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.DodgerBlue
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(884, 25)
        Me.Panel2.TabIndex = 46
        '
        'purchaseOrderClose
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.ClientSize = New System.Drawing.Size(884, 561)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "purchaseOrderClose"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Close Purchase Order"
        Me.panelDate.ResumeLayout(False)
        Me.panelDate.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.dgvPODetails, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvPOList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents chkDatePeriod As CheckBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cmbReason As ComboBox
    Friend WithEvents panelDate As Panel
    Friend WithEvents dateTo As DateTimePicker
    Friend WithEvents dateFrom As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents dgvPODetails As DataGridView
    Friend WithEvents btnPOClose As Button
    Friend WithEvents dgvPOList As DataGridView
    Friend WithEvents cmbSupplier As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents btnCheck As Button
    Friend WithEvents btnRefresh As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
End Class
