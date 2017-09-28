using AndersonSurveySystemData;
using AndersonSurveySystemEntity;
using AndersonSurveySystemModel;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AndersonSurveySystemFunction
{
    public class FEmail : IFEmail
    {
        private IDEmail _iDEmail;

        public FEmail()
        {
            _iDEmail = new DEmail();
        }

        #region CREATE
        public Email Create(Email email)
        {
            EEmail eEmail = EEmail(email);
            eEmail = _iDEmail.Create(eEmail);
            return (Email(eEmail));
        }
        #endregion

        #region READ
        public Email Read(int UserId)
        {
            EEmail eEmail = _iDEmail.Read<EEmail>(a => a.UserId == UserId);
            return Email(eEmail);
        }

        public List<Email> List()
        {
            List<EEmail> eEmails = _iDEmail.List<EEmail>(a => true);
            return Emails(eEmails);
        }

        #endregion

        #region UPDATE
        public Email Update(Email email)
        {
            var eEmail = _iDEmail.Update(EEmail(email));
            return (Email(eEmail));
        }
        #endregion

        #region DELETE
        public void Delete(Email email)
        {
            _iDEmail.Delete(EEmail(email));
        }
        #endregion
        #region OTHER FUNCTION
        private List<Email> Emails(List<EEmail> eEmails)
        {
            var returnEmails = eEmails.Select(a => new Email
            {
                UserId = a.UserId,
                UserName = a.UserName,
                EmailAd = a.EmailAd,
                //TicketNumber = a.TicketNumber,
                //Description = a.Description,
            });

            return returnEmails.ToList();
        }

        private EEmail EEmail(Email email)
        {
            EEmail returnEEmail = new EEmail
            {
                UserId = email.UserId,
                UserName = email.UserName,
                EmailAd = email.EmailAd,
                //TicketNumber = email.TicketNumber,
                //Description = email.Description,
            };
            return returnEEmail;
        }

        private Email Email(EEmail eEmail)
        {
            Email returnEmail = new Email
            {
                UserId = eEmail.UserId,
                UserName = eEmail.UserName,
                EmailAd = eEmail.EmailAd,
                //TicketNumber = eEmail.TicketNumber,
                //Description = eEmail.Description,
            };
            return returnEmail;
        }

        public bool IsMethodAccessible(string username, List<string> list)
        {
            throw new NotImplementedException();
        }

        public object ReadUser(string username)
        {
            throw new NotImplementedException();
        }
        #endregion

    }
}