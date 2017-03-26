using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ComicBookGallery.Controllers
{
    public class ComicBooksController : Controller
    {
        public ActionResult Detail()
        {
            ViewBag.SeriesTitle = "The Amazing Spiderman";
            ViewBag.IssueNumbr = 700;
            ViewBag.Description = "<p>Final issue! Witness some stuff!</p>";
            ViewBag.Artists = new string[]
            {
                "Script: Dan Slott",
                "Pencils: Humberto Ramos",
                "Inks: Victor Whathisnaney",
                "Colors: Edgar Yost",
                "Letters: Chris Eliopoulus"
            };


            return View();
        }
            
        
    }
}