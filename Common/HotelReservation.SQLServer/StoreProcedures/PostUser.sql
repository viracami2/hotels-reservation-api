ALTER PROCEDURE PostUser
	@Username VARCHAR(50) = NULL,
	@Mail	  VARCHAR(50) = NULL,
	@PassWord VARCHAR(50) = NULL
AS
BEGIN
--

INSERT INTO [HR].[Users](
			 Username,
             Mail,
             Password)
     VALUES(    
            @Username,
            @Mail,
            @PassWord)
--
END