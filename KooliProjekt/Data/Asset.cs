using KooliProjekt.Data;
using System.ComponentModel.DataAnnotations;

public class Asset
{
    [Key]
    public int AssetID { get; set; }

    [Required]
    [StringLength(100)]
    public required string Name { get; set; }

    public int ClassID { get; set; }

    // Foreign Key
    // Foreign Key
    public int SelectedClassID { get; set; } // Kontrolli, kas see on õigesti määratud
    public required InvestmentClass InvestmentClass { get; set; }

    [Required]
    [StringLength(50)]
    public required string AssetType { get; set; }

    public required string AssetDetails { get; set; }



    // Navigation properties
    public ICollection<Investment> Investments { get; set; } = new List<Investment>();
    public ICollection<Transaction> Transactions { get; set; } = new List<Transaction>();
}
