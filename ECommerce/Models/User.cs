using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ECommerce.Models
{
    public class User
    {
        public int UserId { get; set; }
        [Required]
        [MaxLength(50)]
        public string Username { get; set; }
        [Required]
        [MaxLength(50)]
        public string Password { get; set; }
        [Required]
        [MaxLength(100)]
        public string Email { get; set; }
        public List<Order> Orders { get; set; }

        public User() { }

        public User(int userId, string username, string password, string email)
        {
            this.UserId = userId;
            this.Username = username;
            this.Password = password;
            this.Email = email;
        }
    }
}
