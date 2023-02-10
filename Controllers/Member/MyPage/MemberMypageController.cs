using Ki4C_Solution.Models.Common.Member;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Ki4C_Solution.Controllers.Member.MyPage
{
    
    public class MemberMypageController : Controller
    {
        public IActionResult MyInfo()
        {
            return View("../Member/MyPage/MyInfo");
        }
        
        public IActionResult MyInfoRead()
        {
            ViewData["Message"] = "MyInfoRead";
            // 임시 추가
            MemberRegModel memberRegModel = new MemberRegModel();
            memberRegModel.ID = "test";
            memberRegModel.Password = "test";
            memberRegModel.PasswordConfirm = "test";
            memberRegModel.Name = "test";
            memberRegModel.Email = "test";
            memberRegModel.Phone = "test";
            memberRegModel.Address = "test";
            memberRegModel.AddressDetail = "test";
            memberRegModel.Birth = "test";
            memberRegModel.Company = "test";
            memberRegModel.Department = "test";
            memberRegModel.Position = "test";
            memberRegModel.Check1 = true;
            memberRegModel.Check2 = true;
            memberRegModel.Check3 = true;
            memberRegModel.Check4 = true;
            memberRegModel.Check5 = true;
            memberRegModel.Check6 = true;
            memberRegModel.Check7 = true;
            memberRegModel.Check8 = true;
            return View("../Member/MyPage/MyInfoRead", memberRegModel);
        }

        [HttpPost]
        public IActionResult MyInfoUpdate()
        {
            ViewData["Message"] = "MyInfoUpdate";
            // 임시 추가
            MemberRegModel memberRegModel = new MemberRegModel();
            memberRegModel.ID = "test";
            memberRegModel.Password = "test";
            memberRegModel.PasswordConfirm = "test";
            memberRegModel.Name = "test";
            memberRegModel.Email = "test";
            memberRegModel.Phone = "test";
            memberRegModel.Address = "test";
            memberRegModel.AddressDetail = "test";
            memberRegModel.Birth = "test";
            memberRegModel.Company = "test";
            memberRegModel.Department = "test";
            memberRegModel.Position = "test";
            memberRegModel.Check1 = true;
            memberRegModel.Check2 = true;
            memberRegModel.Check3 = true;
            memberRegModel.Check4 = true;
            memberRegModel.Check5 = true;
            memberRegModel.Check6 = true;
            memberRegModel.Check7 = true;
            memberRegModel.Check8 = true;
            return View("../Member/MyPage/MyInfoUpdate", memberRegModel);
        }

        public IActionResult MyInfoUpdateConfirm(MemberRegModel memberRegModel)
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
                return RedirectToAction("MyInfoUpdateFinished", "MemberMypage");
            }
            return View("../Member/MyPage/MyInfoUpdateConfirm");
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
