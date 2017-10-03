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

        [HttpPost]
        public JsonResult Result(int id)
        {
            try
            {
                Question question = new Question();
                return Json(_iFQuestionResult.Read(id));
            }
            catch (Exception exception)
            {
                return Json(exception);
            }
        }
    }
}