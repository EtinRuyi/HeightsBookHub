using HeightsBookHub.Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeightsBookHub.Domain.DTOs
{
    public class OrderResponseDto
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public int Quantity { get; set; }
        [ForeignKey("BookId")]
        public string BookId { get; set; }

        [ForeignKey("UserId")]
        public string UserId { get; set; }
        public OrderStatus OrderStatus { get; set; }
    }
}
