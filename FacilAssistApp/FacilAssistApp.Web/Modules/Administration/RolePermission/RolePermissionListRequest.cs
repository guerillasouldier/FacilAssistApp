using Serenity.Services;

namespace FacilAssistApp.Modules.Administration.RolePermission
{
    public class RolePermissionListRequest : ServiceRequest
    {
        public int? RoleID { get; set; }
        public string Module { get; set; }
        public string Submodule { get; set; }
    }
}