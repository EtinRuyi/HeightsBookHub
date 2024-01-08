using HeightsBookHub.Domain.Entities;

namespace HeightsBookHub.Persistence.Repository.Interface
{
    public interface IOrderRepository
    {
        Task<Order> PlaceOrderAsync(Order order);
        Task<Order> GetOrderByIdAsync(string orderId);
    }
}
