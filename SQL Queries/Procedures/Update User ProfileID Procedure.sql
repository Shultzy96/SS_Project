USE [ShultzStudios]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		<Dakota Shultz>
-- Create date: <12-19-2018>
-- Description:	<Updates the User ProfileID in the Users table>
-- =============================================
CREATE PROCEDURE [dbo].[UPDATE_PROFILEID]
(
	@UserID INT,
	@ProfileID INT
)
AS
BEGIN
	UPDATE dbo.Users
	SET  [ProfileID] = @ProfileID
	WHERE [UserID] = @UserID
END