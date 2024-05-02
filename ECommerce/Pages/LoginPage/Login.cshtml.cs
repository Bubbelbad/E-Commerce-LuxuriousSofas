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

        public IActionResult OnPost()
        {
            bool result = sender.UserLogin(Request.Form["logIn-email"], Request.Form["logIn-password"]);
            if (result == true)
            {
                LoginSuccessful = true;
                return Page();
            }
            else
            {
                LoginSuccessful = false;
                return Page();
            }   
        }
    }
}
