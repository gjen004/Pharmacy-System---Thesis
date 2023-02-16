<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class productAdd
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(productAdd))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.grpProductInfo = New System.Windows.Forms.GroupBox()
        Me.cmbProdStatus = New System.Windows.Forms.ComboBox()
        Me.cmbGenName = New System.Windows.Forms.ComboBox()
        Me.cmbProdUnit = New System.Windows.Forms.ComboBox()
        Me.btnProdRefresh = New System.Windows.Forms.Button()
        Me.cmbProdForm = New System.Windows.Forms.ComboBox()
        Me.Label44 = New System.Windows.Forms.Label()
        Me.btnProdAdd = New System.Windows.Forms.Button()
        Me.cmbProdDosage = New System.Windows.Forms.ComboBox()
        Me.txtProdBrandName = New System.Windows.Forms.TextBox()
        Me.cmbProdCategory = New System.Windows.Forms.ComboBox()
        Me.txtProdCode = New System.Windows.Forms.TextBox()
        Me.Label45 = New System.Windows.Forms.Label()
        Me.Label46 = New System.Windows.Forms.Label()
        Me.Label47 = New System.Windows.Forms.Label()
        Me.Label48 = New System.Windows.Forms.Label()
        Me.Label49 = New System.Windows.Forms.Label()
        Me.Label50 = New System.Windows.Forms.Label()
        Me.Label51 = New System.Windows.Forms.Label()
        Me.grpProdSearch = New System.Windows.Forms.GroupBox()
        Me.dgvProduct = New System.Windows.Forms.DataGridView()
        Me.btnProdSearch = New System.Windows.Forms.Button()
        Me.txtProdSearch = New System.Windows.Forms.TextBox()
        Me.Label52 = New System.Windows.Forms.Label()
        Me.rdbProdBrandName = New System.Windows.Forms.RadioButton()
        Me.rdbProdCode = New System.Windows.Forms.RadioButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.grpProductInfo.SuspendLayout()
        Me.grpProdSearch.SuspendLayout()
        CType(Me.dgvProduct, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpProductInfo
        '
        Me.grpProductInfo.BackColor = System.Drawing.SystemColors.Control
        Me.grpProductInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.grpProductInfo.Controls.Add(Me.cmbProdStatus)
        Me.grpProductInfo.Controls.Add(Me.cmbGenName)
        Me.grpProductInfo.Controls.Add(Me.cmbProdUnit)
        Me.grpProductInfo.Controls.Add(Me.btnProdRefresh)
        Me.grpProductInfo.Controls.Add(Me.cmbProdForm)
        Me.grpProductInfo.Controls.Add(Me.Label44)
        Me.grpProductInfo.Controls.Add(Me.btnProdAdd)
        Me.grpProductInfo.Controls.Add(Me.cmbProdDosage)
        Me.grpProductInfo.Controls.Add(Me.txtProdBrandName)
        Me.grpProductInfo.Controls.Add(Me.cmbProdCategory)
        Me.grpProductInfo.Controls.Add(Me.txtProdCode)
        Me.grpProductInfo.Controls.Add(Me.Label45)
        Me.grpProductInfo.Controls.Add(Me.Label46)
        Me.grpProductInfo.Controls.Add(Me.Label47)
        Me.grpProductInfo.Controls.Add(Me.Label48)
        Me.grpProductInfo.Controls.Add(Me.Label49)
        Me.grpProductInfo.Controls.Add(Me.Label50)
        Me.grpProductInfo.Controls.Add(Me.Label51)
        Me.grpProductInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpProductInfo.ForeColor = System.Drawing.Color.Black
        Me.grpProductInfo.Location = New System.Drawing.Point(4, 4)
        Me.grpProductInfo.Name = "grpProductInfo"
        Me.grpProductInfo.Size = New System.Drawing.Size(302, 414)
        Me.grpProductInfo.TabIndex = 2
        Me.grpProductInfo.TabStop = False
        Me.grpProductInfo.Text = "PRODUCT INFO"
        '
        'cmbProdStatus
        '
        Me.cmbProdStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbProdStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbProdStatus.FormattingEnabled = True
        Me.cmbProdStatus.Items.AddRange(New Object() {"Active"})
        Me.cmbProdStatus.Location = New System.Drawing.Point(93, 220)
        Me.cmbProdStatus.Name = "cmbProdStatus"
        Me.cmbProdStatus.Size = New System.Drawing.Size(200, 21)
        Me.cmbProdStatus.TabIndex = 8
        '
        'cmbGenName
        '
        Me.cmbGenName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbGenName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbGenName.FormattingEnabled = True
        Me.cmbGenName.Location = New System.Drawing.Point(93, 112)
        Me.cmbGenName.Name = "cmbGenName"
        Me.cmbGenName.Size = New System.Drawing.Size(200, 21)
        Me.cmbGenName.TabIndex = 4
        '
        'cmbProdUnit
        '
        Me.cmbProdUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbProdUnit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbProdUnit.FormattingEnabled = True
        Me.cmbProdUnit.Location = New System.Drawing.Point(93, 166)
        Me.cmbProdUnit.Name = "cmbProdUnit"
        Me.cmbProdUnit.Size = New System.Drawing.Size(200, 21)
        Me.cmbProdUnit.TabIndex = 6
        '
        'btnProdRefresh
        '
        Me.btnProdRefresh.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnProdRefresh.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProdRefresh.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnProdRefresh.Image = CType(resources.GetObject("btnProdRefresh.Image"), System.Drawing.Image)
        Me.btnProdRefresh.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnProdRefresh.Location = New System.Drawing.Point(6, 359)
        Me.btnProdRefresh.Name = "btnProdRefresh"
        Me.btnProdRefresh.Padding = New System.Windows.Forms.Padding(0, 2, 0, 0)
        Me.btnProdRefresh.Size = New System.Drawing.Size(70, 55)
        Me.btnProdRefresh.TabIndex = 10
        Me.btnProdRefresh.Text = "Refresh"
        Me.btnProdRefresh.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnProdRefresh.UseVisualStyleBackColor = True
        '
        'cmbProdForm
        '
        Me.cmbProdForm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbProdForm.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbProdForm.FormattingEnabled = True
        Me.cmbProdForm.Location = New System.Drawing.Point(93, 193)
        Me.cmbProdForm.Name = "cmbProdForm"
        Me.cmbProdForm.Size = New System.Drawing.Size(200, 21)
        Me.cmbProdForm.TabIndex = 7
        '
        'Label44
        '
        Me.Label44.AutoSize = True
        Me.Label44.BackColor = System.Drawing.SystemColors.Control
        Me.Label44.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label44.Location = New System.Drawing.Point(6, 196)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(36, 13)
        Me.Label44.TabIndex = 36
        Me.Label44.Text = "Form: "
        '
        'btnProdAdd
        '
        Me.btnProdAdd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnProdAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProdAdd.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnProdAdd.Image = CType(resources.GetObject("btnProdAdd.Image"), System.Drawing.Image)
        Me.btnProdAdd.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnProdAdd.Location = New System.Drawing.Point(226, 359)
        Me.btnProdAdd.Name = "btnProdAdd"
        Me.btnProdAdd.Padding = New System.Windows.Forms.Padding(0, 2, 0, 0)
        Me.btnProdAdd.Size = New System.Drawing.Size(70, 55)
        Me.btnProdAdd.TabIndex = 9
        Me.btnProdAdd.Text = "Add"
        Me.btnProdAdd.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnProdAdd.UseVisualStyleBackColor = True
        '
        'cmbProdDosage
        '
        Me.cmbProdDosage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbProdDosage.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbProdDosage.FormattingEnabled = True
        Me.cmbProdDosage.Location = New System.Drawing.Point(93, 139)
        Me.cmbProdDosage.Name = "cmbProdDosage"
        Me.cmbProdDosage.Size = New System.Drawing.Size(200, 21)
        Me.cmbProdDosage.TabIndex = 5
        '
        'txtProdBrandName
        '
        Me.txtProdBrandName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProdBrandName.Location = New System.Drawing.Point(93, 86)
        Me.txtProdBrandName.Name = "txtProdBrandName"
        Me.txtProdBrandName.Size = New System.Drawing.Size(200, 20)
        Me.txtProdBrandName.TabIndex = 3
        '
        'cmbProdCategory
        '
        Me.cmbProdCategory.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbProdCategory.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbProdCategory.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbProdCategory.FormattingEnabled = True
        Me.cmbProdCategory.Location = New System.Drawing.Point(93, 59)
        Me.cmbProdCategory.Name = "cmbProdCategory"
        Me.cmbProdCategory.Size = New System.Drawing.Size(200, 21)
        Me.cmbProdCategory.TabIndex = 2
        '
        'txtProdCode
        '
        Me.txtProdCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProdCode.Location = New System.Drawing.Point(93, 33)
        Me.txtProdCode.Name = "txtProdCode"
        Me.txtProdCode.Size = New System.Drawing.Size(200, 20)
        Me.txtProdCode.TabIndex = 1
        '
        'Label45
        '
        Me.Label45.AutoSize = True
        Me.Label45.BackColor = System.Drawing.SystemColors.Control
        Me.Label45.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label45.Location = New System.Drawing.Point(6, 223)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(43, 13)
        Me.Label45.TabIndex = 20
        Me.Label45.Text = "Status: "
        '
        'Label46
        '
        Me.Label46.AutoSize = True
        Me.Label46.BackColor = System.Drawing.SystemColors.Control
        Me.Label46.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label46.Location = New System.Drawing.Point(6, 169)
        Me.Label46.Name = "Label46"
        Me.Label46.Size = New System.Drawing.Size(32, 13)
        Me.Label46.TabIndex = 19
        Me.Label46.Text = "Unit: "
        '
        'Label47
        '
        Me.Label47.AutoSize = True
        Me.Label47.BackColor = System.Drawing.SystemColors.Control
        Me.Label47.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label47.Location = New System.Drawing.Point(6, 142)
        Me.Label47.Name = "Label47"
        Me.Label47.Size = New System.Drawing.Size(50, 13)
        Me.Label47.TabIndex = 18
        Me.Label47.Text = "Dosage: "
        '
        'Label48
        '
        Me.Label48.AutoSize = True
        Me.Label48.BackColor = System.Drawing.SystemColors.Control
        Me.Label48.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label48.Location = New System.Drawing.Point(6, 115)
        Me.Label48.Name = "Label48"
        Me.Label48.Size = New System.Drawing.Size(81, 13)
        Me.Label48.TabIndex = 17
        Me.Label48.Text = "Generic Name: "
        '
        'Label49
        '
        Me.Label49.AutoSize = True
        Me.Label49.BackColor = System.Drawing.SystemColors.Control
        Me.Label49.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label49.Location = New System.Drawing.Point(6, 89)
        Me.Label49.Name = "Label49"
        Me.Label49.Size = New System.Drawing.Size(72, 13)
        Me.Label49.TabIndex = 16
        Me.Label49.Text = "Brand Name: "
        '
        'Label50
        '
        Me.Label50.AutoSize = True
        Me.Label50.BackColor = System.Drawing.SystemColors.Control
        Me.Label50.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label50.Location = New System.Drawing.Point(6, 62)
        Me.Label50.Name = "Label50"
        Me.Label50.Size = New System.Drawing.Size(55, 13)
        Me.Label50.TabIndex = 15
        Me.Label50.Text = "Category: "
        '
        'Label51
        '
        Me.Label51.AutoSize = True
        Me.Label51.BackColor = System.Drawing.SystemColors.Control
        Me.Label51.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label51.Location = New System.Drawing.Point(6, 36)
        Me.Label51.Name = "Label51"
        Me.Label51.Size = New System.Drawing.Size(78, 13)
        Me.Label51.TabIndex = 14
        Me.Label51.Text = "Product Code: "
        '
        'grpProdSearch
        '
        Me.grpProdSearch.Controls.Add(Me.dgvProduct)
        Me.grpProdSearch.Controls.Add(Me.btnProdSearch)
        Me.grpProdSearch.Controls.Add(Me.txtProdSearch)
        Me.grpProdSearch.Controls.Add(Me.Label52)
        Me.grpProdSearch.Controls.Add(Me.rdbProdBrandName)
        Me.grpProdSearch.Controls.Add(Me.rdbProdCode)
        Me.grpProdSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpProdSearch.ForeColor = System.Drawing.Color.Black
        Me.grpProdSearch.Location = New System.Drawing.Point(312, 4)
        Me.grpProdSearch.Name = "grpProdSearch"
        Me.grpProdSearch.Size = New System.Drawing.Size(589, 414)
        Me.grpProdSearch.TabIndex = 3
        Me.grpProdSearch.TabStop = False
        Me.grpProdSearch.Text = "ADDED PRODUCTS"
        '
        'dgvProduct
        '
        Me.dgvProduct.AllowUserToResizeRows = False
        Me.dgvProduct.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders
        Me.dgvProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvProduct.Location = New System.Drawing.Point(6, 71)
        Me.dgvProduct.MultiSelect = False
        Me.dgvProduct.Name = "dgvProduct"
        Me.dgvProduct.ReadOnly = True
        Me.dgvProduct.RowHeadersVisible = False
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Gray
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        Me.dgvProduct.RowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvProduct.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvProduct.Size = New System.Drawing.Size(577, 332)
        Me.dgvProduct.TabIndex = 15
        '
        'btnProdSearch
        '
        Me.btnProdSearch.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnProdSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProdSearch.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnProdSearch.Image = CType(resources.GetObject("btnProdSearch.Image"), System.Drawing.Image)
        Me.btnProdSearch.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnProdSearch.Location = New System.Drawing.Point(513, 10)
        Me.btnProdSearch.Name = "btnProdSearch"
        Me.btnProdSearch.Padding = New System.Windows.Forms.Padding(0, 2, 0, 0)
        Me.btnProdSearch.Size = New System.Drawing.Size(70, 55)
        Me.btnProdSearch.TabIndex = 14
        Me.btnProdSearch.Text = "Search"
        Me.btnProdSearch.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnProdSearch.UseVisualStyleBackColor = True
        '
        'txtProdSearch
        '
        Me.txtProdSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProdSearch.Location = New System.Drawing.Point(63, 45)
        Me.txtProdSearch.Name = "txtProdSearch"
        Me.txtProdSearch.Size = New System.Drawing.Size(250, 20)
        Me.txtProdSearch.TabIndex = 13
        '
        'Label52
        '
        Me.Label52.AutoSize = True
        Me.Label52.BackColor = System.Drawing.SystemColors.Control
        Me.Label52.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label52.Location = New System.Drawing.Point(6, 48)
        Me.Label52.Name = "Label52"
        Me.Label52.Size = New System.Drawing.Size(51, 13)
        Me.Label52.TabIndex = 24
        Me.Label52.Text = "Keyword:"
        '
        'rdbProdBrandName
        '
        Me.rdbProdBrandName.AutoSize = True
        Me.rdbProdBrandName.Cursor = System.Windows.Forms.Cursors.Hand
        Me.rdbProdBrandName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbProdBrandName.Location = New System.Drawing.Point(162, 19)
        Me.rdbProdBrandName.Name = "rdbProdBrandName"
        Me.rdbProdBrandName.Size = New System.Drawing.Size(84, 17)
        Me.rdbProdBrandName.TabIndex = 12
        Me.rdbProdBrandName.Text = "Brand Name"
        Me.rdbProdBrandName.UseVisualStyleBackColor = True
        '
        'rdbProdCode
        '
        Me.rdbProdCode.AutoSize = True
        Me.rdbProdCode.Cursor = System.Windows.Forms.Cursors.Hand
        Me.rdbProdCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbProdCode.Location = New System.Drawing.Point(35, 19)
        Me.rdbProdCode.Name = "rdbProdCode"
        Me.rdbProdCode.Size = New System.Drawing.Size(90, 17)
        Me.rdbProdCode.TabIndex = 11
        Me.rdbProdCode.Text = "Product Code"
        Me.rdbProdCode.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Control
        Me.Panel1.Controls.Add(Me.grpProdSearch)
        Me.Panel1.Controls.Add(Me.grpProductInfo)
        Me.Panel1.ForeColor = System.Drawing.Color.Black
        Me.Panel1.Location = New System.Drawing.Point(0, 31)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(904, 421)
        Me.Panel1.TabIndex = 4
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.DodgerBlue
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(904, 25)
        Me.Panel2.TabIndex = 5
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.DodgerBlue
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(0, 458)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(904, 25)
        Me.Panel3.TabIndex = 6
        '
        'productAdd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.ClientSize = New System.Drawing.Size(904, 483)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "productAdd"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "New Product Record"
        Me.grpProductInfo.ResumeLayout(False)
        Me.grpProductInfo.PerformLayout()
        Me.grpProdSearch.ResumeLayout(False)
        Me.grpProdSearch.PerformLayout()
        CType(Me.dgvProduct, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grpProductInfo As GroupBox
    Friend WithEvents cmbGenName As ComboBox
    Friend WithEvents cmbProdUnit As ComboBox
    Friend WithEvents btnProdRefresh As Button
    Friend WithEvents cmbProdForm As ComboBox
    Friend WithEvents Label44 As Label
    Friend WithEvents btnProdAdd As Button
    Friend WithEvents cmbProdDosage As ComboBox
    Friend WithEvents txtProdBrandName As TextBox
    Friend WithEvents cmbProdCategory As ComboBox
    Friend WithEvents txtProdCode As TextBox
    Friend WithEvents Label46 As Label
    Friend WithEvents Label47 As Label
    Friend WithEvents Label48 As Label
    Friend WithEvents Label49 As Label
    Friend WithEvents Label50 As Label
    Friend WithEvents Label51 As Label
    Friend WithEvents grpProdSearch As GroupBox
    Friend WithEvents dgvProduct As DataGridView
    Friend WithEvents btnProdSearch As Button
    Friend WithEvents txtProdSearch As TextBox
    Friend WithEvents Label52 As Label
    Friend WithEvents rdbProdBrandName As RadioButton
    Friend WithEvents rdbProdCode As RadioButton
    Friend WithEvents cmbProdStatus As ComboBox
    Friend WithEvents Label45 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
End Class
