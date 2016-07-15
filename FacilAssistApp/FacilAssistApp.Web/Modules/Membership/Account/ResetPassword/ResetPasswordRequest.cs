
using System;
using Serenity.Services;

namespace FacilAssistApp.Modules.Membership.Account.ResetPassword
{
    public class ResetPasswordRequest : ServiceRequest
    {
        public String Token { get; set; }
        public String NewPassword { get; set; }
        public String ConfirmPassword { get; set; }
    }
}