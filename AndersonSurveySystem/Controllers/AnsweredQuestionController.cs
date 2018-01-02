using AndersonSurveySystemFunction;
using AndersonSurveySystemModel;
using System;
using System.Web.Mvc;


namespace AndersonSurveySystem.Controllers
{
    public class AnsweredQuestionController : BaseController
    {
        private IFAnsweredQuestion _iFAnsweredQuestion;

        public AnsweredQuestionController(IFAnsweredQuestion iFAnsweredQuestion)
        {
            _iFAnsweredQuestion = iFAnsweredQuestion;
        }

        [HttpPost]
        public JsonResult Read(QuestionResultFilter questionResultFilter)
        {

            try
            {
                var answeredQuestions = _iFAnsweredQuestion.Read(questionResultFilter);
                return Json(answeredQuestions);
            }
            catch (Exception ex)
            {
                return Json(ex);
            }
        }

    }

}