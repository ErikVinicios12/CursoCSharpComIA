 using System;
using System.Collections.Generic;
using System.Text;

namespace Eventos
{
    public class PedidoEventArgs : EventArgs // Classe para passar informações do evento para os métodos que estão inscritos nele.
    {
        public string? Email { get; set; }
        public string? Telefone { get; set; }
    }
}
