using ModelsTeskApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ModelsTeskApp.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
            Student studentOne = new Student();
            studentOne.Name = " StudentOne";
            studentOne.LastName = "LastName";
            return View();
        }

        public ActionResult GetObjStudent()
        {
            Student studentTwo = new Student();
            studentTwo.Name = "StudentTwo ";
            studentTwo.LastName = "LastName";
            studentTwo.YearBirth = 2010;
            studentTwo.Class = 6; 
            return View(studentTwo);
        }
    }
}