using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;


namespace WebApiExample.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PedidoController : ControllerBase
    {
        [HttpPost]
        public IActionResult ReceberPedido([FromBody] Pedido pedido)
        {
            // Simulando o envio para a fila de faturamento
            EnviarParaFilaFaturamento(pedido);

            // Simulando o envio para a fila de expedição
            EnviarParaFilaExpedicao(pedido);

            return Ok();
        }

        private void EnviarParaFilaFaturamento(Pedido pedido)
        {
            // Aqui você configuraria o cliente de mensageria e enviaria a mensagem
            Console.WriteLine("Enviando para a fila de faturamento...");
        }

        private void EnviarParaFilaExpedicao(Pedido pedido)
        {
            // Aqui você configuraria o cliente de mensageria e enviaria a mensagem
            Console.WriteLine("Enviando para a fila de expedição...");
        }
    }
}