using ModelsTeskApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ModelsTeskApp.Controllers
{
    public class TeacherController : Controller
    {
        // GET: Teacher
        public ActionResult Teacher()
        {
            Teacher teacherOne = new Teacher("Mora", "Kita 2", 1980, 5000);
            ViewBag.Teacher = teacherOne;
            return View();
        }

        public ActionResult ListOfStudent()
        {
 

            return View(ListOfTeachers());
        }

        private static List<Teacher> ListOfTeachers()
        {
            List<Teacher> listOfArray = new List<Teacher>();
            listOfArray.Add(new Teacher("Moree", "MoreeLastNAME", 2010, 5000));
            listOfArray.Add(new Teacher("Moshe", "MoreeLastNAME", 4535, 8000));
            listOfArray.Add(new Teacher("Abraham", "MoreeLastNAME", 234, 7000));
            listOfArray.Add(new Teacher("Yossef", "MoreeLastNAME", 1888, 900));
            return listOfArray;
        }
    }
}