
using System;
using System.ComponentModel;
using Serenity.ComponentModel;

namespace FacilAssistApp.Modules.Membership.Account.ResetPassword
{
    [FormScript("Membership.ResetPassword")]
    public class ResetPasswordForm
    {
        [PasswordEditor, Required(true), DisplayName("New Password")]
        public String NewPassword { get; set; }
        [PasswordEditor, Required(true), DisplayName("Confirm Password")]
        public String ConfirmPassword { get; set; }
    }
}