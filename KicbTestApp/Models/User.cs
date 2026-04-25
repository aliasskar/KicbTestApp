using System.ComponentModel.DataAnnotations;
using System.Numerics;

namespace KicbTestApp.Models
{
    public class User
    {
        [Key] 
        public int Id { get; set; }

        [Required(ErrorMessage = "Имя обязательно")] 
        public string Name { get; set; }

        [Required]
        [EmailAddress(ErrorMessage = "Некорректный Email")]
        public string Email { get; set; }

        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }

        public List<Phone> Phones { get; set; } = new List<Phone>();
    }
}