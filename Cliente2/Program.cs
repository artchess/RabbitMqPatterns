using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RabbitMQ.Client;

namespace Client2
{
    class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Inicializando Publicador de mensajes RabbitMQ");
            Console.WriteLine();
            Console.WriteLine();

            var messageCount = 0;
            var menssageText = "";
            var sender = new RabbitSender();

            Console.WriteLine("Presiona enter para enviar un mensaje");
            while (true)
            {
                var key = Console.ReadKey();

                menssageText += key.KeyChar;

                if (key.Key == ConsoleKey.Enter)
                {
                    var message = $"Mensaje: {messageCount} - {menssageText}";
                    Console.WriteLine($"Enviando - {message}");
                    sender.Send(message);
                    messageCount++;
                    menssageText = "";
                }
            }
            
            Console.ReadLine();
        }
    }
}
