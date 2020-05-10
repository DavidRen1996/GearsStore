namespace GearsStore.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class t2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Games", "GameName", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Games", "GameName", c => c.String(nullable: false));
        }
    }
}
