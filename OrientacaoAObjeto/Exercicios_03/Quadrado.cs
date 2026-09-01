using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicios_03
{
    internal class Quadrado : IForma
    {
        private double _lado;
        public Quadrado (double lado)
        {
            _lado = lado;
        }
        public double CalcularArea()
        {
            return _lado * _lado;
        }

        public void ExibirArea()
        {
            Console.WriteLine($"O quadrado {_lado}x{_lado} tem àrea {CalcularArea()}");
        }
    }
}
