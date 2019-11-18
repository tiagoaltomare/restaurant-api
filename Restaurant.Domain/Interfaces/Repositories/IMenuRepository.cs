using System;
using System.Collections.Generic;

namespace Restaurants.Domain
{
    public interface IMenuRepository : IRepositoryBase<Menu>
    {
        List<Menu> GetMenuByRestaurant(int idRestaurant);
    }
}
