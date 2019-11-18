using System.Collections.Generic;

namespace Restaurants.Domain
{
    public class PaymentOption
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual List<Order> Orders { get; set; }
    }
}
