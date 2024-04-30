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
            HttpResponseMessage response = client.GetAsync("https://localhost:7208/api/Product/GetAllProducts").Result;
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
            HttpResponseMessage response = client.GetAsync("https://localhost:7208/api/Product/GetProductById?id=" + id).Result;
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
            HttpResponseMessage response = client.GetAsync("https://localhost:7208/api/User/GetUserById?id=" + id).Result;
            List<Order> orders = new List<Order>();
            if (response.IsSuccessStatusCode)
            {
                string json = response.Content.ReadAsStringAsync().Result; 
                orders = JsonConvert.DeserializeObject<List<Order>>(json);
                return orders; 
            }
            return orders; 
        }


        public bool UserLogin(string email, string password)
        {
         
            HttpClient client = new HttpClient();
            HttpResponseMessage response = client.GetAsync("https://localhost:7208/api/User/UserLogin?email=" + email + "&password=" + password).Result;
            if (response.IsSuccessStatusCode)
            {
                string json = response.Content.ReadAsStringAsync().Result;
                bool loginSuccessful = JsonConvert.DeserializeObject<bool>(json);
                return loginSuccessful;
            }
            return false; 
        }


       // Probably wont be needed, but lets save it in case: 
       
       // public List<User> GetAllUsers()
       // {
       //     HttpClient client = new HttpClient();
       //     HttpResponseMessage response = client.GetAsync("https://localhost:7208/api/User/GetAllUsers").Result;
       //     List<User> users = new List<User>();
       //     if (response.IsSuccessStatusCode)
       //     {
       //         string json = response.Content.ReadAsStringAsync().Result;
       //         users = JsonConvert.DeserializeObject<List<User>>(json);
       //     }
       //     return users;
       // }


    }
}
