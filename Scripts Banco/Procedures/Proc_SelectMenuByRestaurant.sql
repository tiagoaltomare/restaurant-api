IF EXISTS(SELECT 1 FROM sys.procedures WHERE Name = 'Proc_SelectMenuByRestaurant')
BEGIN
    DROP PROCEDURE Proc_SelectMenuByRestaurant
END
GO

CREATE PROCEDURE Proc_SelectMenuByRestaurant
(
    @ID_RESTAURANT INT
)
AS
BEGIN

    SELECT 
        ID,
        IMAGE_PATH,
        PRODUCT_NAME,
        DESCRIPTION,
        PRICE,
        ID_RESTAURANT
    FROM 
        MENU
    WHERE
        ID_RESTAURANT = @ID_RESTAURANT

END