using CalenderEventAsp.NetFrameworkProject.Context;
using CalenderEventAsp.NetFrameworkProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CalenderEventAsp.NetFrameworkProject.Controllers
{
    public class EventController : Controller
    {
        private CalenderEventContext db = new CalenderEventContext();


        [HttpGet]
        public ActionResult Index()
        {
            return View();  
        }

        [HttpGet]
        public JsonResult GetEvents()
        {
            var events = db.Events.
                 AsEnumerable().
                 Select(e => new {
                id = e.EventId,
                title = e.Title,
                start = e.Start.ToString("s"), // ISO 8601 format
                end = e.End.HasValue ? e.End.Value.ToString("s") : null,
                allDay = e.AllDay,
                backgroundColor = e.BackgroundColor,
                borderColor = e.BorderColor
            }).ToList();

            return Json(events, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public JsonResult CreateEvent(string Title, DateTime Start, DateTime? End, bool AllDay, string BackgroundColor, string BorderColor)
        {
            try
            {
                var newEvent = new Event
                {
                    Title = Title,
                    Start = Start,
                    End = End,
                    AllDay = AllDay,
                    BackgroundColor = BackgroundColor,
                    BorderColor = BorderColor
                };

                db.Events.Add(newEvent);
                db.SaveChanges();

                // ⬇️ EventId'yi JSON olarak dön
                return Json(new { success = true, id = newEvent.EventId });
            }
            catch (Exception ex)
            {
                return Json(new { success = false, error = ex.Message });
            }
        }


        [HttpPost]
        public JsonResult UpdateEvent(int id, DateTime start, DateTime? end)
        {
            try
            {
                var evt = db.Events.Find(id);
                if (evt == null)
                    return Json(new { success = false, message = "Etkinlik bulunamadı. ID = " + id });

                evt.Start = start;
                evt.End = end;
                db.SaveChanges();

                return Json(new { success = true });
            }
            catch (Exception ex)
            {
                return Json(new { success = false, message = ex.Message }); // HATA BURADA GÖRÜNÜR
            }
        }

        [HttpPost]
        public JsonResult DeleteEvent(int id)
        {
            try
            {
                var evt = db.Events.Find(id);
                if (evt == null)
                    return Json(new { success = false, message = "Etkinlik bulunamadı." });

                db.Events.Remove(evt);
                db.SaveChanges();

                return Json(new { success = true });
            }
            catch (Exception ex)
            {
                return Json(new { success = false, message = ex.Message });
            }
        }

    }
}