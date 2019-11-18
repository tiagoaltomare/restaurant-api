using Dapper.FluentMap.Dommel.Mapping;
using Restaurants.Domain;

namespace Restaurants.Data.Mappers
{
    public class PaymentOptionMap : DommelEntityMap<PaymentOption>
    {
        public PaymentOptionMap()
        {
            ToTable("PAYMENT_OPTION");
            Map(x => x.Id).ToColumn("ID").IsKey();
            Map(x => x.Name).ToColumn("NAME");
            Map(x => x.Orders).Ignore();
        }
    }
}
