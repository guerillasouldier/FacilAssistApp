﻿
using System.Data;
using System.Web.Mvc;
using Serenity.Data;
using Serenity.Services;

namespace FacilAssistApp.Modules.Administration.Language
{
    using MyRepository = LanguageRepository;
    using MyRow = LanguageRow;

    [Route("{action}")]
    [ConnectionKey("Default"), ServiceAuthorize(PermissionKeys.Translation)]
    public partial class LanguageController
    {
        [HttpPost]
        public SaveResponse Create(IUnitOfWork uow, SaveRequest<MyRow> request)
        {
            return new MyRepository().Create(uow, request);
        }

        [HttpPost]
        public SaveResponse Update(IUnitOfWork uow, SaveRequest<MyRow> request)
        {
            return new MyRepository().Update(uow, request);
        }

        [HttpPost]
        public DeleteResponse Delete(IUnitOfWork uow, DeleteRequest request)
        {
            return new MyRepository().Delete(uow, request);
        }

        public RetrieveResponse<MyRow> Retrieve(IDbConnection connection, RetrieveRequest request)
        {
            return new MyRepository().Retrieve(connection, request);
        }

        public ListResponse<MyRow> List(IDbConnection connection, ListRequest request)
        {
            return new MyRepository().List(connection, request);
        }
    }
}
