using System.Data.Entity.Migrations;

namespace APFinal2202.Migrations
{
    public partial class AddModels : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Addresses",
                c => new
                {
                    Id = c.String(nullable: false, maxLength: 128),
                    AddressLine1 = c.String(),
                    AddressLine2 = c.String(),
                    Town = c.String(),
                    Province = c.String(),
                    PostalCode = c.String(),
                    Country = c.String(),
                })
                .PrimaryKey(t => t.Id);

            CreateTable(
                "dbo.Agencies",
                c => new
                {
                    Id = c.String(nullable: false, maxLength: 128),
                    Name = c.String(),
                    Logo = c.Binary(),
                    PhoneNumber = c.String(),
                    SellerId = c.String(),
                })
                .PrimaryKey(t => t.Id);

            CreateTable(
                "dbo.Auctions",
                c => new
                {
                    Id = c.String(nullable: false, maxLength: 128),
                    OpeningBid = c.Double(nullable: false),
                    AuctionStart = c.DateTime(nullable: false),
                    AuctionEnd = c.DateTime(nullable: false),
                    AuctionType = c.String(),
                    PropertyId = c.String(),
                    BidIds = c.String(),
                })
                .PrimaryKey(t => t.Id);

            CreateTable(
                "dbo.Bids",
                c => new
                {
                    Id = c.String(nullable: false, maxLength: 128),
                    Amount = c.Double(nullable: false),
                    TimeOf = c.DateTime(nullable: false),
                    IsConcluded = c.Boolean(nullable: false),
                    PropertyId = c.String(),
                    BuyerId = c.String(),
                })
                .PrimaryKey(t => t.Id);

            CreateTable(
                "dbo.Buyers",
                c => new
                {
                    Id = c.String(nullable: false, maxLength: 128),
                    Signature = c.Boolean(nullable: false),
                    ApprovalStatus = c.Boolean(nullable: false),
                    BuyerType = c.String(),
                    NationalIdentificationNumber = c.String(),
                    ReceiveNewsletter = c.Boolean(nullable: false),
                    TermsAndConditions = c.Boolean(nullable: false),
                    UserId = c.String(),
                    AddressId = c.String(),
                    MultimediaId = c.String(),
                })
                .PrimaryKey(t => t.Id);

            CreateTable(
                "dbo.Multimedias",
                c => new
                {
                    Id = c.String(nullable: false, maxLength: 128),
                    FileName = c.String(),
                    PhotoType = c.String(),
                    Content = c.Binary(),
                })
                .PrimaryKey(t => t.Id);

            CreateTable(
                "dbo.Properties",
                c => new
                {
                    Id = c.String(nullable: false, maxLength: 128),
                    Title = c.String(),
                    Description = c.String(),
                    PropertyType = c.String(),
                    OwnershipType = c.String(),
                    PropertyStatus = c.String(),
                    AddressId = c.String(),
                    SellerId = c.String(),
                    MultimediaIds = c.String(),
                })
                .PrimaryKey(t => t.Id);

            CreateTable(
                "dbo.PropertyDetails",
                c => new
                {
                    Id = c.String(nullable: false, maxLength: 128),
                    Bedrooms = c.String(),
                    Bathrooms = c.String(),
                    FloorSize = c.Double(nullable: false),
                    ErfSize = c.Double(nullable: false),
                    MonthlyLevies = c.Double(nullable: false),
                    RatesAndTaxes = c.Double(nullable: false),
                    SpecialLevies = c.Double(nullable: false),
                    PropertyId = c.String(),
                })
                .PrimaryKey(t => t.Id);

            CreateTable(
                "dbo.PropertyFeatures",
                c => new
                {
                    Id = c.String(nullable: false, maxLength: 128),
                    Borehole = c.Boolean(nullable: false),
                    BuiltInCupboards = c.Boolean(nullable: false),
                    Carpets = c.Boolean(nullable: false),
                    Carport = c.Boolean(nullable: false),
                    DomesticBathroom = c.Boolean(nullable: false),
                    DoubleGarage = c.Boolean(nullable: false),
                    Clubhouse = c.Boolean(nullable: false),
                    FiberInternet = c.Boolean(nullable: false),
                    Garage = c.Boolean(nullable: false),
                    Garden = c.Boolean(nullable: false),
                    SolarPower = c.Boolean(nullable: false),
                    SwimmingPool = c.Boolean(nullable: false),
                    TiledFloors = c.Boolean(nullable: false),
                    VisitorParking = c.Boolean(nullable: false),
                    PropertyId = c.String(),
                })
                .PrimaryKey(t => t.Id);

            CreateTable(
                "dbo.AspNetRoles",
                c => new
                {
                    Id = c.String(nullable: false, maxLength: 128),
                    Name = c.String(nullable: false, maxLength: 256),
                })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Name, unique: true, name: "RoleNameIndex");

            CreateTable(
                "dbo.AspNetUserRoles",
                c => new
                {
                    UserId = c.String(nullable: false, maxLength: 128),
                    RoleId = c.String(nullable: false, maxLength: 128),
                })
                .PrimaryKey(t => new { t.UserId, t.RoleId })
                .ForeignKey("dbo.AspNetRoles", t => t.RoleId, cascadeDelete: true)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId)
                .Index(t => t.RoleId);

            CreateTable(
                "dbo.Sellers",
                c => new
                {
                    Id = c.String(nullable: false, maxLength: 128),
                    Signature = c.Boolean(nullable: false),
                    ApprovalStatus = c.Boolean(nullable: false),
                    SellerType = c.String(),
                    NationalIdentificationNumber = c.String(),
                    ReceiveNewsletter = c.Boolean(nullable: false),
                    TermsAndConditions = c.Boolean(nullable: false),
                    UserId = c.String(),
                    AddressId = c.String(),
                    MultimediaId = c.String(),
                })
                .PrimaryKey(t => t.Id);

            CreateTable(
                "dbo.AspNetUsers",
                c => new
                {
                    Id = c.String(nullable: false, maxLength: 128),
                    FirstName = c.String(),
                    LastName = c.String(),
                    Role = c.String(),
                    Email = c.String(maxLength: 256),
                    EmailConfirmed = c.Boolean(nullable: false),
                    PasswordHash = c.String(),
                    SecurityStamp = c.String(),
                    PhoneNumber = c.String(),
                    PhoneNumberConfirmed = c.Boolean(nullable: false),
                    TwoFactorEnabled = c.Boolean(nullable: false),
                    LockoutEndDateUtc = c.DateTime(),
                    LockoutEnabled = c.Boolean(nullable: false),
                    AccessFailedCount = c.Int(nullable: false),
                    UserName = c.String(nullable: false, maxLength: 256),
                })
                .PrimaryKey(t => t.Id)
                .Index(t => t.UserName, unique: true, name: "UserNameIndex");

            CreateTable(
                "dbo.AspNetUserClaims",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    UserId = c.String(nullable: false, maxLength: 128),
                    ClaimType = c.String(),
                    ClaimValue = c.String(),
                })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);

            CreateTable(
                "dbo.AspNetUserLogins",
                c => new
                {
                    LoginProvider = c.String(nullable: false, maxLength: 128),
                    ProviderKey = c.String(nullable: false, maxLength: 128),
                    UserId = c.String(nullable: false, maxLength: 128),
                })
                .PrimaryKey(t => new { t.LoginProvider, t.ProviderKey, t.UserId })
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);

        }

        public override void Down()
        {
            DropForeignKey("dbo.AspNetUserRoles", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserLogins", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserClaims", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserRoles", "RoleId", "dbo.AspNetRoles");
            DropIndex("dbo.AspNetUserLogins", new[] { "UserId" });
            DropIndex("dbo.AspNetUserClaims", new[] { "UserId" });
            DropIndex("dbo.AspNetUsers", "UserNameIndex");
            DropIndex("dbo.AspNetUserRoles", new[] { "RoleId" });
            DropIndex("dbo.AspNetUserRoles", new[] { "UserId" });
            DropIndex("dbo.AspNetRoles", "RoleNameIndex");
            DropTable("dbo.AspNetUserLogins");
            DropTable("dbo.AspNetUserClaims");
            DropTable("dbo.AspNetUsers");
            DropTable("dbo.Sellers");
            DropTable("dbo.AspNetUserRoles");
            DropTable("dbo.AspNetRoles");
            DropTable("dbo.PropertyFeatures");
            DropTable("dbo.PropertyDetails");
            DropTable("dbo.Properties");
            DropTable("dbo.Multimedias");
            DropTable("dbo.Buyers");
            DropTable("dbo.Bids");
            DropTable("dbo.Auctions");
            DropTable("dbo.Agencies");
            DropTable("dbo.Addresses");
        }
    }
}
