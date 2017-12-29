using ExternalAccountWebAuthentication.Authentication;
using ExternalAccountWebAuthentication.Controller;

namespace AndersonSurveySystem.Controllers
{
    [MvcAuthorizationFilterAttribute(false, "Credential", "Login", new string[] { "SurveyAdministrator" })]
    public class BaseController : ExternalAccountBaseController
    {
    }
}