﻿using HeightsBookHub.Domain.Entities.SharedEntities;
using HeightsBookHub.Domain.Enums;
using System.ComponentModel.DataAnnotations.Schema;

namespace HeightsBookHub.Domain.Entities
{
    public class Order : BaseEntity
    {
        public int Quantity { get; set; }
        [ForeignKey("BookId")]
        public string BookId { get; set; }

        [ForeignKey("UserId")]
        public string UserId { get; set; }
        public OrderStatus OrderStatus { get; set; }
    }
}
