using System.Collections.Generic;

namespace Restaurants.Domain
{
    public class Menu
    {
        public int Id { get; set; }
        public string ImagePath { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public virtual Restaurant Restaurant { get; set; }
        public virtual List<OrderItem> Items { get; set; }
    }
}
