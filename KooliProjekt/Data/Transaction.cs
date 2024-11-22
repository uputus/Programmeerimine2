using System.ComponentModel.DataAnnotations;

namespace KooliProjekt.Data
{
    public class Transaction
    {
        public int TransactionID { get; set; }

        // Välisvõti Asset klassi jaoks
        public int AssetID { get; set; }
        public Asset Asset { get; set; }

        [Required]
        public DateTime Date { get; set; }

        public float Quantity { get; set; }

        public float TransactionValue { get; set; }

        [Required]
        [StringLength(50)]
        public string TransactionType { get; set; }
    }
}
