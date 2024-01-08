namespace HeightsBookHub.Application.Service.Interface
{
    public interface IRabbitMQService
    {
        void SendMessage(string queueName, string message);
        void ReceiveMessage(string queueName, Action<string> messageHandler);
    }
}
