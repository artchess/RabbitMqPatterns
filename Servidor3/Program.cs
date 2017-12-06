using System;

namespace Servidor3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inicializando procesador1 de Queue4 RabbitMQ");
            Console.WriteLine();
            Console.WriteLine();

            var queueProcessor = new RabbitConsumer(){Enabled = true};
            queueProcessor.Start();
            Console.ReadLine();
        }
    }
}
