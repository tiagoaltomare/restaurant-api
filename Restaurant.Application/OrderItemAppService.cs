using Restaurants.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurants.Application
{
    public class OrderItemAppService : AppServiceBase<OrderItem>, IOrderItemAppService
    {
        private readonly IOrderItemService _appService;

        public OrderItemAppService(IOrderItemService appService) : base(appService)
        {
            _appService = appService;
        }
    }
}
