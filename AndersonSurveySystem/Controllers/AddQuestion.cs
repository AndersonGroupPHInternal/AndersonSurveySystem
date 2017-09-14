using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AndersonSurveySystem.Controllers
{
    public class AddQuestion : Controller
    {
        // GET: AddQuestion
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost,ActionName("Index")]
        public ActionResult Index2()
        {
            return View();
        }
    }
}