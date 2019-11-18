IF EXISTS(SELECT 1 FROM sys.procedures WHERE Name = 'Proc_InsertOrderItem')
BEGIN
    DROP PROCEDURE Proc_InsertOrderItem
END
GO

CREATE PROCEDURE Proc_InsertOrderItem
(
    @QUANTITY int,
    @PRICE  decimal(18, 0),    
    @ID_PRODUTO int,
	@ID_ORDER int
)
AS
BEGIN
    
	INSERT INTO ORDER_ITEM VALUES (@QUANTITY, @PRICE, @ID_PRODUTO, @ID_ORDER)

    RETURN SCOPE_IDENTITY()
END