
using System.Data;
using System.Web.Mvc;
using Serenity.Data;
using Serenity.Services;

namespace FacilAssistApp.Modules.Administration.RolePermission
{
    using MyRepository = RolePermissionRepository;

    [RoutePrefix("Services/Administration/RolePermission"), Route("{action}")]
    [ConnectionKey("Default"), ServiceAuthorize(Administration.PermissionKeys.Security)]
    public class RolePermissionController : ServiceEndpoint
    {
        [HttpPost]
        public SaveResponse Update(IUnitOfWork uow, RolePermissionUpdateRequest request)
        {
            return new MyRepository().Update(uow, request);
        }

        public RolePermissionListResponse List(IDbConnection connection, RolePermissionListRequest request)
        {
            return new MyRepository().List(connection, request);
        }
    }
}
