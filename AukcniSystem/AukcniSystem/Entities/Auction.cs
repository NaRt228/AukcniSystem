using AukcniSystem.Data;
using System.Security.Cryptography;

namespace AukcniSystem.Entities
{
    public class Auction
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public decimal StartingPrice { get; set; }
        public decimal CurrentPrice { get; set; }
        public string? ImagePath { get; set; }
        public string Address { get; set; } = string.Empty;

        public DateTime? ApprovedAt { get; set; } // Datum schválení (start)
        public int DurationHours { get; set; }
        public bool IsApproved { get; set; } = false;
        public bool IsDeleted { get; set; } = false;

        // Minimální příhoz
        public bool IsPercentageStep { get; set; } // true = %, false = CZK
        public decimal MinStepValue { get; set; }

        // Relace
        public string SellerId { get; set; } = string.Empty;
        public ApplicationUser Seller { get; set; } = null!;
        public int CategoryId { get; set; }
        public Category Category { get; set; } = null!;
        public List<Bid> Bids { get; set; } = new();
    }
}
