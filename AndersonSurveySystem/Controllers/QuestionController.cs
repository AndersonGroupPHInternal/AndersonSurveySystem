using AndersonSurveySystemFunction;
using AndersonSurveySystemModel;
using System.Web.Mvc;

namespace AndersonSurveySystem.Controllers
{
    public class QuestionController : Controller
    {
        private IFQuestion _iFQuestion;

        public int QuestionId { get; private set; }

        public QuestionController(IFQuestion iFQuestion)
        {
            _iFQuestion = iFQuestion;
        }

        #region Create
        #endregion

        #region Read
        [HttpPost]
        public JsonResult Read(int id)
        {
            return Json(_iFQuestion.Read(id));
        }
        #endregion

        #region Update
        #endregion

        #region Delete
        #endregion
    }
}