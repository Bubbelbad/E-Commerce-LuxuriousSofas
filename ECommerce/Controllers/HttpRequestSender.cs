using ECommerce.Models;
using Newtonsoft.Json;

namespace ECommerce.Controllers
{
    public class HttpRequestSender
    {
        public HttpRequestSender() { }

        public List<Product> GetAllProducts()
        {
            HttpClient client = new HttpClient();
            HttpResponseMessage response = client.GetAsync("https://localhost:44300/api/products").Result;
            List<Product> products = new List<Product>();
            if (response.IsSuccessStatusCode)
            {
                string json = response.Content.ReadAsStringAsync().Result;
                products = JsonConvert.DeserializeObject<List<Product>>(json);
            }
            return products;
        }

        public Product GetProductById(string id)
        {
            HttpClient client = new HttpClient();
            HttpResponseMessage response = client.GetAsync("https://localhost:44300/api/products/" + id).Result;
            Product product = new Product();
            if (response.IsSuccessStatusCode)
            {
                string json = response.Content.ReadAsStringAsync().Result;
                product = JsonConvert.DeserializeObject<Product>(json);
                return product;
            }
            return product; 
        }

        public List<Order> GetOrderByUserId(string id)
        {
            HttpClient client = new HttpClient();
            HttpResponseMessage response = client.GetAsync("https://localhost:44300/api/products/" + id).Result;
            List<Order> orders = new List<Order>();
            if (response.IsSuccessStatusCode)
            {
                string json = response.Content.ReadAsStringAsync().Result; 
                orders = JsonConvert.DeserializeObject<List<Order>>(json);
                return orders; 
            }
            return orders; 
        }
    }
}
