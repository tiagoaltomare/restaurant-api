IF EXISTS(SELECT 1 FROM sys.procedures WHERE Name = 'Proc_InsertOrder')
BEGIN
    DROP PROCEDURE Proc_InsertOrder
END
GO

CREATE PROCEDURE Proc_InsertOrder
(
    @EMAIL varchar(150),
	@TELEPHONE varchar(30),
	@ADRESS varchar(200),
	@NUMBER varchar(30),
	@OPTIONAL_ADRESS varchar(100),    
    @PAYMENT_OPTION varchar(50)
)
AS
BEGIN
    
	DECLARE @ID_PAYMENT_OPTION int
	DECLARE @ID_USER int

    SELECT @ID_PAYMENT_OPTION = ID FROM PAYMENT_OPTION P WHERE P.NAME = @PAYMENT_OPTION
    SELECT @ID_USER = ID FROM CUSTOMER C WHERE C.EMAIL = @EMAIL
    
    INSERT INTO [ORDER] VALUES
    (
        @EMAIL,
        @TELEPHONE,
        @ADRESS,
        @NUMBER,
        @OPTIONAL_ADRESS,    
        @ID_PAYMENT_OPTION,
        @ID_USER
    )

    SELECT SCOPE_IDENTITY()
END