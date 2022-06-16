CREATE PROCEDURE [dbo].[spPerson_Add]
    
	@Firstname nvarchar(50),
    @Middlename nvarchar(50),
    @Lastname nvarchar(50),
    @Birthdate datetime2,
    @Address nvarchar(255),
    @Active bit
AS

begin

    insert into dbo.[Person] (Firstname, Middlename, Lastname, Birthdate, Address, Active)
    values (@Firstname, @Middlename, @Lastname, @Birthdate, @Address, @Active);

end





