using AndersonSurveySystemModel;
using AndersonSurveySystemData;
using AndersonSurveySystemEntity;
using System.Collections.Generic;
using System.Linq;
using System;

namespace AndersonSurveySystemFunction
{
    public class FAnsweredSurvey : IFAnsweredSurvey
    {
        private IDAnsweredSurvey _iDAnsweredSurvey;

        public FAnsweredSurvey()
        {
            _iDAnsweredSurvey = new DAnsweredSurvey();
        }

        #region CREATE
        public AnsweredSurvey Create(AnsweredSurvey answeredsurvey)
        {
            EAnsweredSurvey eAnsweredSurvey = EAnsweredSurvey(answeredsurvey);
            eAnsweredSurvey = _iDAnsweredSurvey.Create(eAnsweredSurvey);
            return (AnsweredSurvey(eAnsweredSurvey));
        }
        #endregion

        #region READ
        public AnsweredSurvey Read(int answeredsurveyId)
        {
            EAnsweredSurvey eAnsweredSurvey = _iDAnsweredSurvey.Read<EAnsweredSurvey>(a => a.AnsweredSurveyid == answeredsurveyId);
            return AnsweredSurvey(eAnsweredSurvey);
        }

        public List<AnsweredSurvey> List()
        {
            List<EAnsweredSurvey> eAnsweredSurveys = _iDAnsweredSurvey.List<EAnsweredSurvey>(a => true);
            return AnsweredSurveys(eAnsweredSurveys);
        }

        #endregion

        #region UPDATE
        public AnsweredSurvey Update(AnsweredSurvey answeredsurvey)
        {
            var eAnsweredSurvey = _iDAnsweredSurvey.Update(EAnsweredSurvey(answeredsurvey));
            return (AnsweredSurvey(eAnsweredSurvey));
        }
        #endregion

        #region DELETE
        public void Delete(AnsweredSurvey answeredsurvey)
        {
            _iDAnsweredSurvey.Delete(EAnsweredSurvey(answeredsurvey));
        }
        #endregion
        #region OTHER FUNCTION
        private List<AnsweredSurvey> AnsweredSurveys(List<EAnsweredSurvey> eAnsweredSurveys)
        {
            var returnAnsweredSurveys = eAnsweredSurveys.Select(a => new AnsweredSurvey
            {
                AnsweredSurveyId = a.AnsweredSurveyid,
                Name = a.Name,
                ticketnumber = a.ticketnumber,
                description = a.description
            });

            return returnAnsweredSurveys.ToList();
        }

        private EAnsweredSurvey EAnsweredSurvey(AnsweredSurvey answeredSurvey)
        {
            EAnsweredSurvey returnEAnsweredSurvey = new EAnsweredSurvey
            {
                AnsweredSurveyid = answeredSurvey.AnsweredSurveyId,
                Name = answeredSurvey.Name,
                ticketnumber = answeredSurvey.ticketnumber,
                description = answeredSurvey.description,
                AnsweredQuestions = answeredSurvey.AnsweredQuestions.Select(a => new EAnsweredQuestion
                {
                    Answer = a.Answer,
                    QuestionId = a.QuestionId


                }).ToList(),

                Questions = answeredSurvey.Questions.Select(a => new EQuestion
                {
                    QuestionId = a.QuestionId


                }).ToList()
            };
            return returnEAnsweredSurvey;
        }

        private AnsweredSurvey AnsweredSurvey(EAnsweredSurvey eAnsweredSurvey)
        {
            AnsweredSurvey returnAnsweredSurvey = new AnsweredSurvey
            {
                AnsweredSurveyId = eAnsweredSurvey.AnsweredSurveyid,
                Name = eAnsweredSurvey.Name,
                ticketnumber = eAnsweredSurvey.ticketnumber,
                description = eAnsweredSurvey.description
            };
            return returnAnsweredSurvey;
        }

        public AnsweredSurvey CreateList(AnsweredSurvey answeredsurvey)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
