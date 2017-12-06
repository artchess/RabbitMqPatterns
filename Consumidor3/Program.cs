using System;

namespace Consumidor3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inicializando Consumidor3 de Queue4 RabbitMQ");
            Console.WriteLine();
            Console.WriteLine();

            var queueProcessor = new RabbitConsumer(){Enabled = true};
            queueProcessor.Start();
            Console.ReadLine();
        }
    }
}
