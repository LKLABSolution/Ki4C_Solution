using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Ki4C_Solution.Models.Common.Auth
{
    public class CreateAccountModel
    {
        [Required(ErrorMessage = "아이디를 입력해주세요.")]
        [Display(Name = "아이디")]
        public string Username { get; set; }

        [Required(ErrorMessage = "비밀번호를 입력해주세요.")]
        [Display(Name = "비밀번호")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required(ErrorMessage = "비밀번호를 입력해주세요.")]
        [Display(Name = "비밀번호 확인")]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "비밀번호가 일치하지 않습니다.")]
        public string PasswordConfirm { get; set; }

        [Required(ErrorMessage = "이름을 입력해주세요.")]
        [Display(Name = "이름")]
        public string Name { get; set; }

        [Required(ErrorMessage = "이메일을 입력해주세요.")]
        [Display(Name = "이메일")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required(ErrorMessage = "전화번호를 입력해주세요.")]
        [Display(Name = "전화번호")]
        [DataType(DataType.PhoneNumber)]
        public string Phone { get; set; }

        [Required(ErrorMessage = "주소를 입력해주세요.")]
        [Display(Name = "주소")]
        public string Address { get; set; }

        [Required(ErrorMessage = "생년월일을 입력해주세요.")]
        [Display(Name = "생년월일")]
        [DataType(DataType.Date)]
        public DateTime Birth { get; set; }

        [Required(ErrorMessage = "성별을 선택해주세요.")]
        public string Gender { get; set; }

        [Required(ErrorMessage = "이용약관에 동의해주세요.")]
        public bool Agree { get; set; }

        public string AgreeText { get; set; }

        public CreateAccountModel()
        {
            //약관 텍스트
            this.AgreeText = XElement.Load("wwwroot\\xml\\AgreeText.xml").Value;
        }

        public CreateAccountModel(string agreeText)
        {
            this.AgreeText = agreeText;
        }
        

    }
}
