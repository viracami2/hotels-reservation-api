alter PROCEDURE PostHotel

	@NumberIdentification VARCHAR(50) = NULL,
	@HotelName VARCHAR(50) = NULL,
	@HotelType VARCHAR(50) = NULL,
	@AddressLine VARCHAR(50) = NULL,
	@Mail VARCHAR(50) = NULL,
	@Code varchar(512) =null output,
	@Content VARCHAR(1024) =null OUTPUT,
	@DescriptionContent VARCHAR(1024) =null output
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
			
				SET	 @Code =1
				SET	@Content='Hotel registrado correctamente'
				SET @DescriptionContent ='nice'	
END