using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Ki4C_Solution.Models.Common.Auth
{
    public class LoginModel
    {
        [Required]
        [StringLength(20, MinimumLength = 4, ErrorMessage = "아이디는 4자 이상 20자 이하로 입력해주세요.")]
        [Display(Name = "아이디")]
        public string Id { get; set; }
        [Required]
        [EmailAddress]
        [Display(Name = "Email Address")]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
