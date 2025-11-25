SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Dvori
-- Create date: 18/11/2025
-- Description:	homework
-- =============================================
CREATE PROCEDURE updateUser
	@id int output,
	@Password varchar(15)
AS
BEGIN
	SET NOCOUNT ON;
	UPDATE Users
	SET Password = @Password
	WHERE id = @id

END
GO
