using ECommerce.Models;

namespace ECommerce.Controllers
{
    public class LoginService
    {
        HttpRequestSender sender; 
        public LoginService(HttpRequestSender sender) 
        { 
            this.sender = sender;
        }

        public int GetCurrentUserId()
        {
            throw new NotImplementedException();
        }
    }
}
