namespace MVCproject.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class StudentTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        CourseId = c.Int(nullable: false),
                        CourseEnrolledDate = c.DateTime(nullable: false),
                        CourseStatus = c.Int(nullable: false),
                        Grade = c.String(),
                        Age = c.Int(nullable: false)
                })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Students");
        }
    }
}
