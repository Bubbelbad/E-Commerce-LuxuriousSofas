namespace ECommerce.Models
{
    public class Product
    {
        public int Id { get; set; }
        public double Price { get; set; }
        public int Size { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public string Category { get; set; }

        public Product()
        {

        }

        public Product(int id, double price, int size, string brand, string model, string color, string category)
        {
            this.Id = id;
            this.Price = price;
            this.Size = size;
            this.Brand = brand;
            this.Model = model;
            this.Color = color;
            this.Category = category;
        }
    }
}
