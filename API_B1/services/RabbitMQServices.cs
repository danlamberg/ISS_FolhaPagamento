using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using System.Text;

namespace API_B.services;

public class RabbitMQService : BackgroundService
{
      protected override Task ExecuteAsync(CancellationToken stoppingToken)
  {
    ConnectionFactory factory = new ConnectionFactory
    {
        HostName = "localhost"
    };

    var connection = factory.CreateConnection();
    var channel = connection.CreateModel();

    var produtosConsumer = new EventingBasicConsumer(channel);
    produtosConsumer.Received += (ModuleHandle, message) =>
    {
        var body = message.Body.ToArray();
        var mensagem = Encoding.UTF8.GetString(body);
        Console.WriteLine($"Mensagem da fila 'Fila Folhas' {mensagem}");
    };

    channel.BasicConsume(
        queue: "Fila - Folhas",
        autoAck: true,
        consumer: produtosConsumer
    );

    return Task.CompletedTask;

  }
    
}