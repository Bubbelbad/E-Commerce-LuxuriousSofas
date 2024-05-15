using ECommerce.Controllers;
using ECommerce.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ECommerceTest
{
    public class HttpRequestSenderTest
    {
        [Fact]
        public void GetAllProducts_TestNotNull()
        {
            //Arrange
            HttpRequestSender httpRequestSender = new HttpRequestSender();
            httpRequestSender.GetAllProducts();

            //Act
            List<Product> products = httpRequestSender.GetAllProducts();

            //Assert
            Assert.NotNull(products);
        }

        [Fact]
        public void GetProductsByCategory_Armchairs()
        {
            //Arrange
            HttpRequestSender sender = new HttpRequestSender();
            string category = "Armchairs";

            //Act
            List<Product> products = sender.GetProductsByCategory(category); 

            //Assert
            Assert.NotNull(products);
        }

        [Fact]
        public void GetProductsByCategory_Sofas()
        {
            //Arrange
            HttpRequestSender sender = new HttpRequestSender();
            string category = "Sofas";

            //Act
            List<Product> products = sender.GetProductsByCategory(category);

            //Assert
            Assert.NotNull(products);
        }

        [Fact]
        public void TestGetProductsByCategory_FakeCategory()
        {
            //Arrange
            HttpRequestSender sender = new HttpRequestSender();
            string category = "milk";

            //Act
            List<Product> products = sender.GetProductsByCategory("NotExistingCategory");

            //Assert
            Assert.Empty(products);
        }

        [Fact]
        public void GetProductById_TestNotNull()
        {
            //Arrange
            HttpRequestSender sender = new HttpRequestSender();
            string id = "1";

            //Act
            Product product = sender.GetProductById(id);

            //Assert
            Assert.NotNull(product);
        }


        //This method is note yet in use.

      //  [Fact]
      //  public void GetOrderByUserId_TestNotNull()
      //  {
      //      //Arrange
      //      HttpRequestSender sender = new HttpRequestSender();
      //      string id = "1";
      //
      //      //Act
      //      List<Order> orders = sender.GetOrderByUserId(id);
      //
      //      //Assert
      //      Assert.NotNull(orders);
      //  }
    }
}
