using Filtreler.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Filtreler.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult SıgnIn()
        {
            return View(new SiteUser());
        }
        [HttpPost]
        public ActionResult SıgnIn(SiteUser model)
        {
            DatabaseContext db = new DatabaseContext();
            SiteUser user = db.SiteUsers.FirstOrDefault(x => x.KullaniciAdi == model.KullaniciAdi && x.Sifre == model.Sifre);
            if (user == null)
            {
                ModelState.AddModelError("", "Hatalı Kullanıcı adı ya da şifre");
                return View(model);
            }
            else
            {
                Session["login"] = user;
                return RedirectToAction("Index", "Home");
            }
        }
        public ActionResult Error()
        {
            if (TempData["error"] == null)
                return RedirectToAction("Index", "Home");
            Exception model = TempData["error"] as Exception;
            return View(model);
        }
    }
}