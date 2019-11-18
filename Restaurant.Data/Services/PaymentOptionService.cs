using Restaurants.Domain;

namespace Restaurants.Data.Services
{
    public class PaymentOptionService : ServiceBase<PaymentOption>, IPaymentOptionService
    {
        private readonly IPaymentOptionRepository _serviceRepository;

        public PaymentOptionService(IPaymentOptionRepository serviceRepository) : base(serviceRepository)
        {
            _serviceRepository = serviceRepository;
        }
    }
}
