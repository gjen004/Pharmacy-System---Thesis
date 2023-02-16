Imports System.Data.Sql
Imports System.Data.SqlClient
Module mSQL
    'for new block
    'Public filePath As String
    Public fileReader As String = My.Computer.FileSystem.ReadAllText(Application.StartupPath + "\db\srvrnm.txt")
    Public con As String = fileReader
    Public SQLCon As New SqlConnection(con)
    Public SQLCmd As SqlCommand
    Public SQLDA As SqlDataAdapter
    Public SQLDataset As New DataSet

    'for debug nijjosh
    'Public SQLCon As New SqlConnection With {.ConnectionString = "server=DESKTOP-QAELHH0\SQLEXPRESS;database=newPDB;Integrated Security=SSPI"}

    'old db
    ' {.ConnectionString = "server=GJEN\GJEN;database=dbPhrm;Integrated Security=SSPI"}

    'use this after all debug process
    '{.ConnectionString = "server=GJEN\SLQ2008;database=dbPhrmFinal;Integrated Security=SSPI"} 'gen
    '{.ConnectionString = "server=DESKTOP-0QMKEJC\SQLEXPRESS2008;database=dbPharmacy;Integrated Security=SSPI"} 'josh
    '{.ConnectionString = "server=DESKTOP-QAELHH0\SQLEXPRESS;database=newPDB;Integrated Security=SSPI"} 'laptop ni anj

    'reports
    Public SetPONum As Integer = Nothing
    Public SetRRNum As Integer = Nothing

    'login details

    'for products
    Public prodCode, brndName, temp, categName As String
    Public id, genID, categID, pUnit, dID, statID, fID As Integer
    Public sellPrice As Double

    'databanks
    Public name As String

    'updateProd
    Public point As Integer = -1

    'for supplier and cust
    Public custName, custAdd, suppName, suppAddress, contactNo, contactPerson, tin, savedBy, updatedBy As String
    Public cityID, provinceID As Integer

    'for employee
    Public fname, lname, sex, pos, hiredate, user, pass As String

    'PO
    Public orderNo, remarks, status, quant, price As String
    Public createPO, needPO As String
    Public supp, prod, POID, res As Integer

    'void order
    Public voidWhat, reason As Integer
    Public whoIs As String

    'returns
    Public retno, createRet As String
    Public returnNo, transNo, transDate As String
    Public retReas, qtyRet, frQtyRet As Integer

    'deliveries
    Public rcvr, DTDlvr, expDate As String
    Public delvNo, qtyRcvd, prodName As String
    Public chkVal As Boolean
    Public num As String
    Public RRID, bal As Integer
    Public whereIs As String
    Public PODeID, ordQty As Integer
    Public toPay, amt As Double

    'paymnent
    Public paymentNo, cash, payOn As String
    Public payCsh As String
    Public chqAmt, chqNo As Integer
    'Public chqBnk As Integer
    Public chqBnk As String
    Public dpstAmt, dpstNo As Integer
    'Public dpstBnk As Integer
    Public dpstBnk As String
    Public payDtCsh, payDtChq, payDtDpst As String
    Public RRDiD As Integer

    'sales
    Public place, prc, sbT, qtyProd, promoType, freeQty, freeProd, salesNo As Integer
    Public _place, _index, whereTo As Integer
    Public custID, dscID, promoID As Integer
    Public pID, transAmt As Integer
    Public prodSales, promoSales As String


    'check counts
    Public rowCnt As Integer

    'discount
    Public dscName As String
    Public percent As Double

    'promo
    Public promoName, startDT, endDT As String
    Public prodID, frProdID As Integer
    Public minQty, frQty As Integer

    'handling databings
    Public dtgOnFocus As DataGridView

    'set product ID to show
    Public showProdID As Integer

    'sales 
    Public saleDsc As Integer

    'set ranges
    Public startAt, endsAt As String

    'for login
    Public username As String = loginForm.txtUser.Text
    Public password As String = loginForm.txtPass.Text
    Public empName As String


    'add vars for sales
    Public dscNameCbxChng As String
    Public discountID, stockID As Integer

    'add vars for RR
    Public limit As Integer

    'for user settings
    Public contID, restID, empID As Integer

    'for msgbox
    Public caption As String = "Pharmacy System"
    Public buttons As MessageBoxButtons = MessageBoxButtons.OK


    Public test As String

    'reportorials
    Public querPODR As String
    Public querPOSupp As String
    Public querPOVd, querPOCls, querPOPnd As String
    Public querRR As String
    Public rptSubPop As String
    Public querSales As String
    Public table As String
    Public querPrevPrice As String
End Module
