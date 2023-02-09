using System.ComponentModel.DataAnnotations;

namespace Ki4C_Solution.Models.Common.Member
{
    public class MemberRegModel
    {
        //this model is used for MemberReg.cshtml input tag name

        [Required] public string ID { get; set; } = string.Empty;

        [Required] public string Password { get; set; } = string.Empty;
        [Required] public string PasswordConfirm { get; set; } = string.Empty;
        [Required] public string Name { get; set; } = string.Empty;
        [Required] public string Email { get; set; } = string.Empty;
        [Required] public string Phone { get; set; } = string.Empty;
        [Required] public string Address { get; set; } = string.Empty;
        [Required] public string AddressDetail { get; set; } = string.Empty;

        public string Birth { get; set; } = string.Empty;
        [Required] public string Company { get; set; } = string.Empty;
        public string Department { get; set; } =  string.Empty;
        public string Position { get; set; } =  string.Empty;
        public bool Check1 { get; set; } = false;
        [Required] public bool Check2 { get; set; }
        [Required] public bool Check3 { get; set; }
        [Required] public bool Check4 { get; set; }
        [Required] public bool Check5 { get; set; }
        [Required] public bool Check6 { get; set; }
        [Required] public bool Check7 { get; set; }
        public bool Check8 { get; set; }
        



    }
}
