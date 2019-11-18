using System.Collections.Generic;

namespace Restaurants.Domain
{
    public class Order
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Telephone { get; set; }
        public string Address { get; set; }
        public string Number { get; set; }
        public string OptionalAddress { get; set; }
        public virtual PaymentOption PaymentOption { get; set; }
        public virtual List<OrderItem> Items { get; set; }
    }
}
