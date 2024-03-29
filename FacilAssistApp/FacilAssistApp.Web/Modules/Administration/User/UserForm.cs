﻿using System;
using Serenity.ComponentModel;

namespace FacilAssistApp.Modules.Administration.User
{
    [FormScript("Administration.User")]
    [BasedOnRow(typeof(UserRow))]
    public class UserForm
    {
        public String Username { get; set; }
        public String DisplayName { get; set; }
        [EmailEditor]
        public String Email { get; set; }
        [PasswordEditor, Required(true)]
        public String Password { get; set; }
        [PasswordEditor, OneWay, Required(true)]
        public String PasswordConfirm { get; set; }
        [OneWay]
        public string Source { get; set; }
    }
}