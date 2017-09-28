using AndersonSurveySystemFunction;
using AndersonSurveySystemModel;
using System;
using System.Collections.Generic;
using AndersonSurveySystemContext;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Net;
using System.Collections.Specialized;
using System.Web.Script.Serialization;
using System.Net.Mail;


namespace AndersonSurveySystem.Controllers
{
    [RoutePrefix("AnsweredSurvey")]
    public class AnsweredSurveyController : Controller
    {
      
        private IFAnsweredSurvey _iFAnsweredSurvey;
        private IFAnsweredSurveyResult _iFAnsweredSurveyResult;

        public AnsweredSurveyController()
        {
           
            _iFAnsweredSurvey = new FAnsweredSurvey();
            _iFAnsweredSurveyResult = new FAnsweredSurveyResult();
        }


        [Route("")]
        [HttpGet]
        public ActionResult Index(string ticketnumber, string description, string Name)
        {

            var answeredsurveyss = new AnsweredSurvey { ticketnumber = " " + ticketnumber, description = " " + description, Name = " " + Name };

            return View(answeredsurveyss);

        }


        [Route("")]
        [HttpGet]
        public JsonResult Result(/*int answer, int questionId*/)
        {
            //return View();

            //List<AnsweredQuestion> answeredquestion = new List<AnsweredQuestion>();
            //try
            //{
            //    using (var ctx = new Context())
            //    {
            //        answeredquestion = ctx.AnsweredQuestion.Where(a => a.Answer == answer && a.QuestionId == questionId).Select(a =>
            //            new AnsweredQuestion
            //            {
            //                AnsweredQuestionId = a.AnsweredQuestionId,
            //                Answer = a.Answer,
            //                QuestionId = a.QuestionId
            //            }
            //        ).ToList();

            //    }
            //}
            //catch (Exception)
            //{
            //    throw;
            //}
            //return View();

            return Json(_iFAnsweredSurveyResult.List(0));
        }


        [HttpGet]
        public ActionResult Create()
        {
            return View(new AnsweredSurvey());
        }

        [HttpPost]
        public ActionResult Create(AnsweredSurvey answeredSurvey)
        {

            try
            {

                //foreach (var answeredsurvey in answeredsurveys)
                //{
                _iFAnsweredSurvey.Create(answeredSurvey);
                return RedirectToAction("Index", "AnsweredQuestion", new { Name = answeredSurvey.Name });
                //}

                //return View(/*new AnsweredQuestion()*/);
            }
            catch (Exception ex)
            {
                return Json(ex);
            }
        }

        [Route("List")]
        [HttpPost]
        public ActionResult Survey(Survey model)
        {

            int SurveyId = model.SurveyId;
            int Rate = model.Rate;

            return View(model);
        }
        //List<Survey> Survey = new List<Survey>();




        [HttpGet]
        public ActionResult Update(int id)
        {
            try
            {
                List<Survey> Survey = new List<Survey>();

                AnsweredSurvey answeredsurvey = _iFAnsweredSurvey.Read(id);
                return View(answeredsurvey);
            }
            catch (Exception ex)
            {
                return View(new AnsweredSurvey());
            }
        }

        [HttpPost]
        public ActionResult Update(AnsweredSurvey answeredsurvey)
        {
            try
            {
                answeredsurvey = _iFAnsweredSurvey.Update(answeredsurvey);
                return Json("");
            }
            catch (Exception ex)
            {
                return View(ex);
            }
        }

        [HttpPost]
        public ActionResult Delete(AnsweredSurvey answeredsurvey)
        {
            try
            {
                _iFAnsweredSurvey.Delete(answeredsurvey);
                return Json("");
            }
            catch (Exception ex)
            {
                return Json(ex);
            }
        }

        //public JsonResult Static()
        //{
        //    return Json(_iFAnsweredSurveyResult.List(0));
        //}

        public ActionResult StaticStructured()
        {
            return View();
        }

        public ActionResult DynamicStructured()
        {
            return View();
        }

        public JsonResult DynamicStructuredData()
        {

            return Json(_iFAnsweredSurveyResult.List(0));
        }
        public JsonResult Static()
        {

            return Json(_iFAnsweredSurveyResult.List(0));
        }


    }

}