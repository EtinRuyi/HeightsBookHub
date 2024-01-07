using HeightsBookHub.Application.Service.Interface;
using HeightsBookHub.Domain.DTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HeightsBookHub.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IOrderService _orderService;

        public OrderController(IOrderService orderService)
        {
            _orderService = orderService;
        }

        [HttpPost("place-order")]
        public async Task<IActionResult> PlaceOrder([FromBody] OrderRequestDTO orderDTO)
        {
            var result = await _orderService.PlaceOrderAsync(orderDTO);
            return StatusCode(result.StatusCode, result);
        }

        [HttpGet("get-order/{orderId}")]
        public async Task<IActionResult> GetOrderById(string orderId)
        {
            var result = await _orderService.GetOrderByIdAsync(orderId);
            return StatusCode(result.StatusCode, result);
        }
    }
}
