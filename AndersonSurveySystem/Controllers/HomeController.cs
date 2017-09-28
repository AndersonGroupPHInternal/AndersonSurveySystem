using AndersonSurveySystemFunction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AndersonSurveySystem.Controllers
{
    public class HomeController : Controller
    {

        private IFAnsweredSurveyResult _iFAnsweredSurveyResult;

        public HomeController()
        {

            _iFAnsweredSurveyResult = new FAnsweredSurveyResult();
        }


        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        //public ActionResult Static()
        //{
        //    return View();
        //}

        public JsonResult Static()
        {
            return Json(_iFAnsweredSurveyResult.List(0));
        }

        public ActionResult StaticStructured()
        {
            return View();
        }

        public ActionResult DynamicStructured()
        {
            return View();
        }

        public JsonResult DynamicStructuredData()
        {
           
            return Json(_iFAnsweredSurveyResult.List(0));
        }
    }
}