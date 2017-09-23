using AndersonSurveySystemFunction;
using AndersonSurveySystemModel;
using System;
using System.Collections.Generic;
using System.Web.Mvc;


namespace AndersonSurveySystem.Controllers
{
    [RoutePrefix("AnsweredSurvey")]
    public class AnsweredSurveyController : Controller
    {
      
        private IFAnsweredSurvey _iFAnsweredSurvey;

        public AnsweredSurveyController()
        {
           
            _iFAnsweredSurvey = new FAnsweredSurvey();
        }


        [Route("")]
        [HttpGet]
        public ActionResult Index(string ticketnumber, string description, string Name)
        {

            var answeredsurveyss = new AnsweredSurvey { ticketnumber = "" + ticketnumber,
                                                      description = " " + description, Name = "" + Name };
        
            return View(answeredsurveyss);

           
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

                
                _iFAnsweredSurvey.Create(answeredSurvey);
                return RedirectToAction("Index", "AnsweredQuestion", new { Name = answeredSurvey.Name });
                
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

            

            return View(model);
        }
       
    

        
        
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
        }
    
}