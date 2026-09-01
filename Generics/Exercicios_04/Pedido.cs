using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicios_04
{
    internal class Pedido
    {
        public int Numero { get; set; }
        public double Valor { get; set; }

        public Pedido(int numero, double valor)
        {
            Numero = numero;
            Valor = valor;
        }
    }
}
