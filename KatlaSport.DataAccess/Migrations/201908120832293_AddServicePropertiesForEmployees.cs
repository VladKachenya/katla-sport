namespace KatlaSport.DataAccess.Migrations
{
    using System.Data.Entity.Migrations;

    /// <summary>
    /// Add follow properties for employee_records tables: deleted, created_by_id, created_utc, updated_by_id, updated_utc.
    /// </summary>
    public partial class AddServicePropertiesForEmployees : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.employee_records", "deleted", c => c.Boolean(nullable: false));
            AddColumn("dbo.employee_records", "created_by_id", c => c.Int(nullable: false));
            AddColumn("dbo.employee_records", "created_utc", c => c.DateTime(nullable: false));
            AddColumn("dbo.employee_records", "updated_by_id", c => c.Int(nullable: false));
            AddColumn("dbo.employee_records", "updated_utc", c => c.DateTime(nullable: false));
        }

        public override void Down()
        {
            DropColumn("dbo.employee_records", "updated_utc");
            DropColumn("dbo.employee_records", "updated_by_id");
            DropColumn("dbo.employee_records", "created_utc");
            DropColumn("dbo.employee_records", "created_by_id");
            DropColumn("dbo.employee_records", "deleted");
        }
    }
}
