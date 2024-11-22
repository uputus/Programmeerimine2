namespace KooliProjekt.Data
{
    public class ProgramBase
    {
        public static void Main(string[] args)
        {
            // Example usage
            Asset asset = new Asset { AssetID = 1, Name = "Real Estate", ClassID = 101, AssetType = "Property", AssetDetails = "Details about the asset" };
            Transaction transaction = new Transaction { TransactionID = 1, AssetID = 1, Date = DateTime.Now, Quantity = 10.0f, TransactionValue = 100000.0f, TransactionType = "Buy" };
            Investment investment = new Investment { InvestmentID = 1, AssetID = 1, Date = DateTime.Now, Quantity = 10.0f, Value = 100000.0f, MoneyInvested = 50000.0f, CashBalance = 20000.0f };
            Portfolio portfolio = new Portfolio { PortfolioID = 1, Date = DateTime.Now, TotalValue = 120000.0f, ChangeSinceLastMonth = 5000.0f, ChangeSinceStart = 15000.0f };

            Console.WriteLine($"Asset: {asset.Name}, Transaction Value: {transaction.TransactionValue}, Investment Value: {investment.Value}, Portfolio Total: {portfolio.TotalValue}");
        }
    }
}