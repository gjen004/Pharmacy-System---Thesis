<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class customerUpdate
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(customerUpdate))
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.grpCustInfo = New System.Windows.Forms.GroupBox()
        Me.txtCusContact = New System.Windows.Forms.TextBox()
        Me.txtCusAddress = New System.Windows.Forms.TextBox()
        Me.txtCusName = New System.Windows.Forms.TextBox()
        Me.cmbProvince = New System.Windows.Forms.ComboBox()
        Me.cmbCity = New System.Windows.Forms.ComboBox()
        Me.Label54 = New System.Windows.Forms.Label()
        Me.Label55 = New System.Windows.Forms.Label()
        Me.Label56 = New System.Windows.Forms.Label()
        Me.Label57 = New System.Windows.Forms.Label()
        Me.Label58 = New System.Windows.Forms.Label()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.grpCustSearch = New System.Windows.Forms.GroupBox()
        Me.rdbCustAddress = New System.Windows.Forms.RadioButton()
        Me.rdbCustName = New System.Windows.Forms.RadioButton()
        Me.btnCusSearch = New System.Windows.Forms.Button()
        Me.txtCusSearch = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgvCustomer = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.grpCustInfo.SuspendLayout()
        Me.grpCustSearch.SuspendLayout()
        CType(Me.dgvCustomer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpCustInfo
        '
        Me.grpCustInfo.Controls.Add(Me.txtCusContact)
        Me.grpCustInfo.Controls.Add(Me.txtCusAddress)
        Me.grpCustInfo.Controls.Add(Me.txtCusName)
        Me.grpCustInfo.Controls.Add(Me.cmbProvince)
        Me.grpCustInfo.Controls.Add(Me.cmbCity)
        Me.grpCustInfo.Controls.Add(Me.Label54)
        Me.grpCustInfo.Controls.Add(Me.Label55)
        Me.grpCustInfo.Controls.Add(Me.Label56)
        Me.grpCustInfo.Controls.Add(Me.Label57)
        Me.grpCustInfo.Controls.Add(Me.Label58)
        Me.grpCustInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpCustInfo.Location = New System.Drawing.Point(9, 2)
        Me.grpCustInfo.Name = "grpCustInfo"
        Me.grpCustInfo.Size = New System.Drawing.Size(292, 279)
        Me.grpCustInfo.TabIndex = 2
        Me.grpCustInfo.TabStop = False
        Me.grpCustInfo.Text = "CUSTOMER INFO"
        '
        'txtCusContact
        '
        Me.txtCusContact.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCusContact.ForeColor = System.Drawing.SystemColors.MenuText
        Me.txtCusContact.Location = New System.Drawing.Point(79, 140)
        Me.txtCusContact.Name = "txtCusContact"
        Me.txtCusContact.Size = New System.Drawing.Size(200, 20)
        Me.txtCusContact.TabIndex = 12
        '
        'txtCusAddress
        '
        Me.txtCusAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCusAddress.Location = New System.Drawing.Point(79, 60)
        Me.txtCusAddress.Name = "txtCusAddress"
        Me.txtCusAddress.Size = New System.Drawing.Size(200, 20)
        Me.txtCusAddress.TabIndex = 10
        '
        'txtCusName
        '
        Me.txtCusName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCusName.Location = New System.Drawing.Point(79, 34)
        Me.txtCusName.Name = "txtCusName"
        Me.txtCusName.Size = New System.Drawing.Size(200, 20)
        Me.txtCusName.TabIndex = 9
        '
        'cmbProvince
        '
        Me.cmbProvince.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbProvince.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbProvince.FormattingEnabled = True
        Me.cmbProvince.Location = New System.Drawing.Point(79, 86)
        Me.cmbProvince.Name = "cmbProvince"
        Me.cmbProvince.Size = New System.Drawing.Size(200, 21)
        Me.cmbProvince.TabIndex = 8
        '
        'cmbCity
        '
        Me.cmbCity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCity.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbCity.FormattingEnabled = True
        Me.cmbCity.Location = New System.Drawing.Point(79, 113)
        Me.cmbCity.Name = "cmbCity"
        Me.cmbCity.Size = New System.Drawing.Size(200, 21)
        Me.cmbCity.TabIndex = 7
        '
        'Label54
        '
        Me.Label54.AutoSize = True
        Me.Label54.BackColor = System.Drawing.SystemColors.Control
        Me.Label54.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label54.Location = New System.Drawing.Point(6, 143)
        Me.Label54.Name = "Label54"
        Me.Label54.Size = New System.Drawing.Size(67, 13)
        Me.Label54.TabIndex = 5
        Me.Label54.Text = "Contact No: "
        '
        'Label55
        '
        Me.Label55.AutoSize = True
        Me.Label55.BackColor = System.Drawing.SystemColors.Control
        Me.Label55.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label55.Location = New System.Drawing.Point(6, 89)
        Me.Label55.Name = "Label55"
        Me.Label55.Size = New System.Drawing.Size(55, 13)
        Me.Label55.TabIndex = 3
        Me.Label55.Text = "Province: "
        '
        'Label56
        '
        Me.Label56.AutoSize = True
        Me.Label56.BackColor = System.Drawing.SystemColors.Control
        Me.Label56.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label56.Location = New System.Drawing.Point(6, 116)
        Me.Label56.Name = "Label56"
        Me.Label56.Size = New System.Drawing.Size(30, 13)
        Me.Label56.TabIndex = 2
        Me.Label56.Text = "City: "
        '
        'Label57
        '
        Me.Label57.AutoSize = True
        Me.Label57.BackColor = System.Drawing.SystemColors.Control
        Me.Label57.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label57.Location = New System.Drawing.Point(6, 63)
        Me.Label57.Name = "Label57"
        Me.Label57.Size = New System.Drawing.Size(51, 13)
        Me.Label57.TabIndex = 1
        Me.Label57.Text = "Address: "
        '
        'Label58
        '
        Me.Label58.AutoSize = True
        Me.Label58.BackColor = System.Drawing.SystemColors.Control
        Me.Label58.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label58.Location = New System.Drawing.Point(6, 37)
        Me.Label58.Name = "Label58"
        Me.Label58.Size = New System.Drawing.Size(41, 13)
        Me.Label58.TabIndex = 0
        Me.Label58.Text = "Name: "
        '
        'btnRefresh
        '
        Me.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRefresh.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRefresh.Image = CType(resources.GetObject("btnRefresh.Image"), System.Drawing.Image)
        Me.btnRefresh.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnRefresh.Location = New System.Drawing.Point(12, 287)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(60, 50)
        Me.btnRefresh.TabIndex = 40
        Me.btnRefresh.Text = "Refresh"
        Me.btnRefresh.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Image = CType(resources.GetObject("btnSave.Image"), System.Drawing.Image)
        Me.btnSave.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnSave.Location = New System.Drawing.Point(241, 287)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(60, 50)
        Me.btnSave.TabIndex = 14
        Me.btnSave.Text = "Save"
        Me.btnSave.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'grpCustSearch
        '
        Me.grpCustSearch.Controls.Add(Me.rdbCustAddress)
        Me.grpCustSearch.Controls.Add(Me.rdbCustName)
        Me.grpCustSearch.Controls.Add(Me.btnCusSearch)
        Me.grpCustSearch.Controls.Add(Me.txtCusSearch)
        Me.grpCustSearch.Controls.Add(Me.Label1)
        Me.grpCustSearch.Controls.Add(Me.dgvCustomer)
        Me.grpCustSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpCustSearch.Location = New System.Drawing.Point(307, 2)
        Me.grpCustSearch.Name = "grpCustSearch"
        Me.grpCustSearch.Size = New System.Drawing.Size(494, 344)
        Me.grpCustSearch.TabIndex = 5
        Me.grpCustSearch.TabStop = False
        Me.grpCustSearch.Text = "SEARCH"
        '
        'rdbCustAddress
        '
        Me.rdbCustAddress.AutoSize = True
        Me.rdbCustAddress.Cursor = System.Windows.Forms.Cursors.Hand
        Me.rdbCustAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbCustAddress.Location = New System.Drawing.Point(151, 25)
        Me.rdbCustAddress.Name = "rdbCustAddress"
        Me.rdbCustAddress.Size = New System.Drawing.Size(63, 17)
        Me.rdbCustAddress.TabIndex = 50
        Me.rdbCustAddress.Text = "Address"
        Me.rdbCustAddress.UseVisualStyleBackColor = True
        '
        'rdbCustName
        '
        Me.rdbCustName.AutoSize = True
        Me.rdbCustName.Cursor = System.Windows.Forms.Cursors.Hand
        Me.rdbCustName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbCustName.Location = New System.Drawing.Point(24, 25)
        Me.rdbCustName.Name = "rdbCustName"
        Me.rdbCustName.Size = New System.Drawing.Size(100, 17)
        Me.rdbCustName.TabIndex = 49
        Me.rdbCustName.Text = "Customer Name"
        Me.rdbCustName.UseVisualStyleBackColor = True
        '
        'btnCusSearch
        '
        Me.btnCusSearch.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCusSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCusSearch.Image = CType(resources.GetObject("btnCusSearch.Image"), System.Drawing.Image)
        Me.btnCusSearch.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnCusSearch.Location = New System.Drawing.Point(418, 14)
        Me.btnCusSearch.Name = "btnCusSearch"
        Me.btnCusSearch.Padding = New System.Windows.Forms.Padding(0, 2, 0, 0)
        Me.btnCusSearch.Size = New System.Drawing.Size(70, 55)
        Me.btnCusSearch.TabIndex = 48
        Me.btnCusSearch.Text = "Search"
        Me.btnCusSearch.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnCusSearch.UseVisualStyleBackColor = True
        '
        'txtCusSearch
        '
        Me.txtCusSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCusSearch.Location = New System.Drawing.Point(67, 48)
        Me.txtCusSearch.Name = "txtCusSearch"
        Me.txtCusSearch.Size = New System.Drawing.Size(250, 20)
        Me.txtCusSearch.TabIndex = 47
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(10, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 13)
        Me.Label1.TabIndex = 46
        Me.Label1.Text = "Keyword:"
        '
        'dgvCustomer
        '
        Me.dgvCustomer.AllowUserToResizeRows = False
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Gray
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvCustomer.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvCustomer.Location = New System.Drawing.Point(6, 74)
        Me.dgvCustomer.MultiSelect = False
        Me.dgvCustomer.Name = "dgvCustomer"
        Me.dgvCustomer.ReadOnly = True
        Me.dgvCustomer.RowHeadersVisible = False
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Gray
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White
        Me.dgvCustomer.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvCustomer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvCustomer.Size = New System.Drawing.Size(488, 261)
        Me.dgvCustomer.TabIndex = 27
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Control
        Me.Panel1.Controls.Add(Me.btnSave)
        Me.Panel1.Controls.Add(Me.grpCustSearch)
        Me.Panel1.Controls.Add(Me.grpCustInfo)
        Me.Panel1.Controls.Add(Me.btnRefresh)
        Me.Panel1.Location = New System.Drawing.Point(0, 31)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(804, 349)
        Me.Panel1.TabIndex = 41
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.DodgerBlue
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(804, 25)
        Me.Panel2.TabIndex = 42
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.DodgerBlue
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(0, 386)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(804, 25)
        Me.Panel3.TabIndex = 43
        '
        'customerUpdate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.ClientSize = New System.Drawing.Size(804, 411)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "customerUpdate"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Update Customer Record"
        Me.grpCustInfo.ResumeLayout(False)
        Me.grpCustInfo.PerformLayout()
        Me.grpCustSearch.ResumeLayout(False)
        Me.grpCustSearch.PerformLayout()
        CType(Me.dgvCustomer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grpCustInfo As GroupBox
    Friend WithEvents btnSave As Button
    Friend WithEvents txtCusContact As TextBox
    Friend WithEvents txtCusAddress As TextBox
    Friend WithEvents txtCusName As TextBox
    Friend WithEvents cmbProvince As ComboBox
    Friend WithEvents cmbCity As ComboBox
    Friend WithEvents Label54 As Label
    Friend WithEvents Label55 As Label
    Friend WithEvents Label56 As Label
    Friend WithEvents Label57 As Label
    Friend WithEvents Label58 As Label
    Friend WithEvents grpCustSearch As GroupBox
    Friend WithEvents dgvCustomer As DataGridView
    Friend WithEvents btnRefresh As Button
    Friend WithEvents rdbCustAddress As RadioButton
    Friend WithEvents rdbCustName As RadioButton
    Friend WithEvents btnCusSearch As Button
    Friend WithEvents txtCusSearch As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
End Class
