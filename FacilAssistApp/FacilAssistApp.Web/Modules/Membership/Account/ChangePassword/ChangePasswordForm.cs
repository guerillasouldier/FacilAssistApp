
using System;
using System.ComponentModel;
using Serenity.ComponentModel;

namespace FacilAssistApp.Modules.Membership.Account.ChangePassword
{
    [FormScript("Membership.ChangePassword")]
    public class ChangePasswordForm
    {
        [PasswordEditor, Required(true), DisplayName("Current Password")]
        public String OldPassword { get; set; }
        [PasswordEditor, Required(true), DisplayName("New Password")]
        public String NewPassword { get; set; }
        [PasswordEditor, Required(true), DisplayName("Confirm Password")]
        public String ConfirmPassword { get; set; }
    }
}