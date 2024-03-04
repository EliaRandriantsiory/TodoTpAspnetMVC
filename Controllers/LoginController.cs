using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Todo.Models;

namespace Todo.Controllers
{
    public class LoginController : Controller
    {
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(Utilisateur utilisateur)
        {
            return Content("Login");
        }

        [HttpGet]
        public ActionResult CreationCompte()
        {
            return View();
        }

    }
}