namespace ECommerce.Models
{
    public class Order
    {
        //public int OrderId { get; set; }
        public double TotalPrice { get; set; }
        public string OrderDate { get; set; }
        public List<Product> ProductList { get; set; }
        public int UserId { get; set; }


        public  Order()
        {
            ProductList = new List<Product>();
        }


        public Order(double totalPrice, string date, int userId, List<Product> products)
        {
            this.TotalPrice = totalPrice;
            this.OrderDate = date;
            this.UserId = userId;
            this.ProductList = products;
        }
    }
}
