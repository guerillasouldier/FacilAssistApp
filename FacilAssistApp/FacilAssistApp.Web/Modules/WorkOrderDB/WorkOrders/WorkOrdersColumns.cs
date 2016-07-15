
namespace FacilAssistApp.WorkOrderDB.Columns
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [ColumnsScript("WorkOrderDB.WorkOrders")]
    [BasedOnRow(typeof(Entities.WorkOrdersRow))]
    public class WorkOrdersColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
        public Int32 Pkey { get; set; }
        public Int32 WoNum { get; set; }
        [EditLink]
        public String WoType { get; set; }
        public String Description { get; set; }
        public DateTime DateAdded { get; set; }
        public DateTime DateCompleted { get; set; }
        public String AssetId { get; set; }
        public Int32 Priority { get; set; }
    }
}