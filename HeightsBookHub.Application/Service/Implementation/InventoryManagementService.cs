using HeightsBookHub.Application.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeightsBookHub.Application.Service.Implementation
{
    public class InventoryManagementService
    {
        private readonly IRabbitMQService _rabbitMQService;

        public InventoryManagementService(IRabbitMQService rabbitMQService)
        {
            _rabbitMQService = rabbitMQService;

            _rabbitMQService.ReceiveMessage("InventoryQueue", HandleInventoryMessage);
        }

        private void HandleInventoryMessage(string message)
        {
            Console.WriteLine($"Received message: {message}");

        }
    }

}
