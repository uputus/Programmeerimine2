using System.Runtime.CompilerServices;

namespace KooliProjekt.Data
{
    public class Asset
    {
        public int AssetID { get; set; }
        public string Name { get; set; }
        public int ClassID { get; set; } // Foreign key
        public string AssetType { get; set; }
        public string AssetDetails { get; set; }

        public Asset() 
        {
            Lines = new List
        }
    }
}
