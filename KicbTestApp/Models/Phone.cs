using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KicbTestApp.Models
{
    public class Phone
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Номер телефона обязателен")]
        [Phone]
        public string PhoneNumber { get; set; }

        public int UserId { get; set; }

        [ForeignKey("UserId")]
        public User User { get; set; } 
    }
}