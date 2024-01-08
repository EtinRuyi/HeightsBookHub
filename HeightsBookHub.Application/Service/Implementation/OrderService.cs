using HeightsBookHub.Application.Service.Interface;
using HeightsBookHub.Domain.DTOs;
using HeightsBookHub.Domain.Entities.SharedEntities;
using HeightsBookHub.Domain.Entities;
using HeightsBookHub.Persistence.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HeightsBookHub.Application.Service.Implementation
{
    public class OrderService : IOrderService
    {
        private readonly IOrderRepository _orderRepository;
        //private readonly IRabbitMQService _rabbitMQService;

        public OrderService(IOrderRepository orderRepository /*IRabbitMQService rabbitMQService*/)
        {
            _orderRepository = orderRepository;
            //_rabbitMQService = rabbitMQService;
        }

        public async Task<BaseResponse<OrderResponseDto>> PlaceOrderAsync(OrderRequestDTO orderDTO)
        {
            try
            {
                var order = new Order
                {
                    //Id = orderDTO.Id,
                    UserId = orderDTO.UserId,
                    BookId = orderDTO.BookId,
                    Quantity = orderDTO.Quantity,
                    OrderStatus = orderDTO.OrderStatus,
                };

                var placedOrder = await _orderRepository.PlaceOrderAsync(order);

                var placedOrderDTO = new OrderResponseDto
                {
                    Id = placedOrder.Id,
                    UserId = placedOrder.UserId,
                    BookId = placedOrder.BookId,
                    Quantity = placedOrder.Quantity,
                    OrderStatus = placedOrder.OrderStatus,
                };
                //_rabbitMQService.SendMessage("InventoryQueue", $"OrderProcessed: {placedOrder.Id}");

                return BaseResponse<OrderResponseDto>.Success(placedOrderDTO, "Order placed successfully", 200); 
            }
            catch (Exception ex)
            {
                return BaseResponse<OrderResponseDto>.Failed(false, ex.Message, 500, new List<string> { ex.StackTrace });
            }
        }

        public async Task<BaseResponse<OrderResponseDto>> GetOrderByIdAsync(string orderId)
        {
            try
            {
                var order = await _orderRepository.GetOrderByIdAsync(orderId);

                if (order == null)
                    return BaseResponse<OrderResponseDto>.Failed(false, "Order not found", 404, new List<string> { "Order not found" });

                var orderDTO = new OrderResponseDto
                {
                    Id = order.Id,
                    UserId = order.UserId,
                    BookId = order.BookId,
                    Quantity = order.Quantity,
                    OrderStatus = order.OrderStatus,
                };

                return BaseResponse<OrderResponseDto>.Success(orderDTO, "Order retrieved successfully", 200);
            }
            catch (Exception ex)
            {
                return BaseResponse<OrderResponseDto>.Failed(false, ex.Message, 500, new List<string> { ex.StackTrace });
            }
        }
    }
}
