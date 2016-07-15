
using System.Web.Mvc;
using MVC;
using Serenity.Web;

namespace FacilAssistApp.Modules.Administration.User
{
    [RoutePrefix("Administration/User"), Route("{action=index}")]
    public partial class UserController : Controller
    {
        [PageAuthorize(PermissionKeys.Security)]
        public ActionResult Index()
        {
            return View(Views.Administration.User.UserIndex);
        }
    }
}