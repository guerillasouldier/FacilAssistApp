
namespace FacilAssistApp.WorkOrderDB {
    
    @Serenity.Decorators.registerClass()
    export class WorkOrdersGrid extends Serenity.EntityGrid<WorkOrdersRow, any> {
        protected getColumnsKey() { return 'WorkOrderDB.WorkOrders'; }
        protected getDialogType() { return WorkOrdersDialog; }
        protected getIdProperty() { return WorkOrdersRow.idProperty; }
        protected getLocalTextPrefix() { return WorkOrdersRow.localTextPrefix; }
        protected getService() { return WorkOrdersService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}