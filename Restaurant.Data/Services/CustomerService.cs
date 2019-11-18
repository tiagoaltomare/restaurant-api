using Restaurants.Domain;

namespace Restaurants.Data.Services
{
    public class CustomerService : ServiceBase<Customer>, ICustomerService
    {
        private readonly ICustomerRepository _serviceRepository;

        public CustomerService(ICustomerRepository serviceRepository) : base(serviceRepository)
        {
            _serviceRepository = serviceRepository;
        }

        public Customer GetByEmail(string email)
        {
            return _serviceRepository.GetByEmail(email);
        }
    }
}
