USE [ShultzStudios]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		<Dakota Shultz>
-- Create date: <12/19/2018>
-- Description:	<Create a new role in the UserRoles Table>
-- =============================================
CREATE PROCEDURE [dbo].[CREATE_ROLE]
(
	@RoleID INT,
	@RoleName NVARCHAR (30),
	@RoleDescription NVARCHAR (255)
	
)
AS
BEGIN
	INSERT INTO dbo.UserRoles ([RoleID],[RoleName], [RoleDescription])	
	VALUES                 (@RoleID, @RoleName, @RoleDescription)		  
END