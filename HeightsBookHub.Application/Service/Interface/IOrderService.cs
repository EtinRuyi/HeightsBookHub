using HeightsBookHub.Domain.DTOs;
using HeightsBookHub.Domain.Entities.SharedEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeightsBookHub.Application.Service.Interface
{
    public interface IOrderService
    {
        Task<BaseResponse<OrderResponseDto>> PlaceOrderAsync(OrderRequestDTO orderDTO);
        Task<BaseResponse<OrderResponseDto>> GetOrderByIdAsync(string orderId);
    }
}
