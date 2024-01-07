using HeightsBookHub.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeightsBookHub.Persistence.Repository.Interface
{
    public interface IOrderRepository
    {
        Task<Order> PlaceOrderAsync(Order order);
        Task<Order> GetOrderByIdAsync(string orderId);
    }
}
