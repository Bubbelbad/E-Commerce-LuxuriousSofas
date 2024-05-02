using ECommerce.Models;

namespace ECommerce.Services
{
    public class ShoppingCartService
    {
        List<Product> shoppingCart = new List<Product>();

        public ShoppingCartService()
        {
            
        }


        public List<Product> GetShoppingCartList()
        {
            throw new NotImplementedException();
        }

        public int GetTotalPrice()
        {
            return 10; 
        }
    }
}
