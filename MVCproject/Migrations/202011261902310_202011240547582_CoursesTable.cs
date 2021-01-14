namespace MVCproject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _202011240547582_CoursesTable : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Students", "Age", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Students", "Age", c => c.String(nullable: false));
        }
    }
}
