using Serenity.ComponentModel;

namespace FacilAssistApp.Modules.Common.Imports.ClientTypes
{
    public partial class CustomerEditorAttribute : LookupEditorBaseAttribute
    {
        public const string Key = "FacilAssistApp.Northwind.CustomerEditor";

        public CustomerEditorAttribute()
            : base(Key)
        {
        }
    }
}

