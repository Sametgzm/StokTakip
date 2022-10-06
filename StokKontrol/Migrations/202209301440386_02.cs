namespace StokKontrol.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _02 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Musteris", "Adet", c => c.Int(nullable: false));
            AddColumn("dbo.Musteris", "Tutar", c => c.Single(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Musteris", "Tutar");
            DropColumn("dbo.Musteris", "Adet");
        }
    }
}
