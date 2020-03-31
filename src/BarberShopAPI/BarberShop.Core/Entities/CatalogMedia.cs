using BarberShop.Core.Common;

namespace BarberShop.Core.Entities
{
    public class CatalogMedia : DictionaryEntity
    {
        public bool IsPhoto { get; set; }
        public bool IsVideo { get; set; }
        public Catalog Catalog { get; set; }
        public int CatalogID { get; set; }
        public int Likes { get; set; }
    }
}