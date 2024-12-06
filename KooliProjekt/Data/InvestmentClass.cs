using System.ComponentModel.DataAnnotations;

namespace KooliProjekt.Data
{
    public class InvestmentClass
    {
        [Key]
        public int ClassID { get; set; }

        [Required]
        public required string Name { get; set; }

        // Navigation property
        public ICollection<Asset> Assets { get; set; } = new List<Asset>();

        public required string Description { get; set; }

        // AssetID (Dropdown jaoks)
        public int? AssetID { get; set; }

        // ClassID (Dropdown jaoks)
        public int? SelectedClassID { get; set; }


    }

}


