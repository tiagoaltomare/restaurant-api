using Dapper;
using Restaurants.Data.Factory;
using Restaurants.Domain;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

namespace Restaurants.Data.Repositories
{
    public class OrderRepository : RepositoryBase<Order>, IOrderRepository
    {
        public OrderRepository(IContextFactory factory) : base(factory)
        {
        }

        public int InsertOrder(Order order)
        {
            var parameters = new DynamicParameters();
            parameters.Add("@EMAIL", order.Email);
            parameters.Add("@TELEPHONE", order.Telephone);
            parameters.Add("@ADRESS", order.Address);
            parameters.Add("@NUMBER", order.Number);
            parameters.Add("@OPTIONAL_ADRESS", order.OptionalAddress);
            parameters.Add("@PAYMENT_OPTION", order.PaymentOption.Name);

            using (var db = new SqlConnection(ConnectionString))
            {
                var idOrder = db.Query<int>("Proc_InsertOrder",
                param: parameters,
                commandType: System.Data.CommandType.StoredProcedure).FirstOrDefault();

                foreach (var item in order.Items)
                {
                    parameters = new DynamicParameters();
                    parameters.Add("@QUANTITY", item.Quantity);
                    parameters.Add("@PRICE", item.Price);
                    parameters.Add("@ID_PRODUTO", item.Produto.Id);
                    parameters.Add("@ID_ORDER", idOrder);

                    db.Query<int>("Proc_InsertOrderItem",
                    param: parameters,
                    commandType: System.Data.CommandType.StoredProcedure).FirstOrDefault();
                }

                return idOrder;
            }
        }
    }
}
