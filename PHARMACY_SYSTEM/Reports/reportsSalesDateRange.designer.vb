<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class reportsSalesDateRange
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(reportsSalesDateRange))
        Me.chkPerCat = New System.Windows.Forms.CheckBox()
        Me.chkPerEmp = New System.Windows.Forms.CheckBox()
        Me.chkAllSales = New System.Windows.Forms.CheckBox()
        Me.chkPerProd = New System.Windows.Forms.CheckBox()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.chkDatePeriod = New System.Windows.Forms.CheckBox()
        Me.panelDate = New System.Windows.Forms.Panel()
        Me.dateTo = New System.Windows.Forms.DateTimePicker()
        Me.dateFrom = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmbProduct = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbEmployee = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmbCat = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.chkWdc = New System.Windows.Forms.CheckBox()
        Me.chkWp = New System.Windows.Forms.CheckBox()
        Me.cmbPromo = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.panelDate.SuspendLayout()
        Me.SuspendLayout()
        '
        'chkPerCat
        '
        Me.chkPerCat.AutoSize = True
        Me.chkPerCat.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkPerCat.Location = New System.Drawing.Point(107, 42)
        Me.chkPerCat.Name = "chkPerCat"
        Me.chkPerCat.Size = New System.Drawing.Size(87, 17)
        Me.chkPerCat.TabIndex = 39
        Me.chkPerCat.Text = "Per Category"
        Me.chkPerCat.UseVisualStyleBackColor = True
        '
        'chkPerEmp
        '
        Me.chkPerEmp.AutoSize = True
        Me.chkPerEmp.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkPerEmp.Location = New System.Drawing.Point(107, 19)
        Me.chkPerEmp.Name = "chkPerEmp"
        Me.chkPerEmp.Size = New System.Drawing.Size(91, 17)
        Me.chkPerEmp.TabIndex = 38
        Me.chkPerEmp.Text = "Per Employee"
        Me.chkPerEmp.UseVisualStyleBackColor = True
        '
        'chkAllSales
        '
        Me.chkAllSales.AutoSize = True
        Me.chkAllSales.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkAllSales.Location = New System.Drawing.Point(12, 19)
        Me.chkAllSales.Name = "chkAllSales"
        Me.chkAllSales.Size = New System.Drawing.Size(66, 17)
        Me.chkAllSales.TabIndex = 37
        Me.chkAllSales.Text = "All Sales"
        Me.chkAllSales.UseVisualStyleBackColor = True
        '
        'chkPerProd
        '
        Me.chkPerProd.AutoSize = True
        Me.chkPerProd.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkPerProd.Location = New System.Drawing.Point(12, 42)
        Me.chkPerProd.Name = "chkPerProd"
        Me.chkPerProd.Size = New System.Drawing.Size(82, 17)
        Me.chkPerProd.TabIndex = 36
        Me.chkPerProd.Text = "Per Product"
        Me.chkPerProd.UseVisualStyleBackColor = True
        '
        'btnPrint
        '
        Me.btnPrint.Image = CType(resources.GetObject("btnPrint.Image"), System.Drawing.Image)
        Me.btnPrint.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnPrint.Location = New System.Drawing.Point(229, 200)
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
        Me.chkDatePeriod.Location = New System.Drawing.Point(11, 93)
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
        Me.panelDate.Location = New System.Drawing.Point(8, 116)
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
        'cmbProduct
        '
        Me.cmbProduct.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbProduct.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbProduct.FormattingEnabled = True
        Me.cmbProduct.Location = New System.Drawing.Point(62, 65)
        Me.cmbProduct.Name = "cmbProduct"
        Me.cmbProduct.Size = New System.Drawing.Size(240, 21)
        Me.cmbProduct.TabIndex = 41
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 68)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 40
        Me.Label1.Text = "Product"
        '
        'cmbEmployee
        '
        Me.cmbEmployee.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbEmployee.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbEmployee.FormattingEnabled = True
        Me.cmbEmployee.Location = New System.Drawing.Point(62, 65)
        Me.cmbEmployee.Name = "cmbEmployee"
        Me.cmbEmployee.Size = New System.Drawing.Size(240, 21)
        Me.cmbEmployee.TabIndex = 43
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(8, 69)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 13)
        Me.Label4.TabIndex = 42
        Me.Label4.Text = "Employee"
        '
        'cmbCat
        '
        Me.cmbCat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCat.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbCat.FormattingEnabled = True
        Me.cmbCat.Location = New System.Drawing.Point(62, 65)
        Me.cmbCat.Name = "cmbCat"
        Me.cmbCat.Size = New System.Drawing.Size(240, 21)
        Me.cmbCat.TabIndex = 45
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(8, 69)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 13)
        Me.Label5.TabIndex = 44
        Me.Label5.Text = "Category"
        '
        'chkWdc
        '
        Me.chkWdc.AutoSize = True
        Me.chkWdc.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkWdc.Location = New System.Drawing.Point(204, 19)
        Me.chkWdc.Name = "chkWdc"
        Me.chkWdc.Size = New System.Drawing.Size(87, 17)
        Me.chkWdc.TabIndex = 46
        Me.chkWdc.Text = "W/ Discount"
        Me.chkWdc.UseVisualStyleBackColor = True
        '
        'chkWp
        '
        Me.chkWp.AutoSize = True
        Me.chkWp.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkWp.Location = New System.Drawing.Point(204, 42)
        Me.chkWp.Name = "chkWp"
        Me.chkWp.Size = New System.Drawing.Size(75, 17)
        Me.chkWp.TabIndex = 47
        Me.chkWp.Text = "W/ Promo"
        Me.chkWp.UseVisualStyleBackColor = True
        '
        'cmbPromo
        '
        Me.cmbPromo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPromo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbPromo.FormattingEnabled = True
        Me.cmbPromo.Location = New System.Drawing.Point(62, 65)
        Me.cmbPromo.Name = "cmbPromo"
        Me.cmbPromo.Size = New System.Drawing.Size(240, 21)
        Me.cmbPromo.TabIndex = 49
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(8, 69)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(37, 13)
        Me.Label6.TabIndex = 48
        Me.Label6.Text = "Promo"
        '
        'reportsSalesDateRange
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(311, 278)
        Me.Controls.Add(Me.cmbPromo)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.chkWp)
        Me.Controls.Add(Me.chkWdc)
        Me.Controls.Add(Me.cmbCat)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cmbEmployee)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cmbProduct)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.chkPerCat)
        Me.Controls.Add(Me.chkPerEmp)
        Me.Controls.Add(Me.chkAllSales)
        Me.Controls.Add(Me.chkPerProd)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.chkDatePeriod)
        Me.Controls.Add(Me.panelDate)
        Me.Name = "reportsSalesDateRange"
        Me.Text = "reportsSalesDateRange"
        Me.panelDate.ResumeLayout(False)
        Me.panelDate.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents chkPerCat As CheckBox
    Friend WithEvents chkPerEmp As CheckBox
    Friend WithEvents chkAllSales As CheckBox
    Friend WithEvents chkPerProd As CheckBox
    Friend WithEvents btnPrint As Button
    Friend WithEvents chkDatePeriod As CheckBox
    Friend WithEvents panelDate As Panel
    Friend WithEvents dateTo As DateTimePicker
    Friend WithEvents dateFrom As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents cmbProduct As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cmbEmployee As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents cmbCat As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents chkWdc As CheckBox
    Friend WithEvents chkWp As CheckBox
    Friend WithEvents cmbPromo As ComboBox
    Friend WithEvents Label6 As Label
End Class
