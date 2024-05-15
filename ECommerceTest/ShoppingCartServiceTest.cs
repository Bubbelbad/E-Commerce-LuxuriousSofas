using ECommerce.Models;
using ECommerce.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceTest
{
    public class ShoppingCartServiceTest
    {
        [Fact]
        public void GetShoppingCartList_TestNotNull()
        {
            //Arrange
            ShoppingCartService service = new ShoppingCartService();

            //Act
            List<CartItem> cartItems = service.GetShoppingCartList();

            //Assert
            Assert.NotNull(cartItems); 
        }
    }
}
