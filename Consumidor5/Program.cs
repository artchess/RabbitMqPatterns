using System;

namespace Consumidor5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Incializando consumidor5 de Queue6 de RabbitMQ");
            Console.WriteLine();
            Console.WriteLine();

            var queueProcessor = new RabbitConsumer(){Enabled = true};
            queueProcessor.Start();
            Console.ReadLine();
        }
    }
}
