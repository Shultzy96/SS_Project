USE ShultzStudios
GO

-- =============================================
-- Author:		<Dakota Shultz>
-- Create date: <12-9-2018>
-- Description:	<Gets all the Users from the Users table>
-- =============================================
CREATE PROCEDURE VIEW_USERS

AS
BEGIN
	SET NOCOUNT ON;
	SELECT UserID,
		   UserFirstName,
		   UserLastName,
		   Email,
		   UserName,
		   [Password],
		   RoleID
	FROM dbo.Users
END
GO
