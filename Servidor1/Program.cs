using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servidor1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inicializando Procesador1 de Queue RabbitMQ");
            Console.WriteLine();
            Console.WriteLine();

            var queueProcessor = new ConsumidorUno(){Enabled = true};
            queueProcessor.Start();
            Console.ReadLine();
        }
    }
}
