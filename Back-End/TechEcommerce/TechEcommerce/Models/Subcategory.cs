namespace TechEcommerce.Models
{
    public class Subcategory
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; } 
        public ICollection<Product> Products { get; set; } = new List<Product>();
    }
}
