using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurants.WebApi.ViewModel
{
    public class OrderItemViewModel
    {
        public int Quantity { get; set; }
        public int MenuId { get; set; }
        public double Price { get; set; }
    }
}
