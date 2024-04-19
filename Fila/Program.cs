using Azure.Messaging.ServiceBus;
using Microsoft.Azure.Amqp.Framing;
string connectionString = "Endpoint=sb://mensagens-unirv.servicebus.windows.net/;SharedAccessKeyName=RootManageSharedAccessKey;SharedAccessKey=01eFcbPQ6b7q2sfsebiVfuXtpw3hGvZKy+ASbOJlPLI=";
string fila = "notificacao_faturamento";

var client = new ServiceBusClient(connectionString);


ServiceBusSender sender = client.CreateSender(fila);
ServiceBusMessage message = new ServiceBusMessage("Japones Safado");
await sender.SendMessageAsync(message);


string connectionString = "Endpoint=sb://mensagens-unirv.servicebus.windows.net/;SharedAccessKeyName=RootManageSharedAccessKey;SharedAccessKey=01eFcbPQ6b7q2sfsebiVfuXtpw3hGvZKy+ASbOJlPLI=";
string fila = "notificar_expedicaoo";

var client = new ServiceBusClient(connectionString);


ServiceBusSender sender = client.CreateSender(fila);
ServiceBusMessage message = new ServiceBusMessage("Japones Safado");
await sender.SendMessageAsync(message);