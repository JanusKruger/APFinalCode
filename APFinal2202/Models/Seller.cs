using System;
using System.ComponentModel.DataAnnotations;

namespace APFinal2202.Models
{
    public class Seller
    {
        public Seller()
        {
            Id = Guid.NewGuid().ToString();
        }

        [Key]
        public string Id { get; set; }

        public bool Signature { get; set; }

        public bool ApprovalStatus { get; set; }

        public string SellerType { get; set; }

        public string UserId { get; set; }

        public string AddressId { get; set; }

        public string MultimediaId { get; set; }
    }
}