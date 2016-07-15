
using System;
using Serenity.Services;

namespace FacilAssistApp.Modules.Membership.Account.ForgotPassword
{
    public class ForgotPasswordRequest : ServiceRequest
    {
        public String Email { get; set; }
    }
}