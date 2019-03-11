USE [ShultzStudios]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		<Dakota Shultz>
-- Create date: <12-19-2018>
-- Description:	<Deletes a Payroll Item from the Payroll table by PayrollID>
-- =============================================
CREATE PROCEDURE [dbo].[DELETE_PAYROLL_ITEM]
(
	@PayrollID INT = [PayrollID]
)
AS
BEGIN
	DELETE FROM dbo.Users
	WHERE [PayrollID] = @PayrollID

END