
namespace FacilAssistApp.WorkOrderDB {
    export interface WorkOrdersRow {
        Pkey?: number;
        WoNum?: number;
        WoType?: string;
        Description?: string;
        DateAdded?: string;
        DateCompleted?: string;
        AssetId?: string;
        Priority?: number;
    }

    export namespace WorkOrdersRow {
        export const idProperty = 'Pkey';
        export const nameProperty = 'WoType';
        export const localTextPrefix = 'WorkOrderDB.WorkOrders';

        export namespace Fields {
            export declare const Pkey;
            export declare const WoNum;
            export declare const WoType;
            export declare const Description;
            export declare const DateAdded;
            export declare const DateCompleted;
            export declare const AssetId;
            export declare const Priority;
        }

        ['Pkey', 'WoNum', 'WoType', 'Description', 'DateAdded', 'DateCompleted', 'AssetId', 'Priority'].forEach(x => (<any>Fields)[x] = x);
    }
}

