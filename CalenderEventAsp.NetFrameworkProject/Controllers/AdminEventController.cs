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
    public class AdminEventController : Controller
    {
        public CalenderEventContext db;

        public AdminEventController()
        {
            db = new CalenderEventContext();
        }


        // GET: AdminEvent
        public ActionResult Index()
        {
            var values = db.Events.ToList();
            return View(values);
        }

        [HttpGet]
        public ActionResult CreateEvent()
        {
            var categories = db.Categories.Select(c => new SelectListItem
            {
                Text=c.CategoryName,
                Value =c.CategoryId.ToString(),
            }).ToList();
            ViewBag.CategoryList = categories;  
            return View();
        } 

        [HttpPost]
        public ActionResult CreateEvent(Event model)
        {
            var categories = db.Categories.Select(c => new SelectListItem
            {
                Text = c.CategoryName,
                Value = c.CategoryId.ToString(),
            }).ToList();
            ViewBag.CategoryList = categories;


            if (ModelState.IsValid)
            {
                
                db.Events.Add(model);
                db.SaveChanges();
                return RedirectToAction("Index");   
            }
            return View(model);
        }

        [HttpGet]
        public ActionResult EditEvent(int id)
        {
            var value = db.Events.Find(id);
            return View(value);
        }

        [ValidateAntiForgeryToken]
        [HttpPost]
        public ActionResult EditEvent(Event model)
        {
            if (ModelState.IsValid)
            {
                db.Entry(model).State = EntityState.Modified;
                db.SaveChanges();   
                return RedirectToAction("Index");
            }
            return View();
        }

        public ActionResult DeleteEvent(int id)
        {
            var value = db.Events.Find(id); 
            db.Events.Remove(value);
            db.SaveChanges();   
            return RedirectToAction("Index");   
        }
    }
}