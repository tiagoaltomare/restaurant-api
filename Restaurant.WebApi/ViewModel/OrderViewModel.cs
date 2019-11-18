using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurants.WebApi.ViewModel
{
    public class OrderViewModel
    {
        public string Address { get; set; }
        public string Number { get; set; }
        public string OptionalAddress { get; set; }
        public string Telephone { get; set; }
        public string Email { get; set; }
        public string PaymentOption { get; set; }
        public int? Id { get; set; }
        public List<OrderItemViewModel> OrderItem { get; set; }
    }
}
