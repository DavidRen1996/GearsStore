namespace GearsStore.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddGameSnapshotLink : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Games", "GameSnapshotLink", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Games", "GameSnapshotLink");
        }
    }
}
