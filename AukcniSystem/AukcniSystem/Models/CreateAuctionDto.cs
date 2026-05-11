using System.ComponentModel.DataAnnotations;

namespace AukcniSystem.Models
{
    public class CreateAuctionDto
    {
        [Required(ErrorMessage = "Zadej název aukce")]
        [StringLength(100, ErrorMessage = "Název je příliš dlouhý")]
        public string Title { get; set; } = string.Empty;

        [Required(ErrorMessage = "Zadej popis")]
        public string Description { get; set; } = string.Empty;

        [Range(1, 9999999, ErrorMessage = "Vyvolávací cena musí být alespoň 1 Kč")]
        public decimal StartingPrice { get; set; }

        [Required(ErrorMessage = "Zadej adresu")]
        public string Address { get; set; } = string.Empty;

        [Range(1, 720, ErrorMessage = "Doba aukce musí být mezi 1 a 720 hodinami")]
        public int DurationHours { get; set; }

        [Range(1, int.MaxValue, ErrorMessage = "Vyber platnou kategorii")]
        public int CategoryId { get; set; }

        public bool IsPercentageStep { get; set; }

        [Range(0.01, 9999999, ErrorMessage = "Minimální příhoz musí být větší než 0")]
        public decimal MinStepValue { get; set; }

        public string? ImagePath { get; set; }
    }
}