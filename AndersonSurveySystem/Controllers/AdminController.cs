using AndersonSurveySystemFunction;
using AndersonSurveySystemModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AndersonSurveySystem.Controllers
{
    [RoutePrefix("Admin")]
    public class AdminController : Controller
    {
        private IFAdmin _iFAdmin;

        public AdminController()
        {
            _iFAdmin = new FAdmin();
        }

        [Route("")]
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [Route("")]
        [HttpGet]
        public ActionResult Index2()
        {
            return View();
        }

        [Route("")]
        [HttpGet]
        public ActionResult MainPage()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Report()
        {
            return View(new Admin());
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View(new Admin());
        }


        [HttpPost]
        public JsonResult Create(Admin admin)
        {

            try
            {
                admin = _iFAdmin.Create(admin);
                return Json("");
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
                Admin admin = new Admin();
                return Json(_iFAdmin.List());
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
                Admin admin = _iFAdmin.Read(id);
                return View(admin);
            }
            catch (Exception ex)
            {
                return View(new Admin());
            }
        }

        [HttpPost]
        public ActionResult Update(Admin admin)
        {
            try
            {
                admin = _iFAdmin.Update(admin);
                return Json("");
            }
            catch (Exception ex)
            {
                return View(ex);
            }
        }

        [HttpPost]
        public ActionResult Delete(Admin admin)
        {
            try
            {
                _iFAdmin.Delete(admin);
                return Json("");
            }
            catch (Exception ex)
            {
                return Json(ex);
            }
        }
    }
}