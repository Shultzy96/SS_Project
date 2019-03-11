USE [ShultzStudios]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		<Dakota Shultz>
-- Create date: <12-19-2018>
-- Description:	<Gets all the Payroll Information from the Payroll table>
-- =============================================
CREATE PROCEDURE [dbo].[CREATE_PAYROLL_ITEM]
(
	@PayrollID INT,
	@JobTitle NVARCHAR (120),
	@JobDescription NVARCHAR (255),
	@HourlyRate DECIMAL,
	@Salary DECIMAL
)
AS
BEGIN
	SET NOCOUNT ON;
	INSERT INTO dbo.Payroll ([PayrollID], [JobTitle], [JobDescription], [HourlyRate], [Salary])
	VALUES						 (@PayrollID, @JobTitle, @JobDescription, @HourlyRate, @Salary)

END