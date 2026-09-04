using System;
using System.Collections.Generic;
using System.Text;

namespace Eventos
{
    public static class SMS
    {
        public static void EnviarSMS(object? sender, EventArgs e)
        {
            Console.WriteLine("Enviando SMS de confirmação do pedido...");
        }
    }
}
