using System;
using System.Collections.Generic;
using System.Text;

namespace Eventos
{

    public class Pedido
    {
        public event EventHandler<PedidoEventArgs>? onCriarPedido; // Evento que será disparado quando o pedido for criado. Ele que acumula os metodos

        public void CriarPedido(string email, string telefone)
        {
            Console.WriteLine("Pedido criado com sucesso!");
            if (onCriarPedido != null)
                onCriarPedido(this, new PedidoEventArgs { Email = email, Telefone = telefone }); // Dispara o evento, chamando todos os métodos que estão inscritos nele.
        }
    }
}
