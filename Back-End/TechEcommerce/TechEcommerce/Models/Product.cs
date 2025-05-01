namespace TechEcommerce.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; } 
        public string ImageUrl { get; set; }
        public int CategoryId { get; set; }
        public int SubcategoryId { get; set; } 
        public Category Category { get; set; }
        public Subcategory Subcategory { get; set; }
        public ICollection<OrderItem> OrderItems { get; set; } = new List<OrderItem>();
        public ICollection<ShoppingCartItem> ShoppingCartItems { get; set; } = new List<ShoppingCartItem>();
    }
}
