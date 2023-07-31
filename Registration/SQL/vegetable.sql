create table Vegetable
(
Sno int not null primary key identity (1,1),
Vegetablename nvarchar (200) not null,
Ownername nvarchar (200) not null,
Quantity decimal not null,
Price decimal not null,
Location nvarchar (200) null
)

select * from Vegetable

create or alter Procedure Veginsert(@Vegetablename nvarchar (200),@Ownername nvarchar (200),@Quantity decimal ,@Price decimal,@Location nvarchar (200))
As
Begin
insert into Vegetable(Vegetablename,Ownername,Quantity,Price,Location) values (@Vegetablename,@Ownername,@Quantity,@Price,@Location)
End

Exec Veginsert 'Carrat','Ajay',50.00,45.5,'Ooty'

select * from Vegetable

alter Procedure selectveg 
as
begin
select * from Vegetable
end

Exec selectveg

create or alter Procedure selectveg (@Sno int)
as
begin
select * from Vegetable where @Sno = Sno;
end

Exec selectveg 1

create procedure Vegupdate(@Sno int,@Vegetablename nvarchar (200),@Ownername nvarchar (200),@Quantity decimal ,@Price decimal,@Location nvarchar (200))
as
begin
update Vegetable
set
Vegetablename = @Vegetablename,
Ownername = @Ownername,
Quantity =@Quantity,
Price = @Price,
Location = @Location
where
Sno = @Sno
end

Exec Vegupdate 3,'Onion','Hari',50.5,68.98,'Pollachi'

create procedure vegdelete(@Sno int)
as
begin
delete from Vegetable where Sno = @Sno;
end

Exec vegdelete 2