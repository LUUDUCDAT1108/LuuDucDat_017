namespace LuuDucDat_017.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create_Table_SinhViens : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.LopHocs",
                c => new
                    {
                        MaLop = c.Int(nullable: false, identity: true),
                        TenLop = c.String(maxLength: 128, fixedLength: true, unicode: false),
                    })
                .PrimaryKey(t => t.MaLop);
            
            CreateTable(
                "dbo.SinhViens",
                c => new
                    {
                        MaLop = c.Int(nullable: false),
                        MaSinhVien = c.String(),
                        TenSinhVien = c.String(),
                    })
                .PrimaryKey(t => t.MaLop)
                .ForeignKey("dbo.LopHocs", t => t.MaLop)
                .Index(t => t.MaLop);
            
            DropTable("dbo.LopHocs");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.LopHocs",
                c => new
                    {
                        MaLop = c.Int(nullable: false, identity: true),
                        TenLop = c.String(maxLength: 128, fixedLength: true, unicode: false),
                    })
                .PrimaryKey(t => t.MaLop);
            
            DropForeignKey("dbo.SinhViens", "MaLop", "dbo.LopHocs");
            DropIndex("dbo.SinhViens", new[] { "MaLop" });
            DropTable("dbo.SinhViens");
            DropTable("dbo.LopHocs");
        }
    }
}
