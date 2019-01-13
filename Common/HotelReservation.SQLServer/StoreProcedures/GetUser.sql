CREATE PROCEDURE GetUser
	@Mail nvarchar(30) = NULL
AS
BEGIN
	SELECT * FROM HR.Users 
	WHERE Mail = @Mail
END