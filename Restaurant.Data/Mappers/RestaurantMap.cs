using Dapper.FluentMap.Dommel.Mapping;
using Restaurants.Domain;

namespace Restaurants.Data.Mappers
{
    public class RestaurantMap : DommelEntityMap<Restaurant>
    {
        public RestaurantMap()
        {
            ToTable("RESTAURANT");
            Map(x => x.Id).ToColumn("ID").IsKey();
            Map(x => x.SocialName).ToColumn("SOCIAL_NAME");
            Map(x => x.FantasyName).ToColumn("FANTASY_NAME");
            Map(x => x.Category).ToColumn("CATEGORY");
            Map(x => x.DeliveryEstimate).ToColumn("DELIVERY_ESTIMATE");
            Map(x => x.Rating).ToColumn("RATING");
            Map(x => x.ImagePath).ToColumn("IMAGE_PATH");
            Map(x => x.About).ToColumn("ABOUT");
            Map(x => x.Hours).ToColumn("FUNCTIONAL_HOURS");
            Map(x => x.Produtos).Ignore();
            Map(x => x.Reviews).Ignore();
        }
    }
}
