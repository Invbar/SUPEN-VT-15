using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using System.Web.UI.WebControls;
using DAL.Repositorys;
using Supen.Models;
using BCrypt;

namespace Supen.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public JsonResult CreateUser(RegistrationModel model){
            if (!ModelState.IsValid)
                return Json("Fill in values in every textfield");

            try{
                var salt = BCrypt.Net.BCrypt.GenerateSalt(8);
                model.Password = BCrypt.Net.BCrypt.HashPassword(model.Password, salt);
                var newUser = model.CreateNewUser(salt);
                UserReopsitory.Register(newUser);
                FormsAuthentication.SetAuthCookie(model.Username, false);
                return Json(true);
            }
            catch (Exception e){
                return Json(e.InnerException.ToString());
            }
        }

        [HttpPost]
        public JsonResult Login(LoginModel login){

            if (!ModelState.IsValid)
                return Json(false);

            var password = UserReopsitory.GetHashedPassword(login.Username);
            var compare = BCrypt.Net.BCrypt.Verify(login.Password, password);
            var user1 = UserReopsitory.Login(login.Username, login.Password);

            if (user1 != null){
                if (compare){
                    FormsAuthentication.SetAuthCookie(user1.Username, false);
                    return Json(true);
                }
            }
            return Json(false);
        }

    }
}