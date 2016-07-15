
using System;
using FacilAssistApp.Modules.Administration.User;
using Serenity.ComponentModel;

namespace FacilAssistApp.Modules.Membership.Account
{
    [FormScript("Membership.Login")]
    [BasedOnRow(typeof(UserRow))]
    public class LoginForm
    {
        [Placeholder("")]
        public String Username { get; set; }
        [PasswordEditor, Placeholder(""), Required(true)]
        public String Password { get; set; }
    }
}