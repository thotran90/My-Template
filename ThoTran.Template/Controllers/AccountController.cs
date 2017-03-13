using System.Web.Mvc;

namespace ThoTran.Template.Controllers
{
    public class AccountController : BaseController
    {
        #region Anonymous Action
        [AllowAnonymous]
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        [AllowAnonymous]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult DoLogin()
        {
            return RedirectToAction("Index", "Home");
        }

        [AllowAnonymous]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult ForgetPassword()
        {
            return RedirectToAction("Login");
        }
        #endregion

    }
}