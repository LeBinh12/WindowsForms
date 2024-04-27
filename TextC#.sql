
use QLTS;

Create table Products(
	Products_id int Not Null PRIMARY KEY,
	PRODUCTS_NAME NVARCHAR(50),
	PRICE FLOAT,
	DESCRIBE NVARCHAR(500),
	INGREDIENT NVARCHAR(500)
	
);


CREATE TABLE CUSTOMMER(
	CUSTOMMER_ID INT NOT NULL PRIMARY KEY,
	CUSTOMMER_NAME NVARCHAR(50),
	PHONE NVARCHAR(50),
	CUSTOMMER_ADDRESS TEXT,
	EMAIL NVARCHAR(100)
);

CREATE TABLE ORDERS(
	ORDER_ID INT NOT NULL PRIMARY KEY,
	CUSTOMMER_ID INT,
	PRODUCTS_ID INT,
	QUANTITY INT,
	ORDERS_DATE DATE,

	CONSTRAINT FK_CUSTOMMER FOREIGN KEY (CUSTOMMER_ID) REFERENCES CUSTOMMER(CUSTOMMER_ID),
	CONSTRAINT FK_PRODUCTS FOREIGN KEY (PRODUCTS_ID) REFERENCES PRODUCTS(PRODUCTS_ID)

);

CREATE TABLE STAFF(
	STAFF_ID INT NOT NULL PRIMARY KEY,
	STAFF_NAME NVARCHAR(50),
	STAFF_PHONE NVARCHAR(50),
	STAFF_ADDRESS TEXT,
	STAFF_EMAIL NVARCHAR(100),
	STAFF_POSITION NVARCHAR (50)
);


-------------------------##------------------------------

Create table Users(
	Users_id int not null Primary kEy,
	UserName nvarchar(50),
	UserPassword nvarchar(50),
)

Create table TableFood(
	TableFood_id int primary key,
	TableFood_Name nvarchar(50),
	TableFood_Status nvarchar(50)
);

Create table Category(
	Category_id int not null primary key,
	Category_Name nvarchar(50)
)

create table food(
	Food_id int not null primary key,
	Food_Name nvarchar(50),	
	Category_id int,
	Food_Price int

	CONSTRAINT FK_Category FOREIGN KEY (Category_id) REFERENCES Category(Category_id)



)
	
create table Billtea(
	Bill_id int identity primary key not null,
	DateCheckin date,
	DateCheckout date,
	TableFood_id int,
	Bill_Status int,
	
	CONSTRAINT FK_tablee FOREIGN KEY (TableFood_id) REFERENCES TableFood(TableFood_id)

)



drop table Bill_tea



create table BillIfor(
	BillInfor_id int identity not null primary key,
	Bill_id int ,
	Food_id int,
	BillCount int,

	CONSTRAINT FK_Foodi FOREIGN KEY (Food_id) REFERENCES Food(Food_id),
	CONSTRAINT FK_Billi FOREIGN KEY (Bill_id) REFERENCES Billtea(Bill_id)

)

Drop dbo.

insert into Users(Users_id,UserName,UserPassword) Values (1,'Le Phuoc Binh','123456') 

insert into Products(Products_id,PRODUCTS_NAME,PRICE,DESCRIBE,INGREDIENT) values (2,'Trà sữa Trân Trâu Đường Đen', 30000, 'Ngọt', 'Đường Đen' );

insert into TableFood(TableFood_id,TableFood_Name,TableFood_Status) values (1,N'Ban 1',N'')
insert into TableFood(TableFood_id,TableFood_Name,TableFood_Status) values (2,N'Ban 2',N'')
insert into TableFood(TableFood_id,TableFood_Name,TableFood_Status) values (3,N'Ban 3',N'')
insert into TableFood(TableFood_id,TableFood_Name,TableFood_Status) values (4,N'Ban 4',N'')
insert into TableFood(TableFood_id,TableFood_Name,TableFood_Status) values (5,N'Ban 5',N'')
insert into TableFood(TableFood_id,TableFood_Name,TableFood_Status) values (6,N'Ban 6',N'')
--Vongf laap 
Declare @i int = 0
while @i<=20
Begin
	insert into TableFood(TableFood_id,TableFood_Name,TableFood_Status) values (@i,N'Ban '+ Cast (@i as nvarchar(100)) ,N'Trống')
	set @i =@i +1
	--Delete TableFood where TableFood_id = 0;
End

Select * from TableFood
--tạo store procedure 

Update dbo.TableFood set TableFood_Status = N'Có Người' where TableFood_id = 5;

Create Proc USPP_login
@UserName nvarchar(50),
@UserPassword nvarchar(50)
As
Begin	 
	Select * from dbo.Users where UserName = @UserName and UserPassword = @UserPassword
End
5

Create Proc USP_GetTableList
as select * from dbo.TableFood
go 

Create or alter Proc USP_InsertBill
@idTable int
As
Begin
	insert Billtea(DateCheckin,DateCheckout,TableFood_id,Bill_Status,discount) values (GETDATE(),null,@idTable,0,0)

end


Alter Proc USP_InsertBillInfor
@idBill int, @idFood int, @count int
As
Begin

	Declare @isExitsBillinFor Int
	Declare @foodCount int = 1
	Select @isExitsBillinFor = BillInfor_id , @foodCount = b.BillCount  From dbo.BillIfor as b where Bill_id = @idBill and Food_id = @idFood

	if(@isExitsBillinFor>0)
	Begin
		Declare  @newCount int = @foodCount + @count
		if (@newCount > 0)

			Update dbo.BillIfor set BillCount = @foodCount + @count where Bill_id = @idBill and Food_id = @idFood

		else
			Delete dbo.BillIfor Where Bill_id = @idBill and Food_id = @idFood

	end
	else
	Begin 
			insert into BillIfor(Bill_id,Food_id,BillCount) values (@idBill,@idFood,@count)
	
	end



end

exec dbo.USP_GetTableList

Select * from Users where UserName = N'dsadas' and UserPassword =N''or 1=1--'
Select * from Users where UserName = N'dsadas' and UserPassword =N'';
Select * from Users where UserName = N'Le Phuoc Binh' and UserPassword =N'123456'

select * from Users where UserName =N'' or 1=1--
--add Table 
Declare @i int = 0
while @i<=20
Begin
	insert into TableFood(TableFood_id,TableFood_Name,TableFood_Status) values (@i,N'Ban '+ Cast (@i as nvarchar(100)) ,N'Trống')
	set @i =@i +1
	--Delete TableFood where TableFood_id = 0;
End

--Add category




insert into Category(Category_id,Category_Name) values (1,N'Trà sữa')
insert into Category(Category_id,Category_Name) values (2,N'Hồng Trà')
insert into Category(Category_id,Category_Name) values (3,N'Ăn Vặt')
insert into Category(Category_id,Category_Name) values (4,N'Cafe')


-- Add Food


insert into food(Food_id,Food_Name,Category_id,Food_Price) values (1,N'Trà sữa truyền thống',1,18000)
insert into food(Food_id,Food_Name,Category_id,Food_Price) values (2,N'Trà sữa truyền thống lớn',1,20000)
insert into food(Food_id,Food_Name,Category_id,Food_Price) values (3,N'Trà sữa socola',1,20000)
insert into food(Food_id,Food_Name,Category_id,Food_Price) values (4,N'Trà sữa socola Lớn',1,23000)
insert into food(Food_id,Food_Name,Category_id,Food_Price) values (5,N'Trà sữa matcha',1,20000)
insert into food(Food_id,Food_Name,Category_id,Food_Price) values (6,N'Trà sữa matcha Lớn',1,23000)
insert into food(Food_id,Food_Name,Category_id,Food_Price) values (7,N'Trà sữa khoai môn',1,20000)
insert into food(Food_id,Food_Name,Category_id,Food_Price) values (8,N'Trà sữa khoai môn Lớn',1,23000)
insert into food(Food_id,Food_Name,Category_id,Food_Price) values (9,N'Trà chanh sả mặt ông',2,35000)
insert into food(Food_id,Food_Name,Category_id,Food_Price) values (10,N'Trà Vải',2,35000)
insert into food(Food_id,Food_Name,Category_id,Food_Price) values (11,N'Trà Lipton ',2,15000)
insert into food(Food_id,Food_Name,Category_id,Food_Price) values (12,N'Trà Đào',2,15000)
insert into food(Food_id,Food_Name,Category_id,Food_Price) values (13,N'Trà trái cây nhiệt đới',2,35000)
insert into food(Food_id,Food_Name,Category_id,Food_Price) values (14,N'Xoái lắc',3	,15000)
insert into food(Food_id,Food_Name,Category_id,Food_Price) values (15,N'Khô Bò',3	,15000)
insert into food(Food_id,Food_Name,Category_id,Food_Price) values (16,N'Xoái lắc',3	,15000)
insert into food(Food_id,Food_Name,Category_id,Food_Price) values (17,N'Khoai tây chiên nhỏ',3,15000)
insert into food(Food_id,Food_Name,Category_id,Food_Price) values (18,N'Khoai tây chiên lớn',3,25000)
insert into food(Food_id,Food_Name,Category_id,Food_Price) values (19,N'Cafe đen nhỏ',4,30000)
insert into food(Food_id,Food_Name,Category_id,Food_Price) values (20,N'Cafe đen lớn',4,36000)
insert into food(Food_id,Food_Name,Category_id,Food_Price) values (21,N'Cafe sữa nhỏ',4,33000)
insert into food(Food_id,Food_Name,Category_id,Food_Price) values (22,N'Cafe sữa vừa',4,35000)
insert into food(Food_id,Food_Name,Category_id,Food_Price) values (23,N'Cafe sữa lớn',4,45000)
insert into food(Food_id,Food_Name,Category_id,Food_Price) values (24,N'Cafe cappuccino',4,35000)
insert into food(Food_id,Food_Name,Category_id,Food_Price) values (25,N'Cafe latte',4,40000)

--thêm Bill



insert into Billtea(DateCheckin,DateCheckout,TableFood_id,Bill_Status) values (GETDATE(),null,1,0)
insert into Billtea(DateCheckin,DateCheckout,TableFood_id,Bill_Status) values (GETDATE(),null,2,0)
insert into Billtea(DateCheckin,DateCheckout,TableFood_id,Bill_Status) values (GETDATE(),null,3,1)

--add BillInfor

insert into BillIfor(Bill_id,Food_id,BillCount) values (1,1,2)
insert into BillIfor(Bill_id,Food_id,BillCount) values (1,3,4)
insert into BillIfor(Bill_id,Food_id,BillCount) values (1,5,1)
insert into BillIfor(Bill_id,Food_id,BillCount) values (2,4,2)
insert into BillIfor(Bill_id,Food_id,BillCount) values (2,7,3)
insert into BillIfor(Bill_id,Food_id,BillCount) values (3,1,6)
insert into BillIfor(Bill_id,Food_id,BillCount) values (3,10,2)


select * from Category
select * from food
select * from Bill_tea
select * from BillInfor


select f.Food_Name,bi.BillCount,f.Food_Price,f.Food_Price*bi.BillCount as totalPrice from dbo.BillIfor as bi,dbo.Billtea as b,dbo.food as f where bi.Bill_id = b.Bill_id and bi.Food_id = f.Food_id and b.TableFood_id = 3








select MAX(Bill_id) From dbo.Billtea
select * from Category
select * from food
select * from food where Category_id = 3
select * from BillTea


update dbo.Billtea set Bill_Status = 1 where Bill_id = 1

select*from BillIfor

Create or alter Trigger UTG_UpdateBillIfor
on  dbo.BillIfor for insert, update 
as
Begin

	declare @idBill int
	
	select @idBill=Bill_id from inserted

	Declare @idTable int

	select @idTable=TableFood_id from dbo.Billtea where Bill_id = @idBill and Bill_Status = 0
	
	declare @count int
	Select @count = Count(*) from BillIfor where Bill_id = @idBill

	if(@count > 0)
	begin
	Update dbo.TableFood set TableFood_Status=N'Có Người' WHERE TableFood_id = @idTable
	end
	else
	begin
	Update dbo.TableFood set TableFood_Status=N'Trống' WHERE TableFood_id = @idTable
	end

	

end



select*from BillTea

go
create or alter TRIGGER UPG_UPDATEBILLTEA
ON DBO.BILLTEA FOR insert,UPDATE
AS
BEGIN
	DECLARE @IDBILL INT

	SELECT @IDBILL = BILL_ID FROM inserted

	DECLARE @IDTABLE INT

	select @idTable=TableFood_id from dbo.Billtea where Bill_id = @idBill 

	DECLARE @COUNT INT =  0

	SELECT @COUNT = COUNT(*) FROM DBO.Billtea WHERE TableFood_id = @IDTABLE AND Bill_Status = 0

	IF(@COUNT = 0)
	
		UPDATE DBO.TableFood SET TableFood_Status = N'Trống' where TableFood_id = @IDTABLE 
	
END

select*from Billtea
DELETE DBO.BillIfor
delete Billtea 


select*from TableFood


alter table BillTea 
add discount int

update Billtea set discount = 0
go


create or alter Proc sp_switchTable
@idTable1 int ,@idTable2 int
as
begin 

	declare @idFirtsBill int
	declare @idSeconrdBill int

	declare @isFirstTableEmty int = 1;
	declare @isSeconrdTableEmty int = 1;


	select @idSeconrdBill = Bill_id from Billtea where TableFood_id = @idTable2 and Bill_Status = 0
	select @idFirtsBill = Bill_id from Billtea where TableFood_id = @idTable1 and Bill_Status = 0

	if(@idFirtsBill is NULL)--Khi so sánh vs null nên dùng is
	Begin
		Insert into Billtea(DateCheckin,DateCheckout,TableFood_id,Bill_Status) Values (GETDATE(),Null,@idTable1,0)
		select @idFirtsBill = Max(Bill_id) from Billtea where TableFood_id = @idTable1 and Bill_Status = 0
		
	end

	select @isFirstTableEmty = COUNT(*) from BillIfor where Bill_id = @idFirtsBill 

	if(@idSeconrdBill is NULL)--Khi so sánh vs null nên dùng is
	Begin
		Insert into Billtea(DateCheckin,DateCheckout,TableFood_id,Bill_Status) Values (GETDATE(),Null,@idTable2,0)
		select @idSeconrdBill = Max(Bill_id) from Billtea where TableFood_id = @idTable2 and Bill_Status = 0

	

	end
	select @isSeconrdTableEmty = COUNT(*) from BillIfor where Bill_id = @idSeconrdBill



	select BillInfor_id INTO IdBillInforTable from dbo.BillIfor where Bill_id = @idseconrdBill

	Update dbo.BillIfor set Bill_id = @idseconrdBill where Bill_id = @idFirtsBill

	Update dbo.BillIfor set Bill_id = @idFirtsBill where BillInfor_id in (select * from IdBillInforTable)



	drop table IdBillInforTable
	if(@isFirstTableEmty = 0)
		Update TableFood set TableFood_Status = N'Trống' where TableFood_id = @idTable2
	if(@isSeconrdTableEmty =0)
		Update TableFood set TableFood_Status = N'Trống' where TableFood_id = @idTable1
end
go

