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
        public AnsweredSurvey Create(AnsweredSurvey answeredSurvey)
        {
            EAnsweredSurvey eAnsweredSurvey = EAnsweredSurvey(answeredSurvey);
            eAnsweredSurvey.CreatedDate = DateTime.Now;
            eAnsweredSurvey = _iDAnsweredSurvey.Create(eAnsweredSurvey);
            return (AnsweredSurvey(eAnsweredSurvey));
        }
        #endregion

        #region READ
        public AnsweredSurvey Read(int answeredSurveyId)
        {
            EAnsweredSurvey eAnsweredSurvey = _iDAnsweredSurvey.Read<EAnsweredSurvey>(a => a.AnsweredSurveyId == answeredSurveyId);
            return AnsweredSurvey(eAnsweredSurvey);
        }

        public List<AnsweredSurvey> List()
        {
            List<EAnsweredSurvey> eAnsweredSurveys = _iDAnsweredSurvey.List<EAnsweredSurvey>(a => true);
            return AnsweredSurveys(eAnsweredSurveys);
        }

        #endregion

        #region UPDATE
        #endregion

        #region DELETE
        public void Delete(AnsweredSurvey answeredSurvey)
        {
            _iDAnsweredSurvey.Delete(EAnsweredSurvey(answeredSurvey));
        }
        #endregion

        #region OTHER
        private AnsweredSurvey AnsweredSurvey(EAnsweredSurvey eAnsweredSurvey)
        {
            return new AnsweredSurvey
            {
                AnsweredSurveyId = eAnsweredSurvey.AnsweredSurveyId,
                SurveyId = eAnsweredSurvey.SurveyId,

                Description = eAnsweredSurvey.Description,
                FirstName = eAnsweredSurvey.FirstName,
                LastName = eAnsweredSurvey.LastName,
                MiddleName = eAnsweredSurvey.MiddleName,
                TicketNumber = eAnsweredSurvey.TicketNumber
            };
        }

        private EAnsweredSurvey EAnsweredSurvey(AnsweredSurvey answeredSurvey)
        {
            return new EAnsweredSurvey
            {
                AnsweredSurveyId = answeredSurvey.AnsweredSurveyId,
                SurveyId = answeredSurvey.SurveyId,

                Description = answeredSurvey.Description,
                FirstName = answeredSurvey.FirstName,
                LastName = answeredSurvey.LastName,
                MiddleName = answeredSurvey.MiddleName,
                TicketNumber = answeredSurvey.TicketNumber
            };
        }

        private List<AnsweredSurvey> AnsweredSurveys(List<EAnsweredSurvey> eAnsweredSurveys)
        {
            return eAnsweredSurveys.Select(a => new AnsweredSurvey
            {
                AnsweredSurveyId = a.AnsweredSurveyId,
                SurveyId = a.SurveyId,

                Description = a.Description,
                FirstName = a.FirstName,
                LastName = a.LastName,
                MiddleName = a.MiddleName,
                TicketNumber = a.TicketNumber
            }).ToList();
        }
        #endregion
    }
}
