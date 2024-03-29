USE [ShultzStudios]
GO
/****** Object:  StoredProcedure [dbo].[USER_REGISTER]    Script Date: 12/23/2018 3:14:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		<Dakota Shultz>
-- Create date: <12/9/2018>
-- Description:	<Registering new User into the server database Default ProfileID is 14>
-- =============================================
CREATE PROCEDURE [dbo].[USER_REGISTER]
(
	@UserFirstName NVARCHAR (60),
	@UserLastName NVARCHAR (82),
	@Email NVARCHAR (82),
	@UserName NVARCHAR(32),
	@Password NVARCHAR(24)
	
)
AS
BEGIN
	INSERT INTO dbo.Users ([ProfileID],[UserFirstName], [UserLastName], [Email], [UserName], [Password], [PayrollID], [RoleID])	
	VALUES                 (14, @UserFirstName, @UserLastName, @Email, @UserName, @Password, 0, 1)		  
END