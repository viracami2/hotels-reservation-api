﻿CREATE TABLE HR.Hotels (
	Id			UNIQUEIDENTIFIER DEFAULT(NEWID()) PRIMARY KEY NOT NULL,
	NumberIdentification VARCHAR(100)not null,
	HotelName	VARCHAR(100) NOT NULL,
	HotelType	VARCHAR(100) NOT NULL,
	AddressLine	VARCHAR(100) NOT NULL,
	Mail		VARCHAR(100) NOT NULL
)