
using System;
using System.Web.Mvc;
using FacilAssistApp.WorkOrderDB.Entities;
using MVC;
using Serenity;
using Serenity.Data;

namespace FacilAssistApp.Modules.Common.Dashboard
{
    [RoutePrefix("Dashboard"), Route("{action=index}")]
    public class DashboardController : Controller
    {
        [Authorize, HttpGet, Route("~/")]
        public ActionResult Index()
        {
            var cachedModel = TwoLevelCache.GetLocalStoreOnly("DashboardPageModel", TimeSpan.FromMinutes(5),
                WorkOrdersRow.Fields.GenerationKey, () =>
                {
                    var model = new DashboardPageModel();
                    var o = WorkOrdersRow.Fields;
                    using (var connection = SqlConnections.NewFor<WorkOrdersRow>())
                    {
                        model.OpenOrders = connection.Count<WorkOrdersRow>(o.DateCompleted.IsNull());
                        var closedOrders = connection.Count<WorkOrdersRow>(o.DateAdded.IsNotNull());
                        var totalOrders = model.OpenOrders + closedOrders;
                        model.ClosedOrderPercent = (int)Math.Round(totalOrders == 0 ? 100 :
                            closedOrders / (double)totalOrders * 100);
                        model.CustomerCount = connection.Count<WorkOrdersRow>();
                    }
                    return model;
                });

            return View(Views.Common.Dashboard.DashboardIndex, cachedModel);
        }
    }
}