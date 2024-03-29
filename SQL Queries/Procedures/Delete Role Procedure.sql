USE [ShultzStudios]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		<Dakota Shultz>
-- Create date: <12-19-2018>
-- Description:	<Deletes a Role from the UserRoles table by RoleID>
-- =============================================
CREATE PROCEDURE [dbo].[DELETE_ROLE]
(
	@RoleID INT = [RoleID]
)
AS
BEGIN
	DELETE FROM dbo.UserRoles
	WHERE [RoleID] = @RoleID

END
