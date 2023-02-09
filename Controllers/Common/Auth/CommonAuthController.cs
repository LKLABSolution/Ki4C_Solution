using Microsoft.AspNetCore.Mvc;
using Ki4C_Solution.Models.Common.Auth;

namespace Ki4C_Solution.Controllers.Common.Auth
{
    public class CommonAuthController : Controller
    {
        public IActionResult Login()
        {
            //html doc path : Views/Common/Auth/Login.cshtml
            return View("../Common/Auth/Login");
            //return View();
        }

        //method=post login email, password
        [HttpPost]
        public IActionResult Login(LoginModel model)
        {
            if (ModelState.IsValid)
            {
                //TODO : login logic
                return RedirectToAction("Index", "Home");
            }
            ViewData["ResultText"] = "LoginFail";
            return View("../Common/Auth/Login");
        }
        public IActionResult LogoutPage()
        {
            return View("../Common/Auth/Logout");
        }
        public IActionResult Logout()
        {
            return RedirectToAction("Login", "CommonAuth");
        }


        // Views/Common/Auth/FindIdInput
        public IActionResult FindIdInput()
        {
            return View("../Common/Auth/FindIdInput");
        }

        // Views/Common/Auth/FindIdResultView
        public IActionResult FindIdResultView()
        {
            return View("../Common/Auth/FindIdResultView");
        }

        // Views/Common/Auth/FindPassInput
        public IActionResult FindPassInput()
        {
            return View("../Common/Auth/FindPassInput");
        }

        // Views/Common/Auth/FindPassResultView
        public IActionResult FindPassResultView()
        {
            return View("../Common/Auth/FindPassResultView");
        }

        //Account create page
        public IActionResult CreateAccount()
        {
            return View("../Common/Auth/CreateAccount");
        }

    }
}
