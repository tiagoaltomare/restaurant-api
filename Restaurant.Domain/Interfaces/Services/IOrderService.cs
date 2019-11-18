namespace Restaurants.Domain
{
    public interface IOrderService : IServiceBase<Order>
    {
        int InsertOrder(Order order);
    }
}
