using RabbitMQ.Client;

namespace RabbitMqHelper
{
    public class ConnectionHelper
    {
        public IConnection Connection()
        {
            ConnectionFactory connectionFactory = new ConnectionFactory()
            {
                HostName = "localhost"
            };
            return connectionFactory.CreateConnection();
        }
    }
}
