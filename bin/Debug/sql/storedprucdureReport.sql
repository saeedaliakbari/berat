
CREATE PROCEDURE FillReport
	
AS
BEGIN
	select * from Gozaresh
END

CREATE PROCEDURE DeleteReport
	@id int
AS
BEGIN
	delete from Gozaresh
	where Id=@id
END


CREATE PROCEDURE InsertReport
	@name	nvarchar(max),
	@address nvarchar(max)
AS
BEGIN
	insert into Gozaresh
	values (@name,@address)
END


CREATE PROCEDURE [dbo].[UpdateReport]
	@id		int,
	@name	nvarchar(max),
	@address nvarchar(max)
AS
BEGIN
	update	Gozaresh
	set name=@name,address=@address
	where id=@id
END