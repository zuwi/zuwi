using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using zuwi.Models;

namespace zuwi.Controllers
{
    public class SitesController : Controller
    {
        private ZuwiDBModelContainer _db = new ZuwiDBModelContainer();

        public ActionResult Show(string siteName)
        {
            try
            {
                return View(_db.Sites.Where(s => s.Name == siteName).First());
            }
            catch
            {
                return RedirectToAction("Index", "Home");
            }
        }

        public ActionResult CreateWidget()
        {
            
            return Redirect("/");
        }
    }
}