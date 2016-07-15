
using System.Web.Mvc;
using Serenity.Data;
using Serenity.Services;

namespace FacilAssistApp.Modules.Administration.Translation
{
    using MyRepository = TranslationRepository;

    [Route("{action}")]
    [ConnectionKey("Default"), ServiceAuthorize(Administration.PermissionKeys.Translation)]
    public partial class TranslationController
    {
        public ListResponse<TranslationItem> List(TranslationListRequest request)
        {
            return new MyRepository().List(request);
        }

        [HttpPost]
        public SaveResponse Update(TranslationUpdateRequest request)
        {
            return new MyRepository().Update(request);
        }
    }
}
