DROP PROCEDURE CreateUser;
GO
CREATE PROCEDURE CreateUser @Id int, 
							@Email varchar(255),
							@Phonenumber varchar(255),
							@UserPassword varchar(255),
							@Firstname varchar(255),
							@Surname varchar(255),
							@PostalCode int,
							@StreetAddress varchar(255)
AS
INSERT INTO Users
VALUES (
	@Id,
	@Email,
	@Phonenumber,
	@UserPassword,
	@Firstname,
	@Surname,
	@PostalCode,
	@StreetAddress
);
