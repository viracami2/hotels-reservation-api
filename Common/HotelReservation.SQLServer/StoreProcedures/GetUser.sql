CREATE PROCEDURE GetUser
	@mail nvarchar(30)
AS
BEGIN
	SELECT * FROM HR.Users where Mail = @mail
END