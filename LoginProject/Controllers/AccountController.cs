using LoginProject.Models;
using Microsoft.AspNetCore.Mvc;

namespace LoginProject.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(Users model)
        {
            {
                var user = Data.Users.Where(i => i.Username == model.Username).FirstOrDefault();
                if (user != null)
                    if (user.Password == model.Password)
                {
                    SessionHelper.SetObjectAsJson(HttpContext.Session, "user", user);
                   
                    Data.LoginUser = SessionHelper.GetObjectFromJson<Users>(HttpContext.Session, "user");
                    return RedirectToAction("Index", "Home");
                }

            }
            return View(model);
        }
    }
}
