USE [ShultzStudios]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		<Dakota Shultz>
-- Create date: <12-19-2018>
-- Description:	<Updates a Single Item in the Payroll table>
-- =============================================
CREATE PROCEDURE [dbo].[UPDATE_PAYROLL_ITEM]
(
	@PayrollID INT,
	@JobTitle NVARCHAR (120),
	@JobDescription NVARCHAR (255),
	@HourlyRate DECIMAL,
	@Salary DECIMAL
)
AS
BEGIN
	UPDATE dbo.Payroll
	SET  [JobTitle] = @JobTitle, [JobDescription] = @JobDescription, [HourlyRate] = @HourlyRate, [Salary] = @Salary
	WHERE [PayrollID] = @PayrollID
END
