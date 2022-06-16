if not exists (select 1 from dbo.[Person])
begin

	insert into dbo.[Person] (Firstname, Middlename, Lastname, Birthdate, Address, Active)
	values ('John', 'Jovence', 'Laspinas', '2022-05-19', 'Dumaguete City', '1')

end