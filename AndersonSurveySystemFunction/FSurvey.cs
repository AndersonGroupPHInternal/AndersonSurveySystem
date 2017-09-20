using AndersonSurveySystemModel;
using AndersonSurveySystemData;
using AndersonSurveySystemEntity;
using System.Collections.Generic;
using System.Linq;

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
        public Survey Create(Survey survey)
        {
            ESurvey eSurvey = ESurvey(survey);
            eSurvey = _iDSurvey.Create(eSurvey);
            return (Survey(eSurvey));
        }
        #endregion

        #region READ
        public Survey Read(int surveyId)
        {
            ESurvey eSurvey = _iDSurvey.Read<ESurvey>(a => a.SurveyId == surveyId);
            return Survey(eSurvey);
        }

        public List<Survey> List()
        {
            List<ESurvey> eSurveys = _iDSurvey.List<ESurvey>(a => true);
            return Surveys(eSurveys);
        }

        #endregion

        #region UPDATE
        public Survey Update(Survey survey)
        {
            var eSurvey = _iDSurvey.Update(ESurvey(survey));
            return (Survey(eSurvey));
        }
        #endregion

        #region DELETE
        public void Delete(Survey survey)
        {
            _iDSurvey.Delete(ESurvey(survey));
        }
        #endregion
        #region OTHER FUNCTION
        private List<Survey> Surveys(List<ESurvey> eSurveys)
        {
            var returnSurveys = eSurveys.Select(a => new Survey
            {
                SurveyId = a.SurveyId,
                SurveyName = a.SurveyName,
                //Comments =a.Comments,
                //Rate = a.Rate
            });

            return returnSurveys.ToList();
        }

        private ESurvey ESurvey(Survey survey)
        {
            ESurvey returnESurvey = new ESurvey
            {
                SurveyId = survey.SurveyId,
                SurveyName = survey.SurveyName,
                //Comments=survey.Comments,
                //Rate = survey.Rate
            };
            return returnESurvey;
        }

        private Survey Survey(ESurvey eSurvey)
        {
            Survey returnSurvey = new Survey
            {
                SurveyId = eSurvey.SurveyId,
                SurveyName = eSurvey.SurveyName,
                //Comments=eSurvey.Comments,
                //Rate = eSurvey.Rate
            };
            return returnSurvey;
        }
        #endregion
    }
}
