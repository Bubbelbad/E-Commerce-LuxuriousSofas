using ECommerce.Controllers;
using ECommerce.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ECommerce.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        public HttpRequestSender sender; 
        public List<Product> springCollection = new List<Product> { };

        public IndexModel(ILogger<IndexModel> logger, HttpRequestSender sender)
        {
            _logger = logger;
            this.sender = sender;
        }

        public void OnGet()
        {
            springCollection = sender.GetProductsByCategory("Armchair");
        }
    }
}
