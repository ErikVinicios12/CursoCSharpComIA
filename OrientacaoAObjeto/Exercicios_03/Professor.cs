using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicios_03
{
    public class Professor : Pessoa
    {
        public Professor(string? nome) : base(nome)
        {
        }

        public void Explicar()
        {
            Console.WriteLine($"{_nome} explicando...");
        }
    }
}
