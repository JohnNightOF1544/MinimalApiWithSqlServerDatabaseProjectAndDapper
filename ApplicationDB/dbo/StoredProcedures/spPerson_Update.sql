CREATE PROCEDURE [dbo].[spPerson_Update]
    @Id int,
	@Firstname	nvarchar(50),
    @Middlename nvarchar(50),
    @Lastname nvarchar(50),
    @Birthdate datetime2,
    @Address nvarchar(255),
    @Active bit
AS

begin

    update dbo.[Person]
    set Firstname = @Firstname, Middlename = @Middlename,
        Lastname = @Lastname, Birthdate = @Birthdate, Address = @Address, Active = @Active
    where Id = @Id;

end




