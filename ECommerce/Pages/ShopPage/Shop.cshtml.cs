using ECommerce.Controllers;
using ECommerce.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ECommerce.Pages.ShopPage
{
    public class ShopPageModel : PageModel
    {
        HttpRequestSender httpRequestSender;
        public List<Product> products = new List<Product> { };

        public ShopPageModel (HttpRequestSender sender)
        {
            this.httpRequestSender = sender;
        }
        public void OnGet()
        {
            products = httpRequestSender.GetAllProducts();
        }
    }
}
