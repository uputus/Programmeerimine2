using System.ComponentModel.DataAnnotations;

namespace KooliProjekt.Data
{
    public class Investment
    {
        public int InvestmentID { get; set; }

        // Välisvõti Asset klassi jaoks
        public int AssetID { get; set; }
        public Asset Asset { get; set; }

        [Required]
        public DateTime Date { get; set; }

        public float Quantity { get; set; }

        public float Value { get; set; }

        public float MoneyInvested { get; set; }

        public float CashBalance { get; set; }
    }
}
