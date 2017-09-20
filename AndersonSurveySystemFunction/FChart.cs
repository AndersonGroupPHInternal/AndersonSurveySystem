//using AndersonSurveySystemModel;
//using AndersonSurveySystemData;
//using AndersonSurveySystemEntity;
//using System.Collections.Generic;
//using System.Linq;
//using System;

//namespace AndersonSurveySystemFunction
//{
//    public class FChart : IFAnsweredSurvey
//    {
//        private IDChart _iDChart;

//        public FChart()
//        {
//            _iDChart = new DChart();
//        }

//        #region CREATE
//        public Chart Create(Chart chart)
//        {
//            EChart eAnsweredSurvey = EAnsweredSurvey(answeredsurvey);
//            eAnsweredSurvey = _iDAnsweredSurvey.Create(eAnsweredSurvey);
//            return (AnsweredSurvey(eAnsweredSurvey));
//        }
//        #endregion

//        #region READ
//        public AnsweredSurvey Read(int answeredsurveyId)
//        {
//            EAnsweredSurvey eAnsweredSurvey = _iDAnsweredSurvey.Read<EAnsweredSurvey>(a => a.AnsweredSurveyId == answeredsurveyId);
//            return AnsweredSurvey(eAnsweredSurvey);
//        }

//        public List<AnsweredSurvey> List()
//        {
//            List<EAnsweredSurvey> eAnsweredSurveys = _iDAnsweredSurvey.List<EAnsweredSurvey>(a => true);
//            return AnsweredSurveys(eAnsweredSurveys);
//        }

//        #endregion

//        #region UPDATE
//        public AnsweredSurvey Update(AnsweredSurvey answeredsurvey)
//        {
//            var eAnsweredSurvey = _iDAnsweredSurvey.Update(EAnsweredSurvey(answeredsurvey));
//            return (AnsweredSurvey(eAnsweredSurvey));
//        }
//        #endregion

//        #region DELETE
//        public void Delete(AnsweredSurvey answeredsurvey)
//        {
//            _iDAnsweredSurvey.Delete(EAnsweredSurvey(answeredsurvey));
//        }
//        #endregion
//        #region OTHER FUNCTION
//        private List<AnsweredSurvey> AnsweredSurveys(List<EAnsweredSurvey> eAnsweredSurveys)
//        {
//            var returnAnsweredSurveys = eAnsweredSurveys.Select(a => new AnsweredSurvey
//            {
//                AnsweredSurveyId = a.AnsweredSurveyId,
//                Name = a.Name,
//                ticketnumber = a.ticketnumber,
//                description = a.description,

//            });

//            return returnAnsweredSurveys.ToList();
//        }

//        private EAnsweredSurvey EAnsweredSurvey(AnsweredSurvey answeredSurvey)
//        {
//            EAnsweredSurvey returnEAnsweredSurvey = new EAnsweredSurvey
//            {
//                AnsweredSurveyId = answeredSurvey.AnsweredSurveyId,
//                Name = answeredSurvey.Name,
//                ticketnumber = answeredSurvey.ticketnumber,
//                description = answeredSurvey.description,

//                AnsweredQuestions = answeredSurvey.AnsweredQuestions.Select(a => new EAnsweredQuestion
//                {
//                    Answer = a.Answer,
//                    QuestionId = a.QuestionId

//                }).ToList(),
//                //Questions = answeredSurvey.Questions.Select(a => new EQuestion
//                //{
//                //    QuestionId = a.QuestionId,
//                //    Rate = a.Rate


//                //}).ToList()



//                //comments = answeredSurvey.comments.Select(a => new EComment
//                //{
//                //    Comments = a.Comments
//                //}).ToList()
//            };
//            return returnEAnsweredSurvey;
//        }

//        private AnsweredSurvey AnsweredSurvey(EAnsweredSurvey eAnsweredSurvey)
//        {
//            AnsweredSurvey returnAnsweredSurvey = new AnsweredSurvey
//            {
//                AnsweredSurveyId = eAnsweredSurvey.AnsweredSurveyId,
//                Name = eAnsweredSurvey.Name,
//                ticketnumber = eAnsweredSurvey.ticketnumber,
//                description = eAnsweredSurvey.description,

//            };
//            return returnAnsweredSurvey;
//        }

//        public AnsweredSurvey CreateList(AnsweredSurvey answeredsurvey)
//        {
//            throw new NotImplementedException();
//        }
//        #endregion
//    }
//}
