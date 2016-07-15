
using System.Data;
using System.Web.Mvc;
using Serenity.Data;
using Serenity.Services;

namespace FacilAssistApp.Modules.Common.UserPreference
{
    using MyRepository = UserPreferenceRepository;

    [RoutePrefix("Services/Common/UserPreference"), Route("{action}")]
    [ConnectionKey("Default"), ServiceAuthorize]
    public class UserPreferenceController : ServiceEndpoint
    {
        [HttpPost]
        public ServiceResponse Update(IUnitOfWork uow, UserPreferenceUpdateRequest request)
        {
            return new MyRepository().Update(uow, request);
        }

        public UserPreferenceRetrieveResponse Retrieve(IDbConnection connection, UserPreferenceRetrieveRequest request)
        {
            return new MyRepository().Retrieve(connection, request);
        }
    }
}