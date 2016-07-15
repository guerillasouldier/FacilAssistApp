
using System;
using Serenity.ComponentModel;

namespace FacilAssistApp.Modules.Administration.Language
{
    [FormScript("Administration.Language")]
    [BasedOnRow(typeof(LanguageRow))]
    public class LanguageForm
    {
        public String LanguageId { get; set; }
        public String LanguageName { get; set; }
    }
}