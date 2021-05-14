
using Shop_Thoi_Trang;
using Shop_Thoi_Trang2.Areas.Admin.code;
using Shop_Thoi_Trang2.Areas.Admin.Models;
using System.Web.Mvc;

namespace Shop_Thoi_Trang2.Areas.Admin.Controllers
{
    public class LoginController : Controller
    {
        // GET: Admin/Login

        [HttpGet]

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index(LoginModels model)
        {
            var result = new AccountModel().Login(model.UserName, model.PassWord);
            if ((bool)result && ModelState.IsValid)
            {
                ModelState.AddModelError("", "Ten Dang Nhap Hoac Mat Khau Khong Dung");
            }
            else
            {
                SessionHelper.SetSession(session: new UserSession() { UserName = model.UserName });
                return RedirectToAction("Index", "Home");
            }
            return View(model);
        }
    }
}