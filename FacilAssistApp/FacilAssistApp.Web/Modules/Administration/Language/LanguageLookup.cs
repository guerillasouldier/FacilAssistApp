
using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Web;

namespace FacilAssistApp.Modules.Administration.Language
{
    [LookupScript("Administration.Language")]
    public sealed class LanguageLookup : RowLookupScript<LanguageRow>
    {
        public LanguageLookup()
        {
            IdField = LanguageRow.Fields.LanguageId.PropertyName;
            Permission = "*";
        }

        protected override void PrepareQuery(SqlQuery query)
        {
            base.PrepareQuery(query);

            query.Select(LanguageRow.Fields.LanguageId);
        }
    }
}