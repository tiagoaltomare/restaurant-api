using Restaurants.Data.Factory;
using Restaurants.Domain;

namespace Restaurants.Data.Repositories
{
    public class ReviewRepository : RepositoryBase<Review>, IReviewRepository
    {
        public ReviewRepository(IContextFactory factory) : base(factory)
        {
        }
    }
}
