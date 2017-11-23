using Filtreler.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Filtreler.Filters
{
    //Artık attribute olarak yazılabilr hale gelir orneğin contollera attribute olarak yazabilirsiniz
    public class ActionFilter : FilterAttribute, IActionFilter
    {
        DatabaseContext db = new DatabaseContext();
        //Action Çalıştıktan sonra
        public void OnActionExecuted(ActionExecutedContext filterContext)
        {
            db.Logs.Add(new Log()
            {
                KullaniciAdi = (filterContext.HttpContext.Session["login"] as SiteUser).KullaniciAdi,
                ActionName = filterContext.ActionDescriptor.ActionName,
                ControllerName = filterContext.ActionDescriptor.ControllerDescriptor.ControllerName,
                Tarih = DateTime.Now,
                Bilgi = "OnActionExecuted"
            });
            db.SaveChanges();
        }

        //Action Çalışmadan önce
        public void OnActionExecuting(ActionExecutingContext filterContext)
        {
            db.Logs.Add(new Log()
            {
                KullaniciAdi = (filterContext.HttpContext.Session["login"] as SiteUser).KullaniciAdi,
                ActionName = filterContext.ActionDescriptor.ActionName,
                ControllerName = filterContext.ActionDescriptor.ControllerDescriptor.ControllerName,
                Tarih = DateTime.Now,
                Bilgi = "OnActionExecuting"
            });
            db.SaveChanges();
        }
    }
}