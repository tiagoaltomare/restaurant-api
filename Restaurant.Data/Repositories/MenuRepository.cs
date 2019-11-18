using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using Dapper;
using Restaurants.Data.Factory;
using Restaurants.Domain;

namespace Restaurants.Data.Repositories
{
    public class MenuRepository : RepositoryBase<Menu>, IMenuRepository
    {
        public MenuRepository(IContextFactory factory) : base(factory)
        {
        }
        
        public List<Menu> GetMenuByRestaurant(int idRestaurant)
        {
            var parameters = new DynamicParameters();
            parameters.Add("@ID_RESTAURANT", idRestaurant);

            using (var db = new SqlConnection(ConnectionString))
            {
                var produtos =  db.Query<Menu>("Proc_SelectMenuByRestaurant",
                param: parameters,
                commandType: System.Data.CommandType.StoredProcedure).ToList();

                return produtos;
            }
        }
    }
}
