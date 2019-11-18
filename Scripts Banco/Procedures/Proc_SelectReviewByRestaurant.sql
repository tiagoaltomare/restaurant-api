IF EXISTS(SELECT 1 FROM sys.procedures WHERE Name = 'Proc_SelectReviewByRestaurant')
BEGIN
    DROP PROCEDURE Proc_SelectReviewByRestaurant
END
GO

CREATE PROCEDURE Proc_SelectReviewByRestaurant
(
    @ID_RESTAURANT INT
)
AS
BEGIN

    SELECT 
        ID,
        USER_NAME,
        DATE_REVIEW,
        RATING,
        COMMENTS,
        ID_RESTAURANT
    FROM 
        REVIEW
    WHERE
        ID_RESTAURANT = @ID_RESTAURANT

END