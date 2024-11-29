using System.ComponentModel.DataAnnotations;

namespace KooliProjekt.Data
{
    public class Portfolio
    {
        [Key]
        public int PortfolioID { get; set; }

        [Required]
        public DateTime Date { get; set; }

        public float TotalValue { get; set; }
        public float ChangeSinceLastMonth { get; set; }
        public float ChangeSinceStart { get; set; }

        // Navigation property (nt kui oleks seos investoritega)
        public ICollection<Investment> Investments { get; set; } = new List<Investment>();
    }

}

