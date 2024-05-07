using ECommerce.Models;

namespace ECommerce.Services
{
    public class ShoppingCartService
    {
        List<CartItem> shoppingCart = new List<CartItem>();

        public ShoppingCartService()
        {
            shoppingCart.Add(new CartItem(1, 199.50, "3", "Luxury Sofa", "Guld", "Sofa", 1));
            shoppingCart.Add(new CartItem(2, 299.50, "3", "Fat Sofa", "Silver", "Sofa", 2));
            shoppingCart.Add(new CartItem(3, 49.50, "4", "Potatoes Den", "Titan", "Sofa", 3));
            shoppingCart.Add(new CartItem(5, 49.50, "3", "Sitt-lyan", "Silver", "Sofa", 1));
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
