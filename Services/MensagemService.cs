public class MensagemService : IMensagemService
{
    public void EnviarMensagemFaturamento(object mensagemFaturamento)
    {
        // Implementação do envio de mensagem de faturamento
        Console.WriteLine("Mensagem de faturamento enviada");
    }

    public void EnviarMensagemExpedicao(object mensagemExpedicao)
    {
        // Implementação do envio de mensagem de expedição
        Console.WriteLine("Mensagem de expedição enviada");
    }
}
