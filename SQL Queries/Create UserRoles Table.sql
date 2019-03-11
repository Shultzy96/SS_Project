USE [ShultzStudios]
GO
-- ========================================================================================
-- Author:		<Dakota Shultz>
-- Create date: <12-8-2018>
-- Description:	<Creating the UserRoles Table to store RoleID, RoleName and a short RoleDescription>
-- ========================================================================================
CREATE TABLE UserRoles
(
	RoleID INT IDENTITY (1,1) PRIMARY KEY,
	RoleName NVARCHAR(30),
	RoleDescription NVARCHAR(255)

)