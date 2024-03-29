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
CREATE PROCEDURE [dbo].[VIEW_PAYROLL]

AS
BEGIN
	SET NOCOUNT ON;
	SELECT   PayrollID,
		     JobTitle,
			 JobDescription,
			 HourlyRate,
			 Salary

	FROM dbo.Payroll
END
