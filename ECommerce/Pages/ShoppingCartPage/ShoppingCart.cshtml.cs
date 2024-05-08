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
        public LoginService loginService;
        public List<CartItem> shoppingCart;


        public ShoppingCartPageModel(HttpRequestSender httpRequestSender, ShoppingCartService shoppingCartService, LoginService loginService)
        {
            this.httpRequestSender = httpRequestSender;
            this.shoppingCartService = shoppingCartService;
            this.loginService = loginService;
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


        public IActionResult OnPostCreateOrder(List<CartItem> items, double totalPrice)
        {
            Order order = shoppingCartService.CreateProductList(items);
            order.TotalPrice = totalPrice;
            order.UserId = loginService.GetCurrentUserId();
            order.OrderDate = DateTime.Now;

            httpRequestSender.CreateOrder(order);
            return RedirectToPage();
        }
    }
}
