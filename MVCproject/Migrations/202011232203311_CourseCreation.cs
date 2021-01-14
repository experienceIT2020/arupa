namespace MVCproject.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class CourseCreation : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Courses",
                c => new
                    {
                        CourseId = c.Int(nullable: false, identity: true),
                        CourseName = c.String(),
                        CourseDescription = c.String(),
                        TutorName = c.String(),
                        CourseRating = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.CourseId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Courses");
        }
    }
}
