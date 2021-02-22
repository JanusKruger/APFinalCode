using System;
using System.ComponentModel.DataAnnotations;

namespace APFinal2202.Models
{
    public class Address
    {
        public Address()
        {
            Id = Guid.NewGuid().ToString();
        }

        [Key]
        public string Id { get; set; }

        public string AddressLine1 { get; set; }

        public string AddressLine2 { get; set; }

        public string Town { get; set; }

        public string Province { get; set; }

        public string PostalCode { get; set; }

        public string Country { get; set; }
    }
}