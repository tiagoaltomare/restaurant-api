using System.Data.SqlClient;
using System.Linq;
using Dapper;
using Restaurants.Data.Factory;
using Restaurants.Domain;


namespace Restaurants.Data.Repositories
{
    public class CustomerRepository : RepositoryBase<Customer>, ICustomerRepository
    {
        public CustomerRepository(IContextFactory factory) : base(factory)
        {
        }

        public Customer GetByEmail(string email)
        {
            var parameters = new DynamicParameters();
            parameters.Add("@EMAIL", email);

            using (var db = new SqlConnection(ConnectionString))
            {
                var user = db.Query<Customer>("Proc_SelectCustomerByEmail",
                param: parameters,
                commandType: System.Data.CommandType.StoredProcedure).FirstOrDefault();

                return user;
            }
        }
    }
}