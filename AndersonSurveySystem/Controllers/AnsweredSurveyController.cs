using AndersonSurveySystemFunction;
using AndersonSurveySystemModel;
using System;
using System.Web.Mvc;


namespace AndersonSurveySystem.Controllers
{
    public class AnsweredSurveyController : Controller
    {
        private IFAnsweredQuestion _iFAnsweredQuestion;
        private IFAnsweredSurvey _iFAnsweredSurvey;
        private IFSurvey _iFSurvey;

        public AnsweredSurveyController(IFAnsweredQuestion iFAnsweredQuestion, IFAnsweredSurvey iFAnsweredSurvey, IFSurvey iFSurvey)
        {
            _iFAnsweredQuestion = iFAnsweredQuestion;
            _iFAnsweredSurvey = iFAnsweredSurvey;
            _iFSurvey = iFSurvey;
        }
        
        [HttpGet]
        public ActionResult Index(int surveyId, string description, string firstName, string middleName, string lastName, string ticketNumber)
        {
            var survey = _iFSurvey.Read(surveyId);
            var answeredSurvey = new AnsweredSurvey
            {
                SurveyId = surveyId,

                Description = description,
                FirstName = firstName,
                MiddleName = middleName,
                LastName = lastName,
                TicketNumber = ticketNumber,

                Survey = survey
            };
            return View(answeredSurvey);

        }

        [HttpPost]
        public ActionResult Create(AnsweredSurvey answeredSurvey)
        {
            try
            {
                var result = _iFAnsweredSurvey.Create(answeredSurvey);
                foreach(var answeredQuestion in answeredSurvey.AnsweredQuestions)
                {
                    answeredQuestion.AnsweredSurveyId = result.AnsweredSurveyId;
                    _iFAnsweredQuestion.Create(answeredQuestion);
                }
                return RedirectToAction("Answered", "AnsweredSurvey", new { answeredSurveyId = result.AnsweredSurveyId });
            }
            catch (Exception ex)
            {
                return Json(ex);
            }
        }

        [HttpGet]
        public ActionResult Answered(int answeredSurveyId)
        {

            try
            {
                var answeredSurvey = _iFAnsweredSurvey.Read(answeredSurveyId);
                return View(answeredSurvey);
            }
            catch (Exception ex)
            {
                return Json(ex);
            }
        }

    }

}