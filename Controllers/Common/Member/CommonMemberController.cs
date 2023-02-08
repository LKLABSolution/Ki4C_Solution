using Microsoft.AspNetCore.Mvc;

namespace Ki4C_Solution.Controllers.Common.Member
{
    public class CommonMemberController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult MemberRegSubscription()
        {
            return View("../Common/Member/MemberRegSubscription");
        }
        public IActionResult MemberRegFinished()
        {
            return View("../Common/Member/MemberRegFinished");
        }
        public IActionResult MemberReg()
        {
            return View("../Common/Member/MemberReg");
        }
    }
}
