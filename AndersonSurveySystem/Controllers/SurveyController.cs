using AndersonSurveySystemFunction;
using AndersonSurveySystemModel;
using System.Web.Mvc;

namespace AndersonSurveySystem.Controllers
{
    public class SurveyController : /*Base*/Controller
    {
        private IFSurvey _iFSurvey;
        private IFQuestion _iFQuestion;

        public int SurveyId { get; private set; }

        public SurveyController(IFSurvey iFSurvey, IFQuestion iFQuestion)
        {
            _iFSurvey = iFSurvey;
            _iFQuestion = iFQuestion;
        }

        #region Create
        [HttpGet]
        public ActionResult Create()
        {
            return View(new Survey());
        }

        [HttpPost]
        public ActionResult Create(Survey survey)
        {
            var createdUser = _iFSurvey.Create(SurveyId, survey);
            _iFQuestion.Create(createdUser.SurveyId, /*CredentialId*/0, survey.Questions);
            return RedirectToAction("Index");
        }
        #endregion

        #region Read
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public JsonResult Read()
        {
            return Json(_iFSurvey.Read());
        }
        #endregion

        #region Update
        [HttpGet]
        public ActionResult Update(int id)
        {
            return View(_iFSurvey.Read(id));
        }

        [HttpPost]
        public ActionResult Update(Survey survey)
        {
            var createdUser = _iFSurvey.Update(SurveyId, survey);
            _iFQuestion.Delete(survey.DeletedQuestions);
            _iFQuestion.Create(createdUser.SurveyId, /*CredentialId*/0, survey.Questions);
            return RedirectToAction("Index");
        }
        #endregion

        #region Delete
        [HttpDelete]
        public JsonResult Delete(int id)
        {
            _iFSurvey.Delete(id);
            return Json(string.Empty);
        }
        #endregion
    }
}