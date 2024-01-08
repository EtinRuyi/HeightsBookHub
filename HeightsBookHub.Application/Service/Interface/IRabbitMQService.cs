using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeightsBookHub.Application.Service.Interface
{
    public interface IRabbitMQService
    {
        void SendMessage(string queueName, string message);
        void ReceiveMessage(string queueName, Action<string> messageHandler);
    }
}
