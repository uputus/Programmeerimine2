using System.ComponentModel.DataAnnotations;

namespace KooliProjekt.Data
{
    public class Portfolio
    {
        public int PortfolioID { get; set; }

        [Required]
        public DateTime Date { get; set; }

        public float TotalValue { get; set; }

        public float ChangeSinceLastMonth { get; set; }

        public float ChangeSinceStart { get; set; }
    }
}

