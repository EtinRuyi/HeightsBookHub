using HeightsBookHub.Domain.Entities.SharedEntities;

namespace HeightsBookHub.Domain.Entities
{
    public class Book : BaseEntity
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }
        public string ISBN { get; set; }
        public string Publisher { get; set; }
        public DateTime PublishedDate { get; set; } = DateTime.UtcNow;
        public int TotalPageCount { get; set; }
        public int StockQuantity { get; set; }
        public ICollection<Cart> Carts { get; set; }
    }
}
