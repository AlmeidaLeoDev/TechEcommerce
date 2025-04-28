namespace TechEcommerce.Models
{
    public class ShoppingCartItem
    {
        public int Id { get; set; }
        public int Amount { get; set; }
        public decimal UnitPrice { get; set; }
        public int ShoppingCartId { get; set; }
        public int Productid { get; set; } 
        public ShoppingCart ShoppingCart { get; set; }
        public Product Product { get; set; }
    }
}
