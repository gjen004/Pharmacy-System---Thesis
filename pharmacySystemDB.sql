create table Generic
(
genericID bigint IDENTITY(1,1) PRIMARY KEY,
genericName varchar(250),
categoryID int,
savedBy varchar(250),
saveDT datetime,
updatedBy varchar(250),
deletedBy varchar(250),
deleteDT datetime
)

create table Product
(
productID bigint IDENTITY(1,1) PRIMARY KEY,
productCode varchar(250),
genericID bigint,
brandName varchar(250),
dosageID int,
formID int,
productUnitID bigint,
productStatus varchar(100),
savedBy varchar(250),
saveDT datetime,
updatedBy varchar(250),
updateDT datetime,
deletedBy varchar(250),
deleteDT datetime
)

create table ProductUnitPrice
(
productID bigint,
unitPrice numeric,
savedBy varchar(250),
saveDT datetime,
updatedBy varchar(250),
updateDT datetime,
deletedBy varchar(250),
deleteDT datetime
)

create table Supplier
(
supplierID bigint IDENTITY (1,1) PRIMARY KEY,
supplierName varchar(250),
supplierAddress varchar(250),
cityID int,
provinceID int,
contactNo varchar(50),
contactPerson varchar(250),
tinNo varchar(50),
savedBy varchar(250),
saveDT datetime,
updatedBy varchar(250),
updateDT datetime,
deletedBy varchar(250),
deleteDT datetime
)

create table Customer
(
customerID bigint IDENTITY (1,1) PRIMARY KEY,
customerName varchar(250),
customerAddress varchar(250),
cityID int,
provinceID int,
contactNo varchar(50),
savedBy varchar(250),
saveDT datetime,
updatedBy varchar(250),
updateDT datetime,
deletedBy varchar(250),
deleteDT datetime
)

create table PurchaseOrder
(
POID bigint IDENTITY (1,1) PRIMARY KEY,
PONo varchar(50),
PODate date,
supplierID bigint,
dateNeeded date,
remarks varchar(250),
savedBy varchar(250),
saveDT datetime,
voidBy varchar(250),
voidDT datetime,
voidReason varchar(250),
closedBy varchar(250),
closeDT datetime,
closeReason varchar(250)
)

create table PurchaseOrderDetails
(
PODetailsID bigint IDENTITY (1,1) PRIMARY KEY,
POID bigint,
quantity int,
unitPrice numeric,
balance numeric
)

create table ReceiveRecord
(
RRID bigint IDENTITY (1,1) PRIMARY KEY,
RRNo varchar(50),
supplierID bigint,
RRDate date,
remarks varchar(250),
savedBy varchar(250),
saveDT datetime,
updatedBy varchar(250),
updateDT datetime,
reasonID int,
receivedBy varchar(250)
)

create table ReceiveRecordDetails
(
RRDetailsID bigint IDENTITY (1,1) PRIMARY KEY,
RRID bigint,
PODetailsID bigint,
quantity int,
amount numeric,
balance numeric
)

create table Payment
(
paymentID bigint IDENTITY (1,1) PRIMARY KEY,
paymentNo varchar(50),
supplierID bigint,
paymentDate date,
cashAmount numeric,
remarks varchar(250),
savedBy varchar(250),
saveDT datetime,
closedBy varchar(250),
closeDT datetime,
reasonID int
)

create table PaymentDetails
(
PaymentDetailsID bigint IDENTITY (1,1) primary key,
paymentID bigint,
RRDetailsID bigint,
amount numeric
)

create table PaymentType
(
paymentID bigint,
advancePaymentID bigint,
chequeNo varchar(50),
chequeDate date,
chequeAmount numeric,
chequeBankID int,
bankDepositNo varchar(50),
bankDepositDate date,
bankDepositAmount numeric,
bankDepositBankID int
)

create table PurchaseReturn
(
returnID bigint IDENTITY (1,1) primary key,
returnNo varchar(50),
returnDate date,
savedBy varchar(250),
saveDT datetime,
voidBy varchar(250),
voidDT datetime
)

create table PurchaseReturnDetails
(
RRDetailsID bigint,
quantity int,
reasonID int
)

create table Promo
(
promoID bigint IDENTITY (1,1) primary key,
productID bigint,
startDate date,
endDate date,
discount varchar(100),
percentage numeric,
savedBy varchar(250),
saveDT datetime,
voidBy varchar(250),
voidDT datetime
)

create table Discount
(
discountID bigint IDENTITY (1,1) primary key,
discountName varchar(250),
percentage numeric,
savedBy varchar(250),
saveDT datetime,
voidBy varchar(250),
voidDT datetime
)

create table Sales
(
salesID bigint IDENTITY (1,1) NOT NULL primary key,
salesNo varchar(50) not null,
customerID bigint,
discountID bigint,
savedBy varchar(250),
saveDT datetime
)

create table SalesDetails
(
salesDetailsID bigint IDENTITY (1,1) primary key,
salesID bigint,
productID bigint,
quantity int,
freeQuantity int,
promoID bigint
)

create table SalesReturn
(
salesReturnID bigint IDENTITY (1,1) primary key,
returnNo varchar(50),
salesReturnDate date,
remarks varchar(250),
savedBy varchar(250),
saveDT datetime,
deletedBy varchar(250),
deleteDT datetime
)

create table SalesReturnDetails
(
salesReturnID bigint,
salesDetailsID bigint,
quantity int,
reasonID int
)

create table SalesVoid
(
salesVoidID bigint IDENTITY (1,1) primary key,
salesNo varchar(50),
customerID bigint,
discountID bigint,
salesSavedBy varchar(250),
salesSavedDT datetime,
savedby varchar(250),
saveDT varchar(250)
)

create table SalesVoidDetails
(
salesVoidDetailsID bigint IDENTITY (1,1) primary key,
salesID bigint,
productID bigint,
quantity int,
freeQuantity int,
promoID bigint
)

/*DATABANKS*/
create table Category
(
categoryID int IDENTITY (1,1) primary key,
categoryName varchar(250)
)

create table Dosage
(
dosageID int IDENTITY (1,1) primary key,
dosageName varchar(250)
)

create table Form
(
formID int IDENTITY (1,1) primary key,
formName varchar(250)
)

create table ProductUnit
(
productUnitID int IDENTITY (1,1) primary key,
productUnitName varchar(250)
)

create table DiscountDataBank
(
discountDataBankID int IDENTITY (1,1) primary key,
discountDataBankName varchar(250)
)

create table City
(
cityID int IDENTITY (1,1) primary key,
cityName varchar(250)
)

create table Province
(
provinceID int IDENTITY (1,1) primary key,
provinceName varchar(250)
)

create table Bank
(
bankID int IDENTITY (1,1) primary key,
bankName varchar(250)
)

create table Reason
(
reasonID int IDENTITY (1,1) primary key,
reasonName varchar(250)
)


alter table Product
add constraint generic_product_fk foreign key (genericID)
references Generic (genericID)

alter table Generic
add constraint generic_category_fk foreign key (categoryID)
references Category (categoryID)

alter table Product
add constraint dosage_product_fk foreign key (dosageID)
references Dosage (dosageID)

alter table Product
add constraint form_product_fk foreign key (formID)
references Form (formID)

alter table ProductUnitPrice
add constraint productUnitPrice_product_fk foreign key (productID)
references Product (productID)

alter table Supplier
add constraint supplier_city_fk foreign key (cityID)
references City (cityID)

alter table Supplier
add constraint supplier_province_fk foreign key (provinceID)
references Province (provinceID)

alter table Customer
add constraint customer_city_fk foreign key (cityID)
references City (cityID)

alter table Customer
add constraint customer_province_fk foreign key (provinceID)
references Province (provinceID)

alter table PurchaseOrder
add constraint supplier_purchaseOrder_fk foreign key (supplierID)
references Supplier (supplierID)

alter table PurchaseOrderDetails
add constraint purchaseOrderDetails_purchaseOrder_fk foreign key (POID)
references PurchaseOrder (POID)

alter table ReceiveRecord
add constraint supplier_receiveRecord_fk foreign key (supplierID)
references Supplier (supplierID)

alter table ReceiveRecord
add constraint reason_receiveRecord_fk foreign key (reasonID)
references Reason (reasonID)

alter table ReceiveRecordDetails
add constraint receiveRecordDetails_receiveRecord_fk foreign key (RRID)
references ReceiveRecord (RRID)

alter table ReceiveRecordDetails
add constraint receiveRecordDetails_purchaseOrderDetails_fk foreign key (PODetailsID)
references PurchaseOrderDetails (PODetailsID)

alter table Payment
add constraint supplier_payment_fk foreign key (supplierID)
references Supplier (supplierID)

alter table Payment
add constraint reason_payment_fk foreign key (reasonID)
references Reason (reasonID)

alter table PaymentDetails
add constraint paymentDetails_payment_fk foreign key (paymentID)
references Payment (paymentID)

alter table PaymentDetails
add constraint paymentDetails_receiveRecordDetails_fk foreign key (RRDetailsID)
references ReceiveRecordDetails (RRDetailsID)

create view productMasterRecord as
	select p.productCode as 'Product Code', g.genericName + p.brandName + d.dosageName as 'Details', f.formName as 'Form',
	u.productUnitName as 'Unit', p.productStatus as 'Status', p.savedBy as 'Saved By', p.saveDT as 'Save Date/Time', p.updatedBy
	as 'Updated by', p.updateDT as 'Update Date/Time', p.deletedBy as 'Deleted by', p.deleteDT as 'Delete Date/Time' from Product p JOIN Generic g 
	on p.genericID = g.genericID JOIN Dosage d on p.dosageID = d.dosageID JOIN Form f on p.formID = f.formID JOIN ProductUnit u on 
	p.productUnitID = u.productUnitID


create view supplierMasterRecord as select s.supplierName as 'Supplier Name', s.supplierAddress + c.cityName + p.provinceName as 'Complete Address', s.contactNo as 'Contact No.',
s.contactPerson as 'Contact Person', s.tinNo, s.savedBy, s.saveDT as 'Save Date/Time', s.updatedBy, s.updateDT as 'Update Date/Time',
s.deletedBy, s.deleteDT as 'Delete Date/Time' from Supplier s JOIN City c on s.cityID = c.cityID JOIN Province p on s.provinceID = p.provinceID



