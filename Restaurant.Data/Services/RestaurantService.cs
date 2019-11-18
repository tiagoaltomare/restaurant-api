using Restaurants.Domain;
using System.Collections.Generic;

namespace Restaurants.Data.Services
{
    public class RestaurantService : ServiceBase<Restaurant>, IRestaurantService
    {
        private readonly IRestaurantRepository _serviceRepository;

        public RestaurantService(IRestaurantRepository serviceRepository) : base(serviceRepository)
        {
            _serviceRepository = serviceRepository;
        }

        public List<Restaurant> GetAllRestaurants()
        {
            return _serviceRepository.GetAllRestaurants();
        }
        public Restaurant GetRestaurantById(int id)
        {
            return _serviceRepository.GetRestaurantById(id);
        }

        public List<Menu> GetMenuByRestaurant(int id)
        {
            return _serviceRepository.GetMenuByRestaurant(id);
        }

        public List<Review> GetReviewByRestaurant(int id)
        {
            return _serviceRepository.GetReviewByRestaurant(id);
        }
    }
}
