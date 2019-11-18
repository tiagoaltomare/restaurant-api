using Restaurants.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurants.Application
{
    public class OrderAppService : AppServiceBase<Order>, IOrderAppService
    {
        private readonly IOrderService _appService;

        public OrderAppService(IOrderService appService) : base(appService)
        {
            _appService = appService;
        }

        public int InsertOrder(Order order)
        {
            return _appService.InsertOrder(order);
        }
    }
}
