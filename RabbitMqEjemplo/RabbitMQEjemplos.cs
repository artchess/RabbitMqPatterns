using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RabbitMQ.Client;

namespace RabbitMqEjemplo
{
    public class RabbitMQEjemplos
    {
        private const string HostName = "localhost";
        private const string UserName = "guest";
        private const string Password = "guest";

        private const string QueueOneName = "Queue1";
        private const string ExchangeName = ""; // exchange default

        static void Main(string[] args)
        {
            //CreandoQueueExchangeDinamicamente();
            EnvioMensajeExchangeDefault();
        }

        private static void EnvioMensajeExchangeDefault()
        {
            Console.WriteLine("Envio de mensaje a Exchange default en RabbitMQ");
            Console.WriteLine();
            Console.WriteLine();

            var connectionFactory = new ConnectionFactory {HostName = HostName, UserName = UserName, Password = Password};
            var connection = connectionFactory.CreateConnection();
            var model = connection.CreateModel();

            model.QueueDeclare(QueueOneName, false, false, false, null);
            Console.WriteLine($"Queue {ExchangeName} creada!");

            var properties = model.CreateBasicProperties();
            properties.Persistent = false;

            //Serialize
            byte[] messageBuffer = Encoding.Default.GetBytes("Este es mi mensaje");

            //Send message
            model.BasicPublish(ExchangeName, QueueOneName, properties, messageBuffer);

            Console.WriteLine("Mensaje enviado!");
            Console.ReadLine();
        }

        private static void CreandoQueueExchangeDinamicamente()
        {
            Console.WriteLine("Creando un Exhange y Queue dinamicamente en RabbitMQ");
            Console.WriteLine();
            Console.WriteLine();

            var connFactory = new ConnectionFactory()
            {
                HostName = HostName,
                UserName = UserName,
                Password = Password
            };

            var connection = connFactory.CreateConnection();
            var model = connection.CreateModel();

            model.QueueDeclare("MiQueue", true, false, false, null);
            Console.WriteLine("Queue creada!");

            model.ExchangeDeclare("MiExchange", ExchangeType.Topic);
            Console.WriteLine("Exchange creado!");

            model.QueueBind("MiQueue", "MiExchange", "carros");
            Console.WriteLine("Exchange y Queue enlazados!");

            Console.ReadLine();
        }
    }
}
