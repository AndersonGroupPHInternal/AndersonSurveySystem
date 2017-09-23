//using AndersonSurveySystemFunction;
//using AndersonSurveySystemModel;
//using System;
//using System.Web.Mvc;

//namespace AndersonSurveySystem.Controllers
//{
//    [RoutePrefix("Email")]
//    public class EmailController : Controller
//    {
//        private IFEmail _iFEmail;

//        public EmailController()
//        {
//            _iFEmail = new FEmail();
//        }

//        [Route("")]
//        [HttpGet]
//        public ActionResult Index()
//        {
//            return View();
//        }

//        [Route("")]
//        [HttpGet]
//        public ActionResult Index2()
//        {
//            return View();
//        }

//        [HttpGet]
//        public ActionResult Create()
//        {
//            return View(new Email());
//        }


//        [HttpPost]
//        public JsonResult Create(Email email)
//        {

//            try
//            {
//                email = _iFEmail.Create(email);
//                return Json("");
//            }
//            catch (Exception ex)
//            {
//                return Json(ex);
//            }
//        }

//        [Route("List")]
//        [HttpPost]
//        public ActionResult List()
//        {
//            try
//            {
//                Email email = new Email();
//                return Json(_iFEmail.List());
//            }
//            catch (Exception exception)
//            {
//                return Json(exception);
//            }
//        }

//        [HttpGet]
//        public ActionResult Update(int id)
//        {
//            try
//            {
//                Email email = _iFEmail.Read(id);
//                return View(email);
//            }
//            catch (Exception ex)
//            {
//                return View(new Email());
//            }
//        }

//        [HttpPost]
//        public ActionResult Update(Email email)
//        {
//            try
//            {
//                email = _iFEmail.Update(email);
//                return Json("");
//            }
//            catch (Exception ex)
//            {
//                return View(ex);
//            }
//        }

//        [HttpPost]
//        public ActionResult Delete(Email email)
//        {
//            try
//            {
//                _iFEmail.Delete(email);
//                return Json("");
//            }
//            catch (Exception ex)
//            {
//                return Json(ex);
//            }
//        }
//    }
//}