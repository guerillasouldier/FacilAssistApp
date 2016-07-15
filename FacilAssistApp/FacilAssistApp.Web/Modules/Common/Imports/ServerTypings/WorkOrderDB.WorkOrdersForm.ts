

namespace FacilAssistApp.WorkOrderDB {
    export class WorkOrdersForm extends Serenity.PrefixedContext {
        static formKey = 'WorkOrderDB.WorkOrders';
    }

    export interface WorkOrdersForm {
        WoNum: Serenity.IntegerEditor;
        WoType: Serenity.StringEditor;
        Description: Serenity.StringEditor;
        DateAdded: Serenity.DateEditor;
        DateCompleted: Serenity.DateEditor;
        AssetId: Serenity.StringEditor;
        Priority: Serenity.IntegerEditor;
    }

    [['Pkey', () => Serenity.IntegerEditor], ['WoNum', () => Serenity.IntegerEditor], ['WoType', () => Serenity.StringEditor], ['Description', () => Serenity.StringEditor], ['DateAdded', () => Serenity.DateEditor], ['DateCompleted', () => Serenity.DateEditor], ['AssetId', () => Serenity.StringEditor], ['Priority', () => Serenity.IntegerEditor]].forEach(x => Object.defineProperty(WorkOrdersForm.prototype, <string>x[0], { get: function () { return this.w(x[0], (x[1] as any)()); }, enumerable: true, configurable: true }));
}