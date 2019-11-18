using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Restaurants.Application;
using Restaurants.Domain;

namespace Restaurants.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RestaurantController : ControllerBase
    {
        private readonly IRestaurantAppService _appService;

        public RestaurantController(IRestaurantAppService appService)
        {
            _appService = appService;
        }

        [HttpGet]
        public IEnumerable<Restaurant> Get()
        {
            return _appService.GetAllRestaurants();
        }

        [HttpGet("{id}")]
        public Restaurant Get(int id)
        {
            return _appService.GetRestaurantById(id);
        }

        [HttpGet]
        [Route("menus/{id}")]
        public List<Menu> GetMenus(int id)
        {
            return _appService.GetMenuByRestaurant(id);
        }

        [HttpGet]
        [Route("reviews/{id}")]
        public List<Review> GetReviews(int id)
        {
            return _appService.GetReviewByRestaurant(id);
        }
    }
}