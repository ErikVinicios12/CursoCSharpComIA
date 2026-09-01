using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicios_05
{
    internal class Aluno
    {
        private string _nome;
        private int _idade;
        private string _sexo;
        public Aluno(string nome, int idade, string sexo)
        {
            _nome = nome;
            _idade = idade;
            _sexo = sexo;
        }

        public void Exibir ()
        {
            Console.WriteLine($"Aluno: {_nome} - {_idade} anos - {_sexo}");
        }
    }
}
