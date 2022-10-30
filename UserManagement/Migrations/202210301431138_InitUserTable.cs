namespace UserManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitUserTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.users",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        firstname = c.String(nullable: false, maxLength: 26),
                        lastname = c.String(nullable: false, maxLength: 26),
                        email = c.String(nullable: false),
                        phone = c.String(),
                        Gender = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.users");
        }
    }
}
