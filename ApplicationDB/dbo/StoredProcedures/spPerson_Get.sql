CREATE PROCEDURE [dbo].[spPerson_Get]
	@Id int
AS

begin

	select Firstname, Middlename, Lastname, Birthdate, Address, Active
	from dbo.[Person]
	where Id = @Id;

end

