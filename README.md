# SQLDapperDataAccess
.NET Winforms app where I demo basic read &amp; insert operations with Dapper.

## Techs
* C# / .NET Framework 4.7
* Dapper 2.0.30
* Microsoft SQL Server

## Tools
* Microsoft Visual Studio 2019
* Microsoft SQL Server Management Studio 2018

## Features
This app was a database-first demo. I created a db "Sample" on my MSSQLLocalDB instance with a People table. The People table has FirstName and LastName columns. The FormUI Winforms application allows a user to search the People table by last name, load all People, or insert a Person.

Three stored procs were created for the db:
* dbo.spPeople_GetAll
* dbo.spPeople_GetByLastName
* dbo.spPeople_Insert

spPeople_GetAll:
```sql
CREATE PROCEDURE [dbo].[spPeople_GetAll]
AS
BEGIN
	SET NOCOUNT ON
	SELECT FirstName, LastName
	FROM dbo.People;
END
```

spPeople_GetByLastName:
```sql
CREATE PROCEDURE [dbo].[spPeople_GetByLastName]
	@LastName nvarchar(50)
AS
BEGIN
	SET NOCOUNT ON
	SELECT FirstName, LastName
	FROM dbo.People
	WHERE LastName = @LastName;
END
```
spPeople_Insert:
```sql
CREATE PROCEDURE [dbo].[spPeople_Insert]
	@FirstName nvarchar(50),
	@LastName nvarchar(50)
AS
BEGIN
	SET NOCOUNT ON
	INSERT INTO dbo.People
	(FirstName, LastName)
	VALUES (@FirstName, @LastName);
END
```

