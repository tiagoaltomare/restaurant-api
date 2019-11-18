using System.Collections.Generic;

namespace Restaurants.Domain
{
    public interface IRestaurantRepository : IRepositoryBase<Restaurant>
    {
        List<Restaurant> GetAllRestaurants();
        Restaurant GetRestaurantById(int id);
        List<Menu> GetMenuByRestaurant(int id);
        List<Review> GetReviewByRestaurant(int id);
    }
}
