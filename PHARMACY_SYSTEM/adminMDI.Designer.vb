<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class adminMDI
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(adminMDI))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.menuUser = New System.Windows.Forms.ToolStripMenuItem()
        Me.changePass = New System.Windows.Forms.ToolStripMenuItem()
        Me.userSettings = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuMasterRecords = New System.Windows.Forms.ToolStripMenuItem()
        Me.productAdd = New System.Windows.Forms.ToolStripMenuItem()
        Me.productView = New System.Windows.Forms.ToolStripMenuItem()
        Me.productUpdate = New System.Windows.Forms.ToolStripMenuItem()
        Me.productDelete = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.employeeAdd = New System.Windows.Forms.ToolStripMenuItem()
        Me.employeeUpdate = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.supplierAdd = New System.Windows.Forms.ToolStripMenuItem()
        Me.supplierView = New System.Windows.Forms.ToolStripMenuItem()
        Me.supplierUpdate = New System.Windows.Forms.ToolStripMenuItem()
        Me.supplierDelete = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.customerAdd = New System.Windows.Forms.ToolStripMenuItem()
        Me.customerView = New System.Windows.Forms.ToolStripMenuItem()
        Me.customerUpdate = New System.Windows.Forms.ToolStripMenuItem()
        Me.customerDelete = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuDatabanks = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuProduct = New System.Windows.Forms.ToolStripMenuItem()
        Me.GenericToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.CategoryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DosageToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FormToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.v = New System.Windows.Forms.ToolStripMenuItem()
        Me.addCity = New System.Windows.Forms.ToolStripMenuItem()
        Me.addProvince = New System.Windows.Forms.ToolStripMenuItem()
        Me.addBank = New System.Windows.Forms.ToolStripMenuItem()
        Me.addReason = New System.Windows.Forms.ToolStripMenuItem()
        Me.addPosition = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuSales = New System.Windows.Forms.ToolStripMenuItem()
        Me.PointOfSale = New System.Windows.Forms.ToolStripMenuItem()
        Me.viewSales = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalesReturns = New System.Windows.Forms.ToolStripMenuItem()
        Me.addPromo = New System.Windows.Forms.ToolStripMenuItem()
        Me.addDiscount = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuPO = New System.Windows.Forms.ToolStripMenuItem()
        Me.purchaseOrderAdd = New System.Windows.Forms.ToolStripMenuItem()
        Me.purchaseOrderView = New System.Windows.Forms.ToolStripMenuItem()
        Me.purchaseOrderVoid = New System.Windows.Forms.ToolStripMenuItem()
        Me.purchaseOrderClose = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuRR = New System.Windows.Forms.ToolStripMenuItem()
        Me.receiveRecordAdd = New System.Windows.Forms.ToolStripMenuItem()
        Me.receiveRecordView = New System.Windows.Forms.ToolStripMenuItem()
        Me.receiveRecordUpdate = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuPayment = New System.Windows.Forms.ToolStripMenuItem()
        Me.paymentAdd = New System.Windows.Forms.ToolStripMenuItem()
        Me.paymentHistory = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuReports = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalesSummaryPerEmployeeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReceivingRecordsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuUser, Me.menuMasterRecords, Me.menuDatabanks, Me.menuSales, Me.menuPO, Me.menuRR, Me.menuPayment, Me.menuReports})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(884, 24)
        Me.MenuStrip1.TabIndex = 9
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'menuUser
        '
        Me.menuUser.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.changePass, Me.userSettings})
        Me.menuUser.Name = "menuUser"
        Me.menuUser.Size = New System.Drawing.Size(42, 20)
        Me.menuUser.Text = "User"
        '
        'changePass
        '
        Me.changePass.Name = "changePass"
        Me.changePass.Size = New System.Drawing.Size(168, 22)
        Me.changePass.Text = "Change Password"
        '
        'userSettings
        '
        Me.userSettings.Name = "userSettings"
        Me.userSettings.Size = New System.Drawing.Size(168, 22)
        Me.userSettings.Text = "User Settings"
        '
        'menuMasterRecords
        '
        Me.menuMasterRecords.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.productAdd, Me.productView, Me.productUpdate, Me.productDelete, Me.ToolStripSeparator1, Me.employeeAdd, Me.employeeUpdate, Me.ToolStripSeparator2, Me.supplierAdd, Me.supplierView, Me.supplierUpdate, Me.supplierDelete, Me.ToolStripSeparator3, Me.customerAdd, Me.customerView, Me.customerUpdate, Me.customerDelete})
        Me.menuMasterRecords.Name = "menuMasterRecords"
        Me.menuMasterRecords.Size = New System.Drawing.Size(100, 20)
        Me.menuMasterRecords.Text = "Master Records"
        '
        'productAdd
        '
        Me.productAdd.Name = "productAdd"
        Me.productAdd.Size = New System.Drawing.Size(207, 22)
        Me.productAdd.Text = "New Product Record"
        '
        'productView
        '
        Me.productView.Name = "productView"
        Me.productView.Size = New System.Drawing.Size(207, 22)
        Me.productView.Text = "View Product Record"
        '
        'productUpdate
        '
        Me.productUpdate.Name = "productUpdate"
        Me.productUpdate.Size = New System.Drawing.Size(207, 22)
        Me.productUpdate.Text = "Update Product Record"
        '
        'productDelete
        '
        Me.productDelete.Name = "productDelete"
        Me.productDelete.Size = New System.Drawing.Size(207, 22)
        Me.productDelete.Text = "Delete Product Record"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(204, 6)
        '
        'employeeAdd
        '
        Me.employeeAdd.Name = "employeeAdd"
        Me.employeeAdd.Size = New System.Drawing.Size(207, 22)
        Me.employeeAdd.Text = "New Employee Record"
        '
        'employeeUpdate
        '
        Me.employeeUpdate.Name = "employeeUpdate"
        Me.employeeUpdate.Size = New System.Drawing.Size(207, 22)
        Me.employeeUpdate.Text = "Update Employee Record"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(204, 6)
        '
        'supplierAdd
        '
        Me.supplierAdd.Name = "supplierAdd"
        Me.supplierAdd.Size = New System.Drawing.Size(207, 22)
        Me.supplierAdd.Text = "New Supplier Record"
        '
        'supplierView
        '
        Me.supplierView.Name = "supplierView"
        Me.supplierView.Size = New System.Drawing.Size(207, 22)
        Me.supplierView.Text = "View Supplier Record"
        '
        'supplierUpdate
        '
        Me.supplierUpdate.Name = "supplierUpdate"
        Me.supplierUpdate.Size = New System.Drawing.Size(207, 22)
        Me.supplierUpdate.Text = "Update Supplier Record"
        '
        'supplierDelete
        '
        Me.supplierDelete.Name = "supplierDelete"
        Me.supplierDelete.Size = New System.Drawing.Size(207, 22)
        Me.supplierDelete.Text = "Delete Supplier Record"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(204, 6)
        '
        'customerAdd
        '
        Me.customerAdd.Name = "customerAdd"
        Me.customerAdd.Size = New System.Drawing.Size(207, 22)
        Me.customerAdd.Text = "New Customer Record"
        '
        'customerView
        '
        Me.customerView.Name = "customerView"
        Me.customerView.Size = New System.Drawing.Size(207, 22)
        Me.customerView.Text = "View Customer Records"
        '
        'customerUpdate
        '
        Me.customerUpdate.Name = "customerUpdate"
        Me.customerUpdate.Size = New System.Drawing.Size(207, 22)
        Me.customerUpdate.Text = "Update Customer Record"
        '
        'customerDelete
        '
        Me.customerDelete.Name = "customerDelete"
        Me.customerDelete.Size = New System.Drawing.Size(207, 22)
        Me.customerDelete.Text = "Delete Customer Record"
        '
        'menuDatabanks
        '
        Me.menuDatabanks.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuProduct, Me.addCity, Me.addProvince, Me.addBank, Me.addReason, Me.addPosition})
        Me.menuDatabanks.Name = "menuDatabanks"
        Me.menuDatabanks.Size = New System.Drawing.Size(74, 20)
        Me.menuDatabanks.Text = "Databanks"
        '
        'menuProduct
        '
        Me.menuProduct.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GenericToolStripMenuItem1, Me.CategoryToolStripMenuItem, Me.DosageToolStripMenuItem, Me.FormToolStripMenuItem, Me.v})
        Me.menuProduct.Name = "menuProduct"
        Me.menuProduct.Size = New System.Drawing.Size(120, 22)
        Me.menuProduct.Text = "Product"
        '
        'GenericToolStripMenuItem1
        '
        Me.GenericToolStripMenuItem1.Name = "GenericToolStripMenuItem1"
        Me.GenericToolStripMenuItem1.Size = New System.Drawing.Size(122, 22)
        Me.GenericToolStripMenuItem1.Text = "Generic"
        '
        'CategoryToolStripMenuItem
        '
        Me.CategoryToolStripMenuItem.Name = "CategoryToolStripMenuItem"
        Me.CategoryToolStripMenuItem.Size = New System.Drawing.Size(122, 22)
        Me.CategoryToolStripMenuItem.Text = "Category"
        '
        'DosageToolStripMenuItem
        '
        Me.DosageToolStripMenuItem.Name = "DosageToolStripMenuItem"
        Me.DosageToolStripMenuItem.Size = New System.Drawing.Size(122, 22)
        Me.DosageToolStripMenuItem.Text = "Dosage"
        '
        'FormToolStripMenuItem
        '
        Me.FormToolStripMenuItem.Name = "FormToolStripMenuItem"
        Me.FormToolStripMenuItem.Size = New System.Drawing.Size(122, 22)
        Me.FormToolStripMenuItem.Text = "Form"
        '
        'v
        '
        Me.v.Name = "v"
        Me.v.Size = New System.Drawing.Size(122, 22)
        Me.v.Text = "Unit"
        '
        'addCity
        '
        Me.addCity.Name = "addCity"
        Me.addCity.Size = New System.Drawing.Size(120, 22)
        Me.addCity.Text = "City"
        '
        'addProvince
        '
        Me.addProvince.Name = "addProvince"
        Me.addProvince.Size = New System.Drawing.Size(120, 22)
        Me.addProvince.Text = "Province"
        '
        'addBank
        '
        Me.addBank.Name = "addBank"
        Me.addBank.Size = New System.Drawing.Size(120, 22)
        Me.addBank.Text = "Bank"
        '
        'addReason
        '
        Me.addReason.Name = "addReason"
        Me.addReason.Size = New System.Drawing.Size(120, 22)
        Me.addReason.Text = "Reason"
        '
        'addPosition
        '
        Me.addPosition.Name = "addPosition"
        Me.addPosition.Size = New System.Drawing.Size(120, 22)
        Me.addPosition.Text = "Position"
        '
        'menuSales
        '
        Me.menuSales.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PointOfSale, Me.viewSales, Me.SalesReturns, Me.addPromo, Me.addDiscount})
        Me.menuSales.Name = "menuSales"
        Me.menuSales.Size = New System.Drawing.Size(45, 20)
        Me.menuSales.Text = "S&ales"
        '
        'PointOfSale
        '
        Me.PointOfSale.Name = "PointOfSale"
        Me.PointOfSale.Size = New System.Drawing.Size(143, 22)
        Me.PointOfSale.Text = "Create Sales"
        '
        'viewSales
        '
        Me.viewSales.Name = "viewSales"
        Me.viewSales.Size = New System.Drawing.Size(143, 22)
        Me.viewSales.Text = "View Sales"
        '
        'SalesReturns
        '
        Me.SalesReturns.Name = "SalesReturns"
        Me.SalesReturns.Size = New System.Drawing.Size(143, 22)
        Me.SalesReturns.Text = "Sales Returns"
        '
        'addPromo
        '
        Me.addPromo.Name = "addPromo"
        Me.addPromo.Size = New System.Drawing.Size(143, 22)
        Me.addPromo.Text = "Promos"
        '
        'addDiscount
        '
        Me.addDiscount.Name = "addDiscount"
        Me.addDiscount.Size = New System.Drawing.Size(143, 22)
        Me.addDiscount.Text = "Discounts"
        '
        'menuPO
        '
        Me.menuPO.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.purchaseOrderAdd, Me.purchaseOrderView, Me.purchaseOrderVoid, Me.purchaseOrderClose})
        Me.menuPO.Name = "menuPO"
        Me.menuPO.Size = New System.Drawing.Size(100, 20)
        Me.menuPO.Text = "Purchase Order"
        '
        'purchaseOrderAdd
        '
        Me.purchaseOrderAdd.Name = "purchaseOrderAdd"
        Me.purchaseOrderAdd.Size = New System.Drawing.Size(162, 22)
        Me.purchaseOrderAdd.Text = "New PO Record"
        '
        'purchaseOrderView
        '
        Me.purchaseOrderView.Name = "purchaseOrderView"
        Me.purchaseOrderView.Size = New System.Drawing.Size(162, 22)
        Me.purchaseOrderView.Text = "View PO Record"
        '
        'purchaseOrderVoid
        '
        Me.purchaseOrderVoid.Name = "purchaseOrderVoid"
        Me.purchaseOrderVoid.Size = New System.Drawing.Size(162, 22)
        Me.purchaseOrderVoid.Text = "Void PO Record"
        '
        'purchaseOrderClose
        '
        Me.purchaseOrderClose.Name = "purchaseOrderClose"
        Me.purchaseOrderClose.Size = New System.Drawing.Size(162, 22)
        Me.purchaseOrderClose.Text = "Close PO Record"
        '
        'menuRR
        '
        Me.menuRR.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.receiveRecordAdd, Me.receiveRecordView, Me.receiveRecordUpdate})
        Me.menuRR.Name = "menuRR"
        Me.menuRR.Size = New System.Drawing.Size(108, 20)
        Me.menuRR.Text = "Receiving Report"
        '
        'receiveRecordAdd
        '
        Me.receiveRecordAdd.Name = "receiveRecordAdd"
        Me.receiveRecordAdd.Size = New System.Drawing.Size(129, 22)
        Me.receiveRecordAdd.Text = "New RR"
        '
        'receiveRecordView
        '
        Me.receiveRecordView.Name = "receiveRecordView"
        Me.receiveRecordView.Size = New System.Drawing.Size(129, 22)
        Me.receiveRecordView.Text = "View RR"
        '
        'receiveRecordUpdate
        '
        Me.receiveRecordUpdate.Name = "receiveRecordUpdate"
        Me.receiveRecordUpdate.Size = New System.Drawing.Size(129, 22)
        Me.receiveRecordUpdate.Text = "Update RR"
        '
        'menuPayment
        '
        Me.menuPayment.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.paymentAdd, Me.paymentHistory})
        Me.menuPayment.Name = "menuPayment"
        Me.menuPayment.Size = New System.Drawing.Size(66, 20)
        Me.menuPayment.Text = "Payment"
        '
        'paymentAdd
        '
        Me.paymentAdd.Name = "paymentAdd"
        Me.paymentAdd.Size = New System.Drawing.Size(194, 22)
        Me.paymentAdd.Text = "New Payment Record"
        '
        'paymentHistory
        '
        Me.paymentHistory.Name = "paymentHistory"
        Me.paymentHistory.Size = New System.Drawing.Size(194, 22)
        Me.paymentHistory.Text = "View Payment Records"
        '
        'menuReports
        '
        Me.menuReports.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SalesSummaryPerEmployeeToolStripMenuItem, Me.ReceivingRecordsToolStripMenuItem, Me.SalesToolStripMenuItem})
        Me.menuReports.Name = "menuReports"
        Me.menuReports.Size = New System.Drawing.Size(59, 20)
        Me.menuReports.Text = "Reports"
        '
        'SalesSummaryPerEmployeeToolStripMenuItem
        '
        Me.SalesSummaryPerEmployeeToolStripMenuItem.Name = "SalesSummaryPerEmployeeToolStripMenuItem"
        Me.SalesSummaryPerEmployeeToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.SalesSummaryPerEmployeeToolStripMenuItem.Text = "Purchase Orders"
        '
        'ReceivingRecordsToolStripMenuItem
        '
        Me.ReceivingRecordsToolStripMenuItem.Name = "ReceivingRecordsToolStripMenuItem"
        Me.ReceivingRecordsToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.ReceivingRecordsToolStripMenuItem.Text = "Receiving Records"
        '
        'SalesToolStripMenuItem
        '
        Me.SalesToolStripMenuItem.Name = "SalesToolStripMenuItem"
        Me.SalesToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.SalesToolStripMenuItem.Text = "Sales"
        '
        'adminMDI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(884, 611)
        Me.Controls.Add(Me.MenuStrip1)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.Name = "adminMDI"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " Renzcel's Pharmacy"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents menuSales As ToolStripMenuItem
    Friend WithEvents viewSales As ToolStripMenuItem
    Friend WithEvents SalesReturns As ToolStripMenuItem
    Friend WithEvents addDiscount As ToolStripMenuItem
    Friend WithEvents menuDatabanks As ToolStripMenuItem
    Friend WithEvents menuProduct As ToolStripMenuItem
    Friend WithEvents GenericToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents CategoryToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DosageToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FormToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents v As ToolStripMenuItem
    Friend WithEvents addCity As ToolStripMenuItem
    Friend WithEvents addProvince As ToolStripMenuItem
    Friend WithEvents addBank As ToolStripMenuItem
    Friend WithEvents addReason As ToolStripMenuItem
    Friend WithEvents PointOfSale As ToolStripMenuItem
    Friend WithEvents menuUser As ToolStripMenuItem
    Friend WithEvents changePass As ToolStripMenuItem
    Friend WithEvents userSettings As ToolStripMenuItem
    Friend WithEvents addPromo As ToolStripMenuItem
    Friend WithEvents menuMasterRecords As ToolStripMenuItem
    Friend WithEvents productAdd As ToolStripMenuItem
    Friend WithEvents productView As ToolStripMenuItem
    Friend WithEvents productUpdate As ToolStripMenuItem
    Friend WithEvents productDelete As ToolStripMenuItem
    Friend WithEvents employeeAdd As ToolStripMenuItem
    Friend WithEvents employeeUpdate As ToolStripMenuItem
    Friend WithEvents supplierAdd As ToolStripMenuItem
    Friend WithEvents supplierView As ToolStripMenuItem
    Friend WithEvents supplierUpdate As ToolStripMenuItem
    Friend WithEvents supplierDelete As ToolStripMenuItem
    Friend WithEvents customerAdd As ToolStripMenuItem
    Friend WithEvents customerView As ToolStripMenuItem
    Friend WithEvents customerUpdate As ToolStripMenuItem
    Friend WithEvents customerDelete As ToolStripMenuItem
    Friend WithEvents menuPO As ToolStripMenuItem
    Friend WithEvents purchaseOrderAdd As ToolStripMenuItem
    Friend WithEvents purchaseOrderView As ToolStripMenuItem
    Friend WithEvents purchaseOrderVoid As ToolStripMenuItem
    Friend WithEvents purchaseOrderClose As ToolStripMenuItem
    Friend WithEvents menuRR As ToolStripMenuItem
    Friend WithEvents receiveRecordAdd As ToolStripMenuItem
    Friend WithEvents receiveRecordUpdate As ToolStripMenuItem
    Friend WithEvents menuPayment As ToolStripMenuItem
    Friend WithEvents paymentAdd As ToolStripMenuItem
    Friend WithEvents paymentHistory As ToolStripMenuItem
    Friend WithEvents receiveRecordView As ToolStripMenuItem
    Friend WithEvents menuReports As ToolStripMenuItem
    Friend WithEvents addPosition As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents SalesSummaryPerEmployeeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReceivingRecordsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalesToolStripMenuItem As ToolStripMenuItem
End Class
