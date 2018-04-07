using HomeWorkLec2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HomeWorkLec2.Controllers
{
    public class StudentController : Controller
    {
        ApplicationDbContext db = new ApplicationDbContext();
        // GET: Student

        public ActionResult Index(string name)
        {
            List<Models.Student> students = new List<Models.Student>();
            if (string.IsNullOrEmpty(name))
            {
                students = db.Students.ToList();
            }
            else
            {
                students = db.Students.Where(fun => fun.name == name).ToList();
            }
            return View(students);
        }
        public ActionResult Create()
        {
            var lesson = db.Lessons.ToList();
            SelectList leslist = new SelectList(lesson, "Id", "Name");
            ViewBag.Les = leslist;
            return View();
        }
        [HttpPost]
        public ActionResult Create(Student student)
        {
            if (ModelState.IsValid)
            {
                student.LessonId = db.Lessons.Find(student.LessonId.Id);
                student.DateAdd = DateTime.Now;
                db.Students.Add(student);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View("Index");
        }

        public ActionResult Edit(int Id)
        {
            var lesson = db.Lessons.ToList();
            SelectList leslist = new SelectList(lesson, "Id", "Name");
            ViewBag.Les = leslist;
            Models.Student student = new Models.Student();
            student = db.Students.Find(Id);
            return View(student);
        }
        [HttpPost]
        public ActionResult Edit(Student student)
        {
            if (ModelState.IsValid)
            {
                student.LessonId = db.Lessons.Find(student.LessonId.Id);
                student.DateAdd = DateTime.Now;
                db.Entry(student).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }
    }
}