using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
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
                var newUser = model.CreateNewUser();
                UserReopsitory.Register(newUser);
                FormsAuthentication.SetAuthCookie(model.Username, false);
                return Json(true);
            }
            catch (Exception e){
                return Json(e.InnerException.ToString());
            }
        }
    }
}