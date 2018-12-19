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
            if (DateTime.Today.DayOfWeek == DayOfWeek.Monday)
            {
                //return new RedirectResult("/");.... or
                return Redirect("/");
            }

            //return new ContentResult()
            //{
            //    Content = "This is the deatail page" 
            //}; This can be replaced by
            return Content("This is the detail page");
        }
    }
}