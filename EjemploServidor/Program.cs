using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inicializando procesador de Queue2 de RabbitMQ");
            Console.WriteLine();
            Console.WriteLine();

            var queueProcessor = new RabbitConsumer(){Enabled = true};
            queueProcessor.Start();
            Console.ReadLine();
        }
    }
}
