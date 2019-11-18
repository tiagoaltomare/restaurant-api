using Dapper.FluentMap.Dommel.Mapping;
using Restaurants.Domain;

namespace Restaurants.Data.Mappers
{
    public class OrderItemMap : DommelEntityMap<OrderItem>
    {
        public OrderItemMap()
        {
            ToTable("ORDER_ITEM");
            Map(x => x.Id).ToColumn("Id").IsKey();
            Map(x => x.Quantity).ToColumn("ImagePath");
            Map(x => x.Price).ToColumn("PRICE");
            Map(x => x.Produto).Ignore();
            Map(x => x.Order).Ignore();
        }
    }
}
