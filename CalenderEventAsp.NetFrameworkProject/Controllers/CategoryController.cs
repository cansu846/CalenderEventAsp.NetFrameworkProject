using CalenderEventAsp.NetFrameworkProject.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CalenderEventAsp.NetFrameworkProject.Controllers
{
    public class CategoryController : Controller
    {
        private readonly CalenderEventContext db;

        public CategoryController()
        {
            db = new CalenderEventContext();
        }


        // GET: Category
        public ActionResult Index()
        {
            var values = db.Categories.ToList();
            return View(values);
        }

        [HttpGet]
        public JsonResult GetCategories()
        {
            var categories = db.Categories.Select(c => new
            {
                c.CategoryId,
                c.CategoryName,
                c.Color
            }).ToList();

            return Json(categories, JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        public PartialViewResult CategoryColorList()
        {
            var categories = db.Categories.ToList(); // veya ViewModel'e maple
            return PartialView("_CategoryColorListPartial", categories);
        }
    }
}