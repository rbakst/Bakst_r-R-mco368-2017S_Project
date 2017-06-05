
create database SUPERMARKETDB
go
use SUPERMARKETDB
go 

create table UserAccount (username varchar(10), pswd char(8), balance decimal(2,2),
	constraint PK_UserAccount primary key (username))

create table Purchase (PurchaseID int identity(1,1), username varchar(10), numItems int, totalPrice decimal (2,2), purchaseDate date,
	constraint PK_Purchase primary key (PurchaseID),
	constraint FK_Purchase_UserAccount foreign key (username) references Useraccount(username))

create table Item (itemID int identity(1,1), price decimal(2,2),
	constraint PK_Item primary key (itemID))

create table Purchase_Item ( purchaseID int identity (1,1), itemID int,
	constraint PK_Purchase_Item primary key ( purchaseID, itemID),
	constraint FK_Purchase_Item_PurchaseID foreign key (purchaseID) references Purchase(purchaseID),
	constraint FK_Purchase_Item_ItemID foreign key (itemID) references Item(itemID))
	
create table Payment (paymentID int identity(1,1), amount decimal (2,2), username varchar(10),
	constraint PK_Payment primary key (paymentID),
	constraint FK_Payment_Useraccount foreign key (username) references useraccount(username)
) 
	