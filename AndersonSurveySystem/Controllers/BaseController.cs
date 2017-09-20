//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Web;
//using System.Web.Mvc;
//using AccountsWebAuthentication.Helper;
//using AndersonSurveySystemContext;

//namespace AndersonSurveySystem.Controllers
//{
//    public class BaseController : Controller
//    {
//        //DbManager dbManager = new DbManager();

//        protected string UserName
//        {
//            get
//            {
//                return WindowsUser.Username; //GET Username and UserID
//            }
//        }


//        protected int UserID
//        {
//            get
//            {
//                int AdminID = 0;
//                using (var ctx = new Context())
//                {
//                    AdminID = ctx.Admin.Where(u => u.UserName == UserName).Select(u => u.AdminId).FirstOrDefault();
//                }
//                return UserID;
//            }
//        }

//    }
//}