namespace Restaurants.Domain
{
    public interface ICustomerService : IServiceBase<Customer>
    {
        Customer GetByEmail(string email);
    }
}
