

[assembly:Serenity.Navigation.NavigationLink(int.MaxValue, "WorkOrderDB/WorkOrders", typeof(FacilAssistApp.WorkOrderDB.Pages.WorkOrdersController))]

namespace FacilAssistApp.WorkOrderDB.Pages
{
    using Serenity;
    using Serenity.Web;
    using System.Web.Mvc;

    [RoutePrefix("WorkOrderDB/WorkOrders"), Route("{action=index}")]
    public class WorkOrdersController : Controller
    {
        [PageAuthorize("Administration")]
        public ActionResult Index()
        {
            return View("~/Modules/WorkOrderDB/WorkOrders/WorkOrdersIndex.cshtml");
        }
    }
}