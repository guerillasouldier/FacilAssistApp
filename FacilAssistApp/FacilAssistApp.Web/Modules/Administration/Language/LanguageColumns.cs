
using System;
using Serenity.ComponentModel;

namespace FacilAssistApp.Modules.Administration.Language
{
    [ColumnsScript("Administration.Language")]
    [BasedOnRow(typeof(LanguageRow))]
    public class LanguageColumns
    {
        [EditLink]
        public String LanguageId { get; set; }
        [EditLink]
        public String LanguageName { get; set; }
    }
}