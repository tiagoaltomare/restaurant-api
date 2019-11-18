IF EXISTS(SELECT 1 FROM sys.procedures WHERE Name = 'Proc_SelectAllRestaurant')
BEGIN
    DROP PROCEDURE Proc_SelectAllRestaurant
END
GO

CREATE PROCEDURE Proc_SelectAllRestaurant
AS
BEGIN

    SELECT 
        REST.ID,
        REST.SOCIAL_NAME,
        REST.FANTASY_NAME,
        REST.CATEGORY,
        REST.DELIVERY_ESTIMATE,
        REST.RATING,
        REST.IMAGE_PATH,
        REST.ABOUT,
        REST.FUNCTIONAL_HOURS
    FROM 
        RESTAURANT REST

END