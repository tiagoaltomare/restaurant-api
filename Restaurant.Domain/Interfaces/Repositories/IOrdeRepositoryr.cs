namespace Restaurants.Domain
{
    public interface IOrderRepository : IRepositoryBase<Order>
    {
        int InsertOrder(Order order);
    }
}
