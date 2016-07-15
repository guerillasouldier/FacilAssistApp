using System.Collections.Generic;
using Serenity.Services;

namespace FacilAssistApp.Modules.Administration.Translation
{

    public class TranslationUpdateRequest : ServiceRequest
    {
        public string TargetLanguageID { get; set; }
        public Dictionary<string, string> Translations { get; set; }
    }
}