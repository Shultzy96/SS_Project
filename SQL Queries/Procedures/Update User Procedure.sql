USE [ShultzStudios]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		<Dakota Shultz>
-- Create date: <1-8-2019>
-- Description:	<Updates a Single User in the Users table>
-- =============================================
CREATE PROCEDURE [dbo].[UPDATE_USER]
(
	@UserID INT,
	@UserFirstName NVARCHAR (60),
	@UserLastName NVARCHAR (82),
	@Email NVARCHAR (82),
	@UserName NVARCHAR (32),
	@RoleName NVARCHAR (30), 
	@JobTitle NVARCHAR (120)

)
AS
BEGIN
	UPDATE dbo.Users
	SET [UserFirstName] = @UserFirstName, [UserLastName] = @UserLastName, [Email] = @Email, [UserName] = @UserName
	WHERE [UserID] = @UserID 

	UPDATE dbo.Users
	SET [PayrollID] = P.PayrollID
	FROM dbo.Users U, dbo.Payroll P
	WHERE P.JobTitle = @JobTitle AND U.UserID = @UserID
	
	UPDATE dbo.Users
	SET [RoleID] = R.RoleID
	FROM dbo.Users U, dbo.UserRoles R
	WHERE R.RoleName = @RoleName AND U.UserID = @UserID
END
