namespace TechEcommerce.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; } 
        public string Email { get; set; }  
        public string HashPassword { get; set; }
        public DateTime CreatedAt { get; set; } 
        public ICollection<Order> Orders { get; set; } = new List<Order>();
        public ICollection<ShoppingCart> ShoppingCarts { get; set; } = new List<ShoppingCart>();
    }
}
