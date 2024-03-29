USE [ShultzStudios]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		<Dakota Shultz>
-- Create date: <12-19-2018>
-- Description:	<Deletes a User Profile from the UserProfiles table by ProfileID>
-- =============================================
CREATE PROCEDURE [dbo].[DELETE_PROFILE]
(
	@ProfileID INT = [ProfileID]
)
AS
BEGIN
	DELETE FROM dbo.Users
	WHERE [ProfileID] = @ProfileID

END
