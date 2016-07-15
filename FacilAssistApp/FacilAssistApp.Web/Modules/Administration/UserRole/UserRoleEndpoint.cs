using System.Data;
using System.Web.Mvc;
using Serenity.Data;
using Serenity.Services;

namespace FacilAssistApp.Modules.Administration.UserRole
{
    using MyRepository = UserRoleRepository;

    [RoutePrefix("Services/Administration/UserRole"), Route("{action}")]
    [ConnectionKey("Default"), ServiceAuthorize(Administration.PermissionKeys.Security)]
    public class UserRoleController : ServiceEndpoint
    {
        [HttpPost]
        public SaveResponse Update(IUnitOfWork uow, UserRoleUpdateRequest request)
        {
            return new MyRepository().Update(uow, request);
        }

        public UserRoleListResponse List(IDbConnection connection, UserRoleListRequest request)
        {
            return new MyRepository().List(connection, request);
        }
    }
}
