<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class supplierAdd
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(supplierAdd))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.grpSuppInfo = New System.Windows.Forms.GroupBox()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.btnSuppAdd = New System.Windows.Forms.Button()
        Me.txtSuppTin = New System.Windows.Forms.TextBox()
        Me.txtSuppContact = New System.Windows.Forms.TextBox()
        Me.txtSuppContactPerson = New System.Windows.Forms.TextBox()
        Me.txtSuppAddress = New System.Windows.Forms.TextBox()
        Me.txtSuppName = New System.Windows.Forms.TextBox()
        Me.cmbSuppProvince = New System.Windows.Forms.ComboBox()
        Me.cmbCity = New System.Windows.Forms.ComboBox()
        Me.Label60 = New System.Windows.Forms.Label()
        Me.Label61 = New System.Windows.Forms.Label()
        Me.Label62 = New System.Windows.Forms.Label()
        Me.Label63 = New System.Windows.Forms.Label()
        Me.Label64 = New System.Windows.Forms.Label()
        Me.Label65 = New System.Windows.Forms.Label()
        Me.Label66 = New System.Windows.Forms.Label()
        Me.GroupBox14 = New System.Windows.Forms.GroupBox()
        Me.rdbSuppProvince = New System.Windows.Forms.RadioButton()
        Me.rdbSuppName = New System.Windows.Forms.RadioButton()
        Me.dgvSupplier = New System.Windows.Forms.DataGridView()
        Me.btnSuppSearch = New System.Windows.Forms.Button()
        Me.Label59 = New System.Windows.Forms.Label()
        Me.txtSuppSearch = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.grpSuppInfo.SuspendLayout()
        Me.GroupBox14.SuspendLayout()
        CType(Me.dgvSupplier, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpSuppInfo
        '
        Me.grpSuppInfo.Controls.Add(Me.btnRefresh)
        Me.grpSuppInfo.Controls.Add(Me.btnSuppAdd)
        Me.grpSuppInfo.Controls.Add(Me.txtSuppTin)
        Me.grpSuppInfo.Controls.Add(Me.txtSuppContact)
        Me.grpSuppInfo.Controls.Add(Me.txtSuppContactPerson)
        Me.grpSuppInfo.Controls.Add(Me.txtSuppAddress)
        Me.grpSuppInfo.Controls.Add(Me.txtSuppName)
        Me.grpSuppInfo.Controls.Add(Me.cmbSuppProvince)
        Me.grpSuppInfo.Controls.Add(Me.cmbCity)
        Me.grpSuppInfo.Controls.Add(Me.Label60)
        Me.grpSuppInfo.Controls.Add(Me.Label61)
        Me.grpSuppInfo.Controls.Add(Me.Label62)
        Me.grpSuppInfo.Controls.Add(Me.Label63)
        Me.grpSuppInfo.Controls.Add(Me.Label64)
        Me.grpSuppInfo.Controls.Add(Me.Label65)
        Me.grpSuppInfo.Controls.Add(Me.Label66)
        Me.grpSuppInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpSuppInfo.Location = New System.Drawing.Point(3, 3)
        Me.grpSuppInfo.Name = "grpSuppInfo"
        Me.grpSuppInfo.Size = New System.Drawing.Size(310, 343)
        Me.grpSuppInfo.TabIndex = 1
        Me.grpSuppInfo.TabStop = False
        Me.grpSuppInfo.Text = "SUPPLIER INFO"
        '
        'btnRefresh
        '
        Me.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRefresh.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRefresh.Image = CType(resources.GetObject("btnRefresh.Image"), System.Drawing.Image)
        Me.btnRefresh.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnRefresh.Location = New System.Drawing.Point(6, 282)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Padding = New System.Windows.Forms.Padding(0, 2, 0, 0)
        Me.btnRefresh.Size = New System.Drawing.Size(70, 55)
        Me.btnRefresh.TabIndex = 9
        Me.btnRefresh.Text = "Refresh"
        Me.btnRefresh.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'btnSuppAdd
        '
        Me.btnSuppAdd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSuppAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSuppAdd.Image = CType(resources.GetObject("btnSuppAdd.Image"), System.Drawing.Image)
        Me.btnSuppAdd.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnSuppAdd.Location = New System.Drawing.Point(234, 282)
        Me.btnSuppAdd.Name = "btnSuppAdd"
        Me.btnSuppAdd.Padding = New System.Windows.Forms.Padding(0, 2, 0, 0)
        Me.btnSuppAdd.Size = New System.Drawing.Size(70, 55)
        Me.btnSuppAdd.TabIndex = 8
        Me.btnSuppAdd.Text = "Add"
        Me.btnSuppAdd.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSuppAdd.UseVisualStyleBackColor = True
        '
        'txtSuppTin
        '
        Me.txtSuppTin.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSuppTin.Location = New System.Drawing.Point(98, 196)
        Me.txtSuppTin.Name = "txtSuppTin"
        Me.txtSuppTin.Size = New System.Drawing.Size(200, 20)
        Me.txtSuppTin.TabIndex = 7
        '
        'txtSuppContact
        '
        Me.txtSuppContact.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSuppContact.Location = New System.Drawing.Point(98, 144)
        Me.txtSuppContact.Name = "txtSuppContact"
        Me.txtSuppContact.Size = New System.Drawing.Size(200, 20)
        Me.txtSuppContact.TabIndex = 5
        '
        'txtSuppContactPerson
        '
        Me.txtSuppContactPerson.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSuppContactPerson.Location = New System.Drawing.Point(98, 170)
        Me.txtSuppContactPerson.Name = "txtSuppContactPerson"
        Me.txtSuppContactPerson.Size = New System.Drawing.Size(200, 20)
        Me.txtSuppContactPerson.TabIndex = 6
        '
        'txtSuppAddress
        '
        Me.txtSuppAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSuppAddress.Location = New System.Drawing.Point(97, 64)
        Me.txtSuppAddress.Name = "txtSuppAddress"
        Me.txtSuppAddress.Size = New System.Drawing.Size(200, 20)
        Me.txtSuppAddress.TabIndex = 2
        '
        'txtSuppName
        '
        Me.txtSuppName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSuppName.Location = New System.Drawing.Point(97, 38)
        Me.txtSuppName.Name = "txtSuppName"
        Me.txtSuppName.Size = New System.Drawing.Size(200, 20)
        Me.txtSuppName.TabIndex = 1
        '
        'cmbSuppProvince
        '
        Me.cmbSuppProvince.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSuppProvince.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbSuppProvince.FormattingEnabled = True
        Me.cmbSuppProvince.Location = New System.Drawing.Point(97, 90)
        Me.cmbSuppProvince.Name = "cmbSuppProvince"
        Me.cmbSuppProvince.Size = New System.Drawing.Size(200, 21)
        Me.cmbSuppProvince.TabIndex = 3
        '
        'cmbCity
        '
        Me.cmbCity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCity.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbCity.FormattingEnabled = True
        Me.cmbCity.Location = New System.Drawing.Point(97, 117)
        Me.cmbCity.Name = "cmbCity"
        Me.cmbCity.Size = New System.Drawing.Size(200, 21)
        Me.cmbCity.TabIndex = 4
        '
        'Label60
        '
        Me.Label60.AutoSize = True
        Me.Label60.BackColor = System.Drawing.SystemColors.Control
        Me.Label60.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label60.Location = New System.Drawing.Point(6, 199)
        Me.Label60.Name = "Label60"
        Me.Label60.Size = New System.Drawing.Size(45, 13)
        Me.Label60.TabIndex = 6
        Me.Label60.Text = "Tin No: "
        '
        'Label61
        '
        Me.Label61.AutoSize = True
        Me.Label61.BackColor = System.Drawing.SystemColors.Control
        Me.Label61.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label61.Location = New System.Drawing.Point(6, 147)
        Me.Label61.Name = "Label61"
        Me.Label61.Size = New System.Drawing.Size(67, 13)
        Me.Label61.TabIndex = 5
        Me.Label61.Text = "Contact No: "
        '
        'Label62
        '
        Me.Label62.AutoSize = True
        Me.Label62.BackColor = System.Drawing.SystemColors.Control
        Me.Label62.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label62.Location = New System.Drawing.Point(6, 173)
        Me.Label62.Name = "Label62"
        Me.Label62.Size = New System.Drawing.Size(86, 13)
        Me.Label62.TabIndex = 4
        Me.Label62.Text = "Contact Person: "
        '
        'Label63
        '
        Me.Label63.AutoSize = True
        Me.Label63.BackColor = System.Drawing.SystemColors.Control
        Me.Label63.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label63.Location = New System.Drawing.Point(6, 93)
        Me.Label63.Name = "Label63"
        Me.Label63.Size = New System.Drawing.Size(55, 13)
        Me.Label63.TabIndex = 3
        Me.Label63.Text = "Province: "
        '
        'Label64
        '
        Me.Label64.AutoSize = True
        Me.Label64.BackColor = System.Drawing.SystemColors.Control
        Me.Label64.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label64.Location = New System.Drawing.Point(6, 120)
        Me.Label64.Name = "Label64"
        Me.Label64.Size = New System.Drawing.Size(30, 13)
        Me.Label64.TabIndex = 2
        Me.Label64.Text = "City: "
        '
        'Label65
        '
        Me.Label65.AutoSize = True
        Me.Label65.BackColor = System.Drawing.SystemColors.Control
        Me.Label65.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label65.Location = New System.Drawing.Point(6, 67)
        Me.Label65.Name = "Label65"
        Me.Label65.Size = New System.Drawing.Size(51, 13)
        Me.Label65.TabIndex = 1
        Me.Label65.Text = "Address: "
        '
        'Label66
        '
        Me.Label66.AutoSize = True
        Me.Label66.BackColor = System.Drawing.SystemColors.Control
        Me.Label66.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label66.Location = New System.Drawing.Point(6, 41)
        Me.Label66.Name = "Label66"
        Me.Label66.Size = New System.Drawing.Size(41, 13)
        Me.Label66.TabIndex = 0
        Me.Label66.Text = "Name: "
        '
        'GroupBox14
        '
        Me.GroupBox14.Controls.Add(Me.rdbSuppProvince)
        Me.GroupBox14.Controls.Add(Me.rdbSuppName)
        Me.GroupBox14.Controls.Add(Me.dgvSupplier)
        Me.GroupBox14.Controls.Add(Me.btnSuppSearch)
        Me.GroupBox14.Controls.Add(Me.Label59)
        Me.GroupBox14.Controls.Add(Me.txtSuppSearch)
        Me.GroupBox14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox14.Location = New System.Drawing.Point(319, 3)
        Me.GroupBox14.Name = "GroupBox14"
        Me.GroupBox14.Size = New System.Drawing.Size(583, 343)
        Me.GroupBox14.TabIndex = 2
        Me.GroupBox14.TabStop = False
        Me.GroupBox14.Text = "SEARCH"
        '
        'rdbSuppProvince
        '
        Me.rdbSuppProvince.AutoSize = True
        Me.rdbSuppProvince.Cursor = System.Windows.Forms.Cursors.Hand
        Me.rdbSuppProvince.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbSuppProvince.Location = New System.Drawing.Point(148, 25)
        Me.rdbSuppProvince.Name = "rdbSuppProvince"
        Me.rdbSuppProvince.Size = New System.Drawing.Size(63, 17)
        Me.rdbSuppProvince.TabIndex = 25
        Me.rdbSuppProvince.Text = "Address"
        Me.rdbSuppProvince.UseVisualStyleBackColor = True
        '
        'rdbSuppName
        '
        Me.rdbSuppName.AutoSize = True
        Me.rdbSuppName.Cursor = System.Windows.Forms.Cursors.Hand
        Me.rdbSuppName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbSuppName.Location = New System.Drawing.Point(21, 25)
        Me.rdbSuppName.Name = "rdbSuppName"
        Me.rdbSuppName.Size = New System.Drawing.Size(94, 17)
        Me.rdbSuppName.TabIndex = 10
        Me.rdbSuppName.Text = "Supplier Name"
        Me.rdbSuppName.UseVisualStyleBackColor = True
        '
        'dgvSupplier
        '
        Me.dgvSupplier.AllowUserToResizeRows = False
        Me.dgvSupplier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvSupplier.Location = New System.Drawing.Point(6, 74)
        Me.dgvSupplier.MultiSelect = False
        Me.dgvSupplier.Name = "dgvSupplier"
        Me.dgvSupplier.ReadOnly = True
        Me.dgvSupplier.RowHeadersVisible = False
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Gray
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        Me.dgvSupplier.RowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvSupplier.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvSupplier.Size = New System.Drawing.Size(571, 263)
        Me.dgvSupplier.TabIndex = 13
        '
        'btnSuppSearch
        '
        Me.btnSuppSearch.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSuppSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSuppSearch.Image = CType(resources.GetObject("btnSuppSearch.Image"), System.Drawing.Image)
        Me.btnSuppSearch.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnSuppSearch.Location = New System.Drawing.Point(507, 13)
        Me.btnSuppSearch.Name = "btnSuppSearch"
        Me.btnSuppSearch.Padding = New System.Windows.Forms.Padding(0, 2, 0, 0)
        Me.btnSuppSearch.Size = New System.Drawing.Size(70, 55)
        Me.btnSuppSearch.TabIndex = 12
        Me.btnSuppSearch.Text = "Search"
        Me.btnSuppSearch.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSuppSearch.UseVisualStyleBackColor = True
        '
        'Label59
        '
        Me.Label59.AutoSize = True
        Me.Label59.BackColor = System.Drawing.SystemColors.Control
        Me.Label59.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label59.Location = New System.Drawing.Point(2, 51)
        Me.Label59.Name = "Label59"
        Me.Label59.Size = New System.Drawing.Size(51, 13)
        Me.Label59.TabIndex = 11
        Me.Label59.Text = "Keyword:"
        '
        'txtSuppSearch
        '
        Me.txtSuppSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSuppSearch.Location = New System.Drawing.Point(59, 48)
        Me.txtSuppSearch.Name = "txtSuppSearch"
        Me.txtSuppSearch.Size = New System.Drawing.Size(250, 20)
        Me.txtSuppSearch.TabIndex = 11
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Panel1.Controls.Add(Me.grpSuppInfo)
        Me.Panel1.Controls.Add(Me.GroupBox14)
        Me.Panel1.Location = New System.Drawing.Point(-1, 31)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(905, 349)
        Me.Panel1.TabIndex = 3
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.DodgerBlue
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(904, 25)
        Me.Panel2.TabIndex = 6
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.DodgerBlue
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(0, 386)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(904, 25)
        Me.Panel3.TabIndex = 7
        '
        'supplierAdd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.ClientSize = New System.Drawing.Size(904, 411)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "supplierAdd"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "New Supplier Record"
        Me.grpSuppInfo.ResumeLayout(False)
        Me.grpSuppInfo.PerformLayout()
        Me.GroupBox14.ResumeLayout(False)
        Me.GroupBox14.PerformLayout()
        CType(Me.dgvSupplier, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grpSuppInfo As GroupBox
    Friend WithEvents btnRefresh As Button
    Friend WithEvents btnSuppAdd As Button
    Friend WithEvents txtSuppTin As TextBox
    Friend WithEvents txtSuppContact As TextBox
    Friend WithEvents txtSuppContactPerson As TextBox
    Friend WithEvents txtSuppAddress As TextBox
    Friend WithEvents txtSuppName As TextBox
    Friend WithEvents cmbSuppProvince As ComboBox
    Friend WithEvents cmbCity As ComboBox
    Friend WithEvents Label60 As Label
    Friend WithEvents Label61 As Label
    Friend WithEvents Label62 As Label
    Friend WithEvents Label63 As Label
    Friend WithEvents Label64 As Label
    Friend WithEvents Label65 As Label
    Friend WithEvents Label66 As Label
    Friend WithEvents GroupBox14 As GroupBox
    Friend WithEvents dgvSupplier As DataGridView
    Friend WithEvents btnSuppSearch As Button
    Friend WithEvents Label59 As Label
    Friend WithEvents txtSuppSearch As TextBox
    Friend WithEvents rdbSuppProvince As RadioButton
    Friend WithEvents rdbSuppName As RadioButton
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
End Class
