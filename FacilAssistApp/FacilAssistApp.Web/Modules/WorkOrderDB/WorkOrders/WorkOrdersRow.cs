

namespace FacilAssistApp.WorkOrderDB.Entities
{
    using Newtonsoft.Json;
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using Serenity.Data.Mapping;
    using System;
    using System.ComponentModel;
    using System.IO;

    [ConnectionKey("Default"), DisplayName("Work Order"), InstanceName("WorkOrders"), TwoLevelCached]
    [ReadPermission("Administration")]
    [ModifyPermission("Administration")]
    public sealed class WorkOrdersRow : Row, IIdRow, INameRow
    {
        [DisplayName("Pkey"), Column("pkey"), Identity]
        public Int32? Pkey
        {
            get { return Fields.Pkey[this]; }
            set { Fields.Pkey[this] = value; }
        }

        [DisplayName("Work Order #"), Column("wo_num"), NotNull]
        public Int32? WoNum
        {
            get { return Fields.WoNum[this]; }
            set { Fields.WoNum[this] = value; }
        }

        [DisplayName("Work Type"), Column("wo_type"), Size(100), NotNull, QuickSearch]
        public String WoType
        {
            get { return Fields.WoType[this]; }
            set { Fields.WoType[this] = value; }
        }

        [DisplayName("Description"), Column("description"), Size(400)]
        public String Description
        {
            get { return Fields.Description[this]; }
            set { Fields.Description[this] = value; }
        }

        [DisplayName("Date Added"), Column("date_added"), NotNull]
        public DateTime? DateAdded
        {
            get { return Fields.DateAdded[this]; }
            set { Fields.DateAdded[this] = value; }
        }

        [DisplayName("Date Completed"), Column("date_completed")]
        public DateTime? DateCompleted
        {
            get { return Fields.DateCompleted[this]; }
            set { Fields.DateCompleted[this] = value; }
        }

        [DisplayName("Asset ID"), Column("asset_id"), Size(6), NotNull]
        public String AssetId
        {
            get { return Fields.AssetId[this]; }
            set { Fields.AssetId[this] = value; }
        }

        [DisplayName("Priority"), Column("priority"), NotNull]
        public Int32? Priority
        {
            get { return Fields.Priority[this]; }
            set { Fields.Priority[this] = value; }
        }

        IIdField IIdRow.IdField
        {
            get { return Fields.Pkey; }
        }

        StringField INameRow.NameField
        {
            get { return Fields.WoType; }
        }

        public static readonly RowFields Fields = new RowFields().Init();

        public WorkOrdersRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int32Field Pkey;
            public Int32Field WoNum;
            public StringField WoType;
            public StringField Description;
            public DateTimeField DateAdded;
            public DateTimeField DateCompleted;
            public StringField AssetId;
            public Int32Field Priority;

            public RowFields()
                : base("[workschema].[WorkOrders]")
            {
                LocalTextPrefix = "WorkOrderDB.WorkOrders";
            }
        }
    }
}