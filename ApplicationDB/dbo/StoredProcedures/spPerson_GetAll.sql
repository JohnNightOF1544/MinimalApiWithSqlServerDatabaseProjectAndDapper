CREATE PROCEDURE [dbo].[spPerson_GetAll]

AS

begin

	select Firstname, Middlename, Lastname, Birthdate, Address, Active
	from dbo.[Person];

end