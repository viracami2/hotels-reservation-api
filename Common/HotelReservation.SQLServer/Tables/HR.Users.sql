﻿CREATE TABLE HR.Users (
	UserId		UNIQUEIDENTIFIER DEFAULT(NEWID()) PRIMARY KEY NOT NULL,
	Username 	VARCHAR(100) NOT NULL,
	Password 	VARCHAR(100) NOT NULL
)