using System.ComponentModel.DataAnnotations;

namespace KooliProjekt.Data
{
    public class InvestmentClass
    {
        public int ClassID { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        // Seos Asset'itega
        public ICollection<Asset> Assets { get; set; }
    }

}
