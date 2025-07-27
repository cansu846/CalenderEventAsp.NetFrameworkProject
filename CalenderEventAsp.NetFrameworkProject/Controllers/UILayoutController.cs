using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CalenderEventAsp.NetFrameworkProject.Controllers
{
    public class UILayoutController : Controller
    {
        // GET: UI
        public ActionResult Index()
        {
            return View();
        }
         public PartialViewResult Sidebar()
        {
            return PartialView("_SidebarPartial");
        }
    
    }
}