using System;
using System.Collections.Generic;
using System.Text;

namespace Arrays
{
    public class Calculadora
    {
        // Com params é possivel inserir valores separando por virgula sem precisar criar variável
        public static int Somar(params int[] valores)
        {
            var soma = 0;
            foreach (int valor in valores)
            {
                soma += valor;
            }
            return soma;
        }
    }
}
