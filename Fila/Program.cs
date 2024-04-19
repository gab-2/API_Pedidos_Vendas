using Azure.Messaging.ServiceBus;
using Microsoft.Azure.Amqp.Framing;
string connectionString = "Endpoint=sb://mensagens-unirv.servicebus.windows.net/;SharedAccessKeyName=RootManageSharedAccessKey;SharedAccessKey=01eFcbPQ6b7q2sfsebiVfuXtpw3hGvZKy+ASbOJlPLI=";

string fila = "notificacao_faturamento";
var client = new ServiceBusClient(connectionString);

ServiceBusSender sender = client.CreateSender(fila);
ServiceBusMessage message = new ServiceBusMessage("Notificação de Faturamento");
await sender.SendMessageAsync(message);


string fila2 = "notificar_expedicaoo";
var client2 = new ServiceBusClient(connectionString);

ServiceBusSender sender2 = client2.CreateSender(fila2);
ServiceBusMessage message2 = new ServiceBusMessage("Noficação de Expedição");
await sender.SendMessageAsync(message2);