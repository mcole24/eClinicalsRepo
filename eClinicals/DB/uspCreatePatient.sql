SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE dbo.uspCreatePatient @last VARCHAR(45), @first VARCHAR(45), @dob DATE, @street VARCHAR(100), @city VARCHAR(100), @state CHAR(2), @zip CHAR(5), @phone VARCHAR(20), @gender CHAR(1), @SSN CHAR(9)
AS
BEGIN
	SET NOCOUNT ON;
	DECLARE @contact INT;
	BEGIN TRAN
	BEGIN TRY
		INSERT INTO contact (lName, fName, dob, mailingAddressStreet, mailingAddressCity, mailingAddressState, mailingAddressZip, phoneNumber, gender, SSN, userType) VALUES (@last, @first, @dob, @street, @city, @state, @zip, @phone, @gender, @SSN, 4);
		SET @contact = SCOPE_IDENTITY();
		INSERT INTO patient (contactID) VALUES (@contact);
		COMMIT TRAN;
	END TRY
	BEGIN CATCH
		ROLLBACK TRAN;
	END CATCH
END
GO
