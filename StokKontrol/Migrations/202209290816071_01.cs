namespace StokKontrol.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _01 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Musteris",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        AdSoyad = c.String(),
                        Telefon = c.String(),
                        Kimlik = c.String(),
                        Mail = c.String(),
                        Adres = c.String(),
                        Urunler_id = c.Int(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Urunlers", t => t.Urunler_id)
                .Index(t => t.Urunler_id);
            
            CreateTable(
                "dbo.Urunlers",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Kategori = c.String(),
                        Fiyat = c.Double(nullable: false),
                        Stok = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Musteris", "Urunler_id", "dbo.Urunlers");
            DropIndex("dbo.Musteris", new[] { "Urunler_id" });
            DropTable("dbo.Urunlers");
            DropTable("dbo.Musteris");
        }
    }
}
