using System.ComponentModel.DataAnnotations;

namespace gas_station
{
    public class Login
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Email is required!")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Password is required!")]
        public string PasswordHash { get; set; }
    }
}
