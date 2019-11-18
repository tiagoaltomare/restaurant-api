using Dapper.FluentMap.Dommel.Mapping;
using Restaurants.Domain;

namespace Restaurants.Data.Mappers
{
    public class MenuMap : DommelEntityMap<Menu>
    {
        public MenuMap()
        {
            ToTable("MENU");
            Map(x => x.Id).ToColumn("ID").IsKey();
            Map(x => x.ImagePath).ToColumn("IMAGE_PATH");
            Map(x => x.Name).ToColumn("PRODUCT_NAME");
            Map(x => x.Description).ToColumn("DECRIPTION");
            Map(x => x.Price).ToColumn("PRICE");
            Map(x => x.Restaurant).Ignore();
            Map(x => x.Items).Ignore();
        }
    }
}
