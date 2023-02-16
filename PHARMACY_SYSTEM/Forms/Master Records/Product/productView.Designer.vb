<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class productView
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(productView))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.grpProdList = New System.Windows.Forms.GroupBox()
        Me.rdbProdBrandName = New System.Windows.Forms.RadioButton()
        Me.rdbProdCode = New System.Windows.Forms.RadioButton()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.Label52 = New System.Windows.Forms.Label()
        Me.txtProdSearch = New System.Windows.Forms.TextBox()
        Me.btnProdSearch = New System.Windows.Forms.Button()
        Me.dgvProduct = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.grpProdList.SuspendLayout()
        CType(Me.dgvProduct, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpProdList
        '
        Me.grpProdList.Controls.Add(Me.rdbProdBrandName)
        Me.grpProdList.Controls.Add(Me.rdbProdCode)
        Me.grpProdList.Controls.Add(Me.btnRefresh)
        Me.grpProdList.Controls.Add(Me.Label52)
        Me.grpProdList.Controls.Add(Me.txtProdSearch)
        Me.grpProdList.Controls.Add(Me.btnProdSearch)
        Me.grpProdList.Controls.Add(Me.dgvProduct)
        Me.grpProdList.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpProdList.ForeColor = System.Drawing.Color.Black
        Me.grpProdList.Location = New System.Drawing.Point(2, 3)
        Me.grpProdList.Name = "grpProdList"
        Me.grpProdList.Size = New System.Drawing.Size(779, 512)
        Me.grpProdList.TabIndex = 1
        Me.grpProdList.TabStop = False
        Me.grpProdList.Text = "PRODUCT LIST"
        '
        'rdbProdBrandName
        '
        Me.rdbProdBrandName.AutoSize = True
        Me.rdbProdBrandName.Cursor = System.Windows.Forms.Cursors.Hand
        Me.rdbProdBrandName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbProdBrandName.Location = New System.Drawing.Point(166, 19)
        Me.rdbProdBrandName.Name = "rdbProdBrandName"
        Me.rdbProdBrandName.Size = New System.Drawing.Size(84, 17)
        Me.rdbProdBrandName.TabIndex = 31
        Me.rdbProdBrandName.Text = "Brand Name"
        Me.rdbProdBrandName.UseVisualStyleBackColor = True
        '
        'rdbProdCode
        '
        Me.rdbProdCode.AutoSize = True
        Me.rdbProdCode.Cursor = System.Windows.Forms.Cursors.Hand
        Me.rdbProdCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbProdCode.Location = New System.Drawing.Point(39, 19)
        Me.rdbProdCode.Name = "rdbProdCode"
        Me.rdbProdCode.Size = New System.Drawing.Size(90, 17)
        Me.rdbProdCode.TabIndex = 30
        Me.rdbProdCode.Text = "Product Code"
        Me.rdbProdCode.UseVisualStyleBackColor = True
        '
        'btnRefresh
        '
        Me.btnRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRefresh.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnRefresh.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRefresh.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnRefresh.Image = CType(resources.GetObject("btnRefresh.Image"), System.Drawing.Image)
        Me.btnRefresh.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnRefresh.Location = New System.Drawing.Point(703, 12)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Padding = New System.Windows.Forms.Padding(0, 2, 0, 0)
        Me.btnRefresh.Size = New System.Drawing.Size(70, 55)
        Me.btnRefresh.TabIndex = 29
        Me.btnRefresh.Text = "Refresh"
        Me.btnRefresh.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'Label52
        '
        Me.Label52.AutoSize = True
        Me.Label52.BackColor = System.Drawing.SystemColors.Control
        Me.Label52.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label52.Location = New System.Drawing.Point(7, 50)
        Me.Label52.Name = "Label52"
        Me.Label52.Size = New System.Drawing.Size(51, 13)
        Me.Label52.TabIndex = 28
        Me.Label52.Text = "Keyword:"
        '
        'txtProdSearch
        '
        Me.txtProdSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProdSearch.Location = New System.Drawing.Point(68, 47)
        Me.txtProdSearch.Name = "txtProdSearch"
        Me.txtProdSearch.Size = New System.Drawing.Size(250, 20)
        Me.txtProdSearch.TabIndex = 27
        '
        'btnProdSearch
        '
        Me.btnProdSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProdSearch.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnProdSearch.Image = CType(resources.GetObject("btnProdSearch.Image"), System.Drawing.Image)
        Me.btnProdSearch.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnProdSearch.Location = New System.Drawing.Point(627, 12)
        Me.btnProdSearch.Name = "btnProdSearch"
        Me.btnProdSearch.Padding = New System.Windows.Forms.Padding(0, 2, 0, 0)
        Me.btnProdSearch.Size = New System.Drawing.Size(70, 55)
        Me.btnProdSearch.TabIndex = 13
        Me.btnProdSearch.Text = "Search"
        Me.btnProdSearch.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnProdSearch.UseVisualStyleBackColor = True
        '
        'dgvProduct
        '
        Me.dgvProduct.AllowUserToResizeRows = False
        Me.dgvProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvProduct.Location = New System.Drawing.Point(6, 73)
        Me.dgvProduct.MultiSelect = False
        Me.dgvProduct.Name = "dgvProduct"
        Me.dgvProduct.ReadOnly = True
        Me.dgvProduct.RowHeadersVisible = False
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Gray
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        Me.dgvProduct.RowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvProduct.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvProduct.Size = New System.Drawing.Size(767, 433)
        Me.dgvProduct.TabIndex = 12
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Control
        Me.Panel1.Controls.Add(Me.grpProdList)
        Me.Panel1.Location = New System.Drawing.Point(0, 31)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(784, 518)
        Me.Panel1.TabIndex = 2
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.DodgerBlue
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(784, 25)
        Me.Panel2.TabIndex = 41
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.DodgerBlue
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(0, 555)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(784, 25)
        Me.Panel3.TabIndex = 42
        '
        'productView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.ClientSize = New System.Drawing.Size(784, 580)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "productView"
        Me.Text = "View Product Record"
        Me.grpProdList.ResumeLayout(False)
        Me.grpProdList.PerformLayout()
        CType(Me.dgvProduct, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grpProdList As GroupBox
    Friend WithEvents btnProdSearch As Button
    Friend WithEvents dgvProduct As DataGridView
    Friend WithEvents txtProdSearch As TextBox
    Friend WithEvents Label52 As Label
    Friend WithEvents btnRefresh As Button
    Friend WithEvents rdbProdBrandName As RadioButton
    Friend WithEvents rdbProdCode As RadioButton
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
End Class
