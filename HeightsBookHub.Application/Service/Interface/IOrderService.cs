using HeightsBookHub.Domain.DTOs;
using HeightsBookHub.Domain.Entities.SharedEntities;

namespace HeightsBookHub.Application.Service.Interface
{
    public interface IOrderService
    {
        Task<BaseResponse<OrderResponseDto>> PlaceOrderAsync(OrderRequestDTO orderDTO);
        Task<BaseResponse<OrderResponseDto>> GetOrderByIdAsync(string orderId);
    }
}
