using AndersonSurveySystemModel;
using AndersonSurveySystemFunction;
using System;
using System.Web.Mvc;

namespace AndersonSurveySystem.Controllers
{
    public class QuestionResultController : Controller
    {
        private IFQuestionResult _iFQuestionResult;

        public QuestionResultController(IFQuestionResult iFQuestionResult)
        {
            _iFQuestionResult = iFQuestionResult;
        }

        public ActionResult Index()
        {
            return View();
        }
        public ActionResult List()
        {
            return View();
        }

        [HttpPost]
        public JsonResult Result(QuestionResultFilter questionResultFilter)
        {
            try
            {
                return Json(_iFQuestionResult.Read(questionResultFilter));
            }
            catch (Exception exception)
            {
                return Json(exception);
            }
        }
    }
}