using Restaurants.Domain;
using System;
using System.Collections.Generic;

namespace Restaurants.Application.Interface
{
    public class MenuAppService : AppServiceBase<Menu>, IMenuAppService
    {
        private readonly IMenuService _appService;

        public MenuAppService(IMenuService appService) : base(appService)
        {
            _appService = appService;
        }

        public List<Menu> GetMenuByRestaurant(int idRestaurant)
        {
            return _appService.GetMenuByRestaurant(idRestaurant);
        }
    }
}
