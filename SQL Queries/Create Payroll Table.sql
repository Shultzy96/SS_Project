USE [ShultzStudios]
GO
-- ========================================================================================
-- Author:		<Dakota Shultz>
-- Create date: <12-8-2018>
-- Description:	<Creating the Payroll Table to store Salary and Payment Information>
-- ========================================================================================
CREATE TABLE Payroll
(
	PayrollID INT IDENTITY (1,1) PRIMARY KEY,
	JobTitle NVARCHAR (120),
	JobDescription NVARCHAR (255),
	HourlyRate MONEY,
	Salary MONEY
)
