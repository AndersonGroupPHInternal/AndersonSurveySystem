//using AndersonSurveySystemFunction;
//using System;
//using System.Linq;
//using System.Web;
//using System.Web.Mvc;

//namespace AndersonSurveySystemWebAuthentication
//{
//    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, AllowMultiple = false, Inherited = true)]
//    public class CustomAuthorizeAttribute
//    {
//        private IFAdmin _iFAdmin;

//        public CustomAuthorizeAttribute()
//        {
//            _iFAdmin = new FAdmin();
//        }

//        public string[] AllowedRoles { get; set; }
//        protected override bool AuthorizeCore(HttpContextBase httpContext)
//        {
//            string currentUserlogged = WindowsUser.UserName;
//            try
//            {
//                return _iFAdmin.IsMethodAccessible(currentUserlogged, AllowedRoles.ToList());
//            }
//            catch (Exception ex)
//            {
//                return false;
//            }
//        }
//    }
//}
