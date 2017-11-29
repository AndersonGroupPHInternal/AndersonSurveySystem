using AndersonSurveySystemModel;
using AndersonSurveySystemData;
using AndersonSurveySystemEntity;
using System.Collections.Generic;
using System.Linq;
using System;

namespace AndersonSurveySystemFunction

{
    public class FSurvey : IFSurvey
    {
        private IDSurvey _iDSurvey;
        

        public FSurvey()
        {
            _iDSurvey = new DSurvey();
        }

        #region CREATE
        public Survey Create(int createdBy ,Survey survey)
        {
            ESurvey eSurvey = ESurvey(survey);
            eSurvey.CreatedDate = DateTime.Now;
            eSurvey.CreatedBy = createdBy;
            eSurvey = _iDSurvey.Create(eSurvey);
            return (Survey(eSurvey));
        }
        #endregion

        #region READ
        public Survey Read(int surveyId)
        {
            ESurvey eSurvey = _iDSurvey.Read(surveyId);
            return Survey(eSurvey);
        }

        public List<Survey> List()
        {
            List<ESurvey> eSurveys = _iDSurvey.List<ESurvey>(a => true);
            return Surveys(eSurveys);
        }

        #endregion

        #region UPDATE
        public Survey Update(int updatedBy, Survey survey)
        {
            var eSurvey = _iDSurvey.Update(ESurvey(survey));
            eSurvey.UpdatedDate = DateTime.Now;
            eSurvey.UpdatedBy = updatedBy;
            return (Survey(eSurvey));
        }
        #endregion

        #region DELETE
        public void Delete(Survey survey)
        {
            _iDSurvey.Delete(ESurvey(survey));
        }
        #endregion

        #region OTHER
        private ESurvey ESurvey(Survey survey)
        {
            return new ESurvey
            {
                CreatedBy = survey.CreatedBy,
                SurveyId = survey.SurveyId,
                UpdatedBy = survey.UpdatedBy,

                SurveyName = survey.SurveyName
            };
        }
        private Survey Survey(ESurvey eSurvey)
        {

            return new Survey
            {

                CreatedBy = eSurvey.CreatedBy,
                SurveyId = eSurvey.SurveyId,
                UpdatedBy = eSurvey.UpdatedBy,

                SurveyName = eSurvey.SurveyName,

                Questions = eSurvey.Questions?.Select(b => new Question
                {
                    QuestionId = b.QuestionId,

                    Description = b.Description,
                }).ToList() ?? new List<Question>()
            };

        }

        private List<Survey> Surveys(List<ESurvey> eSurveys)
        {
            return eSurveys.Select(a => new Survey
            {
                CreatedBy = a.CreatedBy,
                SurveyId = a.SurveyId,
                UpdatedBy = a.UpdatedBy,

                SurveyName = a.SurveyName,

                Questions = a.Questions?.Select(b => new Question
                {
                    QuestionId = b.QuestionId,

                    Description = b.Description,
                }).ToList() ?? new List<Question>()
            }).ToList();
        }
        #endregion
    }
}
