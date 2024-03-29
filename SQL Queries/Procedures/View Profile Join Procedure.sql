USE [ShultzStudios]
GO
/****** Object:  StoredProcedure [dbo].[VIEW_PROFILE]    Script Date: 12/20/2018 7:51:51 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		<Dakota Shultz>
-- Create date: <12-18-2018>
-- Description:	<Gets all the User Profile Information from the UserProfiles table>
-- =============================================
CREATE PROCEDURE [dbo].[VIEW_PROFILE]
(
	@ProfileID INT
)
AS
BEGIN
	SET NOCOUNT ON;
	SELECT P.ProfileID, U.UserFirstName, U.UserLastName, U.Email, U.UserName, P.Bio, P.JobTitle, P.Achievements, P.Posts
	FROM dbo.Users U

	JOIN dbo.UserProfiles P 
	ON U.ProfileID = P.ProfileID

	WHERE U.ProfileID = @ProfileID
 
END