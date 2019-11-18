using Restaurants.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurants.Application
{
    public class CustomerAppService : AppServiceBase<Customer>, ICustomerAppService
    {
        private readonly ICustomerService _appService;

        public CustomerAppService(ICustomerService appService) : base(appService)
        {
            _appService = appService;
        }

        public Customer GetByEmail(string email)
        {
            return _appService.GetByEmail(email);
        }
    }
}
