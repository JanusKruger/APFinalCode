using System.Data.Entity.Migrations;

namespace APFinal2202.Migrations
{

    public partial class AddedAditionalColumnToSomeTables : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Multimedias", "Type", c => c.String());
            AddColumn("dbo.PropertyFeatures", "AirConditioning", c => c.Boolean(nullable: false));
            AddColumn("dbo.PropertyFeatures", "Balcony", c => c.Boolean(nullable: false));
            AddColumn("dbo.PropertyFeatures", "BuiltInBraai", c => c.Boolean(nullable: false));
            AddColumn("dbo.PropertyFeatures", "PetFriendly", c => c.Boolean(nullable: false));
            DropColumn("dbo.Multimedias", "PhotoType");
        }

        public override void Down()
        {
            AddColumn("dbo.Multimedias", "PhotoType", c => c.String());
            DropColumn("dbo.PropertyFeatures", "PetFriendly");
            DropColumn("dbo.PropertyFeatures", "BuiltInBraai");
            DropColumn("dbo.PropertyFeatures", "Balcony");
            DropColumn("dbo.PropertyFeatures", "AirConditioning");
            DropColumn("dbo.Multimedias", "Type");
        }
    }
}
