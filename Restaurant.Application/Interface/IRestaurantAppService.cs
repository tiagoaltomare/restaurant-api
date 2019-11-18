using Restaurants.Domain;
using System.Collections.Generic;

namespace Restaurants.Application
{
    public interface IRestaurantAppService : IAppServiceBase<Restaurant>
    {
        List<Restaurant> GetAllRestaurants();
        Restaurant GetRestaurantById(int id);
        List<Menu> GetMenuByRestaurant(int id);
        List<Review> GetReviewByRestaurant(int id);
    }
}
