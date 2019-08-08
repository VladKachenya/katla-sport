namespace KatlaSport.DataAccess.Migrations
{
    using System.Data.Entity.Migrations;

    /// <summary>
    /// Add employee_records, employee_work_places and employee_position tables.
    /// </summary>
    public partial class AddEmployeeCatalogue : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.employee_records",
                c => new
                {
                    employee_id = c.Int(nullable: false, identity: true),
                    employee_first_name = c.String(nullable: false, maxLength: 60),
                    employee_last_name = c.String(nullable: false, maxLength: 60),
                    employee_email = c.String(nullable: false, maxLength: 60),
                    employee_photo_url = c.String(),
                    employee_place_id = c.Int(),
                    employee_position_id = c.Int(nullable: false),
                    employee_boss_id = c.Int(),
                })
                .PrimaryKey(t => t.employee_id)
                .ForeignKey("dbo.employee_records", t => t.employee_boss_id)
                .ForeignKey("dbo.employee_work_places", t => t.employee_place_id)
                .ForeignKey("dbo.employee_position", t => t.employee_position_id, cascadeDelete: true)
                .Index(t => t.employee_place_id)
                .Index(t => t.employee_position_id)
                .Index(t => t.employee_boss_id);

            CreateTable(
                "dbo.employee_work_places",
                c => new
                {
                    place_id = c.Int(nullable: false, identity: true),
                    place_country = c.String(nullable: false, maxLength: 60),
                    place_city = c.String(nullable: false, maxLength: 60),
                    place_street = c.String(nullable: false, maxLength: 60),
                    place_house = c.String(nullable: false, maxLength: 60),
                })
                .PrimaryKey(t => t.place_id);

            CreateTable(
                "dbo.employee_position",
                c => new
                {
                    position_id = c.Int(nullable: false, identity: true),
                    position_name = c.String(nullable: false, maxLength: 100),
                    position_description = c.String(),
                })
                .PrimaryKey(t => t.position_id);
        }

        public override void Down()
        {
            DropForeignKey("dbo.employee_records", "employee_position_id", "dbo.employee_position");
            DropForeignKey("dbo.employee_records", "employee_place_id", "dbo.employee_work_places");
            DropForeignKey("dbo.employee_records", "employee_boss_id", "dbo.employee_records");
            DropIndex("dbo.employee_records", new[] { "employee_boss_id" });
            DropIndex("dbo.employee_records", new[] { "employee_position_id" });
            DropIndex("dbo.employee_records", new[] { "employee_place_id" });
            DropTable("dbo.employee_position");
            DropTable("dbo.employee_work_places");
            DropTable("dbo.employee_records");
        }
    }
}
