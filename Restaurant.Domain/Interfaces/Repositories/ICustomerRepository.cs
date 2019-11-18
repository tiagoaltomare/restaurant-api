namespace Restaurants.Domain
{
    public interface ICustomerRepository : IRepositoryBase<Customer>
    {
        Customer GetByEmail(string email);
    }
}
