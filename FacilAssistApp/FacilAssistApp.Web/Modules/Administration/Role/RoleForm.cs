
using System;
using Serenity.ComponentModel;

namespace FacilAssistApp.Modules.Administration.Role
{
    [FormScript("Administration.Role")]
    [BasedOnRow(typeof(RoleRow))]
    public class RoleForm
    {
        public String RoleName { get; set; }
    }
}