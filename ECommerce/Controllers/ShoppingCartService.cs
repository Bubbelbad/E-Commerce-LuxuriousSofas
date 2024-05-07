using ECommerce.Models;

namespace ECommerce.Services
{
    public class ShoppingCartService
    {
        List<CartItem> shoppingCart = new List<CartItem>();

        public ShoppingCartService()
        {
        }


        public List<CartItem> GetShoppingCartList()
        {
            return shoppingCart;
        }


        public void AddProduct(Product product, int quatity)
        {
            shoppingCart.Add(new CartItem(product.ProductId, product.Price, product.Size, product.Name, 
                                          product.Description, product.Category, quatity));
        }


        public void DeleteProduct(int idToDelete)
        {
            for (int i = 0; i < shoppingCart.Count; i++)
            {
                if (shoppingCart[i].Product.ProductId == idToDelete)
                {
                    shoppingCart.Remove(shoppingCart[i]);
                    break;
                }
            }
        }


        public double GetTotalPrice()
        {
            double totalPrice = 0;
            foreach (CartItem item in shoppingCart)
            {
                totalPrice += item.Product.Price;
            }
            return totalPrice;
        }
    }
}
