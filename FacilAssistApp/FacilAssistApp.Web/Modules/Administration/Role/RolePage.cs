using System.Web.Mvc;
using MVC;
using Serenity.Web;

namespace FacilAssistApp.Modules.Administration.Role
{
    [RoutePrefix("Administration/Role"), Route("{action=index}")]
    public partial class RoleController : Controller
    {
        [PageAuthorize(PermissionKeys.Security)]
        public ActionResult Index()
        {
            return View(Views.Administration.Role.RoleIndex);
        }
    }
}