﻿ALTER PROCEDURE GetHotel
	@Id NVARCHAR(30) = NULL
AS
BEGIN
	SELECT * FROM HR.Hotels 
	WHERE NumberIdentification = @Id
END