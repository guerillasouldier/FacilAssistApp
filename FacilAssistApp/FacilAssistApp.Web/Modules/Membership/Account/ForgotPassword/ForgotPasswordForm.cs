
using System;
using System.ComponentModel;
using Serenity.ComponentModel;

namespace FacilAssistApp.Modules.Membership.Account.ForgotPassword
{
    [FormScript("Membership.ForgotPassword")]
    public class ForgotPasswordForm
    {
        [Required(true), EmailEditor, DisplayName("E-mail Address")]
        public String Email { get; set; }
    }
}