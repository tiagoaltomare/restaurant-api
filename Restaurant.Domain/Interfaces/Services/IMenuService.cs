using System.Collections.Generic;

namespace Restaurants.Domain
{
    public interface IMenuService : IServiceBase<Menu>
    {
        List<Menu> GetMenuByRestaurant(int idRestaurant);
    }
}
