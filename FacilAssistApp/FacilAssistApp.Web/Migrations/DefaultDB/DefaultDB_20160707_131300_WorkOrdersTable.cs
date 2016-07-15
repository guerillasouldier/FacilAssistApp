using FluentMigrator;

namespace FacilAssistApp.Migrations.DefaultDB
{
    [Migration(20160707131300)]
    public class DefaultDB_20160707_131300_WorkOrdersTable : Migration
    {
        public override void Up()
        {
            Create.Schema("workschema");

            Create.Table("WorkOrders").InSchema("workschema")
                .WithColumn("pkey").AsInt32().Identity().PrimaryKey().NotNullable()
                .WithColumn("wo_num").AsInt32().NotNullable()
                .WithColumn("wo_type").AsString(100).NotNullable()
                .WithColumn("description").AsString(400).Nullable()
                .WithColumn("date_added").AsDateTime().NotNullable()
                .WithColumn("date_completed").AsDateTime().Nullable()
                .WithColumn("asset_id").AsString(6).NotNullable()
                .WithColumn("priority").AsInt32().NotNullable();

        }
        public override void Down()
        {}
    }
}