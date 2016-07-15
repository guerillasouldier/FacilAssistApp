
using System;
using Serenity.Services;

namespace FacilAssistApp.Modules.Membership.Account.ChangePassword
{
    public class ChangePasswordRequest : ServiceRequest
    {
        public String OldPassword { get; set; }
        public String NewPassword { get; set; }
        public String ConfirmPassword { get; set; }
    }
}