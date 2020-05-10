namespace GearsStore.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RequiredGame1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Games", "GameName", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Games", "GameName", c => c.String());
        }
    }
}
