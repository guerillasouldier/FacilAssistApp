using Serenity;
using Serenity.Abstractions;

namespace FacilAssistApp.Modules.Administration.User.Authentication
{
    public class AuthorizationService : IAuthorizationService
    {
        public bool IsLoggedIn
        {
            get { return !string.IsNullOrEmpty(Username); }
        }

        public string Username
        {
            get { return WebSecurityHelper.HttpContextUsername; }
        }
    }
}