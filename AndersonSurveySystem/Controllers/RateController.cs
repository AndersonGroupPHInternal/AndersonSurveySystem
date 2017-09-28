using AndersonSurveySystemFunction;
using AndersonSurveySystemModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AndersonSurveySystem.Controllers
{
    [RoutePrefix("Rate")]
    public class RateController : Controller
    {
        private IFAnsweredSurveyResult _iFRate;

        List<Rate> Rates = new List<Rate>();

        public RateController()
        {
            _iFRate = new FAnsweredSurveyResult();
        }

        [Route("")]
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Static()
        {
            return View();
        }

        public ActionResult StaticStructured()
        {
            return View();
        }

        public ActionResult DynamicStructured()
        {
            return View();
        }

    }
}