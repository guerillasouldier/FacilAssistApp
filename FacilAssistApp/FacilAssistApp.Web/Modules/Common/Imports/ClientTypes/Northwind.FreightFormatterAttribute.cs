using Serenity.ComponentModel;

namespace FacilAssistApp.Modules.Common.Imports.ClientTypes
{
    public partial class FreightFormatterAttribute : CustomFormatterAttribute
    {
        public const string Key = "FacilAssistApp.Northwind.FreightFormatter";

        public FreightFormatterAttribute()
            : base(Key)
        {
        }
    }
}

