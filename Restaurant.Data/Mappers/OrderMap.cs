using Dapper.FluentMap.Dommel.Mapping;
using Restaurants.Domain;

namespace Restaurants.Data.Mappers
{
    public class OrderMap : DommelEntityMap<Order>
    {
        public OrderMap()
        {
            ToTable("ORDERS");
            Map(x => x.Id).ToColumn("ID").IsKey();
            Map(x => x.Email).ToColumn("EMAIL");
            Map(x => x.Telephone).ToColumn("TELEPHONE");
            Map(x => x.Address).ToColumn("ADRESS");
            Map(x => x.Number).ToColumn("NUMBER");
            Map(x => x.OptionalAddress).ToColumn("OPTIONAL_ADRESS");
            Map(x => x.PaymentOption).Ignore();
            Map(x => x.Items).Ignore();
        }
    }
}
