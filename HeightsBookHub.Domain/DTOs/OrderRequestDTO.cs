using HeightsBookHub.Domain.Enums;
using System.ComponentModel.DataAnnotations.Schema;

namespace HeightsBookHub.Domain.DTOs
{
    public class OrderRequestDTO
    {
        public int Quantity { get; set; }
        [ForeignKey("BookId")]
        public string BookId { get; set; }

        [ForeignKey("UserId")]
        public string UserId { get; set; }
        public OrderStatus OrderStatus { get; set; }
    }
}
