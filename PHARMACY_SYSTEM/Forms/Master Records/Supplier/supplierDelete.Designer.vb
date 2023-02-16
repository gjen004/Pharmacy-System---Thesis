<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class supplierDelete
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(supplierDelete))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupBox10 = New System.Windows.Forms.GroupBox()
        Me.rdbSuppProvince = New System.Windows.Forms.RadioButton()
        Me.rdbSuppName = New System.Windows.Forms.RadioButton()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.dgvSupplier = New System.Windows.Forms.DataGridView()
        Me.btnSuppSearch = New System.Windows.Forms.Button()
        Me.txtSuppSearch = New System.Windows.Forms.TextBox()
        Me.Label52 = New System.Windows.Forms.Label()
        Me.btnSuppDelete = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.GroupBox10.SuspendLayout()
        CType(Me.dgvSupplier, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox10
        '
        Me.GroupBox10.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox10.Controls.Add(Me.rdbSuppProvince)
        Me.GroupBox10.Controls.Add(Me.rdbSuppName)
        Me.GroupBox10.Controls.Add(Me.btnRefresh)
        Me.GroupBox10.Controls.Add(Me.dgvSupplier)
        Me.GroupBox10.Controls.Add(Me.btnSuppSearch)
        Me.GroupBox10.Controls.Add(Me.txtSuppSearch)
        Me.GroupBox10.Controls.Add(Me.Label52)
        Me.GroupBox10.Controls.Add(Me.btnSuppDelete)
        Me.GroupBox10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox10.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox10.Name = "GroupBox10"
        Me.GroupBox10.Size = New System.Drawing.Size(634, 399)
        Me.GroupBox10.TabIndex = 6
        Me.GroupBox10.TabStop = False
        Me.GroupBox10.Text = "SUPPLIER LIST"
        '
        'rdbSuppProvince
        '
        Me.rdbSuppProvince.AutoSize = True
        Me.rdbSuppProvince.Cursor = System.Windows.Forms.Cursors.Hand
        Me.rdbSuppProvince.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbSuppProvince.Location = New System.Drawing.Point(137, 25)
        Me.rdbSuppProvince.Name = "rdbSuppProvince"
        Me.rdbSuppProvince.Size = New System.Drawing.Size(63, 17)
        Me.rdbSuppProvince.TabIndex = 41
        Me.rdbSuppProvince.Text = "Address"
        Me.rdbSuppProvince.UseVisualStyleBackColor = True
        '
        'rdbSuppName
        '
        Me.rdbSuppName.AutoSize = True
        Me.rdbSuppName.Cursor = System.Windows.Forms.Cursors.Hand
        Me.rdbSuppName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbSuppName.Location = New System.Drawing.Point(10, 25)
        Me.rdbSuppName.Name = "rdbSuppName"
        Me.rdbSuppName.Size = New System.Drawing.Size(94, 17)
        Me.rdbSuppName.TabIndex = 1
        Me.rdbSuppName.Text = "Supplier Name"
        Me.rdbSuppName.UseVisualStyleBackColor = True
        '
        'btnRefresh
        '
        Me.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRefresh.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRefresh.Image = CType(resources.GetObject("btnRefresh.Image"), System.Drawing.Image)
        Me.btnRefresh.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnRefresh.Location = New System.Drawing.Point(482, 13)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Padding = New System.Windows.Forms.Padding(0, 2, 0, 0)
        Me.btnRefresh.Size = New System.Drawing.Size(70, 55)
        Me.btnRefresh.TabIndex = 5
        Me.btnRefresh.Text = "Refresh"
        Me.btnRefresh.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'dgvSupplier
        '
        Me.dgvSupplier.AllowUserToResizeRows = False
        Me.dgvSupplier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvSupplier.Location = New System.Drawing.Point(6, 74)
        Me.dgvSupplier.MultiSelect = False
        Me.dgvSupplier.Name = "dgvSupplier"
        Me.dgvSupplier.ReadOnly = True
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Gray
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvSupplier.RowHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvSupplier.RowHeadersVisible = False
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Gray
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        Me.dgvSupplier.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvSupplier.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvSupplier.Size = New System.Drawing.Size(622, 313)
        Me.dgvSupplier.TabIndex = 27
        '
        'btnSuppSearch
        '
        Me.btnSuppSearch.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSuppSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSuppSearch.Image = CType(resources.GetObject("btnSuppSearch.Image"), System.Drawing.Image)
        Me.btnSuppSearch.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnSuppSearch.Location = New System.Drawing.Point(406, 13)
        Me.btnSuppSearch.Name = "btnSuppSearch"
        Me.btnSuppSearch.Padding = New System.Windows.Forms.Padding(0, 2, 0, 0)
        Me.btnSuppSearch.Size = New System.Drawing.Size(70, 55)
        Me.btnSuppSearch.TabIndex = 3
        Me.btnSuppSearch.Text = "Search"
        Me.btnSuppSearch.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSuppSearch.UseVisualStyleBackColor = True
        '
        'txtSuppSearch
        '
        Me.txtSuppSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSuppSearch.Location = New System.Drawing.Point(64, 48)
        Me.txtSuppSearch.Name = "txtSuppSearch"
        Me.txtSuppSearch.Size = New System.Drawing.Size(250, 20)
        Me.txtSuppSearch.TabIndex = 2
        '
        'Label52
        '
        Me.Label52.AutoSize = True
        Me.Label52.BackColor = System.Drawing.SystemColors.Control
        Me.Label52.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label52.Location = New System.Drawing.Point(7, 51)
        Me.Label52.Name = "Label52"
        Me.Label52.Size = New System.Drawing.Size(51, 13)
        Me.Label52.TabIndex = 24
        Me.Label52.Text = "Keyword:"
        '
        'btnSuppDelete
        '
        Me.btnSuppDelete.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSuppDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSuppDelete.Image = CType(resources.GetObject("btnSuppDelete.Image"), System.Drawing.Image)
        Me.btnSuppDelete.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnSuppDelete.Location = New System.Drawing.Point(558, 13)
        Me.btnSuppDelete.Name = "btnSuppDelete"
        Me.btnSuppDelete.Padding = New System.Windows.Forms.Padding(0, 2, 0, 0)
        Me.btnSuppDelete.Size = New System.Drawing.Size(70, 55)
        Me.btnSuppDelete.TabIndex = 4
        Me.btnSuppDelete.Text = "Delete"
        Me.btnSuppDelete.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSuppDelete.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.GroupBox10)
        Me.Panel1.Location = New System.Drawing.Point(0, 31)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(634, 399)
        Me.Panel1.TabIndex = 7
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.DodgerBlue
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(634, 25)
        Me.Panel2.TabIndex = 8
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.DodgerBlue
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(0, 436)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(634, 25)
        Me.Panel3.TabIndex = 9
        '
        'supplierDelete
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.ClientSize = New System.Drawing.Size(634, 461)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "supplierDelete"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Delete Supplier Record"
        Me.GroupBox10.ResumeLayout(False)
        Me.GroupBox10.PerformLayout()
        CType(Me.dgvSupplier, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox10 As GroupBox
    Friend WithEvents dgvSupplier As DataGridView
    Friend WithEvents btnSuppSearch As Button
    Friend WithEvents txtSuppSearch As TextBox
    Friend WithEvents Label52 As Label
    Friend WithEvents btnSuppDelete As Button
    Friend WithEvents btnRefresh As Button
    Friend WithEvents rdbSuppProvince As RadioButton
    Friend WithEvents rdbSuppName As RadioButton
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
End Class
