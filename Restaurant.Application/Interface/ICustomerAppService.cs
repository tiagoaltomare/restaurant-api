using Restaurants.Domain;

namespace Restaurants.Application
{
    public interface ICustomerAppService : IAppServiceBase<Customer>
    {
        Customer GetByEmail(string email);
    }
}
