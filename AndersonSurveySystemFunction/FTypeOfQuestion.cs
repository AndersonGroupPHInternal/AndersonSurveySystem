using AndersonSurveySystemModel;
using AndersonSurveySystemData;
using AndersonSurveySystemEntity;
using System.Collections.Generic;
using System.Linq;

namespace AndersonSurveySystemFunction
{
    public class FTypeOfQuestion : IFTypeOfQuestion
    {
        private IDTypeOfQuestion _iDTypeOfQuestion;

        public FTypeOfQuestion()
        {
            _iDTypeOfQuestion = new DTypeOfQuestion();
        }

        #region CREATE
        public TypeOfQuestion Create(TypeOfQuestion typeofquestion)
        {
            ETypeOfQuestion eTypeOfQuestion = ETypeOfQuestion(typeofquestion);
            eTypeOfQuestion = _iDTypeOfQuestion.Create(eTypeOfQuestion);
            return (TypeOfQuestion(eTypeOfQuestion));
        }
        #endregion

        #region READ
        public TypeOfQuestion Read(int typeofquestionId)
        {
            ETypeOfQuestion eTypeOfQuestion = _iDTypeOfQuestion.Read<ETypeOfQuestion>(a => a.TypeOfQuestionId == typeofquestionId);
            return TypeOfQuestion(eTypeOfQuestion);
        }

        public List<TypeOfQuestion> List()
        {
            List<ETypeOfQuestion> eTypeOfQuestions = _iDTypeOfQuestion.List<ETypeOfQuestion>(a => true);
            return TypeOfQuestions(eTypeOfQuestions);
        }


        #endregion

        #region UPDATE
        public TypeOfQuestion Update(TypeOfQuestion typeofquestion)
        {
            var eTypeOfQuestion = _iDTypeOfQuestion.Update(ETypeOfQuestion(typeofquestion));
            return (TypeOfQuestion(eTypeOfQuestion));
        }
        #endregion

        #region DELETE
        public void Delete(TypeOfQuestion typeofquestion)
        {
            _iDTypeOfQuestion.Delete(ETypeOfQuestion(typeofquestion));
        }
        #endregion
        #region OTHER FUNCTION
        private List<TypeOfQuestion> TypeOfQuestions(List<ETypeOfQuestion> eTypeOfQuestions)
        {
            var returnTypeOfQuestions = eTypeOfQuestions.Select(a => new TypeOfQuestion
            {
                TypeOfQuestionId = a.TypeOfQuestionId,
                TypeOfQuestionName = a.TypeOfQuestionName
            });

            return returnTypeOfQuestions.ToList();
        }

        private ETypeOfQuestion ETypeOfQuestion(TypeOfQuestion typeofquestion)
        {
            ETypeOfQuestion returnETypeOfQuestion = new ETypeOfQuestion
            {
                TypeOfQuestionId = typeofquestion.TypeOfQuestionId,
                TypeOfQuestionName = typeofquestion.TypeOfQuestionName
               };
            return returnETypeOfQuestion;
        }

        private TypeOfQuestion TypeOfQuestion(ETypeOfQuestion eTypeOfQuestion)
        {
            TypeOfQuestion returnTypeOfQuestion = new TypeOfQuestion
            {
               TypeOfQuestionId = eTypeOfQuestion.TypeOfQuestionId,
               TypeOfQuestionName = eTypeOfQuestion.TypeOfQuestionName
            };
            return returnTypeOfQuestion;
        }
        #endregion
    }
}
