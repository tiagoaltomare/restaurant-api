using Dapper;
using Restaurants.Data.Factory;
using Restaurants.Domain;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

namespace Restaurants.Data.Repositories
{
    public class RestaurantRepository : RepositoryBase<Restaurant>, IRestaurantRepository
    {
        public RestaurantRepository(IContextFactory factory) : base(factory)
        {
        }

        public List<Restaurant> GetAllRestaurants()
        {
            using (var db = new SqlConnection(ConnectionString))
            {
                var restaurants = db.Query<Restaurant>("Proc_SelectAllRestaurant",
                commandType: System.Data.CommandType.StoredProcedure).ToList();
                
                foreach (var rest in restaurants)
                {
                    var parameters = new DynamicParameters();
                    parameters.Add("@ID_RESTAURANT", rest.Id);
                    rest.Produtos = db.Query<Menu>("Proc_SelectMenuByRestaurant",
                    param: parameters,
                    commandType: System.Data.CommandType.StoredProcedure).ToList();
                }

                return restaurants;
            }
        }

        public Restaurant GetRestaurantById(int id)
        {
            using (var db = new SqlConnection(ConnectionString))
            {
                var parameters = new DynamicParameters();
                parameters.Add("@ID", id);
                var restaurant = db.Query<Restaurant>("Proc_SelectRestaurantById",
                param: parameters,
                commandType: System.Data.CommandType.StoredProcedure).FirstOrDefault();

                var parametersProduto = new DynamicParameters();
                parametersProduto.Add("@ID_RESTAURANT", restaurant.Id);
                restaurant.Produtos = db.Query<Menu>("Proc_SelectMenuByRestaurant",
                param: parametersProduto,
                commandType: System.Data.CommandType.StoredProcedure).ToList();

                return restaurant;
            }
        }

        public List<Menu> GetMenuByRestaurant(int idRestaurant)
        {
            var parameters = new DynamicParameters();
            parameters.Add("@ID_RESTAURANT", idRestaurant);

            using (var db = new SqlConnection(ConnectionString))
            {
                var produtos = db.Query<Menu>("Proc_SelectMenuByRestaurant",
                param: parameters,
                commandType: System.Data.CommandType.StoredProcedure).ToList();

                return produtos;
            }
        }

        public List<Review> GetReviewByRestaurant(int idRestaurant)
        {
            var parameters = new DynamicParameters();
            parameters.Add("@ID_RESTAURANT", idRestaurant);

            using (var db = new SqlConnection(ConnectionString))
            {
                var reviews = db.Query<Review>("Proc_SelectReviewByRestaurant",
                param: parameters,
                commandType: System.Data.CommandType.StoredProcedure).ToList();

                return reviews;
            }
        }

    }
}
