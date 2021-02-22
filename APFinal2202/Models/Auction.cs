using System;

namespace APFinal2202.Models
{
    public class Auction
    {
        public Auction()
        {
            Id = Guid.NewGuid().ToString();
        }

        public string Id { get; set; }

        public double OpeningBid { get; set; }

        public DateTime AuctionStart { get; set; }

        public DateTime AuctionEnd { get; set; }

        public string AuctionType { get; set; }

        public string PropertyId { get; set; }

        public string BidIds { get; set; }
    }
}