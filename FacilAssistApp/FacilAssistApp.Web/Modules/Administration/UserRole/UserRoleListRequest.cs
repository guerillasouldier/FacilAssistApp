using Serenity.Services;

namespace FacilAssistApp.Modules.Administration.UserRole
{
    public class UserRoleListRequest : ServiceRequest
    {
        public int? UserID { get; set; }
    }
}