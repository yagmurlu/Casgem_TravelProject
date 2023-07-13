namespace Casgem_CodeFirstProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_add_relation_guide_socialmedia2 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.SocialMedias", "Guide_GuideId", "dbo.Guides");
            DropIndex("dbo.SocialMedias", new[] { "Guide_GuideId" });
            RenameColumn(table: "dbo.SocialMedias", name: "Guide_GuideId", newName: "GuideId");
            AlterColumn("dbo.SocialMedias", "GuideId", c => c.Int(nullable: false));
            CreateIndex("dbo.SocialMedias", "GuideId");
            AddForeignKey("dbo.SocialMedias", "GuideId", "dbo.Guides", "GuideId", cascadeDelete: true);
            DropColumn("dbo.SocialMedias", "GuidId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.SocialMedias", "GuidId", c => c.Int(nullable: false));
            DropForeignKey("dbo.SocialMedias", "GuideId", "dbo.Guides");
            DropIndex("dbo.SocialMedias", new[] { "GuideId" });
            AlterColumn("dbo.SocialMedias", "GuideId", c => c.Int());
            RenameColumn(table: "dbo.SocialMedias", name: "GuideId", newName: "Guide_GuideId");
            CreateIndex("dbo.SocialMedias", "Guide_GuideId");
            AddForeignKey("dbo.SocialMedias", "Guide_GuideId", "dbo.Guides", "GuideId");
        }
    }
}
