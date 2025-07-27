using CalenderEventAsp.NetFrameworkProject.Context;
using CalenderEventAsp.NetFrameworkProject.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CalenderEventAsp.NetFrameworkProject.Controllers
{
    public class AdminCategoryController : Controller
    {
        private readonly CalenderEventContext db;

        public AdminCategoryController()
        {
            db = new CalenderEventContext();
        }


        // GET: AdminCategory
        public ActionResult Index()
        {
            var values = db.Categories.ToList();
            return View(values);
        }


        [HttpGet]
        public ActionResult CreateCategory()
        {
            ViewBag.ColorList = new SelectList(new List<SelectListItem>
            {
                 new SelectListItem { Text = "Siyah", Value = "text-dark" },
                new SelectListItem { Text = "Kırmızı", Value = "text-danger" },
                new SelectListItem { Text = "Yeşil", Value = "text-success" },
                new SelectListItem { Text = "Mavi", Value = "text-primary" },
                new SelectListItem { Text = "Turuncu", Value = "text-warning" },
                new SelectListItem { Text = "Gri", Value = "text-muted" }
            }, "Value", "Text");

            return View();
        }

        [HttpPost]
        public ActionResult CreateCategory(Category model)
        {
            ViewBag.ColorList = new SelectList(new List<SelectListItem>
            {
                 new SelectListItem { Text = "Siyah", Value = "text-dark" },
                new SelectListItem { Text = "Kırmızı", Value = "text-danger" },
                new SelectListItem { Text = "Yeşil", Value = "text-success" },
                new SelectListItem { Text = "Mavi", Value = "text-primary" },
                new SelectListItem { Text = "Turuncu", Value = "text-warning" },
                new SelectListItem { Text = "Gri", Value = "text-muted" }
            }, "Value", "Text");

            if (ModelState.IsValid)
            {

                db.Categories.Add(model);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(model);
        }

        [HttpGet]
        public ActionResult EditCategory(int id)
        {
            var value = db.Categories.Find(id);

            ViewBag.ColorList = new SelectList(new List<SelectListItem>
            {
                 new SelectListItem { Text = "Siyah", Value = "text-dark" },
                new SelectListItem { Text = "Kırmızı", Value = "text-danger" },
                new SelectListItem { Text = "Yeşil", Value = "text-success" },
                new SelectListItem { Text = "Mavi", Value = "text-primary" },
                new SelectListItem { Text = "Turuncu", Value = "text-warning" },
                new SelectListItem { Text = "Gri", Value = "text-muted" }
            }, "Value", "Text");

            return View(value);
        }

        [ValidateAntiForgeryToken]
        [HttpPost]
        public ActionResult EditCategory(Category model)
        {
            ViewBag.ColorList = new SelectList(new List<SelectListItem>
            {
                 new SelectListItem { Text = "Siyah", Value = "text-dark" },
                new SelectListItem { Text = "Kırmızı", Value = "text-danger" },
                new SelectListItem { Text = "Yeşil", Value = "text-success" },
                new SelectListItem { Text = "Mavi", Value = "text-primary" },
                new SelectListItem { Text = "Turuncu", Value = "text-warning" },
                new SelectListItem { Text = "Gri", Value = "text-muted" }
            }, "Value", "Text");

            if (ModelState.IsValid)
            {
                db.Entry(model).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }

        public ActionResult DeleteCategory(int id)
        {
            var value = db.Categories.Find(id);
            db.Categories.Remove(value);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}