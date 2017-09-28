using AndersonSurveySystemContext;
using AndersonSurveySystemFunction;
using AndersonSurveySystemModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AndersonSurveySystem.Controllers
{
    [RoutePrefix("Survey")]
    public class SurveyController : Controller
    {
        private IFSurvey _iFSurvey;

        List<Survey> Rates = new List<Survey>();

      


public SurveyController()
        {
            _iFSurvey = new FSurvey();
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
            return View(new Survey());
        }


        [HttpPost]
        public JsonResult Create(Survey survey)
        {

            try
            {
                survey = _iFSurvey.Create(survey);
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
                Survey survey = new Survey();
                return Json(_iFSurvey.List());
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
                Survey survey = _iFSurvey.Read(id);
               
                return View(survey);
            }
            catch (Exception ex)
            {
                return View(new Survey());
            }
        }

        [HttpPost]
        public ActionResult Update(Survey survey)
        {
            try
            {
                survey = _iFSurvey.Update(survey);
                return Json("");
            }
            catch (Exception ex)
            {
                return View(ex);
            }
        }

        [HttpPost]
        public ActionResult Delete(Survey survey)
        {
            try
            {
                _iFSurvey.Delete(survey);
                return Json("");
            }
            catch (Exception ex)
            {
                return Json(ex);
            }
        }
    }
}