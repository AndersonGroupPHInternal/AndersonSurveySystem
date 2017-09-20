using AndersonSurveySystemData;
using AndersonSurveySystemEntity;
using AndersonSurveySystemModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AndersonSurveySystemFunction
{
    public class FRate : IFRate
    {
        private IDRate _iDRate;

        public FRate()
        {
            _iDRate = new DRate();
        }

        #region CREATE
        public Rate Create(Rate rate)
        {
            ERate eRate = ERate(rate);
            eRate = _iDRate.Create(eRate);
            return (Rate(eRate));
        }
        #endregion

        #region READ
        public Rate Read(int RateId)
        {
            ERate eRate = _iDRate.Read<ERate>(a => a.RateId == RateId);
            return Rate(eRate);
        }

        public List<Rate> List()
        {
            List<ERate> eRates = _iDRate.List<ERate>(a => true);
            return Rates(eRates);
        }

        #endregion

        #region UPDATE
        public Rate Update(Rate rate)
        {
            var eRate = _iDRate.Update(ERate(rate));
            return (Rate(eRate));
        }
        #endregion

        #region DELETE
        public void Delete(Rate rate)
        {
            _iDRate.Delete(ERate(rate));
        }
        #endregion
        #region OTHER FUNCTION
        private List<Rate> Rates(List<ERate> eRates)
        {
            var returnRates = eRates.Select(a => new Rate
            {
                RateId = a.RateId,
                Rates = a.Rates,


            });

            return returnRates.ToList();
        }

        private ERate ERate(Rate rate)
        {
            ERate returnERate = new ERate
            {
                RateId = rate.RateId,
                Rates = rate.Rates,

               
            };


            return returnERate;
        }





        private Rate Rate(ERate eRate)
        {
            Rate returnRate = new Rate
            {
                RateId = eRate.RateId,
                Rates = eRate.Rates,


            };
            return returnRate;
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