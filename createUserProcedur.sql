-- ================================================
-- Template generated from Template Explorer using:
-- Create Procedure (New Menu).SQL
--
-- Use the Specify Values for Template Parameters 
-- command (Ctrl-Shift-M) to fill in the parameter 
-- values below.
--
-- This block of comments will not be included in
-- the definition of the procedure.
-- ================================================
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Dvori
-- Create date: 18/11/2025
-- Description:	homework
-- =============================================
CREATE PROCEDURE createUser
	-- Add the parameters for the stored procedure here
	@Name varchar(50),
	@UserName varchar(50),
	@Password varchar(15),
	@id int output
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	insert into Users
	(
		Name,
		Username,
		Password
	)
	values
	(
		@Name,
		@UserName,
		@Password
	)
	set @id = @@IDENTITY
END
GO
