using System.Data.Entity.Migrations;

namespace APFinal2202.Migrations
{

    public partial class ChangeTheUserAndUserRegistrationStructure : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "NationalIdentificationNumber", c => c.String());
            AddColumn("dbo.AspNetUsers", "ReceiveNewsletter", c => c.Boolean(nullable: false));
            DropColumn("dbo.Buyers", "NationalIdentificationNumber");
            DropColumn("dbo.Buyers", "ReceiveNewsletter");
            DropColumn("dbo.Buyers", "TermsAndConditions");
            DropColumn("dbo.Sellers", "NationalIdentificationNumber");
            DropColumn("dbo.Sellers", "ReceiveNewsletter");
            DropColumn("dbo.Sellers", "TermsAndConditions");
        }

        public override void Down()
        {
            AddColumn("dbo.Sellers", "TermsAndConditions", c => c.Boolean(nullable: false));
            AddColumn("dbo.Sellers", "ReceiveNewsletter", c => c.Boolean(nullable: false));
            AddColumn("dbo.Sellers", "NationalIdentificationNumber", c => c.String());
            AddColumn("dbo.Buyers", "TermsAndConditions", c => c.Boolean(nullable: false));
            AddColumn("dbo.Buyers", "ReceiveNewsletter", c => c.Boolean(nullable: false));
            AddColumn("dbo.Buyers", "NationalIdentificationNumber", c => c.String());
            DropColumn("dbo.AspNetUsers", "ReceiveNewsletter");
            DropColumn("dbo.AspNetUsers", "NationalIdentificationNumber");
        }
    }
}
