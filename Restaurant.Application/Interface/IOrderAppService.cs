using Restaurants.Domain;

namespace Restaurants.Application
{
    public interface IOrderAppService: IAppServiceBase<Order>
    {
        int InsertOrder(Order order);
    }
}
