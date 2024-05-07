namespace ECommerce.Models
{
    public class CartItem
    {
        public Product Product { get; set; }
        public int Quantity { get; set; }

        public CartItem(int id, double price, string size, string name, string description, string category, int quantity)
        {
            this.Product = new Product(id, price, size, name, description, category);
            this.Quantity = quantity;
        }
    }

}
