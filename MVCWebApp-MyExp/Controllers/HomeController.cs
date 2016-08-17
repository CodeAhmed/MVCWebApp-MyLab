using MVCWebApp_MyExp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCWebApp_MyExp.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            ObjectList obj = new ObjectList();
            for (int i = 0; i < 2; i++)
            {
                obj.ObjList.Add(new ObjectItem());
            }
            return View(obj);
        }

        public ActionResult AddObject()
        {
            ObjectList obj = new ObjectList();
            obj.ObjList.Add(new ObjectItem());
            return PartialView("_AddObject",obj);
        }

        [HttpPost]
        public ActionResult Index([Bind] ObjectList obj)
        {
            return View("Index");
        }
    }
}