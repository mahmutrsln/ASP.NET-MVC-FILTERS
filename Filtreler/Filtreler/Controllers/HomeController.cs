using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Filtreler.Filters;
namespace Filtreler.Controllers
{
    [ActionFilter, ResultFilter, AuthFilter, ExcFilter]
    public class HomeController : Controller
    {

        public ActionResult Index()
        {
            return View();
        }
     
        public ActionResult Index2()
        {
            object sayi = 0;
            int deger = 100 / (int)sayi;
            //throw new Exception("Kullanıcı yetkisiz giriş yaptı");
            return View();
        }
   
        public ActionResult Index3()
        {
            return View();
        }
    }
}