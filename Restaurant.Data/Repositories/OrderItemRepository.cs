using Restaurants.Data.Factory;
using Restaurants.Domain;

namespace Restaurants.Data.Repositories
{
    public class OrderItemRepository : RepositoryBase<OrderItem>, IOrderItemRepository
    {
        public OrderItemRepository(IContextFactory factory) : base(factory)
        {
        }
    }
}
