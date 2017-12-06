using System;

namespace Servidor2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inicializando Procesador2 de Queue RabbitMQ");
            Console.WriteLine();
            Console.WriteLine();

            var queueProcessor = new ConsumidorDos(){Enabled = true};
            queueProcessor.Start();
            Console.ReadLine();
        }
    }
}
