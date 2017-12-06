using System;

namespace Publicador4
{
    class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Inicializando publicador4 de RabbitMQ");
            Console.WriteLine();
            Console.WriteLine();

            var messageCount = 0;
            var menssageText = "";
            var sender = new RabbitSender();

            Console.WriteLine("Press enter key to send a message");
            while (true)
            {
                var key = Console.ReadKey();

                if (key.Key != ConsoleKey.Enter)
                {
                    menssageText += key.KeyChar;
                    continue;
                }

                var message = $"Mensaje: {messageCount} - {menssageText}";
                Console.WriteLine("Enviando - {0}", message);
                    
                var response = sender.Send(message, new TimeSpan(0, 0, 1, 0));

                Console.WriteLine("Respuesta - {0}", response);
                messageCount++;
                menssageText = "";
            }
            
            Console.ReadLine();
        }
    }
}
