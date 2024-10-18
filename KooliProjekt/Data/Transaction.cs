namespace KooliProjekt.Data
{
    public class Transaction
    {
        public int TransactionID { get; set; }
        public int AssetID { get; set; } // Foreign key
        public DateTime Date { get; set; }
        public float Quantity { get; set; }
        public float TransactionValue { get; set; }
        public string TransactionType { get; set; }
    }
}
