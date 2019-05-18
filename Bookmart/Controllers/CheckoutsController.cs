using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Bookmart.Controllers
{
    public class CheckoutsController : Controller
    {
        // GET: Checkouts
        public ActionResult New()
        {
            return View();
        }
    }
}