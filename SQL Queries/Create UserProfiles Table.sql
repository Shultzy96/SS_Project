USE [ShultzStudios]
GO
-- ========================================================================================
-- Author:		<Dakota Shultz>
-- Create date: <12-8-2018>
-- Description:	<Creating the UserProfiles Table to store User Profile Information>
-- ========================================================================================
CREATE TABLE UserProfiles
(
	ProfileID INT IDENTITY (1,1) PRIMARY KEY,
	Bio NVARCHAR (500),
	JobTitle NVARCHAR (120),
	Achievements NVARCHAR (255),
	Posts NVARCHAR (500)

)
