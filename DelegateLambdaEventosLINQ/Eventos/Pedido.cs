using System;
using System.Collections.Generic;
using System.Text;

namespace Eventos
{
    public delegate void PedidoEventHandler(); // Delegate que representa o método que será chamado quando o evento for disparado.

    public class Pedido
    {
        public event PedidoEventHandler? onCriarPedido; // Evento que será disparado quando o pedido for criado. Ele que acumula os metodos

        public void CriarPedido()
        {
            Console.WriteLine("Pedido criado com sucesso!");
            if (onCriarPedido != null)
                onCriarPedido(); // Dispara o evento, chamando todos os métodos que estão inscritos nele.
        }
    }
}
