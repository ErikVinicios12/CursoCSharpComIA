using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicios_03
{
    public class Pessoa
    {
        protected string? _nome { get; set; }

        public Pessoa(string? nome)
        {
            _nome = nome;
        }

        public override string ToString()
        {
            return _nome;
        }
    }
}
