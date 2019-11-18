namespace Restaurants.Domain
{
    public class OrderItem
    {
        public int Id { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }
        public virtual Menu Produto { get; set; }
        public virtual Order Order { get; set; }
    }
}
