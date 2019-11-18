using Restaurants.Domain;
using System;
using System.Collections.Generic;

namespace Restaurants.Application
{
    public interface IMenuAppService : IAppServiceBase<Menu>
    {
        List<Menu> GetMenuByRestaurant(int idRestaurant);
    }
}
