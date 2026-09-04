using System;
using System.Collections.Generic;
using System.Text;

namespace Eventos
{
    public static class Email
    {
        public static void EnviarEmail(object? sender, EventArgs e)
        {
            Console.WriteLine("Enviando email de confirmação do pedido...");
        }
    }
}
