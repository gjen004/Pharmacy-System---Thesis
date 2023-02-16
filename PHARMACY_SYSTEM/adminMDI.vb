Imports System.Windows.Forms

Public Class adminMDI                                                           '''''''''''''''''''''''''''ANJ_LAPTOP_FILES
    Dim c As New cControl
    Dim s As New cSQL

    Private Sub ShowNewForm(ByVal sender As Object, ByVal e As EventArgs)
        ' Create a new instance of the child form.
        Dim ChildForm As New System.Windows.Forms.Form
        ' Make it a child of this MDI form before showing it.
        ChildForm.MdiParent = Me

        m_ChildFormNumber += 1
        ChildForm.Text = "Window " & m_ChildFormNumber

        ChildForm.Show()
    End Sub

    Private Sub OpenFile(ByVal sender As Object, ByVal e As EventArgs)
        Dim OpenFileDialog As New OpenFileDialog
        OpenFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        OpenFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*"
        If (OpenFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dim FileName As String = OpenFileDialog.FileName
            ' TODO: Add code here to open the file.
        End If
    End Sub

    Private Sub SaveAsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Dim SaveFileDialog As New SaveFileDialog
        SaveFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        SaveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*"

        If (SaveFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dim FileName As String = SaveFileDialog.FileName
            ' TODO: Add code here to save the current contents of the form to a file.
        End If
    End Sub


    Private Sub ExitToolsStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.Close()
    End Sub

    Private Sub CutToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Use My.Computer.Clipboard to insert the selected text or images into the clipboard
    End Sub

    Private Sub CopyToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Use My.Computer.Clipboard to insert the selected text or images into the clipboard
    End Sub

    Private Sub PasteToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        'Use My.Computer.Clipboard.GetText() or My.Computer.Clipboard.GetData to retrieve information from the clipboard.
    End Sub


    Private Sub CascadeToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub TileVerticalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub

    Private Sub TileHorizontalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

    Private Sub ArrangeIconsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.ArrangeIcons)
    End Sub

    Private Sub CloseAllToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Close all child forms of the parent.
        For Each ChildForm As Form In Me.MdiChildren
            ChildForm.Close()
        Next
    End Sub

    Private m_ChildFormNumber As Integer


    Private Sub SalesTransactionsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles viewSales.Click
        For Each i As Form In Application.OpenForms
            If TypeOf i Is salesRecord Then
                i.Activate()
                Return
            End If
        Next
        Dim f As New salesRecord()
        f.MdiParent = Me
        f.Show()
    End Sub

    Private Sub SalesReturnsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalesReturns.Click
        For Each i As Form In Application.OpenForms
            If TypeOf i Is salesReturn Then
                i.Activate()
                Return
            End If
        Next
        Dim f As New salesReturn()
        f.MdiParent = Me
        f.Show()
    End Sub

    Private Sub adminMDI_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dim message As String = "Do you want to close application?"
        Dim caption As String = "Close Application"
        Dim icons As Integer = MessageBoxIcon.Question
        Dim buttons As Integer = MessageBoxButtons.YesNo

        Dim result As DialogResult

        result = MessageBox.Show(Me, message, caption, buttons, icons)

        If result = DialogResult.Yes Then
            e.Cancel = False
        Else
            e.Cancel = True
        End If
    End Sub

    Private Sub PromosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles addPromo.Click
        For Each i As Form In Application.OpenForms
            If TypeOf i Is promoForm Then
                i.Activate()
                Return
            End If
        Next
        Dim f As New promoForm
        f.MdiParent = Me
        f.Show()
    End Sub

    Private Sub DiscountsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles addDiscount.Click
        For Each i As Form In Application.OpenForms
            If TypeOf i Is discountForm Then
                i.Activate()
                Return
            End If
        Next
        Dim f As New discountForm
        f.MdiParent = Me
        f.Show()
    End Sub

    Private Sub GenericToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles GenericToolStripMenuItem1.Click
        For Each i As Form In Application.OpenForms
            If TypeOf i Is genericForm Then
                i.Activate()
                Return
            End If
        Next
        Dim f As New genericForm
        f.MdiParent = Me
        f.Show()
    End Sub

    Private Sub CategoryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CategoryToolStripMenuItem.Click
        For Each i As Form In Application.OpenForms
            If TypeOf i Is categoryForm Then
                i.Activate()
                Return
            End If
        Next
        Dim f As New categoryForm
        f.MdiParent = Me
        f.Show()
    End Sub

    Private Sub DosageToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DosageToolStripMenuItem.Click
        For Each i As Form In Application.OpenForms
            If TypeOf i Is dosageForm Then
                i.Activate()
                Return
            End If
        Next
        Dim f As New dosageForm
        f.MdiParent = Me
        f.Show()
    End Sub

    Private Sub FormToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FormToolStripMenuItem.Click
        For Each i As Form In Application.OpenForms
            If TypeOf i Is formForm Then
                i.Activate()
                Return
            End If
        Next
        Dim f As New formForm
        f.MdiParent = Me
        f.Show()
    End Sub

    Private Sub UnitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles v.Click
        For Each i As Form In Application.OpenForms
            If TypeOf i Is unitForm Then
                i.Activate()
                Return
            End If
        Next
        Dim f As New unitForm
        f.MdiParent = Me
        f.Show()
    End Sub

    Private Sub CityToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles addCity.Click
        For Each i As Form In Application.OpenForms
            If TypeOf i Is cityForm Then
                i.Activate()
                Return
            End If
        Next
        Dim f As New cityForm
        f.MdiParent = Me
        f.Show()
    End Sub

    Private Sub ProvinceToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles addProvince.Click
        For Each i As Form In Application.OpenForms
            If TypeOf i Is provinceForm Then
                i.Activate()
                Return
            End If
        Next
        Dim f As New provinceForm
        f.MdiParent = Me
        f.Show()
    End Sub

    Private Sub BankToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles addBank.Click
        For Each i As Form In Application.OpenForms
            If TypeOf i Is bankForm Then
                i.Activate()
                Return
            End If
        Next
        Dim f As New bankForm
        f.MdiParent = Me
        f.Show()
    End Sub

    Private Sub ReasonToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles addReason.Click
        For Each i As Form In Application.OpenForms
            If TypeOf i Is reasonForm Then
                i.Activate()
                Return
            End If
        Next
        Dim f As New reasonForm
        f.MdiParent = Me
        f.Show()
    End Sub

    Private Sub AdminMDI_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim f As New iconHolder
        f.MdiParent = Me
        f.Show()
        'Dim ind As Integer = 1
        'user access
        'empName = s.getName()
        'If username = "pharmacy" Then
        '    Exit Sub
        'Else
        empName = s.GetDetailStr("employeeView", "EmployeeName", "userName", username)

            s.checkRestrict(empName, "Change Password", changePass)
            s.checkRestrict(empName, "User Settings", userSettings)
            s.checkRestrict(empName, "New Product", productAdd)
            s.checkRestrict(empName, "View Product", productView)
            s.checkRestrict(empName, "Update Product", productUpdate)
            s.checkRestrict(empName, "Delete Product", productDelete)
            s.checkRestrict(empName, "New Employee", employeeAdd)
            s.checkRestrict(empName, "Update Employee", employeeUpdate)
            s.checkRestrict(empName, "New Supplier", supplierAdd)
            s.checkRestrict(empName, "View Supplier", supplierView)
            s.checkRestrict(empName, "Update Supplier", supplierUpdate)
            s.checkRestrict(empName, "Delete Supplier", supplierDelete)
            s.checkRestrict(empName, "New Customer", customerAdd)
            s.checkRestrict(empName, "View Customer", customerView)
            s.checkRestrict(empName, "Update Customer", customerUpdate)
            s.checkRestrict(empName, "Delete Customer", customerDelete)
            s.checkRestrict(empName, "Generic (Databank)", GenericToolStripMenuItem1)
            s.checkRestrict(empName, "Category (Databank)", CategoryToolStripMenuItem)
            s.checkRestrict(empName, "Dosage (Databank)", DosageToolStripMenuItem)
            s.checkRestrict(empName, "Form (Databank)", FormToolStripMenuItem)
            s.checkRestrict(empName, "Unit (Databank)", v)
            s.checkRestrict(empName, "City (Databank)", addCity)
            s.checkRestrict(empName, "Province (Databank)", addProvince)
            s.checkRestrict(empName, "Bank (Databank)", addBank)
            s.checkRestrict(empName, "Reason (Databank)", addReason)
            s.checkRestrict(empName, "Create Sales", PointOfSale)
            s.checkRestrict(empName, "View Sales", viewSales)
            s.checkRestrict(empName, "Sales Returns", SalesReturns)
            s.checkRestrict(empName, "Promos", addPromo)
            s.checkRestrict(empName, "Discounts", addDiscount)
            s.checkRestrict(empName, "New PO", purchaseOrderAdd)
            s.checkRestrict(empName, "Void PO", purchaseOrderVoid)
            s.checkRestrict(empName, "View PO", purchaseOrderView)
            s.checkRestrict(empName, "Close PO", purchaseOrderClose)
            s.checkRestrict(empName, "New RR", receiveRecordAdd)
            s.checkRestrict(empName, "View RR", receiveRecordView)
            s.checkRestrict(empName, "Update RR", receiveRecordUpdate)
            s.checkRestrict(empName, "New Payment", paymentAdd)
            s.checkRestrict(empName, "View Payment", paymentHistory)
            s.checkRestrict(empName, "User", menuUser)
            s.checkRestrict(empName, "Master Records", menuMasterRecords)
            s.checkRestrict(empName, "Databanks", menuDatabanks)
            s.checkRestrict(empName, "Sales", menuSales)
            s.checkRestrict(empName, "Purchase Order", menuPO)
            s.checkRestrict(empName, "Receiving Report", menuRR)
            s.checkRestrict(empName, "Payment", menuPayment)
            s.checkRestrict(empName, "Reports", menuReports)
        'End If
        'empName = s.GetDetailStr("employeeView", "EmployeeName", "userName", username)

        'For index As Integer = 1 To 43
        '    If index = 5 Then
        '        MsgBox("Skip Index")
        '    Else
        '        s.checkRestrict(empName, s.Res(index), CType(s.Itm(index), ToolStripDropDownItem))
        '    End If
        'Next
        'SQLCon.Open()

        'SQLCon.Close()

    End Sub

    Private Sub PointOfSaleToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PointOfSale.Click
        For Each i As Form In Application.OpenForms
            If TypeOf i Is pointOfSale Then
                i.Activate()
                Return
            End If
        Next
        Dim f As New pointOfSale
        f.MdiParent = Me
        f.Show()
    End Sub


    Private Sub AddRecordToolStripMenuItem6_Click(sender As Object, e As EventArgs)
        For Each i As Form In Application.OpenForms
            If TypeOf i Is paymentAdd Then
                i.Activate()
                Return
            End If
        Next
        Dim f As New paymentAdd
        f.MdiParent = Me
        f.Show()
    End Sub

    Private Sub ViewHistoryToolStripMenuItem_Click(sender As Object, e As EventArgs)
        For Each i As Form In Application.OpenForms
            If TypeOf i Is paymentHistory Then
                i.Activate()
                Return
            End If
        Next
        Dim f As New paymentHistory
        f.MdiParent = Me
        f.Show()
    End Sub

    Private Sub ChangePasswordToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles changePass.Click
        For Each i As Form In Application.OpenForms
            If TypeOf i Is changePass Then
                i.Activate()
                Return
            End If
        Next
        Dim f As New changePass
        f.MdiParent = Me
        f.Show()
    End Sub

    Private Sub UserSettingsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles userSettings.Click
        For Each i As Form In Application.OpenForms
            If TypeOf i Is userSettings Then
                i.Activate()
                Return
            End If
        Next
        Dim f As New userSettings
        f.MdiParent = Me
        f.Show()
    End Sub

    Private Sub ViewSupplierRecordsToolStripMenuItem_Click(sender As Object, e As EventArgs)
        For Each i As Form In Application.OpenForms
            If TypeOf i Is supplierView Then
                i.Activate()
                Return
            End If
        Next
        Dim f As New supplierView
        f.MdiParent = Me
        f.Show()
    End Sub

    Private Sub ViewCustomerRecordToolStripMenuItem_Click(sender As Object, e As EventArgs)
        For Each i As Form In Application.OpenForms
            If TypeOf i Is customerView Then
                i.Activate()
                Return
            End If
        Next
        Dim f As New customerView
        f.MdiParent = Me
        f.Show()
    End Sub

    Private Sub ViewPORecordsToolStripMenuItem_Click(sender As Object, e As EventArgs)
        For Each i As Form In Application.OpenForms
            If TypeOf i Is purchaseOrderView Then
                i.Activate()
                Return
            End If
        Next
        Dim f As New purchaseOrderView
        f.MdiParent = Me
        f.Show()
    End Sub

    Private Sub ViewReturnRecordsToolStripMenuItem_Click(sender As Object, e As EventArgs)
        For Each i As Form In Application.OpenForms
            If TypeOf i Is purchaseReturnView Then
                i.Activate()
                Return
            End If
        Next
        Dim f As New purchaseReturnView
        f.MdiParent = Me
        f.Show()
    End Sub

    Private Sub ProductToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles productAdd.Click
        For Each i As Form In Application.OpenForms
            If TypeOf i Is productAdd Then
                i.Activate()
                Return
            End If
        Next
        Dim f As New productAdd
        f.MdiParent = Me
        f.Show()
    End Sub

    Private Sub productView_Click(sender As Object, e As EventArgs) Handles productView.Click
        For Each i As Form In Application.OpenForms
            If TypeOf i Is productView Then
                i.Activate()
                Return
            End If
        Next
        Dim f As New productView
        f.MdiParent = Me
        f.Show()
    End Sub

    Private Sub productUpdate_Click(sender As Object, e As EventArgs) Handles productUpdate.Click
        For Each i As Form In Application.OpenForms
            If TypeOf i Is productUpdate Then
                i.Activate()
                Return
            End If
        Next
        Dim f As New productUpdate
        f.MdiParent = Me
        f.Show()
    End Sub

    Private Sub productDelete_Click(sender As Object, e As EventArgs) Handles productDelete.Click
        For Each i As Form In Application.OpenForms
            If TypeOf i Is productDelete Then
                i.Activate()
                Return
            End If
        Next
        Dim f As New productDelete
        f.MdiParent = Me
        f.Show()
    End Sub

    Private Sub NewEmployeeRecordToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles employeeAdd.Click
        For Each i As Form In Application.OpenForms
            If TypeOf i Is employeeAdd Then
                i.Activate()
                Return
            End If
        Next
        Dim f As New employeeAdd
        f.MdiParent = Me
        f.Show()
    End Sub

    Private Sub employeeUpdate_Click(sender As Object, e As EventArgs) Handles employeeUpdate.Click
        For Each i As Form In Application.OpenForms
            If TypeOf i Is employeeUpdate Then
                i.Activate()
                Return
            End If
        Next
        Dim f As New employeeUpdate
        f.MdiParent = Me
        f.Show()
    End Sub

    Private Sub supplierAdd_Click(sender As Object, e As EventArgs) Handles supplierAdd.Click
        For Each i As Form In Application.OpenForms
            If TypeOf i Is supplierAdd Then
                i.Activate()
                Return
            End If
        Next
        Dim f As New supplierAdd
        f.MdiParent = Me
        f.Show()
    End Sub

    Private Sub supplierView_Click(sender As Object, e As EventArgs) Handles supplierView.Click
        For Each i As Form In Application.OpenForms
            If TypeOf i Is supplierView Then
                i.Activate()
                Return
            End If
        Next
        Dim f As New supplierView
        f.MdiParent = Me
        f.Show()
    End Sub

    Private Sub supplierUpdate_Click(sender As Object, e As EventArgs) Handles supplierUpdate.Click
        For Each i As Form In Application.OpenForms
            If TypeOf i Is supplierUpdate Then
                i.Activate()
                Return
            End If
        Next
        Dim f As New supplierUpdate
        f.MdiParent = Me
        f.Show()
    End Sub

    Private Sub supplierDelete_Click(sender As Object, e As EventArgs) Handles supplierDelete.Click
        For Each i As Form In Application.OpenForms
            If TypeOf i Is supplierDelete Then
                i.Activate()
                Return
            End If
        Next
        Dim f As New supplierDelete
        f.MdiParent = Me
        f.Show()
    End Sub

    Private Sub customerAdd_Click(sender As Object, e As EventArgs) Handles customerAdd.Click
        For Each i As Form In Application.OpenForms
            If TypeOf i Is customerAdd Then
                i.Activate()
                Return
            End If
        Next
        Dim f As New customerAdd
        f.MdiParent = Me
        f.Show()
    End Sub

    Private Sub customerView_Click(sender As Object, e As EventArgs) Handles customerView.Click
        For Each i As Form In Application.OpenForms
            If TypeOf i Is customerView Then
                i.Activate()
                Return
            End If
        Next
        Dim f As New customerView
        f.MdiParent = Me
        f.Show()
    End Sub

    Private Sub customerUpdate_Click(sender As Object, e As EventArgs) Handles customerUpdate.Click
        For Each i As Form In Application.OpenForms
            If TypeOf i Is customerUpdate Then
                i.Activate()
                Return
            End If
        Next
        Dim f As New customerUpdate
        f.MdiParent = Me
        f.Show()
    End Sub

    Private Sub customerDelete_Click(sender As Object, e As EventArgs) Handles customerDelete.Click
        For Each i As Form In Application.OpenForms
            If TypeOf i Is customerDelete Then
                i.Activate()
                Return
            End If
        Next
        Dim f As New customerDelete
        f.MdiParent = Me
        f.Show()
    End Sub

    Private Sub purchaseOrderAdd_Click(sender As Object, e As EventArgs) Handles purchaseOrderAdd.Click
        For Each i As Form In Application.OpenForms
            If TypeOf i Is purchaseOrderAdd Then
                i.Activate()
                Return
            End If
        Next
        Dim f As New purchaseOrderAdd
        f.MdiParent = Me
        f.Show()
    End Sub

    Private Sub purchaseOrderView_Click(sender As Object, e As EventArgs) Handles purchaseOrderView.Click
        For Each i As Form In Application.OpenForms
            If TypeOf i Is purchaseOrderView Then
                i.Activate()
                Return
            End If
        Next
        Dim f As New purchaseOrderView
        f.MdiParent = Me
        f.Show()
    End Sub

    Private Sub purchaseOrderVoid_Click(sender As Object, e As EventArgs) Handles purchaseOrderVoid.Click
        For Each i As Form In Application.OpenForms
            If TypeOf i Is purchaseOrderVoid Then
                i.Activate()
                Return
            End If
        Next
        Dim f As New purchaseOrderVoid
        f.MdiParent = Me
        f.Show()
    End Sub

    Private Sub purchaseOrderClose_Click(sender As Object, e As EventArgs) Handles purchaseOrderClose.Click
        For Each i As Form In Application.OpenForms
            If TypeOf i Is purchaseOrderClose Then
                i.Activate()
                Return
            End If
        Next
        Dim f As New purchaseOrderClose
        f.MdiParent = Me
        f.Show()
    End Sub

    Private Sub purchaseReturnAdd_Click(sender As Object, e As EventArgs) Handles receiveRecordAdd.Click
        For Each i As Form In Application.OpenForms
            If TypeOf i Is receivingRecordsAdd Then
                i.Activate()
                Return
            End If
        Next
        Dim f As New receivingRecordsAdd
        f.MdiParent = Me
        f.Show()
    End Sub

    Private Sub purchaseReturnUpdate_Click(sender As Object, e As EventArgs) Handles receiveRecordUpdate.Click
        For Each i As Form In Application.OpenForms
            If TypeOf i Is receivingRecordUpdate Then
                i.Activate()
                Return
            End If
        Next
        Dim f As New receivingRecordUpdate
        f.MdiParent = Me
        f.Show()
    End Sub

    Private Sub receiveRecordView_Click(sender As Object, e As EventArgs) Handles receiveRecordView.Click
        For Each i As Form In Application.OpenForms
            If TypeOf i Is receivingRecordView Then
                i.Activate()
                Return
            End If
        Next
        Dim f As New receivingRecordView
        f.MdiParent = Me
        f.Show()
    End Sub

    Private Sub returnAdd_Click(sender As Object, e As EventArgs)
        For Each i As Form In Application.OpenForms
            If TypeOf i Is purchaseReturnAdd Then
                i.Activate()
                Return
            End If
        Next
        Dim f As New purchaseReturnAdd
        f.MdiParent = Me
        f.Show()
    End Sub

    Private Sub returnView_Click(sender As Object, e As EventArgs)
        For Each i As Form In Application.OpenForms
            If TypeOf i Is purchaseReturnView Then
                i.Activate()
                Return
            End If
        Next
        Dim f As New purchaseReturnView
        f.MdiParent = Me
        f.Show()
    End Sub

    Private Sub returnVoid_Click(sender As Object, e As EventArgs)
        For Each i As Form In Application.OpenForms
            If TypeOf i Is purchaseReturnVoid Then
                i.Activate()
                Return
            End If
        Next
        Dim f As New purchaseReturnVoid
        f.MdiParent = Me
        f.Show()
    End Sub

    Private Sub paymentAdd_Click(sender As Object, e As EventArgs) Handles paymentAdd.Click
        For Each i As Form In Application.OpenForms
            If TypeOf i Is paymentAdd Then
                i.Activate()
                Return
            End If
        Next
        Dim f As New paymentAdd
        f.MdiParent = Me
        f.Show()
    End Sub

    Private Sub paymentHistory_Click(sender As Object, e As EventArgs) Handles paymentHistory.Click
        For Each i As Form In Application.OpenForms
            If TypeOf i Is paymentHistory Then
                i.Activate()
                Return
            End If
        Next
        Dim f As New paymentHistory
        f.MdiParent = Me
        f.Show()
    End Sub

    Private Sub PositionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles addPosition.Click
        For Each i As Form In Application.OpenForms
            If TypeOf i Is position Then
                i.Activate()
                Return
            End If
        Next
        Dim f As New position
        f.MdiParent = Me
        f.Show()
    End Sub

    Private Sub SalesReportToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Dim f As New reportsPO
        f.MdiParent = Me
        f.Show()
    End Sub

    Private Sub ProductExpiryReportToolStripMenuItem_Click(sender As Object, e As EventArgs) 
        Dim quer As String = "select Product, Quantity, ProdExpDate from showProdQuantity where quantity > '0' order by ProdExpDate asc"
    End Sub

    Private Sub ExpiredProductReportToolStripMenuItem_Click(sender As Object, e As EventArgs) 
        Dim dt As String = Format(Date.Now, "yyyy-MM-dd")
        Dim quer As String = " select Product, Quantity, ProdExpDate from showProdQuantity where quantity > '0' and ProdExpDate <= '" & dt & "'"
    End Sub

    Private Sub SalesSummaryPerEmployeeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalesSummaryPerEmployeeToolStripMenuItem.Click
        For Each i As Form In Application.OpenForms
            If TypeOf i Is reportsPO Then
                i.Activate()
                Return
            End If
        Next
        Dim f As New reportsPO
        f.MdiParent = Me
        f.Show()
    End Sub

    Private Sub ReceivingRecordsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReceivingRecordsToolStripMenuItem.Click
        For Each i As Form In Application.OpenForms
            If TypeOf i Is reportRRAll Then
                i.Activate()
                Return
            End If
        Next
        Dim f As New reportRRAll
        f.MdiParent = Me
        f.Show()
    End Sub

    Private Sub SalesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalesToolStripMenuItem.Click
        For Each i As Form In Application.OpenForms
            If TypeOf i Is reportsSalesDateRange Then
                i.Activate()
                Return
            End If
        Next
        Dim f As New reportsSalesDateRange
        f.MdiParent = Me
        f.Show()
    End Sub
End Class
