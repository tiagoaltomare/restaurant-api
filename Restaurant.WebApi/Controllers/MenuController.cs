using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Restaurants.Application;
using Restaurants.Domain;

namespace Restaurants.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MenuController : ControllerBase
    {
        private readonly IMenuAppService _appService;

        public MenuController(IMenuAppService appService)
        {
            _appService = appService;
        }

        [HttpGet]
        public IEnumerable<Menu> Get()
        {
            return _appService.GetAll();
        }

        [HttpGet("{id}")]
        public List<Menu> Get(int id)
        {
            return _appService.GetMenuByRestaurant(id);
        }
    }
}