//using AndersonSurveySystemFunction;
//using System.Linq;
//using System.Security.Principal;
//using System.Web;

//namespace AndersonSurveySystemWebAuthentication
//{
//    public static class WindowsUser
//    {
//        private static IFAdmin _iFAdmin;

//        public static bool HasUserRoles(string[] userRoles)
//        {
//            _iFAdmin = new FAdmin();
//            return _iFAdmin.IsMethodAccessible(UserName, userRoles.ToList()); ;
//        }

//        public static int AdminId
//        {
//            get
//            {
//                _iFAdmin = new FAdmin();
//                var user = _iFAdmin.ReadUser(UserName);
//                int UserID = user?.AdminId ?? 0;
//                return UserID;
//            }
//        }

//        public static string UserName
//        {
//            get
//            {
//                WindowsIdentity clientId = (WindowsIdentity)HttpContext.Current.User.Identity;
//                return clientId.Name;
//            }
//        }

//    }
//}