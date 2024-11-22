using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace KooliProjekt.Data
{
    public class Asset
    {
        public int AssetID { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        // Välisvõti InvestmentClass klassi jaoks
        public int ClassID { get; set; }
        public InvestmentClass InvestmentClass { get; set; }

        [Required]
        [StringLength(50)]
        public string AssetType { get; set; }

        public string AssetDetails { get; set; }

        // Seos Investment'itega
        public ICollection<Investment> Investments { get; set; }

        // Seos Transaction'itega
        public ICollection<Transaction> Transactions { get; set; }
    }
}
