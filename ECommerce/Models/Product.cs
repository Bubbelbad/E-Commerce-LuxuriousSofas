using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Xml.Linq;

namespace ECommerce.Models
{
    public class Product

        
        {
             public int Id { get; set; }
             public double Price { get; set; }
             public string Size { get; set; }
             public string Name { get; set; }
             public string Description { get; set; }
             public string Category { get; set; }

             public Product() { }

             public Product(int id, double price, string size, string name, string description, string category)
             {
                 this.Id = id;
                 this.Price = price;
                 this.Size = size;
                 this.Name = name;
                 this.Description = description;
                 this.Category = category;
             }
         }
    
}
