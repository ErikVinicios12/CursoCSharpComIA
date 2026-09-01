using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicios_03
{
    public class Circulo : IForma
    {
        private double _raio;
        public Circulo(double raio)
        {
            _raio = raio;
        }

        public double CalcularArea()
        {
            return Math.PI * _raio * _raio;
        }

        public void ExibirArea()
        {
            Console.WriteLine($"O Circulo de raio {_raio} possui àrea {CalcularArea()}");
        }
    }
}
