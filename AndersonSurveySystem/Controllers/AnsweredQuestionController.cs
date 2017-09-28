using AndersonSurveySystemFunction;
using AndersonSurveySystemModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AndersonSurveySystem.Controllers
{
    [RoutePrefix("AnsweredQuestion")]
    public class AnsweredQuestionController : Controller
    {

        private IFAnsweredQuestion _iFAnsweredQuestion;

        public AnsweredQuestionController()
        {
            _iFAnsweredQuestion = new FAnsweredQuestion();
        }

        [Route("")]
        [HttpGet]
        public ActionResult Index(string Name)
        {
            //return View();

            var answeredsurveyss = new AnsweredSurvey { Name = " " + Name };

            return View(answeredsurveyss);
        }

        [HttpGet]
        public ActionResult Index2()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View(new AnsweredQuestion());
        }

        [HttpPost]
        public JsonResult Create(AnsweredQuestion answeredquestion)
        {

            try
            {
                answeredquestion = _iFAnsweredQuestion.Create(answeredquestion);
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
                AnsweredQuestion answeredquestion = new AnsweredQuestion();
                return Json(_iFAnsweredQuestion.List());
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
                AnsweredQuestion answeredquestion = _iFAnsweredQuestion.Read(id);
                return View(answeredquestion);
            }
            catch (Exception ex)
            {
                return View(new AnsweredQuestion());
            }
        }

        [HttpPost]
        public ActionResult Update(AnsweredQuestion answeredquestion)
        {
            try
            {
                answeredquestion = _iFAnsweredQuestion.Update(answeredquestion);
                return Json("");
            }
            catch (Exception ex)
            {
                return View(ex);
            }
        }

        [HttpPost]
        public ActionResult Delete(AnsweredQuestion answeredquestion)
        {
            try
            {
                _iFAnsweredQuestion.Delete(answeredquestion);
                return Json("");
            }
            catch (Exception ex)
            {
                return Json(ex);
            }
        }

        
    }
}