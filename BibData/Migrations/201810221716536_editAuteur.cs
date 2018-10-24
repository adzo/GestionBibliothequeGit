namespace BibData.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class editAuteur : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Auteurs", "CIN", c => c.Int(nullable: false));
            AddColumn("dbo.Auteurs", "Adresse", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Auteurs", "Adresse");
            DropColumn("dbo.Auteurs", "CIN");
        }
    }
}
