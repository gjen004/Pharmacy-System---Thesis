<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class reportRRAll
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(reportRRAll))
        Me.chkRRBySupplier = New System.Windows.Forms.CheckBox()
        Me.chkRRUnpaid = New System.Windows.Forms.CheckBox()
        Me.chkRRAll = New System.Windows.Forms.CheckBox()
        Me.chkRRPaid = New System.Windows.Forms.CheckBox()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.chkDatePeriod = New System.Windows.Forms.CheckBox()
        Me.panelDate = New System.Windows.Forms.Panel()
        Me.dateTo = New System.Windows.Forms.DateTimePicker()
        Me.dateFrom = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmbSupplier = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.panelDate.SuspendLayout()
        Me.SuspendLayout()
        '
        'chkRRBySupplier
        '
        Me.chkRRBySupplier.AutoSize = True
        Me.chkRRBySupplier.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkRRBySupplier.Location = New System.Drawing.Point(107, 36)
        Me.chkRRBySupplier.Name = "chkRRBySupplier"
        Me.chkRRBySupplier.Size = New System.Drawing.Size(79, 17)
        Me.chkRRBySupplier.TabIndex = 40
        Me.chkRRBySupplier.Text = "By Supplier"
        Me.chkRRBySupplier.UseVisualStyleBackColor = True
        '
        'chkRRUnpaid
        '
        Me.chkRRUnpaid.AutoSize = True
        Me.chkRRUnpaid.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkRRUnpaid.Location = New System.Drawing.Point(107, 13)
        Me.chkRRUnpaid.Name = "chkRRUnpaid"
        Me.chkRRUnpaid.Size = New System.Drawing.Size(60, 17)
        Me.chkRRUnpaid.TabIndex = 38
        Me.chkRRUnpaid.Text = "Unpaid"
        Me.chkRRUnpaid.UseVisualStyleBackColor = True
        '
        'chkRRAll
        '
        Me.chkRRAll.AutoSize = True
        Me.chkRRAll.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkRRAll.Location = New System.Drawing.Point(12, 13)
        Me.chkRRAll.Name = "chkRRAll"
        Me.chkRRAll.Size = New System.Drawing.Size(56, 17)
        Me.chkRRAll.TabIndex = 37
        Me.chkRRAll.Text = "All RR"
        Me.chkRRAll.UseVisualStyleBackColor = True
        '
        'chkRRPaid
        '
        Me.chkRRPaid.AutoSize = True
        Me.chkRRPaid.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkRRPaid.Location = New System.Drawing.Point(12, 36)
        Me.chkRRPaid.Name = "chkRRPaid"
        Me.chkRRPaid.Size = New System.Drawing.Size(47, 17)
        Me.chkRRPaid.TabIndex = 36
        Me.chkRRPaid.Text = "Paid"
        Me.chkRRPaid.UseVisualStyleBackColor = True
        '
        'btnPrint
        '
        Me.btnPrint.Image = CType(resources.GetObject("btnPrint.Image"), System.Drawing.Image)
        Me.btnPrint.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnPrint.Location = New System.Drawing.Point(229, 206)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Padding = New System.Windows.Forms.Padding(0, 5, 0, 0)
        Me.btnPrint.Size = New System.Drawing.Size(70, 60)
        Me.btnPrint.TabIndex = 35
        Me.btnPrint.Text = "Print"
        Me.btnPrint.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'chkDatePeriod
        '
        Me.chkDatePeriod.AutoSize = True
        Me.chkDatePeriod.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkDatePeriod.Location = New System.Drawing.Point(11, 99)
        Me.chkDatePeriod.Name = "chkDatePeriod"
        Me.chkDatePeriod.Size = New System.Drawing.Size(82, 17)
        Me.chkDatePeriod.TabIndex = 34
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
        Me.panelDate.Location = New System.Drawing.Point(8, 122)
        Me.panelDate.Name = "panelDate"
        Me.panelDate.Size = New System.Drawing.Size(294, 72)
        Me.panelDate.TabIndex = 33
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
        Me.cmbSupplier.Location = New System.Drawing.Point(62, 72)
        Me.cmbSupplier.Name = "cmbSupplier"
        Me.cmbSupplier.Size = New System.Drawing.Size(239, 21)
        Me.cmbSupplier.TabIndex = 32
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 75)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 13)
        Me.Label1.TabIndex = 31
        Me.Label1.Text = "Supplier: "
        '
        'reportRRAll
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(311, 278)
        Me.Controls.Add(Me.chkRRBySupplier)
        Me.Controls.Add(Me.chkRRUnpaid)
        Me.Controls.Add(Me.chkRRAll)
        Me.Controls.Add(Me.chkRRPaid)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.chkDatePeriod)
        Me.Controls.Add(Me.panelDate)
        Me.Controls.Add(Me.cmbSupplier)
        Me.Controls.Add(Me.Label1)
        Me.Name = "reportRRAll"
        Me.Text = "reportRRAll"
        Me.panelDate.ResumeLayout(False)
        Me.panelDate.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents chkRRBySupplier As CheckBox
    Friend WithEvents chkRRUnpaid As CheckBox
    Friend WithEvents chkRRAll As CheckBox
    Friend WithEvents chkRRPaid As CheckBox
    Friend WithEvents btnPrint As Button
    Friend WithEvents chkDatePeriod As CheckBox
    Friend WithEvents panelDate As Panel
    Friend WithEvents dateTo As DateTimePicker
    Friend WithEvents dateFrom As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents cmbSupplier As ComboBox
    Friend WithEvents Label1 As Label
End Class
