USE [ShultzStudios]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		<Dakota Shultz>
-- Create date: <12-9-2018>
-- Description:	<Updates a User Profile in the Users table>
-- =============================================
CREATE PROCEDURE [dbo].[UPDATE_PROFILE]
(
	@ProfileID INT,
	@Bio NVARCHAR (500),
	@JobTitle NVARCHAR (120),
	@Achievements NVARCHAR (255),
	@Posts NVARCHAR (500)
	
)
AS
BEGIN
	UPDATE dbo.UserProfiles
	SET [Bio] = @Bio, [JobTitle] = @JobTitle, [Achievements] = @Achievements, [Posts] = @Posts
	WHERE [ProfileID] = @ProfileID
END
