use supermarketDB
go
select * from item
alter table item add itemDesc varchar(10) not null
alter table item drop column price;

alter table item add price decimal(5,2) not null
select * from item
insert into item (price, itemDesc)values(1.99, 'eggs');
select * from useraccount
insert into item (price, itemDesc)values(2.99, 'milk');

ALTER TABLE userAccount
ALTER COLUMN balance float not null;

alter table purchase_item
add itemQuantity int not null default 1
select * from Purchase_Item