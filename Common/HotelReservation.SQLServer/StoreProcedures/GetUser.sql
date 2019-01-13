create PROCEDURE GetUser

@mail nvarchar(30)
AS
SELECT * FROM HR.Users where Mail=@mail
GO; 