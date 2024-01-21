namespace OgainShop.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int CategoryId { get; set; }

        // Navigation property
        public Category Category { get; set; }
        public ICollection<OrderProduct> OrderProducts { get; set; }
    }
}
