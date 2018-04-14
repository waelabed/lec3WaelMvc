using HomeWorkLec2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HomeWorkLec2.Controllers
{
    public class LessonController : Controller
    {
        ApplicationDbContext db = new ApplicationDbContext();
        // GET: Lesson
        public ActionResult Index()
        {
            var lessons = db.Lessons.ToList();
            return View(lessons);
        }

        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Lesson lesson)
        {
            db.Lessons.Add(lesson);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Delete(int Id)
        {
            var lessons = db.Lessons.Find(Id);
            db.Lessons.Remove(lessons);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}