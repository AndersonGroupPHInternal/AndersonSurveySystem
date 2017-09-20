//using AndersonSurveySystemFunction;
//using AndersonSurveySystemModel;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Web;
//using System.Web.Mvc;

//namespace AndersonSurveySystem.Controllers
//{
//    [RoutePrefix("Rate")]
//    public class RateController : Controller
//    {
//        private IFRate _iFRate;

//        List<Rate> Rates = new List<Rate>();




//        public RateController()
//        {
//            _iFRate = new FRate();
//        }

//        [Route("")]
//        [HttpGet]
//        public ActionResult Index()
//        {
//            return View();
//        }

//        [HttpGet]
//        public ActionResult Create(List<Rate> rate)
//        {
//            //foreach (var rate in rates)
//            //{
//            //    _iFRate.Create(rates);
//            //}
//            return Json("");
//            return View(new Rate());
//        }

//        [HttpPost]
//        public JsonResult Create(Rate rate)
//        {

//            try
//            {
//                rate = _iFRate.Create(rate);
//                return Json("");
//            }
//            catch (Exception ex)
//            {
//                return Json(ex);
//            }
//        }

//        [Route("List")]
//        [HttpPost]
//        public ActionResult List()
//        {
//            try
//            {
//                Rate rate = new Rate();
//                return Json(_iFRate.List());
//            }
//            catch (Exception exception)
//            {
//                return Json(exception);
//            }
//        }

//        [HttpGet]
//        public ActionResult Update(int id)
//        {
//            try
//            {
//                Rate rate = _iFRate.Read(id);

//                return View(rate);
//            }
//            catch (Exception ex)
//            {
//                return View(new Rate());
//            }
//        }

//        [HttpPost]
//        public ActionResult Update(Rate rate)
//        {
//            try
//            {
//                rate = _iFRate.Update(rate);
//                return Json("");
//            }
//            catch (Exception ex)
//            {
//                return View(ex);
//            }
//        }

//        [HttpPost]
//        public ActionResult Delete(Rate rate)
//        {
//            try
//            {
//                _iFRate.Delete(rate);
//                return Json("");
//            }
//            catch (Exception ex)
//            {
//                return Json(ex);
//            }
//        }
//    }
//}