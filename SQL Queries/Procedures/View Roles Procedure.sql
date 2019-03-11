USE [ShultzStudios]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		<Dakota Shultz>
-- Create date: <12-19-2018>
-- Description:	<Gets all the Role Information from the UserRoles table>
-- =============================================
CREATE PROCEDURE [dbo].[VIEW_ROLES]

AS
BEGIN
	SET NOCOUNT ON;
	SELECT RoleID,
		   RoleName,
		   RoleDescription
		 
	FROM dbo.UserRoles
END
