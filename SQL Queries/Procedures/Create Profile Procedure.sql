USE [ShultzStudios]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		<Dakota Shultz>
-- Create date: <12-18-2018>
-- Description:	<Gets all the User Profile Information from the UserProfiles table>
-- =============================================
CREATE PROCEDURE [dbo].[CREATE_PROFILE]
(
	@Bio NVARCHAR (500),
	@JobTitle NVARCHAR (120),
	@Achievements NVARCHAR (255),
	@Posts NVARCHAR (500)
)
AS
BEGIN
	SET NOCOUNT ON;
	INSERT INTO dbo.UserProfiles ([Bio], [JobTitle], [Achievements], [Posts])
	VALUES						 (@Bio, @JobTitle, @Achievements, @Posts)
	SELECT CONVERT (int, SCOPE_IDENTITY())
 
END