﻿using HeightsBookHub.Domain.Entities.SharedEntities;
using HeightsBookHub.Domain.Enums;
using System.ComponentModel.DataAnnotations.Schema;

namespace HeightsBookHub.Domain.Entities
{
    public class Order : BaseEntity
    {
        public int Quantity { get; set; }
        [ForeignKey("Book")]
        public string BookId { get; set; } = Guid.NewGuid().ToString();
        public Book Book { get; set; }
        [ForeignKey("User")]
        public string UserId { get; set; } = Guid.NewGuid().ToString();
        public User User { get; set; }
        public OrderStatus OrderStatus { get; set; }
    }
}