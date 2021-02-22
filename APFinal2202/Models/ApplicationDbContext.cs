using Microsoft.AspNet.Identity.EntityFramework;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Validation;

namespace APFinal2202.Models
{
    public sealed class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: true)
        {
        }

        public DbSet<Address> Addresses { get; set; }

        public DbSet<Agency> Agencies { get; set; }

        public DbSet<Auction> Auctions { get; set; }

        public DbSet<Bid> Bids { get; set; }

        public DbSet<Multimedia> MultiMedias { get; set; }

        public DbSet<Property> Properties { get; set; }

        public DbSet<PropertyDetail> PropertyDetails { get; set; }

        public DbSet<PropertyFeature> PropertyFeatures { get; set; }

        public DbSet<Seller> Sellers { get; set; }

        public DbSet<Buyer> Buyers { get; set; }

        protected override DbEntityValidationResult ValidateEntity(DbEntityEntry entityEntry, IDictionary<object, object> items)
        {
            if (!(entityEntry.Entity is Address) ||
                entityEntry.Entity is Agency ||
                entityEntry.Entity is Auction ||
                entityEntry.Entity is Bid ||
                entityEntry.Entity is Buyer ||
                entityEntry.Entity is Multimedia ||
                entityEntry.Entity is Property ||
                entityEntry.Entity is PropertyDetail ||
                entityEntry.Entity is PropertyFeature ||
                entityEntry.Entity is Seller)
            {
                return base.ValidateEntity(entityEntry, items);
            }

            if (entityEntry.CurrentValues.GetValue<string>("Id") != "")
            {
                return base.ValidateEntity(entityEntry, items);
            }

            var errors = new List<DbValidationError>
            {
                new DbValidationError("Id", "Id is required")
            };
            return new DbEntityValidationResult(entityEntry, errors);
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
    }
}