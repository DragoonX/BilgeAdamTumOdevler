using System;

namespace RabbitMq_SecondClient
{
    class SecondClientProgram
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Yazmaya Başla :");
            Listen();
            while (true)
            {
                new RabbitMqHelper.PublisherHelper("secondClient", Console.ReadLine());
            }

        }
        public static void Listen()
        {
          new RabbitMqHelper.ConsumerHelper("firstClient");
        }
    }
}
