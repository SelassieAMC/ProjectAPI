using BarberShopAPI.Core.Common;

namespace BarberShopAPI.Core.Entities
{
    public class CatalogMedia : DictionaryEntity
    {
        public bool isPhoto { get; set; }
        public bool isVideo { get; set; }
        public Catalog Catalog { get; set; }
        public int CatalogID { get; set; }
        public int Likes { get; set; }
    }
}