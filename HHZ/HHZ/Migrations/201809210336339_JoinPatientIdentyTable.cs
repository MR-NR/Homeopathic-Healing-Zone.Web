namespace HHZ.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class JoinPatientIdentyTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Patients", "UserId", c => c.String(maxLength: 128));
            CreateIndex("dbo.Patients", "UserId");
            AddForeignKey("dbo.Patients", "UserId", "dbo.AspNetUsers", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Patients", "UserId", "dbo.AspNetUsers");
            DropIndex("dbo.Patients", new[] { "UserId" });
            DropColumn("dbo.Patients", "UserId");
        }
    }
}
