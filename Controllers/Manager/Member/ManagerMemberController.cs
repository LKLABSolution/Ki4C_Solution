using Microsoft.AspNetCore.Mvc;

namespace Ki4C_Solution.Controllers.Manager.Member
{
    public class ManagerMemberController : Controller
    {
        public IActionResult MemberList()
        {
            return View("../Manager/Member/MemberList");
        }
        public IActionResult MemberDetailView()
        {
            return View("../Manager/Member/MemberDetailView");
        }
    }
}
