using ExternalAccountWebAuthentication.Authentication;
using ExternalAccountWebAuthentication.Controller;

namespace AndersonSurveySystem.Controllers
{
    [MvcAuthorizationFilterAttribute(false, "Credential", "Login", new string[] { "ExternalAccountAdministrator" })]
    public class BaseController : ExternalAccountBaseController
    {
    }
}