using System;

namespace APFinal2202.Models
{
    public class Agency
    {
        public Agency()
        {
            Id = Guid.NewGuid().ToString();
        }

        public string Id { get; set; }

        public string Name { get; set; }

        public byte[] Logo { get; set; }

        public string PhoneNumber { get; set; }

        public string SellerId { get; set; }
    }
}