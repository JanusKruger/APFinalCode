using System;

namespace APFinal2202.Models
{
    public class Property
    {
        public Property()
        {
            Id = Guid.NewGuid().ToString();
        }

        public string Id { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public string PropertyType { get; set; }

        public string OwnershipType { get; set; }

        public string PropertyStatus { get; set; }

        public string AddressId { get; set; }

        public string SellerId { get; set; }

        public string MultimediaIds { get; set; }
    }
}