namespace ECommerce.Models
{
    public class Product
    {
        public int Id { get; set; }
        public double Price { get; set; }
        public string Size { get; set; }
        public string Brand { get; set; }
        public string Color { get; set; }
        public string Category { get; set; }

        public Product()
        {

        }

        public Product(int id, double price, string size, string brand, string color, string category)
        {
            this.Id = id;
            this.Price = price;
            this.Size = size;
            this.Brand = brand;
            this.Color = color;
            this.Category = category;
        }
    }
}
