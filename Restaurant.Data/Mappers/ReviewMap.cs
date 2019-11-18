using Dapper.FluentMap.Dommel.Mapping;
using Restaurants.Domain;

namespace Restaurants.Data.Mappers
{
    public class ReviewMap : DommelEntityMap<Review>
    {
        public ReviewMap()
        {
            ToTable("REVIEW");
            Map(x => x.Id).ToColumn("ID").IsKey();
            Map(x => x.Name).ToColumn("USER_NAME");
            Map(x => x.Date).ToColumn("DATE_REVIEW");
            Map(x => x.Rating).ToColumn("RATING");
            Map(x => x.Comments).ToColumn("COMMENTS");
            Map(x => x.Restaurant).Ignore();
        }
    }
}
