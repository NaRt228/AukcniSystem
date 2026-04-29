using AukcniSystem.Data;

namespace AukcniSystem.Entities
{
    public class Bid
    {
        public int Id { get; set; }
        public int AuctionId { get; set; }
        public Auction Auction { get; set; } = null!;
        public string BidderId { get; set; } = string.Empty;
        public ApplicationUser Bidder { get; set; } = null!;
        public decimal NewPrice { get; set; }
        public decimal BidAmount { get; set; }
        public DateTime BidTime { get; set; } = DateTime.Now;
    }
}
