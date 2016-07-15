
using System.Web.Mvc;
using MVC;
using Serenity.Web;

namespace FacilAssistApp.Modules.Administration.Translation
{
    [RoutePrefix("Administration/Translation"), Route("{action=index}")]
    public partial class TranslationController : Controller
    {
        [PageAuthorize(PermissionKeys.Translation)]
        public ActionResult Index()
        {
            return View(Views.Administration.Translation.TranslationIndex);
        }
    }
}