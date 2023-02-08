using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Ki4C_Solution.Models.Common.Auth
{
    public class LoginModel
    {
        [Required]
        [EmailAddress]
        [Display(Name = "Email Address")]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
