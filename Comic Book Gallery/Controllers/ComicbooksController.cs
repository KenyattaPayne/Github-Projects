using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Comic_Book_Gallery.Controllers
{
    public class ComicbooksController : Controller
    {

        public ActionResult Detail()
        {



            if (DateTime.Today.DayOfWeek == DayOfWeek.Monday)
            {
                return Redirect("/");
                

            }
            return Content("Hello from the comics book controller");
           



        }
    }

}