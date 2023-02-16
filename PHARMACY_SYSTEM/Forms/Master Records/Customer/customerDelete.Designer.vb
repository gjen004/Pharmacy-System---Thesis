<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class customerDelete
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(customerDelete))
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupBox10 = New System.Windows.Forms.GroupBox()
        Me.rdbCustAddress = New System.Windows.Forms.RadioButton()
        Me.rdbCustName = New System.Windows.Forms.RadioButton()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.dgvCustomer = New System.Windows.Forms.DataGridView()
        Me.btnCusSearch = New System.Windows.Forms.Button()
        Me.txtCusSearch = New System.Windows.Forms.TextBox()
        Me.Label52 = New System.Windows.Forms.Label()
        Me.btnCusDelete = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.GroupBox10.SuspendLayout()
        CType(Me.dgvCustomer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox10
        '
        Me.GroupBox10.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox10.Controls.Add(Me.rdbCustAddress)
        Me.GroupBox10.Controls.Add(Me.rdbCustName)
        Me.GroupBox10.Controls.Add(Me.btnRefresh)
        Me.GroupBox10.Controls.Add(Me.dgvCustomer)
        Me.GroupBox10.Controls.Add(Me.btnCusSearch)
        Me.GroupBox10.Controls.Add(Me.txtCusSearch)
        Me.GroupBox10.Controls.Add(Me.Label52)
        Me.GroupBox10.Controls.Add(Me.btnCusDelete)
        Me.GroupBox10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox10.Location = New System.Drawing.Point(0, 3)
        Me.GroupBox10.Name = "GroupBox10"
        Me.GroupBox10.Size = New System.Drawing.Size(604, 393)
        Me.GroupBox10.TabIndex = 6
        Me.GroupBox10.TabStop = False
        Me.GroupBox10.Text = "CUSTOMER RECORDS"
        '
        'rdbCustAddress
        '
        Me.rdbCustAddress.AutoSize = True
        Me.rdbCustAddress.Cursor = System.Windows.Forms.Cursors.Hand
        Me.rdbCustAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbCustAddress.Location = New System.Drawing.Point(158, 23)
        Me.rdbCustAddress.Name = "rdbCustAddress"
        Me.rdbCustAddress.Size = New System.Drawing.Size(63, 17)
        Me.rdbCustAddress.TabIndex = 45
        Me.rdbCustAddress.Text = "Address"
        Me.rdbCustAddress.UseVisualStyleBackColor = True
        '
        'rdbCustName
        '
        Me.rdbCustName.AutoSize = True
        Me.rdbCustName.Cursor = System.Windows.Forms.Cursors.Hand
        Me.rdbCustName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbCustName.Location = New System.Drawing.Point(31, 23)
        Me.rdbCustName.Name = "rdbCustName"
        Me.rdbCustName.Size = New System.Drawing.Size(100, 17)
        Me.rdbCustName.TabIndex = 1
        Me.rdbCustName.Text = "Customer Name"
        Me.rdbCustName.UseVisualStyleBackColor = True
        '
        'btnRefresh
        '
        Me.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRefresh.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRefresh.Image = CType(resources.GetObject("btnRefresh.Image"), System.Drawing.Image)
        Me.btnRefresh.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnRefresh.Location = New System.Drawing.Point(452, 13)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Padding = New System.Windows.Forms.Padding(0, 2, 0, 0)
        Me.btnRefresh.Size = New System.Drawing.Size(70, 55)
        Me.btnRefresh.TabIndex = 4
        Me.btnRefresh.Text = "Refresh"
        Me.btnRefresh.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnRefresh.UseVisualStyleBackColor = True
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
        Me.dgvCustomer.Size = New System.Drawing.Size(592, 313)
        Me.dgvCustomer.TabIndex = 27
        '
        'btnCusSearch
        '
        Me.btnCusSearch.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCusSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCusSearch.Image = CType(resources.GetObject("btnCusSearch.Image"), System.Drawing.Image)
        Me.btnCusSearch.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnCusSearch.Location = New System.Drawing.Point(376, 13)
        Me.btnCusSearch.Name = "btnCusSearch"
        Me.btnCusSearch.Padding = New System.Windows.Forms.Padding(0, 2, 0, 0)
        Me.btnCusSearch.Size = New System.Drawing.Size(70, 55)
        Me.btnCusSearch.TabIndex = 3
        Me.btnCusSearch.Text = "Search"
        Me.btnCusSearch.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnCusSearch.UseVisualStyleBackColor = True
        '
        'txtCusSearch
        '
        Me.txtCusSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCusSearch.Location = New System.Drawing.Point(64, 48)
        Me.txtCusSearch.Name = "txtCusSearch"
        Me.txtCusSearch.Size = New System.Drawing.Size(250, 20)
        Me.txtCusSearch.TabIndex = 2
        '
        'Label52
        '
        Me.Label52.AutoSize = True
        Me.Label52.BackColor = System.Drawing.SystemColors.Control
        Me.Label52.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label52.Location = New System.Drawing.Point(7, 52)
        Me.Label52.Name = "Label52"
        Me.Label52.Size = New System.Drawing.Size(51, 13)
        Me.Label52.TabIndex = 24
        Me.Label52.Text = "Keyword:"
        '
        'btnCusDelete
        '
        Me.btnCusDelete.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCusDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCusDelete.Image = CType(resources.GetObject("btnCusDelete.Image"), System.Drawing.Image)
        Me.btnCusDelete.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnCusDelete.Location = New System.Drawing.Point(528, 13)
        Me.btnCusDelete.Name = "btnCusDelete"
        Me.btnCusDelete.Padding = New System.Windows.Forms.Padding(0, 2, 0, 0)
        Me.btnCusDelete.Size = New System.Drawing.Size(70, 55)
        Me.btnCusDelete.TabIndex = 5
        Me.btnCusDelete.Text = "Delete"
        Me.btnCusDelete.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnCusDelete.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Control
        Me.Panel1.Controls.Add(Me.GroupBox10)
        Me.Panel1.Location = New System.Drawing.Point(0, 31)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(604, 399)
        Me.Panel1.TabIndex = 7
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.DodgerBlue
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(604, 25)
        Me.Panel2.TabIndex = 8
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.DodgerBlue
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(0, 436)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(604, 25)
        Me.Panel3.TabIndex = 9
        '
        'customerDelete
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.ClientSize = New System.Drawing.Size(604, 461)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "customerDelete"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Delete Customer Record"
        Me.GroupBox10.ResumeLayout(False)
        Me.GroupBox10.PerformLayout()
        CType(Me.dgvCustomer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox10 As GroupBox
    Friend WithEvents dgvCustomer As DataGridView
    Friend WithEvents btnCusSearch As Button
    Friend WithEvents txtCusSearch As TextBox
    Friend WithEvents Label52 As Label
    Friend WithEvents btnCusDelete As Button
    Friend WithEvents btnRefresh As Button
    Friend WithEvents rdbCustAddress As RadioButton
    Friend WithEvents rdbCustName As RadioButton
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
End Class
