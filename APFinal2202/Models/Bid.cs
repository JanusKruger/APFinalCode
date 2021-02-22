using System;

namespace APFinal2202.Models
{
    public class Bid
    {
        public Bid()
        {
            Id = Guid.NewGuid().ToString();
        }

        public string Id { get; set; }

        public double Amount { get; set; }

        public DateTime TimeOf { get; set; }

        public bool IsConcluded { get; set; }

        public string PropertyId { get; set; }

        public string BuyerId { get; set; }
    }
}