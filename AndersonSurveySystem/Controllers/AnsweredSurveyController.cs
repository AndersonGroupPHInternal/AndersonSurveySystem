using AndersonSurveySystemFunction;
using AndersonSurveySystemModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AndersonSurveySystem.Controllers
{
    [RoutePrefix("AnsweredSurvey")]
    public class AnsweredSurveyController : Controller
    {
            
        private IFAnsweredSurvey _iFAnsweredSurvey;

        public AnsweredSurveyController()
        {
            _iFAnsweredSurvey = new FAnsweredSurvey();
        }

        [Route("")]
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View(new AnsweredSurvey());
        }

        [HttpPost]
        public JsonResult Create(AnsweredSurvey answeredsurvey)
        {

            try
            {
                answeredsurvey = _iFAnsweredSurvey.Create(answeredsurvey);
                return Json("");
            }
            catch (Exception ex)
            {
                return Json(ex);
            }
        }

        [Route("List")]
        [HttpPost]
        public ActionResult List()
        {
            
            try
            {
                AnsweredSurvey answeredsurvey = new AnsweredSurvey();
                return Json(_iFAnsweredSurvey.List());
            }
            catch (Exception exception)
            {
                return Json(exception);
            }
        }

        [HttpGet]
        public ActionResult Update(int id)
        {
            try
            {
                AnsweredSurvey answeredsurvey = _iFAnsweredSurvey.Read(id);
                return View(answeredsurvey);
            }
            catch (Exception ex)
            {
                return View(new AnsweredSurvey());
            }
        }

        [HttpPost]
        public ActionResult Update(AnsweredSurvey answeredsurvey)
        {
            try
            {
                answeredsurvey = _iFAnsweredSurvey.Update(answeredsurvey);
                return Json("");
            }
            catch (Exception ex)
            {
                return View(ex);
            }
        }

        [HttpPost]
        public ActionResult Delete(AnsweredSurvey answeredsurvey)
        {
            try
            {
                _iFAnsweredSurvey.Delete(answeredsurvey);
                return Json("");
            }
            catch (Exception ex)
            {
                return Json(ex);
            }
        }
    }
}