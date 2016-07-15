using Serenity.Services;

namespace FacilAssistApp.Modules.Administration.Translation
{
    public class TranslationListRequest : ListRequest
    {
        public string SourceLanguageID { get; set; }
        public string TargetLanguageID { get; set; }
    }
}