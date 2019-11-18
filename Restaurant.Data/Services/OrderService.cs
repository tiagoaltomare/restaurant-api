using Restaurants.Domain;

namespace Restaurants.Data.Services
{
    public class OrderService : ServiceBase<Order>, IOrderService
    {
        private readonly IOrderRepository _serviceRepository;

        public OrderService(IOrderRepository serviceRepository): base(serviceRepository)
        {
            _serviceRepository = serviceRepository;
        }

        public int InsertOrder(Order order)
        {
            return _serviceRepository.InsertOrder(order);
        }
    }
}
