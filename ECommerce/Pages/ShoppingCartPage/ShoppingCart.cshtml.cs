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
        public List<CartItem> shoppingCart;

        public ShoppingCartPageModel(HttpRequestSender httpRequestSender, ShoppingCartService shoppingCartService)
        {
            this.httpRequestSender = httpRequestSender;
            this.shoppingCartService = shoppingCartService;
        }


        public void OnGet()
        {
            shoppingCart = shoppingCartService.GetShoppingCartList();
        }

        public IActionResult OnPostRemoveItem(int idToDelete)
        {
            shoppingCartService.DeleteProduct(idToDelete);
            return RedirectToPage();
        }
    }
}
