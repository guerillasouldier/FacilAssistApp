
namespace FacilAssistApp.WorkOrderDB {
    
    @Serenity.Decorators.registerClass()
    @Serenity.Decorators.responsive()
    export class WorkOrdersDialog extends Serenity.EntityDialog<WorkOrdersRow, any> {
        protected getFormKey() { return WorkOrdersForm.formKey; }
        protected getIdProperty() { return WorkOrdersRow.idProperty; }
        protected getLocalTextPrefix() { return WorkOrdersRow.localTextPrefix; }
        protected getNameProperty() { return WorkOrdersRow.nameProperty; }
        protected getService() { return WorkOrdersService.baseUrl; }

        protected form = new WorkOrdersForm(this.idPrefix);
    }
}