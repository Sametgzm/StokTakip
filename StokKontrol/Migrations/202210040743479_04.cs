namespace StokKontrol.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _04 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Musteris", "Urunler_id", c => c.Int());
            CreateIndex("dbo.Musteris", "Urunler_id");
            AddForeignKey("dbo.Musteris", "Urunler_id", "dbo.Urunlers", "id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Musteris", "Urunler_id", "dbo.Urunlers");
            DropIndex("dbo.Musteris", new[] { "Urunler_id" });
            DropColumn("dbo.Musteris", "Urunler_id");
        }
    }
}
