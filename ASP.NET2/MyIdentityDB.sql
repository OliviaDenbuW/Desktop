CREATE DATABASE MyIdentityDB

SELECT * FROM AspNetUsers
INSERT INTO AspNetRoles ([Id], [Name])
	VALUES (2, 'User')

INSERT INTO AspNetUsers
	([Id],
	UserName,
	EmailConfirmed,
	PhoneNumberConfirmed,
	TwoFactorEnabled,
	LockoutEnabled,
	AccessFailedCount)
	VALUES (2, 'Maria', 1, 0, 0, 1, 1)
