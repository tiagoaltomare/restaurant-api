using Dapper.FluentMap;
using Dapper.FluentMap.Dommel;

namespace Restaurants.Data.Mappers
{
    public static class RegisterMappings
    {
        public static void Register()
        {
            FluentMapper.Initialize(config =>
            {
                config.AddMap(new MenuMap());
                config.AddMap(new RestaurantMap());
                config.AddMap(new OrderMap());
                config.AddMap(new OrderItemMap());
                config.AddMap(new PaymentOptionMap());
                config.AddMap(new ReviewMap());
                config.AddMap(new CustomerMap());
                config.ForDommel();
            });
        }
    }
}
