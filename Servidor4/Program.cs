using System;

namespace Servidor4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inicializando procesador2 de Queue5 RabbitMQ");
            Console.WriteLine();
            Console.WriteLine();

            var queueProcessor = new RabbitConsumer(){Enabled = true};
            queueProcessor.Start();
            Console.ReadLine();
        }
    }
}
