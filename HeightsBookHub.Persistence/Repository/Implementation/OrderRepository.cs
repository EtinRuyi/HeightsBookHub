using HeightsBookHub.Domain.Entities;
using HeightsBookHub.Persistence.DbContext;
using HeightsBookHub.Persistence.Repository.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeightsBookHub.Persistence.Repository.Implementation
{
    public class OrderRepository : IOrderRepository
    {
        private readonly HeightsBHDbContext _dbContext;

        public OrderRepository(HeightsBHDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Order> PlaceOrderAsync(Order order)
        {
            _dbContext.Orders.Add(order);
            await _dbContext.SaveChangesAsync();
            return order;
        }

        public async Task<Order> GetOrderByIdAsync(string orderId)
        {
            return await _dbContext.Orders.FirstOrDefaultAsync(o => o.Id == orderId);
        }
    }
}
