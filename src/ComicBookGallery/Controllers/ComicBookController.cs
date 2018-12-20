using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ComicBookGallery.Controllers
{
    public class ComicBookController : Controller
    {
        //action methods must be public 
        //(EVERY PUBLIC METHOD IS REFERED TO AS AN ACTION METHOD)

        public ActionResult Detail()
        {
            //if (DateTime.Today.DayOfWeek == DayOfWeek.Monday)
            //{
            //    //return new RedirectResult("/");.... or
            //    //return Redirect("/");
            //}

            //return new ContentResult()
            //{
            //    Content = "This is the deatail page" 
            //}; This can be replaced by
            //return Content("This is the detail page");

            ViewBag.SeriesTitle = "The Amazing SpiderMan";
            ViewBag.IssueNumber = 79;
            ViewBag.Description = "<p>Final issue! Witness the final hours of Doctor Octopus' " +
                        "life and his one, last, great act of revenge! Even if Spider-Man survives... " +
                        "<strong>will Peter Parker?</strong></p>";
            ViewBag.Artists = new string[]
            {
                "Script: Dan Slott",
                "Pencils: Humberto Ramos",
                "Inks: Victor Olazaba",
                "Colors: Edgar Delgado",
                "Letters: Chris Eliopoulos"
            };

            return View();
        }
    }
}