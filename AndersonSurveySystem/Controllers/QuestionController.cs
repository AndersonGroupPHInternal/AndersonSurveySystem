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
        [HttpGet]
        public ActionResult Create()
        {
            return View(new Question());
        }

        [HttpPost]
        public ActionResult Create(Question question)
        {
            var createdUser = _iFQuestion.Create(QuestionId, question);
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
            return Json(_iFQuestion.Read());
        }
        #endregion

        #region Update
        [HttpGet]
        public ActionResult Update(int id)
        {
            return View(_iFQuestion.Read(id));
        }

        [HttpPost]
        public ActionResult Update(Question question)
        {
            var createdUser = _iFQuestion.Update(QuestionId, question);
            return RedirectToAction("Index");
        }
        #endregion

        #region Delete
        [HttpDelete]
        public JsonResult Delete(int id)
        {
            _iFQuestion.Delete(id);
            return Json(string.Empty);
        }
        #endregion
    }
}