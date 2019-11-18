using System.Collections.Generic;

namespace Restaurants.Domain
{
    public class Restaurant
    {
        public int Id { get; set; }
        public string SocialName { get; set; } //antigo id no json-server
        public string FantasyName { get; set; }
        public string Category { get; set; }
        public int DeliveryEstimate { get; set; }
        public float Rating { get; set; }
        public string ImagePath { get; set; }
        public string About { get; set; }
        public string Hours { get; set; }
        public virtual ICollection<Menu> Produtos { get; set; }
        public virtual ICollection<Review> Reviews { get; set; }
    }
}
