
using Serenity.Services;

namespace FacilAssistApp.Modules.Membership.Account
{
    public class LoginRequest : ServiceRequest
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }
}