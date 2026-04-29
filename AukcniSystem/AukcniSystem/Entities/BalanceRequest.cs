using AukcniSystem.Data;

namespace AukcniSystem.Entities
{
    public class BalanceRequest
    {
        public int Id { get; set; }
        public decimal Amount { get; set; }
        public DateTime RequestedAt { get; set; } = DateTime.Now;
        public bool? IsApproved { get; set; } // null = čeká, true = schváleno, false = zamítnuto
        public DateTime? HandledAt { get; set; }

        // Relace
        public string UserId { get; set; } = string.Empty;
        public ApplicationUser User { get; set; } = null!;
    }
}
