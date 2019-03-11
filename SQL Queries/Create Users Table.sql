USE [ShultzStudios]
GO
-- ========================================================================================
-- Author:		<Dakota Shultz>
-- Create date: <12-8-2018>
-- Description:	<Creating the Users Table to store Usernames and Passwords and their Role>
-- ========================================================================================
CREATE TABLE Users
(
	UserID INT IDENTITY (1,1) PRIMARY KEY,
	ProfileID INT FOREIGN KEY REFERENCES dbo.UserProfiles (ProfileID),
	UserFirstName NVARCHAR (60),
	UserLastName NVARCHAR (82),
	Email NVARCHAR (82),
	UserName NVARCHAR(32),
	[Password] NVARCHAR (256),
	PayrollID INT FOREIGN KEY REFERENCES dbo.Payroll (PayrollID),
	RoleID INT FOREIGN KEY REFERENCES dbo.UserRoles (RoleID)

)
