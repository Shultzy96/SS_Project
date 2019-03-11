USE [ShultzStudios]
GO

-- =============================================
-- Author:		<Dakota Shultz>
-- Create date: <12/9/2018>
-- Description:	<Checking user login data agaisnt stored server data>
-- =============================================
CREATE PROCEDURE USER_LOGIN
(
	@UserName VARCHAR(32),
	@Password VARCHAR(24)

)
AS
BEGIN
	SELECT U.UserID, U.ProfileID, U.UserName, P.JobTitle, R.RoleName
    FROM dbo.Users U
	
	JOIN dbo.UserRoles R 
	ON U.RoleID = R.RoleID

	JOIN dbo.Payroll P 
	ON U.PayrollID = P.PayrollID
				  
	WHERE  @UserName = [UserName] AND @Password = [Password]
END
