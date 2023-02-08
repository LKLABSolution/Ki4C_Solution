using Ki4C_Solution.Models.Common.Member;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

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
        [HttpGet]
        public IActionResult MemberReg()
        {
            return View("../Common/Member/MemberReg");
        }
        [HttpPost]
        public IActionResult MemberReg(MemberRegModel memberRegModel)
        {
            foreach (var modelState in ModelState.Values)
            {
                foreach (var error in modelState.Errors)
                {
                    Debug.WriteLine(error.ErrorMessage);
                }
            }
            if (ModelState.IsValid)
            {
                //TODO : login logic
                return RedirectToAction("Index", "Home");
            }
            return View("../Common/Member/MemberReg");
        }
    }
}
