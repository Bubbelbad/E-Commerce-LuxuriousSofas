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


        public void AddProduct(Product product, int quantity)
        {
            foreach (CartItem item in shoppingCart)
            {
                if (item.Product.ProductId == product.ProductId)
                {
                    item.Quantity += quantity;
                    return;
                }
            }
            shoppingCart.Add(new CartItem(product.ProductId, product.Price, product.Size, product.Name, 
                                          product.Description, product.Category, quantity));
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

        public List<Product> CreateProductList(List<CartItem> items)
        {
            List<Product> products = new List<Product>();
            foreach (CartItem item in items)
            {
                for (int i = 0; i < item.Quantity; i++)
                {
                    products.Add(item.Product);
                }
            }
            return products; 
        }
    }
}
