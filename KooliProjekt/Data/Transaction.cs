using System.ComponentModel.DataAnnotations;

    public class Transaction
    {
        public int TransactionID { get; set; }

        // Välisvõti Asset klassi jaoks
        
        public int AssetID { get; set; }
        public required Asset Asset { get; set; }
        public int ClassID { get; set; }
        [Required]
        public DateTime Date { get; set; }
        public float Quantity { get; set; }
        public float TransactionValue { get; set; }

        [Required]
        [StringLength(50)]
        public required string TransactionType { get; set; }
    }
}
