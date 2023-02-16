<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class reportsPO
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(reportsPO))
        Me.chkDatePeriod = New System.Windows.Forms.CheckBox()
        Me.panelDate = New System.Windows.Forms.Panel()
        Me.dateTo = New System.Windows.Forms.DateTimePicker()
        Me.dateFrom = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmbSupplier = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.chkPOPending = New System.Windows.Forms.CheckBox()
        Me.chkPOAll = New System.Windows.Forms.CheckBox()
        Me.chkPOClose = New System.Windows.Forms.CheckBox()
        Me.chkPOVoid = New System.Windows.Forms.CheckBox()
        Me.chkPOBySupplier = New System.Windows.Forms.CheckBox()
        Me.panelDate.SuspendLayout()
        Me.SuspendLayout()
        '
        'chkDatePeriod
        '
        Me.chkDatePeriod.AutoSize = True
        Me.chkDatePeriod.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkDatePeriod.Location = New System.Drawing.Point(11, 98)
        Me.chkDatePeriod.Name = "chkDatePeriod"
        Me.chkDatePeriod.Size = New System.Drawing.Size(82, 17)
        Me.chkDatePeriod.TabIndex = 24
        Me.chkDatePeriod.Text = "Date Period"
        Me.chkDatePeriod.UseVisualStyleBackColor = True
        '
        'panelDate
        '
        Me.panelDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelDate.Controls.Add(Me.dateTo)
        Me.panelDate.Controls.Add(Me.dateFrom)
        Me.panelDate.Controls.Add(Me.Label2)
        Me.panelDate.Controls.Add(Me.Label3)
        Me.panelDate.Location = New System.Drawing.Point(8, 121)
        Me.panelDate.Name = "panelDate"
        Me.panelDate.Size = New System.Drawing.Size(294, 72)
        Me.panelDate.TabIndex = 23
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
        'cmbSupplier
        '
        Me.cmbSupplier.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSupplier.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbSupplier.FormattingEnabled = True
        Me.cmbSupplier.Location = New System.Drawing.Point(62, 71)
        Me.cmbSupplier.Name = "cmbSupplier"
        Me.cmbSupplier.Size = New System.Drawing.Size(239, 21)
        Me.cmbSupplier.TabIndex = 22
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 74)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 13)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "Supplier: "
        '
        'btnPrint
        '
        Me.btnPrint.Image = CType(resources.GetObject("btnPrint.Image"), System.Drawing.Image)
        Me.btnPrint.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnPrint.Location = New System.Drawing.Point(229, 205)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Padding = New System.Windows.Forms.Padding(0, 5, 0, 0)
        Me.btnPrint.Size = New System.Drawing.Size(70, 60)
        Me.btnPrint.TabIndex = 25
        Me.btnPrint.Text = "Print"
        Me.btnPrint.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'chkPOPending
        '
        Me.chkPOPending.AutoSize = True
        Me.chkPOPending.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkPOPending.Location = New System.Drawing.Point(12, 35)
        Me.chkPOPending.Name = "chkPOPending"
        Me.chkPOPending.Size = New System.Drawing.Size(65, 17)
        Me.chkPOPending.TabIndex = 26
        Me.chkPOPending.Text = "Pending"
        Me.chkPOPending.UseVisualStyleBackColor = True
        '
        'chkPOAll
        '
        Me.chkPOAll.AutoSize = True
        Me.chkPOAll.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkPOAll.Location = New System.Drawing.Point(12, 12)
        Me.chkPOAll.Name = "chkPOAll"
        Me.chkPOAll.Size = New System.Drawing.Size(55, 17)
        Me.chkPOAll.TabIndex = 27
        Me.chkPOAll.Text = "All PO"
        Me.chkPOAll.UseVisualStyleBackColor = True
        '
        'chkPOClose
        '
        Me.chkPOClose.AutoSize = True
        Me.chkPOClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkPOClose.Location = New System.Drawing.Point(107, 12)
        Me.chkPOClose.Name = "chkPOClose"
        Me.chkPOClose.Size = New System.Drawing.Size(58, 17)
        Me.chkPOClose.TabIndex = 28
        Me.chkPOClose.Text = "Closed"
        Me.chkPOClose.UseVisualStyleBackColor = True
        '
        'chkPOVoid
        '
        Me.chkPOVoid.AutoSize = True
        Me.chkPOVoid.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkPOVoid.Location = New System.Drawing.Point(107, 35)
        Me.chkPOVoid.Name = "chkPOVoid"
        Me.chkPOVoid.Size = New System.Drawing.Size(59, 17)
        Me.chkPOVoid.TabIndex = 29
        Me.chkPOVoid.Text = "Voided"
        Me.chkPOVoid.UseVisualStyleBackColor = True
        '
        'chkPOBySupplier
        '
        Me.chkPOBySupplier.AutoSize = True
        Me.chkPOBySupplier.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkPOBySupplier.Location = New System.Drawing.Point(172, 12)
        Me.chkPOBySupplier.Name = "chkPOBySupplier"
        Me.chkPOBySupplier.Size = New System.Drawing.Size(79, 17)
        Me.chkPOBySupplier.TabIndex = 30
        Me.chkPOBySupplier.Text = "By Supplier"
        Me.chkPOBySupplier.UseVisualStyleBackColor = True
        '
        'reportsPO
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(311, 278)
        Me.Controls.Add(Me.chkPOBySupplier)
        Me.Controls.Add(Me.chkPOVoid)
        Me.Controls.Add(Me.chkPOClose)
        Me.Controls.Add(Me.chkPOAll)
        Me.Controls.Add(Me.chkPOPending)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.chkDatePeriod)
        Me.Controls.Add(Me.panelDate)
        Me.Controls.Add(Me.cmbSupplier)
        Me.Controls.Add(Me.Label1)
        Me.Name = "reportsPO"
        Me.Text = "PO Summary"
        Me.panelDate.ResumeLayout(False)
        Me.panelDate.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents chkDatePeriod As CheckBox
    Friend WithEvents panelDate As Panel
    Friend WithEvents dateTo As DateTimePicker
    Friend WithEvents dateFrom As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents cmbSupplier As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnPrint As Button
    Friend WithEvents chkPOPending As CheckBox
    Friend WithEvents chkPOAll As CheckBox
    Friend WithEvents chkPOClose As CheckBox
    Friend WithEvents chkPOVoid As CheckBox
    Friend WithEvents chkPOBySupplier As CheckBox
End Class
