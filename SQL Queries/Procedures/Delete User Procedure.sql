USE ShultzStudios
GO

-- =============================================
-- Author:		<Dakota Shultz>
-- Create date: <12-9-2018>
-- Description:	<Deletes a Single User from the Users table by UserID>
-- =============================================
CREATE PROCEDURE DELETE_USER
(
	@UserID INT = [UserID]
)
AS
BEGIN
	DELETE FROM dbo.Users
	WHERE [UserID] = @UserID

END
GO