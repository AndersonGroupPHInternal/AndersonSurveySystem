using AndersonSurveySystemFunction;
using AndersonSurveySystemModel;
using System.Web.Mvc;

namespace AndersonSurveySystem.Controllers
{
    public class SurveyController : BaseController
    {
        private IFSurvey _iFSurvey;

        public int SurveyId { get; private set; }

        public SurveyController(IFSurvey iFSurvey)
        {
            _iFSurvey = iFSurvey;
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
        public JsonResult Read(int surveyId)
        {
            return Json(_iFSurvey.Read(surveyId));
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
            return RedirectToAction("Index");
        }
        #endregion

        #region Delete
        [HttpDelete]
        public JsonResult Delete(Survey survey)
        {
            _iFSurvey.Delete(survey);
            return Json(string.Empty);
        }
        #endregion
    }
}