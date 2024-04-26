using ECommerce.Controllers;
using ECommerce.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ECommerce.Pages.ProductPage
{
    public class ProductModel : PageModel
    {
        HttpRequestSender httpRequestSender;
        public Product product { get; set; }

        public ProductModel(HttpRequestSender sender)
        {
            this.httpRequestSender = sender;
        }

        public void OnGet()
        {
            string id = Request.Query["id"]; //Gets the id from the asp-route-id attribute in the anchor tag
            product = httpRequestSender.GetProductById(id); //Gets the product by id
            
            string Description = product.Description;   
            string Name = product.Name; 
            string Category = product.Category;
            string Size = product.Size;
            double Price = product.Price;

        }
    }
}
