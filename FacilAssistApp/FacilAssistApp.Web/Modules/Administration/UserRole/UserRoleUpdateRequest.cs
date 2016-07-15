
using System;
using System.Collections.Generic;
using Serenity.Services;

namespace FacilAssistApp.Modules.Administration.UserRole
{
    public class UserRoleUpdateRequest : ServiceRequest
    {
        public Int32? UserID { get; set; }
        public List<Int32> Roles { get; set; }
    }
}