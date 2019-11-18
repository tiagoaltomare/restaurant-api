IF EXISTS(SELECT 1 FROM sys.procedures WHERE Name = 'Proc_SelectCustomerByEmail')
BEGIN
    DROP PROCEDURE Proc_SelectCustomerByEmail
END
GO

CREATE PROCEDURE Proc_SelectCustomerByEmail
(
    @EMAIL VARCHAR(150)
)
AS
BEGIN

    SELECT
        US.ID,
        US.NAME,
        US.EMAIL,
        US.TELEPHONE,
        US.ADRESS,
        US.NUMBER,
        US.OPTIONAL_ADRESS,
        US.ACCESS_KEY,
        US.IMAGE_PATH,
        US.ID_PERMISSION
    FROM 
        CUSTOMER US
    WHERE
        US.EMAIL = @EMAIL

END