using Restaurants.Data.Factory;
using Restaurants.Domain;

namespace Restaurants.Data.Repositories
{
    public class PaymentOptionRepository : RepositoryBase<PaymentOption>, IPaymentOptionRepository
    {
        public PaymentOptionRepository(IContextFactory factory) : base(factory)
        {
        }
    }
}
