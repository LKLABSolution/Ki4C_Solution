using Microsoft.AspNetCore.Mvc;

namespace Ki4C_Solution.Controllers.Member.MyPage
{
    
    public class MemberMypageController : Controller
    {
        public IActionResult MyInfoRead()
        {
            return View("../Member/MyPage/MyInfoRead");
        }
        public IActionResult MyInfoUpdate()
        {
            return View("../Member/MyPage/MyInfoUpdate");
        }

        public IActionResult MyInfoDelete()
        {
            return View("../Member/MyPage/MyInfoDelete");
        }
        public IActionResult RegPostList()
        {
            return View("../Member/MyPage/RegPostList");
        }



        /// <summary>
        /// 추후 로직 추가시 활용
        /// </summary>
        public IActionResult RegPostRead()
        {
            return View("../Member/MyPage/RegPostRead");
        }
        public IActionResult MyInfoUpdateFinished()
        {
            return View("../Member/MyPage/MyInfoUpdateFinished");
        }
        public IActionResult MyInfoDeleteFinished()
        {
            return View("../Member/MyPage/MyInfoDeleteFinished");
        }
        public IActionResult MyInfoDeleteConfirm()
        {
            return View("../Member/MyPage/MyInfoDeleteConfirm");
        }
        public IActionResult MyInfoDeleteConfirmFinished()
        {
            return View("../Member/MyPage/MyInfoDeleteConfirmFinished");
        }
        public IActionResult MyInfoDeleteConfirmCancel()
        {
            return View("../Member/MyPage/MyInfoDeleteConfirmCancel");
        }
        public IActionResult MyInfoDeleteConfirmCancelFinished()
        {
            return View("../Member/MyPage/MyInfoDeleteConfirmCancelFinished");
        }
        




    }
}
