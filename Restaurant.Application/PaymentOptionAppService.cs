using Restaurants.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurants.Application
{
    public class PaymentOptionAppService : AppServiceBase<PaymentOption>, IPaymentOptionAppService
    {
        private readonly IPaymentOptionService _appService;

        public PaymentOptionAppService(IPaymentOptionService appService) : base(appService)
        {
            _appService = appService;
        }
    }
}
