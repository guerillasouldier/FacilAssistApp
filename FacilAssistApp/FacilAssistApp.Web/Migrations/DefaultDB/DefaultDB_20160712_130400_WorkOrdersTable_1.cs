using FluentMigrator;

namespace FacilAssistApp.Migrations.DefaultDB
{
    [Migration(20160712130400)]
    public class DefaultDB_201607012_130400_WorkOrdersTable_1 : Migration
    {
        public override void Up()
        {
            Delete.FromTable("WorkOrders").InSchema("workschema").AllRows();
            Delete.Column("wo_num").FromTable("WorkOrders").InSchema("workschema");

            Alter.Table("WorkOrders").InSchema("workschema")
                .AddColumn("wo_num").AsInt32().NotNullable();

            Create.Index("IX_WOID")
                .OnTable("WorkOrders").InSchema("workschema")
                .OnColumn("wo_num").Ascending()
                .WithOptions()
                .Unique();
        }
        public override void Down()
        {}
    }
}