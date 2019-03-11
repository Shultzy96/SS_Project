USE [ShultzStudios]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		<Dakota Shultz>
-- Create date: <1-8-2019>
-- Description:	<Gets all the User Information from the Database table(s)>
-- =============================================
CREATE PROCEDURE [dbo].[VIEW_USER_INFO]
(
	
)
AS
BEGIN
	SET NOCOUNT ON;
	SELECT  U.UserID, U.ProfileID, U.UserFirstName, U.UserLastName, U.Email, U.UserName, U.RoleID, R.RoleName, U.PayrollID, P.Jobtitle, P.Salary
	FROM dbo.Users U

	JOIN dbo.Payroll P 
	ON U.PayrollID = P.PayrollID

	JOIN dbo.UserRoles R 
	ON U.RoleID = R.RoleID

	
 
END