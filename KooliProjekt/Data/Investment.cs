using System.ComponentModel.DataAnnotations;

namespace KooliProjekt.Data
{
    public class Investment
    {
        [Key]
        public int InvestmentID { get; set; }

        public int AssetID { get; set; }
        public required Asset Asset { get; set; }

        [Required]
        public DateTime Date { get; set; }

        public float Quantity { get; set; }
        public float Value { get; set; }
        public float MoneyInvested { get; set; }
        public float CashBalance { get; set; }
    }

}
