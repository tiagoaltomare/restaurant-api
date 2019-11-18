using System;

namespace Restaurants.Domain
{
    public class Review
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public float Rating { get; set; }
        public string Comments { get; set; }
        public virtual Restaurant Restaurant { get; set; }
    }
}
