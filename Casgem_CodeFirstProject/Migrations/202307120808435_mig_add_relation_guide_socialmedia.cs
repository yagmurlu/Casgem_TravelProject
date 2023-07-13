namespace Casgem_CodeFirstProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_add_relation_guide_socialmedia : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.SocialMedias", "GuidId", c => c.Int(nullable: false));
            AddColumn("dbo.SocialMedias", "Guide_GuideId", c => c.Int());
            CreateIndex("dbo.SocialMedias", "Guide_GuideId");
            AddForeignKey("dbo.SocialMedias", "Guide_GuideId", "dbo.Guides", "GuideId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.SocialMedias", "Guide_GuideId", "dbo.Guides");
            DropIndex("dbo.SocialMedias", new[] { "Guide_GuideId" });
            DropColumn("dbo.SocialMedias", "Guide_GuideId");
            DropColumn("dbo.SocialMedias", "GuidId");
        }
    }
}
