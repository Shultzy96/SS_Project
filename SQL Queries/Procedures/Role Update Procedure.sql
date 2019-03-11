USE [ShultzStudios]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		<Dakota Shultz>
-- Create date: <12-19-2018>
-- Description:	<Updates a Role in the UserRoles table>
-- =============================================
CREATE PROCEDURE [dbo].[UPDATE_ROLE]
(
	@RoleID INT,
	@RoleName NVARCHAR (30),
	@RoleDescription NVARCHAR (255)

)
AS
BEGIN
	UPDATE dbo.UserRoles
	SET  [RoleName] = @RoleName, [RoleDescription] = @RoleDescription
	WHERE [RoleID] = @RoleID
END