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
    public class FAdmin : IFAdmin
    {
        private IDAdmin _iDAdmin;

        public FAdmin()
        {
            _iDAdmin = new DAdmin();
        }

        #region CREATE
        public Admin Create(Admin admin)
        {
            EAdmin eAdmin = EAdmin(admin);
            eAdmin = _iDAdmin.Create(eAdmin);
            return (Admin(eAdmin));
        }
        #endregion

        #region READ
        public Admin Read(int AdminId)
        {
            EAdmin eAdmin = _iDAdmin.Read<EAdmin>(a => a.AdminId == AdminId);
            return Admin(eAdmin);
        }

        public List<Admin> List()
        {
            List<EAdmin> eAdmins = _iDAdmin.List<EAdmin>(a => true);
            return Admins(eAdmins);
        }

        #endregion

        #region UPDATE
        public Admin Update(Admin admin)
        {
            var eAdmin = _iDAdmin.Update(EAdmin(admin));
            return (Admin(eAdmin));
        }
        #endregion

        #region DELETE
        public void Delete(Admin admin)
        {
            _iDAdmin.Delete(EAdmin(admin));
        }
        #endregion
        #region OTHER FUNCTION
        private List<Admin> Admins(List<EAdmin> eAdmins)
        {
            var returnAdmins = eAdmins.Select(a => new Admin
            {
                AdminId = a.AdminId,
                FirstName= a.FirstName,
                LastName = a.LastName,
                UserName = a.UserName,
                Password = a.Password,

            });

            return returnAdmins.ToList();
        }

        private EAdmin EAdmin(Admin admin)
        {
            EAdmin returnEAdmin = new EAdmin
            {
                AdminId = admin.AdminId,
                FirstName = admin.FirstName,
                LastName = admin.LastName,
                UserName = admin.UserName,
                Password = admin.Password,

            };
            return returnEAdmin;
        }

        private Admin Admin(EAdmin eAdmin)
        {
            Admin returnAdmin = new Admin
            {
                AdminId = eAdmin.AdminId,
                FirstName = eAdmin.FirstName,
                LastName = eAdmin.LastName,
                UserName = eAdmin.UserName,
                Password = eAdmin.Password,

            };
            return returnAdmin;
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