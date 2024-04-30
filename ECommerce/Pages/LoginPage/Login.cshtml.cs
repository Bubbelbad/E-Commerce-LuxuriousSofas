using ECommerce.Controllers;
using ECommerce.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ECommerce.Pages.LoginPage
{
    public class LoginModel : PageModel
    {
        HttpRequestSender sender; 
        public bool LoginSuccessful { get; set;} 

        public LoginModel(HttpRequestSender sender)
        {
            this.sender = sender; 
        }

        public void OnGet()
        {
        }

        public void OnPost()
        {
            LoginSuccessful = sender.UserLogin(Request.Form["logIn-email"], Request.Form["logIn-password"]);
        }
    }
}
