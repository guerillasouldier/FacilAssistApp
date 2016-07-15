using System.Data;
using Serenity.Data;
using Serenity.Services;

namespace FacilAssistApp.Modules.Administration.Language
{
    using MyRow = LanguageRow;

    public class LanguageRepository
    {
        private static MyRow.RowFields fld { get { return MyRow.Fields; } }

        public SaveResponse Create(IUnitOfWork uow, SaveRequest<MyRow> request)
        {
            return new MySaveHandler().Process(uow, request, SaveRequestType.Create);
        }

        public SaveResponse Update(IUnitOfWork uow, SaveRequest<MyRow> request)
        {
            return new MySaveHandler().Process(uow, request, SaveRequestType.Update);
        }

        public DeleteResponse Delete(IUnitOfWork uow, DeleteRequest request)
        {
            return new MyDeleteHandler().Process(uow, request);
        }

        public RetrieveResponse<MyRow> Retrieve(IDbConnection connection, RetrieveRequest request)
        {
            return new MyRetrieveHandler().Process(connection, request);
        }

        public ListResponse<MyRow> List(IDbConnection connection, ListRequest request)
        {
            return new MyListHandler().Process(connection, request);
        }

        private class MySaveHandler : SaveRequestHandler<LanguageRow> { }
        private class MyDeleteHandler : DeleteRequestHandler<LanguageRow> { }
        private class MyRetrieveHandler : RetrieveRequestHandler<LanguageRow> { }
        private class MyListHandler : ListRequestHandler<LanguageRow> { }
    }
}