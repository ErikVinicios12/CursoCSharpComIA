using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicios_03
{
    public class Triangulo : IForma
    {
        private double _base;
        private double _altura;
        public Triangulo(double _base, double altura) {
            this._base = _base;
            _altura = altura;
        }

        public double CalcularArea()
        {
            return (_base * _altura) / 2;
        }

        public void ExibirArea()
        {
            Console.WriteLine($"O triângulo de base {_base} e altura {_altura} tem àrea {CalcularArea()}");
        }
    }
}
