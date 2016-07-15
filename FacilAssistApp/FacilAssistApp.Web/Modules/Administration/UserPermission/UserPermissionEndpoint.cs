using System.Data;
using System.Web.Mvc;
using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Services;

namespace FacilAssistApp.Modules.Administration.UserPermission
{
    using MyRepository = UserPermissionRepository;
    using MyRow = UserPermissionRow;

    [RoutePrefix("Services/Administration/UserPermission"), Route("{action}")]
    [ConnectionKey("Default"), ServiceAuthorize(Administration.PermissionKeys.Security)]
    public class UserPermissionController : ServiceEndpoint
    {
        [HttpPost]
        public SaveResponse Update(IUnitOfWork uow, UserPermissionUpdateRequest request)
        {
            return new MyRepository().Update(uow, request);
        }

        public ListResponse<MyRow> List(IDbConnection connection, UserPermissionListRequest request)
        {
            return new MyRepository().List(connection, request);
        }

        public ListResponse<string> ListRolePermissions(IDbConnection connection, UserPermissionListRequest request)
        {
            return new MyRepository().ListRolePermissions(connection, request);
        }

        [DataScript("Administration.PermissionKeys")]
        public ListResponse<string> ListPermissionKeys()
        {
            return new MyRepository().ListPermissionKeys();
        }
    }
}
