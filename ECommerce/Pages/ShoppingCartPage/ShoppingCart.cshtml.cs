using ECommerce.Controllers;
using ECommerce.Models;
using ECommerce.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ECommerce.Pages.ShoppingCartPage
{
    public class ShoppingCartPageModel : PageModel
    {
        public HttpRequestSender httpRequestSender;
        public ShoppingCartService shoppingCartService;
        public List<Product> shoppingCart = new List<Product>();

        public ShoppingCartPageModel(HttpRequestSender httpRequestSender, ShoppingCartService shoppingCartService)
        {
            this.httpRequestSender = httpRequestSender;
            this.shoppingCartService = shoppingCartService;
        }


        public void OnGet()
        {
        }
    }
}
