using System;

namespace RabbitMq_FirstClient
{
    class FirstClientProgram
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Yazmaya Başla :");
            Listen();
            while (true)
            {
                new RabbitMqHelper.PublisherHelper("firstClient", Console.ReadLine());
            }
            
        }
        public static void Listen()
        {
          new RabbitMqHelper.ConsumerHelper("secondClient");
        }
    }
}
