using AndersonSurveySystemModel;
using AndersonSurveySystemFunction;
using System;
using System.Web.Mvc;

namespace AndersonSurveySystem.Controllers
{
    [RoutePrefix("Question")]
    public class QuestionController : Controller
    {
        private IFQuestion _iFQuestion;

        public QuestionController()
        {
            _iFQuestion = new FQuestion();
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
            return View(new Question());
        }

        [HttpPost]
        public JsonResult Create(Question question)
        {

            try
            {
                question = _iFQuestion.Create(question);
                return Json("answeredsurvey");
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
                Question question = new Question();
                return Json(_iFQuestion.List());
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
                Question question = _iFQuestion.Read(id);
                return View(question);
            }
            catch (Exception ex)
            {
                return View(new Question());
            }
        }

        [HttpPost]
        public ActionResult Update(Question question)
        {
            try
            {
                question = _iFQuestion.Update(question);
                return Json("");
            }
            catch (Exception ex)
            {
                return View(ex);
            }
        }

        [HttpPost]
        public ActionResult Delete(Question question)
        {
            try
            {
                _iFQuestion.Delete(question);
                return Json("");
            }
            catch (Exception ex)
            {
                return Json(ex);
            }
        }
    }
}