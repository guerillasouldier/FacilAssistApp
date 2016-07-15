using Serenity.ComponentModel;

namespace FacilAssistApp.Modules.Common.Imports.ClientTypes
{
    public partial class ShipperFormatterAttribute : CustomFormatterAttribute
    {
        public const string Key = "FacilAssistApp.Northwind.ShipperFormatter";

        public ShipperFormatterAttribute()
            : base(Key)
        {
        }
    }
}

