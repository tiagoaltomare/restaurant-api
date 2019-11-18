using Restaurants.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurants.Application
{
    public class RestaurantAppService : AppServiceBase<Restaurant>, IRestaurantAppService
    {
        private readonly IRestaurantService _appService;

        public RestaurantAppService(IRestaurantService appService) : base(appService)
        {
            _appService = appService;
        }

        public List<Restaurant> GetAllRestaurants()
        {
            return _appService.GetAllRestaurants();
        }

        public Restaurant GetRestaurantById(int id)
        {
            return _appService.GetRestaurantById(id);
        }

        public List<Menu> GetMenuByRestaurant(int id)
        {
            return _appService.GetMenuByRestaurant(id);
        }

        public List<Review> GetReviewByRestaurant(int id)
        {
            return _appService.GetReviewByRestaurant(id);
        }
    }
}
