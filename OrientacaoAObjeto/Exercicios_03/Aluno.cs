using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicios_03
{
    public class Aluno : Pessoa
    {
        public Aluno(string? nome) : base(nome)
        {
        }

        public void Estudar() {
            Console.WriteLine($"{_nome} estudando...");
        }
    }
}
