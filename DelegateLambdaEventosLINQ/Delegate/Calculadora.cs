using System;
using System.Collections.Generic;
using System.Text;

namespace Delegate
{
    internal class Calculadora
    {
        public static double Somar(double x, double y)
        {
            return x + y;
        }
        public static double ExibirSoma(double x, double y)
        {
            double resultado = Somar(x, y);
            Console.WriteLine($"Resultado da soma: {resultado}");
            return resultado;
        }
        public static double Subtrair(double x, double y)
        {
            return x - y;
        }
        public static double ExibirSubtracao(double x, double y)
        {
            double resultado = Subtrair(x, y);
            Console.WriteLine($"Resultado da subtração: {resultado}");
            return resultado;
        }
        public static double Multiplicar(double x, double y)
        {
            return x * y;
        }
        public static double Dividir(double x, double y)
        {
            if (y == 0)
            {
                throw new DivideByZeroException("Não é possível dividir por zero.");
            }
            return x / y;
        }
    }
}
