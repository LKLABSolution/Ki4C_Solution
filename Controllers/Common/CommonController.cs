using Microsoft.AspNetCore.Mvc;

namespace Ki4C_Solution.Controllers.Common
{
    public class CommonController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

    }
}