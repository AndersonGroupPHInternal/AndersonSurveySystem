using AndersonSurveySystemFunction;
using AndersonSurveySystemModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AndersonSurveySystem.Controllers
{
    [RoutePrefix("Comment")]
    public class CommentController : Controller
    {
        private IFComment _iFComment;

        List<Comment> Comments = new List<Comment>();




        public CommentController()
        {
            _iFComment = new FComment();
        }

        [Route("")]
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View(new Comment());
        }

        [HttpPost]
        public JsonResult Create(Comment comment)
        {

            try
            {
                comment = _iFComment.Create(comment);
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
                Comment comment = new Comment();
                return Json(_iFComment.List());
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
                Comment comment = _iFComment.Read(id);

                return View(comment);
            }
            catch (Exception ex)
            {
                return View(new Comment());
            }
        }

        [HttpPost]
        public ActionResult Update(Comment comment)
        {
            try
            {
                comment = _iFComment.Update(comment);
                return Json("");
            }
            catch (Exception ex)
            {
                return View(ex);
            }
        }

        [HttpPost]
        public ActionResult Delete(Comment comment)
        {
            try
            {
                _iFComment.Delete(comment);
                return Json("");
            }
            catch (Exception ex)
            {
                return Json(ex);
            }
        }
    }
}