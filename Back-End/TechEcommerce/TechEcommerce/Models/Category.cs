namespace TechEcommerce.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; } 
        public ICollection<Subcategory> Subcategories { get; set; } = new List<Subcategory>();
        public ICollection<Product> Products { get; set;} = new List<Product>();
    }
}
