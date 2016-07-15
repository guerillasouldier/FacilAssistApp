using Serenity.ComponentModel;

namespace FacilAssistApp.Modules.Common.Imports.ClientTypes
{
    public partial class FilteredLookupDetailEditorAttribute : CustomEditorAttribute
    {
        public const string Key = "FacilAssistApp.BasicSamples.FilteredLookupDetailEditor";

        public FilteredLookupDetailEditorAttribute()
            : base(Key)
        {
        }
    }
}

