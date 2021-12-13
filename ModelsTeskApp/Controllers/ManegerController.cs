using ModelsTeskApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ModelsTeskApp.Controllers
{
    public class ManegerController : Controller
    {
        // GET: Maneger
        public ActionResult ManegerPage()
        {
            Maneger manegerOne = new Maneger();
            manegerOne.Name = "Meir";
            manegerOne.LasN = "Menahel";
            manegerOne.PhoneNum = 975245 ;
            ViewBag.ManegerName = manegerOne;
            return View();
        }


        public ActionResult ModelMangere()
        {
            Maneger manegerTwo= new Maneger();
            manegerTwo.Name = "Menahel";
            manegerTwo.LasN = "Menahel";
            manegerTwo.PhoneNum = 895658;
            return View(manegerTwo);
        }
    }
}