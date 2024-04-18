namespace ECommerce.Models
{
    public class ShoppingCart
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public double TotalPrice { get; set; }
        public List<Product> Products { get; set; }

        public ShoppingCart()
        {

        }   

        public ShoppingCart(int id, int productId, int quantity, double totalPrice)
        {
            this.Id = id;
            this.ProductId = productId;
            this.Quantity = quantity;
            this.TotalPrice = totalPrice;
        }
    }
}
