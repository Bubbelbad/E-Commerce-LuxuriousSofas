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
            return shoppingCart;
        }


        public void AddProduct(Product product)
        {
            shoppingCart.Add(product);
        }


        public void DeleteProduct(int idToDelete)
        {
            for (int i = 0; i < shoppingCart.Count; i++)
            {
                if (shoppingCart[i].ProductId == idToDelete)
                {
                    Product product = shoppingCart[i];
                    shoppingCart.Remove(product);
                    break;
                }
            }
        }


        public double GetTotalPrice()
        {
            double totalPrice = 0;
            foreach (Product product in shoppingCart)
            {
                totalPrice += product.Price;
            }
            return totalPrice;
        }
    }
}
