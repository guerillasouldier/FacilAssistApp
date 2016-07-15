
using System;
using System.ComponentModel;
using Serenity.ComponentModel;

namespace FacilAssistApp.Modules.Administration.Role
{
    [ColumnsScript("Administration.Role")]
    [BasedOnRow(typeof(RoleRow))]
    public class RoleColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
        public Int32 RoleId { get; set; }
        [EditLink, Width(300)]
        public String RoleName { get; set; }
    }
}