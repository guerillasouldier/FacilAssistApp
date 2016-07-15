
using System.Web.Mvc;
using MVC;
using Serenity.Services;
using Serenity.Web;

namespace FacilAssistApp.Modules.Administration.Language
{
    [RoutePrefix("Administration/Language"), Route("{action=index}")]
    public partial class LanguageController : ServiceEndpoint
    {
        [PageAuthorize(PermissionKeys.Translation)]
        public ActionResult Index()
        {
            return View(Views.Administration.Language.LanguageIndex);
        }
    }
}