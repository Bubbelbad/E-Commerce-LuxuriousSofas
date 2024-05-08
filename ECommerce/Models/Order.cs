namespace ECommerce.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public double TotalPrice { get; set; }
        public DateTime OrderDate { get; set; }
        public List<Product> Products { get; set; }
        public int UserId { get; set; }


        public  Order()
        {

        }


        public Order(int id, double totalPrice, DateTime date)
        {
            this.OrderId = id;
            this.TotalPrice = totalPrice;
            this.OrderDate = date;
        }
    }
}
