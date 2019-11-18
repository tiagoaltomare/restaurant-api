using Restaurants.Domain;

namespace Restaurants.Data.Services
{
    public class OrderItemService : ServiceBase<OrderItem>, IOrderItemService
    {
        private readonly IOrderItemRepository _serviceRepository;

        public OrderItemService(IOrderItemRepository serviceRepository) : base(serviceRepository)
        {
            _serviceRepository = serviceRepository;
        }
    }
}
