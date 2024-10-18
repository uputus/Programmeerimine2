namespace KooliProjekt.Data
{
    public class Investment
    {
        public int InvestmentID { get; set; }
        public int AssetID { get; set; } // Foreign key
        public DateTime Date { get; set; }
        public float Quantity { get; set; }
        public float Value { get; set; }
        public float MoneyInvested { get; set; }
        public float CashBalance { get; set; }
    }
}
