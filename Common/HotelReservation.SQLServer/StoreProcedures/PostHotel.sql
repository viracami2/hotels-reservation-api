alter PROCEDURE PostHotel

	@NumberIdentification VARCHAR(50) = NULL,
	@HotelName VARCHAR(50) = NULL,
	@HotelType VARCHAR(50) = NULL,
	@AddressLine VARCHAR(50) = NULL,
	@Mail VARCHAR(50) = NULL
AS
BEGIN
--

INSERT INTO [HR].[Hotels](
			 HotelName,
			 NumberIdentification,			 
			 HotelType,
             AddressLine,
             Mail)
     VALUES(
			@HotelName,
			@NumberIdentification,
            @HotelType,
			@AddressLine,
            @Mail
            )

END