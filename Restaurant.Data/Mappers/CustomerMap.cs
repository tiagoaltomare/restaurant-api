using Dapper.FluentMap.Dommel.Mapping;
using Restaurants.Domain;

namespace Restaurants.Data.Mappers
{
    public class CustomerMap : DommelEntityMap<Customer>
    {
        public CustomerMap()
        {
            ToTable("CUSTOMER");
            Map(x => x.CustomerId).ToColumn("ID").IsKey();
            Map(x => x.Name).ToColumn("NAME");
            Map(x => x.Email).ToColumn("EMAIL");
            Map(x => x.Telephone).ToColumn("TELEPHONE");
            Map(x => x.Adress).ToColumn("ADRESS");
            Map(x => x.Number).ToColumn("NUMBER");
            Map(x => x.OptionalAdress).ToColumn("OPTIONAL_ADRESS");
            Map(x => x.AccessKey).ToColumn("ACCESS_KEY");
            Map(x => x.ImagePath).ToColumn("IMAGE_PATH");
            Map(x => x.IdPermission).ToColumn("ID_PERMISSION");
        }
    }
}
