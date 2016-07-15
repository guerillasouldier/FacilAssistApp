using Serenity.Services;

namespace FacilAssistApp.Modules.Administration.UserPermission
{
    public class UserPermissionListRequest : ServiceRequest
    {
        public int? UserID { get; set; }
        public string Module { get; set; }
        public string Submodule { get; set; }
    }
}